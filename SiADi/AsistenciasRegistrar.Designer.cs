namespace SiADi
{
    partial class AsistenciasRegistrar
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
            this.comboBoxCamara = new System.Windows.Forms.ComboBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.labelQR = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxCamara = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamara)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Pro Cond", 20.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label1.Location = new System.Drawing.Point(186, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registrar asistencia";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBoxCamara
            // 
            this.comboBoxCamara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.comboBoxCamara.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCamara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCamara.Font = new System.Drawing.Font("Myriad Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCamara.ForeColor = System.Drawing.Color.LightGray;
            this.comboBoxCamara.FormattingEnabled = true;
            this.comboBoxCamara.Location = new System.Drawing.Point(119, 59);
            this.comboBoxCamara.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCamara.Name = "comboBoxCamara";
            this.comboBoxCamara.Size = new System.Drawing.Size(294, 26);
            this.comboBoxCamara.TabIndex = 44;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Myriad Pro Cond", 14.25F);
            this.btnEnviar.ForeColor = System.Drawing.Color.LightGray;
            this.btnEnviar.Location = new System.Drawing.Point(175, 366);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(131, 40);
            this.btnEnviar.TabIndex = 45;
            this.btnEnviar.Text = "Activar escaneo";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // labelQR
            // 
            this.labelQR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelQR.AutoSize = true;
            this.labelQR.Font = new System.Drawing.Font("Myriad Pro Cond", 17.25F);
            this.labelQR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.labelQR.Location = new System.Drawing.Point(186, 387);
            this.labelQR.Name = "labelQR";
            this.labelQR.Size = new System.Drawing.Size(157, 26);
            this.labelQR.TabIndex = 46;
            this.labelQR.Text = "Escanee el codigo QR";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBoxCamara
            // 
            this.pictureBoxCamara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCamara.Location = new System.Drawing.Point(119, 90);
            this.pictureBoxCamara.Name = "pictureBoxCamara";
            this.pictureBoxCamara.Size = new System.Drawing.Size(294, 294);
            this.pictureBoxCamara.TabIndex = 47;
            this.pictureBoxCamara.TabStop = false;
            // 
            // AsistenciasRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(500, 418);
            this.Controls.Add(this.labelQR);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.comboBoxCamara);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxCamara);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AsistenciasRegistrar";
            this.Text = "AsistenciasRegistrar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AsistenciasRegistrar_FormClosing);
            this.Load += new System.EventHandler(this.AsistenciasRegistrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamara)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.PictureBox pictureBoxCamara;

        private System.Windows.Forms.Timer timer1;

        private System.Windows.Forms.Label labelQR;

        private System.Windows.Forms.Button btnEnviar;

        private System.Windows.Forms.ComboBox comboBoxCamara;

        #endregion

        private System.Windows.Forms.Label label1;
    }
}