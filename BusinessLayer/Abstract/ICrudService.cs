using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{    public interface ICrudService<T> where T : class
    {
        bool Create(T entity);
        bool Save();
        bool Update(T entity);
        bool Delete(T entity);
        T GetById(int id);
        IEnumerable<T> FetchAll();
    }
}
