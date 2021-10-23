using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class EmployeeTypeRepository : GenericRepository<EmployeeTypeEntity>, IEmployeeTypeRepository
    {
        private readonly ProductivoContext _context;

        public EmployeeTypeRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<EmployeeTypeEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.EmployeeTypes.Where(x => x.CompanyId == companyId).ToListAsync();
        }
    }
}
