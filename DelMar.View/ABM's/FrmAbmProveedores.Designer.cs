namespace DelMar.View.ABM_s
{
    partial class FrmAbmProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbmProveedores));
            dgvProveedores = new DataGridView();
            groupBox1 = new GroupBox();
            btnCancelar = new Button();
            btnAgregar = new Button();
            btnGrabar = new Button();
            txtNombreProveedor = new TextBox();
            label1 = new Label();
            bsProveedores = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsProveedores).BeginInit();
            SuspendLayout();
            // 
            // dgvProveedores
            // 
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Location = new Point(12, 12);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.RowHeadersWidth = 62;
            dgvProveedores.Size = new Size(541, 483);
            dgvProveedores.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(btnGrabar);
            groupBox1.Controls.Add(txtNombreProveedor);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 510);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(544, 136);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.Location = new Point(253, 27);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(46, 46);
            btnCancelar.TabIndex = 4;
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.CornflowerBlue;
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.Location = new Point(6, 27);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(46, 46);
            btnAgregar.TabIndex = 3;
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnGrabar
            // 
            btnGrabar.BackColor = Color.LimeGreen;
            btnGrabar.Image = (Image)resources.GetObject("btnGrabar.Image");
            btnGrabar.Location = new Point(492, 27);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(46, 46);
            btnGrabar.TabIndex = 2;
            btnGrabar.UseVisualStyleBackColor = false;
            // 
            // txtNombreProveedor
            // 
            txtNombreProveedor.Location = new Point(120, 91);
            txtNombreProveedor.Name = "txtNombreProveedor";
            txtNombreProveedor.Size = new Size(377, 31);
            txtNombreProveedor.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 94);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre: ";
            // 
            // FrmAbmProveedores
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 658);
            Controls.Add(groupBox1);
            Controls.Add(dgvProveedores);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmAbmProveedores";
            Text = "Administracion de Proveedores";
            Load += FrmAbmProveedores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsProveedores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProveedores;
        private GroupBox groupBox1;
        private BindingSource bsProveedores;
        private Button btnCancelar;
        private Button btnAgregar;
        private Button btnGrabar;
        private TextBox txtNombreProveedor;
        private Label label1;
    }
}