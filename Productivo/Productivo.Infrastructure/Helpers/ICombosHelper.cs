using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Productivo.Infrastructure.Helpers
{
    public interface ICombosHelper
    {
        IEnumerable<SelectListItem> PlansDropDownList();

        IEnumerable<SelectListItem> MetalUnitsDropDownList(int companyId);

        IEnumerable<SelectListItem> CompaniesDropDownList();

        IEnumerable<SelectListItem> EmployeeTypeDropDownList(int companyId);

        IEnumerable<SelectListItem> CountriesDropDownList(int companyId);

        IEnumerable<SelectListItem> StatusDropDownList(int companyId, string module);

        IEnumerable<SelectListItem> StatusDropDownListSST(int companyId);

        IEnumerable<SelectListItem> LocationsDropDownList(int companyId);

        IEnumerable<SelectListItem> ProcessesDropDownList(int companyId);

        IEnumerable<SelectListItem> BrandsDropDownList(int companyId);

        IEnumerable<SelectListItem> BanksDropDownList(int companyId);

        IEnumerable<SelectListItem> ImportsDropDownList(int companyId);

        IEnumerable<SelectListItem> PaymentTypesDropDownList(int companyId);

        IEnumerable<SelectListItem> CurrenciesDropDownList(int companyId);

        IEnumerable<SelectListItem> UnitsDropDownList(int companyId);

        IEnumerable<SelectListItem> ProductTypesDropDownList(int companyId);

        IEnumerable<SelectListItem> ShepesDropDownList(int companyId);

        IEnumerable<SelectListItem> AreasDropDownList(int companyId);

        IEnumerable<SelectListItem> StopCategoriesDropDownList(int companyId);

        IEnumerable<SelectListItem> SupplierTypesDropDownList(int companyId);

        IEnumerable<SelectListItem> ProductsDropDownList(int companyId);

        IEnumerable<SelectListItem> ShiftsDropDownList(int companyId);

        IEnumerable<SelectListItem> EmployeesDropDownList(int companyId);

        IEnumerable<SelectListItem> MachinesDropDownList(int companyId);

        IEnumerable<SelectListItem> StopsDropDownList(int companyId);

        IEnumerable<SelectListItem> SectorsDropDownList(int companyId);

        IEnumerable<SelectListItem> SubSectorsDropDownList(int companyId, int sectorId);

        IEnumerable<SelectListItem> SubSectorsDropDownList(int companyId);

        IEnumerable<SelectListItem> IoTVariablesDropDownList(int companyId, int IoTId);

        IEnumerable<SelectListItem> IoTAlertsDropDownList(int companyId, int IoTId);

        IEnumerable<SelectListItem> EvaluationCategoriesDropDownList(int companyId);

        IEnumerable<SelectListItem> CategoryModelsDropDownList(int companyId);

        IEnumerable<SelectListItem> ModelQuestionsDropDownList(int companyId);

        IEnumerable<SelectListItem> ModelQuestionsDropDownListwoUse(int companyId, int diagnosticId);

        IEnumerable<SelectListItem> AbnormalityDetailTypesDropDownList(int companyId);

        IEnumerable<SelectListItem> AffectationsDropDownList(int companyId);

        IEnumerable<SelectListItem> AbnormalityPlacesDropDownList(int companyId);

        IEnumerable<SelectListItem> WareHousesDropDownList(int companyId);

        IEnumerable<SelectListItem> WareHouseTypesDropDownList(int companyId);

        IEnumerable<SelectListItem> ToolTypesDropDownList(int companyId);

        IEnumerable<SelectListItem> JobsDropDownList(int companyId);

        IEnumerable<SelectListItem> ProtectionCategoriesDropDownList(int companyId);

        IEnumerable<SelectListItem> ProtectionElementsDropDownList(int companyId);

        IEnumerable<SelectListItem> ProtectionTypesDropDownList(int companyId);

        IEnumerable<SelectListItem> RawMaterialsDropDownList(int companyId);

        IEnumerable<SelectListItem> RawMaterialTypesDropDownList(int companyId);

        IEnumerable<SelectListItem> WHLocationsDropDownList(int companyId);

        IEnumerable<SelectListItem> SuppliersDropDownList(int companyId);

        IEnumerable<SelectListItem> PaymentTermsDropDownList(int companyId);

        IEnumerable<SelectListItem> StartPortsDropDownList(int companyId);

        IEnumerable<SelectListItem> FinishPortsDropDownList(int companyId);

        IEnumerable<SelectListItem> TransportCompaniesDropDownList(int companyId);

        IEnumerable<SelectListItem> ShipmentCompaniesDropDownList(int companyId);

        IEnumerable<SelectListItem> IncotermsDropDownList(int companyId);

        IEnumerable<SelectListItem> CustomsAgenciesDropDownList(int companyId);

        IEnumerable<SelectListItem> ContainerTypesDropDownList(int companyId);

        IEnumerable<SelectListItem> InstallationsDropDownList(int companyId);

        IEnumerable<SelectListItem> MethodsDropDownList(int companyId);

        IEnumerable<SelectListItem> ModuleCategoriesDropDownList(int companyId);

        IEnumerable<SelectListItem> ModulesDropDownList(int companyId);

        IEnumerable<SelectListItem> CalendarCategoriesDropDownList(int companyId);

        IEnumerable<SelectListItem> CalendarDropDownList(int companyId);

        IEnumerable<SelectListItem> SubModuleDropDownList(int companyId);

        IEnumerable<SelectListItem> ComponentsDropDownList(int companyId);

        IEnumerable<SelectListItem> BomsDropDownList(int companyId, int productId);

        IEnumerable<SelectListItem> CustomersDropDownList(int companyId);

        IEnumerable<SelectListItem> CustomerTypesDropDownList(int companyId);

        IEnumerable<SelectListItem> VendorsDropDownList(int companyId);

        IEnumerable<SelectListItem> TaxesDropDownList(int companyId);

        IEnumerable<SelectListItem> PriceListsDropDownList(int companyId);

        IEnumerable<SelectListItem> DiscountListsDropDownList(int companyId);

        IEnumerable<SelectListItem> PaymentMethodsDropDownList(int companyId);

        IEnumerable<SelectListItem> MovementBasicsDropDownList(int companyId);

        IEnumerable<SelectListItem> MovementDetailsDropDownList(int companyId);

        IEnumerable<SelectListItem> SpeciesDropDownList(int companyId);

        IEnumerable<SelectListItem> ChannelsDropDownList(int companyId);

        IEnumerable<SelectListItem> ChannelCategoriesDropDownList(int companyId);

        IEnumerable<SelectListItem> CutsDropDownList(int companyId, int cut);

    }
}
