using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract.Repo
{
    public interface IGenericRepo<T> where T : class
    {
        IEnumerable<T> All();
        T GetById(int id);
        bool Add(T entity);
        bool Delete(int id);
        bool Update(T entity);
        bool Save();
    }
}
