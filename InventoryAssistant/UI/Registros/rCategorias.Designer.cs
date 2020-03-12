namespace InventoryAssistant.UI.Registros
{
    partial class rCategorias
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
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.CategoriaIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.CategoriaIdLabel = new System.Windows.Forms.Label();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CategoriaIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // EliminarButton
            // 
            this.EliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.Location = new System.Drawing.Point(342, 130);
            this.EliminarButton.Margin = new System.Windows.Forms.Padding(4);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(100, 35);
            this.EliminarButton.TabIndex = 38;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Location = new System.Drawing.Point(186, 130);
            this.GuardarButton.Margin = new System.Windows.Forms.Padding(4);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(100, 35);
            this.GuardarButton.TabIndex = 39;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimpiarButton.Location = new System.Drawing.Point(38, 130);
            this.LimpiarButton.Margin = new System.Windows.Forms.Padding(4);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(100, 35);
            this.LimpiarButton.TabIndex = 40;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LimpiarButton.UseVisualStyleBackColor = true;
            this.LimpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
            // 
            // BuscarButton
            // 
            this.BuscarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarButton.Location = new System.Drawing.Point(342, 21);
            this.BuscarButton.Margin = new System.Windows.Forms.Padding(4);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(100, 35);
            this.BuscarButton.TabIndex = 37;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreTextBox.Location = new System.Drawing.Point(224, 72);
            this.NombreTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(218, 22);
            this.NombreTextBox.TabIndex = 36;
            this.NombreTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombreTextBox_KeyPress);
            // 
            // CategoriaIdNumericUpDown
            // 
            this.CategoriaIdNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriaIdNumericUpDown.Location = new System.Drawing.Point(224, 28);
            this.CategoriaIdNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.CategoriaIdNumericUpDown.Name = "CategoriaIdNumericUpDown";
            this.CategoriaIdNumericUpDown.Size = new System.Drawing.Size(77, 22);
            this.CategoriaIdNumericUpDown.TabIndex = 35;
            this.CategoriaIdNumericUpDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CategoriaIdNumericUpDown_KeyPress);
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreLabel.Location = new System.Drawing.Point(35, 75);
            this.NombreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(178, 16);
            this.NombreLabel.TabIndex = 34;
            this.NombreLabel.Text = "Nombre de la Categoría:";
            // 
            // CategoriaIdLabel
            // 
            this.CategoriaIdLabel.AutoSize = true;
            this.CategoriaIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriaIdLabel.Location = new System.Drawing.Point(35, 30);
            this.CategoriaIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CategoriaIdLabel.Name = "CategoriaIdLabel";
            this.CategoriaIdLabel.Size = new System.Drawing.Size(173, 16);
            this.CategoriaIdLabel.TabIndex = 33;
            this.CategoriaIdLabel.Text = "Código de la Categoría:";
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // rCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 190);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.LimpiarButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.CategoriaIdNumericUpDown);
            this.Controls.Add(this.NombreLabel);
            this.Controls.Add(this.CategoriaIdLabel);
            this.Name = "rCategorias";
            this.Text = "Registro de Categorias";
            ((System.ComponentModel.ISupportInitialize)(this.CategoriaIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.NumericUpDown CategoriaIdNumericUpDown;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.Label CategoriaIdLabel;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}