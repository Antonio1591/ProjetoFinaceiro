using apiProjetoFinaceiro.Model.Domain;
using apiProjetoFinaceiro.Model.Domain.UsuarioIdentityRepositorio;
using Microsoft.Extensions.DependencyInjection;
using ProjetoFinaceiro.Designer.Movimentação;
using ProjetoFinaceiro.Services;

namespace ProjetoFinaceiro.Designer
{
    public partial class frmPrincipal : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IMovimentacaoFinanceiraServices _IMovimentoFinaceiroService;

        public frmPrincipal(IServiceProvider serviceProvider, IMovimentacaoFinanceiraServices _ImovimentoFinaceiroService)
        {
            _serviceProvider = serviceProvider;
            _IMovimentoFinaceiroService = _ImovimentoFinaceiroService;
            InitializeComponent();
        }

        private void adicionarEntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetService<frmEntrada>();
            form.Show();
        }

        private void cadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form1 = _serviceProvider.GetService<frmCadastroTiposEntradaESaida>();
            form1.Show();

        }
        private async void frmPrincipal_LoadAsync(object sender, EventArgs e)
        {

            var valorEntrada = await _IMovimentoFinaceiroService.RetornarValorUltimoMes(Model.Enum.TipoMovimentacaoEnum.Entrada);
            var valorSaida = await _IMovimentoFinaceiroService.RetornarValorUltimoMes(Model.Enum.TipoMovimentacaoEnum.Saida);
            var valorTotal = (valorEntrada - valorSaida);

            txtValorEntrada.Text = valorEntrada.ToString("N2");
            txtValorSaida.Text = valorSaida.ToString("N2");
            txtValorTotal.Text = valorTotal.ToString("N2");
            //lblValorTotal.Text =   valorTotal.ToString("N2");

            if (valorTotal > 0)
             txtValorTotal.ForeColor = Color.LightGreen;
            else
            txtValorTotal.ForeColor = Color.FromArgb(255, 91, 96);
                //lblValorTotal.ForeColor = Color.FromArgb(255, 91, 96);

                //txtValorEntrada.Text = dtfinal.ToString();
        }

        private void finaceiroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //var form = _serviceProvider.GetService<frmRelatorio>();
            //form.Show();
        }

        private void alterarCadastroExistenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var form = _serviceProvider.GetService<frmAlterarTipoCadastro>();
            //form.Show();
        }

        private void adicionarValorSaidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetService<frmSaida>();
            form.Show();
        }

        private void alterarValorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetService<frmAlteracaoDeMovimentacao>();
            form.Show();
        }


    }
}
