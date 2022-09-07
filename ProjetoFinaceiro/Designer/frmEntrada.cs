using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinaceiro.Designer
{
    public partial class frmEntrada : Form
    {
        public frmEntrada()
        {
            InitializeComponent();
        }

        private void frmEntrada_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair","Sair",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cmbEntradas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
