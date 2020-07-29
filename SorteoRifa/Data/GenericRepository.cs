namespace SorteoRifa.Data
{
    using SorteoRifa.Data.Entities;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Remoting.Contexts;
    using System.Threading.Tasks;

    public class GenericRepository<T> : IGenericRepository<T> where T : class, IEntity
    {
        DataContext context = new DataContext();

        public GenericRepository(DataContext context)
        {
            this.context = context;
        }

        public void Create(T entity)
        {
            var tb = context.Set<T>();
            tb.Add(entity);
            SaveAll();
        }

        public void Delete(T entity)
        {
            this.context.Set<T>().Remove(entity);
            SaveAll();
        }

        private void SaveAll()
        {
            this.context.SaveChanges();
        }

        public bool Exist(int id)
        {
            var tb = context.Set<T>();
            return tb.Any(e => e.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            return context.Set<T>().AsNoTracking();
        }

        public T GetById(int id)
        {
            return context.Set<T>().FirstOrDefault(e => e.Id == id);
        }
        
    }
}
