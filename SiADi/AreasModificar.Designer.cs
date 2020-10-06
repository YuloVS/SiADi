namespace SiADi
{
    partial class AreasModificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AreasModificar));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewAreas = new System.Windows.Forms.DataGridView();
            this.textBoxFiltro = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAreas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Pro Cond", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label1.Location = new System.Drawing.Point(257, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Modificar áreas";
            // 
            // dataGridViewAreas
            // 
            this.dataGridViewAreas.AllowUserToOrderColumns = true;
            this.dataGridViewAreas.AllowUserToResizeRows = false;
            this.dataGridViewAreas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAreas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dataGridViewAreas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAreas.Location = new System.Drawing.Point(87, 149);
            this.dataGridViewAreas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewAreas.Name = "dataGridViewAreas";
            this.dataGridViewAreas.RowHeadersWidth = 51;
            this.dataGridViewAreas.Size = new System.Drawing.Size(535, 351);
            this.dataGridViewAreas.TabIndex = 3;
            this.dataGridViewAreas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBoxFiltro
            // 
            this.textBoxFiltro.Font = new System.Drawing.Font("Myriad Pro Cond", 14.25F);
            this.textBoxFiltro.Location = new System.Drawing.Point(241, 65);
            this.textBoxFiltro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFiltro.Name = "textBoxFiltro";
            this.textBoxFiltro.Size = new System.Drawing.Size(208, 36);
            this.textBoxFiltro.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(459, 59);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 36);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AreasModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(667, 514);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxFiltro);
            this.Controls.Add(this.dataGridViewAreas);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AreasModificar";
            this.Text = "AreasModificar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAreas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewAreas;
        private System.Windows.Forms.TextBox textBoxFiltro;
        private System.Windows.Forms.Button button1;
    }
}