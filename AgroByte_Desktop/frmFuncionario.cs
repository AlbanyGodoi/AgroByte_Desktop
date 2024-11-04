﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AgroByte_Desktop
{
    public partial class frmFuncionario : UserControl
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }
        //Conexao com banco de dados

        SqlConnection cn = new SqlConnection(@"Data Source=ALBANY;Initial Catalog=Agrobyte;Integrated Security=SSPI");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dt;
        private void desabilitaCampos() 
        {

            lblCodigo.Visible = false;
            lblCoc.Visible = false;

            txtNomeFunc.Enabled = false;
            txtLoginFunc.Enabled = false;
            txtSenhaFunc.Enabled = false;
            buttonSalvarFunc.Enabled = false;
            buttonEditarFunc.Enabled = false;
            buttonExcluirFunc.Enabled = false;
            buttonCancelarFunc.Enabled = false;
            buttonNovoFunc.Enabled = true;
        }

        private void habilitaCampos() 
        {
            txtNomeFunc.Enabled = true;
            txtLoginFunc.Enabled = true;
            txtSenhaFunc.Enabled = true;
            buttonSalvarFunc.Enabled = true;
            buttonCancelarFunc.Enabled = true;
            buttonNovoFunc.Enabled = false;
            txtNomeFunc.Focus();
            txtPesquisaFunc.Text = "";
            dataGridFunc.DataSource = null;


        }

        private void limparCampos()
        {
            txtNomeFunc.Text = "";
            txtLoginFunc.Clear();
            txtSenhaFunc.Clear();
            txtNomeFunc.Focus();


        }

        private void manipularDados()
        {
           
            lblCodigo.Visible = true;
            lblCoc.Visible = true;
            
            
            buttonEditarFunc.Enabled = true ;
            buttonCancelarFunc.Enabled = true ;
            buttonExcluirFunc.Enabled=true ;
            buttonSalvarFunc.Enabled = false ;
            buttonNovoFunc.Enabled = false;
            txtNomeFunc.Enabled = true;
            txtLoginFunc.Enabled = true;
        }




        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            desabilitaCampos();
        }

        private void buttonNovoFunc_Click(object sender, EventArgs e)
        {
            habilitaCampos();
        }

        private void buttonCancelarFunc_Click(object sender, EventArgs e)
        {
            desabilitaCampos();
            limparCampos();
        }

        private void buttonSalvarFunc_Click(object sender, EventArgs e)
        {
            if(txtNomeFunc.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo nome.","Atenção",MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNomeFunc.Focus();
            }
            else if(txtLoginFunc.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo login.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLoginFunc.Focus();

            }
            else if(txtSenhaFunc.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo senha.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenhaFunc.Focus();

            }
            else if (txtSenhaFunc.Text.Length < 8 )
            {
                MessageBox.Show("O campo senha deve conter no minimo 8 digitos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenhaFunc.Focus();

            }
            else
            {
                try
                {

                    string nome = txtNomeFunc.Text;
                    string login = txtLoginFunc.Text;
                    string senha = txtSenhaFunc.Text;


                    string strSql = " insert into senhas (Login,Senha,Usuario) values(@login,@senha,@Usuario)";

                    cm.CommandText = strSql;
                    cm.Connection =cn;

                   

                    cm.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
                    cm.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;
                    cm.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = nome;

                    cn.Open();
                    cm.ExecuteNonQuery();

                    MessageBox.Show("Dados salvos com sucesso!!!!.","Inserção de dados concluida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNomeFunc.Focus();
                    limparCampos();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    cn.Close();
                }
                finally
                {
                    cn.Close();
                }

            }

        }

        private void txtPesquisaFunc_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisaFunc.Text != "")
            {

                try
                {
                    cn.Open(); // abre a conexão com o banco de dados
                               //cm.CommandText = " select * from senhas where Usuario like ('" + txtPesquisaFunc.Text + "%')";
                    cm.CommandText = " select SenhaId, Login, Usuario  from senhas where Usuario like ('" + txtPesquisaFunc.Text + "%')";

                    cm.Connection = cn;

                    SqlDataAdapter da = new SqlDataAdapter(); // recebe os dados de uma tabela após a execução de um select

                    DataTable dt = new DataTable(); // representa uma ou mais tabela de dados que ficam na memoria para serem manipuladas

                    da.SelectCommand = cm; // pega o resultado do select e inclui no da
                    da.Fill(dt);// preencher a tabela 
                    dataGridFunc.DataSource = dt; // envia para o dataGridFunc a tabela
                    cn.Close(); // fecha a conexão com o banco de dados
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }


            }
            else
            {
                dataGridFunc.DataSource = null;
            }
        }

        private void dataGridFunc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void carregaFuncionario()
        {
            lblCoc.Text = dataGridFunc.SelectedRows[0].Cells[0].Value.ToString();
            txtLoginFunc.Text = dataGridFunc.SelectedRows[0].Cells[1].Value.ToString();
            txtNomeFunc.Text = dataGridFunc.SelectedRows[0].Cells[2].Value.ToString();
            manipularDados();

        }


        private void dataGridFunc_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            carregaFuncionario();
        }

        private void buttonEditarFunc_Click(object sender, EventArgs e)
        {
            if (txtNomeFunc.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo nome.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNomeFunc.Focus();
            }
            else if (txtLoginFunc.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo login.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLoginFunc.Focus();

            }
            else if (txtSenhaFunc.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo senha.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenhaFunc.Focus();

            }
            else if (txtSenhaFunc.Text.Length < 8)
            {
                MessageBox.Show("O campo senha deve conter no minimo 8 digitos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenhaFunc.Focus();

            }
            else
            {
                try
                {

                    string nome = txtNomeFunc.Text;
                    string login = txtLoginFunc.Text;
                    string senha = txtSenhaFunc.Text;


                    string strSql = " update senhas set Login=@login,Senha=@senha,Usuario=@Usuario";

                    cm.CommandText = strSql;
                    cm.Connection = cn;



                    cm.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
                    cm.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;
                    cm.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = nome;

                    cn.Open();
                    cm.ExecuteNonQuery();

                    MessageBox.Show("Dados salvos com sucesso!!!!.", "Inserção de dados concluida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNomeFunc.Focus();
                    limparCampos();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    cn.Close();
                }
                finally
                {
                    cn.Close();
                }
            }
        }
    } 
}
