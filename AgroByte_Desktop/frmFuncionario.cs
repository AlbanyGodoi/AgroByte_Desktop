using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroByte_Desktop
{
    public partial class frmFuncionario : UserControl
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }

        private void desabilitaCampos() 
        { 
            txtNomeFunc.Enabled = false;
            txtLoginFunc.Enabled = false;
            txtSenhaFunc.Enabled = false;
            buttonSalvarFunc.Enabled = false;
            buttonEditarFunc.Enabled = false;
            buttonExcluirFunc.Enabled = false;
            buttonCancelarFunc.Enabled = false;
        }

        private void habilitaCampos() 
        {
            txtNomeFunc.Enabled = true;
            txtLoginFunc.Enabled = true;
            txtSenhaFunc.Enabled = true;
            buttonSalvarFunc.Enabled = true;
            buttonCancelarFunc.Enabled = true;


        }


        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            desabilitaCampos();
        }

        private void buttonNovoFunc_Click(object sender, EventArgs e)
        {
            habilitaCampos();
        }
    }
}
