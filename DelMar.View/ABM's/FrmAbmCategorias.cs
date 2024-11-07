using DelMar.Entidades.Models;
using DelMar.Negocio.Interfaces;
using Microsoft.Extensions.Logging;

namespace DelMar.View.ABM_s
{
    public partial class FrmAbmCategorias : Form
    {
        private readonly ICategoriaService _categoriaService;
        private readonly ILogger<FrmAbmCategorias> _logger;
        protected bool EsNuevo = false;
        protected Categoria CategoriaBeforeEdit { get; set; }

        public FrmAbmCategorias(ICategoriaService categoriaService, ILogger<FrmAbmCategorias> logger)
        {
            InitializeComponent();
            _logger = logger;
            _categoriaService = categoriaService;

            this.bsCategorias.DataSource = _categoriaService.GetAll();
            this.CategoriaBeforeEdit = new Categoria();
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
            dgvCategorias.Focus();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                var nombre = txtNombre.Text;
                var listaProveedores = (List<Categoria>)bsCategorias.List;
                var result = false;
                Categoria categoria = null;

                if (this.EsNuevo)
                {
                    categoria = new Categoria() { Nombre = nombre };
                    result = _categoriaService.Insert(categoria);
                }
                else
                {
                    this.CategoriaBeforeEdit.Nombre = nombre;
                    result = _categoriaService.Update(CategoriaBeforeEdit);
                }

                if (result)
                {
                    if (EsNuevo)
                    {
                        bsCategorias.Add(categoria);
                        this.EsNuevo = false;
                    }

                    bsCategorias.ResetBindings(false);
                    SetText(false, string.Empty);
                }
                else
                {
                    MessageBox.Show("No se pudieron grabar los datos", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error al grabar la categoria -  Ex.Message: {ex.Message}");
                MessageBox.Show(ex.Message, "Error al grabar la categoria", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void SetText(bool txtEnabled, string text)
        {
            txtNombre.Text = text;
            txtNombre.Enabled = txtEnabled;
        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > 0 && e.RowIndex < bsCategorias.Count)
                {
                    if (e.ColumnIndex == colEliminar.Index)
                    {
                        if (MessageBox.Show("¿Seguro que desea eliminar el proveedor?", "Eliminar articulo",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            var categoria = (Categoria)dgvCategorias.Rows[e.RowIndex].DataBoundItem;

                            var result = _categoriaService.Delete(categoria);

                            if (result)
                            {
                                bsCategorias.Remove(categoria);
                                bsCategorias.ResetBindings(false);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error al eliminar la categoria -  Ex.Message: {ex.Message}");
                MessageBox.Show(ex.Message, "Error al eliminar la categoria", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCategorias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < bsCategorias.Count)
                {
                    var categoria = (Categoria)dgvCategorias.Rows[e.RowIndex].DataBoundItem;
                    this.CategoriaBeforeEdit = categoria;
                    this.SetText(true, categoria.Nombre);
                    txtNombre.Focus();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error editar categoria -  Ex.Message:{ex.Message}");
                MessageBox.Show(ex.Message, "Error editar categoria", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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
    }
}
