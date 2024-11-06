using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace DelMar.Entidades.Models
{
    public partial class Configuracion
    {
        [Key]
        public int IdProveedor { get; set; }
        public int ColumnaNombreLista { get; set; }
        public int ColumnaPrecioCosto { get; set; }
        public int? ColumnaCodigoExterno { get; set; }
    }
}
