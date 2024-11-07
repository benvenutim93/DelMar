namespace DelMar.NET6
{
    partial class FrmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            button1 = new Button();
            btnConsultaListaPrecios = new Button();
            menuStrip = new MenuStrip();
            menuGestion = new ToolStripMenuItem();
            menuPrecios = new ToolStripMenuItem();
            menuPresupuesto = new ToolStripMenuItem();
            articulosToolStripMenuItem = new ToolStripMenuItem();
            categoriasToolStripMenuItem = new ToolStripMenuItem();
            proveedoresToolStripMenuItem = new ToolStripMenuItem();
            consultaListaPreciosToolStripMenuItem = new ToolStripMenuItem();
            actualizacionListaDePreciosToolStripMenuItem = new ToolStripMenuItem();
            actualizacionPorcentualToolStripMenuItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(525, 367);
            button1.Name = "button1";
            button1.Size = new Size(263, 71);
            button1.TabIndex = 0;
            button1.Text = "Presupuesto";
            button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            button1.UseVisualStyleBackColor = true;
            // 
            // btnConsultaListaPrecios
            // 
            btnConsultaListaPrecios.Image = (Image)resources.GetObject("btnConsultaListaPrecios.Image");
            btnConsultaListaPrecios.Location = new Point(12, 367);
            btnConsultaListaPrecios.Name = "btnConsultaListaPrecios";
            btnConsultaListaPrecios.Size = new Size(263, 71);
            btnConsultaListaPrecios.TabIndex = 1;
            btnConsultaListaPrecios.Text = "Consulta Lista Precios";
            btnConsultaListaPrecios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConsultaListaPrecios.UseVisualStyleBackColor = true;
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(24, 24);
            menuStrip.Items.AddRange(new ToolStripItem[] { menuGestion, menuPrecios, menuPresupuesto });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 33);
            menuStrip.TabIndex = 2;
            menuStrip.Text = "Gestion";
            // 
            // menuGestion
            // 
            menuGestion.DropDownItems.AddRange(new ToolStripItem[] { articulosToolStripMenuItem, categoriasToolStripMenuItem, proveedoresToolStripMenuItem });
            menuGestion.Image = (Image)resources.GetObject("menuGestion.Image");
            menuGestion.Name = "menuGestion";
            menuGestion.Size = new Size(112, 29);
            menuGestion.Text = "Gestion";
            // 
            // menuPrecios
            // 
            menuPrecios.DropDownItems.AddRange(new ToolStripItem[] { consultaListaPreciosToolStripMenuItem, actualizacionListaDePreciosToolStripMenuItem, actualizacionPorcentualToolStripMenuItem });
            menuPrecios.Image = (Image)resources.GetObject("menuPrecios.Image");
            menuPrecios.Name = "menuPrecios";
            menuPrecios.Size = new Size(108, 29);
            menuPrecios.Text = "Precios";
            // 
            // menuPresupuesto
            // 
            menuPresupuesto.Image = (Image)resources.GetObject("menuPresupuesto.Image");
            menuPresupuesto.Name = "menuPresupuesto";
            menuPresupuesto.Size = new Size(150, 29);
            menuPresupuesto.Text = "Presupuesto";
            // 
            // articulosToolStripMenuItem
            // 
            articulosToolStripMenuItem.Image = (Image)resources.GetObject("articulosToolStripMenuItem.Image");
            articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
            articulosToolStripMenuItem.Size = new Size(270, 34);
            articulosToolStripMenuItem.Text = "Articulos";
            // 
            // categoriasToolStripMenuItem
            // 
            categoriasToolStripMenuItem.Image = (Image)resources.GetObject("categoriasToolStripMenuItem.Image");
            categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            categoriasToolStripMenuItem.Size = new Size(270, 34);
            categoriasToolStripMenuItem.Text = "Categorias";
            // 
            // proveedoresToolStripMenuItem
            // 
            proveedoresToolStripMenuItem.Image = (Image)resources.GetObject("proveedoresToolStripMenuItem.Image");
            proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            proveedoresToolStripMenuItem.Size = new Size(270, 34);
            proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // consultaListaPreciosToolStripMenuItem
            // 
            consultaListaPreciosToolStripMenuItem.Image = (Image)resources.GetObject("consultaListaPreciosToolStripMenuItem.Image");
            consultaListaPreciosToolStripMenuItem.Name = "consultaListaPreciosToolStripMenuItem";
            consultaListaPreciosToolStripMenuItem.Size = new Size(343, 34);
            consultaListaPreciosToolStripMenuItem.Text = "Consulta Lista Precios";
            // 
            // actualizacionListaDePreciosToolStripMenuItem
            // 
            actualizacionListaDePreciosToolStripMenuItem.Image = (Image)resources.GetObject("actualizacionListaDePreciosToolStripMenuItem.Image");
            actualizacionListaDePreciosToolStripMenuItem.Name = "actualizacionListaDePreciosToolStripMenuItem";
            actualizacionListaDePreciosToolStripMenuItem.Size = new Size(343, 34);
            actualizacionListaDePreciosToolStripMenuItem.Text = "Actualizacion Lista de Precios";
            // 
            // actualizacionPorcentualToolStripMenuItem
            // 
            actualizacionPorcentualToolStripMenuItem.Image = (Image)resources.GetObject("actualizacionPorcentualToolStripMenuItem.Image");
            actualizacionPorcentualToolStripMenuItem.Name = "actualizacionPorcentualToolStripMenuItem";
            actualizacionPorcentualToolStripMenuItem.Size = new Size(343, 34);
            actualizacionPorcentualToolStripMenuItem.Text = "Actualizacion Porcentual";
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConsultaListaPrecios);
            Controls.Add(button1);
            Controls.Add(menuStrip);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            Name = "FrmMenu";
            Text = "Descartables Del Mar - Menu Principal";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnConsultaListaPrecios;
        private MenuStrip menuStrip;
        private ToolStripMenuItem menuGestion;
        private ToolStripMenuItem menuPrecios;
        private ToolStripMenuItem menuPresupuesto;
        private ToolStripMenuItem articulosToolStripMenuItem;
        private ToolStripMenuItem categoriasToolStripMenuItem;
        private ToolStripMenuItem proveedoresToolStripMenuItem;
        private ToolStripMenuItem consultaListaPreciosToolStripMenuItem;
        private ToolStripMenuItem actualizacionListaDePreciosToolStripMenuItem;
        private ToolStripMenuItem actualizacionPorcentualToolStripMenuItem;
    }
}
