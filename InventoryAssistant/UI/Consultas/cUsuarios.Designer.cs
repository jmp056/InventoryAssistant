namespace InventoryAssistant.UI.Consultas
{
    partial class cUsuarios
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
            this.DatosDelUsuarioGroupBox = new System.Windows.Forms.GroupBox();
            this.DatosDelUsuarioButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RealizarBusquedaButton = new System.Windows.Forms.Button();
            this.CriterioTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UsuariosDataGridView = new System.Windows.Forms.DataGridView();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.DatosDelUsuarioGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // DatosDelUsuarioGroupBox
            // 
            this.DatosDelUsuarioGroupBox.Controls.Add(this.DatosDelUsuarioButton);
            this.DatosDelUsuarioGroupBox.Controls.Add(this.groupBox1);
            this.DatosDelUsuarioGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatosDelUsuarioGroupBox.Location = new System.Drawing.Point(5, 5);
            this.DatosDelUsuarioGroupBox.Name = "DatosDelUsuarioGroupBox";
            this.DatosDelUsuarioGroupBox.Size = new System.Drawing.Size(190, 324);
            this.DatosDelUsuarioGroupBox.TabIndex = 22;
            this.DatosDelUsuarioGroupBox.TabStop = false;
            this.DatosDelUsuarioGroupBox.Text = "Consultar Usuarios";
            // 
            // DatosDelUsuarioButton
            // 
            this.DatosDelUsuarioButton.Location = new System.Drawing.Point(5, 30);
            this.DatosDelUsuarioButton.Name = "DatosDelUsuarioButton";
            this.DatosDelUsuarioButton.Size = new System.Drawing.Size(180, 50);
            this.DatosDelUsuarioButton.TabIndex = 24;
            this.DatosDelUsuarioButton.Text = "Datos del usuario";
            this.DatosDelUsuarioButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DatosDelUsuarioButton.UseVisualStyleBackColor = true;
            this.DatosDelUsuarioButton.Click += new System.EventHandler(this.DatosDelUsuarioButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RealizarBusquedaButton);
            this.groupBox1.Controls.Add(this.CriterioTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.FiltroComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 223);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // RealizarBusquedaButton
            // 
            this.RealizarBusquedaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RealizarBusquedaButton.Location = new System.Drawing.Point(9, 157);
            this.RealizarBusquedaButton.Name = "RealizarBusquedaButton";
            this.RealizarBusquedaButton.Size = new System.Drawing.Size(173, 46);
            this.RealizarBusquedaButton.TabIndex = 4;
            this.RealizarBusquedaButton.Text = "Realizar Busqueda";
            this.RealizarBusquedaButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RealizarBusquedaButton.UseVisualStyleBackColor = true;
            this.RealizarBusquedaButton.Click += new System.EventHandler(this.RealizarBusquedaButton_Click);
            // 
            // CriterioTextBox
            // 
            this.CriterioTextBox.Location = new System.Drawing.Point(5, 115);
            this.CriterioTextBox.Name = "CriterioTextBox";
            this.CriterioTextBox.Size = new System.Drawing.Size(180, 22);
            this.CriterioTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Criterio";
            // 
            // FiltroComboBox
            // 
            this.FiltroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltroComboBox.FormattingEnabled = true;
            this.FiltroComboBox.Items.AddRange(new object[] {
            "Todo",
            "Codigo",
            "Nombres y Apellidos",
            "Cedula",
            "Celular",
            "Usuario",
            "Nivel de Usuario"});
            this.FiltroComboBox.Location = new System.Drawing.Point(5, 55);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(180, 24);
            this.FiltroComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtrar por";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UsuariosDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(200, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(749, 323);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // UsuariosDataGridView
            // 
            this.UsuariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsuariosDataGridView.Location = new System.Drawing.Point(5, 10);
            this.UsuariosDataGridView.Name = "UsuariosDataGridView";
            this.UsuariosDataGridView.ReadOnly = true;
            this.UsuariosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsuariosDataGridView.Size = new System.Drawing.Size(738, 307);
            this.UsuariosDataGridView.TabIndex = 0;
            this.UsuariosDataGridView.Click += new System.EventHandler(this.UsuariosDataGridView_Click);
            this.UsuariosDataGridView.DoubleClick += new System.EventHandler(this.UsuariosDataGridView_DoubleClick);
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // cUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 335);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DatosDelUsuarioGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "cUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consultas de Usuarios";
            this.Load += new System.EventHandler(this.ConsultasUsuarios_Load);
            this.DatosDelUsuarioGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox DatosDelUsuarioGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button RealizarBusquedaButton;
        private System.Windows.Forms.TextBox CriterioTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView UsuariosDataGridView;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.Button DatosDelUsuarioButton;
    }
}