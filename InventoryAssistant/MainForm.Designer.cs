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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.NivelDeUsuarioToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.NombreUsuarioToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.UsuarioStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeFacturasToolStripMenuItem,
            this.entradaDeProductosToolStripMenuItem,
            this.registroDeProductosToolStripMenuItem,
            this.registroDeCategoriaToolStripMenuItem,
            this.registroDeUsuariosToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // registroDeFacturasToolStripMenuItem
            // 
            this.registroDeFacturasToolStripMenuItem.Image = global::InventoryAssistant.Properties.Resources.FacturaImg;
            this.registroDeFacturasToolStripMenuItem.Name = "registroDeFacturasToolStripMenuItem";
            this.registroDeFacturasToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.registroDeFacturasToolStripMenuItem.Text = "Registro de Facturas";
            this.registroDeFacturasToolStripMenuItem.Click += new System.EventHandler(this.registroDeFacturasToolStripMenuItem_Click);
            // 
            // entradaDeProductosToolStripMenuItem
            // 
            this.entradaDeProductosToolStripMenuItem.Image = global::InventoryAssistant.Properties.Resources.EntradaImg;
            this.entradaDeProductosToolStripMenuItem.Name = "entradaDeProductosToolStripMenuItem";
            this.entradaDeProductosToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.entradaDeProductosToolStripMenuItem.Text = "Entrada de productos";
            this.entradaDeProductosToolStripMenuItem.Click += new System.EventHandler(this.entradaDeProductosToolStripMenuItem_Click);
            // 
            // registroDeProductosToolStripMenuItem
            // 
            this.registroDeProductosToolStripMenuItem.Image = global::InventoryAssistant.Properties.Resources.ProductosImg;
            this.registroDeProductosToolStripMenuItem.Name = "registroDeProductosToolStripMenuItem";
            this.registroDeProductosToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.registroDeProductosToolStripMenuItem.Text = "Registro de Productos";
            this.registroDeProductosToolStripMenuItem.Click += new System.EventHandler(this.registroDeProductosToolStripMenuItem_Click);
            // 
            // registroDeCategoriaToolStripMenuItem
            // 
            this.registroDeCategoriaToolStripMenuItem.Image = global::InventoryAssistant.Properties.Resources.CategoriaImg;
            this.registroDeCategoriaToolStripMenuItem.Name = "registroDeCategoriaToolStripMenuItem";
            this.registroDeCategoriaToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.registroDeCategoriaToolStripMenuItem.Text = "Registro de Categoria";
            this.registroDeCategoriaToolStripMenuItem.Click += new System.EventHandler(this.registroDeCategoriaToolStripMenuItem_Click);
            // 
            // registroDeUsuariosToolStripMenuItem
            // 
            this.registroDeUsuariosToolStripMenuItem.Image = global::InventoryAssistant.Properties.Resources.UsuarioMenuImg;
            this.registroDeUsuariosToolStripMenuItem.Name = "registroDeUsuariosToolStripMenuItem";
            this.registroDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.registroDeUsuariosToolStripMenuItem.Text = "Registro de Usuarios";
            this.registroDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.registroDeUsuariosToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaDeUsuariosToolStripMenuItem,
            this.consultaDeProductosToolStripMenuItem,
            this.consultaDeFacturasToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // consultaDeUsuariosToolStripMenuItem
            // 
            this.consultaDeUsuariosToolStripMenuItem.Name = "consultaDeUsuariosToolStripMenuItem";
            this.consultaDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.consultaDeUsuariosToolStripMenuItem.Text = "Consulta de Usuarios";
            this.consultaDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.consultaDeUsuariosToolStripMenuItem_Click);
            // 
            // consultaDeProductosToolStripMenuItem
            // 
            this.consultaDeProductosToolStripMenuItem.Name = "consultaDeProductosToolStripMenuItem";
            this.consultaDeProductosToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.consultaDeProductosToolStripMenuItem.Text = "Consulta de Productos";
            this.consultaDeProductosToolStripMenuItem.Click += new System.EventHandler(this.consultaDeProductosToolStripMenuItem_Click);
            // 
            // consultaDeFacturasToolStripMenuItem
            // 
            this.consultaDeFacturasToolStripMenuItem.Name = "consultaDeFacturasToolStripMenuItem";
            this.consultaDeFacturasToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.consultaDeFacturasToolStripMenuItem.Text = "Consulta de Facturas";
            this.consultaDeFacturasToolStripMenuItem.Click += new System.EventHandler(this.consultaDeFacturasToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(217, 164);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(462, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Ventana en proceso";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.menuStrip1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradaDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeProductosToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem consultaDeFacturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeFacturasToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel UsuarioStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel NombreUsuarioToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel NivelDeUsuarioToolStripStatusLabel;
        private System.Windows.Forms.Button button1;
    }
}

