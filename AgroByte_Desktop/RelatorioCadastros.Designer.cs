namespace AgroByte_Desktop
{
    partial class RelatorioCadastros
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLblRelat = new System.Windows.Forms.Panel();
            this.logoRelatorio = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGerarRel = new System.Windows.Forms.Button();
            this.dataGridViewRel = new System.Windows.Forms.DataGridView();
            this.buttonExpRel = new System.Windows.Forms.Button();
            this.panelLblRelat.SuspendLayout();
            this.logoRelatorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRel)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLblRelat
            // 
            this.panelLblRelat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelLblRelat.Controls.Add(this.buttonExpRel);
            this.panelLblRelat.Controls.Add(this.buttonGerarRel);
            this.panelLblRelat.Controls.Add(this.label1);
            this.panelLblRelat.ForeColor = System.Drawing.Color.Black;
            this.panelLblRelat.Location = new System.Drawing.Point(234, 3);
            this.panelLblRelat.Name = "panelLblRelat";
            this.panelLblRelat.Size = new System.Drawing.Size(1056, 137);
            this.panelLblRelat.TabIndex = 0;
            // 
            // logoRelatorio
            // 
            this.logoRelatorio.Controls.Add(this.pictureBox1);
            this.logoRelatorio.Location = new System.Drawing.Point(0, 0);
            this.logoRelatorio.Name = "logoRelatorio";
            this.logoRelatorio.Size = new System.Drawing.Size(234, 140);
            this.logoRelatorio.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(136, 146);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::AgroByte_Desktop.Properties.Resources.download__1_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(221, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(523, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Relatório de Cadastros";
            // 
            // buttonGerarRel
            // 
            this.buttonGerarRel.BackColor = System.Drawing.Color.Green;
            this.buttonGerarRel.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGerarRel.ForeColor = System.Drawing.Color.Transparent;
            this.buttonGerarRel.Location = new System.Drawing.Point(6, 3);
            this.buttonGerarRel.Name = "buttonGerarRel";
            this.buttonGerarRel.Size = new System.Drawing.Size(190, 56);
            this.buttonGerarRel.TabIndex = 1;
            this.buttonGerarRel.Text = "Gerar Relatório";
            this.buttonGerarRel.UseVisualStyleBackColor = false;
            this.buttonGerarRel.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewRel
            // 
            this.dataGridViewRel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRel.Location = new System.Drawing.Point(3, 139);
            this.dataGridViewRel.Name = "dataGridViewRel";
            this.dataGridViewRel.RowHeadersWidth = 51;
            this.dataGridViewRel.RowTemplate.Height = 24;
            this.dataGridViewRel.Size = new System.Drawing.Size(1284, 506);
            this.dataGridViewRel.TabIndex = 3;
            // 
            // buttonExpRel
            // 
            this.buttonExpRel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonExpRel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExpRel.Location = new System.Drawing.Point(6, 65);
            this.buttonExpRel.Name = "buttonExpRel";
            this.buttonExpRel.Size = new System.Drawing.Size(190, 63);
            this.buttonExpRel.TabIndex = 2;
            this.buttonExpRel.Text = "Exportar ";
            this.buttonExpRel.UseVisualStyleBackColor = false;
            this.buttonExpRel.Click += new System.EventHandler(this.buttonExpRel_Click);
            // 
            // RelatorioCadastros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewRel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.logoRelatorio);
            this.Controls.Add(this.panelLblRelat);
            this.Name = "RelatorioCadastros";
            this.Size = new System.Drawing.Size(1290, 648);
            this.panelLblRelat.ResumeLayout(false);
            this.panelLblRelat.PerformLayout();
            this.logoRelatorio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLblRelat;
        private System.Windows.Forms.Panel logoRelatorio;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonGerarRel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonExpRel;
        private System.Windows.Forms.DataGridView dataGridViewRel;
    }
}
