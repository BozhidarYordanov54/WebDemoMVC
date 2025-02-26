
using Microsoft.EntityFrameworkCore;
using WebDemo.Infrastrucutre.Data;

namespace WebDemo.Infrastructure.Data.Common
{
    public class Repository : IRepository
    {
        private readonly DbContext _context;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }

        private DbSet<T> DbSet<T>() where T : class
        {
            return _context.Set<T>();
        }

        //accessor isAsync returnType AddAsync<Entity_Name>
        public async Task AddAsync<T>(T entity) where T : class
        {
            await DbSet<T>().AddAsync(entity);
        }

        public async Task AddRangeAsync<T>(IEnumerable<T> entities) where T : class
        {
            await _context.AddRangeAsync(entities);
        }

        public async Task DeleteAsync<T>(object entity) where T : class
        {
            T entityToDelete = await FindByIdAsync<T>(entity);

            DbSet<T>().Remove(entityToDelete);
        }

        public async Task<T> FindByIdAsync<T>(object id) where T : class
        {
            T? entity = await DbSet<T>().FindAsync(id);

            if(entity == null)
            {
                throw new ArgumentNullException("Entity not found");
            }

            return entity;
        }

        public IQueryable<T> AllAsNoTrackingAsync<T>() where T : class
        {
            return DbSet<T>().AsNoTracking();
        }

        public IQueryable<T> AllAsync<T>() where T : class
        {
            return DbSet<T>();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}