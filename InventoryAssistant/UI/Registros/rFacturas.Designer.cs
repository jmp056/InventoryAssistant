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
            this.DetalleDataGridView = new System.Windows.Forms.DataGridView();
            this.VerProductosButton = new System.Windows.Forms.Button();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.EliminarProductoButton = new System.Windows.Forms.Button();
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
            this.AgregarProductoButton = new System.Windows.Forms.Button();
            this.BuscarProductoButton = new System.Windows.Forms.Button();
            this.FacturaIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FacturaIdLabel = new System.Windows.Forms.Label();
            this.VendedorLabel = new System.Windows.Forms.Label();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.FechaLabel = new System.Windows.Forms.Label();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ClienteTextBox = new System.Windows.Forms.TextBox();
            this.ClienteLabel = new System.Windows.Forms.Label();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.BuscarButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.UsuarioToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.EstadoToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.DetalleGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DetalleGroupBox
            // 
            this.DetalleGroupBox.Controls.Add(this.DetalleDataGridView);
            this.DetalleGroupBox.Controls.Add(this.VerProductosButton);
            this.DetalleGroupBox.Controls.Add(this.TotalLabel);
            this.DetalleGroupBox.Controls.Add(this.EliminarProductoButton);
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
            this.DetalleGroupBox.Controls.Add(this.AgregarProductoButton);
            this.DetalleGroupBox.Controls.Add(this.BuscarProductoButton);
            this.DetalleGroupBox.Location = new System.Drawing.Point(12, 108);
            this.DetalleGroupBox.Name = "DetalleGroupBox";
            this.DetalleGroupBox.Size = new System.Drawing.Size(592, 328);
            this.DetalleGroupBox.TabIndex = 100;
            this.DetalleGroupBox.TabStop = false;
            // 
            // DetalleDataGridView
            // 
            this.DetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalleDataGridView.Location = new System.Drawing.Point(18, 97);
            this.DetalleDataGridView.Name = "DetalleDataGridView";
            this.DetalleDataGridView.ReadOnly = true;
            this.DetalleDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DetalleDataGridView.Size = new System.Drawing.Size(548, 175);
            this.DetalleDataGridView.TabIndex = 118;
            this.DetalleDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DetalleDataGridView_CellContentClick_1);
            // 
            // VerProductosButton
            // 
            this.VerProductosButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerProductosButton.Location = new System.Drawing.Point(20, 15);
            this.VerProductosButton.Name = "VerProductosButton";
            this.VerProductosButton.Size = new System.Drawing.Size(33, 35);
            this.VerProductosButton.TabIndex = 117;
            this.VerProductosButton.UseVisualStyleBackColor = true;
            this.VerProductosButton.Click += new System.EventHandler(this.VerProductosButton_Click);
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(377, 295);
            this.TotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(78, 16);
            this.TotalLabel.TabIndex = 116;
            this.TotalLabel.Text = "Total RD$";
            // 
            // EliminarProductoButton
            // 
            this.EliminarProductoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarProductoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarProductoButton.Location = new System.Drawing.Point(30, 290);
            this.EliminarProductoButton.Margin = new System.Windows.Forms.Padding(4);
            this.EliminarProductoButton.Name = "EliminarProductoButton";
            this.EliminarProductoButton.Size = new System.Drawing.Size(165, 30);
            this.EliminarProductoButton.TabIndex = 115;
            this.EliminarProductoButton.Text = "Eliminar Producto";
            this.EliminarProductoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarProductoButton.UseVisualStyleBackColor = true;
            this.EliminarProductoButton.Click += new System.EventHandler(this.EliminarProductoButton_Click);
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.BackColor = System.Drawing.Color.White;
            this.TotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTextBox.Location = new System.Drawing.Point(457, 292);
            this.TotalTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(98, 22);
            this.TotalTextBox.TabIndex = 115;
            this.TotalTextBox.Text = "0.00";
            // 
            // CantidadNumericUpDown
            // 
            this.CantidadNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadNumericUpDown.Location = new System.Drawing.Point(100, 62);
            this.CantidadNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.CantidadNumericUpDown.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.CantidadNumericUpDown.Name = "CantidadNumericUpDown";
            this.CantidadNumericUpDown.Size = new System.Drawing.Size(68, 22);
            this.CantidadNumericUpDown.TabIndex = 112;
            this.CantidadNumericUpDown.ValueChanged += new System.EventHandler(this.CantidadNumericUpDown_ValueChanged);
            // 
            // PrecioNumericUpDown
            // 
            this.PrecioNumericUpDown.BackColor = System.Drawing.Color.White;
            this.PrecioNumericUpDown.DecimalPlaces = 2;
            this.PrecioNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PrecioNumericUpDown.Location = new System.Drawing.Point(250, 62);
            this.PrecioNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.PrecioNumericUpDown.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.PrecioNumericUpDown.Name = "PrecioNumericUpDown";
            this.PrecioNumericUpDown.Size = new System.Drawing.Size(90, 22);
            this.PrecioNumericUpDown.TabIndex = 113;
            this.PrecioNumericUpDown.ValueChanged += new System.EventHandler(this.PrecioNumericUpDown_ValueChanged);
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.BackColor = System.Drawing.Color.White;
            this.DescripcionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionTextBox.Location = new System.Drawing.Point(355, 22);
            this.DescripcionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.ReadOnly = true;
            this.DescripcionTextBox.Size = new System.Drawing.Size(200, 22);
            this.DescripcionTextBox.TabIndex = 114;
            // 
            // ImporteTextBox
            // 
            this.ImporteTextBox.BackColor = System.Drawing.Color.White;
            this.ImporteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImporteTextBox.Location = new System.Drawing.Point(425, 63);
            this.ImporteTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ImporteTextBox.Name = "ImporteTextBox";
            this.ImporteTextBox.ReadOnly = true;
            this.ImporteTextBox.Size = new System.Drawing.Size(80, 22);
            this.ImporteTextBox.TabIndex = 115;
            this.ImporteTextBox.Text = "0.00";
            // 
            // ProductoIdNumericUpDown
            // 
            this.ProductoIdNumericUpDown.BackColor = System.Drawing.SystemColors.Window;
            this.ProductoIdNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductoIdNumericUpDown.Location = new System.Drawing.Point(130, 22);
            this.ProductoIdNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.ProductoIdNumericUpDown.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.ProductoIdNumericUpDown.Name = "ProductoIdNumericUpDown";
            this.ProductoIdNumericUpDown.Size = new System.Drawing.Size(61, 22);
            this.ProductoIdNumericUpDown.TabIndex = 112;
            // 
            // ImporteLabel
            // 
            this.ImporteLabel.AutoSize = true;
            this.ImporteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImporteLabel.Location = new System.Drawing.Point(360, 65);
            this.ImporteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ImporteLabel.Name = "ImporteLabel";
            this.ImporteLabel.Size = new System.Drawing.Size(64, 16);
            this.ImporteLabel.TabIndex = 116;
            this.ImporteLabel.Text = "Importe:";
            // 
            // PrecioLabel
            // 
            this.PrecioLabel.AutoSize = true;
            this.PrecioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioLabel.Location = new System.Drawing.Point(190, 65);
            this.PrecioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PrecioLabel.Name = "PrecioLabel";
            this.PrecioLabel.Size = new System.Drawing.Size(57, 16);
            this.PrecioLabel.TabIndex = 115;
            this.PrecioLabel.Text = "Precio:";
            // 
            // CantidadLabel
            // 
            this.CantidadLabel.AutoSize = true;
            this.CantidadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadLabel.Location = new System.Drawing.Point(20, 65);
            this.CantidadLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CantidadLabel.Name = "CantidadLabel";
            this.CantidadLabel.Size = new System.Drawing.Size(74, 16);
            this.CantidadLabel.TabIndex = 114;
            this.CantidadLabel.Text = "Cantidad:";
            // 
            // DescripcionLabel
            // 
            this.DescripcionLabel.AutoSize = true;
            this.DescripcionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionLabel.Location = new System.Drawing.Point(255, 25);
            this.DescripcionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DescripcionLabel.Name = "DescripcionLabel";
            this.DescripcionLabel.Size = new System.Drawing.Size(95, 16);
            this.DescripcionLabel.TabIndex = 113;
            this.DescripcionLabel.Text = "Descripción:";
            // 
            // ProductoIdLabel
            // 
            this.ProductoIdLabel.AutoSize = true;
            this.ProductoIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductoIdLabel.Location = new System.Drawing.Point(60, 25);
            this.ProductoIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProductoIdLabel.Name = "ProductoIdLabel";
            this.ProductoIdLabel.Size = new System.Drawing.Size(62, 16);
            this.ProductoIdLabel.TabIndex = 112;
            this.ProductoIdLabel.Text = "Código:";
            // 
            // AgregarProductoButton
            // 
            this.AgregarProductoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarProductoButton.Location = new System.Drawing.Point(525, 58);
            this.AgregarProductoButton.Name = "AgregarProductoButton";
            this.AgregarProductoButton.Size = new System.Drawing.Size(30, 30);
            this.AgregarProductoButton.TabIndex = 17;
            this.AgregarProductoButton.UseVisualStyleBackColor = true;
            this.AgregarProductoButton.Click += new System.EventHandler(this.AgregarProductoButton_Click);
            // 
            // BuscarProductoButton
            // 
            this.BuscarProductoButton.Location = new System.Drawing.Point(214, 17);
            this.BuscarProductoButton.Name = "BuscarProductoButton";
            this.BuscarProductoButton.Size = new System.Drawing.Size(33, 33);
            this.BuscarProductoButton.TabIndex = 8;
            this.BuscarProductoButton.UseVisualStyleBackColor = true;
            this.BuscarProductoButton.Click += new System.EventHandler(this.BuscarProductoButton_Click);
            // 
            // FacturaIdNumericUpDown
            // 
            this.FacturaIdNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacturaIdNumericUpDown.Location = new System.Drawing.Point(127, 27);
            this.FacturaIdNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.FacturaIdNumericUpDown.Name = "FacturaIdNumericUpDown";
            this.FacturaIdNumericUpDown.Size = new System.Drawing.Size(92, 22);
            this.FacturaIdNumericUpDown.TabIndex = 104;
            // 
            // FacturaIdLabel
            // 
            this.FacturaIdLabel.AutoSize = true;
            this.FacturaIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacturaIdLabel.Location = new System.Drawing.Point(25, 29);
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
            this.VendedorLabel.Location = new System.Drawing.Point(25, 69);
            this.VendedorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VendedorLabel.Name = "VendedorLabel";
            this.VendedorLabel.Size = new System.Drawing.Size(80, 16);
            this.VendedorLabel.TabIndex = 105;
            this.VendedorLabel.Text = "Vendedor:";
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.BackColor = System.Drawing.Color.White;
            this.UsuarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioTextBox.Location = new System.Drawing.Point(107, 67);
            this.UsuarioTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.ReadOnly = true;
            this.UsuarioTextBox.Size = new System.Drawing.Size(190, 22);
            this.UsuarioTextBox.TabIndex = 106;
            // 
            // FechaLabel
            // 
            this.FechaLabel.AutoSize = true;
            this.FechaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaLabel.Location = new System.Drawing.Point(399, 29);
            this.FechaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FechaLabel.Name = "FechaLabel";
            this.FechaLabel.Size = new System.Drawing.Size(55, 16);
            this.FechaLabel.TabIndex = 107;
            this.FechaLabel.Text = "Fecha:";
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(462, 27);
            this.FechaDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(116, 22);
            this.FechaDateTimePicker.TabIndex = 108;
            this.FechaDateTimePicker.Value = new System.DateTime(2020, 3, 12, 0, 0, 0, 0);
            // 
            // ClienteTextBox
            // 
            this.ClienteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienteTextBox.Location = new System.Drawing.Point(380, 67);
            this.ClienteTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ClienteTextBox.Name = "ClienteTextBox";
            this.ClienteTextBox.Size = new System.Drawing.Size(198, 22);
            this.ClienteTextBox.TabIndex = 110;
            // 
            // ClienteLabel
            // 
            this.ClienteLabel.AutoSize = true;
            this.ClienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienteLabel.Location = new System.Drawing.Point(315, 69);
            this.ClienteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ClienteLabel.Name = "ClienteLabel";
            this.ClienteLabel.Size = new System.Drawing.Size(60, 16);
            this.ClienteLabel.TabIndex = 111;
            this.ClienteLabel.Text = "Cliente:";
            // 
            // EliminarButton
            // 
            this.EliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(479, 464);
            this.EliminarButton.Margin = new System.Windows.Forms.Padding(4);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(100, 35);
            this.EliminarButton.TabIndex = 112;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.Location = new System.Drawing.Point(273, 464);
            this.GuardarButton.Margin = new System.Windows.Forms.Padding(4);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(100, 35);
            this.GuardarButton.TabIndex = 113;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimpiarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LimpiarButton.Location = new System.Drawing.Point(23, 464);
            this.LimpiarButton.Margin = new System.Windows.Forms.Padding(4);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(100, 35);
            this.LimpiarButton.TabIndex = 114;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LimpiarButton.UseVisualStyleBackColor = true;
            this.LimpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(240, 20);
            this.BuscarButton.Margin = new System.Windows.Forms.Padding(4);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(100, 35);
            this.BuscarButton.TabIndex = 109;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UsuarioToolStripStatusLabel,
            this.EstadoToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 512);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(616, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 115;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // UsuarioToolStripStatusLabel
            // 
            this.UsuarioToolStripStatusLabel.Name = "UsuarioToolStripStatusLabel";
            this.UsuarioToolStripStatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UsuarioToolStripStatusLabel.Size = new System.Drawing.Size(37, 17);
            this.UsuarioToolStripStatusLabel.Text = "          ";
            // 
            // EstadoToolStripStatusLabel
            // 
            this.EstadoToolStripStatusLabel.Name = "EstadoToolStripStatusLabel";
            this.EstadoToolStripStatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EstadoToolStripStatusLabel.Size = new System.Drawing.Size(37, 17);
            this.EstadoToolStripStatusLabel.Text = "          ";
            // 
            // rFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 534);
            this.Controls.Add(this.statusStrip1);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "rFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registro de Facturas";
            this.Load += new System.EventHandler(this.rFacturas_Load);
            this.DetalleGroupBox.ResumeLayout(false);
            this.DetalleGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox DetalleGroupBox;
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
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.TextBox ImporteTextBox;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.Button EliminarProductoButton;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.Button VerProductosButton;
        private System.Windows.Forms.NumericUpDown PrecioNumericUpDown;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel UsuarioToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel EstadoToolStripStatusLabel;
        private System.Windows.Forms.DataGridView DetalleDataGridView;
    }
}