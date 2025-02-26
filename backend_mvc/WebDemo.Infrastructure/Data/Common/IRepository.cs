namespace WebDemo.Infrastructure.Data.Common
{
    public interface IRepository
    {
        //? GetAllAsync() -> Gets all data from the table
        public IQueryable<T> AllAsync<T>() where T : class;

        //? GetAllAsNoTrackingAsync() -> Gets all data from table without tracking data changes
        //! UPDATING DATA DOESN'T WOKRK
        public IQueryable<T> AllAsNoTrackingAsync<T>() where T : class;

        //* Add(T entity)
        public Task AddAsync<T>(T entity) where T : class;

        //* AddRange(IEnumerable<T> entities)
        public Task AddRangeAsync<T>(IEnumerable<T> entities) where T : class;

        //? Update(T entity)
        public Task UpdateAsync<T>(T entity) where T : class;

        //? FindById(int id)
        public Task<T> FindByIdAsync<T>(int id) where T : class;

        //! Delete(T entity)
        public Task DeleteAsync<T>(T entity) where T : class;

        //* SaveChanges()
        public Task SaveChangesAsync();

    }
}