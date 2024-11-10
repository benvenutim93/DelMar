namespace DelMar.View.Actualizar_Lista_Precio
{
    partial class FrmActualizarLista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmActualizarLista));
            lblProveedor = new Label();
            cbxProveedores = new ComboBox();
            bsProveedores = new BindingSource(components);
            lblEstado = new Label();
            btnAdjuntar = new Button();
            ofdListaPrecios = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)bsProveedores).BeginInit();
            SuspendLayout();
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Location = new Point(48, 52);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(103, 25);
            lblProveedor.TabIndex = 0;
            lblProveedor.Text = "Proveedor: ";
            // 
            // cbxProveedores
            // 
            cbxProveedores.DataSource = bsProveedores;
            cbxProveedores.DisplayMember = "Nombre";
            cbxProveedores.FormattingEnabled = true;
            cbxProveedores.Location = new Point(157, 49);
            cbxProveedores.Name = "cbxProveedores";
            cbxProveedores.Size = new Size(306, 33);
            cbxProveedores.TabIndex = 1;
            cbxProveedores.ValueMember = "Id";
            // 
            // bsProveedores
            // 
            bsProveedores.DataSource = typeof(Entidades.Models.Proveedor);
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.ForeColor = SystemColors.HotTrack;
            lblEstado.Location = new Point(48, 113);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(24, 25);
            lblEstado.TabIndex = 2;
            lblEstado.Text = "...";
            // 
            // btnAdjuntar
            // 
            btnAdjuntar.BackColor = Color.Teal;
            btnAdjuntar.Image = (Image)resources.GetObject("btnAdjuntar.Image");
            btnAdjuntar.Location = new Point(513, 41);
            btnAdjuntar.Name = "btnAdjuntar";
            btnAdjuntar.Size = new Size(46, 46);
            btnAdjuntar.TabIndex = 3;
            btnAdjuntar.UseVisualStyleBackColor = false;
            btnAdjuntar.Click += btnAdjuntar_Click;
            // 
            // ofdListaPrecios
            // 
            ofdListaPrecios.FileName = "ofd";
            // 
            // FrmActualizarLista
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 170);
            Controls.Add(btnAdjuntar);
            Controls.Add(lblEstado);
            Controls.Add(cbxProveedores);
            Controls.Add(lblProveedor);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmActualizarLista";
            Text = "Actualización Lista de Precios";
            ((System.ComponentModel.ISupportInitialize)bsProveedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProveedor;
        private ComboBox cbxProveedores;
        private Label lblEstado;
        private Button btnAdjuntar;
        private BindingSource bsProveedores;
        private OpenFileDialog ofdListaPrecios;
    }
}