namespace WegeOnline.Models
{
    public interface IRepository<T> where T : class
    {
        public interface IRipository
        {
            Task<IEnumerable<T>> GetAllAsync();

            Task<IEnumerable<T>> GetAllByIdAsync<TKey>(TKey id, string propertyName, QueryOptions<T> options);

            Task<T> GetByIdAsync(int id, QueryOptions<T> options);
            Task AddAsync(T entity);
            Task UpdateAsync(T entity);
            Task DeleteAsync(int id);
        }
    }
}
