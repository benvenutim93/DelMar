using DelMar.DB.Interfaces;
using DelMar.Negocio.Interfaces;

namespace DelMar.View.ABM_s
{
    public partial class FrmAbmProveedores : Form
    {
        private readonly IProveedorService _proveedorService;
        public FrmAbmProveedores(IProveedorService proveedorService)
        {
            InitializeComponent();
            _proveedorService = proveedorService;

            this.bsProveedores.DataSource = _proveedorService.GetAll();
        }

        private void FrmAbmProveedores_Load(object sender, EventArgs e)
        {

        }
    }
}
