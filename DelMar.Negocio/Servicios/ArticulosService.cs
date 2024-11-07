using DelMar.DB.UOF;
using DelMar.Negocio.Interfaces;

namespace DelMar.Negocio.Servicios
{
    public class ArticulosService : IArticuloService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ArticulosService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
