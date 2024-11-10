using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroByte_Desktop
{
    public partial class RelatorioCadastros : UserControl
    {
        public RelatorioCadastros()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=ALBANY;Initial Catalog=Agrobyte;Integrated Security=SSPI");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dt;


        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                cn.Open();
                cm.CommandText = "select * from VWCadastro2 ";
                cm.Connection = cn;



                SqlDataAdapter da = new SqlDataAdapter(); // recebe os dados de uma tabela após a execução de um select

                DataTable dt = new DataTable(); // representa uma ou mais tabela de dados que ficam na memoria para serem manipuladas

                da.SelectCommand = cm; // pega o resultado do select e inclui no da
                da.Fill(dt);// preencher a tabela 
                dataGridViewRel.DataSource = dt; // envia para o dataGridFunc a tabela
                cn.Close(); // fecha a conexão com o banco de dados


            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }


        }



        private void buttonExpRel_Click(object sender, EventArgs e)
        {

        }
    }
}


