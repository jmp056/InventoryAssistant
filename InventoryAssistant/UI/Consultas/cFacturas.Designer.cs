namespace InventoryAssistant.UI.Consultas
{
    partial class cFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cFacturas));
            this.FechaGroupBox = new System.Windows.Forms.GroupBox();
            this.HastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DesdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.HastaFechaLabel = new System.Windows.Forms.Label();
            this.DesdeFechaLabel = new System.Windows.Forms.Label();
            this.FiltrarPorFechaCheckBox = new System.Windows.Forms.CheckBox();
            this.RealizarBusquedaButton = new System.Windows.Forms.Button();
            this.HastaLabel = new System.Windows.Forms.Label();
            this.HastaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DatosDeLaFacturaGroupBox = new System.Windows.Forms.GroupBox();
            this.DatosDeLaFacturaButton = new System.Windows.Forms.Button();
            this.BuscarGroupBox = new System.Windows.Forms.GroupBox();
            this.DesdeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CriterioTextBox = new System.Windows.Forms.TextBox();
            this.CriterioLabel = new System.Windows.Forms.Label();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.FiltrarPorlabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FacturaDataGridView = new System.Windows.Forms.DataGridView();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.FechaGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HastaNumericUpDown)).BeginInit();
            this.DatosDeLaFacturaGroupBox.SuspendLayout();
            this.BuscarGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DesdeNumericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // FechaGroupBox
            // 
            this.FechaGroupBox.Controls.Add(this.HastaDateTimePicker);
            this.FechaGroupBox.Controls.Add(this.DesdeDateTimePicker);
            this.FechaGroupBox.Controls.Add(this.HastaFechaLabel);
            this.FechaGroupBox.Controls.Add(this.DesdeFechaLabel);
            this.FechaGroupBox.Controls.Add(this.FiltrarPorFechaCheckBox);
            this.FechaGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaGroupBox.Location = new System.Drawing.Point(9, 266);
            this.FechaGroupBox.Name = "FechaGroupBox";
            this.FechaGroupBox.Size = new System.Drawing.Size(190, 92);
            this.FechaGroupBox.TabIndex = 32;
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
            // RealizarBusquedaButton
            // 
            this.RealizarBusquedaButton.Image = ((System.Drawing.Image)(resources.GetObject("RealizarBusquedaButton.Image")));
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
            // DatosDeLaFacturaGroupBox
            // 
            this.DatosDeLaFacturaGroupBox.Controls.Add(this.DatosDeLaFacturaButton);
            this.DatosDeLaFacturaGroupBox.Controls.Add(this.BuscarGroupBox);
            this.DatosDeLaFacturaGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatosDeLaFacturaGroupBox.Location = new System.Drawing.Point(9, 5);
            this.DatosDeLaFacturaGroupBox.Name = "DatosDeLaFacturaGroupBox";
            this.DatosDeLaFacturaGroupBox.Size = new System.Drawing.Size(190, 417);
            this.DatosDeLaFacturaGroupBox.TabIndex = 30;
            this.DatosDeLaFacturaGroupBox.TabStop = false;
            this.DatosDeLaFacturaGroupBox.Text = "Consultar Facturas";
            // 
            // DatosDeLaFacturaButton
            // 
            this.DatosDeLaFacturaButton.Location = new System.Drawing.Point(5, 30);
            this.DatosDeLaFacturaButton.Name = "DatosDeLaFacturaButton";
            this.DatosDeLaFacturaButton.Size = new System.Drawing.Size(180, 50);
            this.DatosDeLaFacturaButton.TabIndex = 24;
            this.DatosDeLaFacturaButton.Text = "Datos de la Factura";
            this.DatosDeLaFacturaButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DatosDeLaFacturaButton.UseVisualStyleBackColor = true;
            this.DatosDeLaFacturaButton.Click += new System.EventHandler(this.DatosDeLaEntradaButton_Click);
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
            // DesdeNumericUpDown
            // 
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
            "Vendedor",
            "Cliente",
            "Monto"});
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FacturaDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(204, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(733, 416);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            // 
            // FacturaDataGridView
            // 
            this.FacturaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FacturaDataGridView.Location = new System.Drawing.Point(6, 10);
            this.FacturaDataGridView.Name = "FacturaDataGridView";
            this.FacturaDataGridView.Size = new System.Drawing.Size(723, 400);
            this.FacturaDataGridView.TabIndex = 0;
            this.FacturaDataGridView.Click += new System.EventHandler(this.FacturaDataGridView_Click);
            this.FacturaDataGridView.DoubleClick += new System.EventHandler(this.FacturaDataGridView_DoubleClick);
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // cFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 450);
            this.Controls.Add(this.FechaGroupBox);
            this.Controls.Add(this.DatosDeLaFacturaGroupBox);
            this.Controls.Add(this.groupBox2);
            this.Name = "cFacturas";
            this.Text = "cFacturas";
            this.Load += new System.EventHandler(this.cFacturas_Load);
            this.FechaGroupBox.ResumeLayout(false);
            this.FechaGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HastaNumericUpDown)).EndInit();
            this.DatosDeLaFacturaGroupBox.ResumeLayout(false);
            this.BuscarGroupBox.ResumeLayout(false);
            this.BuscarGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DesdeNumericUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FacturaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox FechaGroupBox;
        private System.Windows.Forms.DateTimePicker HastaDateTimePicker;
        private System.Windows.Forms.DateTimePicker DesdeDateTimePicker;
        private System.Windows.Forms.Label HastaFechaLabel;
        private System.Windows.Forms.Label DesdeFechaLabel;
        private System.Windows.Forms.CheckBox FiltrarPorFechaCheckBox;
        private System.Windows.Forms.Button RealizarBusquedaButton;
        private System.Windows.Forms.Label HastaLabel;
        private System.Windows.Forms.NumericUpDown HastaNumericUpDown;
        private System.Windows.Forms.GroupBox DatosDeLaFacturaGroupBox;
        private System.Windows.Forms.Button DatosDeLaFacturaButton;
        private System.Windows.Forms.GroupBox BuscarGroupBox;
        private System.Windows.Forms.NumericUpDown DesdeNumericUpDown;
        private System.Windows.Forms.TextBox CriterioTextBox;
        private System.Windows.Forms.Label CriterioLabel;
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.Label FiltrarPorlabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView FacturaDataGridView;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}