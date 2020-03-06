namespace InventoryAssistant.UI.Registros
{
    partial class rFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rFacturas));
            this.DetalleGroupBox = new System.Windows.Forms.GroupBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.CantidadNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PrecioNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.ImporteTextBox = new System.Windows.Forms.TextBox();
            this.ProductoIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ImporteLabel = new System.Windows.Forms.Label();
            this.PrecioLabel = new System.Windows.Forms.Label();
            this.CantidadLabel = new System.Windows.Forms.Label();
            this.DescripcionLabel = new System.Windows.Forms.Label();
            this.ProductoIdLabel = new System.Windows.Forms.Label();
            this.DetalleDataGridView = new System.Windows.Forms.DataGridView();
            this.AgregarProductoButton = new System.Windows.Forms.Button();
            this.BuscarProductoButton = new System.Windows.Forms.Button();
            this.FacturaIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FacturaIdLabel = new System.Windows.Forms.Label();
            this.VendedorLabel = new System.Windows.Forms.Label();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.FechaLabel = new System.Windows.Forms.Label();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.ClienteTextBox = new System.Windows.Forms.TextBox();
            this.ClienteLabel = new System.Windows.Forms.Label();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.DetalleGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // DetalleGroupBox
            // 
            this.DetalleGroupBox.Controls.Add(this.TotalLabel);
            this.DetalleGroupBox.Controls.Add(this.button1);
            this.DetalleGroupBox.Controls.Add(this.TotalTextBox);
            this.DetalleGroupBox.Controls.Add(this.CantidadNumericUpDown);
            this.DetalleGroupBox.Controls.Add(this.PrecioNumericUpDown);
            this.DetalleGroupBox.Controls.Add(this.DescripcionTextBox);
            this.DetalleGroupBox.Controls.Add(this.ImporteTextBox);
            this.DetalleGroupBox.Controls.Add(this.ProductoIdNumericUpDown);
            this.DetalleGroupBox.Controls.Add(this.ImporteLabel);
            this.DetalleGroupBox.Controls.Add(this.PrecioLabel);
            this.DetalleGroupBox.Controls.Add(this.CantidadLabel);
            this.DetalleGroupBox.Controls.Add(this.DescripcionLabel);
            this.DetalleGroupBox.Controls.Add(this.ProductoIdLabel);
            this.DetalleGroupBox.Controls.Add(this.DetalleDataGridView);
            this.DetalleGroupBox.Controls.Add(this.AgregarProductoButton);
            this.DetalleGroupBox.Controls.Add(this.BuscarProductoButton);
            this.DetalleGroupBox.Location = new System.Drawing.Point(12, 108);
            this.DetalleGroupBox.Name = "DetalleGroupBox";
            this.DetalleGroupBox.Size = new System.Drawing.Size(619, 334);
            this.DetalleGroupBox.TabIndex = 100;
            this.DetalleGroupBox.TabStop = false;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(410, 300);
            this.TotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(78, 16);
            this.TotalLabel.TabIndex = 116;
            this.TotalLabel.Text = "Total RD$";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(10, 289);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 35);
            this.button1.TabIndex = 115;
            this.button1.Text = "Eliminar Producto";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTextBox.Location = new System.Drawing.Point(490, 298);
            this.TotalTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.Size = new System.Drawing.Size(98, 22);
            this.TotalTextBox.TabIndex = 115;
            // 
            // CantidadNumericUpDown
            // 
            this.CantidadNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadNumericUpDown.Location = new System.Drawing.Point(315, 35);
            this.CantidadNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.CantidadNumericUpDown.Name = "CantidadNumericUpDown";
            this.CantidadNumericUpDown.Size = new System.Drawing.Size(68, 22);
            this.CantidadNumericUpDown.TabIndex = 112;
            // 
            // PrecioNumericUpDown
            // 
            this.PrecioNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioNumericUpDown.Location = new System.Drawing.Point(395, 35);
            this.PrecioNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.PrecioNumericUpDown.Name = "PrecioNumericUpDown";
            this.PrecioNumericUpDown.Size = new System.Drawing.Size(90, 22);
            this.PrecioNumericUpDown.TabIndex = 113;
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionTextBox.Location = new System.Drawing.Point(120, 35);
            this.DescripcionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(187, 22);
            this.DescripcionTextBox.TabIndex = 114;
            // 
            // ImporteTextBox
            // 
            this.ImporteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImporteTextBox.Location = new System.Drawing.Point(495, 35);
            this.ImporteTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ImporteTextBox.Name = "ImporteTextBox";
            this.ImporteTextBox.Size = new System.Drawing.Size(80, 22);
            this.ImporteTextBox.TabIndex = 115;
            // 
            // ProductoIdNumericUpDown
            // 
            this.ProductoIdNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductoIdNumericUpDown.Location = new System.Drawing.Point(10, 35);
            this.ProductoIdNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.ProductoIdNumericUpDown.Name = "ProductoIdNumericUpDown";
            this.ProductoIdNumericUpDown.Size = new System.Drawing.Size(70, 22);
            this.ProductoIdNumericUpDown.TabIndex = 112;
            // 
            // ImporteLabel
            // 
            this.ImporteLabel.AutoSize = true;
            this.ImporteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImporteLabel.Location = new System.Drawing.Point(495, 20);
            this.ImporteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ImporteLabel.Name = "ImporteLabel";
            this.ImporteLabel.Size = new System.Drawing.Size(49, 13);
            this.ImporteLabel.TabIndex = 116;
            this.ImporteLabel.Text = "Importe";
            // 
            // PrecioLabel
            // 
            this.PrecioLabel.AutoSize = true;
            this.PrecioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioLabel.Location = new System.Drawing.Point(395, 20);
            this.PrecioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PrecioLabel.Name = "PrecioLabel";
            this.PrecioLabel.Size = new System.Drawing.Size(43, 13);
            this.PrecioLabel.TabIndex = 115;
            this.PrecioLabel.Text = "Precio";
            // 
            // CantidadLabel
            // 
            this.CantidadLabel.AutoSize = true;
            this.CantidadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadLabel.Location = new System.Drawing.Point(315, 20);
            this.CantidadLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CantidadLabel.Name = "CantidadLabel";
            this.CantidadLabel.Size = new System.Drawing.Size(57, 13);
            this.CantidadLabel.TabIndex = 114;
            this.CantidadLabel.Text = "Cantidad";
            // 
            // DescripcionLabel
            // 
            this.DescripcionLabel.AutoSize = true;
            this.DescripcionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionLabel.Location = new System.Drawing.Point(120, 20);
            this.DescripcionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DescripcionLabel.Name = "DescripcionLabel";
            this.DescripcionLabel.Size = new System.Drawing.Size(74, 13);
            this.DescripcionLabel.TabIndex = 113;
            this.DescripcionLabel.Text = "Descripción";
            // 
            // ProductoIdLabel
            // 
            this.ProductoIdLabel.AutoSize = true;
            this.ProductoIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductoIdLabel.Location = new System.Drawing.Point(10, 20);
            this.ProductoIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProductoIdLabel.Name = "ProductoIdLabel";
            this.ProductoIdLabel.Size = new System.Drawing.Size(58, 13);
            this.ProductoIdLabel.TabIndex = 112;
            this.ProductoIdLabel.Text = "Producto";
            // 
            // DetalleDataGridView
            // 
            this.DetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalleDataGridView.Location = new System.Drawing.Point(6, 69);
            this.DetalleDataGridView.Name = "DetalleDataGridView";
            this.DetalleDataGridView.ReadOnly = true;
            this.DetalleDataGridView.Size = new System.Drawing.Size(604, 213);
            this.DetalleDataGridView.TabIndex = 18;
            // 
            // AgregarProductoButton
            // 
            this.AgregarProductoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarProductoButton.Image = ((System.Drawing.Image)(resources.GetObject("AgregarProductoButton.Image")));
            this.AgregarProductoButton.Location = new System.Drawing.Point(580, 30);
            this.AgregarProductoButton.Name = "AgregarProductoButton";
            this.AgregarProductoButton.Size = new System.Drawing.Size(30, 30);
            this.AgregarProductoButton.TabIndex = 17;
            this.AgregarProductoButton.UseVisualStyleBackColor = true;
            // 
            // BuscarProductoButton
            // 
            this.BuscarProductoButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarProductoButton.Image")));
            this.BuscarProductoButton.Location = new System.Drawing.Point(85, 30);
            this.BuscarProductoButton.Name = "BuscarProductoButton";
            this.BuscarProductoButton.Size = new System.Drawing.Size(30, 30);
            this.BuscarProductoButton.TabIndex = 8;
            this.BuscarProductoButton.UseVisualStyleBackColor = true;
            // 
            // FacturaIdNumericUpDown
            // 
            this.FacturaIdNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacturaIdNumericUpDown.Location = new System.Drawing.Point(140, 28);
            this.FacturaIdNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.FacturaIdNumericUpDown.Name = "FacturaIdNumericUpDown";
            this.FacturaIdNumericUpDown.Size = new System.Drawing.Size(113, 22);
            this.FacturaIdNumericUpDown.TabIndex = 104;
            // 
            // FacturaIdLabel
            // 
            this.FacturaIdLabel.AutoSize = true;
            this.FacturaIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacturaIdLabel.Location = new System.Drawing.Point(35, 30);
            this.FacturaIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FacturaIdLabel.Name = "FacturaIdLabel";
            this.FacturaIdLabel.Size = new System.Drawing.Size(92, 16);
            this.FacturaIdLabel.TabIndex = 103;
            this.FacturaIdLabel.Text = "No. Factura:";
            // 
            // VendedorLabel
            // 
            this.VendedorLabel.AutoSize = true;
            this.VendedorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendedorLabel.Location = new System.Drawing.Point(35, 70);
            this.VendedorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VendedorLabel.Name = "VendedorLabel";
            this.VendedorLabel.Size = new System.Drawing.Size(80, 16);
            this.VendedorLabel.TabIndex = 105;
            this.VendedorLabel.Text = "Vendedor:";
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioTextBox.Location = new System.Drawing.Point(120, 68);
            this.UsuarioTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.Size = new System.Drawing.Size(190, 22);
            this.UsuarioTextBox.TabIndex = 106;
            // 
            // FechaLabel
            // 
            this.FechaLabel.AutoSize = true;
            this.FechaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaLabel.Location = new System.Drawing.Point(369, 30);
            this.FechaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FechaLabel.Name = "FechaLabel";
            this.FechaLabel.Size = new System.Drawing.Size(55, 16);
            this.FechaLabel.TabIndex = 107;
            this.FechaLabel.Text = "Fecha:";
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.CustomFormat = "dd/MM/yyyy - hh:mm:ss tt";
            this.FechaDateTimePicker.Enabled = false;
            this.FechaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(425, 28);
            this.FechaDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(188, 22);
            this.FechaDateTimePicker.TabIndex = 108;
            this.FechaDateTimePicker.Value = new System.DateTime(2020, 3, 5, 0, 3, 0, 0);
            // 
            // BuscarButton
            // 
            this.BuscarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarButton.Location = new System.Drawing.Point(261, 21);
            this.BuscarButton.Margin = new System.Windows.Forms.Padding(4);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(100, 35);
            this.BuscarButton.TabIndex = 109;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // ClienteTextBox
            // 
            this.ClienteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienteTextBox.Location = new System.Drawing.Point(393, 70);
            this.ClienteTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ClienteTextBox.Name = "ClienteTextBox";
            this.ClienteTextBox.Size = new System.Drawing.Size(190, 22);
            this.ClienteTextBox.TabIndex = 110;
            // 
            // ClienteLabel
            // 
            this.ClienteLabel.AutoSize = true;
            this.ClienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienteLabel.Location = new System.Drawing.Point(325, 73);
            this.ClienteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ClienteLabel.Name = "ClienteLabel";
            this.ClienteLabel.Size = new System.Drawing.Size(60, 16);
            this.ClienteLabel.TabIndex = 111;
            this.ClienteLabel.Text = "Cliente:";
            // 
            // EliminarButton
            // 
            this.EliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.Location = new System.Drawing.Point(513, 464);
            this.EliminarButton.Margin = new System.Windows.Forms.Padding(4);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(100, 35);
            this.EliminarButton.TabIndex = 112;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarButton.UseVisualStyleBackColor = true;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Location = new System.Drawing.Point(273, 464);
            this.GuardarButton.Margin = new System.Windows.Forms.Padding(4);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(100, 35);
            this.GuardarButton.TabIndex = 113;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = true;
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimpiarButton.Location = new System.Drawing.Point(23, 464);
            this.LimpiarButton.Margin = new System.Windows.Forms.Padding(4);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(100, 35);
            this.LimpiarButton.TabIndex = 114;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LimpiarButton.UseVisualStyleBackColor = true;
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // rFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 512);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.LimpiarButton);
            this.Controls.Add(this.ClienteLabel);
            this.Controls.Add(this.ClienteTextBox);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(this.FechaLabel);
            this.Controls.Add(this.UsuarioTextBox);
            this.Controls.Add(this.VendedorLabel);
            this.Controls.Add(this.FacturaIdNumericUpDown);
            this.Controls.Add(this.FacturaIdLabel);
            this.Controls.Add(this.DetalleGroupBox);
            this.Name = "rFacturas";
            this.Text = "rFacturas";
            this.DetalleGroupBox.ResumeLayout(false);
            this.DetalleGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox DetalleGroupBox;
        private System.Windows.Forms.DataGridView DetalleDataGridView;
        private System.Windows.Forms.Button AgregarProductoButton;
        private System.Windows.Forms.Button BuscarProductoButton;
        private System.Windows.Forms.NumericUpDown FacturaIdNumericUpDown;
        private System.Windows.Forms.Label FacturaIdLabel;
        private System.Windows.Forms.Label VendedorLabel;
        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.Label FechaLabel;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.TextBox ClienteTextBox;
        private System.Windows.Forms.Label ClienteLabel;
        private System.Windows.Forms.NumericUpDown ProductoIdNumericUpDown;
        private System.Windows.Forms.Label ImporteLabel;
        private System.Windows.Forms.Label PrecioLabel;
        private System.Windows.Forms.Label CantidadLabel;
        private System.Windows.Forms.Label DescripcionLabel;
        private System.Windows.Forms.Label ProductoIdLabel;
        private System.Windows.Forms.NumericUpDown CantidadNumericUpDown;
        private System.Windows.Forms.NumericUpDown PrecioNumericUpDown;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.TextBox ImporteTextBox;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}