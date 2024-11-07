using DelMar.DB.UOF;
using DelMar.Entidades.Models;
using DelMar.Negocio.Interfaces;

namespace DelMar.Negocio.Servicios
{
    public class CategoriaService : ICategoriaService
    {
        private readonly IUnitOfWork _unitOfWork;
        public CategoriaService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public bool Delete(Categoria categoria)
        {
            return _unitOfWork.Categorias.Delete(categoria);
        }

        public List<Categoria> GetAll()
        {
            return _unitOfWork.Categorias.GetAll().ToList();
        }

        public bool Insert(Categoria categoria)
        {
            return _unitOfWork.Categorias.Insert(categoria);
        }

        public bool Update(Categoria categoria)
        {
            return _unitOfWork.Categorias.Update(categoria);
        }
    }
}
