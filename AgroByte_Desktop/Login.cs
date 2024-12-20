﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AgroByte_Desktop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static string usuario;
        public static string codUsuario;
        //Conexao com banco de dados

        SqlConnection cn = new SqlConnection(@"Data Source=ALBANY;Initial Catalog=Agrobyte;Integrated Security=SSPI");
        SqlCommand cm = new SqlCommand();
        //SqlDataReader dt;


        private void buttonFecharLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSenha_MouseDown(object sender, MouseEventArgs e)
        {
            txtSenha.UseSystemPasswordChar = false;
        }

        private void btnSenha_MouseUp(object sender, MouseEventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
        }

        private void buttonAcessar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "" || txtSenha.Text == "")
            {

                MessageBox.Show("Obrigatório preencher os campos login e senha", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "select * from senhas where Login = ('" + txtLogin.Text + "') and Senha = ('" + txtSenha.Text + "') and status = 1";
                    cm.Connection = cn;
                    //dt =cm.ExecuteReader();
                    SqlDataAdapter da = new SqlDataAdapter(cm);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0) // contagem de linha no datatable
                    {
                        usuario = dt.Rows[0]["login"].ToString();
                        codUsuario = dt.Rows[0]["SenhaId"].ToString();
                        frmMenu menu = new frmMenu();
                        menu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha inválidos", "Ocorreu um erro !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtLogin.Clear();
                        txtSenha.Clear();
                        txtLogin.Focus();
                    }
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

        private void buttonSairAplic_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
