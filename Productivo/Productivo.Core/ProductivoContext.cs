using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Productivo.Core.Entities;

namespace Productivo.Core
{
    public class ProductivoContext : IdentityDbContext<ApplicationUser>
    {
        public ProductivoContext(DbContextOptions<ProductivoContext> options) : base(options) { }

        public DbSet<CompanyEntity> Companies { get; set; }
        public DbSet<PlanEntity> Plans { get; set; }
        public DbSet<AreaEntity> Areas { get; set; }
        public DbSet<BankEntity> Banks { get; set; }
        public DbSet<BioCareSurveyAnswerEntity> BioCareSurveyAnswers { get; set; }
        public DbSet<BioCareSurveyQuestionEntity> BioCareSurveyQuestions { get; set; }
        public DbSet<BrandEntity> Brands { get; set; }
        public DbSet<CategoryModelEntity> CategoryModels { get; set; }
        public DbSet<CommImportEntity> CommImports { get; set; }
        public DbSet<ContainerEntity> Containers { get; set; }
        public DbSet<ContainerTypeEntity> ContainerTypes { get; set; }
        public DbSet<CountryEntity> Countries { get; set; }
        public DbSet<CurrencyEntity> Currencies { get; set; }
        public DbSet<CustomsAgencyEntity> CustomsAgencies { get; set; }
        public DbSet<DiagnosticEntity> Diagnostics { get; set; }
        public DbSet<DiagnosticDetailEntity> DiagnosticDetails { get; set; }
        public DbSet<DimensionEntity> Dimensions { get; set; }
        public DbSet<EmployeeEntity> Employees { get; set; }
        public DbSet<EmployeeTypeEntity> EmployeeTypes { get; set; }
        public DbSet<EvaluationCategoryEntity> EvaluationCategories { get; set; }
        public DbSet<FinishEntity> Finisheses { get; set; }
        public DbSet<FinishPortEntity> FinishPorts { get; set; }
        public DbSet<IdealModelQuestionEntity> IdealModelQuestions { get; set; }
        public DbSet<ImportDetailEntity> ImportDetails { get; set; }
        public DbSet<ImportEntity> Imports { get; set; }
        public DbSet<ImportFileEntity> ImportFiles { get; set; }
        public DbSet<IncotermEntity> Incoterms { get; set; }
        public DbSet<IoTEntity> IoTs { get; set; }
        public DbSet<IoTAlertEntity> IoTAlerts { get; set; }
        public DbSet<IoTMachineEntity> IoTMachines { get; set; }
        public DbSet<IoTNotificationEntity> IoTNotifications { get; set; }
        public DbSet<IoTVariableEntity> IoTVariables { get; set; }
        public DbSet<IoTDataEntity> IoTDatas { get; set; }
        public DbSet<LocationEntity> Locations { get; set; }
        public DbSet<MachineEntity> Machines { get; set; }
        public DbSet<MetalUnitEntity> MetalUnits { get; set; }
        public DbSet<MetalUnitTypeEntity> MetalUnitTypes { get; set; }
        public DbSet<ModelQuestionEntity> ModelQuestions { get; set; }
        public DbSet<PackingListEntity> PackingLists { get; set; }
        public DbSet<PaymentEntity> Payments { get; set; }
        public DbSet<PaymentTypeEntity> PaymentTypes { get; set; }
        public DbSet<PaymentTermEntity> PaymentTerms { get; set; }
        public DbSet<PlanPaymentEntity> PlanPayments { get; set; }
        public DbSet<ProcessEntity> Processes { get; set; }
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<ProductionInfoEntity> ProductionInfos { get; set; }
        public DbSet<ProductionOrderDetailEntity> ProductionOrderDetails { get; set; }
        public DbSet<ProductionOrderEntity> ProductionOrders { get; set; }
        public DbSet<ProductionOrderFileEntity> ProductionOrderFiles { get; set; }
        public DbSet<ProductionOrderProcessEntity> ProductionOrderProcesses { get; set; }
        public DbSet<ProductionStopEntity> ProductionStops { get; set; }
        public DbSet<ProductTypeEntity> ProductTypes { get; set; }
        public DbSet<SectorEntity> Sectors { get; set; }
        public DbSet<ShapeEntity> Shapes { get; set; }
        public DbSet<ShiftEntity> Shifts { get; set; }
        public DbSet<ShipmentCompanyEntity> ShipmentCompanies { get; set; }
        public DbSet<StartPortEntity> StartPorts { get; set; }
        public DbSet<StatusEntity> Status { get; set; }
        public DbSet<SteelEntity> Steels { get; set; }
        public DbSet<StopEntity> Stops { get; set; }
        public DbSet<StopsCategoryEntity> StopsCategories { get; set; }
        public DbSet<SubSectorEntity> SubSectors { get; set; }
        public DbSet<SupplierEntity> Suppliers { get; set; }
        public DbSet<SupplierTypeEntity> SupplierTypes { get; set; }
        public DbSet<ThicknessEntity> Thicknesses { get; set; }
        public DbSet<TransportCompanyEntity> TransportCompanies { get; set; }
        public DbSet<UnitEntity> Units { get; set; }
        public DbSet<WHLocationEntity> WHLocations { get; set; }
        public DbSet<AffectationEntity> Affectations { get; set; }
        public DbSet<AbnormalityTypeEntity> AbnormalityTypes { get; set; }
        public DbSet<AbnormalityDetailEntity> AbnormalityDetails { get; set; }
        public DbSet<AbnormalityPlaceEntity> AbnormalityPlaces { get; set; }
        public DbSet<AbnormalityPlaceDetailEntity> AbnormalityPlaceDetails { get; set; }
        public DbSet<WareHouseEntity> WareHouses { get; set; }
        public DbSet<WareHouseTypeEntity> WareHouseTypes { get; set; }
        public DbSet<ToolEntity> Tools { get; set; }
        public DbSet<ToolTypeEntity> ToolTypes { get; set; }
        public DbSet<TaskTypeEntity> TaskTypes { get; set; }
        public DbSet<ProtectionTypeEntity> ProtectionTypes { get; set; }
        public DbSet<ProtectionCategoryEntity> ProtectionCategories { get; set; }
        public DbSet<JobEntity> Jobs { get; set; }
        public DbSet<ControlEPPEntity> ControlEPPs { get; set; }
        public DbSet<ControlEPPDetailEntity> ControlEPPDetails { get; set; }
        public DbSet<ProtectionElementEntity> ProtectionElements { get; set; }
        public DbSet<RawMaterialEntity> RawMaterials { get; set; }
        public DbSet<RawMaterialTypeEntity> RawMaterialTypes { get; set; }
        public DbSet<EmailJobConfigEntity> EmailJobConfigs { get; set; }
        public DbSet<IoTDataAlertNotificationEntity> IoTDataAlertNotifications { get; set; }
        public DbSet<MethodEntity> Methods { get; set; }
        public DbSet<BOMEntity> BOMs { get; set; }
        public DbSet<RouteEntity> Routes { get; set; }
        public DbSet<InstallationEntity> Installations { get; set; }
        public DbSet<RouteOperationEntity> RouteOperations { get; set; }
        public DbSet<BOMDetailEntity> BOMDetails { get; set; }
        public DbSet<CalendarEntity> Calendars { get; set; }
        public DbSet<CalendarCategoryEntity> CalendarCategories { get; set; }
        public DbSet<CalendarEventEntity> CalendarEvents { get; set; }
        public DbSet<ModuleEntity> Modules { get; set; }
        public DbSet<ModuleRolEntity> ModuleRoles { get; set; }
        public DbSet<SubModuleEntity> SubModules { get; set; }
        public DbSet<ModuleCategoryEntity> ModuleCategories { get; set; }
        public DbSet<CustomerEntity> Customers { get; set; }
        public DbSet<CustomerTypeEntity> CustomerTypes { get; set; }
        public DbSet<VendorEntity> Vendors { get; set; }
        public DbSet<VendorTypeEntity> VendorTypes { get; set; }
        public DbSet<TaxEntity> Taxes { get; set; }
        public DbSet<PriceListEntity> PriceLists { get; set; }
        public DbSet<DiscountListEntity> DiscountLists { get; set; }
        public DbSet<PaymentMethodEntity> PaymentMethods { get; set; }
        public DbSet<CustomerFileEntity> CustomerFiles { get; set; }
        public DbSet<CustomerCommEntity> CustomerComms { get; set; }
        public DbSet<MovementBasicEntity> MovementBasics { get; set; }
        public DbSet<MovementTypeEntity> MovementTypes { get; set; }
        public DbSet<MovementEntity> Movements { get; set; }
        public DbSet<MovementClassEntity> MovementClasses { get; set; }
        public DbSet<MovementDetailEntity> MovementDetails { get; set; }

        public DbSet<SpecieEntity> Species { get; set; }
        public DbSet<ChannelEntity> Channels { get; set; }
        public DbSet<ChannelCategoryEntity> ChannelCategories { get; set; }
        public DbSet<MeatCuttingEntity> CutsOfMeats { get; set; }
        public DbSet<StrippingEntity> Strips  { get; set; }
        public DbSet<StrippingDetailEntity> StrippingDetails { get; set; }
        public DbSet<YieldMeatCutting> YieldMeatCuts { get; set; }
        public DbSet<QuantitySaleTop> QuantitySaleTops { get; set; }
        public DbSet<PriceCutEntity> PriceCuts { get; set; }
        public DbSet<SubCutEntity> SubCuts { get; set; }
        

    }
}
