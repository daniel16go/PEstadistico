using Microsoft.Extensions.DependencyInjection;
using Productivo.Core.Interfaces;
using Productivo.Infrastructure.Helpers;
using Productivo.Infrastructure.Interfaces;
using Productivo.Infrastructure.Repositories;
using Productivo.Infrastructure.Services;

namespace Productivo.Infrastructure.Register
{
    public static class IoCRegister
    {
        public static IServiceCollection AddRegistration(this IServiceCollection services)
        {
            AddRegisterServices(services);
            AddRegisterRespositories(services);
            return services;
        }

        private static IServiceCollection AddRegisterServices(this IServiceCollection services)
        {
            services.AddTransient<ICompanyService, CompanyService>();
            return services;
        }

        private static IServiceCollection AddRegisterRespositories(this IServiceCollection services)
        {
            services.AddTransient<ICompanyRepository, CompanyRepository>();
            services.AddTransient<IPlanRepository, PlanRepository>();
            services.AddTransient<IAreaRepository, AreaRepository>();
            services.AddTransient<IBankRepository, BankRepository>();
            services.AddTransient<IBrandRepository, BrandRepository>();
            services.AddTransient<ICommImportRepository, CommImportRepository>();
            services.AddTransient<ICountryRepository, CountryRepository>();
            services.AddTransient<IContainerRepository, ContainerRepository>();
            services.AddTransient<IContainerTypeRepository, ContainerTypeRepository>();
            services.AddTransient<ICurrencyRepository, CurrencyRepository>();
            services.AddTransient<ICustomsAgencyRepository, CustomsAgencyRepository>();

            services.AddTransient<IDimensionRepository, DimensionRepository>();
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<IEmployeeTypeRepository, EmployeeTypeRepository>();
            services.AddTransient<IFinishRepository, FinishRepository>();
            services.AddTransient<IFinishPortRepository, FinishPortRepository>();
            services.AddTransient<IImportFileRepository, ImportFileRepository>();
            services.AddTransient<IImportDetailRepository, ImportDetailRepository>();

            services.AddTransient<IIncotermRepository, IncotermRepository>();
            services.AddTransient<ILocationRepository, LocationRepository>();
            services.AddTransient<IMachineRepository, MachineRepository>();
            services.AddTransient<IPackingListRepository, PackingListRepository>();
            services.AddTransient<IPaymentRepository, PaymentRepository>();
            services.AddTransient<IPaymentTermRepository, PaymentTermRepository>();
            services.AddTransient<IPaymentTypeRepository, PaymentTypeRepository>();
            services.AddTransient<IPlanPaymentRepository, PlanPaymentRepository>();
            services.AddTransient<IProcessRepository, ProcessRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IProductTypeRepository, ProductTypeRepository>();
            services.AddTransient<ISectorRepository, SectorRepository>();
            services.AddTransient<IShapeRepository, ShapeRepository>();
            services.AddTransient<IShiftRepository, ShiftRepository>();
            services.AddTransient<IShipmentCompanyRepository, ShipmentCompanyRepository>();

            services.AddTransient<IStartPortRepository, StartPortRepository>();
            services.AddTransient<IStatusRepository, StatusRepository>();
            services.AddTransient<ISteelRepository, SteelRepository>();
            services.AddTransient<IStopRepository, StopRepository>();
            services.AddTransient<IStopCategoryRepository, StopCategoryRepository>();
            services.AddTransient<ISubSectorRepository, SubSectorRepository>();
            services.AddTransient<ISupplierRepository, SupplierRepository>();
            services.AddTransient<ISupplierTypeRepository, SupplierTypeRepository>();
            services.AddTransient<IThicknessRepository, ThicknessRepository>();
            services.AddTransient<ITransportCompanyRepository, TransportCompanyRepository>();
            services.AddTransient<IUnitRepository, UnitRepository>();
            services.AddTransient<IWHLocationRepository, WHLocationRepository>();
            services.AddTransient<ICombosHelper, CombosHelper>();

            services.AddTransient<IProductionOrderRepository, ProductionOrderRepository>();
            services.AddTransient<IProductionOrderDetailRepository, ProductionOrderDetailRepository>();
            services.AddTransient<IProductionOrderFileRepository, ProductionOrderFileRepository>();
            services.AddTransient<IProductionOrderProcessRepository, ProductionOrderProcessRepository>();
            services.AddTransient<IProductionStopRepository, ProductionStopRepository>();
            services.AddTransient<IProductionInfoRepository, ProductionInfoRepository>();
            services.AddTransient<IProductionStopRepository, ProductionStopRepository>();
            services.AddTransient<IProductionInfoRepository, ProductionInfoRepository>();

            services.AddTransient<ICategoryModelRepository, CategoryModelRepository>();
            services.AddTransient<IEvaluationCategoryRepository, EvaluationCategoryRepository>();
            services.AddTransient<IModelQuestionRepository, ModelQuestionRepository>();
            services.AddTransient<IDiagnosticRepository, DiagnosticRepository>();
            services.AddTransient<IDiagnosticDetailRepository, DiagnosticDetailRepository>();

            services.AddTransient<IIoTAlertRepository, IoTAlertRepository>();
            services.AddTransient<IIoTMachineRepository, IoTMachineRepository>();
            services.AddTransient<IIoTNotificationRepository, IoTNotificationRepository>();
            services.AddTransient<IIoTRepository, IoTRepository>();
            services.AddTransient<IIoTVariableRepository, IoTVariableRepository>();
            services.AddTransient<IIoTDataRepository, IoTDataRepository>();
            services.AddTransient<IIoTDataAlertNotificationRepository, IoTDataAlertNotificationRepository>();

            services.AddTransient<IBioCareSurveyAnswerRepository, BioCareSurveyAnswerRepository>();
            services.AddTransient<IBioCareSurveyQuestionRepository, BioCareSurveyQuestionRepository>();

            services.AddTransient<IAffectationRepository, AffectationRepository>();

            services.AddTransient<IAbnormalityDetailRepository, AbnormalityDetailRepository>();
            services.AddTransient<IAbnormalityPlaceDetailRepository, AbnormalityPlaceDetailRepository>();
            services.AddTransient<IAbnormalityPlaceRepository, AbnormalityPlaceRepository>();
            services.AddTransient<IAbnormalityTypeRepository, AbnormalityTypeRepository>();

            services.AddTransient<IWareHouseRepository, WareHouseRepository>();
            services.AddTransient<IWareHouseTypeRepository, WareHouseTypeRepository>();

            services.AddTransient<IJobRepository, JobRepository>();
            services.AddTransient<IProtectionCategoryRepository, ProtectionCategoryRepository>();
            services.AddTransient<IProtectionTypeRepository, ProtectionTypeRepository>();
            services.AddTransient<ITaskTypeRepository, TaskTypeRepository>();
            services.AddTransient<IToolRepository, ToolRepository>();
            services.AddTransient<IToolTypeRepository, ToolTypeRepository>();

            services.AddTransient<IControlEPPRepository, ControlEPPRepository>();
            services.AddTransient<IControlEPPDetailRepository, ControlEPPDetailRepository>();
            services.AddTransient<IProtectionElementRepository, ProtectionElementRepository>();

            services.AddTransient<IRawMaterialRepository, RawMaterialRepository>();
            services.AddTransient<IRawMaterialTypeRepository, RawMaterialTypeRepository>();

            services.AddTransient<IImportRepository, ImportRepository>();
            services.AddTransient<IEmailJobConfigRepository, EmailJobConfigRepository>();

            services.AddTransient<IIdealModelQuestionRepository, IdealModelQuestionRepository>();

            services.AddTransient<ICalendarRepository, CalendarRepository>();
            services.AddTransient<ICalendarCategoryRepository, CalendarCategoryRepository>();
            services.AddTransient<ICalendarEventRepository, CalendarEventRepository>();
            services.AddTransient<IModuleRepository, ModuleRepository>();
            services.AddTransient<IModuleCategoryRepository, ModuleCategoryRepository>();
            services.AddTransient<IModuleRolRepository, ModuleRolRepository>();
            services.AddTransient<ISubModuleRepository, SubModuleRepository>();

            services.AddTransient<IInstallationRepository, InstallationRepository>();
            services.AddTransient<IMethodRepository, MethodRepository>();

            services.AddTransient<IBOMRepository, BOMRepository>();
            services.AddTransient<IBOMDetailRepository, BOMDetailRepository>();

            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<ICustomerTypeRepository, CustomerTypeRepository>();
            services.AddTransient<IVendorRepository, VendorRepository>();
            services.AddTransient<ITaxRepository, TaxRepository>();
            services.AddTransient<IPriceListRepository, PriceListRepository>();
            services.AddTransient<IDiscountListRepository, DiscountListRepository>();
            services.AddTransient<IPaymentMethodRepository, PaymentMethodRepository>();

            services.AddTransient<IMovementBasicRepository, MovementBasicRepository>();
            services.AddTransient<IMovementDetailRepository, MovementDetailRepository>();

            services.AddTransient<IChannelRepository, ChannelRepository>();
            services.AddTransient<IChannelCategoryRepository, ChannelCategoryRepository>();
            services.AddTransient<IMeatCuttingRepository, MeatCuttingRepository>();
            services.AddTransient<ISpecieRepository, SpecieRepository>();
            services.AddTransient<IStrippingRepository, StrippingRepository>();
            services.AddTransient<IStrippingDetailRepository, StrippingDetailRepository>();
            services.AddTransient<ICutsRelationRepository, CutsRelationRepository>();
            services.AddTransient<IYieldMeatCuttingRepository, YieldMeatCuttingRepository>();


            return services;
        }
    }
}

//services.AddTransient<IoTController>();

