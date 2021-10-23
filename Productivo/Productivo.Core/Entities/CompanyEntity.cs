using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Productivo.Core.Interfaces;

namespace Productivo.Core.Entities
{
    public class CompanyEntity : IEntity
    {
        [Key]
        [Display(Name = "Pandora ID")]
        public int Id { get; set; }

        [StringLength(4)]
        [Required(ErrorMessage = "El codigo de la compañia es requerido.")]
        [Display(Name = "Codigo Compañia")]
        public string Code { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "El nombre de la compañia es requerido.")]
        [Display(Name = "Nombre Compañia")]
        public string Name { get; set; }

        [Display(Name = "Latitud")]
        public string Latitude { get; set; }

        [Display(Name = "Longitud")]
        public string Longitude { get; set; }

        [StringLength(100)]
        [Display(Name = "Nombre Responsable")]
        public string Owner { get; set; }

        [Display(Name = "Creado")]
        public DateTime CreatedAt { get; set; }

        [Display(Name = "Actualizado")]
        public DateTime UpdatedAt { get; set; }

        [Required(ErrorMessage = "El plan de la compañia es requerido.")]
        [Display(Name = "Plan")]
        public int PlansId { get; set; }

        [Display(Name = "Modo Uso")]
        public ConfigCompany ConfigMode { get; set; }

        [Display(Name = "Ruta Principal Server")]
        public string PathWeb { get; set; }

        public string LogoPath { get; set; }

        [Display(Name = "Sector")]
        public int? SectorsId { get; set; }

        [Display(Name = "Sub-Sector")]
        public int? SubSectorsId { get; set; }

        [Display(Name = "Plan Vigente")]
        public int? PlanPaymentsId { get; set; }

        public bool? SeederLoad { get; set; }

        public string CreateUserId { get; set; }

        public string UpdateUserId { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public int CompanyId { get; set; }

        public DateTime CreateDate { get; set; }

        public ICollection<ApplicationUser> ApplicationUsers { get; set; }

        public ProcessEntity Processes { get; set; }
        public BrandEntity Brands { get; set; }
        public MachineEntity Machines { get; set; }
        public BankEntity Banks { get; set; }
        public LocationEntity Locations { get; set; }
        public PlanEntity Plans { get; set; }
        public CountryEntity Countries { get; set; }
        public CurrencyEntity Currencies { get; set; }
        public CustomsAgencyEntity CustomsAgencies { get; set; }
        public FinishPortEntity FinishPorts { get; set; }
        public ImportEntity Imports { get; set; }
        public IncotermEntity Incoterms { get; set; }
        public PaymentTermEntity PaymentTerms { get; set; }
        public ShipmentCompanyEntity ShipmentsCompanies { get; set; }
        public StartPortEntity StartPorts { get; set; }
        public StatusEntity Status { get; set; }
        public SupplierEntity Suppliers { get; set; }
        public SupplierTypeEntity SupplierTypes { get; set; }
        public TransportCompanyEntity TransportCompanies { get; set; }
        public ImportDetailEntity ImportDetails { get; set; }
        public ProductEntity Products { get; set; }
        public UnitEntity Units { get; set; }
        public ProductTypeEntity ProductTypes { get; set; }
        public ContainerEntity Containers { get; set; }
        public ContainerTypeEntity ContainerTypes { get; set; }
        public CommImportEntity CommImports { get; set; }
        public ImportFileEntity ImportFiles { get; set; }
        public PackingListEntity PackingLists { get; set; }
        public PaymentTypeEntity PaymentTypes { get; set; }
        public PaymentEntity Payments { get; set; }
        public PlanPaymentEntity PlanPayments { get; set; }
        public ShiftEntity Shifts { get; set; }
        public ProductionOrderEntity ProductionOrders { get; set; }
        public MetalUnitEntity MetalUnits { get; set; }
        public MetalUnitTypeEntity MetalUnitTypes { get; set; }
        public ProductionInfoEntity ProductionInfos { get; set; }
        public ProductionOrderDetailEntity ProductionOrderDetails { get; set; }
        public ProductionStopEntity ProductionStops { get; set; }
        public ProductionOrderProcessEntity ProductionOrderProcesses { get; set; }
        public EmployeeEntity Employees { get; set; }
        public EmployeeTypeEntity EmployeeTypes { get; set; }
        public StopsCategoryEntity StopsCategories { get; set; }
        public AreaEntity Areas { get; set; }
        public StopEntity Stops { get; set; }
        public ProductionOrderFileEntity ProductionOrderFiles { get; set; }
        public ShapeEntity Shapes { get; set; }
        public SectorEntity Sectors { get; set; }
        public SubSectorEntity SubSectors { get; set; }
        public CategoryModelEntity CategoryModels { get; set; }
        public EvaluationCategoryEntity EvaluationCategories { get; set; }
        public IoTEntity IoTs { get; set; }
        public IoTAlertEntity IoTAlerts { get; set; }
        public IoTMachineEntity IoTMachines { get; set; }
        public IoTNotificationEntity IoTNotifications { get; set; }
        public IoTVariableEntity IoTVariables { get; set; }
        public ModelQuestionEntity ModelQuestions { get; set; }
        public IdealModelQuestionEntity IdealModelQuestions { get; set; }



        public enum ConfigCompany
        {
            ERP,
            StandAlone,
            Mix
        }

    }
}
