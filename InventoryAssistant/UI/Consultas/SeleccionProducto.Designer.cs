﻿namespace InventoryAssistant.UI.Consultas
{
    partial class SeleccionProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeleccionProducto));
            this.BusquedaGroupBox = new System.Windows.Forms.GroupBox();
            this.HastaLabel = new System.Windows.Forms.Label();
            this.RealizarBusquedaButton = new System.Windows.Forms.Button();
            this.HastaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DesdeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CriterioLabel = new System.Windows.Forms.Label();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.FiltrarPorLabel = new System.Windows.Forms.Label();
            this.CriterioTextBox = new System.Windows.Forms.TextBox();
            this.ProductosDataGridView = new System.Windows.Forms.DataGridView();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.SeleccionarProductoButton = new System.Windows.Forms.Button();
            this.BusquedaGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HastaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DesdeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // BusquedaGroupBox
            // 
            this.BusquedaGroupBox.Controls.Add(this.HastaLabel);
            this.BusquedaGroupBox.Controls.Add(this.RealizarBusquedaButton);
            this.BusquedaGroupBox.Controls.Add(this.HastaNumericUpDown);
            this.BusquedaGroupBox.Controls.Add(this.DesdeNumericUpDown);
            this.BusquedaGroupBox.Controls.Add(this.CriterioLabel);
            this.BusquedaGroupBox.Controls.Add(this.FiltroComboBox);
            this.BusquedaGroupBox.Controls.Add(this.FiltrarPorLabel);
            this.BusquedaGroupBox.Controls.Add(this.CriterioTextBox);
            this.BusquedaGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusquedaGroupBox.Location = new System.Drawing.Point(7, 2);
            this.BusquedaGroupBox.Name = "BusquedaGroupBox";
            this.BusquedaGroupBox.Size = new System.Drawing.Size(618, 53);
            this.BusquedaGroupBox.TabIndex = 24;
            this.BusquedaGroupBox.TabStop = false;
            // 
            // HastaLabel
            // 
            this.HastaLabel.AutoSize = true;
            this.HastaLabel.Location = new System.Drawing.Point(368, 21);
            this.HastaLabel.Name = "HastaLabel";
            this.HastaLabel.Size = new System.Drawing.Size(49, 16);
            this.HastaLabel.TabIndex = 29;
            this.HastaLabel.Text = "Hasta";
            // 
            // RealizarBusquedaButton
            // 
            this.RealizarBusquedaButton.Image = global::InventoryAssistant.Properties.Resources.BuscarButtonImg;
            this.RealizarBusquedaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RealizarBusquedaButton.Location = new System.Drawing.Point(508, 11);
            this.RealizarBusquedaButton.Name = "RealizarBusquedaButton";
            this.RealizarBusquedaButton.Size = new System.Drawing.Size(100, 35);
            this.RealizarBusquedaButton.TabIndex = 4;
            this.RealizarBusquedaButton.Text = "Buscar";
            this.RealizarBusquedaButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RealizarBusquedaButton.UseVisualStyleBackColor = true;
            this.RealizarBusquedaButton.Click += new System.EventHandler(this.RealizarBusquedaButton_Click);
            // 
            // HastaNumericUpDown
            // 
            this.HastaNumericUpDown.DecimalPlaces = 2;
            this.HastaNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.HastaNumericUpDown.Location = new System.Drawing.Point(422, 18);
            this.HastaNumericUpDown.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.HastaNumericUpDown.Name = "HastaNumericUpDown";
            this.HastaNumericUpDown.Size = new System.Drawing.Size(80, 22);
            this.HastaNumericUpDown.TabIndex = 28;
            // 
            // DesdeNumericUpDown
            // 
            this.DesdeNumericUpDown.DecimalPlaces = 2;
            this.DesdeNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.DesdeNumericUpDown.Location = new System.Drawing.Point(272, 18);
            this.DesdeNumericUpDown.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.DesdeNumericUpDown.Name = "DesdeNumericUpDown";
            this.DesdeNumericUpDown.Size = new System.Drawing.Size(80, 22);
            this.DesdeNumericUpDown.TabIndex = 27;
            // 
            // CriterioLabel
            // 
            this.CriterioLabel.AutoSize = true;
            this.CriterioLabel.Location = new System.Drawing.Point(219, 20);
            this.CriterioLabel.Name = "CriterioLabel";
            this.CriterioLabel.Size = new System.Drawing.Size(62, 16);
            this.CriterioLabel.TabIndex = 2;
            this.CriterioLabel.Text = "Criterio:";
            // 
            // FiltroComboBox
            // 
            this.FiltroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltroComboBox.FormattingEnabled = true;
            this.FiltroComboBox.Items.AddRange(new object[] {
            "Todo",
            "Codigo",
            "Descripcion",
            "Categoria",
            "Cantidad",
            "Precio"});
            this.FiltroComboBox.Location = new System.Drawing.Point(89, 18);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(127, 24);
            this.FiltroComboBox.TabIndex = 1;
            this.FiltroComboBox.SelectedIndexChanged += new System.EventHandler(this.FiltroComboBox_SelectedIndexChanged);
            // 
            // FiltrarPorLabel
            // 
            this.FiltrarPorLabel.AutoSize = true;
            this.FiltrarPorLabel.Location = new System.Drawing.Point(4, 20);
            this.FiltrarPorLabel.Name = "FiltrarPorLabel";
            this.FiltrarPorLabel.Size = new System.Drawing.Size(79, 16);
            this.FiltrarPorLabel.TabIndex = 0;
            this.FiltrarPorLabel.Text = "Filtrar por:";
            // 
            // CriterioTextBox
            // 
            this.CriterioTextBox.Location = new System.Drawing.Point(281, 18);
            this.CriterioTextBox.Name = "CriterioTextBox";
            this.CriterioTextBox.Size = new System.Drawing.Size(202, 22);
            this.CriterioTextBox.TabIndex = 3;
            // 
            // ProductosDataGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductosDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProductosDataGridView.Location = new System.Drawing.Point(8, 61);
            this.ProductosDataGridView.Name = "ProductosDataGridView";
            this.ProductosDataGridView.ReadOnly = true;
            this.ProductosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductosDataGridView.Size = new System.Drawing.Size(748, 377);
            this.ProductosDataGridView.TabIndex = 26;
            this.ProductosDataGridView.Click += new System.EventHandler(this.ProductosDataGridView_Click);
            this.ProductosDataGridView.DoubleClick += new System.EventHandler(this.ProductosDataGridView_DoubleClick);
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // SeleccionarProductoButton
            // 
            this.SeleccionarProductoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeleccionarProductoButton.Image = global::InventoryAssistant.Properties.Resources.SeleccionarButtonImg;
            this.SeleccionarProductoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SeleccionarProductoButton.Location = new System.Drawing.Point(631, 14);
            this.SeleccionarProductoButton.Name = "SeleccionarProductoButton";
            this.SeleccionarProductoButton.Size = new System.Drawing.Size(125, 35);
            this.SeleccionarProductoButton.TabIndex = 25;
            this.SeleccionarProductoButton.Text = "Seleccionar";
            this.SeleccionarProductoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SeleccionarProductoButton.UseVisualStyleBackColor = true;
            this.SeleccionarProductoButton.Click += new System.EventHandler(this.AnadirProductoButton_Click);
            // 
            // SeleccionProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 450);
            this.Controls.Add(this.ProductosDataGridView);
            this.Controls.Add(this.SeleccionarProductoButton);
            this.Controls.Add(this.BusquedaGroupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SeleccionProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Seleccion de Producto";
            this.Load += new System.EventHandler(this.CProductos_Factura_Load);
            this.BusquedaGroupBox.ResumeLayout(false);
            this.BusquedaGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HastaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DesdeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox BusquedaGroupBox;
        private System.Windows.Forms.Button RealizarBusquedaButton;
        private System.Windows.Forms.TextBox CriterioTextBox;
        private System.Windows.Forms.Label CriterioLabel;
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.Label FiltrarPorLabel;
        private System.Windows.Forms.Button SeleccionarProductoButton;
        private System.Windows.Forms.DataGridView ProductosDataGridView;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.Label HastaLabel;
        private System.Windows.Forms.NumericUpDown HastaNumericUpDown;
        private System.Windows.Forms.NumericUpDown DesdeNumericUpDown;
    }
}