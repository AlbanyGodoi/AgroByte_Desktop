using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.ConstrainedExecution;
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
            txtNumCad.Enabled = false;
            txtBairroCad.Enabled = false;
            CbEstadoCad.Enabled = false;
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
            txtCpfCad.Clear();
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

            lblCod.Visible = true;

            txtNomeCad.Enabled = true;
            txtSobrenomeCad.Enabled = true;
            txtEndCad.Enabled = true;
            txtEmailCad.Enabled = true;
            txtNumCad.Enabled = true;
            txtBairroCad.Enabled = true;
            txtCidadeCad.Enabled = true;
            txtCelularCad.Enabled = true;
            txtFoneCad.Enabled = true;
            CbEstadoCad.Enabled = true;
            CbTipoCad.Enabled = true;
            txtCepCad.Enabled = true;
            txtCnpjCad.Enabled = true;
            txtCpfCad.Enabled = true;



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
            if (CbTipoCad.SelectedIndex == -1) // se não tiver nada selecionado
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



             if (txtNomeCad.Text == "")
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

            else if (CbTipoCad.SelectedIndex == -1)
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

            else if (CbEstadoCad.SelectedIndex == -1)
            {
                MessageBox.Show("Obrigatório informar um Estado !!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                try
                {

                    string tipo = CbTipoCad.SelectedItem.ToString();
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


                    string strSql = "insert into cadastros(CadastroName,Sobrenome,CPF,CNPJ,CEP,CelularCad,CidadeCad,EmailCad,EnderecoCad1,EstadoCad,FoneCad,NumeroCad1,tipo,bairro) values (@CadastroName,@Sobrenome,@CPF,@CNPJ,@CEP,@CelularCad,@CidadeCad,@EmailCad,@EnderecoCad1,@EstadoCad,@FoneCad,@NumeroCad1,@tipo,@bairro)";

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
                    cm.Parameters.Add("@tipo", SqlDbType.VarChar).Value = tipo;
                    cm.Parameters.Add("@bairro", SqlDbType.VarChar).Value = bairro;

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

        private void buttonEditarCad_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica se lblCod.Text tem um valor numérico válido
                if (!int.TryParse(lblCod.Text, out int cd))
                {
                    MessageBox.Show("Código inválido. Por favor, selecione um registro válido para edição.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string cpf = txtCpfCad.Text;
                string cnpj = txtCnpjCad.Text;
                string nome = txtNomeCad.Text;
                string sobrenome = txtSobrenomeCad.Text;
                string endereco = txtEndCad.Text;
                string numero = txtNumCad.Text;
                string bairro = txtBairroCad.Text;
                string cidade = txtCidadeCad.Text;
                string cep = txtCepCad.Text;
                string estado = CbEstadoCad.SelectedItem?.ToString();
                string email = txtEmailCad.Text;
                string celular = txtCelularCad.Text;
                string fone = txtFoneCad.Text;

                string strSql = "UPDATE cadastros SET CadastroName=@CadastroName, Sobrenome=@Sobrenome, CPF=@CPF, CNPJ=@CNPJ, CEP=@CEP, CelularCad=@CelularCad, CidadeCad=@CidadeCad, EmailCad=@EmailCad, EnderecoCad1=@EnderecoCad1, EstadoCad=@EstadoCad, FoneCad=@FoneCad, NumeroCad1=@NumeroCad1, bairro=@bairro WHERE CadastroId=@cd";
                cm.CommandText = strSql;
                cm.Connection = cn;

                // Adicionando parâmetros
                cm.Parameters.AddWithValue("@CadastroName", nome);
                cm.Parameters.AddWithValue("@Sobrenome", sobrenome);
                cm.Parameters.AddWithValue("@CPF", cpf);
                cm.Parameters.AddWithValue("@CNPJ", cnpj);
                cm.Parameters.AddWithValue("@CEP", cep);
                cm.Parameters.AddWithValue("@CelularCad", celular);
                cm.Parameters.AddWithValue("@CidadeCad", cidade);
                cm.Parameters.AddWithValue("@EmailCad", email);
                cm.Parameters.AddWithValue("@EnderecoCad1", endereco);
                cm.Parameters.AddWithValue("@EstadoCad", estado);
                cm.Parameters.AddWithValue("@FoneCad", fone);
                cm.Parameters.AddWithValue("@NumeroCad1", numero);
                cm.Parameters.AddWithValue("@bairro", bairro);
                cm.Parameters.AddWithValue("@cd", cd);  // Adicionando o parâmetro cd

                cn.Open();
                cm.ExecuteNonQuery();
                MessageBox.Show("Dados atualizados com sucesso.", "Edição Concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cm.Parameters.Clear();
                limparCampos();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
            }
        }

        private void txtPesquisacad_TextChanged(object sender, EventArgs e)
        {


            if (txtPesquisacad.Text != "")
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "select * from VWCadastro2 where CadastroName like ('" + txtPesquisacad.Text + "%')";
                    cm.Connection = cn;



                    SqlDataAdapter da = new SqlDataAdapter(); // recebe os dados de uma tabela após a execução de um select

                    DataTable dt = new DataTable(); // representa uma ou mais tabela de dados que ficam na memoria para serem manipuladas

                    da.SelectCommand = cm; // pega o resultado do select e inclui no da
                    da.Fill(dt);// preencher a tabela 
                    dataGridViewCad.DataSource = dt; // envia para o dataGridFunc a tabela
                    cn.Close(); // fecha a conexão com o banco de dados


                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);

                }


            }
            else
            {
                dataGridViewCad.DataSource = null;
            }




        }


        private void carregaCadastro()
        {
            if (dataGridViewCad.SelectedRows.Count > 0)
            {
                // Garantir que a linha selecionada seja a primeira linha
                DataGridViewRow selectedRow = dataGridViewCad.SelectedRows[0];

                // Agora atribuímos os valores das células para os campos
                lblCod.Text = selectedRow.Cells[0].Value.ToString();
                txtNomeCad.Text = selectedRow.Cells[1].Value.ToString();
                txtSobrenomeCad.Text = selectedRow.Cells[2].Value.ToString();
                txtCpfCad.Text = selectedRow.Cells[3].Value.ToString();
                txtCnpjCad.Text = selectedRow.Cells[4].Value.ToString();
                txtCepCad.Text = selectedRow.Cells[5].Value.ToString();
                txtCelularCad.Text = selectedRow.Cells[6].Value.ToString();
                txtCidadeCad.Text = selectedRow.Cells[7].Value.ToString();
                txtEmailCad.Text = selectedRow.Cells[8].Value.ToString();
                txtEndCad.Text = selectedRow.Cells[9].Value.ToString();
                CbEstadoCad.Text = selectedRow.Cells[10].Value.ToString();
                txtFoneCad.Text = selectedRow.Cells[11].Value.ToString();
                txtNumCad.Text = selectedRow.Cells[12].Value.ToString();
                CbTipoCad.Text = selectedRow.Cells[13].Value.ToString();
                txtBairroCad.Text = selectedRow.Cells[14].Value.ToString();

                manipularDados();
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma linha.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void dataGridViewCad_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dataGridViewCad_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Certifique-se de que a linha que está sendo clicada seja a linha inteira
            if (dataGridViewCad.SelectedRows.Count > 0)
            {
                carregaCadastro();
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma linha.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridViewCad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void numcad_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonExcluirCad_Click(object sender, EventArgs e)
        {
            // Verifica se um cadastro está selecionado
            if (lblCod.Visible && int.TryParse(lblCod.Text, out int cadastroId))
            {
                // Confirmação do usuário antes de excluir
                DialogResult confirmacao = MessageBox.Show(
                    "Tem certeza de que deseja excluir este cadastro?",
                    "Confirmação de Exclusão",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmacao == DialogResult.Yes)
                {
                    try
                    {
                        // Comando SQL para excluir o cadastro pelo ID
                        string strSql = "DELETE FROM cadastros WHERE CadastroId = @CadastroId";
                        cm.CommandText = strSql;
                        cm.Connection = cn;

                        // Adiciona o parâmetro de ID ao comando
                        cm.Parameters.Add("@CadastroId", SqlDbType.Int).Value = cadastroId;

                        // Executa o comando
                        cn.Open();
                        cm.ExecuteNonQuery();
                        cm.Parameters.Clear(); // Limpa os parâmetros para reutilizar o SqlCommand

                        MessageBox.Show("Cadastro excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Limpa os campos e atualiza a visualização
                        limparCampos();
                        desabilitaCampos();
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Erro ao excluir o cadastro: " + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        cn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um cadastro válido para exclusão.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
