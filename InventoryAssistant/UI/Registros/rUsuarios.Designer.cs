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
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.UsuarioIdLabel = new System.Windows.Forms.Label();
            this.CedulaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.NombresTextBox = new System.Windows.Forms.TextBox();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
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
            this.CelularMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.UsuarioLabel = new System.Windows.Forms.Label();
            this.NivelDeUsuarioLabel = new System.Windows.Forms.Label();
            this.ContrasenaLabel = new System.Windows.Forms.Label();
            this.ConfirmarContrasenaLabel = new System.Windows.Forms.Label();
            this.DatosDelUsuarioGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioIdNumericUpDown)).BeginInit();
            this.DatosDelUsuarioGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimpiarButton.Location = new System.Drawing.Point(56, 238);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(75, 23);
            this.LimpiarButton.TabIndex = 0;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LimpiarButton.UseVisualStyleBackColor = true;
            this.LimpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
            // 
            // UsuarioIdLabel
            // 
            this.UsuarioIdLabel.AutoSize = true;
            this.UsuarioIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioIdLabel.Location = new System.Drawing.Point(37, 35);
            this.UsuarioIdLabel.Name = "UsuarioIdLabel";
            this.UsuarioIdLabel.Size = new System.Drawing.Size(143, 16);
            this.UsuarioIdLabel.TabIndex = 1;
            this.UsuarioIdLabel.Text = "Codigo del usuario:";
            // 
            // CedulaMaskedTextBox
            // 
            this.CedulaMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CedulaMaskedTextBox.Location = new System.Drawing.Point(129, 119);
            this.CedulaMaskedTextBox.Mask = "999-9999999-9";
            this.CedulaMaskedTextBox.Name = "CedulaMaskedTextBox";
            this.CedulaMaskedTextBox.Size = new System.Drawing.Size(100, 22);
            this.CedulaMaskedTextBox.TabIndex = 2;
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // NombresTextBox
            // 
            this.NombresTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombresTextBox.Location = new System.Drawing.Point(129, 63);
            this.NombresTextBox.Name = "NombresTextBox";
            this.NombresTextBox.Size = new System.Drawing.Size(100, 22);
            this.NombresTextBox.TabIndex = 3;
            // 
            // EliminarButton
            // 
            this.EliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.Location = new System.Drawing.Point(337, 256);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 23);
            this.EliminarButton.TabIndex = 5;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Location = new System.Drawing.Point(184, 238);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 23);
            this.GuardarButton.TabIndex = 6;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // BuscarButton
            // 
            this.BuscarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarButton.Location = new System.Drawing.Point(363, 27);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(75, 23);
            this.BuscarButton.TabIndex = 7;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // UsuarioIdNumericUpDown
            // 
            this.UsuarioIdNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioIdNumericUpDown.Location = new System.Drawing.Point(129, 30);
            this.UsuarioIdNumericUpDown.Name = "UsuarioIdNumericUpDown";
            this.UsuarioIdNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.UsuarioIdNumericUpDown.TabIndex = 8;
            // 
            // NombresLabel
            // 
            this.NombresLabel.AutoSize = true;
            this.NombresLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombresLabel.Location = new System.Drawing.Point(53, 69);
            this.NombresLabel.Name = "NombresLabel";
            this.NombresLabel.Size = new System.Drawing.Size(75, 16);
            this.NombresLabel.TabIndex = 9;
            this.NombresLabel.Text = "Nombres:";
            // 
            // ApellidosLabel
            // 
            this.ApellidosLabel.AutoSize = true;
            this.ApellidosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApellidosLabel.Location = new System.Drawing.Point(46, 97);
            this.ApellidosLabel.Name = "ApellidosLabel";
            this.ApellidosLabel.Size = new System.Drawing.Size(82, 16);
            this.ApellidosLabel.TabIndex = 10;
            this.ApellidosLabel.Text = "Apellidos: ";
            // 
            // TelefonoLabel
            // 
            this.TelefonoLabel.AutoSize = true;
            this.TelefonoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelefonoLabel.Location = new System.Drawing.Point(63, 143);
            this.TelefonoLabel.Name = "TelefonoLabel";
            this.TelefonoLabel.Size = new System.Drawing.Size(74, 16);
            this.TelefonoLabel.TabIndex = 11;
            this.TelefonoLabel.Text = "Telefono:";
            // 
            // FechaDeRegistroLabel
            // 
            this.FechaDeRegistroLabel.AutoSize = true;
            this.FechaDeRegistroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaDeRegistroLabel.Location = new System.Drawing.Point(37, 174);
            this.FechaDeRegistroLabel.Name = "FechaDeRegistroLabel";
            this.FechaDeRegistroLabel.Size = new System.Drawing.Size(134, 16);
            this.FechaDeRegistroLabel.TabIndex = 12;
            this.FechaDeRegistroLabel.Text = "Fecha de registro:";
            // 
            // FechaDeRegistroDateTimePicker
            // 
            this.FechaDeRegistroDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaDeRegistroDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaDeRegistroDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaDeRegistroDateTimePicker.Location = new System.Drawing.Point(129, 168);
            this.FechaDeRegistroDateTimePicker.MaxDate = new System.DateTime(2050, 1, 1, 0, 0, 0, 0);
            this.FechaDeRegistroDateTimePicker.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.FechaDeRegistroDateTimePicker.Name = "FechaDeRegistroDateTimePicker";
            this.FechaDeRegistroDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.FechaDeRegistroDateTimePicker.TabIndex = 13;
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioTextBox.Location = new System.Drawing.Point(6, 33);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.Size = new System.Drawing.Size(100, 22);
            this.UsuarioTextBox.TabIndex = 14;
            // 
            // ContrasenaTextBox
            // 
            this.ContrasenaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContrasenaTextBox.Location = new System.Drawing.Point(10, 123);
            this.ContrasenaTextBox.Name = "ContrasenaTextBox";
            this.ContrasenaTextBox.Size = new System.Drawing.Size(100, 22);
            this.ContrasenaTextBox.TabIndex = 15;
            this.ContrasenaTextBox.UseSystemPasswordChar = true;
            // 
            // ConfirmarContrasenaTextBox
            // 
            this.ConfirmarContrasenaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmarContrasenaTextBox.Location = new System.Drawing.Point(25, 172);
            this.ConfirmarContrasenaTextBox.Name = "ConfirmarContrasenaTextBox";
            this.ConfirmarContrasenaTextBox.Size = new System.Drawing.Size(100, 22);
            this.ConfirmarContrasenaTextBox.TabIndex = 16;
            this.ConfirmarContrasenaTextBox.UseSystemPasswordChar = true;
            // 
            // NivelDeUsuarioComboBox
            // 
            this.NivelDeUsuarioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NivelDeUsuarioComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NivelDeUsuarioComboBox.FormattingEnabled = true;
            this.NivelDeUsuarioComboBox.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.NivelDeUsuarioComboBox.Location = new System.Drawing.Point(6, 78);
            this.NivelDeUsuarioComboBox.Name = "NivelDeUsuarioComboBox";
            this.NivelDeUsuarioComboBox.Size = new System.Drawing.Size(121, 24);
            this.NivelDeUsuarioComboBox.Sorted = true;
            this.NivelDeUsuarioComboBox.TabIndex = 17;
            // 
            // ApellidosTextBox
            // 
            this.ApellidosTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApellidosTextBox.Location = new System.Drawing.Point(129, 91);
            this.ApellidosTextBox.Name = "ApellidosTextBox";
            this.ApellidosTextBox.Size = new System.Drawing.Size(100, 22);
            this.ApellidosTextBox.TabIndex = 18;
            // 
            // CedulaLabel
            // 
            this.CedulaLabel.AutoSize = true;
            this.CedulaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CedulaLabel.Location = new System.Drawing.Point(63, 113);
            this.CedulaLabel.Name = "CedulaLabel";
            this.CedulaLabel.Size = new System.Drawing.Size(61, 16);
            this.CedulaLabel.TabIndex = 19;
            this.CedulaLabel.Text = "Cedula:";
            // 
            // CelularMaskedTextBox
            // 
            this.CelularMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CelularMaskedTextBox.Location = new System.Drawing.Point(139, 140);
            this.CelularMaskedTextBox.Mask = "999-999-9999";
            this.CelularMaskedTextBox.Name = "CelularMaskedTextBox";
            this.CelularMaskedTextBox.Size = new System.Drawing.Size(100, 22);
            this.CelularMaskedTextBox.TabIndex = 20;
            // 
            // UsuarioLabel
            // 
            this.UsuarioLabel.AutoSize = true;
            this.UsuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioLabel.Location = new System.Drawing.Point(-3, 18);
            this.UsuarioLabel.Name = "UsuarioLabel";
            this.UsuarioLabel.Size = new System.Drawing.Size(66, 16);
            this.UsuarioLabel.TabIndex = 21;
            this.UsuarioLabel.Text = "Usuario:";
            // 
            // NivelDeUsuarioLabel
            // 
            this.NivelDeUsuarioLabel.AutoSize = true;
            this.NivelDeUsuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NivelDeUsuarioLabel.Location = new System.Drawing.Point(22, 64);
            this.NivelDeUsuarioLabel.Name = "NivelDeUsuarioLabel";
            this.NivelDeUsuarioLabel.Size = new System.Drawing.Size(121, 16);
            this.NivelDeUsuarioLabel.TabIndex = 22;
            this.NivelDeUsuarioLabel.Text = "Nivel de usuario";
            // 
            // ContrasenaLabel
            // 
            this.ContrasenaLabel.AutoSize = true;
            this.ContrasenaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContrasenaLabel.Location = new System.Drawing.Point(3, 105);
            this.ContrasenaLabel.Name = "ContrasenaLabel";
            this.ContrasenaLabel.Size = new System.Drawing.Size(91, 16);
            this.ContrasenaLabel.TabIndex = 23;
            this.ContrasenaLabel.Text = "Contraseña:";
            // 
            // ConfirmarContrasenaLabel
            // 
            this.ConfirmarContrasenaLabel.AutoSize = true;
            this.ConfirmarContrasenaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmarContrasenaLabel.Location = new System.Drawing.Point(22, 144);
            this.ConfirmarContrasenaLabel.Name = "ConfirmarContrasenaLabel";
            this.ConfirmarContrasenaLabel.Size = new System.Drawing.Size(159, 16);
            this.ConfirmarContrasenaLabel.TabIndex = 24;
            this.ConfirmarContrasenaLabel.Text = "Confirmar contraseña:";
            // 
            // DatosDelUsuarioGroupBox
            // 
            this.DatosDelUsuarioGroupBox.Controls.Add(this.UsuarioLabel);
            this.DatosDelUsuarioGroupBox.Controls.Add(this.ConfirmarContrasenaLabel);
            this.DatosDelUsuarioGroupBox.Controls.Add(this.UsuarioTextBox);
            this.DatosDelUsuarioGroupBox.Controls.Add(this.ContrasenaLabel);
            this.DatosDelUsuarioGroupBox.Controls.Add(this.ConfirmarContrasenaTextBox);
            this.DatosDelUsuarioGroupBox.Controls.Add(this.NivelDeUsuarioComboBox);
            this.DatosDelUsuarioGroupBox.Controls.Add(this.NivelDeUsuarioLabel);
            this.DatosDelUsuarioGroupBox.Controls.Add(this.ContrasenaTextBox);
            this.DatosDelUsuarioGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatosDelUsuarioGroupBox.Location = new System.Drawing.Point(487, 12);
            this.DatosDelUsuarioGroupBox.Name = "DatosDelUsuarioGroupBox";
            this.DatosDelUsuarioGroupBox.Size = new System.Drawing.Size(200, 249);
            this.DatosDelUsuarioGroupBox.TabIndex = 25;
            this.DatosDelUsuarioGroupBox.TabStop = false;
            this.DatosDelUsuarioGroupBox.Text = "Datos del usuario";
            // 
            // rUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DatosDelUsuarioGroupBox);
            this.Controls.Add(this.CelularMaskedTextBox);
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
            this.Name = "rUsuarios";
            this.Text = "rUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioIdNumericUpDown)).EndInit();
            this.DatosDelUsuarioGroupBox.ResumeLayout(false);
            this.DatosDelUsuarioGroupBox.PerformLayout();
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
        private System.Windows.Forms.MaskedTextBox CelularMaskedTextBox;
        private System.Windows.Forms.Label ConfirmarContrasenaLabel;
        private System.Windows.Forms.Label ContrasenaLabel;
        private System.Windows.Forms.Label NivelDeUsuarioLabel;
        private System.Windows.Forms.Label UsuarioLabel;
        private System.Windows.Forms.GroupBox DatosDelUsuarioGroupBox;
        private System.Windows.Forms.ComboBox NivelDeUsuarioComboBox;
    }
}