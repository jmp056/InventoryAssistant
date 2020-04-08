namespace InventoryAssistant.UI.Registros
{
    partial class rUsuarios
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
            this.UsuarioIdLabel = new System.Windows.Forms.Label();
            this.CedulaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.NombresTextBox = new System.Windows.Forms.TextBox();
            this.UsuarioIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NombresLabel = new System.Windows.Forms.Label();
            this.ApellidosLabel = new System.Windows.Forms.Label();
            this.TelefonoLabel = new System.Windows.Forms.Label();
            this.FechaDeRegistroLabel = new System.Windows.Forms.Label();
            this.FechaDeRegistroDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.ContrasenaTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmarContrasenaTextBox = new System.Windows.Forms.TextBox();
            this.NivelDeUsuarioComboBox = new System.Windows.Forms.ComboBox();
            this.ApellidosTextBox = new System.Windows.Forms.TextBox();
            this.CedulaLabel = new System.Windows.Forms.Label();
            this.UsuarioLabel = new System.Windows.Forms.Label();
            this.NivelDeUsuarioLabel = new System.Windows.Forms.Label();
            this.ContrasenaLabel = new System.Windows.Forms.Label();
            this.ConfirmarContrasenaLabel = new System.Windows.Forms.Label();
            this.DatosDelUsuarioGroupBox = new System.Windows.Forms.GroupBox();
            this.TelefonoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.UsuarioToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.EstadoToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioIdNumericUpDown)).BeginInit();
            this.DatosDelUsuarioGroupBox.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UsuarioIdLabel
            // 
            this.UsuarioIdLabel.AutoSize = true;
            this.UsuarioIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioIdLabel.Location = new System.Drawing.Point(35, 30);
            this.UsuarioIdLabel.Name = "UsuarioIdLabel";
            this.UsuarioIdLabel.Size = new System.Drawing.Size(146, 16);
            this.UsuarioIdLabel.TabIndex = 0;
            this.UsuarioIdLabel.Text = "Código del Usuario:";
            // 
            // CedulaMaskedTextBox
            // 
            this.CedulaMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CedulaMaskedTextBox.Location = new System.Drawing.Point(190, 146);
            this.CedulaMaskedTextBox.Mask = "999-9999999-9";
            this.CedulaMaskedTextBox.Name = "CedulaMaskedTextBox";
            this.CedulaMaskedTextBox.Size = new System.Drawing.Size(100, 22);
            this.CedulaMaskedTextBox.TabIndex = 50;
            this.CedulaMaskedTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CedulaMaskedTextBox_KeyDown);
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // NombresTextBox
            // 
            this.NombresTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombresTextBox.Location = new System.Drawing.Point(190, 67);
            this.NombresTextBox.Name = "NombresTextBox";
            this.NombresTextBox.Size = new System.Drawing.Size(200, 22);
            this.NombresTextBox.TabIndex = 30;
            this.NombresTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NombresTextBox_KeyDown);
            // 
            // UsuarioIdNumericUpDown
            // 
            this.UsuarioIdNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioIdNumericUpDown.Location = new System.Drawing.Point(190, 28);
            this.UsuarioIdNumericUpDown.Name = "UsuarioIdNumericUpDown";
            this.UsuarioIdNumericUpDown.Size = new System.Drawing.Size(85, 22);
            this.UsuarioIdNumericUpDown.TabIndex = 10;
            this.UsuarioIdNumericUpDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UsuarioIdNumericUpDown_KeyDown);
            // 
            // NombresLabel
            // 
            this.NombresLabel.AutoSize = true;
            this.NombresLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombresLabel.Location = new System.Drawing.Point(35, 70);
            this.NombresLabel.Name = "NombresLabel";
            this.NombresLabel.Size = new System.Drawing.Size(75, 16);
            this.NombresLabel.TabIndex = 2;
            this.NombresLabel.Text = "Nombres:";
            // 
            // ApellidosLabel
            // 
            this.ApellidosLabel.AutoSize = true;
            this.ApellidosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApellidosLabel.Location = new System.Drawing.Point(35, 110);
            this.ApellidosLabel.Name = "ApellidosLabel";
            this.ApellidosLabel.Size = new System.Drawing.Size(78, 16);
            this.ApellidosLabel.TabIndex = 1;
            this.ApellidosLabel.Text = "Apellidos:";
            // 
            // TelefonoLabel
            // 
            this.TelefonoLabel.AutoSize = true;
            this.TelefonoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelefonoLabel.Location = new System.Drawing.Point(35, 190);
            this.TelefonoLabel.Name = "TelefonoLabel";
            this.TelefonoLabel.Size = new System.Drawing.Size(74, 16);
            this.TelefonoLabel.TabIndex = 4;
            this.TelefonoLabel.Text = "Teléfono:";
            // 
            // FechaDeRegistroLabel
            // 
            this.FechaDeRegistroLabel.AutoSize = true;
            this.FechaDeRegistroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaDeRegistroLabel.Location = new System.Drawing.Point(35, 230);
            this.FechaDeRegistroLabel.Name = "FechaDeRegistroLabel";
            this.FechaDeRegistroLabel.Size = new System.Drawing.Size(134, 16);
            this.FechaDeRegistroLabel.TabIndex = 70;
            this.FechaDeRegistroLabel.Text = "Fecha de registro:";
            // 
            // FechaDeRegistroDateTimePicker
            // 
            this.FechaDeRegistroDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaDeRegistroDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaDeRegistroDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaDeRegistroDateTimePicker.Location = new System.Drawing.Point(190, 228);
            this.FechaDeRegistroDateTimePicker.Name = "FechaDeRegistroDateTimePicker";
            this.FechaDeRegistroDateTimePicker.Size = new System.Drawing.Size(115, 22);
            this.FechaDeRegistroDateTimePicker.TabIndex = 70;
            this.FechaDeRegistroDateTimePicker.Value = new System.DateTime(2020, 3, 6, 0, 0, 0, 0);
            this.FechaDeRegistroDateTimePicker.CloseUp += new System.EventHandler(this.FechaDeRegistroDateTimePicker_CloseUp);
            this.FechaDeRegistroDateTimePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FechaDeRegistroDateTimePicker_KeyDown);
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioTextBox.Location = new System.Drawing.Point(15, 50);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.Size = new System.Drawing.Size(159, 22);
            this.UsuarioTextBox.TabIndex = 80;
            this.UsuarioTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UsuarioTextBox_KeyDown);
            // 
            // ContrasenaTextBox
            // 
            this.ContrasenaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContrasenaTextBox.Location = new System.Drawing.Point(15, 160);
            this.ContrasenaTextBox.Name = "ContrasenaTextBox";
            this.ContrasenaTextBox.Size = new System.Drawing.Size(159, 22);
            this.ContrasenaTextBox.TabIndex = 100;
            this.ContrasenaTextBox.UseSystemPasswordChar = true;
            this.ContrasenaTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ContrasenaTextBox_KeyDown);
            // 
            // ConfirmarContrasenaTextBox
            // 
            this.ConfirmarContrasenaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmarContrasenaTextBox.Location = new System.Drawing.Point(15, 215);
            this.ConfirmarContrasenaTextBox.Name = "ConfirmarContrasenaTextBox";
            this.ConfirmarContrasenaTextBox.Size = new System.Drawing.Size(156, 22);
            this.ConfirmarContrasenaTextBox.TabIndex = 110;
            this.ConfirmarContrasenaTextBox.UseSystemPasswordChar = true;
            this.ConfirmarContrasenaTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConfirmarContrasenaTextBox_KeyDown);
            // 
            // NivelDeUsuarioComboBox
            // 
            this.NivelDeUsuarioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NivelDeUsuarioComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NivelDeUsuarioComboBox.FormattingEnabled = true;
            this.NivelDeUsuarioComboBox.Items.AddRange(new object[] {
            "Administrador",
            "Supervisor",
            "Usuario"});
            this.NivelDeUsuarioComboBox.Location = new System.Drawing.Point(15, 105);
            this.NivelDeUsuarioComboBox.Name = "NivelDeUsuarioComboBox";
            this.NivelDeUsuarioComboBox.Size = new System.Drawing.Size(159, 24);
            this.NivelDeUsuarioComboBox.TabIndex = 90;
            this.NivelDeUsuarioComboBox.DropDownClosed += new System.EventHandler(this.NivelDeUsuarioComboBox_DropDownClosed);
            this.NivelDeUsuarioComboBox.Enter += new System.EventHandler(this.NivelDeUsuarioComboBox_Enter);
            // 
            // ApellidosTextBox
            // 
            this.ApellidosTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApellidosTextBox.Location = new System.Drawing.Point(190, 107);
            this.ApellidosTextBox.Name = "ApellidosTextBox";
            this.ApellidosTextBox.Size = new System.Drawing.Size(200, 22);
            this.ApellidosTextBox.TabIndex = 40;
            this.ApellidosTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ApellidosTextBox_KeyDown);
            // 
            // CedulaLabel
            // 
            this.CedulaLabel.AutoSize = true;
            this.CedulaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CedulaLabel.Location = new System.Drawing.Point(35, 150);
            this.CedulaLabel.Name = "CedulaLabel";
            this.CedulaLabel.Size = new System.Drawing.Size(61, 16);
            this.CedulaLabel.TabIndex = 8;
            this.CedulaLabel.Text = "Cedula:";
            // 
            // UsuarioLabel
            // 
            this.UsuarioLabel.AutoSize = true;
            this.UsuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioLabel.Location = new System.Drawing.Point(15, 30);
            this.UsuarioLabel.Name = "UsuarioLabel";
            this.UsuarioLabel.Size = new System.Drawing.Size(66, 16);
            this.UsuarioLabel.TabIndex = 150;
            this.UsuarioLabel.Text = "Usuario:";
            // 
            // NivelDeUsuarioLabel
            // 
            this.NivelDeUsuarioLabel.AutoSize = true;
            this.NivelDeUsuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NivelDeUsuarioLabel.Location = new System.Drawing.Point(15, 85);
            this.NivelDeUsuarioLabel.Name = "NivelDeUsuarioLabel";
            this.NivelDeUsuarioLabel.Size = new System.Drawing.Size(125, 16);
            this.NivelDeUsuarioLabel.TabIndex = 9;
            this.NivelDeUsuarioLabel.Text = "Nivel de usuario:";
            // 
            // ContrasenaLabel
            // 
            this.ContrasenaLabel.AutoSize = true;
            this.ContrasenaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContrasenaLabel.Location = new System.Drawing.Point(15, 140);
            this.ContrasenaLabel.Name = "ContrasenaLabel";
            this.ContrasenaLabel.Size = new System.Drawing.Size(91, 16);
            this.ContrasenaLabel.TabIndex = 6;
            this.ContrasenaLabel.Text = "Contraseña:";
            // 
            // ConfirmarContrasenaLabel
            // 
            this.ConfirmarContrasenaLabel.AutoSize = true;
            this.ConfirmarContrasenaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmarContrasenaLabel.Location = new System.Drawing.Point(15, 195);
            this.ConfirmarContrasenaLabel.Name = "ConfirmarContrasenaLabel";
            this.ConfirmarContrasenaLabel.Size = new System.Drawing.Size(159, 16);
            this.ConfirmarContrasenaLabel.TabIndex = 7;
            this.ConfirmarContrasenaLabel.Text = "Confirmar contraseña:";
            // 
            // DatosDelUsuarioGroupBox
            // 
            this.DatosDelUsuarioGroupBox.Controls.Add(this.ConfirmarContrasenaTextBox);
            this.DatosDelUsuarioGroupBox.Controls.Add(this.ContrasenaTextBox);
            this.DatosDelUsuarioGroupBox.Controls.Add(this.UsuarioTextBox);
            this.DatosDelUsuarioGroupBox.Controls.Add(this.UsuarioLabel);
            this.DatosDelUsuarioGroupBox.Controls.Add(this.ConfirmarContrasenaLabel);
            this.DatosDelUsuarioGroupBox.Controls.Add(this.NivelDeUsuarioLabel);
            this.DatosDelUsuarioGroupBox.Controls.Add(this.ContrasenaLabel);
            this.DatosDelUsuarioGroupBox.Controls.Add(this.NivelDeUsuarioComboBox);
            this.DatosDelUsuarioGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatosDelUsuarioGroupBox.Location = new System.Drawing.Point(410, 12);
            this.DatosDelUsuarioGroupBox.Name = "DatosDelUsuarioGroupBox";
            this.DatosDelUsuarioGroupBox.Size = new System.Drawing.Size(205, 258);
            this.DatosDelUsuarioGroupBox.TabIndex = 20;
            this.DatosDelUsuarioGroupBox.TabStop = false;
            // 
            // TelefonoMaskedTextBox
            // 
            this.TelefonoMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelefonoMaskedTextBox.Location = new System.Drawing.Point(190, 183);
            this.TelefonoMaskedTextBox.Mask = "999-999-9999";
            this.TelefonoMaskedTextBox.Name = "TelefonoMaskedTextBox";
            this.TelefonoMaskedTextBox.Size = new System.Drawing.Size(100, 22);
            this.TelefonoMaskedTextBox.TabIndex = 60;
            this.TelefonoMaskedTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TelefonoMaskedTextBox_KeyDown);
            // 
            // BuscarButton
            // 
            this.BuscarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(292, 20);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(100, 35);
            this.BuscarButton.TabIndex = 20;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click_1);
            this.BuscarButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BuscarButton_KeyDown);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.Location = new System.Drawing.Point(254, 290);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(100, 35);
            this.GuardarButton.TabIndex = 120;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click_1);
            this.GuardarButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GuardarButton_KeyDown);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(481, 290);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(100, 35);
            this.EliminarButton.TabIndex = 140;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            this.EliminarButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EliminarButton_KeyDown);
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimpiarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LimpiarButton.Location = new System.Drawing.Point(45, 290);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(100, 35);
            this.LimpiarButton.TabIndex = 130;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LimpiarButton.UseVisualStyleBackColor = true;
            this.LimpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click_1);
            this.LimpiarButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LimpiarButton_KeyDown);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UsuarioToolStripStatusLabel,
            this.EstadoToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 340);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(627, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 71;
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
            // rUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 362);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.TelefonoMaskedTextBox);
            this.Controls.Add(this.DatosDelUsuarioGroupBox);
            this.Controls.Add(this.CedulaLabel);
            this.Controls.Add(this.ApellidosTextBox);
            this.Controls.Add(this.FechaDeRegistroDateTimePicker);
            this.Controls.Add(this.FechaDeRegistroLabel);
            this.Controls.Add(this.TelefonoLabel);
            this.Controls.Add(this.ApellidosLabel);
            this.Controls.Add(this.NombresLabel);
            this.Controls.Add(this.UsuarioIdNumericUpDown);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.NombresTextBox);
            this.Controls.Add(this.CedulaMaskedTextBox);
            this.Controls.Add(this.UsuarioIdLabel);
            this.Controls.Add(this.LimpiarButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "rUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registro de usuarios";
            this.Load += new System.EventHandler(this.rUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioIdNumericUpDown)).EndInit();
            this.DatosDelUsuarioGroupBox.ResumeLayout(false);
            this.DatosDelUsuarioGroupBox.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.Label UsuarioIdLabel;
        private System.Windows.Forms.MaskedTextBox CedulaMaskedTextBox;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.NumericUpDown UsuarioIdNumericUpDown;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.TextBox NombresTextBox;
        private System.Windows.Forms.TextBox ConfirmarContrasenaTextBox;
        private System.Windows.Forms.TextBox ContrasenaTextBox;
        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.DateTimePicker FechaDeRegistroDateTimePicker;
        private System.Windows.Forms.Label FechaDeRegistroLabel;
        private System.Windows.Forms.Label TelefonoLabel;
        private System.Windows.Forms.Label ApellidosLabel;
        private System.Windows.Forms.Label NombresLabel;
        private System.Windows.Forms.TextBox ApellidosTextBox;
        private System.Windows.Forms.Label CedulaLabel;
        private System.Windows.Forms.Label ConfirmarContrasenaLabel;
        private System.Windows.Forms.Label ContrasenaLabel;
        private System.Windows.Forms.Label NivelDeUsuarioLabel;
        private System.Windows.Forms.Label UsuarioLabel;
        private System.Windows.Forms.GroupBox DatosDelUsuarioGroupBox;
        private System.Windows.Forms.ComboBox NivelDeUsuarioComboBox;
        private System.Windows.Forms.MaskedTextBox TelefonoMaskedTextBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel UsuarioToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel EstadoToolStripStatusLabel;
    }
}