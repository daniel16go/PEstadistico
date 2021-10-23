using System;
using AutoMapper;
using Hangfire;
using Hangfire.MemoryStorage;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Infrastructure.Mappings;
using Productivo.Infrastructure.Register;
using Productivo.Web.Models;
using Rotativa.AspNetCore;

namespace Productivo.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            // Configuracion Automapper
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            // Obligar acceso a controladores logueado
            services.AddMvc(options =>
            {
                services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

                var policy = new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser()
                .Build();
                options.Filters.Add(new AuthorizeFilter(policy));
            }).AddXmlSerializerFormatters();
            //

            //Autorizacion Basada en Claims(Restricciones a nivel de funciones) para los usuarios
            services.AddAuthorization(options =>
            {
                //Policy una sola validacion de permiso a funcion
                options.AddPolicy("DeleteRolePolicy",
                    policy => policy.RequireClaim("Eliminar Rol"));

                //Policy dos validaciones 1.permiso a funcion y 2. de rol o solo de super administrador
                options.AddPolicy("EditRolePolicy",
                    policy => policy.RequireAssertion(context => context.User.IsInRole("Admin") &&
                    context.User.HasClaim(claim => claim.Type == "Actualizar Rol" && claim.Value == "true") ||
                    context.User.IsInRole("Super Admin")));

                //Policy una sola validacion de rol
                options.AddPolicy("AdminRolePolicy",
                   policy => policy.RequireRole("Admin"));
            });
            //

            //Autorizacion Basada en Roles(Restricciones a nivel de roles) para los usuarios
            services.AddAuthorization(options =>
            {
                //Policy una sola validacion de permiso a Role
                options.AddPolicy("SUPERADMIN",
                    policy => policy.RequireRole("Super Admin")
                    );

                //Policy una sola validacion de permiso a Role
                options.AddPolicy("OPERATIVE",
                    policy => policy.RequireRole("Operario", "Test", "Supervisor")
                    );

                options.AddPolicy("ALL",
                    policy => policy.RequireRole("Operario", "Test", "Supervisor", "Super Admin")
                    );

            });
            //

            services.AddSingleton(Configuration);

            //Injection Dependency Productivo DB
            IoCRegister.AddRegistration(services);

            services.AddDbContext<ProductivoContext>(options
               => options.UseMySQL(Configuration.GetConnectionString("ProductivoConnection"), x => x.MigrationsAssembly("Productivo.Core")));

            services.Configure<SmartSettings>(Configuration.GetSection(SmartSettings.SectionName));

            services.AddSingleton(s => s.GetRequiredService<IOptions<SmartSettings>>().Value);

            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            //services.AddIdentity<IdentityUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = false)
            //.AddRoleManager<RoleManager<IdentityRole>>()


            services.AddTransient<IEmailSender, EmailSender>();

            services.AddControllersWithViews();

            services.AddRazorPages();

            var timeout = "5";
            double SessionTimeout = Double.Parse(timeout);

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Account/Login";
                options.LogoutPath = "/Account/Logout";
                options.AccessDeniedPath = "/Account/AccessDenied";
                options.ExpireTimeSpan = TimeSpan.FromMinutes(SessionTimeout);
            });

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(SessionTimeout);
            });

            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.Password.RequiredLength = 8;
                options.Password.RequiredUniqueChars = 3;
            }).AddEntityFrameworkStores<ProductivoContext>();

            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequiredLength = 8;
                options.Password.RequiredUniqueChars = 3;
            });

            services.AddHangfire(config =>
                config.SetDataCompatibilityLevel(CompatibilityLevel.Version_170)
                .UseSimpleAssemblyNameTypeSerializer()
                .UseDefaultTypeSerializer()
                .UseMemoryStorage());

            services.AddHangfireServer();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    "default",
                    "{controller=Account}/{action=Login}/{id?}");
                endpoints.MapRazorPages();
            });

            //PDF Generator Path
            RotativaConfiguration.Setup(env.WebRootPath, "..\\wwwroot\\Rotativa\\Windows\\");

            app.UseHangfireDashboard();
        }
    }
}
