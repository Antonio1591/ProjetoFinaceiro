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

namespace ProjetoFinaceiro.Designer
{
    public partial class frmCadastroTiposEntradaESaida : Form
    {
        private readonly TiposService _tiposService;
        public frmCadastroTiposEntradaESaida(TiposService tiposService)
        {
            _tiposService = tiposService;
            InitializeComponent();

        }
        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtNomeOperacao.Text == "" || cmbTipoOperacao.Text == "" || txtDescriscao.Text == "")
            {
                MessageBox.Show("Não pode haver campos vazios", "Campos vazios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _tiposService.Salvar(new Modelo.Tipos(txtNomeOperacao.Text, cmbTipoOperacao.Text, txtDescriscao.Text, "ATIVO"));
            MessageBox.Show("Operação cadastrada! ", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fechar essa tela? ", "Fechar tela", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}