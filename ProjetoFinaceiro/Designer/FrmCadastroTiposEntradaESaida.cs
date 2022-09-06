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
        private readonly MovimentoFinanceiroService _movimentoFinanceiroService;
        public frmCadastroTiposEntradaESaida(MovimentoFinanceiroService movimentoFinanceiroService)
        {
            InitializeComponent();

            _movimentoFinanceiroService = movimentoFinanceiroService;


        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            _movimentoFinanceiroService.Salvar(new Modelo.TipoEntrada(0, "teste","Teste Tipo", "teste descricao"));
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja fechar essa tela? ","Fechar tela",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                             this.Close();
        
        }
    }
}
