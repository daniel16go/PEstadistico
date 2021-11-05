using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace Productivo.Core.Migrations
{
    public partial class CreateDatabaseGoogle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AbnormalityPlaces",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 80, nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbnormalityPlaces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Affectations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 80, nullable: false),
                    Initials = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Affectations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Areas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Banks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 80, nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BioCareSurveyQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    QuestionName = table.Column<string>(nullable: false),
                    AnswerName = table.Column<string>(maxLength: 100, nullable: true),
                    Remarks = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BioCareSurveyQuestions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 80, nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CalendarCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 80, nullable: false),
                    Color = table.Column<string>(maxLength: 20, nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalendarCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Calendars",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 80, nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calendars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoryModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ScopeNameCategory = table.Column<string>(maxLength: 40, nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContainerTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Lenght = table.Column<decimal>(nullable: false),
                    Width = table.Column<decimal>(nullable: false),
                    Height = table.Column<decimal>(nullable: false),
                    Weight = table.Column<decimal>(nullable: false),
                    MaxLoadKG = table.Column<decimal>(nullable: false),
                    MaxLoadCM = table.Column<decimal>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContainerTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    Initials = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    Initials = table.Column<string>(nullable: true),
                    Factor = table.Column<decimal>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    Initials = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomsAgencies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Phone1 = table.Column<string>(nullable: true),
                    Phone2 = table.Column<string>(nullable: true),
                    Email1 = table.Column<string>(nullable: false),
                    Email2 = table.Column<string>(nullable: true),
                    Contact = table.Column<string>(nullable: true),
                    Website = table.Column<string>(nullable: true),
                    Initials = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomsAgencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dimensions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    Lenght = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Width = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dimensions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DiscountLists",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    Initials = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscountLists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmailJobConfigs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    SmtpHost = table.Column<string>(nullable: false),
                    SmtpPort = table.Column<int>(nullable: false),
                    EnableSSL = table.Column<bool>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailJobConfigs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 80, nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EvaluationCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    EvaluationNameCategory = table.Column<string>(maxLength: 40, nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvaluationCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Finisheses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    Initials = table.Column<string>(maxLength: 10, nullable: true),
                    Remarks = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Finisheses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Incoterms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    Initials = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incoterms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Installations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(maxLength: 4, nullable: false),
                    Name = table.Column<string>(maxLength: 80, nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Installations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IoTDatas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    DispositivoIOT = table.Column<int>(nullable: false),
                    Nombres = table.Column<string>(maxLength: 80, nullable: false),
                    Valores = table.Column<string>(maxLength: 50, nullable: false),
                    Fecha = table.Column<DateTime>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IoTDatas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IoTMachines",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    IoTsId = table.Column<int>(nullable: false),
                    MachinesId = table.Column<int>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IoTMachines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IoTs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 80, nullable: false),
                    CodeIoT = table.Column<string>(maxLength: 5, nullable: false),
                    URLPath = table.Column<string>(maxLength: 100, nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IoTs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 80, nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 80, nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MetalUnitTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 80, nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetalUnitTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Methods",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(maxLength: 4, nullable: false),
                    Name = table.Column<string>(maxLength: 80, nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Methods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ModuleCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 80, nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModuleCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MovementBasics",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(maxLength: 10, nullable: false),
                    Name = table.Column<string>(maxLength: 80, nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovementBasics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MovementClasses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(maxLength: 10, nullable: false),
                    Distance = table.Column<string>(maxLength: 50, nullable: false),
                    MotionRange = table.Column<string>(maxLength: 150, nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovementClasses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movements",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Distance = table.Column<double>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MovementTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 80, nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovementTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethods",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentTerms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    Days = table.Column<int>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTerms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Plans",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 80, nullable: false),
                    LastPurchase = table.Column<DateTime>(nullable: false),
                    ActiveDays = table.Column<int>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PriceLists",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    Initials = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceLists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Processes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 80, nullable: false),
                    ProductionTarget = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Remarks = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Processes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProtectionCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 80, nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProtectionCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RawMaterialTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 80, nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RawMaterialTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sectors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Sector = table.Column<string>(maxLength: 150, nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sectors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shapes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 80, nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shapes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shifts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    ShiftStart = table.Column<DateTime>(nullable: false),
                    ShiftEnd = table.Column<DateTime>(nullable: false),
                    RestTimeShift = table.Column<int>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shifts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShipmentCompanies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    URLTracking = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipmentCompanies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Species",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Species", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    Module = table.Column<string>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Steels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    DIN = table.Column<string>(maxLength: 15, nullable: true),
                    AISI = table.Column<string>(maxLength: 15, nullable: true),
                    Remarks = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Steels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StopsCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Level = table.Column<string>(maxLength: 4, nullable: false),
                    Code = table.Column<string>(maxLength: 4, nullable: false),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StopsCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SupplierTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    Initials = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Taxes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(maxLength: 30, nullable: true),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    TaxPercentage = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Remarks = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taxes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Thicknesses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Thicknesses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ToolTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 80, nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToolTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransportCompanies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    URLTracking = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportCompanies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Initials = table.Column<string>(maxLength: 8, nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VendorTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    Initials = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendorTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WareHouseTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 80, nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WareHouseTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WHLocations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    Position = table.Column<string>(maxLength: 10, nullable: true),
                    Remarks = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WHLocations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbnormalityPlaceDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 80, nullable: false),
                    AbnormalityPlacesId = table.Column<int>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbnormalityPlaceDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbnormalityPlaceDetails_AbnormalityPlaces_AbnormalityPlacesId",
                        column: x => x.AbnormalityPlacesId,
                        principalTable: "AbnormalityPlaces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AbnormalityTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 80, nullable: false),
                    AffectationsId = table.Column<int>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbnormalityTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbnormalityTypes_Affectations_AffectationsId",
                        column: x => x.AffectationsId,
                        principalTable: "Affectations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CalendarEvents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CalendarsId = table.Column<int>(nullable: false),
                    CalendarCategoriesId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    EventStartDate = table.Column<DateTime>(nullable: false),
                    EventEndDate = table.Column<DateTime>(nullable: false),
                    EventStartTime = table.Column<DateTime>(nullable: false),
                    EventEndTime = table.Column<DateTime>(nullable: false),
                    EventRemember = table.Column<bool>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    Seen = table.Column<bool>(nullable: false),
                    EmailSent = table.Column<bool>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalendarEvents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CalendarEvents_CalendarCategories_CalendarCategoriesId",
                        column: x => x.CalendarCategoriesId,
                        principalTable: "CalendarCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CalendarEvents_Calendars_CalendarsId",
                        column: x => x.CalendarsId,
                        principalTable: "Calendars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FinishPorts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    Latitude = table.Column<string>(nullable: true),
                    Longitude = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CountriesId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinishPorts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FinishPorts_Countries_CountriesId",
                        column: x => x.CountriesId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StartPorts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    Latitude = table.Column<string>(nullable: true),
                    Longitude = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CountriesId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StartPorts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StartPorts_Countries_CountriesId",
                        column: x => x.CountriesId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    IdCode = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 80, nullable: false),
                    SecondName = table.Column<string>(maxLength: 80, nullable: true),
                    LastName1 = table.Column<string>(maxLength: 80, nullable: false),
                    LastName2 = table.Column<string>(maxLength: 80, nullable: true),
                    Address = table.Column<string>(maxLength: 80, nullable: false),
                    Phone1 = table.Column<string>(maxLength: 20, nullable: false),
                    Phone2 = table.Column<string>(maxLength: 20, nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    EmployeeTypesId = table.Column<int>(nullable: false),
                    EmergencyName = table.Column<string>(maxLength: 100, nullable: true),
                    EmergencyPhone = table.Column<string>(maxLength: 20, nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_EmployeeTypes_EmployeeTypesId",
                        column: x => x.EmployeeTypesId,
                        principalTable: "EmployeeTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ModelQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    QuestionName = table.Column<string>(nullable: false),
                    EvaluationCategoriesId = table.Column<int>(nullable: false),
                    CategoryModelsId = table.Column<int>(nullable: false),
                    WeightQuestion = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModelQuestions_CategoryModels_CategoryModelsId",
                        column: x => x.CategoryModelsId,
                        principalTable: "CategoryModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModelQuestions_EvaluationCategories_EvaluationCategoriesId",
                        column: x => x.EvaluationCategoriesId,
                        principalTable: "EvaluationCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Routes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    InstallationsId = table.Column<int>(nullable: false),
                    Code = table.Column<string>(maxLength: 30, nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Routes_Installations_InstallationsId",
                        column: x => x.InstallationsId,
                        principalTable: "Installations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IoTNotifications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 80, nullable: false),
                    IoTsId = table.Column<int>(nullable: false),
                    IoTAlertsId = table.Column<int>(nullable: false),
                    Emails = table.Column<string>(nullable: false),
                    Subject = table.Column<string>(maxLength: 150, nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IoTNotifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IoTNotifications_IoTs_IoTsId",
                        column: x => x.IoTsId,
                        principalTable: "IoTs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IoTVariables",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 80, nullable: false),
                    IoTsId = table.Column<int>(nullable: false),
                    MinValue = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    MaxValue = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    UpdateInterval = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    DailyReset = table.Column<bool>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IoTVariables", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IoTVariables_IoTs_IoTsId",
                        column: x => x.IoTsId,
                        principalTable: "IoTs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaskTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 80, nullable: false),
                    JobsId = table.Column<int>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskTypes_Jobs_JobsId",
                        column: x => x.JobsId,
                        principalTable: "Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Modules",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 80, nullable: false),
                    Order = table.Column<int>(nullable: false),
                    ModuleCategoriesId = table.Column<int>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Modules_ModuleCategories_ModuleCategoriesId",
                        column: x => x.ModuleCategoriesId,
                        principalTable: "ModuleCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovementDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(maxLength: 10, nullable: false),
                    Name = table.Column<string>(maxLength: 80, nullable: false),
                    MovementBasicsId = table.Column<int>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovementDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovementDetails_MovementBasics_MovementBasicsId",
                        column: x => x.MovementBasicsId,
                        principalTable: "MovementBasics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlanPayments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CompanyId = table.Column<int>(nullable: false),
                    PlansId = table.Column<int>(nullable: false),
                    PurchaseDate = table.Column<DateTime>(nullable: false),
                    PaymentTypesId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanPayments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlanPayments_PaymentTypes_PaymentTypesId",
                        column: x => x.PaymentTypesId,
                        principalTable: "PaymentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlanPayments_Plans_PlansId",
                        column: x => x.PlansId,
                        principalTable: "Plans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProtectionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 80, nullable: false),
                    ProtectionCategoriesId = table.Column<int>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProtectionTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProtectionTypes_ProtectionCategories_ProtectionCategoriesId",
                        column: x => x.ProtectionCategoriesId,
                        principalTable: "ProtectionCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubSectors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    SectorsId = table.Column<int>(nullable: false),
                    SubSector = table.Column<string>(maxLength: 150, nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubSectors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubSectors_Sectors_SectorsId",
                        column: x => x.SectorsId,
                        principalTable: "Sectors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Channels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    SpecieId = table.Column<int>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Channels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Channels_Species_SpecieId",
                        column: x => x.SpecieId,
                        principalTable: "Species",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Machines",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 80, nullable: false),
                    StatusId = table.Column<int>(nullable: false),
                    Model = table.Column<string>(maxLength: 50, nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Insurance = table.Column<bool>(nullable: false),
                    Reference = table.Column<string>(nullable: true),
                    LocationsId = table.Column<int>(nullable: false),
                    BrandsId = table.Column<int>(nullable: false),
                    ProcessesId = table.Column<int>(nullable: false),
                    OutputStandard = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    IoTMachineEntityId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Machines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Machines_Brands_BrandsId",
                        column: x => x.BrandsId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Machines_IoTMachines_IoTMachineEntityId",
                        column: x => x.IoTMachineEntityId,
                        principalTable: "IoTMachines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Machines_Locations_LocationsId",
                        column: x => x.LocationsId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Machines_Processes_ProcessesId",
                        column: x => x.ProcessesId,
                        principalTable: "Processes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Machines_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Strips",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Reference = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: true),
                    StatusId = table.Column<int>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Strips", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Strips_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stops",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    StopsCategoriesId = table.Column<int>(nullable: false),
                    Level = table.Column<string>(maxLength: 4, nullable: false),
                    Code = table.Column<string>(maxLength: 4, nullable: false),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    AreasId = table.Column<int>(nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stops", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stops_Areas_AreasId",
                        column: x => x.AreasId,
                        principalTable: "Areas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Stops_StopsCategories_StopsCategoriesId",
                        column: x => x.StopsCategoriesId,
                        principalTable: "StopsCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    Latitude = table.Column<string>(nullable: true),
                    Longitude = table.Column<string>(nullable: true),
                    CountriesId = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Phone1 = table.Column<string>(nullable: true),
                    Phone2 = table.Column<string>(nullable: true),
                    Email1 = table.Column<string>(nullable: false),
                    Email2 = table.Column<string>(nullable: true),
                    Contact = table.Column<string>(nullable: true),
                    Initials = table.Column<string>(nullable: true),
                    SupplierTypesId = table.Column<int>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Suppliers_Countries_CountriesId",
                        column: x => x.CountriesId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Suppliers_SupplierTypes_SupplierTypesId",
                        column: x => x.SupplierTypesId,
                        principalTable: "SupplierTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tools",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 80, nullable: false),
                    ToolTypesId = table.Column<int>(nullable: false),
                    PurchaseDate = table.Column<DateTime>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    StatusId = table.Column<int>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tools", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tools_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tools_ToolTypes_ToolTypesId",
                        column: x => x.ToolTypesId,
                        principalTable: "ToolTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(maxLength: 8, nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    UnitsId = table.Column<int>(nullable: false),
                    CodeERP = table.Column<string>(maxLength: 8, nullable: true),
                    Minimum = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Maximum = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Factor1 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Factor2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductTypesId = table.Column<int>(nullable: false),
                    ShapesId = table.Column<int>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_ProductTypes_ProductTypesId",
                        column: x => x.ProductTypesId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Shapes_ShapesId",
                        column: x => x.ShapesId,
                        principalTable: "Shapes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Units_UnitsId",
                        column: x => x.UnitsId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vendors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(maxLength: 30, nullable: true),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    VendorTypesId = table.Column<int>(nullable: false),
                    BlockId = table.Column<int>(nullable: false),
                    InstallationsId = table.Column<int>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vendors_Installations_InstallationsId",
                        column: x => x.InstallationsId,
                        principalTable: "Installations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vendors_VendorTypes_VendorTypesId",
                        column: x => x.VendorTypesId,
                        principalTable: "VendorTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WareHouses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 80, nullable: false),
                    WareHouseTypesId = table.Column<int>(nullable: false),
                    Address = table.Column<string>(maxLength: 100, nullable: true),
                    Email1 = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(maxLength: 80, nullable: true),
                    Latitude = table.Column<string>(nullable: true),
                    Longitude = table.Column<string>(nullable: true),
                    Remarks = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WareHouses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WareHouses_WareHouseTypes_WareHouseTypesId",
                        column: x => x.WareHouseTypesId,
                        principalTable: "WareHouseTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MetalUnits",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    MetalCode = table.Column<string>(maxLength: 8, nullable: true),
                    WarehouseDate = table.Column<DateTime>(nullable: false),
                    MetalUnitTypesId = table.Column<int>(nullable: false),
                    SteelsId = table.Column<int>(nullable: false),
                    ThicknessesId = table.Column<int>(nullable: false),
                    DimensionsId = table.Column<int>(nullable: false),
                    FinishesesId = table.Column<int>(nullable: false),
                    WHLocationsId = table.Column<int>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetalUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MetalUnits_Dimensions_DimensionsId",
                        column: x => x.DimensionsId,
                        principalTable: "Dimensions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MetalUnits_Finisheses_FinishesesId",
                        column: x => x.FinishesesId,
                        principalTable: "Finisheses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MetalUnits_MetalUnitTypes_MetalUnitTypesId",
                        column: x => x.MetalUnitTypesId,
                        principalTable: "MetalUnitTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MetalUnits_Steels_SteelsId",
                        column: x => x.SteelsId,
                        principalTable: "Steels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MetalUnits_Thicknesses_ThicknessesId",
                        column: x => x.ThicknessesId,
                        principalTable: "Thicknesses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MetalUnits_WHLocations_WHLocationsId",
                        column: x => x.WHLocationsId,
                        principalTable: "WHLocations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AbnormalityDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 80, nullable: false),
                    AbnormalityTypesId = table.Column<int>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbnormalityDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbnormalityDetails_AbnormalityTypes_AbnormalityTypesId",
                        column: x => x.AbnormalityTypesId,
                        principalTable: "AbnormalityTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BioCareSurveyAnswers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    SurveyDate = table.Column<DateTime>(nullable: true),
                    SurveyTime = table.Column<DateTime>(nullable: true),
                    EmployeesId = table.Column<int>(nullable: false),
                    BioCareSurveyQuestionsId = table.Column<int>(nullable: false),
                    Answer = table.Column<string>(maxLength: 50, nullable: false),
                    Temperature = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BioCareSurveyAnswers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BioCareSurveyAnswers_BioCareSurveyQuestions_BioCareSurveyQue~",
                        column: x => x.BioCareSurveyQuestionsId,
                        principalTable: "BioCareSurveyQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BioCareSurveyAnswers_Employees_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ControlEPPs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ControlEPPDate = table.Column<DateTime>(nullable: true),
                    Order = table.Column<string>(maxLength: 15, nullable: true),
                    StatusId = table.Column<int>(nullable: false),
                    EmployeesId = table.Column<int>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControlEPPs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ControlEPPs_Employees_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ControlEPPs_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IoTDataAlertNotifications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    EmployeesId = table.Column<int>(nullable: false),
                    Subject = table.Column<string>(nullable: true),
                    Seen = table.Column<bool>(nullable: false),
                    EmailSent = table.Column<bool>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IoTDataAlertNotifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IoTDataAlertNotifications_Employees_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RouteOperations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    RoutesId = table.Column<int>(nullable: false),
                    Code = table.Column<int>(nullable: false),
                    ProcessesId = table.Column<int>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RouteOperations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RouteOperations_Processes_ProcessesId",
                        column: x => x.ProcessesId,
                        principalTable: "Processes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RouteOperations_Routes_RoutesId",
                        column: x => x.RoutesId,
                        principalTable: "Routes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IoTAlerts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 80, nullable: false),
                    IoTsId = table.Column<int>(nullable: false),
                    IoTVariablesId = table.Column<int>(nullable: false),
                    AlertColor = table.Column<string>(maxLength: 12, nullable: true),
                    MinAlertValue = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    MaxAlertValue = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    IoTNotificationsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IoTAlerts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IoTAlerts_IoTNotifications_IoTNotificationsId",
                        column: x => x.IoTNotificationsId,
                        principalTable: "IoTNotifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IoTAlerts_IoTVariables_IoTVariablesId",
                        column: x => x.IoTVariablesId,
                        principalTable: "IoTVariables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IoTAlerts_IoTs_IoTsId",
                        column: x => x.IoTsId,
                        principalTable: "IoTs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubModules",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ModulesId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 80, nullable: false),
                    URLPath = table.Column<string>(maxLength: 150, nullable: false),
                    Order = table.Column<int>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubModules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubModules_Modules_ModulesId",
                        column: x => x.ModulesId,
                        principalTable: "Modules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProtectionElements",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(maxLength: 8, nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    UnitsId = table.Column<int>(nullable: false),
                    CodeERP = table.Column<string>(maxLength: 8, nullable: true),
                    Minimum = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Maximum = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Factor1 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Factor2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaxDayAsignment = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProtectionTypesId = table.Column<int>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    ImageElement = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProtectionElements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProtectionElements_ProtectionTypes_ProtectionTypesId",
                        column: x => x.ProtectionTypesId,
                        principalTable: "ProtectionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProtectionElements_Units_UnitsId",
                        column: x => x.UnitsId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Diagnostics",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 80, nullable: false),
                    CodeDiagnostic = table.Column<string>(maxLength: 5, nullable: false),
                    StatusId = table.Column<int>(nullable: false),
                    DiagDate = table.Column<DateTime>(nullable: true),
                    EndDiagDate = table.Column<DateTime>(nullable: true),
                    SubSectorsId = table.Column<int>(nullable: false),
                    EmployeesId = table.Column<int>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diagnostics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Diagnostics_Employees_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Diagnostics_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Diagnostics_SubSectors_SubSectorsId",
                        column: x => x.SubSectorsId,
                        principalTable: "SubSectors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IdealModelQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ModelQuestionsId = table.Column<int>(nullable: false),
                    SubSectorsId = table.Column<int>(nullable: false),
                    IdealExecution = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdealModelQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IdealModelQuestions_ModelQuestions_ModelQuestionsId",
                        column: x => x.ModelQuestionsId,
                        principalTable: "ModelQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IdealModelQuestions_SubSectors_SubSectorsId",
                        column: x => x.SubSectorsId,
                        principalTable: "SubSectors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CutsOfMeats",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ChannelId = table.Column<int>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CutsOfMeats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CutsOfMeats_Channels_ChannelId",
                        column: x => x.ChannelId,
                        principalTable: "Channels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StrippingDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    StrippingId = table.Column<int>(nullable: false),
                    ChannelId = table.Column<int>(nullable: false),
                    Weight = table.Column<decimal>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StrippingDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StrippingDetails_Channels_ChannelId",
                        column: x => x.ChannelId,
                        principalTable: "Channels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StrippingDetails_Strips_StrippingId",
                        column: x => x.StrippingId,
                        principalTable: "Strips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Imports",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Order = table.Column<string>(maxLength: 6, nullable: false),
                    SuppliersId = table.Column<int>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    CurrenciesId = table.Column<int>(nullable: false),
                    PurchaseDate = table.Column<DateTime>(nullable: false),
                    ShipmentDate = table.Column<DateTime>(nullable: true),
                    PaymentTermsId = table.Column<int>(nullable: false),
                    Liquidacion = table.Column<bool>(nullable: false),
                    Insurance = table.Column<bool>(nullable: false),
                    Eta = table.Column<DateTime>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    Goods = table.Column<string>(nullable: true),
                    StatusId = table.Column<int>(nullable: false),
                    WarehouseDate = table.Column<DateTime>(nullable: true),
                    PortDate = table.Column<DateTime>(nullable: true),
                    StartPortsId = table.Column<int>(nullable: false),
                    FinishPortsId = table.Column<int>(nullable: false),
                    DO = table.Column<string>(nullable: true),
                    TransportCompaniesId = table.Column<int>(nullable: false),
                    ShipmentCompaniesId = table.Column<int>(nullable: false),
                    IncotermsId = table.Column<int>(nullable: false),
                    CustomsAgenciesId = table.Column<int>(nullable: false),
                    Totalton = table.Column<double>(nullable: true),
                    OC = table.Column<string>(nullable: true),
                    EA = table.Column<string>(nullable: true),
                    Dollar = table.Column<decimal>(nullable: true),
                    DollarSim = table.Column<decimal>(nullable: true),
                    DepositDate = table.Column<DateTime>(nullable: true),
                    DueDate = table.Column<DateTime>(nullable: true),
                    DocsAgencyDate = table.Column<DateTime>(nullable: true),
                    TransportDeliverDate = table.Column<DateTime>(nullable: true),
                    CustomsAuthDate = table.Column<DateTime>(nullable: true),
                    TRMCosts = table.Column<decimal>(nullable: true),
                    POFinishDate = table.Column<DateTime>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    PaymentMethodEntityId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Imports_Currencies_CurrenciesId",
                        column: x => x.CurrenciesId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Imports_CustomsAgencies_CustomsAgenciesId",
                        column: x => x.CustomsAgenciesId,
                        principalTable: "CustomsAgencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Imports_FinishPorts_FinishPortsId",
                        column: x => x.FinishPortsId,
                        principalTable: "FinishPorts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Imports_Incoterms_IncotermsId",
                        column: x => x.IncotermsId,
                        principalTable: "Incoterms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Imports_PaymentMethods_PaymentMethodEntityId",
                        column: x => x.PaymentMethodEntityId,
                        principalTable: "PaymentMethods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Imports_PaymentTerms_PaymentTermsId",
                        column: x => x.PaymentTermsId,
                        principalTable: "PaymentTerms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Imports_ShipmentCompanies_ShipmentCompaniesId",
                        column: x => x.ShipmentCompaniesId,
                        principalTable: "ShipmentCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Imports_StartPorts_StartPortsId",
                        column: x => x.StartPortsId,
                        principalTable: "StartPorts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Imports_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Imports_Suppliers_SuppliersId",
                        column: x => x.SuppliersId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Imports_TransportCompanies_TransportCompaniesId",
                        column: x => x.TransportCompaniesId,
                        principalTable: "TransportCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BOMs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ProductsId = table.Column<int>(nullable: false),
                    InstallationsId = table.Column<int>(nullable: false),
                    MethodsId = table.Column<int>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BOMs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BOMs_Installations_InstallationsId",
                        column: x => x.InstallationsId,
                        principalTable: "Installations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BOMs_Methods_MethodsId",
                        column: x => x.MethodsId,
                        principalTable: "Methods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BOMs_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductionOrders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ProdDate = table.Column<DateTime>(nullable: true),
                    ProdStartDate = table.Column<DateTime>(nullable: true),
                    ProdFinishDate = table.Column<DateTime>(nullable: true),
                    Order = table.Column<string>(maxLength: 15, nullable: true),
                    StatusId = table.Column<int>(nullable: false),
                    Lot = table.Column<int>(nullable: true),
                    ProductsId = table.Column<int>(nullable: false),
                    ShiftsId = table.Column<int>(nullable: false),
                    MinPackageWeight = table.Column<decimal>(nullable: true),
                    MaxPackageWeight = table.Column<decimal>(nullable: true),
                    Lenght = table.Column<decimal>(nullable: true),
                    LenghtTolerance = table.Column<decimal>(nullable: true),
                    ExpectedQuantity = table.Column<decimal>(nullable: true),
                    Remarks = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductionOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductionOrders_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductionOrders_Shifts_ShiftsId",
                        column: x => x.ShiftsId,
                        principalTable: "Shifts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductionOrders_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(maxLength: 30, nullable: true),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    Latitude = table.Column<string>(nullable: true),
                    Longitude = table.Column<string>(nullable: true),
                    Initials = table.Column<string>(nullable: true),
                    CustomerTypesId = table.Column<int>(nullable: false),
                    CreditLimit = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BlockId = table.Column<int>(nullable: false),
                    VendorsId = table.Column<int>(nullable: false),
                    InstallationsId = table.Column<int>(nullable: false),
                    InvoiceDeliveryId = table.Column<int>(nullable: false),
                    TaxesId = table.Column<int>(nullable: false),
                    InvoiceCopies = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CurrenciesId = table.Column<int>(nullable: false),
                    PricesListsId = table.Column<int>(nullable: false),
                    DiscountListsId = table.Column<int>(nullable: false),
                    DownPaymentPercentage = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DownPaymentApId = table.Column<int>(nullable: false),
                    PaymentTermsId = table.Column<int>(nullable: false),
                    PaymentMethodsId = table.Column<int>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    PriceListsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Currencies_CurrenciesId",
                        column: x => x.CurrenciesId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Customers_CustomerTypes_CustomerTypesId",
                        column: x => x.CustomerTypesId,
                        principalTable: "CustomerTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Customers_DiscountLists_DiscountListsId",
                        column: x => x.DiscountListsId,
                        principalTable: "DiscountLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Customers_Installations_InstallationsId",
                        column: x => x.InstallationsId,
                        principalTable: "Installations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Customers_PaymentMethods_PaymentMethodsId",
                        column: x => x.PaymentMethodsId,
                        principalTable: "PaymentMethods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Customers_PaymentTerms_PaymentTermsId",
                        column: x => x.PaymentTermsId,
                        principalTable: "PaymentTerms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Customers_PriceLists_PriceListsId",
                        column: x => x.PriceListsId,
                        principalTable: "PriceLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customers_Taxes_TaxesId",
                        column: x => x.TaxesId,
                        principalTable: "Taxes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Customers_Vendors_VendorsId",
                        column: x => x.VendorsId,
                        principalTable: "Vendors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ModuleRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    SubModulesId = table.Column<int>(nullable: false),
                    Access = table.Column<bool>(nullable: false),
                    RolId = table.Column<string>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModuleRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModuleRoles_SubModules_SubModulesId",
                        column: x => x.SubModulesId,
                        principalTable: "SubModules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ControlEPPDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ControlEPPsId = table.Column<int>(nullable: false),
                    EmployeesId = table.Column<int>(nullable: false),
                    AsignmentDateTime = table.Column<DateTime>(nullable: true),
                    ReturnDateTime = table.Column<DateTime>(nullable: true),
                    ProtectionElementsId = table.Column<int>(nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Remarks = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControlEPPDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ControlEPPDetails_ControlEPPs_ControlEPPsId",
                        column: x => x.ControlEPPsId,
                        principalTable: "ControlEPPs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ControlEPPDetails_Employees_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ControlEPPDetails_ProtectionElements_ProtectionElementsId",
                        column: x => x.ProtectionElementsId,
                        principalTable: "ProtectionElements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiagnosticDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    DiagnosticsId = table.Column<int>(nullable: false),
                    ModelQuestionsId = table.Column<int>(nullable: false),
                    Execution = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiagnosticDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DiagnosticDetails_Diagnostics_DiagnosticsId",
                        column: x => x.DiagnosticsId,
                        principalTable: "Diagnostics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiagnosticDetails_ModelQuestions_ModelQuestionsId",
                        column: x => x.ModelQuestionsId,
                        principalTable: "ModelQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PriceCuts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    MeatCuttingId = table.Column<int>(nullable: false),
                    MalePrice = table.Column<decimal>(nullable: false),
                    FemalePrice = table.Column<decimal>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceCuts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PriceCuts_CutsOfMeats_MeatCuttingId",
                        column: x => x.MeatCuttingId,
                        principalTable: "CutsOfMeats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuantitySaleTops",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    MeatCuttingId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuantitySaleTops", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuantitySaleTops_CutsOfMeats_MeatCuttingId",
                        column: x => x.MeatCuttingId,
                        principalTable: "CutsOfMeats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubCuts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    MainCutId = table.Column<int>(nullable: false),
                    SubCutId = table.Column<int>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCuts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCuts_CutsOfMeats_MainCutId",
                        column: x => x.MainCutId,
                        principalTable: "CutsOfMeats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubCuts_CutsOfMeats_SubCutId",
                        column: x => x.SubCutId,
                        principalTable: "CutsOfMeats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "YieldMeatCuts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    MeatCuttingId = table.Column<int>(nullable: false),
                    Yield = table.Column<decimal>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YieldMeatCuts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_YieldMeatCuts_CutsOfMeats_MeatCuttingId",
                        column: x => x.MeatCuttingId,
                        principalTable: "CutsOfMeats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CommImports",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ImportsId = table.Column<int>(nullable: false),
                    DateComm = table.Column<DateTime>(nullable: false),
                    Message = table.Column<string>(nullable: false),
                    SuppliersId = table.Column<int>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommImports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommImports_Imports_ImportsId",
                        column: x => x.ImportsId,
                        principalTable: "Imports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CommImports_Suppliers_SuppliersId",
                        column: x => x.SuppliersId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Containers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ImportsId = table.Column<int>(nullable: false),
                    Container = table.Column<string>(maxLength: 40, nullable: false),
                    BL = table.Column<string>(maxLength: 40, nullable: false),
                    InitialDate = table.Column<DateTime>(nullable: false),
                    FinalDate = table.Column<DateTime>(nullable: false),
                    Booking = table.Column<string>(nullable: true),
                    ContainerTypesId = table.Column<int>(nullable: false),
                    GrossWeight = table.Column<decimal>(nullable: false),
                    ContainerLoadType = table.Column<int>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Containers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Containers_ContainerTypes_ContainerTypesId",
                        column: x => x.ContainerTypesId,
                        principalTable: "ContainerTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Containers_Imports_ImportsId",
                        column: x => x.ImportsId,
                        principalTable: "Imports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ImportDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ImportsId = table.Column<int>(nullable: false),
                    ProductsId = table.Column<int>(nullable: false),
                    LeadTime = table.Column<DateTime>(nullable: true),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CertificationPath = table.Column<string>(nullable: true),
                    PendQuantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImportDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImportDetails_Imports_ImportsId",
                        column: x => x.ImportsId,
                        principalTable: "Imports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ImportDetails_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ImportFiles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ImportsId = table.Column<int>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    FilePath = table.Column<string>(nullable: true),
                    LoadDate = table.Column<DateTime>(nullable: false),
                    TypeFile = table.Column<int>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImportFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImportFiles_Imports_ImportsId",
                        column: x => x.ImportsId,
                        principalTable: "Imports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ImportsId = table.Column<int>(nullable: false),
                    BanksId = table.Column<int>(nullable: false),
                    PaymentTypesId = table.Column<int>(nullable: false),
                    CurrenciesId = table.Column<int>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    PaymentDate = table.Column<DateTime>(nullable: false),
                    Legalization = table.Column<bool>(nullable: false),
                    LegalDate = table.Column<DateTime>(nullable: true),
                    ChangeRate = table.Column<decimal>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_Banks_BanksId",
                        column: x => x.BanksId,
                        principalTable: "Banks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payments_Currencies_CurrenciesId",
                        column: x => x.CurrenciesId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payments_Imports_ImportsId",
                        column: x => x.ImportsId,
                        principalTable: "Imports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payments_PaymentTypes_PaymentTypesId",
                        column: x => x.PaymentTypesId,
                        principalTable: "PaymentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BOMDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    BOMsId = table.Column<int>(nullable: false),
                    ProductsId = table.Column<int>(nullable: false),
                    ComponentsId = table.Column<int>(nullable: false),
                    BaseQuantity = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    RequiredQuantity = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AdicionalQuantity = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    WastePercentage = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ActivationDateTime = table.Column<DateTime>(nullable: true),
                    InactivationDateTime = table.Column<DateTime>(nullable: true),
                    Remarks = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BOMDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BOMDetails_BOMs_BOMsId",
                        column: x => x.BOMsId,
                        principalTable: "BOMs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BOMDetails_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductionInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ProductionOrdersId = table.Column<int>(nullable: false),
                    ProductsId = table.Column<int>(nullable: false),
                    DeliveryDate = table.Column<DateTime>(nullable: false),
                    Quantity = table.Column<decimal>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductionInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductionInfos_ProductionOrders_ProductionOrdersId",
                        column: x => x.ProductionOrdersId,
                        principalTable: "ProductionOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductionInfos_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductionOrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ProductionOrdersId = table.Column<int>(nullable: false),
                    EmployeesId = table.Column<int>(nullable: false),
                    StartDateTime = table.Column<DateTime>(nullable: true),
                    FinishDateTime = table.Column<DateTime>(nullable: true),
                    TuneUp = table.Column<int>(nullable: true),
                    LenghtDifference = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Speed = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ProdQuantity = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    OddmentQuantity = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    WasteQuantity = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Remarks = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductionOrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductionOrderDetails_Employees_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductionOrderDetails_ProductionOrders_ProductionOrdersId",
                        column: x => x.ProductionOrdersId,
                        principalTable: "ProductionOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductionOrderFiles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ProductionOrdersId = table.Column<int>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    FilePath = table.Column<string>(nullable: true),
                    LoadDate = table.Column<DateTime>(nullable: false),
                    TypeFile = table.Column<int>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductionOrderFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductionOrderFiles_ProductionOrders_ProductionOrdersId",
                        column: x => x.ProductionOrdersId,
                        principalTable: "ProductionOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductionOrderProcesses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ProductionOrdersId = table.Column<int>(nullable: false),
                    MachinesId = table.Column<int>(nullable: false),
                    ScheduleDate = table.Column<DateTime>(nullable: false),
                    EmployeesId = table.Column<int>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductionOrderProcesses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductionOrderProcesses_Employees_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductionOrderProcesses_Machines_MachinesId",
                        column: x => x.MachinesId,
                        principalTable: "Machines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductionOrderProcesses_ProductionOrders_ProductionOrdersId",
                        column: x => x.ProductionOrdersId,
                        principalTable: "ProductionOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductionStops",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ProductionOrdersId = table.Column<int>(nullable: false),
                    StopsId = table.Column<int>(nullable: false),
                    MachinesId = table.Column<int>(nullable: false),
                    StartDateTime = table.Column<DateTime>(nullable: true),
                    FinishDateTime = table.Column<DateTime>(nullable: true),
                    EmployeesId = table.Column<int>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductionStops", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductionStops_Employees_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductionStops_Machines_MachinesId",
                        column: x => x.MachinesId,
                        principalTable: "Machines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductionStops_ProductionOrders_ProductionOrdersId",
                        column: x => x.ProductionOrdersId,
                        principalTable: "ProductionOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductionStops_Stops_StopsId",
                        column: x => x.StopsId,
                        principalTable: "Stops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerComms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CustomerId = table.Column<int>(nullable: false),
                    DateComm = table.Column<DateTime>(nullable: false),
                    Message = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CustomersId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerComms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerComms_Customers_CustomersId",
                        column: x => x.CustomersId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CustomerFiles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CustomersId = table.Column<int>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    FilePath = table.Column<string>(nullable: true),
                    LoadDate = table.Column<DateTime>(nullable: false),
                    TypeFile = table.Column<int>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerFiles_Customers_CustomersId",
                        column: x => x.CustomersId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PackingLists",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ImportsId = table.Column<int>(nullable: false),
                    ImportDetailsId = table.Column<int>(nullable: false),
                    Heat = table.Column<string>(maxLength: 40, nullable: false),
                    Package = table.Column<string>(maxLength: 40, nullable: true),
                    Pieces = table.Column<decimal>(nullable: false),
                    GrossWeight = table.Column<decimal>(nullable: false),
                    NetWeight = table.Column<decimal>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    LoadDate = table.Column<DateTime>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackingLists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PackingLists_ImportDetails_ImportDetailsId",
                        column: x => x.ImportDetailsId,
                        principalTable: "ImportDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PackingLists_Imports_ImportsId",
                        column: x => x.ImportsId,
                        principalTable: "Imports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(maxLength: 4, nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Latitude = table.Column<string>(nullable: true),
                    Longitude = table.Column<string>(nullable: true),
                    Owner = table.Column<string>(maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    PlansId = table.Column<int>(nullable: false),
                    ConfigMode = table.Column<int>(nullable: false),
                    PathWeb = table.Column<string>(nullable: true),
                    LogoPath = table.Column<string>(nullable: true),
                    SectorsId = table.Column<int>(nullable: true),
                    SubSectorsId = table.Column<int>(nullable: true),
                    PlanPaymentsId = table.Column<int>(nullable: true),
                    SeederLoad = table.Column<bool>(nullable: true),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ProcessesId = table.Column<int>(nullable: true),
                    BrandsId = table.Column<int>(nullable: true),
                    MachinesId = table.Column<int>(nullable: true),
                    BanksId = table.Column<int>(nullable: true),
                    LocationsId = table.Column<int>(nullable: true),
                    CountriesId = table.Column<int>(nullable: true),
                    CurrenciesId = table.Column<int>(nullable: true),
                    CustomsAgenciesId = table.Column<int>(nullable: true),
                    FinishPortsId = table.Column<int>(nullable: true),
                    ImportsId = table.Column<int>(nullable: true),
                    IncotermsId = table.Column<int>(nullable: true),
                    PaymentTermsId = table.Column<int>(nullable: true),
                    ShipmentsCompaniesId = table.Column<int>(nullable: true),
                    StartPortsId = table.Column<int>(nullable: true),
                    StatusId = table.Column<int>(nullable: true),
                    SuppliersId = table.Column<int>(nullable: true),
                    SupplierTypesId = table.Column<int>(nullable: true),
                    TransportCompaniesId = table.Column<int>(nullable: true),
                    ImportDetailsId = table.Column<int>(nullable: true),
                    ProductsId = table.Column<int>(nullable: true),
                    UnitsId = table.Column<int>(nullable: true),
                    ProductTypesId = table.Column<int>(nullable: true),
                    ContainersId = table.Column<int>(nullable: true),
                    ContainerTypesId = table.Column<int>(nullable: true),
                    CommImportsId = table.Column<int>(nullable: true),
                    ImportFilesId = table.Column<int>(nullable: true),
                    PackingListsId = table.Column<int>(nullable: true),
                    PaymentTypesId = table.Column<int>(nullable: true),
                    PaymentsId = table.Column<int>(nullable: true),
                    ShiftsId = table.Column<int>(nullable: true),
                    ProductionOrdersId = table.Column<int>(nullable: true),
                    MetalUnitsId = table.Column<int>(nullable: true),
                    MetalUnitTypesId = table.Column<int>(nullable: true),
                    ProductionInfosId = table.Column<int>(nullable: true),
                    ProductionOrderDetailsId = table.Column<int>(nullable: true),
                    ProductionStopsId = table.Column<int>(nullable: true),
                    ProductionOrderProcessesId = table.Column<int>(nullable: true),
                    EmployeesId = table.Column<int>(nullable: true),
                    EmployeeTypesId = table.Column<int>(nullable: true),
                    StopsCategoriesId = table.Column<int>(nullable: true),
                    AreasId = table.Column<int>(nullable: true),
                    StopsId = table.Column<int>(nullable: true),
                    ProductionOrderFilesId = table.Column<int>(nullable: true),
                    ShapesId = table.Column<int>(nullable: true),
                    CategoryModelsId = table.Column<int>(nullable: true),
                    EvaluationCategoriesId = table.Column<int>(nullable: true),
                    IoTsId = table.Column<int>(nullable: true),
                    IoTAlertsId = table.Column<int>(nullable: true),
                    IoTMachinesId = table.Column<int>(nullable: true),
                    IoTNotificationsId = table.Column<int>(nullable: true),
                    IoTVariablesId = table.Column<int>(nullable: true),
                    ModelQuestionsId = table.Column<int>(nullable: true),
                    IdealModelQuestionsId = table.Column<int>(nullable: true),
                    DimensionEntityId = table.Column<int>(nullable: true),
                    FinishEntityId = table.Column<int>(nullable: true),
                    SteelEntityId = table.Column<int>(nullable: true),
                    ThicknessEntityId = table.Column<int>(nullable: true),
                    WHLocationEntityId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Companies_Areas_AreasId",
                        column: x => x.AreasId,
                        principalTable: "Areas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_Banks_BanksId",
                        column: x => x.BanksId,
                        principalTable: "Banks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_Brands_BrandsId",
                        column: x => x.BrandsId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_CategoryModels_CategoryModelsId",
                        column: x => x.CategoryModelsId,
                        principalTable: "CategoryModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_CommImports_CommImportsId",
                        column: x => x.CommImportsId,
                        principalTable: "CommImports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_ContainerTypes_ContainerTypesId",
                        column: x => x.ContainerTypesId,
                        principalTable: "ContainerTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_Containers_ContainersId",
                        column: x => x.ContainersId,
                        principalTable: "Containers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_Countries_CountriesId",
                        column: x => x.CountriesId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_Currencies_CurrenciesId",
                        column: x => x.CurrenciesId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_CustomsAgencies_CustomsAgenciesId",
                        column: x => x.CustomsAgenciesId,
                        principalTable: "CustomsAgencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_Dimensions_DimensionEntityId",
                        column: x => x.DimensionEntityId,
                        principalTable: "Dimensions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_EmployeeTypes_EmployeeTypesId",
                        column: x => x.EmployeeTypesId,
                        principalTable: "EmployeeTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_Employees_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_EvaluationCategories_EvaluationCategoriesId",
                        column: x => x.EvaluationCategoriesId,
                        principalTable: "EvaluationCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_Finisheses_FinishEntityId",
                        column: x => x.FinishEntityId,
                        principalTable: "Finisheses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_FinishPorts_FinishPortsId",
                        column: x => x.FinishPortsId,
                        principalTable: "FinishPorts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_IdealModelQuestions_IdealModelQuestionsId",
                        column: x => x.IdealModelQuestionsId,
                        principalTable: "IdealModelQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_ImportDetails_ImportDetailsId",
                        column: x => x.ImportDetailsId,
                        principalTable: "ImportDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_ImportFiles_ImportFilesId",
                        column: x => x.ImportFilesId,
                        principalTable: "ImportFiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_Imports_ImportsId",
                        column: x => x.ImportsId,
                        principalTable: "Imports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_Incoterms_IncotermsId",
                        column: x => x.IncotermsId,
                        principalTable: "Incoterms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_IoTAlerts_IoTAlertsId",
                        column: x => x.IoTAlertsId,
                        principalTable: "IoTAlerts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_IoTMachines_IoTMachinesId",
                        column: x => x.IoTMachinesId,
                        principalTable: "IoTMachines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_IoTNotifications_IoTNotificationsId",
                        column: x => x.IoTNotificationsId,
                        principalTable: "IoTNotifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_IoTVariables_IoTVariablesId",
                        column: x => x.IoTVariablesId,
                        principalTable: "IoTVariables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_IoTs_IoTsId",
                        column: x => x.IoTsId,
                        principalTable: "IoTs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_Locations_LocationsId",
                        column: x => x.LocationsId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_Machines_MachinesId",
                        column: x => x.MachinesId,
                        principalTable: "Machines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_MetalUnitTypes_MetalUnitTypesId",
                        column: x => x.MetalUnitTypesId,
                        principalTable: "MetalUnitTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_MetalUnits_MetalUnitsId",
                        column: x => x.MetalUnitsId,
                        principalTable: "MetalUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_ModelQuestions_ModelQuestionsId",
                        column: x => x.ModelQuestionsId,
                        principalTable: "ModelQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_PackingLists_PackingListsId",
                        column: x => x.PackingListsId,
                        principalTable: "PackingLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_PaymentTerms_PaymentTermsId",
                        column: x => x.PaymentTermsId,
                        principalTable: "PaymentTerms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_PaymentTypes_PaymentTypesId",
                        column: x => x.PaymentTypesId,
                        principalTable: "PaymentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_Payments_PaymentsId",
                        column: x => x.PaymentsId,
                        principalTable: "Payments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_PlanPayments_PlanPaymentsId",
                        column: x => x.PlanPaymentsId,
                        principalTable: "PlanPayments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_Plans_PlansId",
                        column: x => x.PlansId,
                        principalTable: "Plans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Companies_Processes_ProcessesId",
                        column: x => x.ProcessesId,
                        principalTable: "Processes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_ProductTypes_ProductTypesId",
                        column: x => x.ProductTypesId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_ProductionInfos_ProductionInfosId",
                        column: x => x.ProductionInfosId,
                        principalTable: "ProductionInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_ProductionOrderDetails_ProductionOrderDetailsId",
                        column: x => x.ProductionOrderDetailsId,
                        principalTable: "ProductionOrderDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_ProductionOrderFiles_ProductionOrderFilesId",
                        column: x => x.ProductionOrderFilesId,
                        principalTable: "ProductionOrderFiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_ProductionOrderProcesses_ProductionOrderProcessesId",
                        column: x => x.ProductionOrderProcessesId,
                        principalTable: "ProductionOrderProcesses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_ProductionOrders_ProductionOrdersId",
                        column: x => x.ProductionOrdersId,
                        principalTable: "ProductionOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_ProductionStops_ProductionStopsId",
                        column: x => x.ProductionStopsId,
                        principalTable: "ProductionStops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_Sectors_SectorsId",
                        column: x => x.SectorsId,
                        principalTable: "Sectors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_Shapes_ShapesId",
                        column: x => x.ShapesId,
                        principalTable: "Shapes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_Shifts_ShiftsId",
                        column: x => x.ShiftsId,
                        principalTable: "Shifts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_ShipmentCompanies_ShipmentsCompaniesId",
                        column: x => x.ShipmentsCompaniesId,
                        principalTable: "ShipmentCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_StartPorts_StartPortsId",
                        column: x => x.StartPortsId,
                        principalTable: "StartPorts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_Steels_SteelEntityId",
                        column: x => x.SteelEntityId,
                        principalTable: "Steels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_StopsCategories_StopsCategoriesId",
                        column: x => x.StopsCategoriesId,
                        principalTable: "StopsCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_Stops_StopsId",
                        column: x => x.StopsId,
                        principalTable: "Stops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_SubSectors_SubSectorsId",
                        column: x => x.SubSectorsId,
                        principalTable: "SubSectors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_SupplierTypes_SupplierTypesId",
                        column: x => x.SupplierTypesId,
                        principalTable: "SupplierTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_Suppliers_SuppliersId",
                        column: x => x.SuppliersId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_Thicknesses_ThicknessEntityId",
                        column: x => x.ThicknessEntityId,
                        principalTable: "Thicknesses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_TransportCompanies_TransportCompaniesId",
                        column: x => x.TransportCompaniesId,
                        principalTable: "TransportCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_Units_UnitsId",
                        column: x => x.UnitsId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_WHLocations_WHLocationEntityId",
                        column: x => x.WHLocationEntityId,
                        principalTable: "WHLocations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RawMaterials",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    RawCode = table.Column<string>(maxLength: 8, nullable: true),
                    Name = table.Column<string>(maxLength: 80, nullable: true),
                    WarehouseDate = table.Column<DateTime>(nullable: false),
                    RawMaterialTypesId = table.Column<int>(nullable: false),
                    WHLocationsId = table.Column<int>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    PackingListsId = table.Column<int>(nullable: false),
                    ProductionOrdersId = table.Column<int>(nullable: true),
                    RawMaterialTypeEntityId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RawMaterials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RawMaterials_PackingLists_PackingListsId",
                        column: x => x.PackingListsId,
                        principalTable: "PackingLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RawMaterials_ProductionOrders_ProductionOrdersId",
                        column: x => x.ProductionOrdersId,
                        principalTable: "ProductionOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RawMaterials_RawMaterialTypes_RawMaterialTypeEntityId",
                        column: x => x.RawMaterialTypeEntityId,
                        principalTable: "RawMaterialTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RawMaterials_MetalUnitTypes_RawMaterialTypesId",
                        column: x => x.RawMaterialTypesId,
                        principalTable: "MetalUnitTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RawMaterials_WHLocations_WHLocationsId",
                        column: x => x.WHLocationsId,
                        principalTable: "WHLocations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 80, nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    Position = table.Column<string>(maxLength: 80, nullable: false),
                    FilePath = table.Column<string>(nullable: true),
                    CompaniesId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Companies_CompaniesId",
                        column: x => x.CompaniesId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AbnormalityDetails_AbnormalityTypesId",
                table: "AbnormalityDetails",
                column: "AbnormalityTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_AbnormalityPlaceDetails_AbnormalityPlacesId",
                table: "AbnormalityPlaceDetails",
                column: "AbnormalityPlacesId");

            migrationBuilder.CreateIndex(
                name: "IX_AbnormalityTypes_AffectationsId",
                table: "AbnormalityTypes",
                column: "AffectationsId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CompaniesId",
                table: "AspNetUsers",
                column: "CompaniesId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BioCareSurveyAnswers_BioCareSurveyQuestionsId",
                table: "BioCareSurveyAnswers",
                column: "BioCareSurveyQuestionsId");

            migrationBuilder.CreateIndex(
                name: "IX_BioCareSurveyAnswers_EmployeesId",
                table: "BioCareSurveyAnswers",
                column: "EmployeesId");

            migrationBuilder.CreateIndex(
                name: "IX_BOMDetails_BOMsId",
                table: "BOMDetails",
                column: "BOMsId");

            migrationBuilder.CreateIndex(
                name: "IX_BOMDetails_ProductsId",
                table: "BOMDetails",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_BOMs_InstallationsId",
                table: "BOMs",
                column: "InstallationsId");

            migrationBuilder.CreateIndex(
                name: "IX_BOMs_MethodsId",
                table: "BOMs",
                column: "MethodsId");

            migrationBuilder.CreateIndex(
                name: "IX_BOMs_ProductsId",
                table: "BOMs",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_CalendarEvents_CalendarCategoriesId",
                table: "CalendarEvents",
                column: "CalendarCategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_CalendarEvents_CalendarsId",
                table: "CalendarEvents",
                column: "CalendarsId");

            migrationBuilder.CreateIndex(
                name: "IX_Channels_SpecieId",
                table: "Channels",
                column: "SpecieId");

            migrationBuilder.CreateIndex(
                name: "IX_CommImports_ImportsId",
                table: "CommImports",
                column: "ImportsId");

            migrationBuilder.CreateIndex(
                name: "IX_CommImports_SuppliersId",
                table: "CommImports",
                column: "SuppliersId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_AreasId",
                table: "Companies",
                column: "AreasId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_BanksId",
                table: "Companies",
                column: "BanksId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_BrandsId",
                table: "Companies",
                column: "BrandsId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_CategoryModelsId",
                table: "Companies",
                column: "CategoryModelsId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_CommImportsId",
                table: "Companies",
                column: "CommImportsId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_ContainerTypesId",
                table: "Companies",
                column: "ContainerTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_ContainersId",
                table: "Companies",
                column: "ContainersId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_CountriesId",
                table: "Companies",
                column: "CountriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_CurrenciesId",
                table: "Companies",
                column: "CurrenciesId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_CustomsAgenciesId",
                table: "Companies",
                column: "CustomsAgenciesId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_DimensionEntityId",
                table: "Companies",
                column: "DimensionEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_EmployeeTypesId",
                table: "Companies",
                column: "EmployeeTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_EmployeesId",
                table: "Companies",
                column: "EmployeesId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_EvaluationCategoriesId",
                table: "Companies",
                column: "EvaluationCategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_FinishEntityId",
                table: "Companies",
                column: "FinishEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_FinishPortsId",
                table: "Companies",
                column: "FinishPortsId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_IdealModelQuestionsId",
                table: "Companies",
                column: "IdealModelQuestionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_ImportDetailsId",
                table: "Companies",
                column: "ImportDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_ImportFilesId",
                table: "Companies",
                column: "ImportFilesId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_ImportsId",
                table: "Companies",
                column: "ImportsId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_IncotermsId",
                table: "Companies",
                column: "IncotermsId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_IoTAlertsId",
                table: "Companies",
                column: "IoTAlertsId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_IoTMachinesId",
                table: "Companies",
                column: "IoTMachinesId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_IoTNotificationsId",
                table: "Companies",
                column: "IoTNotificationsId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_IoTVariablesId",
                table: "Companies",
                column: "IoTVariablesId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_IoTsId",
                table: "Companies",
                column: "IoTsId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_LocationsId",
                table: "Companies",
                column: "LocationsId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_MachinesId",
                table: "Companies",
                column: "MachinesId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_MetalUnitTypesId",
                table: "Companies",
                column: "MetalUnitTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_MetalUnitsId",
                table: "Companies",
                column: "MetalUnitsId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_ModelQuestionsId",
                table: "Companies",
                column: "ModelQuestionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_PackingListsId",
                table: "Companies",
                column: "PackingListsId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_PaymentTermsId",
                table: "Companies",
                column: "PaymentTermsId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_PaymentTypesId",
                table: "Companies",
                column: "PaymentTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_PaymentsId",
                table: "Companies",
                column: "PaymentsId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_PlanPaymentsId",
                table: "Companies",
                column: "PlanPaymentsId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_PlansId",
                table: "Companies",
                column: "PlansId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_ProcessesId",
                table: "Companies",
                column: "ProcessesId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_ProductTypesId",
                table: "Companies",
                column: "ProductTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_ProductionInfosId",
                table: "Companies",
                column: "ProductionInfosId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_ProductionOrderDetailsId",
                table: "Companies",
                column: "ProductionOrderDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_ProductionOrderFilesId",
                table: "Companies",
                column: "ProductionOrderFilesId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_ProductionOrderProcessesId",
                table: "Companies",
                column: "ProductionOrderProcessesId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_ProductionOrdersId",
                table: "Companies",
                column: "ProductionOrdersId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_ProductionStopsId",
                table: "Companies",
                column: "ProductionStopsId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_ProductsId",
                table: "Companies",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_SectorsId",
                table: "Companies",
                column: "SectorsId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_ShapesId",
                table: "Companies",
                column: "ShapesId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_ShiftsId",
                table: "Companies",
                column: "ShiftsId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_ShipmentsCompaniesId",
                table: "Companies",
                column: "ShipmentsCompaniesId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_StartPortsId",
                table: "Companies",
                column: "StartPortsId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_StatusId",
                table: "Companies",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_SteelEntityId",
                table: "Companies",
                column: "SteelEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_StopsCategoriesId",
                table: "Companies",
                column: "StopsCategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_StopsId",
                table: "Companies",
                column: "StopsId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_SubSectorsId",
                table: "Companies",
                column: "SubSectorsId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_SupplierTypesId",
                table: "Companies",
                column: "SupplierTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_SuppliersId",
                table: "Companies",
                column: "SuppliersId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_ThicknessEntityId",
                table: "Companies",
                column: "ThicknessEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_TransportCompaniesId",
                table: "Companies",
                column: "TransportCompaniesId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_UnitsId",
                table: "Companies",
                column: "UnitsId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_WHLocationEntityId",
                table: "Companies",
                column: "WHLocationEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Containers_ContainerTypesId",
                table: "Containers",
                column: "ContainerTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_Containers_ImportsId",
                table: "Containers",
                column: "ImportsId");

            migrationBuilder.CreateIndex(
                name: "IX_ControlEPPDetails_ControlEPPsId",
                table: "ControlEPPDetails",
                column: "ControlEPPsId");

            migrationBuilder.CreateIndex(
                name: "IX_ControlEPPDetails_EmployeesId",
                table: "ControlEPPDetails",
                column: "EmployeesId");

            migrationBuilder.CreateIndex(
                name: "IX_ControlEPPDetails_ProtectionElementsId",
                table: "ControlEPPDetails",
                column: "ProtectionElementsId");

            migrationBuilder.CreateIndex(
                name: "IX_ControlEPPs_EmployeesId",
                table: "ControlEPPs",
                column: "EmployeesId");

            migrationBuilder.CreateIndex(
                name: "IX_ControlEPPs_StatusId",
                table: "ControlEPPs",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerComms_CustomersId",
                table: "CustomerComms",
                column: "CustomersId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerFiles_CustomersId",
                table: "CustomerFiles",
                column: "CustomersId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CurrenciesId",
                table: "Customers",
                column: "CurrenciesId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CustomerTypesId",
                table: "Customers",
                column: "CustomerTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_DiscountListsId",
                table: "Customers",
                column: "DiscountListsId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_InstallationsId",
                table: "Customers",
                column: "InstallationsId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_PaymentMethodsId",
                table: "Customers",
                column: "PaymentMethodsId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_PaymentTermsId",
                table: "Customers",
                column: "PaymentTermsId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_PriceListsId",
                table: "Customers",
                column: "PriceListsId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_TaxesId",
                table: "Customers",
                column: "TaxesId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_VendorsId",
                table: "Customers",
                column: "VendorsId");

            migrationBuilder.CreateIndex(
                name: "IX_CutsOfMeats_ChannelId",
                table: "CutsOfMeats",
                column: "ChannelId");

            migrationBuilder.CreateIndex(
                name: "IX_DiagnosticDetails_DiagnosticsId",
                table: "DiagnosticDetails",
                column: "DiagnosticsId");

            migrationBuilder.CreateIndex(
                name: "IX_DiagnosticDetails_ModelQuestionsId",
                table: "DiagnosticDetails",
                column: "ModelQuestionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Diagnostics_EmployeesId",
                table: "Diagnostics",
                column: "EmployeesId");

            migrationBuilder.CreateIndex(
                name: "IX_Diagnostics_StatusId",
                table: "Diagnostics",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Diagnostics_SubSectorsId",
                table: "Diagnostics",
                column: "SubSectorsId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmployeeTypesId",
                table: "Employees",
                column: "EmployeeTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_FinishPorts_CountriesId",
                table: "FinishPorts",
                column: "CountriesId");

            migrationBuilder.CreateIndex(
                name: "IX_IdealModelQuestions_ModelQuestionsId",
                table: "IdealModelQuestions",
                column: "ModelQuestionsId");

            migrationBuilder.CreateIndex(
                name: "IX_IdealModelQuestions_SubSectorsId",
                table: "IdealModelQuestions",
                column: "SubSectorsId");

            migrationBuilder.CreateIndex(
                name: "IX_ImportDetails_ImportsId",
                table: "ImportDetails",
                column: "ImportsId");

            migrationBuilder.CreateIndex(
                name: "IX_ImportDetails_ProductsId",
                table: "ImportDetails",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_ImportFiles_ImportsId",
                table: "ImportFiles",
                column: "ImportsId");

            migrationBuilder.CreateIndex(
                name: "IX_Imports_CurrenciesId",
                table: "Imports",
                column: "CurrenciesId");

            migrationBuilder.CreateIndex(
                name: "IX_Imports_CustomsAgenciesId",
                table: "Imports",
                column: "CustomsAgenciesId");

            migrationBuilder.CreateIndex(
                name: "IX_Imports_FinishPortsId",
                table: "Imports",
                column: "FinishPortsId");

            migrationBuilder.CreateIndex(
                name: "IX_Imports_IncotermsId",
                table: "Imports",
                column: "IncotermsId");

            migrationBuilder.CreateIndex(
                name: "IX_Imports_PaymentMethodEntityId",
                table: "Imports",
                column: "PaymentMethodEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Imports_PaymentTermsId",
                table: "Imports",
                column: "PaymentTermsId");

            migrationBuilder.CreateIndex(
                name: "IX_Imports_ShipmentCompaniesId",
                table: "Imports",
                column: "ShipmentCompaniesId");

            migrationBuilder.CreateIndex(
                name: "IX_Imports_StartPortsId",
                table: "Imports",
                column: "StartPortsId");

            migrationBuilder.CreateIndex(
                name: "IX_Imports_StatusId",
                table: "Imports",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Imports_SuppliersId",
                table: "Imports",
                column: "SuppliersId");

            migrationBuilder.CreateIndex(
                name: "IX_Imports_TransportCompaniesId",
                table: "Imports",
                column: "TransportCompaniesId");

            migrationBuilder.CreateIndex(
                name: "IX_IoTAlerts_IoTNotificationsId",
                table: "IoTAlerts",
                column: "IoTNotificationsId");

            migrationBuilder.CreateIndex(
                name: "IX_IoTAlerts_IoTVariablesId",
                table: "IoTAlerts",
                column: "IoTVariablesId");

            migrationBuilder.CreateIndex(
                name: "IX_IoTAlerts_IoTsId",
                table: "IoTAlerts",
                column: "IoTsId");

            migrationBuilder.CreateIndex(
                name: "IX_IoTDataAlertNotifications_EmployeesId",
                table: "IoTDataAlertNotifications",
                column: "EmployeesId");

            migrationBuilder.CreateIndex(
                name: "IX_IoTNotifications_IoTsId",
                table: "IoTNotifications",
                column: "IoTsId");

            migrationBuilder.CreateIndex(
                name: "IX_IoTVariables_IoTsId",
                table: "IoTVariables",
                column: "IoTsId");

            migrationBuilder.CreateIndex(
                name: "IX_Machines_BrandsId",
                table: "Machines",
                column: "BrandsId");

            migrationBuilder.CreateIndex(
                name: "IX_Machines_IoTMachineEntityId",
                table: "Machines",
                column: "IoTMachineEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Machines_LocationsId",
                table: "Machines",
                column: "LocationsId");

            migrationBuilder.CreateIndex(
                name: "IX_Machines_ProcessesId",
                table: "Machines",
                column: "ProcessesId");

            migrationBuilder.CreateIndex(
                name: "IX_Machines_StatusId",
                table: "Machines",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_MetalUnits_DimensionsId",
                table: "MetalUnits",
                column: "DimensionsId");

            migrationBuilder.CreateIndex(
                name: "IX_MetalUnits_FinishesesId",
                table: "MetalUnits",
                column: "FinishesesId");

            migrationBuilder.CreateIndex(
                name: "IX_MetalUnits_MetalUnitTypesId",
                table: "MetalUnits",
                column: "MetalUnitTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_MetalUnits_SteelsId",
                table: "MetalUnits",
                column: "SteelsId");

            migrationBuilder.CreateIndex(
                name: "IX_MetalUnits_ThicknessesId",
                table: "MetalUnits",
                column: "ThicknessesId");

            migrationBuilder.CreateIndex(
                name: "IX_MetalUnits_WHLocationsId",
                table: "MetalUnits",
                column: "WHLocationsId");

            migrationBuilder.CreateIndex(
                name: "IX_ModelQuestions_CategoryModelsId",
                table: "ModelQuestions",
                column: "CategoryModelsId");

            migrationBuilder.CreateIndex(
                name: "IX_ModelQuestions_EvaluationCategoriesId",
                table: "ModelQuestions",
                column: "EvaluationCategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_ModuleRoles_SubModulesId",
                table: "ModuleRoles",
                column: "SubModulesId");

            migrationBuilder.CreateIndex(
                name: "IX_Modules_ModuleCategoriesId",
                table: "Modules",
                column: "ModuleCategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_MovementDetails_MovementBasicsId",
                table: "MovementDetails",
                column: "MovementBasicsId");

            migrationBuilder.CreateIndex(
                name: "IX_PackingLists_ImportDetailsId",
                table: "PackingLists",
                column: "ImportDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_PackingLists_ImportsId",
                table: "PackingLists",
                column: "ImportsId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_BanksId",
                table: "Payments",
                column: "BanksId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_CurrenciesId",
                table: "Payments",
                column: "CurrenciesId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_ImportsId",
                table: "Payments",
                column: "ImportsId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_PaymentTypesId",
                table: "Payments",
                column: "PaymentTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanPayments_PaymentTypesId",
                table: "PlanPayments",
                column: "PaymentTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanPayments_PlansId",
                table: "PlanPayments",
                column: "PlansId");

            migrationBuilder.CreateIndex(
                name: "IX_PriceCuts_MeatCuttingId",
                table: "PriceCuts",
                column: "MeatCuttingId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionInfos_ProductionOrdersId",
                table: "ProductionInfos",
                column: "ProductionOrdersId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionInfos_ProductsId",
                table: "ProductionInfos",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionOrderDetails_EmployeesId",
                table: "ProductionOrderDetails",
                column: "EmployeesId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionOrderDetails_ProductionOrdersId",
                table: "ProductionOrderDetails",
                column: "ProductionOrdersId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionOrderFiles_ProductionOrdersId",
                table: "ProductionOrderFiles",
                column: "ProductionOrdersId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionOrderProcesses_EmployeesId",
                table: "ProductionOrderProcesses",
                column: "EmployeesId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionOrderProcesses_MachinesId",
                table: "ProductionOrderProcesses",
                column: "MachinesId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionOrderProcesses_ProductionOrdersId",
                table: "ProductionOrderProcesses",
                column: "ProductionOrdersId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionOrders_ProductsId",
                table: "ProductionOrders",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionOrders_ShiftsId",
                table: "ProductionOrders",
                column: "ShiftsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionOrders_StatusId",
                table: "ProductionOrders",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionStops_EmployeesId",
                table: "ProductionStops",
                column: "EmployeesId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionStops_MachinesId",
                table: "ProductionStops",
                column: "MachinesId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionStops_ProductionOrdersId",
                table: "ProductionStops",
                column: "ProductionOrdersId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionStops_StopsId",
                table: "ProductionStops",
                column: "StopsId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductTypesId",
                table: "Products",
                column: "ProductTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ShapesId",
                table: "Products",
                column: "ShapesId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_UnitsId",
                table: "Products",
                column: "UnitsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProtectionElements_ProtectionTypesId",
                table: "ProtectionElements",
                column: "ProtectionTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_ProtectionElements_UnitsId",
                table: "ProtectionElements",
                column: "UnitsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProtectionTypes_ProtectionCategoriesId",
                table: "ProtectionTypes",
                column: "ProtectionCategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_QuantitySaleTops_MeatCuttingId",
                table: "QuantitySaleTops",
                column: "MeatCuttingId");

            migrationBuilder.CreateIndex(
                name: "IX_RawMaterials_PackingListsId",
                table: "RawMaterials",
                column: "PackingListsId");

            migrationBuilder.CreateIndex(
                name: "IX_RawMaterials_ProductionOrdersId",
                table: "RawMaterials",
                column: "ProductionOrdersId");

            migrationBuilder.CreateIndex(
                name: "IX_RawMaterials_RawMaterialTypeEntityId",
                table: "RawMaterials",
                column: "RawMaterialTypeEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_RawMaterials_RawMaterialTypesId",
                table: "RawMaterials",
                column: "RawMaterialTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_RawMaterials_WHLocationsId",
                table: "RawMaterials",
                column: "WHLocationsId");

            migrationBuilder.CreateIndex(
                name: "IX_RouteOperations_ProcessesId",
                table: "RouteOperations",
                column: "ProcessesId");

            migrationBuilder.CreateIndex(
                name: "IX_RouteOperations_RoutesId",
                table: "RouteOperations",
                column: "RoutesId");

            migrationBuilder.CreateIndex(
                name: "IX_Routes_InstallationsId",
                table: "Routes",
                column: "InstallationsId");

            migrationBuilder.CreateIndex(
                name: "IX_StartPorts_CountriesId",
                table: "StartPorts",
                column: "CountriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Stops_AreasId",
                table: "Stops",
                column: "AreasId");

            migrationBuilder.CreateIndex(
                name: "IX_Stops_StopsCategoriesId",
                table: "Stops",
                column: "StopsCategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_StrippingDetails_ChannelId",
                table: "StrippingDetails",
                column: "ChannelId");

            migrationBuilder.CreateIndex(
                name: "IX_StrippingDetails_StrippingId",
                table: "StrippingDetails",
                column: "StrippingId");

            migrationBuilder.CreateIndex(
                name: "IX_Strips_StatusId",
                table: "Strips",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCuts_MainCutId",
                table: "SubCuts",
                column: "MainCutId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCuts_SubCutId",
                table: "SubCuts",
                column: "SubCutId");

            migrationBuilder.CreateIndex(
                name: "IX_SubModules_ModulesId",
                table: "SubModules",
                column: "ModulesId");

            migrationBuilder.CreateIndex(
                name: "IX_SubSectors_SectorsId",
                table: "SubSectors",
                column: "SectorsId");

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_CountriesId",
                table: "Suppliers",
                column: "CountriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_SupplierTypesId",
                table: "Suppliers",
                column: "SupplierTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskTypes_JobsId",
                table: "TaskTypes",
                column: "JobsId");

            migrationBuilder.CreateIndex(
                name: "IX_Tools_StatusId",
                table: "Tools",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Tools_ToolTypesId",
                table: "Tools",
                column: "ToolTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendors_InstallationsId",
                table: "Vendors",
                column: "InstallationsId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendors_VendorTypesId",
                table: "Vendors",
                column: "VendorTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_WareHouses_WareHouseTypesId",
                table: "WareHouses",
                column: "WareHouseTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_YieldMeatCuts_MeatCuttingId",
                table: "YieldMeatCuts",
                column: "MeatCuttingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AbnormalityDetails");

            migrationBuilder.DropTable(
                name: "AbnormalityPlaceDetails");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BioCareSurveyAnswers");

            migrationBuilder.DropTable(
                name: "BOMDetails");

            migrationBuilder.DropTable(
                name: "CalendarEvents");

            migrationBuilder.DropTable(
                name: "ControlEPPDetails");

            migrationBuilder.DropTable(
                name: "CustomerComms");

            migrationBuilder.DropTable(
                name: "CustomerFiles");

            migrationBuilder.DropTable(
                name: "DiagnosticDetails");

            migrationBuilder.DropTable(
                name: "EmailJobConfigs");

            migrationBuilder.DropTable(
                name: "IoTDataAlertNotifications");

            migrationBuilder.DropTable(
                name: "IoTDatas");

            migrationBuilder.DropTable(
                name: "ModuleRoles");

            migrationBuilder.DropTable(
                name: "MovementClasses");

            migrationBuilder.DropTable(
                name: "MovementDetails");

            migrationBuilder.DropTable(
                name: "Movements");

            migrationBuilder.DropTable(
                name: "MovementTypes");

            migrationBuilder.DropTable(
                name: "PriceCuts");

            migrationBuilder.DropTable(
                name: "QuantitySaleTops");

            migrationBuilder.DropTable(
                name: "RawMaterials");

            migrationBuilder.DropTable(
                name: "RouteOperations");

            migrationBuilder.DropTable(
                name: "StrippingDetails");

            migrationBuilder.DropTable(
                name: "SubCuts");

            migrationBuilder.DropTable(
                name: "TaskTypes");

            migrationBuilder.DropTable(
                name: "Tools");

            migrationBuilder.DropTable(
                name: "WareHouses");

            migrationBuilder.DropTable(
                name: "YieldMeatCuts");

            migrationBuilder.DropTable(
                name: "AbnormalityTypes");

            migrationBuilder.DropTable(
                name: "AbnormalityPlaces");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "BioCareSurveyQuestions");

            migrationBuilder.DropTable(
                name: "BOMs");

            migrationBuilder.DropTable(
                name: "CalendarCategories");

            migrationBuilder.DropTable(
                name: "Calendars");

            migrationBuilder.DropTable(
                name: "ControlEPPs");

            migrationBuilder.DropTable(
                name: "ProtectionElements");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Diagnostics");

            migrationBuilder.DropTable(
                name: "SubModules");

            migrationBuilder.DropTable(
                name: "MovementBasics");

            migrationBuilder.DropTable(
                name: "RawMaterialTypes");

            migrationBuilder.DropTable(
                name: "Routes");

            migrationBuilder.DropTable(
                name: "Strips");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "ToolTypes");

            migrationBuilder.DropTable(
                name: "WareHouseTypes");

            migrationBuilder.DropTable(
                name: "CutsOfMeats");

            migrationBuilder.DropTable(
                name: "Affectations");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Methods");

            migrationBuilder.DropTable(
                name: "ProtectionTypes");

            migrationBuilder.DropTable(
                name: "CustomerTypes");

            migrationBuilder.DropTable(
                name: "DiscountLists");

            migrationBuilder.DropTable(
                name: "PriceLists");

            migrationBuilder.DropTable(
                name: "Taxes");

            migrationBuilder.DropTable(
                name: "Vendors");

            migrationBuilder.DropTable(
                name: "Modules");

            migrationBuilder.DropTable(
                name: "Channels");

            migrationBuilder.DropTable(
                name: "CommImports");

            migrationBuilder.DropTable(
                name: "Containers");

            migrationBuilder.DropTable(
                name: "IdealModelQuestions");

            migrationBuilder.DropTable(
                name: "ImportFiles");

            migrationBuilder.DropTable(
                name: "IoTAlerts");

            migrationBuilder.DropTable(
                name: "MetalUnits");

            migrationBuilder.DropTable(
                name: "PackingLists");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "PlanPayments");

            migrationBuilder.DropTable(
                name: "ProductionInfos");

            migrationBuilder.DropTable(
                name: "ProductionOrderDetails");

            migrationBuilder.DropTable(
                name: "ProductionOrderFiles");

            migrationBuilder.DropTable(
                name: "ProductionOrderProcesses");

            migrationBuilder.DropTable(
                name: "ProductionStops");

            migrationBuilder.DropTable(
                name: "ProtectionCategories");

            migrationBuilder.DropTable(
                name: "Installations");

            migrationBuilder.DropTable(
                name: "VendorTypes");

            migrationBuilder.DropTable(
                name: "ModuleCategories");

            migrationBuilder.DropTable(
                name: "Species");

            migrationBuilder.DropTable(
                name: "ContainerTypes");

            migrationBuilder.DropTable(
                name: "ModelQuestions");

            migrationBuilder.DropTable(
                name: "SubSectors");

            migrationBuilder.DropTable(
                name: "IoTNotifications");

            migrationBuilder.DropTable(
                name: "IoTVariables");

            migrationBuilder.DropTable(
                name: "Dimensions");

            migrationBuilder.DropTable(
                name: "Finisheses");

            migrationBuilder.DropTable(
                name: "MetalUnitTypes");

            migrationBuilder.DropTable(
                name: "Steels");

            migrationBuilder.DropTable(
                name: "Thicknesses");

            migrationBuilder.DropTable(
                name: "WHLocations");

            migrationBuilder.DropTable(
                name: "ImportDetails");

            migrationBuilder.DropTable(
                name: "Banks");

            migrationBuilder.DropTable(
                name: "PaymentTypes");

            migrationBuilder.DropTable(
                name: "Plans");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Machines");

            migrationBuilder.DropTable(
                name: "ProductionOrders");

            migrationBuilder.DropTable(
                name: "Stops");

            migrationBuilder.DropTable(
                name: "CategoryModels");

            migrationBuilder.DropTable(
                name: "EvaluationCategories");

            migrationBuilder.DropTable(
                name: "Sectors");

            migrationBuilder.DropTable(
                name: "IoTs");

            migrationBuilder.DropTable(
                name: "Imports");

            migrationBuilder.DropTable(
                name: "EmployeeTypes");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "IoTMachines");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Processes");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Shifts");

            migrationBuilder.DropTable(
                name: "Areas");

            migrationBuilder.DropTable(
                name: "StopsCategories");

            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropTable(
                name: "CustomsAgencies");

            migrationBuilder.DropTable(
                name: "FinishPorts");

            migrationBuilder.DropTable(
                name: "Incoterms");

            migrationBuilder.DropTable(
                name: "PaymentMethods");

            migrationBuilder.DropTable(
                name: "PaymentTerms");

            migrationBuilder.DropTable(
                name: "ShipmentCompanies");

            migrationBuilder.DropTable(
                name: "StartPorts");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "TransportCompanies");

            migrationBuilder.DropTable(
                name: "ProductTypes");

            migrationBuilder.DropTable(
                name: "Shapes");

            migrationBuilder.DropTable(
                name: "Units");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "SupplierTypes");
        }
    }
}
