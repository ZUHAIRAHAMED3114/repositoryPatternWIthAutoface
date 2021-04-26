using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Threading.Tasks;

namespace depenDencyInjectionWIthAutoFac.Models
{
    public class BaseRepostiroy<T> : Irepository<T> where T : class
    {
        private readonly DbContext context;
        private DbSet<T> dataset;
        public BaseRepostiroy(DbContext databaseContext)
        {
            this.context = databaseContext;
            this.dataset = this.context.Set<T>();
        }

        public Task Add(T item)
        {
         
            dataset.Add(item);
            context.SaveChanges();
            return Task.CompletedTask;
        }

        public Task<T> Get(int Id)
        {
            
           return Task.FromResult<T>(dataset.Find(Id));
        }

        public Task<IEnumerable<T>> GetAll()
        {
            return Task.FromResult<IEnumerable<T>>(dataset.ToList());
        }

        public Task Remove(int Id)
        {
            dataset.Remove(dataset.Find(Id));
            return Task.CompletedTask;

        }

      
    }
}