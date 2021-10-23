using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class BioCareSurveyAnswerRepository : GenericRepository<BioCareSurveyAnswerEntity>, IBioCareSurveyAnswerRepository
    {
        private readonly ProductivoContext _context;

        public BioCareSurveyAnswerRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<BioCareSurveyAnswerEntity>> GetAllByCompanyId(int companyId) => await _context.BioCareSurveyAnswers.Where(x => x.CompanyId == companyId).Include(x => x.Employees).ToListAsync();
        public async Task<IEnumerable<BioCareSurveyAnswerEntity>> GetAllByCompanyIdAndDateTime(int companyId, DateTime date)
        {
            return await _context.BioCareSurveyAnswers
                .Where(x => x.CompanyId == companyId && ((DateTime)x.SurveyDate).Date == date.Date)
                .Include(x => x.Employees)
                .ToListAsync();
        }
    }
}
