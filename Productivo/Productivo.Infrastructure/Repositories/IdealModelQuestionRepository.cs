using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    class IdealModelQuestionRepository : GenericRepository<IdealModelQuestionEntity>, IIdealModelQuestionRepository
    {
        private readonly ProductivoContext _context;

        public IdealModelQuestionRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<IdealModelQuestionEntity>> GetAllByCompanyId(int companyId)
        {
            return await _context.IdealModelQuestions.Where(x => x.CompanyId == companyId).ToListAsync();
        }

        public async Task<bool> ExistBySubSectorId(int subSectorId)
        {
            return (await _context.IdealModelQuestions.Where(x => x.SubSectorsId == subSectorId).ToListAsync()).Count > 0;
        }

        public async Task<IEnumerable<IdealModelQuestionEntity>> GetAllByCompanyIdAndSubSectorId(int companyId, int subSectorId)
        {
            return await _context.IdealModelQuestions.Where(x => x.CompanyId == companyId && x.SubSectorsId == subSectorId).ToListAsync();
        }
    }

}
