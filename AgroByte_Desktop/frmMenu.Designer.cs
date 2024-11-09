namespace AgroByte_Desktop
{
    partial class frmMenu
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonSairAplic1 = new System.Windows.Forms.Button();
            this.buttonRelatorio = new System.Windows.Forms.Button();
            this.buttonCadastro = new System.Windows.Forms.Button();
            this.buttonFuncionario = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TelaInicial = new System.Windows.Forms.Button();
            this.principal21 = new AgroByte_Desktop.principal2();
            this.frmFuncionario1 = new AgroByte_Desktop.frmFuncionario();
            this.fmlCadastro1 = new AgroByte_Desktop.fmlCadastro();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelMenu.Controls.Add(this.TelaInicial);
            this.panelMenu.Controls.Add(this.buttonSairAplic1);
            this.panelMenu.Controls.Add(this.buttonRelatorio);
            this.panelMenu.Controls.Add(this.buttonCadastro);
            this.panelMenu.Controls.Add(this.buttonFuncionario);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 884);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonSairAplic1
            // 
            this.buttonSairAplic1.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonSairAplic1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSairAplic1.Image = global::AgroByte_Desktop.Properties.Resources.icons8_exit_28;
            this.buttonSairAplic1.Location = new System.Drawing.Point(3, 488);
            this.buttonSairAplic1.Name = "buttonSairAplic1";
            this.buttonSairAplic1.Size = new System.Drawing.Size(214, 40);
            this.buttonSairAplic1.TabIndex = 8;
            this.buttonSairAplic1.Text = "Sair";
            this.buttonSairAplic1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSairAplic1.UseVisualStyleBackColor = false;
            this.buttonSairAplic1.Click += new System.EventHandler(this.buttonSairAplic1_Click);
            // 
            // buttonRelatorio
            // 
            this.buttonRelatorio.BackColor = System.Drawing.Color.Green;
            this.buttonRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRelatorio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRelatorio.Image = global::AgroByte_Desktop.Properties.Resources.icons8_graph_report_28;
            this.buttonRelatorio.Location = new System.Drawing.Point(6, 258);
            this.buttonRelatorio.Name = "buttonRelatorio";
            this.buttonRelatorio.Size = new System.Drawing.Size(214, 40);
            this.buttonRelatorio.TabIndex = 3;
            this.buttonRelatorio.Text = "Relatório";
            this.buttonRelatorio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRelatorio.UseVisualStyleBackColor = false;
            // 
            // buttonCadastro
            // 
            this.buttonCadastro.BackColor = System.Drawing.Color.Green;
            this.buttonCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadastro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCadastro.Image = global::AgroByte_Desktop.Properties.Resources.icons8_task_30__1_;
            this.buttonCadastro.Location = new System.Drawing.Point(6, 216);
            this.buttonCadastro.Name = "buttonCadastro";
            this.buttonCadastro.Size = new System.Drawing.Size(214, 40);
            this.buttonCadastro.TabIndex = 2;
            this.buttonCadastro.Text = "Cadastro";
            this.buttonCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCadastro.UseVisualStyleBackColor = false;
            this.buttonCadastro.Click += new System.EventHandler(this.buttonCadastro_Click);
            // 
            // buttonFuncionario
            // 
            this.buttonFuncionario.AutoSize = true;
            this.buttonFuncionario.BackColor = System.Drawing.Color.Green;
            this.buttonFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFuncionario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFuncionario.Image = global::AgroByte_Desktop.Properties.Resources.icons8_customer_30;
            this.buttonFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFuncionario.Location = new System.Drawing.Point(6, 177);
            this.buttonFuncionario.Name = "buttonFuncionario";
            this.buttonFuncionario.Size = new System.Drawing.Size(214, 40);
            this.buttonFuncionario.TabIndex = 1;
            this.buttonFuncionario.Text = "Funcionário";
            this.buttonFuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonFuncionario.UseVisualStyleBackColor = false;
            this.buttonFuncionario.Click += new System.EventHandler(this.buttonFuncionario_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelLogo.BackgroundImage = global::AgroByte_Desktop.Properties.Resources.download__1_;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 171);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fmlCadastro1);
            this.panel1.Controls.Add(this.frmFuncionario1);
            this.panel1.Controls.Add(this.principal21);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(220, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1097, 884);
            this.panel1.TabIndex = 1;
            // 
            // TelaInicial
            // 
            this.TelaInicial.BackColor = System.Drawing.Color.Green;
            this.TelaInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelaInicial.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TelaInicial.Image = global::AgroByte_Desktop.Properties.Resources.icons8_graph_report_28;
            this.TelaInicial.Location = new System.Drawing.Point(6, 347);
            this.TelaInicial.Name = "TelaInicial";
            this.TelaInicial.Size = new System.Drawing.Size(214, 40);
            this.TelaInicial.TabIndex = 9;
            this.TelaInicial.Text = "Tela Inicial";
            this.TelaInicial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TelaInicial.UseVisualStyleBackColor = false;
            this.TelaInicial.Click += new System.EventHandler(this.TelaInicial_Click);
            // 
            // principal21
            // 
            this.principal21.AutoSize = true;
            this.principal21.Location = new System.Drawing.Point(0, 0);
            this.principal21.Margin = new System.Windows.Forms.Padding(4);
            this.principal21.Name = "principal21";
            this.principal21.Size = new System.Drawing.Size(1110, 965);
            this.principal21.TabIndex = 0;
            // 
            // frmFuncionario1
            // 
            this.frmFuncionario1.AutoSize = true;
            this.frmFuncionario1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmFuncionario1.Location = new System.Drawing.Point(0, 0);
            this.frmFuncionario1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.frmFuncionario1.Name = "frmFuncionario1";
            this.frmFuncionario1.Size = new System.Drawing.Size(1125, 700);
            this.frmFuncionario1.TabIndex = 1;
            // 
            // fmlCadastro1
            // 
            this.fmlCadastro1.AutoSize = true;
            this.fmlCadastro1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmlCadastro1.Location = new System.Drawing.Point(0, 0);
            this.fmlCadastro1.Margin = new System.Windows.Forms.Padding(4);
            this.fmlCadastro1.Name = "fmlCadastro1";
            this.fmlCadastro1.Size = new System.Drawing.Size(1057, 721);
            this.fmlCadastro1.TabIndex = 2;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1317, 884);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonFuncionario;
        private System.Windows.Forms.Button buttonRelatorio;
        private System.Windows.Forms.Button buttonCadastro;
        private System.Windows.Forms.Button buttonSairAplic1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button TelaInicial;
        private fmlCadastro fmlCadastro1;
        private frmFuncionario frmFuncionario1;
        private principal2 principal21;
    }
}