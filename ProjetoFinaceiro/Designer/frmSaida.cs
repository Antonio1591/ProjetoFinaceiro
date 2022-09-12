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
using System.Globalization;
using Dapper;

namespace ProjetoFinaceiro.Designer
{
    public partial class frmSaida : Form
    {
        private readonly SaidaFinaceiraService _SaidaFinaceiraService;
        private readonly TiposService _tiposService;
        private readonly MovimentoFinaceiroService _movimentoFinaceiroService;

        public frmSaida(SaidaFinaceiraService saidaFinaceiraService, TiposService tiposService, MovimentoFinaceiroService movimentoFinaceiroService)
        {
            _SaidaFinaceiraService = saidaFinaceiraService;
            _tiposService = tiposService;
            _movimentoFinaceiroService = movimentoFinaceiroService;
            InitializeComponent();
            
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (cmbSaidas.Text == "" || txtValor.Text == "")
            {
                MessageBox.Show("Não pode ter campos vazios! ", "Campos vazios! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double valor = Convert.ToDouble(txtValor.Text.Replace("R$ ", "")); ;

            DateTime data = DateTime.Now;
            MessageBox.Show(valor.ToString(), data.ToString());




            _SaidaFinaceiraService.Salvar(new Modelo.SaidaFinaceira(cmbSaidas.Text, valor, DateTime.Now, "ATIVO"));
            MessageBox.Show("Operação cadastrada! ", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _movimentoFinaceiroService.Salvar(new Modelo.MovimentoFinaceiro(cmbSaidas.Text, "Saida", 0, valor, DateTime.Now, "ATIVO"));
        }

        private void frmSaida_Load(object sender, EventArgs e)
        {
            var tipo = _tiposService.obterTipoSaida();

            foreach (var tipos in tipo)
            {
                cmbSaidas.Items.Add(tipos.Nome);

            }
        }
    }
}
