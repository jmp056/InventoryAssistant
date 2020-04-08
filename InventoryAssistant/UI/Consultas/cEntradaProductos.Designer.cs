namespace InventoryAssistant.UI.Consultas
{
    partial class cEntradaProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cEntradaProductos));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EntradasProductosDataGridView = new System.Windows.Forms.DataGridView();
            this.DatosDelUsuarioGroupBox = new System.Windows.Forms.GroupBox();
            this.DatosDeLaEntradaButton = new System.Windows.Forms.Button();
            this.BuscarGroupBox = new System.Windows.Forms.GroupBox();
            this.HastaLabel = new System.Windows.Forms.Label();
            this.HastaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DesdeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.RealizarBusquedaButton = new System.Windows.Forms.Button();
            this.CriterioTextBox = new System.Windows.Forms.TextBox();
            this.CriterioLabel = new System.Windows.Forms.Label();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.FiltrarPorlabel = new System.Windows.Forms.Label();
            this.DesdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DesdeFechaLabel = new System.Windows.Forms.Label();
            this.FechaGroupBox = new System.Windows.Forms.GroupBox();
            this.HastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.HastaFechaLabel = new System.Windows.Forms.Label();
            this.FiltrarPorFechaCheckBox = new System.Windows.Forms.CheckBox();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EntradasProductosDataGridView)).BeginInit();
            this.DatosDelUsuarioGroupBox.SuspendLayout();
            this.BuscarGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HastaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DesdeNumericUpDown)).BeginInit();
            this.FechaGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.EntradasProductosDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(201, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(565, 416);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            // 
            // EntradasProductosDataGridView
            // 
            this.EntradasProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EntradasProductosDataGridView.Location = new System.Drawing.Point(6, 10);
            this.EntradasProductosDataGridView.Name = "EntradasProductosDataGridView";
            this.EntradasProductosDataGridView.ReadOnly = true;
            this.EntradasProductosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EntradasProductosDataGridView.Size = new System.Drawing.Size(553, 400);
            this.EntradasProductosDataGridView.TabIndex = 0;
            this.EntradasProductosDataGridView.Click += new System.EventHandler(this.EntradasProductosDataGridView_Click);
            this.EntradasProductosDataGridView.DoubleClick += new System.EventHandler(this.EntradasProductosDataGridView_DoubleClick);
            // 
            // DatosDelUsuarioGroupBox
            // 
            this.DatosDelUsuarioGroupBox.Controls.Add(this.DatosDeLaEntradaButton);
            this.DatosDelUsuarioGroupBox.Controls.Add(this.BuscarGroupBox);
            this.DatosDelUsuarioGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatosDelUsuarioGroupBox.Location = new System.Drawing.Point(6, 4);
            this.DatosDelUsuarioGroupBox.Name = "DatosDelUsuarioGroupBox";
            this.DatosDelUsuarioGroupBox.Size = new System.Drawing.Size(190, 417);
            this.DatosDelUsuarioGroupBox.TabIndex = 27;
            this.DatosDelUsuarioGroupBox.TabStop = false;
            this.DatosDelUsuarioGroupBox.Text = "Consultar Entradas";
            // 
            // DatosDeLaEntradaButton
            // 
            this.DatosDeLaEntradaButton.Image = global::InventoryAssistant.Properties.Resources.DatosDeLaEntradaBtn;
            this.DatosDeLaEntradaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DatosDeLaEntradaButton.Location = new System.Drawing.Point(5, 30);
            this.DatosDeLaEntradaButton.Name = "DatosDeLaEntradaButton";
            this.DatosDeLaEntradaButton.Size = new System.Drawing.Size(180, 50);
            this.DatosDeLaEntradaButton.TabIndex = 24;
            this.DatosDeLaEntradaButton.Text = "Datos de la Entrada";
            this.DatosDeLaEntradaButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DatosDeLaEntradaButton.UseVisualStyleBackColor = true;
            this.DatosDeLaEntradaButton.Click += new System.EventHandler(this.DatosDeLaEntradaButton_Click);
            // 
            // BuscarGroupBox
            // 
            this.BuscarGroupBox.Controls.Add(this.HastaLabel);
            this.BuscarGroupBox.Controls.Add(this.HastaNumericUpDown);
            this.BuscarGroupBox.Controls.Add(this.DesdeNumericUpDown);
            this.BuscarGroupBox.Controls.Add(this.RealizarBusquedaButton);
            this.BuscarGroupBox.Controls.Add(this.CriterioTextBox);
            this.BuscarGroupBox.Controls.Add(this.CriterioLabel);
            this.BuscarGroupBox.Controls.Add(this.FiltroComboBox);
            this.BuscarGroupBox.Controls.Add(this.FiltrarPorlabel);
            this.BuscarGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarGroupBox.Location = new System.Drawing.Point(0, 96);
            this.BuscarGroupBox.Name = "BuscarGroupBox";
            this.BuscarGroupBox.Size = new System.Drawing.Size(190, 321);
            this.BuscarGroupBox.TabIndex = 23;
            this.BuscarGroupBox.TabStop = false;
            this.BuscarGroupBox.Text = "Buscar";
            // 
            // HastaLabel
            // 
            this.HastaLabel.AutoSize = true;
            this.HastaLabel.Location = new System.Drawing.Point(104, 90);
            this.HastaLabel.Name = "HastaLabel";
            this.HastaLabel.Size = new System.Drawing.Size(49, 16);
            this.HastaLabel.TabIndex = 7;
            this.HastaLabel.Text = "Hasta";
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
            // 
            // RealizarBusquedaButton
            // 
            this.RealizarBusquedaButton.Image = global::InventoryAssistant.Properties.Resources.BuscarButtonImg;
            this.RealizarBusquedaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RealizarBusquedaButton.Location = new System.Drawing.Point(8, 261);
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
            "Producto",
            "Cantidad"});
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
            // 
            // DesdeDateTimePicker
            // 
            this.DesdeDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.DesdeDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesdeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DesdeDateTimePicker.Location = new System.Drawing.Point(65, 28);
            this.DesdeDateTimePicker.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.DesdeDateTimePicker.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.DesdeDateTimePicker.Name = "DesdeDateTimePicker";
            this.DesdeDateTimePicker.Size = new System.Drawing.Size(120, 21);
            this.DesdeDateTimePicker.TabIndex = 8;
            this.DesdeDateTimePicker.Value = new System.DateTime(2020, 3, 30, 0, 0, 0, 0);
            // 
            // DesdeFechaLabel
            // 
            this.DesdeFechaLabel.AutoSize = true;
            this.DesdeFechaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesdeFechaLabel.Location = new System.Drawing.Point(5, 30);
            this.DesdeFechaLabel.Name = "DesdeFechaLabel";
            this.DesdeFechaLabel.Size = new System.Drawing.Size(58, 16);
            this.DesdeFechaLabel.TabIndex = 10;
            this.DesdeFechaLabel.Text = "Desde:";
            // 
            // FechaGroupBox
            // 
            this.FechaGroupBox.Controls.Add(this.HastaDateTimePicker);
            this.FechaGroupBox.Controls.Add(this.DesdeDateTimePicker);
            this.FechaGroupBox.Controls.Add(this.HastaFechaLabel);
            this.FechaGroupBox.Controls.Add(this.DesdeFechaLabel);
            this.FechaGroupBox.Controls.Add(this.FiltrarPorFechaCheckBox);
            this.FechaGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaGroupBox.Location = new System.Drawing.Point(6, 263);
            this.FechaGroupBox.Name = "FechaGroupBox";
            this.FechaGroupBox.Size = new System.Drawing.Size(190, 92);
            this.FechaGroupBox.TabIndex = 29;
            this.FechaGroupBox.TabStop = false;
            this.FechaGroupBox.Text = "     Filtrar por Fecha";
            // 
            // HastaDateTimePicker
            // 
            this.HastaDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.HastaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HastaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastaDateTimePicker.Location = new System.Drawing.Point(65, 58);
            this.HastaDateTimePicker.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.HastaDateTimePicker.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.HastaDateTimePicker.Name = "HastaDateTimePicker";
            this.HastaDateTimePicker.Size = new System.Drawing.Size(120, 21);
            this.HastaDateTimePicker.TabIndex = 12;
            this.HastaDateTimePicker.Value = new System.DateTime(2020, 3, 30, 0, 0, 0, 0);
            // 
            // HastaFechaLabel
            // 
            this.HastaFechaLabel.AutoSize = true;
            this.HastaFechaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HastaFechaLabel.Location = new System.Drawing.Point(5, 60);
            this.HastaFechaLabel.Name = "HastaFechaLabel";
            this.HastaFechaLabel.Size = new System.Drawing.Size(53, 16);
            this.HastaFechaLabel.TabIndex = 11;
            this.HastaFechaLabel.Text = "Hasta:";
            // 
            // FiltrarPorFechaCheckBox
            // 
            this.FiltrarPorFechaCheckBox.AutoSize = true;
            this.FiltrarPorFechaCheckBox.Location = new System.Drawing.Point(9, 0);
            this.FiltrarPorFechaCheckBox.Name = "FiltrarPorFechaCheckBox";
            this.FiltrarPorFechaCheckBox.Size = new System.Drawing.Size(15, 14);
            this.FiltrarPorFechaCheckBox.TabIndex = 0;
            this.FiltrarPorFechaCheckBox.UseVisualStyleBackColor = true;
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // cEntradaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 429);
            this.Controls.Add(this.FechaGroupBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DatosDelUsuarioGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "cEntradaProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta de Entradas de Productos";
            this.Activated += new System.EventHandler(this.cEntradaProductos_Activated);
            this.Load += new System.EventHandler(this.cEntradaProductos_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EntradasProductosDataGridView)).EndInit();
            this.DatosDelUsuarioGroupBox.ResumeLayout(false);
            this.BuscarGroupBox.ResumeLayout(false);
            this.BuscarGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HastaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DesdeNumericUpDown)).EndInit();
            this.FechaGroupBox.ResumeLayout(false);
            this.FechaGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView EntradasProductosDataGridView;
        private System.Windows.Forms.GroupBox DatosDelUsuarioGroupBox;
        private System.Windows.Forms.Button DatosDeLaEntradaButton;
        private System.Windows.Forms.GroupBox BuscarGroupBox;
        private System.Windows.Forms.Label HastaLabel;
        private System.Windows.Forms.NumericUpDown HastaNumericUpDown;
        private System.Windows.Forms.NumericUpDown DesdeNumericUpDown;
        private System.Windows.Forms.Button RealizarBusquedaButton;
        private System.Windows.Forms.TextBox CriterioTextBox;
        private System.Windows.Forms.Label CriterioLabel;
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.Label FiltrarPorlabel;
        private System.Windows.Forms.Label DesdeFechaLabel;
        private System.Windows.Forms.DateTimePicker DesdeDateTimePicker;
        private System.Windows.Forms.GroupBox FechaGroupBox;
        private System.Windows.Forms.CheckBox FiltrarPorFechaCheckBox;
        private System.Windows.Forms.Label HastaFechaLabel;
        private System.Windows.Forms.DateTimePicker HastaDateTimePicker;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}