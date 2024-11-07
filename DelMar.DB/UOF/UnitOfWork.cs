using DelMar.DB.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public IArticulosRepositorio Articulos => this._articulosRepositorio;

        public IProveedoresRepositorio Proveedores => this._proveedoresRepositorio;

        public ICategoriaRepositorio Categorias => this._categoriasRepositorio;

        public IConfiguracionesRepositorio Configuraciones => _configuracionesRepositorio;

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
