namespace InventoryAssistant.UI.Registros
{
    partial class rEntradaProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rEntradaProductos));
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CantidadNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ProductoLabel = new System.Windows.Forms.Label();
            this.CantidadLabel = new System.Windows.Forms.Label();
            this.FechaLabel = new System.Windows.Forms.Label();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.EntradaIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.EntradaIdLabel = new System.Windows.Forms.Label();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ProductoTextBox = new System.Windows.Forms.TextBox();
            this.VerProductosButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.UsuarioToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.EstadoToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntradaIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EliminarButton
            // 
            this.EliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(342, 215);
            this.EliminarButton.Margin = new System.Windows.Forms.Padding(4);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(100, 35);
            this.EliminarButton.TabIndex = 53;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.Location = new System.Drawing.Point(191, 215);
            this.GuardarButton.Margin = new System.Windows.Forms.Padding(4);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(100, 35);
            this.GuardarButton.TabIndex = 54;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimpiarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LimpiarButton.Location = new System.Drawing.Point(38, 215);
            this.LimpiarButton.Margin = new System.Windows.Forms.Padding(4);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(100, 35);
            this.LimpiarButton.TabIndex = 55;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LimpiarButton.UseVisualStyleBackColor = true;
            this.LimpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(200, 153);
            this.FechaDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(113, 22);
            this.FechaDateTimePicker.TabIndex = 52;
            this.FechaDateTimePicker.Value = new System.DateTime(2020, 3, 6, 0, 0, 0, 0);
            // 
            // CantidadNumericUpDown
            // 
            this.CantidadNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadNumericUpDown.Location = new System.Drawing.Point(200, 113);
            this.CantidadNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.CantidadNumericUpDown.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.CantidadNumericUpDown.Name = "CantidadNumericUpDown";
            this.CantidadNumericUpDown.Size = new System.Drawing.Size(113, 22);
            this.CantidadNumericUpDown.TabIndex = 51;
            // 
            // ProductoLabel
            // 
            this.ProductoLabel.AutoSize = true;
            this.ProductoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductoLabel.Location = new System.Drawing.Point(35, 75);
            this.ProductoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProductoLabel.Name = "ProductoLabel";
            this.ProductoLabel.Size = new System.Drawing.Size(74, 16);
            this.ProductoLabel.TabIndex = 49;
            this.ProductoLabel.Text = "Producto:";
            // 
            // CantidadLabel
            // 
            this.CantidadLabel.AutoSize = true;
            this.CantidadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadLabel.Location = new System.Drawing.Point(35, 115);
            this.CantidadLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CantidadLabel.Name = "CantidadLabel";
            this.CantidadLabel.Size = new System.Drawing.Size(74, 16);
            this.CantidadLabel.TabIndex = 48;
            this.CantidadLabel.Text = "Cantidad:";
            // 
            // FechaLabel
            // 
            this.FechaLabel.AutoSize = true;
            this.FechaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaLabel.Location = new System.Drawing.Point(35, 155);
            this.FechaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FechaLabel.Name = "FechaLabel";
            this.FechaLabel.Size = new System.Drawing.Size(55, 16);
            this.FechaLabel.TabIndex = 47;
            this.FechaLabel.Text = "Fecha:";
            // 
            // BuscarButton
            // 
            this.BuscarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(342, 21);
            this.BuscarButton.Margin = new System.Windows.Forms.Padding(4);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(100, 35);
            this.BuscarButton.TabIndex = 46;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // EntradaIdNumericUpDown
            // 
            this.EntradaIdNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntradaIdNumericUpDown.Location = new System.Drawing.Point(200, 28);
            this.EntradaIdNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.EntradaIdNumericUpDown.Name = "EntradaIdNumericUpDown";
            this.EntradaIdNumericUpDown.Size = new System.Drawing.Size(113, 22);
            this.EntradaIdNumericUpDown.TabIndex = 45;
            // 
            // EntradaIdLabel
            // 
            this.EntradaIdLabel.AutoSize = true;
            this.EntradaIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntradaIdLabel.Location = new System.Drawing.Point(35, 30);
            this.EntradaIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EntradaIdLabel.Name = "EntradaIdLabel";
            this.EntradaIdLabel.Size = new System.Drawing.Size(158, 16);
            this.EntradaIdLabel.TabIndex = 44;
            this.EntradaIdLabel.Text = "Código de la entrada:";
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // ProductoTextBox
            // 
            this.ProductoTextBox.BackColor = System.Drawing.Color.White;
            this.ProductoTextBox.Enabled = false;
            this.ProductoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductoTextBox.Location = new System.Drawing.Point(200, 73);
            this.ProductoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ProductoTextBox.Name = "ProductoTextBox";
            this.ProductoTextBox.Size = new System.Drawing.Size(190, 22);
            this.ProductoTextBox.TabIndex = 56;
            // 
            // VerProductosButton
            // 
            this.VerProductosButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerProductosButton.Location = new System.Drawing.Point(410, 69);
            this.VerProductosButton.Name = "VerProductosButton";
            this.VerProductosButton.Size = new System.Drawing.Size(30, 30);
            this.VerProductosButton.TabIndex = 118;
            this.VerProductosButton.UseVisualStyleBackColor = true;
            this.VerProductosButton.Click += new System.EventHandler(this.VerProductosButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UsuarioToolStripStatusLabel,
            this.EstadoToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 264);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(469, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 119;
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
            // rEntradaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 286);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.VerProductosButton);
            this.Controls.Add(this.ProductoTextBox);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.LimpiarButton);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(this.CantidadNumericUpDown);
            this.Controls.Add(this.ProductoLabel);
            this.Controls.Add(this.CantidadLabel);
            this.Controls.Add(this.FechaLabel);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.EntradaIdNumericUpDown);
            this.Controls.Add(this.EntradaIdLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "rEntradaProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Entrada de Productos";
            this.Load += new System.EventHandler(this.rEntradaProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CantidadNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntradaIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.NumericUpDown CantidadNumericUpDown;
        private System.Windows.Forms.Label ProductoLabel;
        private System.Windows.Forms.Label CantidadLabel;
        private System.Windows.Forms.Label FechaLabel;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.NumericUpDown EntradaIdNumericUpDown;
        private System.Windows.Forms.Label EntradaIdLabel;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.TextBox ProductoTextBox;
        private System.Windows.Forms.Button VerProductosButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel UsuarioToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel EstadoToolStripStatusLabel;
    }
}