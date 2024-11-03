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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLoginFunc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPesquisaFunc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSenhaFunc = new System.Windows.Forms.TextBox();
            this.dataGridFunc = new System.Windows.Forms.DataGridView();
            this.groupBoxPesquisaFunc = new System.Windows.Forms.GroupBox();
            this.textNomeFunc = new System.Windows.Forms.TextBox();
            this.buttonCancelarFunc = new System.Windows.Forms.Button();
            this.buttonExcluirFunc = new System.Windows.Forms.Button();
            this.buttonEditarFunc = new System.Windows.Forms.Button();
            this.buttonSalvarFunc = new System.Windows.Forms.Button();
            this.buttonNovoFunc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFunc)).BeginInit();
            this.groupBoxPesquisaFunc.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblfunc
            // 
            this.lblfunc.AutoSize = true;
            this.lblfunc.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfunc.ForeColor = System.Drawing.Color.Green;
            this.lblfunc.Location = new System.Drawing.Point(261, 21);
            this.lblfunc.Name = "lblfunc";
            this.lblfunc.Size = new System.Drawing.Size(273, 51);
            this.lblfunc.TabIndex = 0;
            this.lblfunc.Text = "Funcionário";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Login:";
            // 
            // txtLoginFunc
            // 
            this.txtLoginFunc.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginFunc.Location = new System.Drawing.Point(135, 239);
            this.txtLoginFunc.MaxLength = 10;
            this.txtLoginFunc.Name = "txtLoginFunc";
            this.txtLoginFunc.Size = new System.Drawing.Size(270, 34);
            this.txtLoginFunc.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome:";
            // 
            // txtPesquisaFunc
            // 
            this.txtPesquisaFunc.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaFunc.Location = new System.Drawing.Point(84, 33);
            this.txtPesquisaFunc.MaxLength = 60;
            this.txtPesquisaFunc.Name = "txtPesquisaFunc";
            this.txtPesquisaFunc.Size = new System.Drawing.Size(459, 34);
            this.txtPesquisaFunc.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Senha:";
            // 
            // txtSenhaFunc
            // 
            this.txtSenhaFunc.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaFunc.Location = new System.Drawing.Point(135, 292);
            this.txtSenhaFunc.MaxLength = 10;
            this.txtSenhaFunc.Name = "txtSenhaFunc";
            this.txtSenhaFunc.Size = new System.Drawing.Size(270, 34);
            this.txtSenhaFunc.TabIndex = 7;
            // 
            // dataGridFunc
            // 
            this.dataGridFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFunc.Location = new System.Drawing.Point(52, 436);
            this.dataGridFunc.Name = "dataGridFunc";
            this.dataGridFunc.RowHeadersWidth = 51;
            this.dataGridFunc.RowTemplate.Height = 24;
            this.dataGridFunc.Size = new System.Drawing.Size(543, 150);
            this.dataGridFunc.TabIndex = 8;
            // 
            // groupBoxPesquisaFunc
            // 
            this.groupBoxPesquisaFunc.Controls.Add(this.txtPesquisaFunc);
            this.groupBoxPesquisaFunc.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPesquisaFunc.Location = new System.Drawing.Point(52, 351);
            this.groupBoxPesquisaFunc.Name = "groupBoxPesquisaFunc";
            this.groupBoxPesquisaFunc.Size = new System.Drawing.Size(543, 79);
            this.groupBoxPesquisaFunc.TabIndex = 9;
            this.groupBoxPesquisaFunc.TabStop = false;
            this.groupBoxPesquisaFunc.Text = "Pesquisa por Funcionário";
            // 
            // textNomeFunc
            // 
            this.textNomeFunc.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNomeFunc.Location = new System.Drawing.Point(135, 193);
            this.textNomeFunc.MaxLength = 60;
            this.textNomeFunc.Name = "textNomeFunc";
            this.textNomeFunc.Size = new System.Drawing.Size(459, 34);
            this.textNomeFunc.TabIndex = 10;
            // 
            // buttonCancelarFunc
            // 
            this.buttonCancelarFunc.BackColor = System.Drawing.SystemColors.Info;
            this.buttonCancelarFunc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarFunc.Image = global::AgroByte_Desktop.Properties.Resources.icons8_cancelar_16;
            this.buttonCancelarFunc.Location = new System.Drawing.Point(662, 340);
            this.buttonCancelarFunc.Name = "buttonCancelarFunc";
            this.buttonCancelarFunc.Size = new System.Drawing.Size(130, 41);
            this.buttonCancelarFunc.TabIndex = 15;
            this.buttonCancelarFunc.Text = "Cancelar";
            this.buttonCancelarFunc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancelarFunc.UseVisualStyleBackColor = false;
            // 
            // buttonExcluirFunc
            // 
            this.buttonExcluirFunc.BackColor = System.Drawing.Color.Salmon;
            this.buttonExcluirFunc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluirFunc.Image = global::AgroByte_Desktop.Properties.Resources.icons8_full_trash_28;
            this.buttonExcluirFunc.Location = new System.Drawing.Point(662, 280);
            this.buttonExcluirFunc.Name = "buttonExcluirFunc";
            this.buttonExcluirFunc.Size = new System.Drawing.Size(130, 41);
            this.buttonExcluirFunc.TabIndex = 14;
            this.buttonExcluirFunc.Text = "Excluir";
            this.buttonExcluirFunc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonExcluirFunc.UseVisualStyleBackColor = false;
            // 
            // buttonEditarFunc
            // 
            this.buttonEditarFunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonEditarFunc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditarFunc.Image = global::AgroByte_Desktop.Properties.Resources.icons8_edit_28;
            this.buttonEditarFunc.Location = new System.Drawing.Point(662, 215);
            this.buttonEditarFunc.Name = "buttonEditarFunc";
            this.buttonEditarFunc.Size = new System.Drawing.Size(130, 41);
            this.buttonEditarFunc.TabIndex = 13;
            this.buttonEditarFunc.Text = "Editar";
            this.buttonEditarFunc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEditarFunc.UseVisualStyleBackColor = false;
            // 
            // buttonSalvarFunc
            // 
            this.buttonSalvarFunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonSalvarFunc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvarFunc.Image = global::AgroByte_Desktop.Properties.Resources.icons8_salvar;
            this.buttonSalvarFunc.Location = new System.Drawing.Point(662, 156);
            this.buttonSalvarFunc.Name = "buttonSalvarFunc";
            this.buttonSalvarFunc.Size = new System.Drawing.Size(130, 41);
            this.buttonSalvarFunc.TabIndex = 12;
            this.buttonSalvarFunc.Text = "Salvar";
            this.buttonSalvarFunc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSalvarFunc.UseVisualStyleBackColor = false;
            // 
            // buttonNovoFunc
            // 
            this.buttonNovoFunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonNovoFunc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNovoFunc.Image = global::AgroByte_Desktop.Properties.Resources.icons8_novo;
            this.buttonNovoFunc.Location = new System.Drawing.Point(662, 98);
            this.buttonNovoFunc.Name = "buttonNovoFunc";
            this.buttonNovoFunc.Size = new System.Drawing.Size(130, 41);
            this.buttonNovoFunc.TabIndex = 11;
            this.buttonNovoFunc.Text = "Novo";
            this.buttonNovoFunc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonNovoFunc.UseVisualStyleBackColor = false;
            // 
            // frmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonCancelarFunc);
            this.Controls.Add(this.buttonExcluirFunc);
            this.Controls.Add(this.buttonEditarFunc);
            this.Controls.Add(this.buttonSalvarFunc);
            this.Controls.Add(this.buttonNovoFunc);
            this.Controls.Add(this.textNomeFunc);
            this.Controls.Add(this.groupBoxPesquisaFunc);
            this.Controls.Add(this.dataGridFunc);
            this.Controls.Add(this.txtSenhaFunc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLoginFunc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblfunc);
            this.Name = "frmFuncionario";
            this.Size = new System.Drawing.Size(811, 624);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFunc)).EndInit();
            this.groupBoxPesquisaFunc.ResumeLayout(false);
            this.groupBoxPesquisaFunc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfunc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLoginFunc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPesquisaFunc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSenhaFunc;
        private System.Windows.Forms.DataGridView dataGridFunc;
        private System.Windows.Forms.GroupBox groupBoxPesquisaFunc;
        private System.Windows.Forms.TextBox textNomeFunc;
        private System.Windows.Forms.Button buttonNovoFunc;
        private System.Windows.Forms.Button buttonSalvarFunc;
        private System.Windows.Forms.Button buttonEditarFunc;
        private System.Windows.Forms.Button buttonExcluirFunc;
        private System.Windows.Forms.Button buttonCancelarFunc;
    }
}
