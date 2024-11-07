using DelMar.View.ABM_s;
using Microsoft.Extensions.DependencyInjection;

namespace DelMar.NET6
{
    public partial class FrmMenu : Form
    {
        private readonly IServiceProvider _serviceProvider;
        public FrmMenu(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<FrmAbmProveedores>();
            form.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<FrmAbmCategorias>();
            form.Show();
        }
    }
}
