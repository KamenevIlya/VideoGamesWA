namespace VideoGamesWA.Repositories
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);

        void Update(Guid id, T entity);

        void Delete(Guid id);

        T? GetById(Guid id);

        List<T> GetAll();
    }
}
