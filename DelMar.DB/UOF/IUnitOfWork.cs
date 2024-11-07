using DelMar.DB.Interfaces;

namespace DelMar.DB.UOF
{
    public interface IUnitOfWork : IDisposable
    {
        IArticulosRepositorio Articulos { get; }
        IProveedoresRepositorio Proveedores { get; }
        ICategoriaRepositorio Categorias { get; }
        IConfiguracionesRepositorio Configuraciones { get; }
    }
}
