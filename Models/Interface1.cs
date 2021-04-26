using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depenDencyInjectionWIthAutoFac.Models
{
    public  interface Irepository<T> where T:class
    {
        Task Add(T item);
        Task Remove(int Id);
        Task<T> Get(int Id);
        Task<IEnumerable<T>> GetAll();
       
    }
}
