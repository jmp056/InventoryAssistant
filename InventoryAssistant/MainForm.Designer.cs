namespace InventoryAssistant
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegistroDeFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.EntradaDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegistroDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegistroDeCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.RegistroDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cuadreDeCajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsultaDeFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ConsultaDeEntradaDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeProductosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeCategoríasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.ConsultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.consultaDeCuadresDeCajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryAssistantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.NivelDeUsuarioToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.NombreUsuarioToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.UsuarioStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MyTimer = new System.Windows.Forms.Timer(this.components);
            this.FechaPanel = new System.Windows.Forms.Panel();
            this.HoraLabel = new System.Windows.Forms.Label();
            this.FechaLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.FechaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(701, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RegistroDeFacturasToolStripMenuItem,
            this.toolStripSeparator1,
            this.EntradaDeProductosToolStripMenuItem,
            this.RegistroDeProductosToolStripMenuItem,
            this.RegistroDeCategoriaToolStripMenuItem,
            this.toolStripSeparator3,
            this.RegistroDeUsuariosToolStripMenuItem,
            this.toolStripSeparator2,
            this.cuadreDeCajaToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // RegistroDeFacturasToolStripMenuItem
            // 
            this.RegistroDeFacturasToolStripMenuItem.Name = "RegistroDeFacturasToolStripMenuItem";
            this.RegistroDeFacturasToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.RegistroDeFacturasToolStripMenuItem.Text = "Registro de Facturas";
            this.RegistroDeFacturasToolStripMenuItem.Click += new System.EventHandler(this.registroDeFacturasToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(189, 6);
            // 
            // EntradaDeProductosToolStripMenuItem
            // 
            this.EntradaDeProductosToolStripMenuItem.Name = "EntradaDeProductosToolStripMenuItem";
            this.EntradaDeProductosToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.EntradaDeProductosToolStripMenuItem.Text = "Entrada de productos";
            this.EntradaDeProductosToolStripMenuItem.Click += new System.EventHandler(this.entradaDeProductosToolStripMenuItem_Click);
            // 
            // RegistroDeProductosToolStripMenuItem
            // 
            this.RegistroDeProductosToolStripMenuItem.Name = "RegistroDeProductosToolStripMenuItem";
            this.RegistroDeProductosToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.RegistroDeProductosToolStripMenuItem.Text = "Registro de Productos";
            this.RegistroDeProductosToolStripMenuItem.Click += new System.EventHandler(this.registroDeProductosToolStripMenuItem_Click);
            // 
            // RegistroDeCategoriaToolStripMenuItem
            // 
            this.RegistroDeCategoriaToolStripMenuItem.Name = "RegistroDeCategoriaToolStripMenuItem";
            this.RegistroDeCategoriaToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.RegistroDeCategoriaToolStripMenuItem.Text = "Registro de Categorías";
            this.RegistroDeCategoriaToolStripMenuItem.Click += new System.EventHandler(this.registroDeCategoriaToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(189, 6);
            // 
            // RegistroDeUsuariosToolStripMenuItem
            // 
            this.RegistroDeUsuariosToolStripMenuItem.Name = "RegistroDeUsuariosToolStripMenuItem";
            this.RegistroDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.RegistroDeUsuariosToolStripMenuItem.Text = "Registro de Usuarios";
            this.RegistroDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.registroDeUsuariosToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(189, 6);
            // 
            // cuadreDeCajaToolStripMenuItem
            // 
            this.cuadreDeCajaToolStripMenuItem.Name = "cuadreDeCajaToolStripMenuItem";
            this.cuadreDeCajaToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.cuadreDeCajaToolStripMenuItem.Text = "Cuadre de Caja";
            this.cuadreDeCajaToolStripMenuItem.Click += new System.EventHandler(this.cuadreDeCajaToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConsultaDeFacturasToolStripMenuItem,
            this.toolStripSeparator5,
            this.ConsultaDeEntradaDeProductosToolStripMenuItem,
            this.consultaDeProductosToolStripMenuItem1,
            this.consultaDeCategoríasToolStripMenuItem,
            this.toolStripSeparator6,
            this.ConsultaToolStripMenuItem,
            this.toolStripSeparator4,
            this.consultaDeCuadresDeCajaToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // ConsultaDeFacturasToolStripMenuItem
            // 
            this.ConsultaDeFacturasToolStripMenuItem.Name = "ConsultaDeFacturasToolStripMenuItem";
            this.ConsultaDeFacturasToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.ConsultaDeFacturasToolStripMenuItem.Text = "Consulta de Facturas";
            this.ConsultaDeFacturasToolStripMenuItem.Click += new System.EventHandler(this.ConsultaDeFacturasToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(250, 6);
            // 
            // ConsultaDeEntradaDeProductosToolStripMenuItem
            // 
            this.ConsultaDeEntradaDeProductosToolStripMenuItem.Name = "ConsultaDeEntradaDeProductosToolStripMenuItem";
            this.ConsultaDeEntradaDeProductosToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.ConsultaDeEntradaDeProductosToolStripMenuItem.Text = "Consulta de Entrada de Productos";
            this.ConsultaDeEntradaDeProductosToolStripMenuItem.Click += new System.EventHandler(this.consultaDeEntradaDeProductosToolStripMenuItem_Click);
            // 
            // consultaDeProductosToolStripMenuItem1
            // 
            this.consultaDeProductosToolStripMenuItem1.Name = "consultaDeProductosToolStripMenuItem1";
            this.consultaDeProductosToolStripMenuItem1.Size = new System.Drawing.Size(253, 22);
            this.consultaDeProductosToolStripMenuItem1.Text = "Consulta de Productos";
            this.consultaDeProductosToolStripMenuItem1.Click += new System.EventHandler(this.consultaDeProductosToolStripMenuItem1_Click);
            // 
            // consultaDeCategoríasToolStripMenuItem
            // 
            this.consultaDeCategoríasToolStripMenuItem.Name = "consultaDeCategoríasToolStripMenuItem";
            this.consultaDeCategoríasToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.consultaDeCategoríasToolStripMenuItem.Text = "Consulta de Categorías";
            this.consultaDeCategoríasToolStripMenuItem.Click += new System.EventHandler(this.consultaDeCategoríasToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(250, 6);
            // 
            // ConsultaToolStripMenuItem
            // 
            this.ConsultaToolStripMenuItem.Name = "ConsultaToolStripMenuItem";
            this.ConsultaToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.ConsultaToolStripMenuItem.Text = "Consulta de Usuarios";
            this.ConsultaToolStripMenuItem.Click += new System.EventHandler(this.ConsultaToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(250, 6);
            // 
            // consultaDeCuadresDeCajaToolStripMenuItem
            // 
            this.consultaDeCuadresDeCajaToolStripMenuItem.Name = "consultaDeCuadresDeCajaToolStripMenuItem";
            this.consultaDeCuadresDeCajaToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.consultaDeCuadresDeCajaToolStripMenuItem.Text = "Consulta de Cuadres de Caja";
            this.consultaDeCuadresDeCajaToolStripMenuItem.Click += new System.EventHandler(this.consultaDeCuadresDeCajaToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosToolStripMenuItem1,
            this.consultasToolStripMenuItem1});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // registrosToolStripMenuItem1
            // 
            this.registrosToolStripMenuItem1.Name = "registrosToolStripMenuItem1";
            this.registrosToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.registrosToolStripMenuItem1.Text = "Registros";
            this.registrosToolStripMenuItem1.Click += new System.EventHandler(this.registrosToolStripMenuItem1_Click);
            // 
            // consultasToolStripMenuItem1
            // 
            this.consultasToolStripMenuItem1.Name = "consultasToolStripMenuItem1";
            this.consultasToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.consultasToolStripMenuItem1.Text = "Consultas";
            this.consultasToolStripMenuItem1.Click += new System.EventHandler(this.consultasToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventoryAssistantToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // inventoryAssistantToolStripMenuItem
            // 
            this.inventoryAssistantToolStripMenuItem.Name = "inventoryAssistantToolStripMenuItem";
            this.inventoryAssistantToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inventoryAssistantToolStripMenuItem.Text = "Inventory Assistant";
            this.inventoryAssistantToolStripMenuItem.Click += new System.EventHandler(this.inventoryAssistantToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Login";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NivelDeUsuarioToolStripStatusLabel,
            this.ToolStripStatusLabel,
            this.NombreUsuarioToolStripStatusLabel,
            this.UsuarioStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 358);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(701, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // NivelDeUsuarioToolStripStatusLabel
            // 
            this.NivelDeUsuarioToolStripStatusLabel.Name = "NivelDeUsuarioToolStripStatusLabel";
            this.NivelDeUsuarioToolStripStatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NivelDeUsuarioToolStripStatusLabel.Size = new System.Drawing.Size(34, 17);
            this.NivelDeUsuarioToolStripStatusLabel.Text = "Nivel";
            // 
            // ToolStripStatusLabel
            // 
            this.ToolStripStatusLabel.Name = "ToolStripStatusLabel";
            this.ToolStripStatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ToolStripStatusLabel.Size = new System.Drawing.Size(24, 17);
            this.ToolStripStatusLabel.Text = "  -  ";
            // 
            // NombreUsuarioToolStripStatusLabel
            // 
            this.NombreUsuarioToolStripStatusLabel.Name = "NombreUsuarioToolStripStatusLabel";
            this.NombreUsuarioToolStripStatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NombreUsuarioToolStripStatusLabel.Size = new System.Drawing.Size(47, 17);
            this.NombreUsuarioToolStripStatusLabel.Text = "Usuario";
            // 
            // UsuarioStripStatusLabel
            // 
            this.UsuarioStripStatusLabel.Name = "UsuarioStripStatusLabel";
            this.UsuarioStripStatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UsuarioStripStatusLabel.Size = new System.Drawing.Size(53, 17);
            this.UsuarioStripStatusLabel.Text = "Usuario: ";
            // 
            // MyTimer
            // 
            this.MyTimer.Tick += new System.EventHandler(this.MyTimer_Tick);
            // 
            // FechaPanel
            // 
            this.FechaPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FechaPanel.BackColor = System.Drawing.Color.Transparent;
            this.FechaPanel.Controls.Add(this.HoraLabel);
            this.FechaPanel.Controls.Add(this.FechaLabel);
            this.FechaPanel.Location = new System.Drawing.Point(382, 274);
            this.FechaPanel.Name = "FechaPanel";
            this.FechaPanel.Size = new System.Drawing.Size(319, 81);
            this.FechaPanel.TabIndex = 23;
            // 
            // HoraLabel
            // 
            this.HoraLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.HoraLabel.AutoSize = true;
            this.HoraLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoraLabel.Location = new System.Drawing.Point(15, 3);
            this.HoraLabel.Name = "HoraLabel";
            this.HoraLabel.Size = new System.Drawing.Size(294, 55);
            this.HoraLabel.TabIndex = 24;
            this.HoraLabel.Text = "hh:mm:ss tt";
            // 
            // FechaLabel
            // 
            this.FechaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FechaLabel.AutoSize = true;
            this.FechaLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaLabel.Location = new System.Drawing.Point(25, 56);
            this.FechaLabel.Name = "FechaLabel";
            this.FechaLabel.Size = new System.Drawing.Size(284, 23);
            this.FechaLabel.TabIndex = 25;
            this.FechaLabel.Text = "Dia       30 de Mes       del Año";
            this.FechaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(701, 380);
            this.Controls.Add(this.FechaPanel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Assistant";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.FechaPanel.ResumeLayout(false);
            this.FechaPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RegistroDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RegistroDeCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RegistroDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EntradaDeProductosToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem RegistroDeFacturasToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel UsuarioStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel NombreUsuarioToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel NivelDeUsuarioToolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem ConsultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeCategoríasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeProductosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ConsultaDeEntradaDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConsultaDeFacturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuadreDeCajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeCuadresDeCajaToolStripMenuItem;
        private System.Windows.Forms.Timer MyTimer;
        private System.Windows.Forms.Panel FechaPanel;
        private System.Windows.Forms.Label FechaLabel;
        private System.Windows.Forms.Label HoraLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryAssistantToolStripMenuItem;
    }
}

