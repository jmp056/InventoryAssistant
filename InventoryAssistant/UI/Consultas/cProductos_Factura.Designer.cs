namespace InventoryAssistant.UI.Consultas
{
    partial class cProductos_Factura
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
            this.BusquedaGroupBox = new System.Windows.Forms.GroupBox();
            this.RealizarBusquedaButton = new System.Windows.Forms.Button();
            this.CriterioTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AnadirProductoButton = new System.Windows.Forms.Button();
            this.ProductosDataGridView = new System.Windows.Forms.DataGridView();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.BusquedaGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // BusquedaGroupBox
            // 
            this.BusquedaGroupBox.Controls.Add(this.RealizarBusquedaButton);
            this.BusquedaGroupBox.Controls.Add(this.CriterioTextBox);
            this.BusquedaGroupBox.Controls.Add(this.label2);
            this.BusquedaGroupBox.Controls.Add(this.FiltroComboBox);
            this.BusquedaGroupBox.Controls.Add(this.label1);
            this.BusquedaGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusquedaGroupBox.Location = new System.Drawing.Point(7, 2);
            this.BusquedaGroupBox.Name = "BusquedaGroupBox";
            this.BusquedaGroupBox.Size = new System.Drawing.Size(619, 53);
            this.BusquedaGroupBox.TabIndex = 24;
            this.BusquedaGroupBox.TabStop = false;
            // 
            // RealizarBusquedaButton
            // 
            this.RealizarBusquedaButton.Location = new System.Drawing.Point(507, 19);
            this.RealizarBusquedaButton.Name = "RealizarBusquedaButton";
            this.RealizarBusquedaButton.Size = new System.Drawing.Size(81, 23);
            this.RealizarBusquedaButton.TabIndex = 4;
            this.RealizarBusquedaButton.Text = "Buscar";
            this.RealizarBusquedaButton.UseVisualStyleBackColor = true;
            this.RealizarBusquedaButton.Click += new System.EventHandler(this.RealizarBusquedaButton_Click);
            // 
            // CriterioTextBox
            // 
            this.CriterioTextBox.Location = new System.Drawing.Point(330, 18);
            this.CriterioTextBox.Name = "CriterioTextBox";
            this.CriterioTextBox.Size = new System.Drawing.Size(155, 22);
            this.CriterioTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Criterio:";
            // 
            // FiltroComboBox
            // 
            this.FiltroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltroComboBox.FormattingEnabled = true;
            this.FiltroComboBox.Items.AddRange(new object[] {
            "Todo",
            "Codigo",
            "Descripcion"});
            this.FiltroComboBox.Location = new System.Drawing.Point(95, 18);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(155, 24);
            this.FiltroComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtrar por:";
            // 
            // AnadirProductoButton
            // 
            this.AnadirProductoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnadirProductoButton.Location = new System.Drawing.Point(644, 15);
            this.AnadirProductoButton.Name = "AnadirProductoButton";
            this.AnadirProductoButton.Size = new System.Drawing.Size(81, 34);
            this.AnadirProductoButton.TabIndex = 25;
            this.AnadirProductoButton.Text = "Añadir";
            this.AnadirProductoButton.UseVisualStyleBackColor = true;
            this.AnadirProductoButton.Click += new System.EventHandler(this.AnadirProductoButton_Click);
            // 
            // ProductosDataGridView
            // 
            this.ProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductosDataGridView.Location = new System.Drawing.Point(8, 61);
            this.ProductosDataGridView.Name = "ProductosDataGridView";
            this.ProductosDataGridView.ReadOnly = true;
            this.ProductosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductosDataGridView.Size = new System.Drawing.Size(718, 377);
            this.ProductosDataGridView.TabIndex = 26;
            this.ProductosDataGridView.Click += new System.EventHandler(this.ProductosDataGridView_Click);
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // cProductos_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 450);
            this.Controls.Add(this.ProductosDataGridView);
            this.Controls.Add(this.AnadirProductoButton);
            this.Controls.Add(this.BusquedaGroupBox);
            this.Name = "cProductos_Factura";
            this.Text = "CProductos_Factura";
            this.Load += new System.EventHandler(this.CProductos_Factura_Load);
            this.BusquedaGroupBox.ResumeLayout(false);
            this.BusquedaGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox BusquedaGroupBox;
        private System.Windows.Forms.Button RealizarBusquedaButton;
        private System.Windows.Forms.TextBox CriterioTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AnadirProductoButton;
        private System.Windows.Forms.DataGridView ProductosDataGridView;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}