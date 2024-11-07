using DelMar.Entidades.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DelMar.DB
{
    public class DelMarContext : DbContext
    {
        private IDbContextTransaction dbTran;
        public DelMarContext(DbContextOptions<DelMarContext> options) :base(options)
        {

        }

        public DbSet<Articulo> Articulos { get; set; }
        public DbSet<Configuracion> Configuraciones { get; set; }
        public DbSet <Proveedor> Proveedores { get; set; }
        public DbSet <Categoria> Categorias { get; set; }

                partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public void InitDBTransaction(System.Data.IsolationLevel il)
        {
            this.dbTran = this.Database.BeginTransaction(il);
        }

        public void CommitDBTransaction()
        {
            if (this.dbTran != null)
            {
                this.dbTran.Commit();
                this.dbTran = null;
            }
            else
            {
                throw new ApplicationException("Transacción no iniciada");
            }
        }

        public void RollbackDBTransaction()
        {
            if (this.dbTran != null)
            {
                this.dbTran.Rollback();
                this.dbTran = null;
            }
            else
            {
                throw new ApplicationException("Transacción no iniciada");
            }
        }

        public DbTransaction UnderlyingTransaction
        {
            get
            {
                if (this.dbTran != null)
                {
                    //return dbTran.UnderlyingTransaction;
                    return this.dbTran.GetDbTransaction();
                }
                else
                    return null;
            }
        }

        public bool IsInTransaction
        {
            get { return this.UnderlyingTransaction == null ? false : true; }
        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        public void Commit()
        {
            this.SaveChanges();
        }

        public override void Dispose()
        {
            GC.SuppressFinalize(this);
            if (dbTran != null)
            {
                //Pongo try and catch porque no puedo modificar el timeout en tiempos de ejecución
                try
                {
                    dbTran.Rollback();
                    dbTran.Dispose();
                }
                catch { }
            }
            if (this != null)
            {
                base.Dispose();
            }
        }

        public DbConnection GetConnection()
        {
            return this.Database.GetDbConnection();
        }
    }
}
