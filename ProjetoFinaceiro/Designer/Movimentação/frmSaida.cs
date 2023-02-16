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
using apiProjetoFinaceiro.Model.Imput;
using ProjetoFinaceiro.Modelo.Domain;
using ProjetoFinaceiro.Model.View;
using ProjetoFinaceiro.Model.Enum;

namespace ProjetoFinaceiro.Designer
{
    public partial class frmSaida : Form
    {

        private readonly ITipoMovimentacaoServices _tiposService;
        private readonly IMovimentacaoFinanceiraServices _movimentoFinaceiroService;
        private IEnumerable<TipoMovimentacaoViewModel> _tipoViweModel;
        public frmSaida(ITipoMovimentacaoServices tiposService, IMovimentacaoFinanceiraServices movimentoFinaceiroService)
        {
            _tiposService = tiposService;
            _movimentoFinaceiroService = movimentoFinaceiroService;
            InitializeComponent();
        }

        //public MovimentacaoFinanceiraServices MovimentoFinaceiroService => _movimentoFinaceiroService;

    

        private async void frmSaida_Load(object sender, EventArgs e)
        {
            _tipoViweModel = await _tiposService.BuscarTipos();

            foreach (var tipos in _tipoViweModel)
            {
                cmbSaidas.Items.Add(tipos.TipoDescriscao);

            }
        }

        private async void btnInserir_Click(object sender, EventArgs e)
        {

            if (cmbSaidas.Text == "" || txtValor.Text == "")
            {
                MessageBox.Show("Não pode ter campos vazios! ", "Campos vazios! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //double valor = Convert.ToDouble(txtValor.Text.Replace("R$ ", ""));

            var tipoMovimentacao = _tipoViweModel.FirstOrDefault(T =>T.TipoDescriscao== cmbSaidas.Text);
            var movimentacaoFinaceira = new MovimentacaoFinanceiraInputModel(DataSaida.Value, Decimal.Parse(txtValor.Text), tipoMovimentacao.Id, SituacaoEnum.ATIVO) ;

            var resultado= await _movimentoFinaceiroService.CadastrarMovimentacoes(movimentacaoFinaceira);
            if (resultado == null)
                return;
            MessageBox.Show("Operação cadastrada! ", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            //txtValor.Clear();
            //cmbSaidas.SelectedIndex = -1;

        }
    }
}
