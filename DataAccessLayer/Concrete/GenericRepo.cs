using DataAccessLayer.Abstract.Repo;
using DataAccessLayer.AppDbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        protected MySqlContext _context;
        protected DbSet<T> dbSet;
        protected readonly ILogger _logger;
        public GenericRepo(MySqlContext context, ILogger logger)
        {
            _context = context;
            _logger = logger;
            dbSet = _context.Set<T>();
        }

        public virtual bool Add(T entity)
        {
            try
            {
                dbSet.Add(entity);
                return true;
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, $"{typeof(GenericRepo<>)} {nameof(Add)} threw an exception.");

            }

            return false;
        }

        public virtual IEnumerable<T> All()
        {
            try
            {
                return dbSet.ToList();
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, $"{typeof(GenericRepo<>)} {nameof(All)} threw an exception.");

            }

            return new List<T>();
        }

        public virtual bool Delete(int id)
        {
            try
            {
                var entity = dbSet.Find(id);
                if (entity != null)
                {
                    dbSet.Remove(entity);
                }
                return true;
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, $"{typeof(GenericRepo<>)} {nameof(Delete)} threw an exception.");

            }

            return false;
        }

        public virtual T GetById(int id)
        {
            T entity = null;
            try
            {
                entity =  dbSet.Find(id);

            }
            catch (Exception ex)
            {

                _logger.LogError(ex, $"{typeof(GenericRepo<>)} {nameof(GetById)} threw an exception.");

            }

            return entity;
        }

        public virtual bool Update(T entity)
        {
            try
            {
                dbSet.Update(entity);
                return true;
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, $"{typeof(GenericRepo<>)} {nameof(Delete)} threw an exception.");

            }

            return false;
        }

        public bool Save()
        {
            try
            {
                _context.SaveChanges(); ;
                return true;
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, $"{typeof(GenericRepo<>)} {nameof(Delete)} threw an exception.");

            }
            return false;
        }
    }
}
