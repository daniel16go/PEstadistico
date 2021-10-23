using System.Threading.Tasks;
using Productivo.Core.Interfaces;
using Productivo.Infrastructure.Interfaces;

namespace Productivo.Infrastructure.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyService(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public async Task<string> GetCompanyName(int id)
        {
            var entity = await _companyRepository.GetByIdAsync(id);

            return entity.Name;
        }
    }
}
