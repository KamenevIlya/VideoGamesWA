using Microsoft.EntityFrameworkCore;
using VideoGamesWA.Data;

namespace VideoGamesWA.Repositories
{
    public class BaseRepository<T> where T : class
    {
        private readonly DataContext _context;

        private readonly DbSet<T> _dbSet;

        protected BaseRepository(DataContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public virtual void Add(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public virtual void Update(Guid id, T entity)
        {
            var obj = _dbSet.Find(entity);
            if (obj == null)
            {
                return;
            }

            foreach (var prop in typeof(T).GetProperties())
            {
                var value = prop.GetValue(entity);
                prop.SetValue(obj, value);
            }

            typeof(T).GetProperty("Id")?.SetValue(obj, Guid.NewGuid());
            _context.SaveChanges();
        }

        public virtual void Delete(Guid id)
        {
            var entity = _dbSet.Find(id);
            if (entity == null)
            {
                return;
            }

            _dbSet.Remove(entity);
            _context.SaveChanges();
        }

        public virtual T? GetById(Guid id)
        {
            return _dbSet.Find(id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }
    }
}
