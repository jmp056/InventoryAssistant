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
            this.EntradaDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegistroDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegistroDeCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegistroDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuadreDeCajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsultaDeFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsultaDeEntradaDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeProductosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeCategoríasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeCuadresDeCajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.NivelDeUsuarioToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.NombreUsuarioToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.UsuarioStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MyTimer = new System.Windows.Forms.Timer(this.components);
            this.FechaGroupBox = new System.Windows.Forms.GroupBox();
            this.FechaTextBox = new System.Windows.Forms.TextBox();
            this.HoraTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.FechaGroupBox.SuspendLayout();
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
            this.RegistroDeUsuariosToolStripMenuItem,
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
            this.ConsultaDeEntradaDeProductosToolStripMenuItem,
            this.consultaDeProductosToolStripMenuItem1,
            this.consultaDeCategoríasToolStripMenuItem,
            this.ConsultaToolStripMenuItem,
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
            // ConsultaToolStripMenuItem
            // 
            this.ConsultaToolStripMenuItem.Name = "ConsultaToolStripMenuItem";
            this.ConsultaToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.ConsultaToolStripMenuItem.Text = "Consulta de Usuarios";
            this.ConsultaToolStripMenuItem.Click += new System.EventHandler(this.ConsultaToolStripMenuItem_Click);
            // 
            // consultaDeCuadresDeCajaToolStripMenuItem
            // 
            this.consultaDeCuadresDeCajaToolStripMenuItem.Name = "consultaDeCuadresDeCajaToolStripMenuItem";
            this.consultaDeCuadresDeCajaToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.consultaDeCuadresDeCajaToolStripMenuItem.Text = "Consulta de Cuadres de Caja";
            this.consultaDeCuadresDeCajaToolStripMenuItem.Click += new System.EventHandler(this.consultaDeCuadresDeCajaToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 44);
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
            // MyTimer
            // 
            this.MyTimer.Tick += new System.EventHandler(this.MyTimer_Tick);
            // 
            // FechaGroupBox
            // 
            this.FechaGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FechaGroupBox.Controls.Add(this.FechaTextBox);
            this.FechaGroupBox.Controls.Add(this.HoraTextBox);
            this.FechaGroupBox.Location = new System.Drawing.Point(526, 329);
            this.FechaGroupBox.Name = "FechaGroupBox";
            this.FechaGroupBox.Size = new System.Drawing.Size(274, 100);
            this.FechaGroupBox.TabIndex = 22;
            this.FechaGroupBox.TabStop = false;
            // 
            // FechaTextBox
            // 
            this.FechaTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.FechaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FechaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaTextBox.Location = new System.Drawing.Point(5, 77);
            this.FechaTextBox.Name = "FechaTextBox";
            this.FechaTextBox.Size = new System.Drawing.Size(255, 15);
            this.FechaTextBox.TabIndex = 23;
            this.FechaTextBox.Text = "Sabado 30 de diciembre del 2020";
            this.FechaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // HoraTextBox
            // 
            this.HoraTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.HoraTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HoraTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoraTextBox.Location = new System.Drawing.Point(2, 27);
            this.HoraTextBox.Name = "HoraTextBox";
            this.HoraTextBox.Size = new System.Drawing.Size(258, 46);
            this.HoraTextBox.TabIndex = 24;
            this.HoraTextBox.Text = "hh:mm:ss pm";
            this.HoraTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FechaGroupBox);
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
            this.FechaGroupBox.ResumeLayout(false);
            this.FechaGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RegistroDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
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
        private System.Windows.Forms.GroupBox FechaGroupBox;
        private System.Windows.Forms.TextBox FechaTextBox;
        private System.Windows.Forms.TextBox HoraTextBox;
    }
}

