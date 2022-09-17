using ProjetoFinaceiro.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinaceiro.Designer.Cadastro
{
    public partial class frmAlterarTipoCadastro : Form
    {
        private readonly TiposService _tiposService;

        public frmAlterarTipoCadastro(TiposService tiposService)
        {
            InitializeComponent();
            _tiposService = tiposService;
        }

        private void frmAlterarTipoCadastro_Load(object sender, EventArgs e)
        {
            cmbTipoOperacao.Enabled=false;
            txtDescriscao.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fechar essa tela? ", "Fechar tela", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Modelo.Tipos tipo = _tiposService.obterTipo(int.Parse(txtCodigo.Text),txtNomeOperacao.Text);
            txtCodigo.Text = tipo.Id.ToString();
            txtNomeOperacao.Text = tipo.Nome;
            cmbTipoOperacao.Items.Add(tipo.Situacao.ToString());
            txtDescriscao.Text=tipo.Descricao.ToString();

            cmbTipoOperacao.Enabled = true;
            txtDescriscao.Enabled = true;
        }
    }
}
