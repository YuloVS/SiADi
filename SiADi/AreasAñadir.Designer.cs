namespace SiADi
{
    partial class AreasAñadir
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
            this.LabelAreasAñadir = new System.Windows.Forms.Label();
            this.NombreAreasAñadir = new System.Windows.Forms.Label();
            this.TextboxDescipcionAreasAñadir = new System.Windows.Forms.RichTextBox();
            this.DescripcionAreasAñadir = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.TextboxNombreAreasAñadir = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelAreasAñadir
            // 
            this.LabelAreasAñadir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelAreasAñadir.AutoSize = true;
            this.LabelAreasAñadir.Font = new System.Drawing.Font("Myriad Pro Cond", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAreasAñadir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.LabelAreasAñadir.Location = new System.Drawing.Point(208, 9);
            this.LabelAreasAñadir.Name = "LabelAreasAñadir";
            this.LabelAreasAñadir.Size = new System.Drawing.Size(109, 30);
            this.LabelAreasAñadir.TabIndex = 2;
            this.LabelAreasAñadir.Text = "Nueva Área";
            this.LabelAreasAñadir.Click += new System.EventHandler(this.LabelAreasAñadir_Click);
            // 
            // NombreAreasAñadir
            // 
            this.NombreAreasAñadir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NombreAreasAñadir.AutoSize = true;
            this.NombreAreasAñadir.Font = new System.Drawing.Font("Myriad Pro Cond", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreAreasAñadir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.NombreAreasAñadir.Location = new System.Drawing.Point(126, 65);
            this.NombreAreasAñadir.Name = "NombreAreasAñadir";
            this.NombreAreasAñadir.Size = new System.Drawing.Size(69, 26);
            this.NombreAreasAñadir.TabIndex = 4;
            this.NombreAreasAñadir.Text = "Nombre";
            // 
            // TextboxDescipcionAreasAñadir
            // 
            this.TextboxDescipcionAreasAñadir.Font = new System.Drawing.Font("Myriad Pro Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxDescipcionAreasAñadir.Location = new System.Drawing.Point(144, 191);
            this.TextboxDescipcionAreasAñadir.Margin = new System.Windows.Forms.Padding(2);
            this.TextboxDescipcionAreasAñadir.MaxLength = 100;
            this.TextboxDescipcionAreasAñadir.Name = "TextboxDescipcionAreasAñadir";
            this.TextboxDescipcionAreasAñadir.Size = new System.Drawing.Size(248, 126);
            this.TextboxDescipcionAreasAñadir.TabIndex = 5;
            this.TextboxDescipcionAreasAñadir.Text = "";
            this.TextboxDescipcionAreasAñadir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextboxDescipcionAreasAñadir_KeyPress);
            // 
            // DescripcionAreasAñadir
            // 
            this.DescripcionAreasAñadir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DescripcionAreasAñadir.AutoSize = true;
            this.DescripcionAreasAñadir.Font = new System.Drawing.Font("Myriad Pro Cond", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionAreasAñadir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.DescripcionAreasAñadir.Location = new System.Drawing.Point(125, 165);
            this.DescripcionAreasAñadir.Name = "DescripcionAreasAñadir";
            this.DescripcionAreasAñadir.Size = new System.Drawing.Size(92, 26);
            this.DescripcionAreasAñadir.TabIndex = 6;
            this.DescripcionAreasAñadir.Text = "Descripción";
            // 
            // btnCrear
            // 
            this.btnCrear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.btnCrear.FlatAppearance.BorderSize = 0;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("Myriad Pro Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.Color.LightGray;
            this.btnCrear.Location = new System.Drawing.Point(298, 367);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(150, 40);
            this.btnCrear.TabIndex = 17;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Myriad Pro Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.LightGray;
            this.btnLimpiar.Location = new System.Drawing.Point(55, 367);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(150, 40);
            this.btnLimpiar.TabIndex = 18;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // TextboxNombreAreasAñadir
            // 
            this.TextboxNombreAreasAñadir.Font = new System.Drawing.Font("Myriad Pro Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxNombreAreasAñadir.Location = new System.Drawing.Point(144, 88);
            this.TextboxNombreAreasAñadir.Margin = new System.Windows.Forms.Padding(2);
            this.TextboxNombreAreasAñadir.MaxLength = 30;
            this.TextboxNombreAreasAñadir.Name = "TextboxNombreAreasAñadir";
            this.TextboxNombreAreasAñadir.Size = new System.Drawing.Size(157, 30);
            this.TextboxNombreAreasAñadir.TabIndex = 19;
            this.TextboxNombreAreasAñadir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextboxNombreAreasAñadir_KeyPress);
            this.TextboxNombreAreasAñadir.Validated += new System.EventHandler(this.TextboxNombreAreasAñadir_Validated);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AreasAñadir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(500, 418);
            this.Controls.Add(this.TextboxNombreAreasAñadir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.DescripcionAreasAñadir);
            this.Controls.Add(this.TextboxDescipcionAreasAñadir);
            this.Controls.Add(this.NombreAreasAñadir);
            this.Controls.Add(this.LabelAreasAñadir);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AreasAñadir";
            this.Text = "AreasAñadir";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelAreasAñadir;
        private System.Windows.Forms.Label NombreAreasAñadir;
        private System.Windows.Forms.RichTextBox TextboxDescipcionAreasAñadir;
        private System.Windows.Forms.Label DescripcionAreasAñadir;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox TextboxNombreAreasAñadir;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}