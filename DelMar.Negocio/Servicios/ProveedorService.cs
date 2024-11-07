using DelMar.DB.UOF;
using DelMar.Entidades.Models;
using DelMar.Negocio.Interfaces;

namespace DelMar.Negocio.Servicios
{
    public class ProveedorService : IProveedorService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProveedorService(IUnitOfWork unitOfWork) { 
            _unitOfWork = unitOfWork;
        }

        public List<Proveedor> GetAll()
        {
            return _unitOfWork.Proveedores.GetAll().ToList();
        }

        public bool Insert(Proveedor proveedor)
        {
            return _unitOfWork.Proveedores.Insert(proveedor);
        }

        public bool Update(Proveedor proveedor) 
        { 
            return _unitOfWork.Proveedores.Update(proveedor);
        }

        public bool Delete(Proveedor proveedor) { 
            return _unitOfWork.Proveedores.Delete(proveedor);
        }
    }
}
