namespace InventoryAssistant.UI.Consultas
{
    partial class cProductos
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
            this.DatosDelProductoButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ProductosDataGridView = new System.Windows.Forms.DataGridView();
            this.DatosDelUsuarioGroupBox = new System.Windows.Forms.GroupBox();
            this.GenerarEntradaButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HastaLabel = new System.Windows.Forms.Label();
            this.HastaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DesdeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.RealizarBusquedaButton = new System.Windows.Forms.Button();
            this.CriterioTextBox = new System.Windows.Forms.TextBox();
            this.CriterioLabel = new System.Windows.Forms.Label();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.FiltrarPorlabel = new System.Windows.Forms.Label();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosDataGridView)).BeginInit();
            this.DatosDelUsuarioGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HastaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DesdeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // DatosDelProductoButton
            // 
            this.DatosDelProductoButton.Location = new System.Drawing.Point(5, 30);
            this.DatosDelProductoButton.Name = "DatosDelProductoButton";
            this.DatosDelProductoButton.Size = new System.Drawing.Size(180, 50);
            this.DatosDelProductoButton.TabIndex = 24;
            this.DatosDelProductoButton.Text = "Datos del Producto";
            this.DatosDelProductoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DatosDelProductoButton.UseVisualStyleBackColor = true;
            this.DatosDelProductoButton.Click += new System.EventHandler(this.DatosDelProductoButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ProductosDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(200, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(730, 369);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // ProductosDataGridView
            // 
            this.ProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductosDataGridView.Location = new System.Drawing.Point(5, 10);
            this.ProductosDataGridView.Name = "ProductosDataGridView";
            this.ProductosDataGridView.ReadOnly = true;
            this.ProductosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductosDataGridView.Size = new System.Drawing.Size(718, 353);
            this.ProductosDataGridView.TabIndex = 0;
            this.ProductosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductosDataGridView_CellContentClick);
            this.ProductosDataGridView.Click += new System.EventHandler(this.ProductosDataGridView_Click);
            this.ProductosDataGridView.DoubleClick += new System.EventHandler(this.ProductosDataGridView_DoubleClick);
            // 
            // DatosDelUsuarioGroupBox
            // 
            this.DatosDelUsuarioGroupBox.Controls.Add(this.GenerarEntradaButton);
            this.DatosDelUsuarioGroupBox.Controls.Add(this.DatosDelProductoButton);
            this.DatosDelUsuarioGroupBox.Controls.Add(this.groupBox1);
            this.DatosDelUsuarioGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatosDelUsuarioGroupBox.Location = new System.Drawing.Point(5, 4);
            this.DatosDelUsuarioGroupBox.Name = "DatosDelUsuarioGroupBox";
            this.DatosDelUsuarioGroupBox.Size = new System.Drawing.Size(190, 371);
            this.DatosDelUsuarioGroupBox.TabIndex = 25;
            this.DatosDelUsuarioGroupBox.TabStop = false;
            this.DatosDelUsuarioGroupBox.Text = "Consultar Productos";
            this.DatosDelUsuarioGroupBox.Enter += new System.EventHandler(this.DatosDelUsuarioGroupBox_Enter);
            // 
            // GenerarEntradaButton
            // 
            this.GenerarEntradaButton.Location = new System.Drawing.Point(4, 86);
            this.GenerarEntradaButton.Name = "GenerarEntradaButton";
            this.GenerarEntradaButton.Size = new System.Drawing.Size(180, 50);
            this.GenerarEntradaButton.TabIndex = 25;
            this.GenerarEntradaButton.Text = "      Genenrar Entrada";
            this.GenerarEntradaButton.UseVisualStyleBackColor = true;
            this.GenerarEntradaButton.Click += new System.EventHandler(this.GenerarEntradaButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HastaLabel);
            this.groupBox1.Controls.Add(this.HastaNumericUpDown);
            this.groupBox1.Controls.Add(this.DesdeNumericUpDown);
            this.groupBox1.Controls.Add(this.RealizarBusquedaButton);
            this.groupBox1.Controls.Add(this.CriterioTextBox);
            this.groupBox1.Controls.Add(this.CriterioLabel);
            this.groupBox1.Controls.Add(this.FiltroComboBox);
            this.groupBox1.Controls.Add(this.FiltrarPorlabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 223);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // HastaLabel
            // 
            this.HastaLabel.AutoSize = true;
            this.HastaLabel.Location = new System.Drawing.Point(104, 90);
            this.HastaLabel.Name = "HastaLabel";
            this.HastaLabel.Size = new System.Drawing.Size(49, 16);
            this.HastaLabel.TabIndex = 7;
            this.HastaLabel.Text = "Hasta";
            this.HastaLabel.Click += new System.EventHandler(this.HastaLabel_Click);
            // 
            // HastaNumericUpDown
            // 
            this.HastaNumericUpDown.DecimalPlaces = 2;
            this.HastaNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.HastaNumericUpDown.Location = new System.Drawing.Point(107, 116);
            this.HastaNumericUpDown.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.HastaNumericUpDown.Name = "HastaNumericUpDown";
            this.HastaNumericUpDown.Size = new System.Drawing.Size(80, 22);
            this.HastaNumericUpDown.TabIndex = 6;
            this.HastaNumericUpDown.ValueChanged += new System.EventHandler(this.HastaNumericUpDown_ValueChanged);
            // 
            // DesdeNumericUpDown
            // 
            this.DesdeNumericUpDown.DecimalPlaces = 2;
            this.DesdeNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.DesdeNumericUpDown.Location = new System.Drawing.Point(5, 116);
            this.DesdeNumericUpDown.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.DesdeNumericUpDown.Name = "DesdeNumericUpDown";
            this.DesdeNumericUpDown.Size = new System.Drawing.Size(80, 22);
            this.DesdeNumericUpDown.TabIndex = 5;
            this.DesdeNumericUpDown.ValueChanged += new System.EventHandler(this.DesdeNumericUpDown_ValueChanged);
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
            this.CriterioTextBox.TextChanged += new System.EventHandler(this.CriterioTextBox_TextChanged);
            // 
            // CriterioLabel
            // 
            this.CriterioLabel.AutoSize = true;
            this.CriterioLabel.Location = new System.Drawing.Point(5, 90);
            this.CriterioLabel.Name = "CriterioLabel";
            this.CriterioLabel.Size = new System.Drawing.Size(58, 16);
            this.CriterioLabel.TabIndex = 2;
            this.CriterioLabel.Text = "Criterio";
            this.CriterioLabel.Click += new System.EventHandler(this.CriterioLabel_Click);
            // 
            // FiltroComboBox
            // 
            this.FiltroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltroComboBox.FormattingEnabled = true;
            this.FiltroComboBox.Items.AddRange(new object[] {
            "Todo",
            "Codigo",
            "Descripción",
            "Categoría",
            "Cantidad",
            "Precio"});
            this.FiltroComboBox.Location = new System.Drawing.Point(5, 55);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(180, 24);
            this.FiltroComboBox.TabIndex = 1;
            this.FiltroComboBox.SelectedIndexChanged += new System.EventHandler(this.FiltroComboBox_SelectedIndexChanged);
            // 
            // FiltrarPorlabel
            // 
            this.FiltrarPorlabel.AutoSize = true;
            this.FiltrarPorlabel.Location = new System.Drawing.Point(8, 30);
            this.FiltrarPorlabel.Name = "FiltrarPorlabel";
            this.FiltrarPorlabel.Size = new System.Drawing.Size(75, 16);
            this.FiltrarPorlabel.TabIndex = 0;
            this.FiltrarPorlabel.Text = "Filtrar por";
            this.FiltrarPorlabel.Click += new System.EventHandler(this.FiltrarPorlabel_Click);
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // cProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 380);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DatosDelUsuarioGroupBox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "cProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "cProductos";
            this.Load += new System.EventHandler(this.cProductos_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductosDataGridView)).EndInit();
            this.DatosDelUsuarioGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HastaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DesdeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DatosDelProductoButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView ProductosDataGridView;
        private System.Windows.Forms.GroupBox DatosDelUsuarioGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button RealizarBusquedaButton;
        private System.Windows.Forms.TextBox CriterioTextBox;
        private System.Windows.Forms.Label CriterioLabel;
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.Label FiltrarPorlabel;
        private System.Windows.Forms.Button GenerarEntradaButton;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.NumericUpDown HastaNumericUpDown;
        private System.Windows.Forms.NumericUpDown DesdeNumericUpDown;
        private System.Windows.Forms.Label HastaLabel;
    }
}