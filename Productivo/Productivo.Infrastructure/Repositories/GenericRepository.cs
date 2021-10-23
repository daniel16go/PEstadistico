using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Productivo.Core;
using Productivo.Core.Interfaces;

namespace Productivo.Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class, IEntity
    {
        private readonly ProductivoContext _context;

        public GenericRepository(ProductivoContext context)
        {
            _context = context;
        }

        public virtual async Task<IEnumerable<T>> GetAll() => await _context.Set<T>().ToListAsync();

        public virtual async Task<T> GetByIdAsync(int id) => await _context.Set<T>()
                .AsNoTracking()
                .FirstOrDefaultAsync(e => e.Id == id);

        public virtual async Task<T> CreateAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await SaveAllAsync();
            return entity;
        }

        public virtual async Task CreateListAsync(IEnumerable<T> entities)
        {
            //List<T> listT = new List<T>();
            foreach (T entity in entities)
            {
                //if(!await ExistAsync(entity.Id))
                //{
                    _context.Set<T>().Add(entity);
                /*}
                else
                {
                    listT.Add(entity);
                }*/
                
            }
            //if(listT.Count == 0)
            //{
                await SaveAllAsync();
            //}

            //return listT;
        }

        public async Task<T> UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
            await SaveAllAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            await SaveAllAsync();
        }

        public async Task<bool> ExistAsync(int id) => await _context.Set<T>().AnyAsync(e => e.Id == id);

        public async Task<bool> SaveAllAsync() => await _context.SaveChangesAsync() > 0;
        
    }
}
