namespace SiADi
{
    partial class CargosAñadir
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
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.labelHorario = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.LabelCargosAñadir = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.labelArea = new System.Windows.Forms.Label();
            this.comboBoxArea = new System.Windows.Forms.ComboBox();
            this.horarioEntrada = new System.Windows.Forms.DateTimePicker();
            this.horarioSalida = new System.Windows.Forms.DateTimePicker();
            this.labelSalario = new System.Windows.Forms.Label();
            this.textBoxSalario = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNombre.Font = new System.Drawing.Font("Myriad Pro Cond", 14.25F);
            this.textBoxNombre.Location = new System.Drawing.Point(184, 91);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNombre.MaxLength = 25;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(157, 23);
            this.textBoxNombre.TabIndex = 0;
            this.textBoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombre_KeyPress);
            this.textBoxNombre.Validated += new System.EventHandler(this.textBoxNombre_Validated);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Myriad Pro Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.LightGray;
            this.btnLimpiar.Location = new System.Drawing.Point(46, 358);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(150, 40);
            this.btnLimpiar.TabIndex = 25;
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
            this.btnCrear.Font = new System.Drawing.Font("Myriad Pro Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.Color.LightGray;
            this.btnCrear.Location = new System.Drawing.Point(308, 358);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(150, 40);
            this.btnCrear.TabIndex = 24;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // labelHorario
            // 
            this.labelHorario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelHorario.AutoSize = true;
            this.labelHorario.Font = new System.Drawing.Font("Myriad Pro Cond", 17.25F);
            this.labelHorario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.labelHorario.Location = new System.Drawing.Point(165, 126);
            this.labelHorario.Name = "labelHorario";
            this.labelHorario.Size = new System.Drawing.Size(65, 26);
            this.labelHorario.TabIndex = 23;
            this.labelHorario.Text = "Horario";
            // 
            // labelNombre
            // 
            this.labelNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Myriad Pro Cond", 17.25F);
            this.labelNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.labelNombre.Location = new System.Drawing.Point(167, 66);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(69, 26);
            this.labelNombre.TabIndex = 21;
            this.labelNombre.Text = "Nombre";
            // 
            // LabelCargosAñadir
            // 
            this.LabelCargosAñadir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelCargosAñadir.AutoSize = true;
            this.LabelCargosAñadir.Font = new System.Drawing.Font("Myriad Pro Cond", 20.25F);
            this.LabelCargosAñadir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.LabelCargosAñadir.Location = new System.Drawing.Point(206, 9);
            this.LabelCargosAñadir.Name = "LabelCargosAñadir";
            this.LabelCargosAñadir.Size = new System.Drawing.Size(118, 30);
            this.LabelCargosAñadir.TabIndex = 20;
            this.LabelCargosAñadir.Text = "Nuevo Cargo";
            // 
            // labelA
            // 
            this.labelA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Myriad Pro Cond", 17.25F);
            this.labelA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.labelA.Location = new System.Drawing.Point(251, 151);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(20, 26);
            this.labelA.TabIndex = 27;
            this.labelA.Text = "a";
            // 
            // labelArea
            // 
            this.labelArea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelArea.AutoSize = true;
            this.labelArea.Font = new System.Drawing.Font("Myriad Pro Cond", 17.25F);
            this.labelArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.labelArea.Location = new System.Drawing.Point(168, 199);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(44, 26);
            this.labelArea.TabIndex = 28;
            this.labelArea.Text = "Área";
            // 
            // comboBoxArea
            // 
            this.comboBoxArea.Font = new System.Drawing.Font("Myriad Pro Cond", 14.25F);
            this.comboBoxArea.FormattingEnabled = true;
            this.comboBoxArea.Location = new System.Drawing.Point(184, 221);
            this.comboBoxArea.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxArea.Name = "comboBoxArea";
            this.comboBoxArea.Size = new System.Drawing.Size(92, 29);
            this.comboBoxArea.TabIndex = 3;
            // 
            // horarioEntrada
            // 
            this.horarioEntrada.Font = new System.Drawing.Font("Myriad Pro Cond", 14.25F);
            this.horarioEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.horarioEntrada.Location = new System.Drawing.Point(184, 151);
            this.horarioEntrada.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.horarioEntrada.Name = "horarioEntrada";
            this.horarioEntrada.ShowUpDown = true;
            this.horarioEntrada.Size = new System.Drawing.Size(62, 30);
            this.horarioEntrada.TabIndex = 1;
            this.horarioEntrada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateTimePickerDesde_KeyPress);
            this.horarioEntrada.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePickerDesde_Validating);
            // 
            // horarioSalida
            // 
            this.horarioSalida.Font = new System.Drawing.Font("Myriad Pro Cond", 14.25F);
            this.horarioSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.horarioSalida.Location = new System.Drawing.Point(297, 151);
            this.horarioSalida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.horarioSalida.Name = "horarioSalida";
            this.horarioSalida.ShowUpDown = true;
            this.horarioSalida.Size = new System.Drawing.Size(62, 30);
            this.horarioSalida.TabIndex = 2;
            this.horarioSalida.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePickerHasta_Validating);
            // 
            // labelSalario
            // 
            this.labelSalario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSalario.AutoSize = true;
            this.labelSalario.Font = new System.Drawing.Font("Myriad Pro Cond", 17.25F);
            this.labelSalario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.labelSalario.Location = new System.Drawing.Point(168, 263);
            this.labelSalario.Name = "labelSalario";
            this.labelSalario.Size = new System.Drawing.Size(59, 26);
            this.labelSalario.TabIndex = 32;
            this.labelSalario.Text = "Salario";
            // 
            // textBoxSalario
            // 
            this.textBoxSalario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSalario.Font = new System.Drawing.Font("Myriad Pro Cond", 14.25F);
            this.textBoxSalario.Location = new System.Drawing.Point(184, 288);
            this.textBoxSalario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSalario.MaxLength = 6;
            this.textBoxSalario.Name = "textBoxSalario";
            this.textBoxSalario.Size = new System.Drawing.Size(97, 23);
            this.textBoxSalario.TabIndex = 4;
            this.textBoxSalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSalario_KeyPress);
            this.textBoxSalario.Validated += new System.EventHandler(this.textBoxSalario_Validated);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEliminar.BackColor = System.Drawing.Color.Red;
            this.buttonEliminar.FlatAppearance.BorderSize = 0;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.Font = new System.Drawing.Font("Myriad Pro Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.ForeColor = System.Drawing.Color.LightGray;
            this.buttonEliminar.Location = new System.Drawing.Point(221, 358);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 40);
            this.buttonEliminar.TabIndex = 35;
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
            this.buttonCancelar.Location = new System.Drawing.Point(37, 358);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(150, 40);
            this.buttonCancelar.TabIndex = 34;
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
            this.buttonEditar.Location = new System.Drawing.Point(313, 358);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(150, 40);
            this.buttonEditar.TabIndex = 33;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = false;
            // 
            // CargosAñadir
            // 
            this.AcceptButton = this.btnCrear;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(500, 418);
            this.ControlBox = false;
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.textBoxSalario);
            this.Controls.Add(this.labelSalario);
            this.Controls.Add(this.horarioSalida);
            this.Controls.Add(this.horarioEntrada);
            this.Controls.Add(this.comboBoxArea);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.labelHorario);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.LabelCargosAñadir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CargosAñadir";
            this.Text = "CargosAñadir";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label labelHorario;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label LabelCargosAñadir;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.ComboBox comboBoxArea;
        private System.Windows.Forms.DateTimePicker horarioEntrada;
        private System.Windows.Forms.DateTimePicker horarioSalida;
        private System.Windows.Forms.Label labelSalario;
        private System.Windows.Forms.TextBox textBoxSalario;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonEditar;
    }
}