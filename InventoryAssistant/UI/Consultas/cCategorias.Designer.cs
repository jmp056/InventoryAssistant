namespace InventoryAssistant.UI.Consultas
{
    partial class cCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cCategorias));
            this.CategoriasDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DatosDeLaCategoriaGroupBox = new System.Windows.Forms.GroupBox();
            this.DatosDeLaCategoriaButton = new System.Windows.Forms.Button();
            this.BuscarGroupBox = new System.Windows.Forms.GroupBox();
            this.RealizarBusquedaButton = new System.Windows.Forms.Button();
            this.CriterioTextBox = new System.Windows.Forms.TextBox();
            this.CriterioLabel = new System.Windows.Forms.Label();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.FiltrarPorLabel = new System.Windows.Forms.Label();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CategoriasDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.DatosDeLaCategoriaGroupBox.SuspendLayout();
            this.BuscarGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoriasDataGridView
            // 
            this.CategoriasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoriasDataGridView.Location = new System.Drawing.Point(5, 10);
            this.CategoriasDataGridView.Name = "CategoriasDataGridView";
            this.CategoriasDataGridView.Size = new System.Drawing.Size(393, 307);
            this.CategoriasDataGridView.TabIndex = 0;
            this.CategoriasDataGridView.Click += new System.EventHandler(this.CategoriasDataGridView_Click);
            this.CategoriasDataGridView.DoubleClick += new System.EventHandler(this.CategoriasDataGridView_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CategoriasDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(214, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(402, 323);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // DatosDeLaCategoriaGroupBox
            // 
            this.DatosDeLaCategoriaGroupBox.Controls.Add(this.DatosDeLaCategoriaButton);
            this.DatosDeLaCategoriaGroupBox.Controls.Add(this.BuscarGroupBox);
            this.DatosDeLaCategoriaGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatosDeLaCategoriaGroupBox.Location = new System.Drawing.Point(4, 3);
            this.DatosDeLaCategoriaGroupBox.Name = "DatosDeLaCategoriaGroupBox";
            this.DatosDeLaCategoriaGroupBox.Size = new System.Drawing.Size(205, 324);
            this.DatosDeLaCategoriaGroupBox.TabIndex = 25;
            this.DatosDeLaCategoriaGroupBox.TabStop = false;
            this.DatosDeLaCategoriaGroupBox.Text = "Consultar Categorías";
            // 
            // DatosDeLaCategoriaButton
            // 
            this.DatosDeLaCategoriaButton.Location = new System.Drawing.Point(5, 30);
            this.DatosDeLaCategoriaButton.Name = "DatosDeLaCategoriaButton";
            this.DatosDeLaCategoriaButton.Size = new System.Drawing.Size(195, 50);
            this.DatosDeLaCategoriaButton.TabIndex = 24;
            this.DatosDeLaCategoriaButton.Text = "Datos de la Categoria";
            this.DatosDeLaCategoriaButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DatosDeLaCategoriaButton.UseVisualStyleBackColor = true;
            this.DatosDeLaCategoriaButton.Click += new System.EventHandler(this.DatosDeLaCategoriaButton_Click);
            // 
            // BuscarGroupBox
            // 
            this.BuscarGroupBox.Controls.Add(this.RealizarBusquedaButton);
            this.BuscarGroupBox.Controls.Add(this.CriterioTextBox);
            this.BuscarGroupBox.Controls.Add(this.CriterioLabel);
            this.BuscarGroupBox.Controls.Add(this.FiltroComboBox);
            this.BuscarGroupBox.Controls.Add(this.FiltrarPorLabel);
            this.BuscarGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarGroupBox.Location = new System.Drawing.Point(0, 101);
            this.BuscarGroupBox.Name = "BuscarGroupBox";
            this.BuscarGroupBox.Size = new System.Drawing.Size(205, 223);
            this.BuscarGroupBox.TabIndex = 23;
            this.BuscarGroupBox.TabStop = false;
            this.BuscarGroupBox.Text = "Buscar";
            // 
            // RealizarBusquedaButton
            // 
            this.RealizarBusquedaButton.Image = ((System.Drawing.Image)(resources.GetObject("RealizarBusquedaButton.Image")));
            this.RealizarBusquedaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RealizarBusquedaButton.Location = new System.Drawing.Point(17, 157);
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
            this.CriterioTextBox.Size = new System.Drawing.Size(195, 22);
            this.CriterioTextBox.TabIndex = 3;
            // 
            // CriterioLabel
            // 
            this.CriterioLabel.AutoSize = true;
            this.CriterioLabel.Location = new System.Drawing.Point(5, 90);
            this.CriterioLabel.Name = "CriterioLabel";
            this.CriterioLabel.Size = new System.Drawing.Size(58, 16);
            this.CriterioLabel.TabIndex = 2;
            this.CriterioLabel.Text = "Criterio";
            // 
            // FiltroComboBox
            // 
            this.FiltroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltroComboBox.FormattingEnabled = true;
            this.FiltroComboBox.Items.AddRange(new object[] {
            "Todo",
            "Codigo",
            "Nombre"});
            this.FiltroComboBox.Location = new System.Drawing.Point(5, 55);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(195, 24);
            this.FiltroComboBox.TabIndex = 1;
            // 
            // FiltrarPorLabel
            // 
            this.FiltrarPorLabel.AutoSize = true;
            this.FiltrarPorLabel.Location = new System.Drawing.Point(8, 30);
            this.FiltrarPorLabel.Name = "FiltrarPorLabel";
            this.FiltrarPorLabel.Size = new System.Drawing.Size(75, 16);
            this.FiltrarPorLabel.TabIndex = 0;
            this.FiltrarPorLabel.Text = "Filtrar por";
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // cCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 335);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DatosDeLaCategoriaGroupBox);
            this.Name = "cCategorias";
            this.Text = "cCategorias";
            this.Load += new System.EventHandler(this.cCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CategoriasDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.DatosDeLaCategoriaGroupBox.ResumeLayout(false);
            this.BuscarGroupBox.ResumeLayout(false);
            this.BuscarGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CategoriasDataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox DatosDeLaCategoriaGroupBox;
        private System.Windows.Forms.GroupBox BuscarGroupBox;
        private System.Windows.Forms.Button RealizarBusquedaButton;
        private System.Windows.Forms.TextBox CriterioTextBox;
        private System.Windows.Forms.Label CriterioLabel;
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.Label FiltrarPorLabel;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.Button DatosDeLaCategoriaButton;
    }
}