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
            //if (MessageBox.Show("Deseja fechar essa tela? ", "Fechar tela", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    this.Close();
            txtCodigo.Clear();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Modelo.Tipos tipo = _tiposService.obterTipo(string.IsNullOrWhiteSpace(txtCodigo.Text) ? 0 : int.Parse(txtCodigo.Text), txtNomeOperacao.Text);


            if(tipo == null)
            {
                MessageBox.Show("Informação Invalida, codigo ou nome não encontrado");
                return;
            }
            txtCodigo.Text = tipo.Id.ToString();
            txtNomeOperacao.Text = tipo.Nome;
            cmbTipoOperacao.Text = tipo.Tipo;
            txtDescriscao.Text=tipo.Descricao.ToString();
            lblPesquisar.Text = "Alterar Cadastro";
            btnInserir.Enabled = true;
            btnInserir.Visible = true;
            txtCodigo.Enabled = false;
            cmbTipoOperacao.Enabled = true;
            txtDescriscao.Enabled = true;
            btnBuscar.Enabled = false;
            btnBuscar.Visible = false;
        }
    }
}
