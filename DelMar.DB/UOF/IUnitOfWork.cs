using DelMar.DB.Interfaces;
using System.Data;

namespace DelMar.DB.UOF
{
    public interface IUnitOfWork : IDisposable
    {
        IArticulosRepositorio Articulos { get; }
        IProveedoresRepositorio Proveedores { get; }
        ICategoriaRepositorio Categorias { get; }
        IConfiguracionesRepositorio Configuraciones { get; }

        void Commit();
        void CommitDBTransaction();
        void InitDBTransaction(IsolationLevel il);
        bool IsInTransaction { get; }
        void RollbackDBTransaction();
        Task SaveChanges();

    }
}
