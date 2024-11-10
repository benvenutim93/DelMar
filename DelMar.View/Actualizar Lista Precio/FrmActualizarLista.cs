using DelMar.Entidades.Models;
using DelMar.Entidades.Utiles;
using DelMar.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelMar.View.Actualizar_Lista_Precio
{
    public partial class FrmActualizarLista : Form
    {
        private readonly IProveedorService _proveedorService;
        private readonly IArticuloService _articuloService;

        public FrmActualizarLista(IProveedorService proveedorService, IArticuloService articuloService)
        {
            InitializeComponent();
            _proveedorService = proveedorService;
            _articuloService = articuloService;

            bsProveedores.DataSource = _proveedorService.GetAll();
        }

        private void btnAdjuntar_Click(object sender, EventArgs e)
        {
            try
            {

                ofdListaPrecios.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                ofdListaPrecios.Filter = "CSV (*.csv)|*.csv";
                ofdListaPrecios.FileName = string.Empty;

                if (ofdListaPrecios.ShowDialog() == DialogResult.OK)
                {

                    //Cursor = Cursors.WaitCursor;
                    //var proveedor = (Proveedor)bsProveedores.Current;
                    //var arrayListArticulos = FileUtils.GetArrayListFromFile(ofdListaPrecios.FileName);
                    //var articuloNegocio = new ArticuloNegocio();

                    //var listaArticulosParaGrabar = articuloNegocio.GetListaFromArchivoProveedor(proveedor, arrayListArticulos);

                    //if (listaArticulosParaGrabar.Count > 0)
                    //{
                    //    var grabado = articuloNegocio.UpdateMasivo(listaArticulosParaGrabar);

                    //    lblInfo.Text = grabado ? $"Se han actualizado {listaArticulosParaGrabar.Count} precios"
                    //        : "No se han actualizado precios";
                    //}
                    //else
                    //{
                    //    lblInfo.Text = "No se han actualizado precios";
                    //    lblInfo.Refresh();
                    //}
                }

            }
            catch (IOException ex)
            {
                MessageBox.Show($"No se puede tener acceso al archivo ya que se encuentra en uso. Cierrelo y vuelva a intentarlo." +
                    $" Error --> {ex.Message}", "Cierre Archivo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al adjuntar archivo. Error --> {ex.Message} - {ex.InnerException} - {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor = Cursors.Default;
        }
    }
}
