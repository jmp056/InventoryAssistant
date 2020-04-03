namespace InventoryAssistant.UI.Consultas
{
    partial class cCuadreDeCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cCuadreDeCaja));
            this.CuadresDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DatosDelCuadreGroupBox = new System.Windows.Forms.GroupBox();
            this.DatosDelCuadreButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FechaGroupBox = new System.Windows.Forms.GroupBox();
            this.HastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DesdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.HastaFechaLabel = new System.Windows.Forms.Label();
            this.DesdeFechaLabel = new System.Windows.Forms.Label();
            this.FiltrarPorFechaCheckBox = new System.Windows.Forms.CheckBox();
            this.HastaLabel = new System.Windows.Forms.Label();
            this.HastaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DesdeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.RealizarBusquedaButton = new System.Windows.Forms.Button();
            this.CriterioTextBox = new System.Windows.Forms.TextBox();
            this.CriterioLabel = new System.Windows.Forms.Label();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.FiltrarPorlabel = new System.Windows.Forms.Label();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CuadresDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.DatosDelCuadreGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.FechaGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HastaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DesdeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // CuadresDataGridView
            // 
            this.CuadresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CuadresDataGridView.Location = new System.Drawing.Point(5, 10);
            this.CuadresDataGridView.Name = "CuadresDataGridView";
            this.CuadresDataGridView.ReadOnly = true;
            this.CuadresDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CuadresDataGridView.Size = new System.Drawing.Size(718, 388);
            this.CuadresDataGridView.TabIndex = 0;
            this.CuadresDataGridView.Click += new System.EventHandler(this.CuadresDataGridView_Click);
            this.CuadresDataGridView.DoubleClick += new System.EventHandler(this.CuadresDataGridView_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CuadresDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(202, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(730, 405);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            // 
            // DatosDelCuadreGroupBox
            // 
            this.DatosDelCuadreGroupBox.Controls.Add(this.DatosDelCuadreButton);
            this.DatosDelCuadreGroupBox.Controls.Add(this.groupBox1);
            this.DatosDelCuadreGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatosDelCuadreGroupBox.Location = new System.Drawing.Point(7, 3);
            this.DatosDelCuadreGroupBox.Name = "DatosDelCuadreGroupBox";
            this.DatosDelCuadreGroupBox.Size = new System.Drawing.Size(190, 406);
            this.DatosDelCuadreGroupBox.TabIndex = 27;
            this.DatosDelCuadreGroupBox.TabStop = false;
            this.DatosDelCuadreGroupBox.Text = "Consultar Cuadres";
            // 
            // DatosDelCuadreButton
            // 
            this.DatosDelCuadreButton.Location = new System.Drawing.Point(5, 30);
            this.DatosDelCuadreButton.Name = "DatosDelCuadreButton";
            this.DatosDelCuadreButton.Size = new System.Drawing.Size(180, 50);
            this.DatosDelCuadreButton.TabIndex = 24;
            this.DatosDelCuadreButton.Text = "Datos del Cuadre";
            this.DatosDelCuadreButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DatosDelCuadreButton.UseVisualStyleBackColor = true;
            this.DatosDelCuadreButton.Click += new System.EventHandler(this.DatosDelCuadreButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FechaGroupBox);
            this.groupBox1.Controls.Add(this.HastaLabel);
            this.groupBox1.Controls.Add(this.HastaNumericUpDown);
            this.groupBox1.Controls.Add(this.DesdeNumericUpDown);
            this.groupBox1.Controls.Add(this.RealizarBusquedaButton);
            this.groupBox1.Controls.Add(this.CriterioTextBox);
            this.groupBox1.Controls.Add(this.CriterioLabel);
            this.groupBox1.Controls.Add(this.FiltroComboBox);
            this.groupBox1.Controls.Add(this.FiltrarPorlabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 311);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // FechaGroupBox
            // 
            this.FechaGroupBox.Controls.Add(this.HastaDateTimePicker);
            this.FechaGroupBox.Controls.Add(this.DesdeDateTimePicker);
            this.FechaGroupBox.Controls.Add(this.HastaFechaLabel);
            this.FechaGroupBox.Controls.Add(this.DesdeFechaLabel);
            this.FechaGroupBox.Controls.Add(this.FiltrarPorFechaCheckBox);
            this.FechaGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaGroupBox.Location = new System.Drawing.Point(0, 157);
            this.FechaGroupBox.Name = "FechaGroupBox";
            this.FechaGroupBox.Size = new System.Drawing.Size(190, 92);
            this.FechaGroupBox.TabIndex = 33;
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
            // FiltrarPorFechaCheckBox
            // 
            this.FiltrarPorFechaCheckBox.AutoSize = true;
            this.FiltrarPorFechaCheckBox.Location = new System.Drawing.Point(9, 0);
            this.FiltrarPorFechaCheckBox.Name = "FiltrarPorFechaCheckBox";
            this.FiltrarPorFechaCheckBox.Size = new System.Drawing.Size(15, 14);
            this.FiltrarPorFechaCheckBox.TabIndex = 0;
            this.FiltrarPorFechaCheckBox.UseVisualStyleBackColor = true;
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
            this.RealizarBusquedaButton.Image = ((System.Drawing.Image)(resources.GetObject("RealizarBusquedaButton.Image")));
            this.RealizarBusquedaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RealizarBusquedaButton.Location = new System.Drawing.Point(9, 254);
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
            "Usuario",
            "Total Vendido",
            "Diferencia",
            "Total en Caja"});
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
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // cCuadreDeCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 416);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DatosDelCuadreGroupBox);
            this.Name = "cCuadreDeCaja";
            this.Text = "cCuadreDeCaja";
            this.Load += new System.EventHandler(this.cCuadreDeCaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CuadresDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.DatosDelCuadreGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.FechaGroupBox.ResumeLayout(false);
            this.FechaGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HastaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DesdeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CuadresDataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox DatosDelCuadreGroupBox;
        private System.Windows.Forms.Button DatosDelCuadreButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label HastaLabel;
        private System.Windows.Forms.NumericUpDown HastaNumericUpDown;
        private System.Windows.Forms.NumericUpDown DesdeNumericUpDown;
        private System.Windows.Forms.Button RealizarBusquedaButton;
        private System.Windows.Forms.TextBox CriterioTextBox;
        private System.Windows.Forms.Label CriterioLabel;
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.Label FiltrarPorlabel;
        private System.Windows.Forms.GroupBox FechaGroupBox;
        private System.Windows.Forms.DateTimePicker HastaDateTimePicker;
        private System.Windows.Forms.DateTimePicker DesdeDateTimePicker;
        private System.Windows.Forms.Label HastaFechaLabel;
        private System.Windows.Forms.Label DesdeFechaLabel;
        private System.Windows.Forms.CheckBox FiltrarPorFechaCheckBox;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}