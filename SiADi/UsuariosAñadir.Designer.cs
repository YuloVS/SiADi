﻿namespace SiADi
{
    partial class UsuariosAñadir
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelFechaNacimiento = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelDNI = new System.Windows.Forms.Label();
            this.labelCUIL = new System.Windows.Forms.Label();
            this.textBoxCUIL = new System.Windows.Forms.TextBox();
            this.labelApellido = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.dateTimePickerFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.labelEdad = new System.Windows.Forms.Label();
            this.textBoxEdad = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label1.Location = new System.Drawing.Point(196, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nuevo Usuario";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(35, 259);
            this.textBoxDireccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDireccion.MaxLength = 45;
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(342, 20);
            this.textBoxDireccion.TabIndex = 46;
            this.textBoxDireccion.Validated += new System.EventHandler(this.textBoxDireccion_Validated);
            // 
            // labelDireccion
            // 
            this.labelDireccion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.labelDireccion.Location = new System.Drawing.Point(23, 233);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(90, 24);
            this.labelDireccion.TabIndex = 45;
            this.labelDireccion.Text = "Dirección";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(35, 319);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(128, 21);
            this.comboBox1.TabIndex = 42;
            // 
            // labelFechaNacimiento
            // 
            this.labelFechaNacimiento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelFechaNacimiento.AutoSize = true;
            this.labelFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaNacimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.labelFechaNacimiento.Location = new System.Drawing.Point(23, 172);
            this.labelFechaNacimiento.Name = "labelFechaNacimiento";
            this.labelFechaNacimiento.Size = new System.Drawing.Size(161, 24);
            this.labelFechaNacimiento.TabIndex = 41;
            this.labelFechaNacimiento.Text = "Fecha nacimiento";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.LightGray;
            this.btnLimpiar.Location = new System.Drawing.Point(42, 367);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(150, 40);
            this.btnLimpiar.TabIndex = 38;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.btnCrear.FlatAppearance.BorderSize = 0;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.Color.LightGray;
            this.btnCrear.Location = new System.Drawing.Point(305, 367);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(150, 40);
            this.btnCrear.TabIndex = 37;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = false;
            // 
            // labelNombre
            // 
            this.labelNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.labelNombre.Location = new System.Drawing.Point(23, 114);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(79, 24);
            this.labelNombre.TabIndex = 36;
            this.labelNombre.Text = "Nombre";
            // 
            // labelDNI
            // 
            this.labelDNI.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelDNI.AutoSize = true;
            this.labelDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDNI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.labelDNI.Location = new System.Drawing.Point(23, 56);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(41, 24);
            this.labelDNI.TabIndex = 35;
            this.labelDNI.Text = "DNI";
            // 
            // labelCUIL
            // 
            this.labelCUIL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCUIL.AutoSize = true;
            this.labelCUIL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCUIL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.labelCUIL.Location = new System.Drawing.Point(174, 56);
            this.labelCUIL.Name = "labelCUIL";
            this.labelCUIL.Size = new System.Drawing.Size(50, 24);
            this.labelCUIL.TabIndex = 47;
            this.labelCUIL.Text = "CUIL";
            // 
            // textBoxCUIL
            // 
            this.textBoxCUIL.Location = new System.Drawing.Point(184, 82);
            this.textBoxCUIL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCUIL.MaxLength = 11;
            this.textBoxCUIL.Name = "textBoxCUIL";
            this.textBoxCUIL.Size = new System.Drawing.Size(120, 20);
            this.textBoxCUIL.TabIndex = 1;
            this.textBoxCUIL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCUIL_KeyPress);
            this.textBoxCUIL.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCUIL_Validating);
            // 
            // labelApellido
            // 
            this.labelApellido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelApellido.AutoSize = true;
            this.labelApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.labelApellido.Location = new System.Drawing.Point(174, 114);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(79, 24);
            this.labelApellido.TabIndex = 49;
            this.labelApellido.Text = "Apellido";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(35, 140);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNombre.MaxLength = 30;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(120, 20);
            this.textBoxNombre.TabIndex = 2;
            this.textBoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombre_KeyPress);
            this.textBoxNombre.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNombre_Validating);
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(184, 140);
            this.textBoxApellido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(120, 20);
            this.textBoxApellido.TabIndex = 3;
            this.textBoxApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxApellido_KeyPress);
            this.textBoxApellido.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxApellido_Validating);
            // 
            // dateTimePickerFechaNacimiento
            // 
            this.dateTimePickerFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaNacimiento.Location = new System.Drawing.Point(35, 198);
            this.dateTimePickerFechaNacimiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerFechaNacimiento.MaxDate = new System.DateTime(2002, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerFechaNacimiento.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerFechaNacimiento.Name = "dateTimePickerFechaNacimiento";
            this.dateTimePickerFechaNacimiento.ShowUpDown = true;
            this.dateTimePickerFechaNacimiento.Size = new System.Drawing.Size(71, 20);
            this.dateTimePickerFechaNacimiento.TabIndex = 4;
            this.dateTimePickerFechaNacimiento.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerFechaNacimiento.Leave += new System.EventHandler(this.dateTimePickerFechaNacimiento_Leave);
            // 
            // labelEdad
            // 
            this.labelEdad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelEdad.AutoSize = true;
            this.labelEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.labelEdad.Location = new System.Drawing.Point(174, 172);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(55, 24);
            this.labelEdad.TabIndex = 54;
            this.labelEdad.Text = "Edad";
            // 
            // textBoxEdad
            // 
            this.textBoxEdad.Location = new System.Drawing.Point(184, 200);
            this.textBoxEdad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxEdad.MaxLength = 2;
            this.textBoxEdad.Name = "textBoxEdad";
            this.textBoxEdad.ReadOnly = true;
            this.textBoxEdad.Size = new System.Drawing.Size(34, 20);
            this.textBoxEdad.TabIndex = 55;
            this.textBoxEdad.TabStop = false;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(248, 200);
            this.textBoxTelefono.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTelefono.MaxLength = 10;
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(128, 20);
            this.textBoxTelefono.TabIndex = 5;
            this.textBoxTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTelefono_KeyPress);
            this.textBoxTelefono.Validated += new System.EventHandler(this.textBoxTelefono_Validated);
            // 
            // labelTelefono
            // 
            this.labelTelefono.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.labelTelefono.Location = new System.Drawing.Point(238, 172);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(85, 24);
            this.labelTelefono.TabIndex = 57;
            this.labelTelefono.Text = "Teléfono";
            this.labelTelefono.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label10.Location = new System.Drawing.Point(23, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 24);
            this.label10.TabIndex = 58;
            this.label10.Text = "Cargo";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label11.Location = new System.Drawing.Point(238, 293);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 24);
            this.label11.TabIndex = 59;
            this.label11.Text = "Tipo usuario";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(248, 319);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(128, 21);
            this.comboBox2.TabIndex = 60;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(352, 56);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 126);
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(35, 82);
            this.textBoxDNI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDNI.MaxLength = 8;
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(120, 20);
            this.textBoxDNI.TabIndex = 0;
            this.textBoxDNI.TextChanged += new System.EventHandler(this.textBoxDNI_TextChanged);
            this.textBoxDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDNI_KeyPress);
            this.textBoxDNI.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxDNI_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UsuariosAñadir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(500, 418);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.textBoxEdad);
            this.Controls.Add(this.labelEdad);
            this.Controls.Add(this.dateTimePickerFechaNacimiento);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.textBoxCUIL);
            this.Controls.Add(this.labelCUIL);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.labelDireccion);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelFechaNacimiento);
            this.Controls.Add(this.textBoxDNI);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelDNI);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UsuariosAñadir";
            this.Text = "UsuariosAñadir";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelFechaNacimiento;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelDNI;
        private System.Windows.Forms.Label labelCUIL;
        private System.Windows.Forms.TextBox textBoxCUIL;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaNacimiento;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.TextBox textBoxEdad;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}