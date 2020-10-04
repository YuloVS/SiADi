﻿namespace SiADi
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
            this.horarioEntrada = new System.Windows.Forms.DateTimePicker();
            this.horarioSalida = new System.Windows.Forms.DateTimePicker();
            this.labelSalario = new System.Windows.Forms.Label();
            this.textBoxSalario = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Myriad Pro Cond", 14.25F);
            this.textBoxNombre.Location = new System.Drawing.Point(245, 112);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNombre.MaxLength = 25;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(208, 36);
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
            this.btnLimpiar.Location = new System.Drawing.Point(61, 441);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(200, 49);
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
            this.btnCrear.Location = new System.Drawing.Point(411, 441);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(200, 49);
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
            this.labelHorario.Location = new System.Drawing.Point(220, 155);
            this.labelHorario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHorario.Name = "labelHorario";
            this.labelHorario.Size = new System.Drawing.Size(80, 33);
            this.labelHorario.TabIndex = 23;
            this.labelHorario.Text = "Horario";
            // 
            // labelNombre
            // 
            this.labelNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Myriad Pro Cond", 17.25F);
            this.labelNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.labelNombre.Location = new System.Drawing.Point(223, 81);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(87, 33);
            this.labelNombre.TabIndex = 21;
            this.labelNombre.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myriad Pro Cond", 20.25F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label4.Location = new System.Drawing.Point(275, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 38);
            this.label4.TabIndex = 20;
            this.label4.Text = "Nuevo Cargo";
            // 
            // labelA
            // 
            this.labelA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Myriad Pro Cond", 17.25F);
            this.labelA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.labelA.Location = new System.Drawing.Point(348, 178);
            this.labelA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(26, 33);
            this.labelA.TabIndex = 27;
            this.labelA.Text = "a";
            // 
            // labelArea
            // 
            this.labelArea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelArea.AutoSize = true;
            this.labelArea.Font = new System.Drawing.Font("Myriad Pro Cond", 17.25F);
            this.labelArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.labelArea.Location = new System.Drawing.Point(224, 245);
            this.labelArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(57, 33);
            this.labelArea.TabIndex = 28;
            this.labelArea.Text = "Área";
            // 
            // comboBoxArea
            // 
            this.comboBoxArea.Font = new System.Drawing.Font("Myriad Pro Cond", 14.25F);
            this.comboBoxArea.FormattingEnabled = true;
            this.comboBoxArea.Location = new System.Drawing.Point(245, 272);
            this.comboBoxArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxArea.Name = "comboBoxArea";
            this.comboBoxArea.Size = new System.Drawing.Size(121, 35);
            this.comboBoxArea.TabIndex = 3;
            // 
            // horarioEntrada
            // 
            this.horarioEntrada.Font = new System.Drawing.Font("Myriad Pro Cond", 14.25F);
            this.horarioEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.horarioEntrada.Location = new System.Drawing.Point(245, 186);
            this.horarioEntrada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.horarioEntrada.Name = "horarioEntrada";
            this.horarioEntrada.ShowUpDown = true;
            this.horarioEntrada.Size = new System.Drawing.Size(81, 36);
            this.horarioEntrada.TabIndex = 1;
            this.horarioEntrada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateTimePickerDesde_KeyPress);
            this.horarioEntrada.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePickerDesde_Validating);
            // 
            // horarioSalida
            // 
            this.horarioSalida.Font = new System.Drawing.Font("Myriad Pro Cond", 14.25F);
            this.horarioSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.horarioSalida.Location = new System.Drawing.Point(396, 186);
            this.horarioSalida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.horarioSalida.Name = "horarioSalida";
            this.horarioSalida.ShowUpDown = true;
            this.horarioSalida.Size = new System.Drawing.Size(81, 36);
            this.horarioSalida.TabIndex = 2;
            this.horarioSalida.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePickerHasta_Validating);
            // 
            // labelSalario
            // 
            this.labelSalario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSalario.AutoSize = true;
            this.labelSalario.Font = new System.Drawing.Font("Myriad Pro Cond", 17.25F);
            this.labelSalario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.labelSalario.Location = new System.Drawing.Point(224, 324);
            this.labelSalario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSalario.Name = "labelSalario";
            this.labelSalario.Size = new System.Drawing.Size(76, 33);
            this.labelSalario.TabIndex = 32;
            this.labelSalario.Text = "Salario";
            // 
            // textBoxSalario
            // 
            this.textBoxSalario.Font = new System.Drawing.Font("Myriad Pro Cond", 14.25F);
            this.textBoxSalario.Location = new System.Drawing.Point(245, 354);
            this.textBoxSalario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSalario.MaxLength = 6;
            this.textBoxSalario.Name = "textBoxSalario";
            this.textBoxSalario.Size = new System.Drawing.Size(128, 36);
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
            this.ClientSize = new System.Drawing.Size(667, 514);
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
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.DateTimePicker horarioEntrada;
        private System.Windows.Forms.DateTimePicker horarioSalida;
        private System.Windows.Forms.Label labelSalario;
        private System.Windows.Forms.TextBox textBoxSalario;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}