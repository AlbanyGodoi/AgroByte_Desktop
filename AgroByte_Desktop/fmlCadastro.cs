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
    }
}
