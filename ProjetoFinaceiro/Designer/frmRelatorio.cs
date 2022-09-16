using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic;
using ProjetoFinaceiro.Modelo;
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
    public partial class frmRelatorio : Form
    {
        private readonly MovimentoFinaceiroService _MovimentoFinaceiroService;

        public frmRelatorio(MovimentoFinaceiroService movimentoFinaceiroService)
        {
            InitializeComponent();
            _MovimentoFinaceiroService = movimentoFinaceiroService;
        }

        private void frmRelatorio_Load(object sender, EventArgs e)
        {
            dtInicial.Value=DateTime.Now;
            dtFinal.Value = DateTime.Now;
            cmbTipoOPeracao.Text = "TODOS";
            cmbSituacao.Text = "TODOS";

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            IEnumerable<MovimentoFinaceiro> movimento = _MovimentoFinaceiroService.RelatorioPersonalizado(dtInicial.Value, dtFinal.Value, cmbTipoOPeracao.Text, cmbSituacao.Text);
            var celula=0;
            dataGridView1.Rows.Clear();
            foreach (var Movimentos in movimento)
   
            {
                txtNomeoperacao.DataGridView.Rows.Add(Movimentos.NomeOperacao_Finaceiro);
                txtDataLancamento.DataGridView.Rows[celula].Cells[1].Value = Movimentos.DataMovimentacao_Finaceiro;
                txtTipoOperracao.DataGridView.Rows[celula].Cells[2].Value = Movimentos.TipoOperacao_Finaceiro;
                txtValor.DataGridView.Rows[celula].Cells[3].Value = Movimentos.ValorEntrada_Finaceiro + Movimentos.ValorSaida_Finaceiro;
                txtSituacao.DataGridView.Rows[celula].Cells[4].Value = Movimentos.Situacao_Finaceiro;
                celula++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
    }
}
