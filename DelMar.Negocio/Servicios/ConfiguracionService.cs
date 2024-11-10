using DelMar.DB.UOF;
using DelMar.Entidades.Models;
using DelMar.Negocio.Interfaces;

namespace DelMar.Negocio.Servicios
{
    public class ConfiguracionService : IConfiguracionService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ConfiguracionService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Configuracion GetByIdProveedor(int idProveedor)
        {
            return _unitOfWork.Configuraciones.GetByCondition(c => c.IdProveedor == idProveedor);
        }
    }
}
