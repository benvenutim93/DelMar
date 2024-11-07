namespace DelMar.Negocio.Interfaces
{
    public interface IBaseService<T> where T : class
    {
        bool Insert(T model);
        bool Update(T model);
        bool Delete(T model);
        List<T> GetAll();
    }
}
