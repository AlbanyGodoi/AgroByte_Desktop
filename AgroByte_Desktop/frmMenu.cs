using System;
using System.Windows.Forms;

namespace AgroByte_Desktop
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonSairAplic1_Click(object sender, EventArgs e)
        {
            Login telaLogin = new Login();
            telaLogin.Show();
            this.Hide();
        }

        //private void MainForm_Load(object sender, EventArgs e)
        //{
            
        //}



        private void frmMenu_Load(object sender, EventArgs e)
        {

            fmlCadastro1.Visible = false;
            principal21.Visible = true;
            relatorioCadastros1.Visible = false;
            frmFuncionario1.Visible = false;


            principal21.BringToFront();

        }

        private void principal1_Load(object sender, EventArgs e)
        {

        }

        private void frmFuncionario1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCadastro_Click(object sender, EventArgs e)
        {
            fmlCadastro1.Visible = true;
            principal21.Visible = false;
            relatorioCadastros1.Visible = false;
            frmFuncionario1.Visible = false;
            fmlCadastro1.BringToFront();
            //fmlCadastro1.Show();
            //fmlCadastro1.BringToFront();

        }

        private void buttonFuncionario_Click(object sender, EventArgs e)
        {

            fmlCadastro1.Visible = false;
            principal21.Visible = false;
            relatorioCadastros1.Visible = false;
            frmFuncionario1.Visible = true;
            
            //frmFuncionario1.Show();
            frmFuncionario1.BringToFront();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TelaInicial_Click(object sender, EventArgs e)
        {
            fmlCadastro1.Visible = false;
            principal21.Visible = true;
            relatorioCadastros1.Visible = false;
            frmFuncionario1.Visible = false;
            principal21.BringToFront();
        }

        private void buttonRelatorio_Click(object sender, EventArgs e)
        {
            fmlCadastro1.Visible = false;
            principal21.Visible = false;
            relatorioCadastros1.Visible = true;
            frmFuncionario1.Visible = false;


            relatorioCadastros1.BringToFront();
        }
    }
}
