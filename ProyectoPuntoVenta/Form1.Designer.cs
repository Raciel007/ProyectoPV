namespace ProyectoPuntoVenta
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AcercadeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SalirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblrol = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.blankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.BackColor = System.Drawing.Color.LightSteelBlue;
            this.msMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.msMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.blankToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.gestionToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.reporteriaToolStripMenuItem,
            this.AcercadeToolStripMenuItem1,
            this.SalirToolStripMenuItem1});
            this.msMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(1712, 95);
            this.msMenu.TabIndex = 1;
            this.msMenu.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.clientesToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.clientesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.clientesToolStripMenuItem.Image = global::ProyectoPuntoVenta.Properties.Resources.clientes;
            this.clientesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(87, 91);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.gestionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gestionToolStripMenuItem.Image = global::ProyectoPuntoVenta.Properties.Resources.gestion;
            this.gestionToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(84, 91);
            this.gestionToolStripMenuItem.Text = "Gestión";
            this.gestionToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.gestionToolStripMenuItem.Click += new System.EventHandler(this.gestionToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ventasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.ventasToolStripMenuItem.Image = global::ProyectoPuntoVenta.Properties.Resources.venta;
            this.ventasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(78, 91);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.comprasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.comprasToolStripMenuItem.Image = global::ProyectoPuntoVenta.Properties.Resources.compras;
            this.comprasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(95, 91);
            this.comprasToolStripMenuItem.Text = "Compras";
            this.comprasToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.comprasToolStripMenuItem.Click += new System.EventHandler(this.comprasToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.proveedoresToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.proveedoresToolStripMenuItem.Image = global::ProyectoPuntoVenta.Properties.Resources.proveedores;
            this.proveedoresToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(122, 91);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.usuariosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.usuariosToolStripMenuItem.Image = global::ProyectoPuntoVenta.Properties.Resources.usuarios;
            this.usuariosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(91, 91);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // reporteriaToolStripMenuItem
            // 
            this.reporteriaToolStripMenuItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.reporteriaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.reporteriaToolStripMenuItem.Image = global::ProyectoPuntoVenta.Properties.Resources.reporteria;
            this.reporteriaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reporteriaToolStripMenuItem.Name = "reporteriaToolStripMenuItem";
            this.reporteriaToolStripMenuItem.Size = new System.Drawing.Size(109, 91);
            this.reporteriaToolStripMenuItem.Text = "Reporteria";
            this.reporteriaToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.reporteriaToolStripMenuItem.Click += new System.EventHandler(this.reporteriaToolStripMenuItem_Click);
            // 
            // AcercadeToolStripMenuItem1
            // 
            this.AcercadeToolStripMenuItem1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.AcercadeToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.AcercadeToolStripMenuItem1.Image = global::ProyectoPuntoVenta.Properties.Resources.info64;
            this.AcercadeToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AcercadeToolStripMenuItem1.Name = "AcercadeToolStripMenuItem1";
            this.AcercadeToolStripMenuItem1.Size = new System.Drawing.Size(102, 91);
            this.AcercadeToolStripMenuItem1.Text = "Acerca de";
            this.AcercadeToolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AcercadeToolStripMenuItem1.Click += new System.EventHandler(this.AcercadeToolStripMenuItem1_Click);
            // 
            // SalirToolStripMenuItem1
            // 
            this.SalirToolStripMenuItem1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.SalirToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.SalirToolStripMenuItem1.Image = global::ProyectoPuntoVenta.Properties.Resources.exit64;
            this.SalirToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SalirToolStripMenuItem1.Name = "SalirToolStripMenuItem1";
            this.SalirToolStripMenuItem1.Size = new System.Drawing.Size(78, 91);
            this.SalirToolStripMenuItem1.Text = "Salir";
            this.SalirToolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SalirToolStripMenuItem1.Click += new System.EventHandler(this.SalirToolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1491, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1529, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rol:";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.ForeColor = System.Drawing.Color.Black;
            this.lblusuario.Location = new System.Drawing.Point(1571, 44);
            this.lblusuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(72, 20);
            this.lblusuario.TabIndex = 3;
            this.lblusuario.Text = "Usuario:";
            // 
            // lblrol
            // 
            this.lblrol.AutoSize = true;
            this.lblrol.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrol.ForeColor = System.Drawing.Color.Black;
            this.lblrol.Location = new System.Drawing.Point(1571, 73);
            this.lblrol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblrol.Name = "lblrol";
            this.lblrol.Size = new System.Drawing.Size(72, 20);
            this.lblrol.TabIndex = 3;
            this.lblrol.Text = "Usuario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(1489, 2);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "Bienvenido";
            // 
            // blankToolStripMenuItem
            // 
            this.blankToolStripMenuItem.Enabled = false;
            this.blankToolStripMenuItem.Name = "blankToolStripMenuItem";
            this.blankToolStripMenuItem.Size = new System.Drawing.Size(63, 91);
            this.blankToolStripMenuItem.Text = "          ";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Enabled = false;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(63, 91);
            this.toolStripMenuItem1.Text = "          ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1712, 814);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblrol);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1327, 605);
            this.Name = "Form1";
            this.Text = "Punto Venta";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lblrol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem AcercadeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SalirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem blankToolStripMenuItem;
    }
}

