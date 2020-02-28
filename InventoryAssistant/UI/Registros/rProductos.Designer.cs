namespace InventoryAssistant.UI.Registros
{
    partial class rProductos
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
            this.RDLabel = new System.Windows.Forms.Label();
            this.PrecioLabel = new System.Windows.Forms.Label();
            this.CategoriaLabel = new System.Windows.Forms.Label();
            this.DescripcionLabel = new System.Windows.Forms.Label();
            this.ProductoIdLabel = new System.Windows.Forms.Label();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.IdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ControlAlmacenCheckBox = new System.Windows.Forms.CheckBox();
            this.InventarioLabel = new System.Windows.Forms.Label();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.ControlAlmacenLabel = new System.Windows.Forms.Label();
            this.CategoriaComboBox = new System.Windows.Forms.ComboBox();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.FechaDeRegistroDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FechaDeRegistroLabel = new System.Windows.Forms.Label();
            this.CantidadNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PrecioNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // RDLabel
            // 
            this.RDLabel.AutoSize = true;
            this.RDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDLabel.Location = new System.Drawing.Point(150, 230);
            this.RDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RDLabel.Name = "RDLabel";
            this.RDLabel.Size = new System.Drawing.Size(38, 16);
            this.RDLabel.TabIndex = 12;
            this.RDLabel.Text = "RD$";
            // 
            // PrecioLabel
            // 
            this.PrecioLabel.AutoSize = true;
            this.PrecioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioLabel.Location = new System.Drawing.Point(35, 230);
            this.PrecioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PrecioLabel.Name = "PrecioLabel";
            this.PrecioLabel.Size = new System.Drawing.Size(53, 16);
            this.PrecioLabel.TabIndex = 11;
            this.PrecioLabel.Text = "Precio";
            // 
            // CategoriaLabel
            // 
            this.CategoriaLabel.AutoSize = true;
            this.CategoriaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriaLabel.Location = new System.Drawing.Point(35, 110);
            this.CategoriaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CategoriaLabel.Name = "CategoriaLabel";
            this.CategoriaLabel.Size = new System.Drawing.Size(76, 16);
            this.CategoriaLabel.TabIndex = 9;
            this.CategoriaLabel.Text = "Categoria";
            // 
            // DescripcionLabel
            // 
            this.DescripcionLabel.AutoSize = true;
            this.DescripcionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionLabel.Location = new System.Drawing.Point(35, 70);
            this.DescripcionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DescripcionLabel.Name = "DescripcionLabel";
            this.DescripcionLabel.Size = new System.Drawing.Size(91, 16);
            this.DescripcionLabel.TabIndex = 8;
            this.DescripcionLabel.Text = "Descripción";
            // 
            // ProductoIdLabel
            // 
            this.ProductoIdLabel.AutoSize = true;
            this.ProductoIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductoIdLabel.Location = new System.Drawing.Point(35, 30);
            this.ProductoIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProductoIdLabel.Name = "ProductoIdLabel";
            this.ProductoIdLabel.Size = new System.Drawing.Size(154, 16);
            this.ProductoIdLabel.TabIndex = 7;
            this.ProductoIdLabel.Text = "Código del Producto:";
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscarbutton.Location = new System.Drawing.Point(343, 21);
            this.Buscarbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(100, 35);
            this.Buscarbutton.TabIndex = 29;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionTextBox.Location = new System.Drawing.Point(210, 68);
            this.DescripcionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(233, 22);
            this.DescripcionTextBox.TabIndex = 28;
            // 
            // IdNumericUpDown
            // 
            this.IdNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdNumericUpDown.Location = new System.Drawing.Point(210, 28);
            this.IdNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.IdNumericUpDown.Name = "IdNumericUpDown";
            this.IdNumericUpDown.Size = new System.Drawing.Size(113, 22);
            this.IdNumericUpDown.TabIndex = 27;
            // 
            // ControlAlmacenCheckBox
            // 
            this.ControlAlmacenCheckBox.AutoSize = true;
            this.ControlAlmacenCheckBox.Location = new System.Drawing.Point(210, 150);
            this.ControlAlmacenCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.ControlAlmacenCheckBox.Name = "ControlAlmacenCheckBox";
            this.ControlAlmacenCheckBox.Size = new System.Drawing.Size(15, 14);
            this.ControlAlmacenCheckBox.TabIndex = 31;
            this.ControlAlmacenCheckBox.UseVisualStyleBackColor = true;
            // 
            // InventarioLabel
            // 
            this.InventarioLabel.AutoSize = true;
            this.InventarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventarioLabel.Location = new System.Drawing.Point(35, 190);
            this.InventarioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InventarioLabel.Name = "InventarioLabel";
            this.InventarioLabel.Size = new System.Drawing.Size(147, 16);
            this.InventarioLabel.TabIndex = 32;
            this.InventarioLabel.Text = "Cantidad disponible";
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimpiarButton.Location = new System.Drawing.Point(26, 330);
            this.LimpiarButton.Margin = new System.Windows.Forms.Padding(4);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(100, 35);
            this.LimpiarButton.TabIndex = 32;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LimpiarButton.UseVisualStyleBackColor = true;
            this.LimpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Location = new System.Drawing.Point(187, 330);
            this.GuardarButton.Margin = new System.Windows.Forms.Padding(4);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(100, 35);
            this.GuardarButton.TabIndex = 31;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.Location = new System.Drawing.Point(347, 330);
            this.EliminarButton.Margin = new System.Windows.Forms.Padding(4);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(100, 35);
            this.EliminarButton.TabIndex = 30;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarButton.UseVisualStyleBackColor = true;
            // 
            // ControlAlmacenLabel
            // 
            this.ControlAlmacenLabel.AutoSize = true;
            this.ControlAlmacenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControlAlmacenLabel.Location = new System.Drawing.Point(35, 150);
            this.ControlAlmacenLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ControlAlmacenLabel.Name = "ControlAlmacenLabel";
            this.ControlAlmacenLabel.Size = new System.Drawing.Size(154, 13);
            this.ControlAlmacenLabel.TabIndex = 36;
            this.ControlAlmacenLabel.Text = "Llevar control en almacen";
            // 
            // CategoriaComboBox
            // 
            this.CategoriaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoriaComboBox.FormattingEnabled = true;
            this.CategoriaComboBox.Items.AddRange(new object[] {
            "Accesorios",
            "Calzados",
            "Pacas"});
            this.CategoriaComboBox.Location = new System.Drawing.Point(210, 108);
            this.CategoriaComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.CategoriaComboBox.Name = "CategoriaComboBox";
            this.CategoriaComboBox.Size = new System.Drawing.Size(173, 24);
            this.CategoriaComboBox.TabIndex = 37;
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // FechaDeRegistroDateTimePicker
            // 
            this.FechaDeRegistroDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaDeRegistroDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaDeRegistroDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaDeRegistroDateTimePicker.Location = new System.Drawing.Point(210, 268);
            this.FechaDeRegistroDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.FechaDeRegistroDateTimePicker.Name = "FechaDeRegistroDateTimePicker";
            this.FechaDeRegistroDateTimePicker.Size = new System.Drawing.Size(113, 22);
            this.FechaDeRegistroDateTimePicker.TabIndex = 39;
            // 
            // FechaDeRegistroLabel
            // 
            this.FechaDeRegistroLabel.AutoSize = true;
            this.FechaDeRegistroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaDeRegistroLabel.Location = new System.Drawing.Point(35, 270);
            this.FechaDeRegistroLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FechaDeRegistroLabel.Name = "FechaDeRegistroLabel";
            this.FechaDeRegistroLabel.Size = new System.Drawing.Size(134, 16);
            this.FechaDeRegistroLabel.TabIndex = 38;
            this.FechaDeRegistroLabel.Text = "Fecha de registro:";
            // 
            // CantidadNumericUpDown
            // 
            this.CantidadNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadNumericUpDown.Location = new System.Drawing.Point(209, 188);
            this.CantidadNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.CantidadNumericUpDown.Name = "CantidadNumericUpDown";
            this.CantidadNumericUpDown.Size = new System.Drawing.Size(113, 22);
            this.CantidadNumericUpDown.TabIndex = 66;
            // 
            // PrecioNumericUpDown
            // 
            this.PrecioNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioNumericUpDown.Location = new System.Drawing.Point(210, 228);
            this.PrecioNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.PrecioNumericUpDown.Name = "PrecioNumericUpDown";
            this.PrecioNumericUpDown.Size = new System.Drawing.Size(113, 22);
            this.PrecioNumericUpDown.TabIndex = 67;
            // 
            // rProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 391);
            this.Controls.Add(this.PrecioNumericUpDown);
            this.Controls.Add(this.CantidadNumericUpDown);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.LimpiarButton);
            this.Controls.Add(this.FechaDeRegistroDateTimePicker);
            this.Controls.Add(this.FechaDeRegistroLabel);
            this.Controls.Add(this.CategoriaComboBox);
            this.Controls.Add(this.ControlAlmacenLabel);
            this.Controls.Add(this.InventarioLabel);
            this.Controls.Add(this.ControlAlmacenCheckBox);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.IdNumericUpDown);
            this.Controls.Add(this.RDLabel);
            this.Controls.Add(this.PrecioLabel);
            this.Controls.Add(this.CategoriaLabel);
            this.Controls.Add(this.DescripcionLabel);
            this.Controls.Add(this.ProductoIdLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "rProductos";
            this.Text = "Registro de Productos";
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label RDLabel;
        private System.Windows.Forms.Label PrecioLabel;
        private System.Windows.Forms.Label CategoriaLabel;
        private System.Windows.Forms.Label DescripcionLabel;
        private System.Windows.Forms.Label ProductoIdLabel;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.NumericUpDown IdNumericUpDown;
        private System.Windows.Forms.CheckBox ControlAlmacenCheckBox;
        private System.Windows.Forms.Label InventarioLabel;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Label ControlAlmacenLabel;
        private System.Windows.Forms.ComboBox CategoriaComboBox;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.DateTimePicker FechaDeRegistroDateTimePicker;
        private System.Windows.Forms.Label FechaDeRegistroLabel;
        private System.Windows.Forms.NumericUpDown CantidadNumericUpDown;
        private System.Windows.Forms.NumericUpDown PrecioNumericUpDown;
    }
}