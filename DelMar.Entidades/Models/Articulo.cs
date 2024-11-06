using System;
using System.Collections.Generic;

#nullable disable

namespace DelMar.Entidades.Models
{
    public partial class Articulo
    {
        public int Id { get; set; }
        public int IdCategoria { get; set; }
        public int IdProveedor { get; set; }
        public string Nombre { get; set; }
        public string NombreLista { get; set; }
        public int Contenido { get; set; }
        public string Unidad { get; set; }
        public decimal PrecioCosto { get; set; }
        public decimal Porcentaje { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public decimal? PrecioVenta { get; set; }
        public int? CodigoExterno { get; set; }

        public virtual Categoria IdCategoriaNavigation { get; set; }
        public virtual Proveedor IdProveedorNavigation { get; set; }
    }
}
