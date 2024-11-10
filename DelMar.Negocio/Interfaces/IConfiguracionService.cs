using DelMar.Entidades.Models;

namespace DelMar.Negocio.Interfaces
{
    public interface IConfiguracionService
    {
        Configuracion GetByIdProveedor(int idProveedor);
    }
}
