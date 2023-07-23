using GACI.RentCar.Aplicacion.Contractos;
using GACI.RentCar.Infraestructura.Contexto;
using Microsoft.EntityFrameworkCore;

namespace GACI.RentCar.Infraestructura.Repositorios
{
    public class RepositorioGenerico<T> : IRepositorioGenerico<T> where T : class
    {
        protected readonly PrincipalDbContext _context;

        public RepositorioGenerico(PrincipalDbContext context)
        {
            _context = context;
        }

        public async Task<T> AddAsync(T entity)
        {
            _context.Set<T>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<T> UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
