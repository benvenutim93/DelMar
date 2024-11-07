namespace DelMar.View.ABM_s
{
    partial class FrmAbmCategorias
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbmCategorias));
            dgvCategorias = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            colEliminar = new DataGridViewImageColumn();
            bsCategorias = new BindingSource(components);
            groupBox1 = new GroupBox();
            txtNombre = new TextBox();
            label1 = new Label();
            btnGrabar = new Button();
            btnCancelar = new Button();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsCategorias).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCategorias
            // 
            dgvCategorias.AllowUserToAddRows = false;
            dgvCategorias.AllowUserToDeleteRows = false;
            dgvCategorias.AutoGenerateColumns = false;
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, colEliminar });
            dgvCategorias.DataSource = bsCategorias;
            dgvCategorias.Location = new Point(12, 12);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.ReadOnly = true;
            dgvCategorias.RowHeadersVisible = false;
            dgvCategorias.RowHeadersWidth = 62;
            dgvCategorias.Size = new Size(541, 483);
            dgvCategorias.TabIndex = 0;
            dgvCategorias.CellContentClick += dgvCategorias_CellContentClick;
            dgvCategorias.CellDoubleClick += dgvCategorias_CellDoubleClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Red;
            dataGridViewCellStyle1.NullValue = resources.GetObject("dataGridViewCellStyle1.NullValue");
            colEliminar.DefaultCellStyle = dataGridViewCellStyle1;
            colEliminar.HeaderText = "";
            colEliminar.Image = (Image)resources.GetObject("colEliminar.Image");
            colEliminar.MinimumWidth = 8;
            colEliminar.Name = "colEliminar";
            colEliminar.ReadOnly = true;
            colEliminar.Width = 8;
            // 
            // bsCategorias
            // 
            bsCategorias.DataSource = typeof(Entidades.Models.Categoria);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnGrabar);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Location = new Point(12, 501);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(541, 150);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(116, 102);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(376, 31);
            txtNombre.TabIndex = 4;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 105);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 3;
            label1.Text = "Nombre:";
            // 
            // btnGrabar
            // 
            btnGrabar.BackColor = Color.LimeGreen;
            btnGrabar.Image = (Image)resources.GetObject("btnGrabar.Image");
            btnGrabar.Location = new Point(489, 27);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(46, 46);
            btnGrabar.TabIndex = 2;
            btnGrabar.UseVisualStyleBackColor = false;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Tomato;
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.Location = new Point(253, 27);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(46, 46);
            btnCancelar.TabIndex = 1;
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
            btnAgregar.TabIndex = 0;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // FrmAbmCategorias
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 658);
            Controls.Add(groupBox1);
            Controls.Add(dgvCategorias);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmAbmCategorias";
            Text = "Administracion de Categorias";
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsCategorias).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCategorias;
        private GroupBox groupBox1;
        private Button btnAgregar;
        private Button btnCancelar;
        private Button btnGrabar;
        private Label label1;
        private TextBox txtNombre;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewImageColumn colEliminar;
        private BindingSource bsCategorias;
    }
}