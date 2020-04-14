namespace InventoryAssistant.UI.Otras
{
    partial class Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            this.MontoRecibidoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MontoRetornoLabel = new System.Windows.Forms.Label();
            this.MontoRecibidoLabel = new System.Windows.Forms.Label();
            this.MontoFacturaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MontoFacturaLabel = new System.Windows.Forms.Label();
            this.RetornoTextBox = new System.Windows.Forms.TextBox();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.CalcularButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MontoRecibidoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MontoFacturaNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // MontoRecibidoNumericUpDown
            // 
            this.MontoRecibidoNumericUpDown.BackColor = System.Drawing.Color.White;
            this.MontoRecibidoNumericUpDown.DecimalPlaces = 2;
            this.MontoRecibidoNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.MontoRecibidoNumericUpDown.Location = new System.Drawing.Point(180, 68);
            this.MontoRecibidoNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.MontoRecibidoNumericUpDown.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.MontoRecibidoNumericUpDown.Name = "MontoRecibidoNumericUpDown";
            this.MontoRecibidoNumericUpDown.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MontoRecibidoNumericUpDown.Size = new System.Drawing.Size(113, 22);
            this.MontoRecibidoNumericUpDown.TabIndex = 20;
            this.MontoRecibidoNumericUpDown.ValueChanged += new System.EventHandler(this.MontoRecibidoNumericUpDown_ValueChanged);
            this.MontoRecibidoNumericUpDown.Enter += new System.EventHandler(this.MontoRecibidoNumericUpDown_Enter);
            this.MontoRecibidoNumericUpDown.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MontoRecibidoNumericUpDown_KeyUp);
            // 
            // MontoRetornoLabel
            // 
            this.MontoRetornoLabel.AutoSize = true;
            this.MontoRetornoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.MontoRetornoLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MontoRetornoLabel.Location = new System.Drawing.Point(25, 115);
            this.MontoRetornoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MontoRetornoLabel.Name = "MontoRetornoLabel";
            this.MontoRetornoLabel.Size = new System.Drawing.Size(125, 16);
            this.MontoRetornoLabel.TabIndex = 125;
            this.MontoRetornoLabel.Text = "Monto a retornar:";
            // 
            // MontoRecibidoLabel
            // 
            this.MontoRecibidoLabel.AutoSize = true;
            this.MontoRecibidoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.MontoRecibidoLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MontoRecibidoLabel.Location = new System.Drawing.Point(25, 70);
            this.MontoRecibidoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MontoRecibidoLabel.Name = "MontoRecibidoLabel";
            this.MontoRecibidoLabel.Size = new System.Drawing.Size(115, 16);
            this.MontoRecibidoLabel.TabIndex = 124;
            this.MontoRecibidoLabel.Text = "Monto recibido:";
            // 
            // MontoFacturaNumericUpDown
            // 
            this.MontoFacturaNumericUpDown.BackColor = System.Drawing.Color.White;
            this.MontoFacturaNumericUpDown.DecimalPlaces = 2;
            this.MontoFacturaNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.MontoFacturaNumericUpDown.Location = new System.Drawing.Point(180, 23);
            this.MontoFacturaNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.MontoFacturaNumericUpDown.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.MontoFacturaNumericUpDown.Name = "MontoFacturaNumericUpDown";
            this.MontoFacturaNumericUpDown.Size = new System.Drawing.Size(113, 22);
            this.MontoFacturaNumericUpDown.TabIndex = 10;
            this.MontoFacturaNumericUpDown.ValueChanged += new System.EventHandler(this.MontoFacturaNumericUpDown_ValueChanged);
            this.MontoFacturaNumericUpDown.Enter += new System.EventHandler(this.MontoFacturaNumericUpDown_Enter);
            this.MontoFacturaNumericUpDown.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MontoFacturaNumericUpDown_KeyUp);
            // 
            // MontoFacturaLabel
            // 
            this.MontoFacturaLabel.AutoSize = true;
            this.MontoFacturaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.MontoFacturaLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MontoFacturaLabel.Location = new System.Drawing.Point(25, 25);
            this.MontoFacturaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MontoFacturaLabel.Name = "MontoFacturaLabel";
            this.MontoFacturaLabel.Size = new System.Drawing.Size(149, 16);
            this.MontoFacturaLabel.TabIndex = 122;
            this.MontoFacturaLabel.Text = "Monto de la Factura:";
            // 
            // RetornoTextBox
            // 
            this.RetornoTextBox.BackColor = System.Drawing.Color.White;
            this.RetornoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetornoTextBox.Location = new System.Drawing.Point(180, 113);
            this.RetornoTextBox.Name = "RetornoTextBox";
            this.RetornoTextBox.ReadOnly = true;
            this.RetornoTextBox.Size = new System.Drawing.Size(113, 22);
            this.RetornoTextBox.TabIndex = 50;
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.LimpiarButton.Image = global::InventoryAssistant.Properties.Resources.LimpiarButtonImg;
            this.LimpiarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LimpiarButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LimpiarButton.Location = new System.Drawing.Point(40, 159);
            this.LimpiarButton.Margin = new System.Windows.Forms.Padding(4);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(100, 35);
            this.LimpiarButton.TabIndex = 40;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LimpiarButton.UseVisualStyleBackColor = true;
            this.LimpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
            // 
            // CalcularButton
            // 
            this.CalcularButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.CalcularButton.Image = global::InventoryAssistant.Properties.Resources.CalcularButtonImg;
            this.CalcularButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CalcularButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CalcularButton.Location = new System.Drawing.Point(180, 159);
            this.CalcularButton.Margin = new System.Windows.Forms.Padding(4);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(100, 35);
            this.CalcularButton.TabIndex = 30;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 214);
            this.Controls.Add(this.RetornoTextBox);
            this.Controls.Add(this.LimpiarButton);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.MontoRecibidoNumericUpDown);
            this.Controls.Add(this.MontoRetornoLabel);
            this.Controls.Add(this.MontoRecibidoLabel);
            this.Controls.Add(this.MontoFacturaNumericUpDown);
            this.Controls.Add(this.MontoFacturaLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Calculadora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MontoRecibidoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MontoFacturaNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.NumericUpDown MontoRecibidoNumericUpDown;
        private System.Windows.Forms.Label MontoRetornoLabel;
        private System.Windows.Forms.Label MontoRecibidoLabel;
        private System.Windows.Forms.NumericUpDown MontoFacturaNumericUpDown;
        private System.Windows.Forms.Label MontoFacturaLabel;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.TextBox RetornoTextBox;
    }
}