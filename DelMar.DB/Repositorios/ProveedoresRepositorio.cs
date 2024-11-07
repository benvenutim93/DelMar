using DelMar.DB.Interfaces;
using DelMar.Entidades.Models;

namespace DelMar.DB.Repositorios
{
    public class ProveedoresRepositorio : GenericRepository<Proveedor>, IProveedoresRepositorio
    {
        public ProveedoresRepositorio(DelMarContext context) : base(context)
        {

        }
    }
}
