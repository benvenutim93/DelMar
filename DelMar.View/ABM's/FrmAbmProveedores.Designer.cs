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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbmProveedores));
            dgvProveedores = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            colEliminar = new DataGridViewImageColumn();
            bsProveedores = new BindingSource(components);
            groupBox1 = new GroupBox();
            btnCancelar = new Button();
            btnAgregar = new Button();
            btnGrabar = new Button();
            txtNombre = new TextBox();
            lblNombre = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsProveedores).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProveedores
            // 
            dgvProveedores.AllowUserToAddRows = false;
            dgvProveedores.AllowUserToDeleteRows = false;
            dgvProveedores.AutoGenerateColumns = false;
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, colEliminar });
            dgvProveedores.DataSource = bsProveedores;
            dgvProveedores.Location = new Point(12, 12);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.ReadOnly = true;
            dgvProveedores.RowHeadersVisible = false;
            dgvProveedores.RowHeadersWidth = 62;
            dgvProveedores.Size = new Size(541, 483);
            dgvProveedores.TabIndex = 0;
            dgvProveedores.CellContentClick += dgvProveedores_CellContentClick;
            dgvProveedores.CellDoubleClick += dgvProveedores_CellDoubleClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 8;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 64;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.MinimumWidth = 8;
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colEliminar
            // 
            colEliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Red;
            dataGridViewCellStyle2.ForeColor = SystemColors.Control;
            dataGridViewCellStyle2.NullValue = resources.GetObject("dataGridViewCellStyle2.NullValue");
            colEliminar.DefaultCellStyle = dataGridViewCellStyle2;
            colEliminar.HeaderText = "";
            colEliminar.Image = (Image)resources.GetObject("colEliminar.Image");
            colEliminar.MinimumWidth = 8;
            colEliminar.Name = "colEliminar";
            colEliminar.ReadOnly = true;
            colEliminar.Width = 8;
            // 
            // bsProveedores
            // 
            bsProveedores.DataSource = typeof(Entidades.Models.Proveedor);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(btnGrabar);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(lblNombre);
            groupBox1.Location = new Point(12, 510);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(544, 136);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Tomato;
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.Location = new Point(253, 27);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(46, 46);
            btnCancelar.TabIndex = 4;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
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
            btnAgregar.Click += btnAgregar_Click;
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
            btnGrabar.Click += btnGrabar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(120, 91);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(377, 31);
            txtNombre.TabIndex = 1;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(27, 94);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(87, 25);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre: ";
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
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administracion de Proveedores";
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsProveedores).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProveedores;
        private GroupBox groupBox1;
        private Button btnCancelar;
        private Button btnAgregar;
        private Button btnGrabar;
        private TextBox txtNombre;
        private Label lblNombre;
        private BindingSource bsProveedores;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewImageColumn colEliminar;
    }
}