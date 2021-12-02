using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;


namespace Productivo.Infrastructure.Helpers
{
    public class CombosHelper : ICombosHelper
    {
        private readonly ProductivoContext _context;

        public CombosHelper(ProductivoContext context)
        {
            _context = context;
        }

        IEnumerable<SelectListItem> ICombosHelper.PlansDropDownList()
        {
            var list = _context.Plans.Select(t => new SelectListItem
            {
                Text = t.Name,
                Value = t.Id.ToString()
            })
      .OrderBy(t => t.Text)
      .ToList();
            return list;
        }

        IEnumerable<SelectListItem> ICombosHelper.MetalUnitsDropDownList(int companyId)
        {
            //var metalUnitsUsed = _context.ProductionOrders.Where(x => x.CompanyId == companyId).Select(x => x.MetalUnitsId).ToList();
            var metalUnitsUsed = _context.ProductionOrders.Where(x => x.CompanyId == companyId).ToList();
            var list = _context.MetalUnits.Where(x => x.CompanyId == companyId)
            //var list = _context.MetalUnits.Where(x => x.CompanyId == companyId && !metalUnitsUsed.Contains(x.Id))

            .Select(t => new SelectListItem
            {
                Text = t.MetalCode,
                Value = t.Id.ToString()
            })
      .OrderBy(t => t.Text)
      .ToList();
            return list;
        }

        IEnumerable<SelectListItem> ICombosHelper.CompaniesDropDownList()
        {
            var list = _context.Companies.Select(t => new SelectListItem
            {
                Text = t.Name,
                Value = t.Id.ToString()
            })
      .OrderBy(t => t.Text)
      .ToList();
            return list;
        }

        IEnumerable<SelectListItem> ICombosHelper.EmployeeTypeDropDownList(int companyId)
        {
            var list = _context.EmployeeTypes.Where(x => x.CompanyId == companyId)
            .Select(t => new SelectListItem
            {
                Text = t.Name,
                Value = t.Id.ToString()
            })
          .OrderBy(t => t.Text)
          .ToList();
            return list;
        }
        IEnumerable<SelectListItem> ICombosHelper.CountriesDropDownList(int companyId)
        {
            var list = _context.Countries.Where(x => x.CompanyId == companyId)
            .Select(t => new SelectListItem
            {
                Text = t.Name,
                Value = t.Id.ToString()
            })
            .OrderBy(t => t.Text)
            .ToList();
            return list;
        }

        IEnumerable<SelectListItem> ICombosHelper.StatusDropDownList(int companyId, string module)
        {
            var list = _context.Status.Where(x => x.CompanyId == companyId && x.Module == module)
            .Select(t => new SelectListItem
            {
                Text = t.Name,
                Value = t.Id.ToString()
            })
            .OrderBy(t => t.Text)
            .ToList();
            return list;
        }

        IEnumerable<SelectListItem> ICombosHelper.StatusDropDownListSST(int companyId)
        {
            var list = _context.Status.Where(x => x.CompanyId == companyId).Where(ty => ty.Module == "SST")
            .Select(t => new SelectListItem
            {
                Text = t.Name,
                Value = t.Id.ToString()
            })
            .OrderBy(t => t.Text)
            .ToList();
            return list;
        }

        IEnumerable<SelectListItem> ICombosHelper.ProcessesDropDownList(int companyId)
        {
            var list = _context.Processes.Where(x => x.CompanyId == companyId)
            .Select(t => new SelectListItem
            {
                Text = t.Name,
                Value = t.Id.ToString()
            })
            .OrderBy(t => t.Text)
            .ToList();
            return list;
        }

        IEnumerable<SelectListItem> ICombosHelper.LocationsDropDownList(int companyId)
        {
            var list = _context.Locations.Where(x => x.CompanyId == companyId)
            .Select(t => new SelectListItem
            {
                Text = t.Name,
                Value = t.Id.ToString()
            })
            .OrderBy(t => t.Text)
            .ToList();
            return list;
        }

        IEnumerable<SelectListItem> ICombosHelper.BrandsDropDownList(int companyId)
        {
            var list = _context.Brands.Where(x => x.CompanyId == companyId)
            .Select(t => new SelectListItem
            {
                Text = t.Name,
                Value = t.Id.ToString()
            })
            .OrderBy(t => t.Text)
            .ToList();
            return list;
        }

        IEnumerable<SelectListItem> ICombosHelper.BanksDropDownList(int companyId)
        {
            var list = _context.Banks.Where(x => x.CompanyId == companyId)
            .Select(t => new SelectListItem
            {
                Text = t.Name,
                Value = t.Id.ToString()
            })
            .OrderBy(t => t.Text)
            .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> ImportsDropDownList(int companyId)
        {
            var list = _context.Imports.Where(x => x.CompanyId == companyId)
            .Select(t => new SelectListItem
            {
                Text = t.Order,
                Value = t.Id.ToString()
            })
            .OrderBy(t => t.Text)
            .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> PaymentTypesDropDownList(int companyId)
        {
            var list = _context.PaymentTypes.Where(x => x.CompanyId == companyId)
            .Select(t => new SelectListItem
            {
                Text = t.Name,
                Value = t.Id.ToString()
            })
            .OrderBy(t => t.Text)
            .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> CurrenciesDropDownList(int companyId)
        {
            var list = _context.Currencies.Where(x => x.CompanyId == companyId)
            .Select(t => new SelectListItem
            {
                Text = t.Name,
                Value = t.Id.ToString()
            })
            .OrderBy(t => t.Text)
            .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> UnitsDropDownList(int companyId)
        {
            var list = _context.Units.Where(x => x.CompanyId == companyId)
            .Select(t => new SelectListItem
            {
                Text = t.Name,
                Value = t.Id.ToString()
            })
            .OrderBy(t => t.Text)
            .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> ProductTypesDropDownList(int companyId)
        {
            var list = _context.ProductTypes.Where(x => x.CompanyId == companyId)
            .Select(t => new SelectListItem
            {
                Text = t.Name,
                Value = t.Id.ToString()
            })
            .OrderBy(t => t.Text)
            .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> ShepesDropDownList(int companyId)
        {
            var list = _context.Shapes.Where(x => x.CompanyId == companyId)
            .Select(t => new SelectListItem
            {
                Text = t.Name,
                Value = t.Id.ToString()
            })
            .OrderBy(t => t.Text)
            .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> AreasDropDownList(int companyId)
        {
            var list = _context.Areas.Where(x => x.CompanyId == companyId)
            .Select(t => new SelectListItem
            {
                Text = t.Name,
                Value = t.Id.ToString()
            })
            .OrderBy(t => t.Text)
            .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> StopCategoriesDropDownList(int companyId)
        {
            var list = _context.StopsCategories.Where(x => x.CompanyId == companyId)
            .Select(t => new SelectListItem
            {
                Text = t.Name,
                Value = t.Id.ToString()
            })
            .OrderBy(t => t.Text)
            .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> SupplierTypesDropDownList(int companyId)
        {
            var list = _context.SupplierTypes.Where(x => x.CompanyId == companyId)
            .Select(t => new SelectListItem
            {
                Text = t.Name,
                Value = t.Id.ToString()
            })
            .OrderBy(t => t.Text)
            .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> ProductsDropDownList(int companyId)
        {
            var list = _context.Products.Where(x => x.CompanyId == companyId)
            .Select(t => new SelectListItem
            {
                Text = t.Name,
                Value = t.Id.ToString()
            })
            .OrderBy(t => t.Text)
            .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> ShiftsDropDownList(int companyId)
        {
            var list = _context.Shifts.Where(x => x.CompanyId == companyId)
            .Select(t => new SelectListItem
            {
                Text = t.Name,
                Value = t.Id.ToString()
            })
            .OrderBy(t => t.Text)
            .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> EmployeesDropDownList(int companyId)
        {
            var list = _context.Employees.Where(x => x.CompanyId == companyId).ToList()
            .Select(t => new SelectListItem
            {
                Text = t.FullName,
                Value = t.Id.ToString()
            })
            .OrderBy(t => t.Text)
            .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> MachinesDropDownList(int companyId)
        {
            var list = _context.Machines.Where(x => x.CompanyId == companyId)
            .Select(t => new SelectListItem
            {
                Text = t.Name,
                Value = t.Id.ToString()
            })
            .OrderBy(t => t.Text)
            .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> StopsDropDownList(int companyId)
        {
            var list = _context.Stops.Where(x => x.CompanyId == companyId)
            .Select(t => new SelectListItem
            {
                Text = t.Name,
                Value = t.Id.ToString()
            })
            .OrderBy(t => t.Text)
            .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> SectorsDropDownList(int companyId)
        {
            var list = _context.Sectors.Where(x => x.CompanyId == companyId)
            .Select(t => new SelectListItem
            {
                Text = t.Sector,
                Value = t.Id.ToString()
            })
            .OrderBy(t => t.Text)
            .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> SubSectorsDropDownList(int companyId, int sectorId)
        {
            var list = _context.SubSectors.Where(x => x.CompanyId == companyId && x.SectorsId == sectorId)
            .Select(t => new SelectListItem
            {
                Text = t.SubSector,
                Value = t.Id.ToString()
            })
            .OrderBy(t => t.Text)
            .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> SubSectorsDropDownList(int companyId)
        {
            var list = _context.SubSectors.Where(x => x.CompanyId == companyId)
            .Select(t => new SelectListItem
            {
                Text = t.SubSector,
                Value = t.Id.ToString()
            })
            .OrderBy(t => t.Text)
            .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> IoTVariablesDropDownList(int companyId, int IoTId)
        {
            var list = _context.IoTVariables.Where(x => x.CompanyId == companyId && x.IoTsId == IoTId)
            .Select(t => new SelectListItem
            {
                Text = t.Name,
                Value = t.Id.ToString()
            })
            .OrderBy(t => t.Text)
            .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> IoTAlertsDropDownList(int companyId, int IoTId)
        {
            var list = _context.IoTAlerts.Where(x => x.CompanyId == companyId && x.IoTsId == IoTId)
            .Select(t => new SelectListItem
            {
                Text = t.Name,
                Value = t.Id.ToString()
            })
            .OrderBy(t => t.Text)
            .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> EvaluationCategoriesDropDownList(int companyId)
        {
            var list = _context.EvaluationCategories.Where(x => x.CompanyId == companyId)
            .Select(t => new SelectListItem
            {
                Text = t.EvaluationNameCategory,
                Value = t.Id.ToString()
            })
            .OrderBy(t => t.Text)
            .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> CategoryModelsDropDownList(int companyId)
        {
            var list = _context.CategoryModels.Where(x => x.CompanyId == companyId)
            .Select(t => new SelectListItem
            {
                Text = t.ScopeNameCategory,
                Value = t.Id.ToString()
            })
            .OrderBy(t => t.Text)
            .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> ModelQuestionsDropDownList(int companyId)
        {
            var list = _context.ModelQuestions.Where(x => x.CompanyId == companyId)
            .Select(t => new SelectListItem
            {
                Text = t.QuestionName,
                Value = t.Id.ToString()
            })
            .OrderBy(t => t.Text)
            .ToList();
            return list;
        }

        IEnumerable<SelectListItem> ICombosHelper.ModelQuestionsDropDownListwoUse(int companyId, int diagnosticId)
        {
            var modelQuestionswoUsed = _context.DiagnosticDetails.Where(x => x.CompanyId == companyId && x.DiagnosticsId == diagnosticId).Select(x => x.ModelQuestionsId).ToList();
            var list = _context.ModelQuestions.Where(x => x.CompanyId == companyId && !modelQuestionswoUsed.Contains(x.Id))
            .Select(t => new SelectListItem
            {
                Text = t.QuestionName,
                Value = t.Id.ToString()
            })
            .OrderBy(t => t.Text)
            .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> AbnormalityDetailTypesDropDownList(int companyId)
        {
            var list = _context.AbnormalityTypes.Where(x => x.CompanyId == companyId)
            .Select(t => new SelectListItem
            {
                Text = t.Name,
                Value = t.Id.ToString()
            })
            .OrderBy(t => t.Text)
            .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> AffectationsDropDownList(int companyId)
        {
            var list = _context.Affectations.Where(x => x.CompanyId == companyId)
           .Select(t => new SelectListItem
           {
               Text = t.Name,
               Value = t.Id.ToString()
           })
           .OrderBy(t => t.Text)
           .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> AbnormalityPlacesDropDownList(int companyId)
        {
            var list = _context.AbnormalityPlaces.Where(x => x.CompanyId == companyId)
           .Select(t => new SelectListItem
           {
               Text = t.Name,
               Value = t.Id.ToString()
           })
           .OrderBy(t => t.Text)
           .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> WareHousesDropDownList(int companyId)
        {
            var list = _context.WareHouses.Where(x => x.CompanyId == companyId)
           .Select(t => new SelectListItem
           {
               Text = t.Name,
               Value = t.Id.ToString()
           })
           .OrderBy(t => t.Text)
           .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> WareHouseTypesDropDownList(int companyId)
        {
            var list = _context.WareHouseTypes.Where(x => x.CompanyId == companyId)
           .Select(t => new SelectListItem
           {
               Text = t.Name,
               Value = t.Id.ToString()
           })
           .OrderBy(t => t.Text)
           .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> ToolTypesDropDownList(int companyId)
        {
            var list = _context.ToolTypes.Where(x => x.CompanyId == companyId)
           .Select(t => new SelectListItem
           {
               Text = t.Name,
               Value = t.Id.ToString()
           })
           .OrderBy(t => t.Text)
           .ToList();
            return list;
        }
        public IEnumerable<SelectListItem> JobsDropDownList(int companyId)
        {
            var list = _context.Jobs.Where(x => x.CompanyId == companyId)
           .Select(t => new SelectListItem
           {
               Text = t.Name,
               Value = t.Id.ToString()
           })
           .OrderBy(t => t.Text)
           .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> ProtectionCategoriesDropDownList(int companyId)
        {
            var list = _context.ProtectionCategories.Where(x => x.CompanyId == companyId)
           .Select(t => new SelectListItem
           {
               Text = t.Name,
               Value = t.Id.ToString()
           })
           .OrderBy(t => t.Text)
           .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> ProtectionElementsDropDownList(int companyId)
        {
            var list = _context.ProtectionElements.Where(x => x.CompanyId == companyId)
           .Select(t => new SelectListItem
           {
               Text = t.Name,
               Value = t.Id.ToString()
           })
           .OrderBy(t => t.Text)
           .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> ProtectionTypesDropDownList(int companyId)
        {
            var list = _context.ProtectionTypes.Where(x => x.CompanyId == companyId)
           .Select(t => new SelectListItem
           {
               Text = t.Name,
               Value = t.Id.ToString()
           })
           .OrderBy(t => t.Text)
           .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> RawMaterialsDropDownList(int companyId)
        {
            var list = _context.RawMaterials.Where(x => x.CompanyId == companyId)
           .Select(t => new SelectListItem
           {
               Text = t.Name,
               Value = t.Id.ToString()
           })
           .OrderBy(t => t.Text)
           .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> RawMaterialTypesDropDownList(int companyId)
        {
            var list = _context.RawMaterialTypes.Where(x => x.CompanyId == companyId)
           .Select(t => new SelectListItem
           {
               Text = t.Name,
               Value = t.Id.ToString()
           })
           .OrderBy(t => t.Text)
           .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> WHLocationsDropDownList(int companyId)
        {
            var list = _context.WHLocations.Where(x => x.CompanyId == companyId)
           .Select(t => new SelectListItem
           {
               Text = t.Name,
               Value = t.Id.ToString()
           })
           .OrderBy(t => t.Text)
           .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> SuppliersDropDownList(int companyId)
        {
            var list = _context.Suppliers.Where(x => x.CompanyId == companyId)
           .Select(t => new SelectListItem
           {
               Text = t.Name,
               Value = t.Id.ToString()
           })
           .OrderBy(t => t.Text)
           .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> PaymentTermsDropDownList(int companyId)
        {
            var list = _context.PaymentTerms.Where(x => x.CompanyId == companyId)
           .Select(t => new SelectListItem
           {
               Text = t.Name,
               Value = t.Id.ToString()
           })
           .OrderBy(t => t.Text)
           .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> StartPortsDropDownList(int companyId)
        {
            var list = _context.StartPorts.Where(x => x.CompanyId == companyId)
           .Select(t => new SelectListItem
           {
               Text = t.Name,
               Value = t.Id.ToString()
           })
           .OrderBy(t => t.Text)
           .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> FinishPortsDropDownList(int companyId)
        {
            var list = _context.FinishPorts.Where(x => x.CompanyId == companyId)
           .Select(t => new SelectListItem
           {
               Text = t.Name,
               Value = t.Id.ToString()
           })
           .OrderBy(t => t.Text)
           .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> TransportCompaniesDropDownList(int companyId)
        {
            var list = _context.TransportCompanies.Where(x => x.CompanyId == companyId)
           .Select(t => new SelectListItem
           {
               Text = t.Name,
               Value = t.Id.ToString()
           })
           .OrderBy(t => t.Text)
           .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> ShipmentCompaniesDropDownList(int companyId)
        {
            var list = _context.ShipmentCompanies.Where(x => x.CompanyId == companyId)
           .Select(t => new SelectListItem
           {
               Text = t.Name,
               Value = t.Id.ToString()
           })
           .OrderBy(t => t.Text)
           .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> IncotermsDropDownList(int companyId)
        {
            var list = _context.Incoterms.Where(x => x.CompanyId == companyId)
           .Select(t => new SelectListItem
           {
               Text = t.Name,
               Value = t.Id.ToString()
           })
           .OrderBy(t => t.Text)
           .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> CustomsAgenciesDropDownList(int companyId)
        {
            var list = _context.CustomsAgencies.Where(x => x.CompanyId == companyId)
           .Select(t => new SelectListItem
           {
               Text = t.Name,
               Value = t.Id.ToString()
           })
           .OrderBy(t => t.Text)
           .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> ContainerTypesDropDownList(int companyId)
        {
            var list = _context.ContainerTypes.Where(x => x.CompanyId == companyId)
           .Select(t => new SelectListItem
           {
               Text = t.Name,
               Value = t.Id.ToString()
           })
           .OrderBy(t => t.Text)
           .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> ModuleCategoriesDropDownList(int companyId)
        {
            var list = _context.ModuleCategories.Where(x => x.CompanyId == companyId)
           .Select(t => new SelectListItem
           {
               Text = t.Name,
               Value = t.Id.ToString()
           })
           .OrderBy(t => t.Text)
           .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> ModulesDropDownList(int companyId)
        {
            var list = _context.Modules.Where(x => x.CompanyId == companyId)
           .Select(t => new SelectListItem
           {
               Text = t.Name,
               Value = t.Id.ToString()
           })
           .OrderBy(t => t.Text)
           .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> CalendarCategoriesDropDownList(int companyId)
        {
            var list = _context.CalendarCategories.Where(x => x.CompanyId == companyId)
           .Select(t => new SelectListItem
           {
               Text = t.Name,
               Value = t.Id.ToString()
           })
           .OrderBy(t => t.Text)
           .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> CalendarDropDownList(int companyId)
        {
            var list = _context.Calendars.Where(x => x.CompanyId == companyId)
           .Select(t => new SelectListItem
           {
               Text = t.Name,
               Value = t.Id.ToString()
           })
           .OrderBy(t => t.Text)
           .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> SubModuleDropDownList(int companyId)
        {
            var list = _context.SubModules.Where(x => x.CompanyId == companyId)
           .Select(t => new SelectListItem
           {
               Text = t.Name,
               Value = t.Id.ToString()
           })
           .OrderBy(t => t.Text)
           .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> InstallationsDropDownList(int companyId)
        {
            var list = _context.Installations.Where(x => x.CompanyId == companyId)
           .Select(t => new SelectListItem
           {
               Text = t.Name,
               Value = t.Id.ToString()
           })
           .OrderBy(t => t.Text)
           .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> MethodsDropDownList(int companyId)
        {
            var list = _context.Methods.Where(x => x.CompanyId == companyId)
           .Select(t => new SelectListItem
           {
               Text = t.Name,
               Value = t.Id.ToString()
           })
           .OrderBy(t => t.Text)
           .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> ComponentsDropDownList(int companyId)
        {
            var list = _context.Products.Where(x => x.CompanyId == companyId && x.ProductTypes.Name == "Insumos")
            .Select(t => new SelectListItem
            {
                Text = t.Name,
                Value = t.Id.ToString()
            })
            .OrderBy(t => t.Text)
            .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> BomsDropDownList(int companyId, int productId)
        {
            var list = (_context.BOMs
                .Include(x => x.Methods)
                .Include(x => x.Installations)
                .Where(x => x.CompanyId == companyId && x.ProductsId == productId).ToList())
            .Select(t => new SelectListItem
            {
                Text = (t.Installations.Name + " | " + t.Methods.Name),
                Value = t.Id.ToString()
            })
            .OrderBy(t => t.Text)
            .ToList();
            return list;


        }

        public IEnumerable<SelectListItem> CustomersDropDownList(int companyId)
        {
            var list = _context.Customers.Where(x => x.CompanyId == companyId)
           .Select(t => new SelectListItem
           {
               Text = t.Name,
               Value = t.Id.ToString()
           })
           .OrderBy(t => t.Text)
           .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> CustomerTypesDropDownList(int companyId)
        {
            var list = _context.CustomerTypes.Where(x => x.CompanyId == companyId)
           .Select(t => new SelectListItem
           {
               Text = t.Name,
               Value = t.Id.ToString()
           })
           .OrderBy(t => t.Text)
           .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> VendorsDropDownList(int companyId)
        {
            var list = _context.Vendors.Where(x => x.CompanyId == companyId)
           .Select(t => new SelectListItem
           {
               Text = t.Name,
               Value = t.Id.ToString()
           })
           .OrderBy(t => t.Text)
           .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> TaxesDropDownList(int companyId)
        {
            var list = _context.Taxes.Where(x => x.CompanyId == companyId)
           .Select(t => new SelectListItem
           {
               Text = t.Name,
               Value = t.Id.ToString()
           })
           .OrderBy(t => t.Text)
           .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> PriceListsDropDownList(int companyId)
        {
            var list = _context.PriceLists.Where(x => x.CompanyId == companyId)
           .Select(t => new SelectListItem
           {
               Text = t.Name,
               Value = t.Id.ToString()
           })
           .OrderBy(t => t.Text)
           .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> DiscountListsDropDownList(int companyId)
        {
            var list = _context.DiscountLists.Where(x => x.CompanyId == companyId)
           .Select(t => new SelectListItem
           {
               Text = t.Name,
               Value = t.Id.ToString()
           })
           .OrderBy(t => t.Text)
           .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> PaymentMethodsDropDownList(int companyId)
        {
            var list = _context.PaymentMethods.Where(x => x.CompanyId == companyId)
           .Select(t => new SelectListItem
           {
               Text = t.Name,
               Value = t.Id.ToString()
           })
           .OrderBy(t => t.Text)
           .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> MovementBasicsDropDownList(int companyId)
        {
            var list = _context.MovementBasics.Where(x => x.CompanyId == companyId)
           .Select(t => new SelectListItem
           {
               Text = t.Name,
               Value = t.Id.ToString()
           })
           .OrderBy(t => t.Text)
           .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> MovementDetailsDropDownList(int companyId)
        {
            var list = _context.MovementDetails.Where(x => x.CompanyId == companyId)
           .Select(t => new SelectListItem
           {
               Text = t.Name,
               Value = t.Id.ToString()
           })
           .OrderBy(t => t.Text)
           .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> SpeciesDropDownList(int companyId)
        {
            var list = _context.Species.Where(x => x.CompanyId == companyId)
           .Select(t => new SelectListItem
           {
               Text = t.Name,
               Value = t.Id.ToString()
           })
           .OrderBy(t => t.Text)
           .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> ChannelsDropDownList(int companyId)
        {
            var list = _context.Channels.Include(x => x.Specie).Where(x => x.CompanyId == companyId)
           .Select(t => new SelectListItem
           {
               Text = t.Name,
               Value = t.Id.ToString()
           })
           .OrderBy(t => t.Text)
           .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> ChannelCategoriesDropDownList(int companyId)
        {
            var list = _context.ChannelCategories.Where(x => x.CompanyId == companyId)
           .Select(t => new SelectListItem
           {
               Text = t.Name,
               Value = t.Id.ToString()
           })
           .OrderBy(t => t.Text)
           .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> CutsDropDownList(int companyId, int id)
        {
            var list = _context.CutsOfMeats.Where(x => x.CompanyId == companyId && x.Id != id)
           .Select(t => new SelectListItem
           {
               Text = t.Name,
               Value = t.Id.ToString()
           })
           .OrderBy(t => t.Text)
           .ToList();
            return list;
        }
    }
}

