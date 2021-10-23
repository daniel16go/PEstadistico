using System.Threading.Tasks;

namespace Productivo.Infrastructure.Interfaces
{
    public interface ICompanyService
    {
        Task<string> GetCompanyName(int id);
    }
}
