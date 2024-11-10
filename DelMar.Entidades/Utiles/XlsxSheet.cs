using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelMar.Entidades.Utiles
{
    public class XlsxSheet
    {

        /// <summary>
        /// Nombre de la Hoja.
        /// </summary>
        public string NombreHoja { get; set; }
        /// <summary>
        /// Información adicional 1 que se quiere agregar como encabezado
        /// [opcional -> vacio o null si no se usa]
        /// </summary>
        public string Info1 { get; set; }
        /// <summary>
        /// Información adicional 2 que se quiere agregar como encabezado
        /// [opcional -> vacio o null si no se usa]
        /// </summary>
        public string Info2 { get; set; }
        /// <summary>
        /// Datos a exportar en formato de grilla (matriz de objetos).
        /// </summary>
        public object[,] RawData { get; set; }
        /// <summary>
        /// Datos a exportar en formato de grilla (matriz de objetos) a modo de resumen.
        /// A continuación de los datos principales con una fila de separación.
        /// [opcional -> null si no se usa]
        /// </summary>
        public object[,] RawDataSummary { get; set; }

        /// <summary>
        /// Constructor principal para la exportación a XLS usando esta interfaz.
        /// </summary>
        /// <param name="nombreHoja">Nombre de la Hoja.</param>
        /// <param name="info1">Información adicional 1 que se quiere agregar como encabezado
        /// [opcional -> vacio o null si no se usa]</param>
        /// <param name="info2">Información adicional 2 que se quiere agregar como encabezado
        /// [opcional -> vacio o null si no se usa]</param>
        /// <param name="rawData">Datos a exportar en formato de grilla (matriz de objetos).</param>
        /// <param name="rawDataSummary">Datos a exportar en formato de grilla (matriz) a modo de resumen.
        /// A continuación de los datos principales con una fila de separación.
        /// [opcional -> null si no se usa]</param>
        public XlsxSheet(string nombreHoja, string info1, string info2, object[,] rawData, object[,] rawDataSummary)
        {
            NombreHoja = nombreHoja;
            Info1 = info1;
            Info2 = info2;
            RawData = rawData;
            RawDataSummary = rawDataSummary;
        }

        /// <summary>
        /// Datos de la Hoja.
        /// </summary>
        public override string ToString() => "Hoja: " + NombreHoja + " - Info: " + Info1 + " - " + Info2;

    }
}
