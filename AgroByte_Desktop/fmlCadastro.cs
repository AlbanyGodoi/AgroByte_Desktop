using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace AgroByte_Desktop
{
    public partial class fmlCadastro : UserControl
    {
        public fmlCadastro()
        {
            InitializeComponent();
        }


        SqlConnection cn = new SqlConnection(@"Data Source=ALBANY;Initial Catalog=Agrobyte;Integrated Security=SSPI");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dt;



        // inicio

        private void desabilitaCampos()
        {

            lblCodigo.Visible = false;
            lblCod.Visible = false;

            txtNomeCad.Enabled = false;
            txtSobrenomeCad.Enabled = false;

            txtEndCad.Enabled = false;
            txtEmailCad.Enabled = false;
            txtCelularCad.Enabled = false;
            txtFoneCad.Enabled = false;
            txtCepCad.Enabled = false;
            txtCidadeCad.Enabled = false;
            txtCnpjCad.Enabled = false;
            txtCpfCad.Enabled = false;
            txtNumCad.Enabled=false;
            txtBairroCad.Enabled=false;
           CbEstadoCad.Enabled=false;
            CbTipoCad.Enabled = false;



            buttonSalvarCad.Enabled = false;
            buttonEditarCad.Enabled = false;
            buttonExcluirCad.Enabled = false;
            buttonCancelarCad.Enabled = false;
            buttonNovoCad.Enabled = true;
        }

        private void habilitaCampos()
        {
            txtNomeCad.Enabled = true;
            txtSobrenomeCad.Enabled = true;
            txtEndCad.Enabled = true;
            txtEmailCad.Enabled = true;
            txtCelularCad.Enabled = true;
            txtFoneCad.Enabled = true;
            txtCepCad.Enabled = true;
            txtCidadeCad.Enabled = true;
            txtCnpjCad.Enabled = true;
            txtCpfCad.Enabled = true;
            txtNumCad.Enabled = true;
            txtBairroCad.Enabled = true;
            CbEstadoCad.Enabled = true;
            CbTipoCad.Enabled = true;


            buttonSalvarCad.Enabled = true;
            buttonCancelarCad.Enabled = true;
            buttonNovoCad.Enabled = false;
            txtNomeCad.Focus();
            txtPesquisacad.Text = "";
            dataGridViewCad.DataSource = null;


        }

        private void limparCampos()
        {
            txtNomeCad.Clear();
            txtSobrenomeCad.Clear();
            txtEndCad.Clear();
            txtEmailCad.Clear();
            txtCelularCad.Clear();
            txtFoneCad.Clear();
            txtCepCad.Clear();
            txtCidadeCad.Clear();
            txtCnpjCad.Clear();
            txtCpfCad.Clear() ;
            txtNumCad.Clear();
            txtBairroCad.Clear();
            CbEstadoCad.SelectedIndex = -1;
            CbTipoCad.SelectedIndex = -1;




            txtNomeCad.Focus();
            txtPesquisacad.Clear();
            dataGridViewCad.DataSource = null;
            lblCod.Visible = false;

        }

        private void manipularDados()
        {

            lblCodigo.Visible = true;
            lblCod.Visible = true;


            buttonEditarCad.Enabled = true;
            buttonCancelarCad.Enabled = true;
            buttonExcluirCad.Enabled = true;
            buttonSalvarCad.Enabled = false;
            buttonNovoCad.Enabled = false;
            txtNomeCad.Enabled = true;
           
        }
















        //fim

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fmlCadastro_Load(object sender, EventArgs e)
        {
            desabilitaCampos();
        }

        private void CbTipoCad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CbTipoCad.SelectedIndex == -1) // se não tiver nada selecionado
            {
                lblCnpj.Visible = false;
                txtCnpjCad.Visible = false;

            }
            else
            if (CbTipoCad.SelectedIndex == 0) // selecionado pessoa fisica
            {
                lblCnpj.Visible = false;
                txtCnpjCad.Visible = false;

            }
            else
            {
                lblCnpj.Visible = true;
                txtCnpjCad.Visible = true;
            }
        }

        private void buttonNovoCad_Click(object sender, EventArgs e)
        {
            habilitaCampos();
        }

        private void buttonCancelarCad_Click(object sender, EventArgs e)
        {
            limparCampos();
            desabilitaCampos();
        }

        private void buttonSalvarCad_Click(object sender, EventArgs e)
        {
            if (radioInativo.Checked)
            {
                MessageBox.Show("Para inserir um cadastro o status teve estar como ATIVO!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                radioAtivo.Checked = true;
            }

            else if(txtNomeCad.Text == "")
            {
                MessageBox.Show("Obrigatorio informar o Campo Nome!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeCad.Focus();
            }
            else if (txtSobrenomeCad.Text == "")
            {
                MessageBox.Show("Obrigatorio informar o Campo Sobrenome!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeCad.Focus();
            }
            else if (txtEmailCad.Text == "")
            {
                MessageBox.Show("Obrigatorio informar o Campo E-mail!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmailCad.Focus();
            }
            else if (txtEndCad.Text == "")
            {
                MessageBox.Show("Obrigatorio informar o Campo endereço!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEndCad.Focus();
            }
            else if (txtNumCad.Text == "")
            {
                MessageBox.Show("Obrigatorio informar o numero do endereço!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNumCad.Focus();
            }
            else if (txtBairroCad.Text == "")
            {
                MessageBox.Show("Obrigatorio informar o Bairro", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBairroCad.Focus();
            }
            else if (txtCidadeCad.Text == "")
            {
                MessageBox.Show("Obrigatorio informar a Cidade", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCidadeCad.Focus();
            }
            else if (txtCepCad.Text == "")
            {
                MessageBox.Show("Obrigatorio informar o CEP da localidade!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCepCad.Focus();
            }
            else if (txtCelularCad.Text == "")
            {
                MessageBox.Show("Obrigatorio informar um numero de celular!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCelularCad.Focus();
            }
            else if (txtCelularCad.Text.Length < 11)
            {
                MessageBox.Show("Obrigatorio informar um numero de celular válido!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCelularCad.Focus();
            }

            else if(CbTipoCad.SelectedIndex == -1) 
            {
                MessageBox.Show("Informar o tipo de cadastro!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }

            //else if (CbTipoCad.SelectedIndex == 0 && txtCpfCad.Text.Length < 11)
            //{


            //    MessageBox.Show("Obrigatório informar Cpf válido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    CbTipoCad.Show();

            //}


            else if (CbTipoCad.SelectedIndex == 1 && txtCnpjCad.Text.Length < 14)
            {
                
                
                    MessageBox.Show("Obrigatório informar CNPJ válido!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCnpjCad.Focus();
               

            }
            else if (CbTipoCad.SelectedIndex == 0 && txtCpfCad.Text.Length < 14)
            {
                                       
                    MessageBox.Show("Obrigatório informar Cpf válido!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CbTipoCad.Focus();
                
                
            }

            else if( CbEstadoCad.SelectedIndex == -1)
            {
                MessageBox.Show("Obrigatório informar um Estado !!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                try
                {


                    string cpf = txtCpfCad.Text;
                    string cnpj = txtCnpjCad.Text;
                    string nome = txtNomeCad.Text;
                    string sobrenome = txtSobrenomeCad.Text;
                    string endereco = txtEndCad.Text;
                    string numero = txtNumCad.Text;
                    string bairro = txtBairroCad.Text;
                    string cidade = txtCidadeCad.Text;
                    string cep = txtCepCad.Text;
                    string estado = CbEstadoCad.SelectedItem.ToString();
                    string email = txtEmailCad.Text;
                    string celular = txtCelularCad.Text;
                    string fone = txtFoneCad.Text;
                    

                    string strSql = "insert into cadastros(CadastroName,Sobrenome,CPF,CNPJ,CEP,CelularCad,CidadeCad,EmailCad,EnderecoCad1,EstadoCad,FoneCad,NumeroCad1) values (@CadastroName,@Sobrenome,@CPF,@CNPJ,@CEP,@CelularCad,@CidadeCad,@EmailCad,@EnderecoCad1,@EstadoCad,@FoneCad,@NumeroCad1)";

                    cm.CommandText = strSql;
                    cm.Connection = cn;


                    cm.Parameters.Add("@CadastroName", SqlDbType.VarChar).Value = nome;
                    cm.Parameters.Add("@Sobrenome", SqlDbType.VarChar).Value = sobrenome;
                    cm.Parameters.Add("@CPF", SqlDbType.VarChar).Value = cpf;
                    cm.Parameters.Add("@CNPJ", SqlDbType.VarChar).Value = cnpj;
                    cm.Parameters.Add("@CEP", SqlDbType.VarChar).Value = cep;
                    cm.Parameters.Add("@CelularCad", SqlDbType.VarChar).Value = celular;
                    cm.Parameters.Add("@CidadeCad", SqlDbType.VarChar).Value = cidade;
                    cm.Parameters.Add("@EmailCad", SqlDbType.VarChar).Value = email;
                    cm.Parameters.Add("@EnderecoCad1", SqlDbType.VarChar).Value = endereco;
                    cm.Parameters.Add("@EstadoCad", SqlDbType.VarChar).Value = estado;
                    cm.Parameters.Add("@FoneCad", SqlDbType.VarChar).Value = fone;
                    cm.Parameters.Add("@NumeroCad1", SqlDbType.VarChar).Value = numero;


                    cn.Open();
                    cm.ExecuteNonQuery();

                    cm.Parameters.Clear();

                    MessageBox.Show("Dados Salvos com sucesso!!!!.", "Alteração de dados concluida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNomeCad.Focus();
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
