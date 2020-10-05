namespace SiADi
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
            this.comboBoxCargo = new System.Windows.Forms.ComboBox();
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
            this.pictureBoxUsuario = new System.Windows.Forms.PictureBox();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.btnAgregarFoto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxArea = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Pro Cond", 20.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label1.Location = new System.Drawing.Point(261, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nuevo Usuario";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDireccion.Font = new System.Drawing.Font("Myriad Pro Cond", 14.25F);
            this.textBoxDireccion.Location = new System.Drawing.Point(47, 319);
            this.textBoxDireccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDireccion.MaxLength = 45;
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(456, 29);
            this.textBoxDireccion.TabIndex = 6;
            this.textBoxDireccion.Validated += new System.EventHandler(this.textBoxDireccion_Validated);
            // 
            // labelDireccion
            // 
            this.labelDireccion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Font = new System.Drawing.Font("Myriad Pro Cond", 17.25F);
            this.labelDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.labelDireccion.Location = new System.Drawing.Point(25, 289);
            this.labelDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(97, 33);
            this.labelDireccion.TabIndex = 45;
            this.labelDireccion.Text = "Dirección";
            // 
            // comboBoxCargo
            // 
            this.comboBoxCargo.Font = new System.Drawing.Font("Myriad Pro Cond", 14.25F);
            this.comboBoxCargo.FormattingEnabled = true;
            this.comboBoxCargo.Location = new System.Drawing.Point(334, 390);
            this.comboBoxCargo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCargo.Name = "comboBoxCargo";
            this.comboBoxCargo.Size = new System.Drawing.Size(169, 35);
            this.comboBoxCargo.TabIndex = 7;
            // 
            // labelFechaNacimiento
            // 
            this.labelFechaNacimiento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelFechaNacimiento.AutoSize = true;
            this.labelFechaNacimiento.Font = new System.Drawing.Font("Myriad Pro Cond", 17.25F);
            this.labelFechaNacimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.labelFechaNacimiento.Location = new System.Drawing.Point(25, 215);
            this.labelFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFechaNacimiento.Name = "labelFechaNacimiento";
            this.labelFechaNacimiento.Size = new System.Drawing.Size(173, 33);
            this.labelFechaNacimiento.TabIndex = 41;
            this.labelFechaNacimiento.Text = "Fecha nacimiento";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Myriad Pro Cond", 14.25F);
            this.btnLimpiar.ForeColor = System.Drawing.Color.LightGray;
            this.btnLimpiar.Location = new System.Drawing.Point(56, 452);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(200, 49);
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
            this.btnCrear.Font = new System.Drawing.Font("Myriad Pro Cond", 14.25F);
            this.btnCrear.ForeColor = System.Drawing.Color.LightGray;
            this.btnCrear.Location = new System.Drawing.Point(407, 452);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(200, 49);
            this.btnCrear.TabIndex = 37;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Myriad Pro Cond", 17.25F);
            this.labelNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.labelNombre.Location = new System.Drawing.Point(23, 142);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(87, 33);
            this.labelNombre.TabIndex = 36;
            this.labelNombre.Text = "Nombre";
            // 
            // labelDNI
            // 
            this.labelDNI.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelDNI.AutoSize = true;
            this.labelDNI.Font = new System.Drawing.Font("Myriad Pro Cond", 17.25F);
            this.labelDNI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.labelDNI.Location = new System.Drawing.Point(27, 69);
            this.labelDNI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(47, 33);
            this.labelDNI.TabIndex = 35;
            this.labelDNI.Text = "DNI";
            // 
            // labelCUIL
            // 
            this.labelCUIL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCUIL.AutoSize = true;
            this.labelCUIL.Font = new System.Drawing.Font("Myriad Pro Cond", 17.25F);
            this.labelCUIL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.labelCUIL.Location = new System.Drawing.Point(224, 69);
            this.labelCUIL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCUIL.Name = "labelCUIL";
            this.labelCUIL.Size = new System.Drawing.Size(55, 33);
            this.labelCUIL.TabIndex = 47;
            this.labelCUIL.Text = "CUIL";
            // 
            // textBoxCUIL
            // 
            this.textBoxCUIL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCUIL.Font = new System.Drawing.Font("Myriad Pro Cond", 14.25F);
            this.textBoxCUIL.Location = new System.Drawing.Point(245, 101);
            this.textBoxCUIL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCUIL.MaxLength = 11;
            this.textBoxCUIL.Name = "textBoxCUIL";
            this.textBoxCUIL.Size = new System.Drawing.Size(160, 29);
            this.textBoxCUIL.TabIndex = 1;
            this.textBoxCUIL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCUIL_KeyPress);
            this.textBoxCUIL.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCUIL_Validating);
            // 
            // labelApellido
            // 
            this.labelApellido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelApellido.AutoSize = true;
            this.labelApellido.Font = new System.Drawing.Font("Myriad Pro Cond", 17.25F);
            this.labelApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.labelApellido.Location = new System.Drawing.Point(223, 139);
            this.labelApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(91, 33);
            this.labelApellido.TabIndex = 49;
            this.labelApellido.Text = "Apellido";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNombre.Font = new System.Drawing.Font("Myriad Pro Cond", 14.25F);
            this.textBoxNombre.Location = new System.Drawing.Point(47, 172);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNombre.MaxLength = 30;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(160, 29);
            this.textBoxNombre.TabIndex = 2;
            this.textBoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombre_KeyPress);
            this.textBoxNombre.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNombre_Validating);
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxApellido.Font = new System.Drawing.Font("Myriad Pro Cond", 14.25F);
            this.textBoxApellido.Location = new System.Drawing.Point(245, 172);
            this.textBoxApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(160, 29);
            this.textBoxApellido.TabIndex = 3;
            this.textBoxApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxApellido_KeyPress);
            this.textBoxApellido.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxApellido_Validating);
            // 
            // dateTimePickerFechaNacimiento
            // 
            this.dateTimePickerFechaNacimiento.Font = new System.Drawing.Font("Myriad Pro Cond", 14.25F);
            this.dateTimePickerFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaNacimiento.Location = new System.Drawing.Point(47, 244);
            this.dateTimePickerFechaNacimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerFechaNacimiento.MaxDate = new System.DateTime(2002, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerFechaNacimiento.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerFechaNacimiento.Name = "dateTimePickerFechaNacimiento";
            this.dateTimePickerFechaNacimiento.ShowUpDown = true;
            this.dateTimePickerFechaNacimiento.Size = new System.Drawing.Size(93, 36);
            this.dateTimePickerFechaNacimiento.TabIndex = 4;
            this.dateTimePickerFechaNacimiento.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerFechaNacimiento.Leave += new System.EventHandler(this.dateTimePickerFechaNacimiento_Leave);
            // 
            // labelEdad
            // 
            this.labelEdad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelEdad.AutoSize = true;
            this.labelEdad.Font = new System.Drawing.Font("Myriad Pro Cond", 17.25F);
            this.labelEdad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.labelEdad.Location = new System.Drawing.Point(225, 212);
            this.labelEdad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(60, 33);
            this.labelEdad.TabIndex = 54;
            this.labelEdad.Text = "Edad";
            // 
            // textBoxEdad
            // 
            this.textBoxEdad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEdad.Font = new System.Drawing.Font("Myriad Pro Cond", 14.25F);
            this.textBoxEdad.Location = new System.Drawing.Point(245, 246);
            this.textBoxEdad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEdad.MaxLength = 2;
            this.textBoxEdad.Name = "textBoxEdad";
            this.textBoxEdad.ReadOnly = true;
            this.textBoxEdad.Size = new System.Drawing.Size(45, 29);
            this.textBoxEdad.TabIndex = 55;
            this.textBoxEdad.TabStop = false;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTelefono.Font = new System.Drawing.Font("Myriad Pro Cond", 14.25F);
            this.textBoxTelefono.Location = new System.Drawing.Point(331, 246);
            this.textBoxTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTelefono.MaxLength = 10;
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(171, 29);
            this.textBoxTelefono.TabIndex = 5;
            this.textBoxTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTelefono_KeyPress);
            this.textBoxTelefono.Validated += new System.EventHandler(this.textBoxTelefono_Validated);
            // 
            // labelTelefono
            // 
            this.labelTelefono.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Font = new System.Drawing.Font("Myriad Pro Cond", 17.25F);
            this.labelTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.labelTelefono.Location = new System.Drawing.Point(312, 213);
            this.labelTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(92, 33);
            this.labelTelefono.TabIndex = 57;
            this.labelTelefono.Text = "Teléfono";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Myriad Pro Cond", 17.25F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label10.Location = new System.Drawing.Point(315, 359);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 33);
            this.label10.TabIndex = 58;
            this.label10.Text = "Cargo";
            // 
            // pictureBoxUsuario
            // 
            this.pictureBoxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxUsuario.Location = new System.Drawing.Point(495, 69);
            this.pictureBoxUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxUsuario.Name = "pictureBoxUsuario";
            this.pictureBoxUsuario.Size = new System.Drawing.Size(154, 155);
            this.pictureBoxUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUsuario.TabIndex = 61;
            this.pictureBoxUsuario.TabStop = false;
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDNI.Font = new System.Drawing.Font("Myriad Pro Cond", 14.25F);
            this.textBoxDNI.Location = new System.Drawing.Point(47, 101);
            this.textBoxDNI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDNI.MaxLength = 8;
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(160, 29);
            this.textBoxDNI.TabIndex = 0;
            this.textBoxDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDNI_KeyPress);
            this.textBoxDNI.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxDNI_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // btnAgregarFoto
            // 
            this.btnAgregarFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.btnAgregarFoto.FlatAppearance.BorderSize = 0;
            this.btnAgregarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarFoto.Font = new System.Drawing.Font("Myriad Pro Cond", 14.25F);
            this.btnAgregarFoto.ForeColor = System.Drawing.Color.LightGray;
            this.btnAgregarFoto.Location = new System.Drawing.Point(495, 154);
            this.btnAgregarFoto.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarFoto.Name = "btnAgregarFoto";
            this.btnAgregarFoto.Size = new System.Drawing.Size(112, 34);
            this.btnAgregarFoto.TabIndex = 63;
            this.btnAgregarFoto.Text = "Añadir foto";
            this.btnAgregarFoto.UseVisualStyleBackColor = false;
            this.btnAgregarFoto.Click += new System.EventHandler(this.btnAgregarFoto_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myriad Pro Cond", 17.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label2.Location = new System.Drawing.Point(37, 359);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 33);
            this.label2.TabIndex = 65;
            this.label2.Text = "Área";
            // 
            // comboBoxArea
            // 
            this.comboBoxArea.Font = new System.Drawing.Font("Myriad Pro Cond", 14.25F);
            this.comboBoxArea.FormattingEnabled = true;
            this.comboBoxArea.Location = new System.Drawing.Point(56, 390);
            this.comboBoxArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxArea.Name = "comboBoxArea";
            this.comboBoxArea.Size = new System.Drawing.Size(169, 35);
            this.comboBoxArea.TabIndex = 64;
            this.comboBoxArea.SelectedValueChanged += new System.EventHandler(this.comboBoxArea_SelectedValueChanged);
            // 
            // UsuariosAñadir
            // 
            this.AcceptButton = this.btnCrear;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(667, 514);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxArea);
            this.Controls.Add(this.btnAgregarFoto);
            this.Controls.Add(this.pictureBoxUsuario);
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
            this.Controls.Add(this.comboBoxCargo);
            this.Controls.Add(this.labelFechaNacimiento);
            this.Controls.Add(this.textBoxDNI);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelDNI);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UsuariosAñadir";
            this.Text = "UsuariosAñadir";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.ComboBox comboBoxCargo;
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
        private System.Windows.Forms.PictureBox pictureBoxUsuario;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button btnAgregarFoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxArea;
    }
}