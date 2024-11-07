using DelMar.DB.Interfaces;
using DelMar.DB.Repositorios;

namespace DelMar.DB.UOF
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DelMarContext _context;
        private IArticulosRepositorio _articulosRepositorio;
        private IProveedoresRepositorio _proveedoresRepositorio;
        private ICategoriaRepositorio _categoriasRepositorio;
        private IConfiguracionesRepositorio _configuracionesRepositorio;

        public UnitOfWork(DelMarContext context)
        {
            _context = context;
        }
        public IArticulosRepositorio Articulos
        {
            get
            {
                if (_articulosRepositorio == null)
                    _articulosRepositorio = new ArticulosRepositorio(_context);
                return _articulosRepositorio;
            }
        }

        public IProveedoresRepositorio Proveedores
        {
            get
            {
                if (_proveedoresRepositorio == null)
                    _proveedoresRepositorio = new ProveedoresRepositorio(_context);
                return _proveedoresRepositorio;
            }
        }

        public ICategoriaRepositorio Categorias
        {
            get
            {
                if (_categoriasRepositorio == null)
                    _categoriasRepositorio = new CategoriasRepositorio(_context);
                return _categoriasRepositorio;
            }
        }

        public IConfiguracionesRepositorio Configuraciones
        {
            get
            {
                if (_configuracionesRepositorio == null)
                    _configuracionesRepositorio = new ConfiguracionesRepositorio(_context);
                return _configuracionesRepositorio;
            }
        }

        public bool IsInTransaction => _context.IsInTransaction;

        public void Commit()
        {
            _context.Commit();
        }

        public void CommitDBTransaction()
        {
            _context.CommitDBTransaction();
        }

        public void InitDBTransaction(System.Data.IsolationLevel il)
        {
            _context.InitDBTransaction(il);
        }

        public void RollbackDBTransaction()
        {
            _context.RollbackDBTransaction();
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
