using DelMar.DB;
using DelMar.DB.Interfaces.Base;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DelMar.DB.Repositorios
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DelMarContext _context;

        public GenericRepository(DelMarContext context)
        {
            _context = context;
        }
        public bool Delete(T model)
        {
            _context.Set<T>().Remove(model);
            return Save();
        }


        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }


        public IEnumerable<T> GetAllByCondition(Expression<Func<T, bool>> where)
        {
            return _context.Set<T>().Where(where).ToList();
        }

        public T GetByCondition(Expression<Func<T, bool>> where)
        {
            return _context.Set<T>().Where(where).SingleOrDefault();
        }

        public T GetById(int id)
        {
            var model = _context.Set<T>().Find(id);
            if (model == null)
                throw new Exception("Objeto no encontrado en la BD");
            return model;
        }

        public bool Insert(T model)
        {
            _context.Add(model);
            return Save();
        }

        public bool Save()
        {
            return _context.SaveChanges() > 0;
        }

        public bool Update(T model)
        {
            _context.Update(model);
            return Save();
        }
    }
}
