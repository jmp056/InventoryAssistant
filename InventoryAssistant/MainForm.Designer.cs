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
            this.RegistroDeFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EntradaDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegistroDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegistroDeCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegistroDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeEntradaDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeProductosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeCategoríasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.RegistroDeFacturasToolStripMenuItem,
            this.EntradaDeProductosToolStripMenuItem,
            this.RegistroDeProductosToolStripMenuItem,
            this.RegistroDeCategoriaToolStripMenuItem,
            this.RegistroDeUsuariosToolStripMenuItem});
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
            // RegistroDeUsuariosToolStripMenuItem
            // 
            this.RegistroDeUsuariosToolStripMenuItem.Name = "RegistroDeUsuariosToolStripMenuItem";
            this.RegistroDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.RegistroDeUsuariosToolStripMenuItem.Text = "Registro de Usuarios";
            this.RegistroDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.registroDeUsuariosToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaDeUsuariosToolStripMenuItem,
            this.consultaDeEntradaDeProductosToolStripMenuItem,
            this.consultaDeProductosToolStripMenuItem1,
            this.consultaDeCategoríasToolStripMenuItem,
            this.ConsultaToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // consultaDeUsuariosToolStripMenuItem
            // 
            this.consultaDeUsuariosToolStripMenuItem.Name = "consultaDeUsuariosToolStripMenuItem";
            this.consultaDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.consultaDeUsuariosToolStripMenuItem.Text = "Consulta de Usuarios";
            // 
            // consultaDeEntradaDeProductosToolStripMenuItem
            // 
            this.consultaDeEntradaDeProductosToolStripMenuItem.Name = "consultaDeEntradaDeProductosToolStripMenuItem";
            this.consultaDeEntradaDeProductosToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.consultaDeEntradaDeProductosToolStripMenuItem.Text = "Consulta de Entrada de Productos";
            this.consultaDeEntradaDeProductosToolStripMenuItem.Click += new System.EventHandler(this.consultaDeEntradaDeProductosToolStripMenuItem_Click);
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
            // ConsultaToolStripMenuItem
            // 
            this.ConsultaToolStripMenuItem.Name = "ConsultaToolStripMenuItem";
            this.ConsultaToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.ConsultaToolStripMenuItem.Text = "Consulta de Usuarios";
            this.ConsultaToolStripMenuItem.Click += new System.EventHandler(this.ConsultaToolStripMenuItem_Click);
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
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
        private System.Windows.Forms.ToolStripMenuItem RegistroDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeUsuariosToolStripMenuItem;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem ConsultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeCategoríasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeProductosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultaDeEntradaDeProductosToolStripMenuItem;
    }
}

