using DelMar.DB.UOF;
using DelMar.Entidades.Models;
using DelMar.Entidades.Utiles;
using DelMar.Negocio.Interfaces;
using System.Collections;

namespace DelMar.Negocio.Servicios
{
    public class ArticulosService : IArticuloService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IConfiguracionService _configuracionService;
        public ArticulosService(IUnitOfWork unitOfWork, IConfiguracionService configuracionService)
        {
            _unitOfWork = unitOfWork;
            _configuracionService = configuracionService;
        }

        public bool Delete(Articulo model)
        {
            return _unitOfWork.Articulos.Delete(model);
        }
        public bool Insert(Articulo model)
        {
            return _unitOfWork.Articulos.Insert(model);
        }

        public bool Update(Articulo model)
        {
            return _unitOfWork.Articulos.Update(model);
        }

        public List<Articulo> GetAll()
        {
            return _unitOfWork.Articulos.GetAll().ToList();
        }

        /// <summary>
        /// A partir de una lectura de archivo y las configuraciones para el proveedor, se genera
        /// una lista de articulos con los precios para actualizar. 
        /// </summary>
        /// <param name="proveedor">Proveedor para obtener configuracion de archivo</param>
        /// <param name="arrayList">ArrayList generado de la lectura del archivo</param>
        /// <returns></returns>
        public List<Articulo> GetListaFromArchivoProveedor(Proveedor proveedor, ArrayList arrayList)
        {

            var listaArticulos = new List<Articulo>();

            var configuracion = _configuracionService.GetByIdProveedor(proveedor.Id);

            if (configuracion != null && arrayList.Count > 0)
            {
                foreach (var rowArray in arrayList)
                {
                    var item = rowArray.ToString().Split(';');

                    if (item.Length < configuracion.ColumnaPrecioCosto || item.Length < configuracion.ColumnaNombreLista)
                    {
                        continue;
                    }

                    var descripcionArticulo = StringUtils.Filtrar(StringUtils.QuitarAcentos(item[configuracion.ColumnaNombreLista].ToString())).Trim();
                    var precioCosto = item[configuracion.ColumnaPrecioCosto].ToString();

                    if (!string.IsNullOrEmpty(descripcionArticulo) && !string.IsNullOrWhiteSpace(descripcionArticulo))
                    {

                        var articulo = base.GetByCondition(0, descripcionArticulo, 0, 0);

                        if (articulo != null)
                        {

                            var precioSinSimbolo = StringUtils.Filtrar(precioCosto, new[] { '$' });

                            if (decimal.TryParse(precioSinSimbolo, out var precioParseado))
                            {
                                articulo.PrecioCosto = precioParseado;
                                articulo.PrecioVenta = null;
                                listaArticulos.Add(articulo);
                            }
                        }
                    }
                }
            }
            else
            {
                throw new SinConfiguracionException($"Las configuraciones de lectura del archivo para el proveedor {proveedor.Nombre} no están cargadas");
            }

            return listaArticulos;
        }


    }
}
