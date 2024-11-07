using DelMar.DB.Interfaces;
using DelMar.Entidades.Models;

namespace DelMar.DB.Repositorios
{
    public class ConfiguracionesRepositorio : GenericRepository<Configuracion>,IConfiguracionesRepositorio
    {
        public ConfiguracionesRepositorio(DelMarContext context) : base(context)
        {

        }
    }
}
