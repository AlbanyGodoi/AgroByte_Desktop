namespace AgroByte_Desktop
{
    partial class frmFuncionario
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
            this.lblfunc = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLoginFunc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPesquisaFunc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSenhaFunc = new System.Windows.Forms.TextBox();
            this.dataGridFunc = new System.Windows.Forms.DataGridView();
            this.groupBoxPesquisaFunc = new System.Windows.Forms.GroupBox();
            this.txtNomeFunc = new System.Windows.Forms.TextBox();
            this.lblCodigoFunc = new System.Windows.Forms.Label();
            this.lblCoc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radStAtivo = new System.Windows.Forms.RadioButton();
            this.radStInativo = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUsuariologado = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCancelarFunc = new System.Windows.Forms.Button();
            this.buttonExcluirFunc = new System.Windows.Forms.Button();
            this.buttonEditarFunc = new System.Windows.Forms.Button();
            this.buttonSalvarFunc = new System.Windows.Forms.Button();
            this.buttonNovoFunc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFunc)).BeginInit();
            this.groupBoxPesquisaFunc.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblfunc
            // 
            this.lblfunc.AutoSize = true;
            this.lblfunc.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfunc.ForeColor = System.Drawing.Color.Green;
            this.lblfunc.Location = new System.Drawing.Point(456, 37);
            this.lblfunc.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblfunc.Name = "lblfunc";
            this.lblfunc.Size = new System.Drawing.Size(267, 51);
            this.lblfunc.TabIndex = 0;
            this.lblfunc.Text = "Funcionário";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(24, 121);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(99, 27);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código:";
            this.lblCodigo.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 229);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Login:";
            // 
            // txtLoginFunc
            // 
            this.txtLoginFunc.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginFunc.Location = new System.Drawing.Point(150, 226);
            this.txtLoginFunc.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtLoginFunc.MaxLength = 19;
            this.txtLoginFunc.Name = "txtLoginFunc";
            this.txtLoginFunc.Size = new System.Drawing.Size(469, 34);
            this.txtLoginFunc.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 180);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome:";
            // 
            // txtPesquisaFunc
            // 
            this.txtPesquisaFunc.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaFunc.Location = new System.Drawing.Point(63, 55);
            this.txtPesquisaFunc.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtPesquisaFunc.MaxLength = 60;
            this.txtPesquisaFunc.Name = "txtPesquisaFunc";
            this.txtPesquisaFunc.Size = new System.Drawing.Size(651, 34);
            this.txtPesquisaFunc.TabIndex = 5;
            this.txtPesquisaFunc.TextChanged += new System.EventHandler(this.txtPesquisaFunc_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 278);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Senha:";
            // 
            // txtSenhaFunc
            // 
            this.txtSenhaFunc.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaFunc.Location = new System.Drawing.Point(150, 275);
            this.txtSenhaFunc.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtSenhaFunc.MaxLength = 10;
            this.txtSenhaFunc.Name = "txtSenhaFunc";
            this.txtSenhaFunc.Size = new System.Drawing.Size(469, 34);
            this.txtSenhaFunc.TabIndex = 7;
            this.txtSenhaFunc.UseSystemPasswordChar = true;
            // 
            // dataGridFunc
            // 
            this.dataGridFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFunc.Location = new System.Drawing.Point(31, 531);
            this.dataGridFunc.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dataGridFunc.MultiSelect = false;
            this.dataGridFunc.Name = "dataGridFunc";
            this.dataGridFunc.RowHeadersWidth = 51;
            this.dataGridFunc.RowTemplate.Height = 24;
            this.dataGridFunc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridFunc.Size = new System.Drawing.Size(812, 96);
            this.dataGridFunc.TabIndex = 8;
            this.dataGridFunc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridFunc_CellContentClick);
            this.dataGridFunc.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridFunc_MouseDoubleClick);
            // 
            // groupBoxPesquisaFunc
            // 
            this.groupBoxPesquisaFunc.Controls.Add(this.txtPesquisaFunc);
            this.groupBoxPesquisaFunc.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPesquisaFunc.Location = new System.Drawing.Point(31, 384);
            this.groupBoxPesquisaFunc.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBoxPesquisaFunc.Name = "groupBoxPesquisaFunc";
            this.groupBoxPesquisaFunc.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBoxPesquisaFunc.Size = new System.Drawing.Size(812, 138);
            this.groupBoxPesquisaFunc.TabIndex = 9;
            this.groupBoxPesquisaFunc.TabStop = false;
            this.groupBoxPesquisaFunc.Text = "Pesquisa por Funcionário";
            // 
            // txtNomeFunc
            // 
            this.txtNomeFunc.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFunc.Location = new System.Drawing.Point(150, 177);
            this.txtNomeFunc.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtNomeFunc.MaxLength = 19;
            this.txtNomeFunc.Name = "txtNomeFunc";
            this.txtNomeFunc.Size = new System.Drawing.Size(679, 34);
            this.txtNomeFunc.TabIndex = 10;
            // 
            // lblCodigoFunc
            // 
            this.lblCodigoFunc.AutoSize = true;
            this.lblCodigoFunc.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblCodigoFunc.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoFunc.Location = new System.Drawing.Point(228, 168);
            this.lblCodigoFunc.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCodigoFunc.Name = "lblCodigoFunc";
            this.lblCodigoFunc.Size = new System.Drawing.Size(0, 32);
            this.lblCodigoFunc.TabIndex = 16;
            this.lblCodigoFunc.Visible = false;
            // 
            // lblCoc
            // 
            this.lblCoc.AutoSize = true;
            this.lblCoc.Location = new System.Drawing.Point(172, 125);
            this.lblCoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoc.Name = "lblCoc";
            this.lblCoc.Size = new System.Drawing.Size(0, 28);
            this.lblCoc.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 336);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Status:";
            // 
            // radStAtivo
            // 
            this.radStAtivo.AutoSize = true;
            this.radStAtivo.Checked = true;
            this.radStAtivo.Location = new System.Drawing.Point(150, 331);
            this.radStAtivo.Margin = new System.Windows.Forms.Padding(4);
            this.radStAtivo.Name = "radStAtivo";
            this.radStAtivo.Size = new System.Drawing.Size(89, 32);
            this.radStAtivo.TabIndex = 19;
            this.radStAtivo.TabStop = true;
            this.radStAtivo.Text = "Ativo";
            this.radStAtivo.UseVisualStyleBackColor = true;
            this.radStAtivo.CheckedChanged += new System.EventHandler(this.radStAtivo_CheckedChanged);
            // 
            // radStInativo
            // 
            this.radStInativo.AutoSize = true;
            this.radStInativo.Location = new System.Drawing.Point(261, 331);
            this.radStInativo.Name = "radStInativo";
            this.radStInativo.Size = new System.Drawing.Size(107, 32);
            this.radStInativo.TabIndex = 20;
            this.radStInativo.Text = "Inativo";
            this.radStInativo.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblUsuariologado);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(31, 477);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 220);
            this.panel1.TabIndex = 21;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblUsuariologado
            // 
            this.lblUsuariologado.AutoSize = true;
            this.lblUsuariologado.ForeColor = System.Drawing.Color.Red;
            this.lblUsuariologado.Location = new System.Drawing.Point(43, 72);
            this.lblUsuariologado.Name = "lblUsuariologado";
            this.lblUsuariologado.Size = new System.Drawing.Size(0, 28);
            this.lblUsuariologado.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Usuário Logado:";
            // 
            // buttonCancelarFunc
            // 
            this.buttonCancelarFunc.AutoSize = true;
            this.buttonCancelarFunc.BackColor = System.Drawing.SystemColors.Info;
            this.buttonCancelarFunc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarFunc.Image = global::AgroByte_Desktop.Properties.Resources.icons8_cancelar_30;
            this.buttonCancelarFunc.Location = new System.Drawing.Point(892, 544);
            this.buttonCancelarFunc.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.buttonCancelarFunc.Name = "buttonCancelarFunc";
            this.buttonCancelarFunc.Size = new System.Drawing.Size(227, 72);
            this.buttonCancelarFunc.TabIndex = 15;
            this.buttonCancelarFunc.Text = "Cancelar";
            this.buttonCancelarFunc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancelarFunc.UseVisualStyleBackColor = false;
            this.buttonCancelarFunc.Click += new System.EventHandler(this.buttonCancelarFunc_Click);
            // 
            // buttonExcluirFunc
            // 
            this.buttonExcluirFunc.BackColor = System.Drawing.Color.Salmon;
            this.buttonExcluirFunc.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluirFunc.Image = global::AgroByte_Desktop.Properties.Resources.icons8_bloqueado_30;
            this.buttonExcluirFunc.Location = new System.Drawing.Point(892, 439);
            this.buttonExcluirFunc.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.buttonExcluirFunc.Name = "buttonExcluirFunc";
            this.buttonExcluirFunc.Size = new System.Drawing.Size(227, 72);
            this.buttonExcluirFunc.TabIndex = 14;
            this.buttonExcluirFunc.Text = "Confirmar funcionario INATIVO";
            this.buttonExcluirFunc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonExcluirFunc.UseVisualStyleBackColor = false;
            this.buttonExcluirFunc.Click += new System.EventHandler(this.buttonExcluirFunc_Click);
            // 
            // buttonEditarFunc
            // 
            this.buttonEditarFunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonEditarFunc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditarFunc.Image = global::AgroByte_Desktop.Properties.Resources.icons8_edit_28;
            this.buttonEditarFunc.Location = new System.Drawing.Point(892, 348);
            this.buttonEditarFunc.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.buttonEditarFunc.Name = "buttonEditarFunc";
            this.buttonEditarFunc.Size = new System.Drawing.Size(227, 72);
            this.buttonEditarFunc.TabIndex = 13;
            this.buttonEditarFunc.Text = "Editar ";
            this.buttonEditarFunc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEditarFunc.UseVisualStyleBackColor = false;
            this.buttonEditarFunc.Click += new System.EventHandler(this.buttonEditarFunc_Click);
            // 
            // buttonSalvarFunc
            // 
            this.buttonSalvarFunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonSalvarFunc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvarFunc.Image = global::AgroByte_Desktop.Properties.Resources.icons8_salvar;
            this.buttonSalvarFunc.Location = new System.Drawing.Point(892, 266);
            this.buttonSalvarFunc.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.buttonSalvarFunc.Name = "buttonSalvarFunc";
            this.buttonSalvarFunc.Size = new System.Drawing.Size(227, 72);
            this.buttonSalvarFunc.TabIndex = 12;
            this.buttonSalvarFunc.Text = "Salvar";
            this.buttonSalvarFunc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSalvarFunc.UseVisualStyleBackColor = false;
            this.buttonSalvarFunc.Click += new System.EventHandler(this.buttonSalvarFunc_Click);
            // 
            // buttonNovoFunc
            // 
            this.buttonNovoFunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonNovoFunc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNovoFunc.Image = global::AgroByte_Desktop.Properties.Resources.icons8_novo_arquivo_30;
            this.buttonNovoFunc.Location = new System.Drawing.Point(892, 180);
            this.buttonNovoFunc.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.buttonNovoFunc.Name = "buttonNovoFunc";
            this.buttonNovoFunc.Size = new System.Drawing.Size(227, 72);
            this.buttonNovoFunc.TabIndex = 11;
            this.buttonNovoFunc.Text = "Novo";
            this.buttonNovoFunc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonNovoFunc.UseVisualStyleBackColor = false;
            this.buttonNovoFunc.Click += new System.EventHandler(this.buttonNovoFunc_Click);
            // 
            // frmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radStInativo);
            this.Controls.Add(this.radStAtivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCoc);
            this.Controls.Add(this.lblCodigoFunc);
            this.Controls.Add(this.buttonCancelarFunc);
            this.Controls.Add(this.buttonExcluirFunc);
            this.Controls.Add(this.buttonEditarFunc);
            this.Controls.Add(this.buttonSalvarFunc);
            this.Controls.Add(this.buttonNovoFunc);
            this.Controls.Add(this.txtNomeFunc);
            this.Controls.Add(this.groupBoxPesquisaFunc);
            this.Controls.Add(this.dataGridFunc);
            this.Controls.Add(this.txtSenhaFunc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLoginFunc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblfunc);
            this.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmFuncionario";
            this.Size = new System.Drawing.Size(1125, 1164);
            this.Load += new System.EventHandler(this.frmFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFunc)).EndInit();
            this.groupBoxPesquisaFunc.ResumeLayout(false);
            this.groupBoxPesquisaFunc.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfunc;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLoginFunc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPesquisaFunc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSenhaFunc;
        private System.Windows.Forms.DataGridView dataGridFunc;
        private System.Windows.Forms.GroupBox groupBoxPesquisaFunc;
        private System.Windows.Forms.TextBox txtNomeFunc;
        private System.Windows.Forms.Button buttonNovoFunc;
        private System.Windows.Forms.Button buttonSalvarFunc;
        private System.Windows.Forms.Button buttonEditarFunc;
        private System.Windows.Forms.Button buttonExcluirFunc;
        private System.Windows.Forms.Button buttonCancelarFunc;
        private System.Windows.Forms.Label lblCodigoFunc;
        private System.Windows.Forms.Label lblCoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radStAtivo;
        private System.Windows.Forms.RadioButton radStInativo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUsuariologado;
        private System.Windows.Forms.Label label5;
    }
}
