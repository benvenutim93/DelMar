using DelMar.Entidades.Models;
using DelMar.Negocio.Interfaces;
using Microsoft.Extensions.Logging;
using NLog;

namespace DelMar.View.ABM_s
{
    public partial class FrmAbmProveedores : Form
    {
        private readonly IProveedorService _proveedorService;
        private readonly ILogger<FrmAbmProveedores> _logger;
        public bool EsNuevo = false;
        public Proveedor ProveedorBeforeEdit { get; set; }

        public FrmAbmProveedores(IProveedorService proveedorService, ILogger<FrmAbmProveedores> logger)
        {
            InitializeComponent();
            _proveedorService = proveedorService;
            _logger = logger;

            this.bsProveedores.DataSource = _proveedorService.GetAll();
            this.ProveedorBeforeEdit = new Proveedor();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.EsNuevo = true;
            SetText(true, string.Empty);
            this.txtNombre.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.EsNuevo = false;
            SetText(false, string.Empty);
            dgvProveedores.Focus();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                var nombre = txtNombre.Text;
                var listaProveedores = (List<Proveedor>)bsProveedores.List;
                var result = false;
                Proveedor proveedor = null;

                if (this.EsNuevo)
                {
                    proveedor = new Proveedor() { Nombre = nombre };
                    result = _proveedorService.Insert(proveedor);
                }
                else
                {
                    this.ProveedorBeforeEdit.Nombre = nombre;
                    result = _proveedorService.Update(ProveedorBeforeEdit);
                }

                if (result)
                {
                    if (EsNuevo)
                    {
                        bsProveedores.Add(proveedor);
                        this.EsNuevo = false;
                    }

                    bsProveedores.ResetBindings(false);
                    SetText(false, string.Empty);
                }
                else
                {
                    MessageBox.Show("No se pudieron grabar los datos", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error al grabar el proveedor {ex.Message}");

            }
        }


        private void SetText(bool txtEnabled, string text)
        {
            txtNombre.Text = text;
            txtNombre.Enabled = txtEnabled;
        }

        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > 0 && e.RowIndex < bsProveedores.Count)
                {
                    if (e.ColumnIndex == colEliminar.Index)
                    {
                        if (MessageBox.Show("¿Seguro que desea eliminar el proveedor?", "Eliminar articulo",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            var proveedor = (Proveedor)dgvProveedores.Rows[e.RowIndex].DataBoundItem;

                            var result = _proveedorService.Delete(proveedor);

                            if (result)
                            {
                                bsProveedores.Remove(proveedor);
                                bsProveedores.ResetBindings(false);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error al eliminar el proveedor {ex.Message}");
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < bsProveedores.Count)
                {
                    var proveedor = (Proveedor)dgvProveedores.Rows[e.RowIndex].DataBoundItem;
                    this.ProveedorBeforeEdit = proveedor;
                    this.SetText(true, proveedor.Nombre);
                    txtNombre.Focus();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error editar proveedor {ex.Message}");
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region TEXT BOX
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    this.btnGrabar_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
