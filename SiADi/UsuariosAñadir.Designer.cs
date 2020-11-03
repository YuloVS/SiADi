namespace SiADi
{
    partial class imagen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(imagen));
            this.labelUsuariosAñadir = new System.Windows.Forms.Label();
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
            this.labelCargo = new System.Windows.Forms.Label();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.labelArea = new System.Windows.Forms.Label();
            this.comboBoxArea = new System.Windows.Forms.ComboBox();
            this.checkBoxEncargado = new System.Windows.Forms.CheckBox();
            this.textBoxEdad2 = new System.Windows.Forms.TextBox();
            this.labelEdad2 = new System.Windows.Forms.Label();
            this.labelTelefono2 = new System.Windows.Forms.Label();
            this.textBoxTelefono2 = new System.Windows.Forms.TextBox();
            this.labelFechaNacimiento2 = new System.Windows.Forms.Label();
            this.labelNombre2 = new System.Windows.Forms.Label();
            this.labelApellido2 = new System.Windows.Forms.Label();
            this.labelCUIL2 = new System.Windows.Forms.Label();
            this.labelDNI2 = new System.Windows.Forms.Label();
            this.labelDireccion2 = new System.Windows.Forms.Label();
            this.labelArea2 = new System.Windows.Forms.Label();
            this.labelCargo2 = new System.Windows.Forms.Label();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUsuariosAñadir
            // 
            this.labelUsuariosAñadir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelUsuariosAñadir.AutoSize = true;
            this.labelUsuariosAñadir.Font = new System.Drawing.Font("Myriad Pro Cond", 20.25F);
            this.labelUsuariosAñadir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.labelUsuariosAñadir.Location = new System.Drawing.Point(196, 15);
            this.labelUsuariosAñadir.Name = "labelUsuariosAñadir";
            this.labelUsuariosAñadir.Size = new System.Drawing.Size(133, 30);
            this.labelUsuariosAñadir.TabIndex = 2;
            this.labelUsuariosAñadir.Text = "Nuevo Usuario";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDireccion.Font = new System.Drawing.Font("Myriad Pro Cond", 14.25F);
            this.textBoxDireccion.Location = new System.Drawing.Point(35, 259);
            this.textBoxDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDireccion.MaxLength = 45;
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(342, 23);
            this.textBoxDireccion.TabIndex = 6;
            this.textBoxDireccion.Validated += new System.EventHandler(this.textBoxDireccion_Validated);
            // 
            // labelDireccion
            // 
            this.labelDireccion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Font = new System.Drawing.Font("Myriad Pro Cond", 17.25F);
            this.labelDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.labelDireccion.Location = new System.Drawing.Point(19, 235);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(76, 26);
            this.labelDireccion.TabIndex = 45;
            this.labelDireccion.Text = "Dirección";
            // 
            // comboBoxCargo
            // 
            this.comboBoxCargo.Font = new System.Drawing.Font("Myriad Pro Cond", 14.25F);
            this.comboBoxCargo.FormattingEnabled = true;
            this.comboBoxCargo.Location = new System.Drawing.Point(250, 317);
            this.comboBoxCargo.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCargo.Name = "comboBoxCargo";
            this.comboBoxCargo.Size = new System.Drawing.Size(128, 29);
            this.comboBoxCargo.TabIndex = 7;
            // 
            // labelFechaNacimiento
            // 
            this.labelFechaNacimiento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelFechaNacimiento.AutoSize = true;
            this.labelFechaNacimiento.Font = new System.Drawing.Font("Myriad Pro Cond", 17.25F);
            this.labelFechaNacimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.labelFechaNacimiento.Location = new System.Drawing.Point(19, 175);
            this.labelFechaNacimiento.Name = "labelFechaNacimiento";
            this.labelFechaNacimiento.Size = new System.Drawing.Size(134, 26);
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
            this.btnLimpiar.Location = new System.Drawing.Point(25, 366);
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
            this.btnCrear.Font = new System.Drawing.Font("Myriad Pro Cond", 14.25F);
            this.btnCrear.ForeColor = System.Drawing.Color.LightGray;
            this.btnCrear.Location = new System.Drawing.Point(305, 367);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(150, 40);
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
            this.labelNombre.Location = new System.Drawing.Point(17, 115);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(69, 26);
            this.labelNombre.TabIndex = 36;
            this.labelNombre.Text = "Nombre";
            // 
            // labelDNI
            // 
            this.labelDNI.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelDNI.AutoSize = true;
            this.labelDNI.Font = new System.Drawing.Font("Myriad Pro Cond", 17.25F);
            this.labelDNI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.labelDNI.Location = new System.Drawing.Point(20, 56);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(38, 26);
            this.labelDNI.TabIndex = 35;
            this.labelDNI.Text = "DNI";
            // 
            // labelCUIL
            // 
            this.labelCUIL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCUIL.AutoSize = true;
            this.labelCUIL.Font = new System.Drawing.Font("Myriad Pro Cond", 17.25F);
            this.labelCUIL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.labelCUIL.Location = new System.Drawing.Point(168, 56);
            this.labelCUIL.Name = "labelCUIL";
            this.labelCUIL.Size = new System.Drawing.Size(45, 26);
            this.labelCUIL.TabIndex = 47;
            this.labelCUIL.Text = "CUIL";
            // 
            // textBoxCUIL
            // 
            this.textBoxCUIL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCUIL.Font = new System.Drawing.Font("Myriad Pro Cond", 14.25F);
            this.textBoxCUIL.Location = new System.Drawing.Point(184, 82);
            this.textBoxCUIL.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCUIL.MaxLength = 11;
            this.textBoxCUIL.Name = "textBoxCUIL";
            this.textBoxCUIL.Size = new System.Drawing.Size(120, 23);
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
            this.labelApellido.Location = new System.Drawing.Point(167, 113);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(69, 26);
            this.labelApellido.TabIndex = 49;
            this.labelApellido.Text = "Apellido";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNombre.Font = new System.Drawing.Font("Myriad Pro Cond", 14.25F);
            this.textBoxNombre.Location = new System.Drawing.Point(35, 140);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNombre.MaxLength = 30;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(120, 23);
            this.textBoxNombre.TabIndex = 2;
            this.textBoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombre_KeyPress);
            this.textBoxNombre.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNombre_Validating);
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxApellido.Font = new System.Drawing.Font("Myriad Pro Cond", 14.25F);
            this.textBoxApellido.Location = new System.Drawing.Point(184, 140);
            this.textBoxApellido.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(120, 23);
            this.textBoxApellido.TabIndex = 3;
            this.textBoxApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxApellido_KeyPress);
            this.textBoxApellido.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxApellido_Validating);
            // 
            // dateTimePickerFechaNacimiento
            // 
            this.dateTimePickerFechaNacimiento.Font = new System.Drawing.Font("Myriad Pro Cond", 14.25F);
            this.dateTimePickerFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaNacimiento.Location = new System.Drawing.Point(35, 198);
            this.dateTimePickerFechaNacimiento.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerFechaNacimiento.MaxDate = new System.DateTime(2002, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerFechaNacimiento.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerFechaNacimiento.Name = "dateTimePickerFechaNacimiento";
            this.dateTimePickerFechaNacimiento.ShowUpDown = true;
            this.dateTimePickerFechaNacimiento.Size = new System.Drawing.Size(71, 30);
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
            this.labelEdad.Location = new System.Drawing.Point(142, 175);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(46, 26);
            this.labelEdad.TabIndex = 54;
            this.labelEdad.Text = "Edad";
            // 
            // textBoxEdad
            // 
            this.textBoxEdad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEdad.Font = new System.Drawing.Font("Myriad Pro Cond", 14.25F);
            this.textBoxEdad.Location = new System.Drawing.Point(158, 203);
            this.textBoxEdad.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEdad.MaxLength = 2;
            this.textBoxEdad.Name = "textBoxEdad";
            this.textBoxEdad.ReadOnly = true;
            this.textBoxEdad.Size = new System.Drawing.Size(34, 23);
            this.textBoxEdad.TabIndex = 55;
            this.textBoxEdad.TabStop = false;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTelefono.Font = new System.Drawing.Font("Myriad Pro Cond", 14.25F);
            this.textBoxTelefono.Location = new System.Drawing.Point(222, 203);
            this.textBoxTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTelefono.MaxLength = 10;
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(128, 23);
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
            this.labelTelefono.Location = new System.Drawing.Point(205, 175);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(71, 26);
            this.labelTelefono.TabIndex = 57;
            this.labelTelefono.Text = "Teléfono";
            // 
            // labelCargo
            // 
            this.labelCargo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCargo.AutoSize = true;
            this.labelCargo.Font = new System.Drawing.Font("Myriad Pro Cond", 17.25F);
            this.labelCargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.labelCargo.Location = new System.Drawing.Point(236, 292);
            this.labelCargo.Name = "labelCargo";
            this.labelCargo.Size = new System.Drawing.Size(53, 26);
            this.labelCargo.TabIndex = 58;
            this.labelCargo.Text = "Cargo";
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDNI.Font = new System.Drawing.Font("Myriad Pro Cond", 14.25F);
            this.textBoxDNI.Location = new System.Drawing.Point(35, 82);
            this.textBoxDNI.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDNI.MaxLength = 8;
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(120, 23);
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
            // labelArea
            // 
            this.labelArea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelArea.AutoSize = true;
            this.labelArea.Font = new System.Drawing.Font("Myriad Pro Cond", 17.25F);
            this.labelArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.labelArea.Location = new System.Drawing.Point(20, 292);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(44, 26);
            this.labelArea.TabIndex = 65;
            this.labelArea.Text = "Área";
            // 
            // comboBoxArea
            // 
            this.comboBoxArea.Font = new System.Drawing.Font("Myriad Pro Cond", 14.25F);
            this.comboBoxArea.FormattingEnabled = true;
            this.comboBoxArea.Location = new System.Drawing.Point(35, 317);
            this.comboBoxArea.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxArea.Name = "comboBoxArea";
            this.comboBoxArea.Size = new System.Drawing.Size(128, 29);
            this.comboBoxArea.TabIndex = 64;
            this.comboBoxArea.SelectedValueChanged += new System.EventHandler(this.comboBoxArea_SelectedValueChanged);
            // 
            // checkBoxEncargado
            // 
            this.checkBoxEncargado.AutoSize = true;
            this.checkBoxEncargado.Font = new System.Drawing.Font("Myriad Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEncargado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.checkBoxEncargado.Location = new System.Drawing.Point(168, 321);
            this.checkBoxEncargado.Name = "checkBoxEncargado";
            this.checkBoxEncargado.Size = new System.Drawing.Size(78, 22);
            this.checkBoxEncargado.TabIndex = 67;
            this.checkBoxEncargado.Text = "Encargado";
            this.checkBoxEncargado.UseVisualStyleBackColor = true;
            // 
            // textBoxEdad2
            // 
            this.textBoxEdad2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEdad2.Font = new System.Drawing.Font("Myriad Pro Cond", 14.25F);
            this.textBoxEdad2.Location = new System.Drawing.Point(195, 203);
            this.textBoxEdad2.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEdad2.MaxLength = 2;
            this.textBoxEdad2.Name = "textBoxEdad2";
            this.textBoxEdad2.ReadOnly = true;
            this.textBoxEdad2.Size = new System.Drawing.Size(34, 23);
            this.textBoxEdad2.TabIndex = 70;
            this.textBoxEdad2.TabStop = false;
            // 
            // labelEdad2
            // 
            this.labelEdad2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelEdad2.AutoSize = true;
            this.labelEdad2.Font = new System.Drawing.Font("Myriad Pro Cond", 17.25F);
            this.labelEdad2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.labelEdad2.Location = new System.Drawing.Point(190, 175);
            this.labelEdad2.Name = "labelEdad2";
            this.labelEdad2.Size = new System.Drawing.Size(46, 26);
            this.labelEdad2.TabIndex = 69;
            this.labelEdad2.Text = "Edad";
            // 
            // labelTelefono2
            // 
            this.labelTelefono2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTelefono2.AutoSize = true;
            this.labelTelefono2.Font = new System.Drawing.Font("Myriad Pro Cond", 17.25F);
            this.labelTelefono2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.labelTelefono2.Location = new System.Drawing.Point(279, 175);
            this.labelTelefono2.Name = "labelTelefono2";
            this.labelTelefono2.Size = new System.Drawing.Size(71, 26);
            this.labelTelefono2.TabIndex = 72;
            this.labelTelefono2.Text = "Teléfono";
            // 
            // textBoxTelefono2
            // 
            this.textBoxTelefono2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTelefono2.Font = new System.Drawing.Font("Myriad Pro Cond", 14.25F);
            this.textBoxTelefono2.Location = new System.Drawing.Point(284, 203);
            this.textBoxTelefono2.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTelefono2.MaxLength = 10;
            this.textBoxTelefono2.Name = "textBoxTelefono2";
            this.textBoxTelefono2.Size = new System.Drawing.Size(128, 23);
            this.textBoxTelefono2.TabIndex = 71;
            this.textBoxTelefono2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTelefono2_KeyPress);
            this.textBoxTelefono2.Validated += new System.EventHandler(this.textBoxTelefono2_Validated);
            // 
            // labelFechaNacimiento2
            // 
            this.labelFechaNacimiento2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelFechaNacimiento2.AutoSize = true;
            this.labelFechaNacimiento2.Font = new System.Drawing.Font("Myriad Pro Cond", 17.25F);
            this.labelFechaNacimiento2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.labelFechaNacimiento2.Location = new System.Drawing.Point(30, 175);
            this.labelFechaNacimiento2.Name = "labelFechaNacimiento2";
            this.labelFechaNacimiento2.Size = new System.Drawing.Size(134, 26);
            this.labelFechaNacimiento2.TabIndex = 74;
            this.labelFechaNacimiento2.Text = "Fecha nacimiento";
            // 
            // labelNombre2
            // 
            this.labelNombre2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNombre2.AutoSize = true;
            this.labelNombre2.Font = new System.Drawing.Font("Myriad Pro Cond", 17.25F);
            this.labelNombre2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.labelNombre2.Location = new System.Drawing.Point(30, 112);
            this.labelNombre2.Name = "labelNombre2";
            this.labelNombre2.Size = new System.Drawing.Size(69, 26);
            this.labelNombre2.TabIndex = 75;
            this.labelNombre2.Text = "Nombre";
            // 
            // labelApellido2
            // 
            this.labelApellido2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelApellido2.AutoSize = true;
            this.labelApellido2.Font = new System.Drawing.Font("Myriad Pro Cond", 17.25F);
            this.labelApellido2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.labelApellido2.Location = new System.Drawing.Point(179, 112);
            this.labelApellido2.Name = "labelApellido2";
            this.labelApellido2.Size = new System.Drawing.Size(69, 26);
            this.labelApellido2.TabIndex = 76;
            this.labelApellido2.Text = "Apellido";
            // 
            // labelCUIL2
            // 
            this.labelCUIL2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCUIL2.AutoSize = true;
            this.labelCUIL2.Font = new System.Drawing.Font("Myriad Pro Cond", 17.25F);
            this.labelCUIL2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.labelCUIL2.Location = new System.Drawing.Point(179, 54);
            this.labelCUIL2.Name = "labelCUIL2";
            this.labelCUIL2.Size = new System.Drawing.Size(45, 26);
            this.labelCUIL2.TabIndex = 77;
            this.labelCUIL2.Text = "CUIL";
            // 
            // labelDNI2
            // 
            this.labelDNI2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelDNI2.AutoSize = true;
            this.labelDNI2.Font = new System.Drawing.Font("Myriad Pro Cond", 17.25F);
            this.labelDNI2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.labelDNI2.Location = new System.Drawing.Point(30, 54);
            this.labelDNI2.Name = "labelDNI2";
            this.labelDNI2.Size = new System.Drawing.Size(38, 26);
            this.labelDNI2.TabIndex = 78;
            this.labelDNI2.Text = "DNI";
            // 
            // labelDireccion2
            // 
            this.labelDireccion2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelDireccion2.AutoSize = true;
            this.labelDireccion2.Font = new System.Drawing.Font("Myriad Pro Cond", 17.25F);
            this.labelDireccion2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.labelDireccion2.Location = new System.Drawing.Point(30, 231);
            this.labelDireccion2.Name = "labelDireccion2";
            this.labelDireccion2.Size = new System.Drawing.Size(76, 26);
            this.labelDireccion2.TabIndex = 79;
            this.labelDireccion2.Text = "Dirección";
            // 
            // labelArea2
            // 
            this.labelArea2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelArea2.AutoSize = true;
            this.labelArea2.Font = new System.Drawing.Font("Myriad Pro Cond", 17.25F);
            this.labelArea2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.labelArea2.Location = new System.Drawing.Point(30, 289);
            this.labelArea2.Name = "labelArea2";
            this.labelArea2.Size = new System.Drawing.Size(44, 26);
            this.labelArea2.TabIndex = 80;
            this.labelArea2.Text = "Área";
            // 
            // labelCargo2
            // 
            this.labelCargo2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCargo2.AutoSize = true;
            this.labelCargo2.Font = new System.Drawing.Font("Myriad Pro Cond", 17.25F);
            this.labelCargo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.labelCargo2.Location = new System.Drawing.Point(245, 289);
            this.labelCargo2.Name = "labelCargo2";
            this.labelCargo2.Size = new System.Drawing.Size(53, 26);
            this.labelCargo2.TabIndex = 81;
            this.labelCargo2.Text = "Cargo";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEliminar.BackColor = System.Drawing.Color.Red;
            this.buttonEliminar.FlatAppearance.BorderSize = 0;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.Font = new System.Drawing.Font("Myriad Pro Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.ForeColor = System.Drawing.Color.LightGray;
            this.buttonEliminar.Location = new System.Drawing.Point(210, 366);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 40);
            this.buttonEliminar.TabIndex = 84;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.buttonCancelar.FlatAppearance.BorderSize = 0;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Myriad Pro Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.ForeColor = System.Drawing.Color.LightGray;
            this.buttonCancelar.Location = new System.Drawing.Point(35, 366);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(150, 40);
            this.buttonCancelar.TabIndex = 83;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.buttonEditar.FlatAppearance.BorderSize = 0;
            this.buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditar.Font = new System.Drawing.Font("Myriad Pro Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditar.ForeColor = System.Drawing.Color.LightGray;
            this.buttonEditar.Location = new System.Drawing.Point(314, 366);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(150, 40);
            this.buttonEditar.TabIndex = 82;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Myriad Pro Cond", 12.25F);
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(375, 94);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 47);
            this.button1.TabIndex = 85;
            this.button1.Text = "Generar credencial";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(365, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 136);
            this.pictureBox1.TabIndex = 86;
            this.pictureBox1.TabStop = false;
            // 
            // imagen
            // 
            this.AcceptButton = this.btnCrear;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(500, 418);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.labelCargo2);
            this.Controls.Add(this.labelArea2);
            this.Controls.Add(this.labelDireccion2);
            this.Controls.Add(this.labelDNI2);
            this.Controls.Add(this.labelCUIL2);
            this.Controls.Add(this.labelApellido2);
            this.Controls.Add(this.labelNombre2);
            this.Controls.Add(this.labelFechaNacimiento2);
            this.Controls.Add(this.labelTelefono2);
            this.Controls.Add(this.textBoxTelefono2);
            this.Controls.Add(this.textBoxEdad2);
            this.Controls.Add(this.labelEdad2);
            this.Controls.Add(this.checkBoxEncargado);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.comboBoxArea);
            this.Controls.Add(this.labelCargo);
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
            this.Controls.Add(this.labelUsuariosAñadir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "imagen";
            this.Text = "UsuariosAñadir";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button button1;

        #endregion

        private System.Windows.Forms.Label labelUsuariosAñadir;
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
        private System.Windows.Forms.Label labelCargo;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.ComboBox comboBoxArea;
        private System.Windows.Forms.CheckBox checkBoxEncargado;
        private System.Windows.Forms.TextBox textBoxEdad2;
        private System.Windows.Forms.Label labelEdad2;
        private System.Windows.Forms.Label labelTelefono2;
        private System.Windows.Forms.TextBox textBoxTelefono2;
        private System.Windows.Forms.Label labelFechaNacimiento2;
        private System.Windows.Forms.Label labelNombre2;
        private System.Windows.Forms.Label labelApellido2;
        private System.Windows.Forms.Label labelCUIL2;
        private System.Windows.Forms.Label labelDNI2;
        private System.Windows.Forms.Label labelDireccion2;
        private System.Windows.Forms.Label labelArea2;
        private System.Windows.Forms.Label labelCargo2;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}