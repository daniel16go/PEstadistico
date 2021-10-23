using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class EmailJobConfigRepository : GenericRepository<EmailJobConfigEntity>, IEmailJobConfigRepository
    {
        private readonly ProductivoContext _context;

        public EmailJobConfigRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<EmailJobConfigEntity> GetAllByCompanyId(int companyId) => _context.EmailJobConfigs.Where(x => x.CompanyId == companyId).FirstOrDefault();
    }
}
