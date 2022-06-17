using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Repos
{
    public interface IRepository<T>
    {
        T Get(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        void SaveChanges();
        IQueryable<T> GetAll();
        List<T>  GetAllObs();


    }
}
