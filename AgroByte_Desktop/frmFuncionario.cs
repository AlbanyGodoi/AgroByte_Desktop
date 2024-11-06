using System;
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
            txtPesquisaFunc.Clear();
            dataGridFunc.DataSource = null;
            lblCoc.Visible = false;

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
            txtSenhaFunc.Enabled = true;
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

            else if (radStInativo.Checked)
            {
                MessageBox.Show("Inpossivel realizar o cadasdo de funcionário como STATUS INATIVO.", "Erro ao tentar gravar o registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }



            else
            {
                try
                {

                    string nome = txtNomeFunc.Text;
                    string login = txtLoginFunc.Text;
                    string senha = txtSenhaFunc.Text;


                    string strSql = " insert into senhas (Login,Senha,Usuario,status) values(@login,@senha,@Usuario,1)";

                    cm.CommandText = strSql;
                    cm.Connection =cn;

                   

                    cm.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
                    cm.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;
                    cm.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = nome;

                    cn.Open();
                    cm.ExecuteNonQuery();
                    cm.Parameters.Clear();

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
                               cm.CommandText = " select * from senhas where Usuario like ('" + txtPesquisaFunc.Text + "%')";
                    

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
            txtLoginFunc.Text = dataGridFunc.SelectedRows[0].Cells[2].Value.ToString();
            txtNomeFunc.Text = dataGridFunc.SelectedRows[0].Cells[3].Value.ToString();
            txtSenhaFunc.Text = dataGridFunc.SelectedRows[0].Cells[1].Value.ToString();
            string valor = dataGridFunc.SelectedRows[0].Cells[4].Value.ToString();

            if (valor == "True")
            { 
                radStAtivo.Checked = true;
            }
            else
            {
                radStInativo.Checked = true;
            }
            manipularDados();

        }


        private void dataGridFunc_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            carregaFuncionario();

            if(radStAtivo.Checked)
            {
                buttonExcluirFunc.Enabled = true;
            }
            else
                buttonExcluirFunc.Enabled=false;
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

            else if(radStAtivo.Checked)
            {
                MessageBox.Show("Para colocar o funcionario como Inativo clicar no botão excluir ", "Erro na operação", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



            else
            {
                try
                {

                    string nome = txtNomeFunc.Text;
                    string login = txtLoginFunc.Text;
                    string senha = txtSenhaFunc.Text;
                    int cd = Convert.ToInt32(lblCoc.Text);


                    string strSql = " update senhas set Login=@login,Senha=@senha,Usuario=@Usuario, status = 1  where SenhaID=@cd ";

                    cm.CommandText = strSql;
                    cm.Connection = cn;



                    cm.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
                    cm.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;
                    cm.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = nome;
                    cm.Parameters.Add("@cd", SqlDbType.Int).Value = cd;

                    cn.Open();
                    cm.ExecuteNonQuery();

                    cm.Parameters.Clear();

                    MessageBox.Show("Dados alterados com sucesso!!!!.", "Alteração de dados concluida", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void buttonExcluirFunc_Click(object sender, EventArgs e)
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
            else if (radStInativo.Checked)
            {
                MessageBox.Show("Para bloquear o acesso ao sistema o status deve ser alterado para INATIVO.", "Erro ao tentar alterar o status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                DialogResult exclusao = MessageBox.Show("Confirmar alteração", "alteração de registro",MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (exclusao == DialogResult.No)
                {
                    return;
                }
                else
                {
                    try
                    {
                        int cd = Convert.ToInt32(lblCoc.Text);
                        cn.Open();
                        string strSql = "update senhas set status = 0 where SenhaId = @cd";
                        cm.CommandText = strSql;
                        cm.Connection = cn;
                        cm.Parameters.Add("@cd", SqlDbType.Int).Value = cd;

                        cm.ExecuteNonQuery();

                        cm.Parameters.Clear();

                        MessageBox.Show("Dados alterados com sucesso!!!!.", "Alteração de dados concluida", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void radStAtivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            lblUsuariologado.Text = Login.usuario;
        }
    } 
}
