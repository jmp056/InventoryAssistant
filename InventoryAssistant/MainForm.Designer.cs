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
            this.Userlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
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
            this.registroDeFacturasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registroDeFacturasToolStripMenuItem.Image")));
            this.registroDeFacturasToolStripMenuItem.Name = "registroDeFacturasToolStripMenuItem";
            this.registroDeFacturasToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.registroDeFacturasToolStripMenuItem.Text = "Registro de Facturas";
            this.registroDeFacturasToolStripMenuItem.Click += new System.EventHandler(this.registroDeFacturasToolStripMenuItem_Click);
            // 
            // entradaDeProductosToolStripMenuItem
            // 
            this.entradaDeProductosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("entradaDeProductosToolStripMenuItem.Image")));
            this.entradaDeProductosToolStripMenuItem.Name = "entradaDeProductosToolStripMenuItem";
            this.entradaDeProductosToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.entradaDeProductosToolStripMenuItem.Text = "Entrada de productos";
            this.entradaDeProductosToolStripMenuItem.Click += new System.EventHandler(this.entradaDeProductosToolStripMenuItem_Click);
            // 
            // registroDeProductosToolStripMenuItem
            // 
            this.registroDeProductosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registroDeProductosToolStripMenuItem.Image")));
            this.registroDeProductosToolStripMenuItem.Name = "registroDeProductosToolStripMenuItem";
            this.registroDeProductosToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.registroDeProductosToolStripMenuItem.Text = "Registro de Productos";
            this.registroDeProductosToolStripMenuItem.Click += new System.EventHandler(this.registroDeProductosToolStripMenuItem_Click);
            // 
            // registroDeCategoriaToolStripMenuItem
            // 
            this.registroDeCategoriaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registroDeCategoriaToolStripMenuItem.Image")));
            this.registroDeCategoriaToolStripMenuItem.Name = "registroDeCategoriaToolStripMenuItem";
            this.registroDeCategoriaToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.registroDeCategoriaToolStripMenuItem.Text = "Registro de Categoria";
            this.registroDeCategoriaToolStripMenuItem.Click += new System.EventHandler(this.registroDeCategoriaToolStripMenuItem_Click);
            // 
            // registroDeUsuariosToolStripMenuItem
            // 
            this.registroDeUsuariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registroDeUsuariosToolStripMenuItem.Image")));
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
            this.button2.Location = new System.Drawing.Point(348, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Userlabel
            // 
            this.Userlabel.AutoSize = true;
            this.Userlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Userlabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Userlabel.Location = new System.Drawing.Point(93, 239);
            this.Userlabel.Name = "Userlabel";
            this.Userlabel.Size = new System.Drawing.Size(41, 15);
            this.Userlabel.TabIndex = 18;
            this.Userlabel.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(42, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Usuario:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Userlabel);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label Userlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem consultaDeFacturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeFacturasToolStripMenuItem;
    }
}

