namespace InventoryAssistant.UI.Consultas
{
    partial class ConsultaEntradaProductos
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cEntradasdataGridView = new System.Windows.Forms.DataGridView();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CristerioTextBox = new System.Windows.Forms.TextBox();
            this.RealizarBusquedaButton = new System.Windows.Forms.Button();
            this.DatosDelUsuarioGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cEntradasdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cEntradasdataGridView);
            this.groupBox2.Location = new System.Drawing.Point(202, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(592, 426);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            // 
            // cEntradasdataGridView
            // 
            this.cEntradasdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cEntradasdataGridView.Location = new System.Drawing.Point(0, 19);
            this.cEntradasdataGridView.Name = "cEntradasdataGridView";
            this.cEntradasdataGridView.Size = new System.Drawing.Size(586, 401);
            this.cEntradasdataGridView.TabIndex = 0;
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RealizarBusquedaButton);
            this.groupBox1.Controls.Add(this.CristerioTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.FiltroComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 202);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtrar por";
            // 
            // FiltroComboBox
            // 
            this.FiltroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltroComboBox.FormattingEnabled = true;
            this.FiltroComboBox.Items.AddRange(new object[] {
            "Todo",
            "Entrada Id",
            "Producto Id"});
            this.FiltroComboBox.Location = new System.Drawing.Point(9, 63);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(155, 24);
            this.FiltroComboBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Criterio";
            // 
            // CristerioTextBox
            // 
            this.CristerioTextBox.Location = new System.Drawing.Point(9, 127);
            this.CristerioTextBox.Name = "CristerioTextBox";
            this.CristerioTextBox.Size = new System.Drawing.Size(155, 22);
            this.CristerioTextBox.TabIndex = 3;
            // 
            // RealizarBusquedaButton
            // 
            this.RealizarBusquedaButton.Location = new System.Drawing.Point(12, 169);
            this.RealizarBusquedaButton.Name = "RealizarBusquedaButton";
            this.RealizarBusquedaButton.Size = new System.Drawing.Size(153, 23);
            this.RealizarBusquedaButton.TabIndex = 4;
            this.RealizarBusquedaButton.Text = "Realizar Busqueda";
            this.RealizarBusquedaButton.UseVisualStyleBackColor = true;
            this.RealizarBusquedaButton.Click += new System.EventHandler(this.RealizarBusquedaButton_Click);
            // 
            // DatosDelUsuarioGroupBox
            // 
            this.DatosDelUsuarioGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatosDelUsuarioGroupBox.Location = new System.Drawing.Point(6, 2);
            this.DatosDelUsuarioGroupBox.Name = "DatosDelUsuarioGroupBox";
            this.DatosDelUsuarioGroupBox.Size = new System.Drawing.Size(190, 446);
            this.DatosDelUsuarioGroupBox.TabIndex = 27;
            this.DatosDelUsuarioGroupBox.TabStop = false;
            this.DatosDelUsuarioGroupBox.Text = "Entrada Productos";
            // 
            // ConsultaEntradaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DatosDelUsuarioGroupBox);
            this.Name = "ConsultaEntradaProductos";
            this.Text = "ConsultaEntradaProductos";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cEntradasdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView cEntradasdataGridView;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button RealizarBusquedaButton;
        private System.Windows.Forms.TextBox CristerioTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox DatosDelUsuarioGroupBox;
    }
}