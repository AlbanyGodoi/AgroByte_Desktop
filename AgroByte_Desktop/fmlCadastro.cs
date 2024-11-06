using System;
using System.Windows.Forms;

namespace AgroByte_Desktop
{
    public partial class fmlCadastro : UserControl
    {
        public fmlCadastro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fmlCadastro_Load(object sender, EventArgs e)
        {

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
    }
}
