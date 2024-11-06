using System.Linq.Expressions;

namespace DelMar.Negocio.Interfaces.Base
{
    internal interface IGenericRepository<T> where T : class
    {
        bool Insert(T obj);
        bool Update(T obj);
        IEnumerable<T> GetAll();
        T GetById(int id);
        bool Delete(T obj);
        IEnumerable<T> GetAllByCondition(Expression<Func<T, bool>> where);
        public T GetByCondition(Expression<Func<T, bool>> where);
        bool Save();
    }
}
