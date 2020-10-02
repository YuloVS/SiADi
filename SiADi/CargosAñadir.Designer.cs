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
            this.label4 = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.labelArea = new System.Windows.Forms.Label();
            this.comboBoxArea = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDesde = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerHasta = new System.Windows.Forms.DateTimePicker();
            this.labelSalario = new System.Windows.Forms.Label();
            this.textBoxSalario = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(246, 112);
            this.textBoxNombre.MaxLength = 25;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(208, 22);
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
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.LightGray;
            this.btnLimpiar.Location = new System.Drawing.Point(62, 441);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(200, 49);
            this.btnLimpiar.TabIndex = 25;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnCrear
            // 
            this.btnCrear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.btnCrear.FlatAppearance.BorderSize = 0;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.Color.LightGray;
            this.btnCrear.Location = new System.Drawing.Point(410, 441);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(200, 49);
            this.btnCrear.TabIndex = 24;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = false;
            // 
            // labelHorario
            // 
            this.labelHorario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelHorario.AutoSize = true;
            this.labelHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHorario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.labelHorario.Location = new System.Drawing.Point(231, 154);
            this.labelHorario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHorario.Name = "labelHorario";
            this.labelHorario.Size = new System.Drawing.Size(93, 29);
            this.labelHorario.TabIndex = 23;
            this.labelHorario.Text = "Horario";
            // 
            // labelNombre
            // 
            this.labelNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.labelNombre.Location = new System.Drawing.Point(235, 80);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(101, 29);
            this.labelNombre.TabIndex = 21;
            this.labelNombre.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label4.Location = new System.Drawing.Point(261, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 29);
            this.label4.TabIndex = 20;
            this.label4.Text = "Nuevo Cargo";
            // 
            // labelA
            // 
            this.labelA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.labelA.Location = new System.Drawing.Point(348, 179);
            this.labelA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(26, 29);
            this.labelA.TabIndex = 27;
            this.labelA.Text = "a";
            // 
            // labelArea
            // 
            this.labelArea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelArea.AutoSize = true;
            this.labelArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.labelArea.Location = new System.Drawing.Point(235, 240);
            this.labelArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(63, 29);
            this.labelArea.TabIndex = 28;
            this.labelArea.Text = "Área";
            // 
            // comboBoxArea
            // 
            this.comboBoxArea.FormattingEnabled = true;
            this.comboBoxArea.Location = new System.Drawing.Point(246, 272);
            this.comboBoxArea.Name = "comboBoxArea";
            this.comboBoxArea.Size = new System.Drawing.Size(121, 24);
            this.comboBoxArea.TabIndex = 3;
            // 
            // dateTimePickerDesde
            // 
            this.dateTimePickerDesde.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerDesde.Location = new System.Drawing.Point(246, 186);
            this.dateTimePickerDesde.Name = "dateTimePickerDesde";
            this.dateTimePickerDesde.ShowUpDown = true;
            this.dateTimePickerDesde.Size = new System.Drawing.Size(82, 22);
            this.dateTimePickerDesde.TabIndex = 1;
            this.dateTimePickerDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateTimePickerDesde_KeyPress);
            this.dateTimePickerDesde.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePickerDesde_Validating);
            // 
            // dateTimePickerHasta
            // 
            this.dateTimePickerHasta.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerHasta.Location = new System.Drawing.Point(396, 186);
            this.dateTimePickerHasta.Name = "dateTimePickerHasta";
            this.dateTimePickerHasta.ShowUpDown = true;
            this.dateTimePickerHasta.Size = new System.Drawing.Size(82, 22);
            this.dateTimePickerHasta.TabIndex = 2;
            this.dateTimePickerHasta.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePickerHasta_Validating);
            // 
            // labelSalario
            // 
            this.labelSalario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSalario.AutoSize = true;
            this.labelSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.labelSalario.Location = new System.Drawing.Point(235, 322);
            this.labelSalario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSalario.Name = "labelSalario";
            this.labelSalario.Size = new System.Drawing.Size(89, 29);
            this.labelSalario.TabIndex = 32;
            this.labelSalario.Text = "Salario";
            // 
            // textBoxSalario
            // 
            this.textBoxSalario.Location = new System.Drawing.Point(246, 354);
            this.textBoxSalario.MaxLength = 6;
            this.textBoxSalario.Name = "textBoxSalario";
            this.textBoxSalario.Size = new System.Drawing.Size(128, 22);
            this.textBoxSalario.TabIndex = 4;
            this.textBoxSalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSalario_KeyPress);
            this.textBoxSalario.Validated += new System.EventHandler(this.textBoxSalario_Validated);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CargosAñadir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(666, 514);
            this.Controls.Add(this.textBoxSalario);
            this.Controls.Add(this.labelSalario);
            this.Controls.Add(this.dateTimePickerHasta);
            this.Controls.Add(this.dateTimePickerDesde);
            this.Controls.Add(this.comboBoxArea);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.labelHorario);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.ComboBox comboBoxArea;
        private System.Windows.Forms.DateTimePicker dateTimePickerDesde;
        private System.Windows.Forms.DateTimePicker dateTimePickerHasta;
        private System.Windows.Forms.Label labelSalario;
        private System.Windows.Forms.TextBox textBoxSalario;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}