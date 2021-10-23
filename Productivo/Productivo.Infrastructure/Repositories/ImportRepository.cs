using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Entities;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class ImportRepository : GenericRepository<ImportEntity>, IImportRepository
    {
        private readonly ProductivoContext _context;

        public ImportRepository(ProductivoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ImportEntity>> GetAllByCompanyId(int companyId) => await _context.Imports
              .Include(x => x.Suppliers)
              .Include(x => x.Currencies)
              .Include(x => x.PaymentTerms)
              .Include(x => x.Status)
              .Include(x => x.StartPorts)
              .Include(x => x.FinishPorts)
              .Include(x => x.TransportCompanies)
              .Include(x => x.ShipmentCompanies)
              .Include(x => x.Incoterms)
              .Include(x => x.CustomsAgencies)
              .Where(x => x.CompanyId == companyId).ToListAsync();

        public async Task<IEnumerable<ImportEntity>> GetPending(int companyId) => await _context.Imports
              .Include(x => x.Suppliers)
              .Include(x => x.Currencies)
              .Include(x => x.PaymentTerms)
              .Include(x => x.Status)
              .Include(x => x.StartPorts)
              .Include(x => x.FinishPorts)
              .Include(x => x.TransportCompanies)
              .Include(x => x.ShipmentCompanies)
              .Include(x => x.Incoterms)
              .Include(x => x.CustomsAgencies)
              .Where(x => x.CompanyId == companyId && x.Status.Name == "Pendiente").ToListAsync();

        public override async Task<ImportEntity> GetByIdAsync(int id)
        {
            return await _context.Imports
              .Include(x => x.Suppliers)
              .Include(x => x.Currencies)
              .Include(x => x.PaymentTerms)
              .Include(x => x.Status)
              .Include(x => x.StartPorts)
              .Include(x => x.FinishPorts)
              .Include(x => x.TransportCompanies)
              .Include(x => x.ShipmentCompanies)
              .Include(x => x.Incoterms)
              .Include(x => x.CustomsAgencies)
               .Include(x => x.Status).AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<bool> IsValidDelete(ImportEntity import)
        {
            ImportEntity importEntity = await _context.Imports
                                                      .Include(x => x.ImportDetails)
                                                      .Include(x => x.Containers)
                                                      .Include(x => x.CommImports)
                                                      .Include(x => x.ImportFiles)
                                                      .Include(x => x.PackingLists)
                                                      .Include(x => x.Payments)
                                                      .AsNoTracking()
                                                      .FirstOrDefaultAsync(x => x.Id == import.Id);

            bool response = importEntity.ImportDetails.Count == 0 &&
                            importEntity.Containers.Count == 0 &&
                            importEntity.CommImports.Count == 0 &&
                            importEntity.ImportFiles.Count == 0 &&
                            importEntity.PackingLists.Count == 0 &&
                            importEntity.Payments.Count == 0;

            return response;
        }
    }
}
