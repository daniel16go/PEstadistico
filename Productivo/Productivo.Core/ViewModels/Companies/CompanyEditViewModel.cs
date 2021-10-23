namespace Productivo.Core.ViewModels.Companies
{
    public class CompanyEditViewModel : CompanyCreateViewModel
    {
        public int Id { get; set; }

        public string ExistingLogoPath { get; set; }
    }
}
