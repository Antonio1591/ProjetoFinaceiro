using apiProjetoFinaceiro.Model.Domain;
using Microsoft.Extensions.DependencyInjection;
using ProjetoFinaceiro.Designer.Movimentação;
using ProjetoFinaceiro.Services;

namespace ProjetoFinaceiro.Designer
{
    public partial class frmPrincipal : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly MovimentacaoFinanceiraServices _MovimentoFinaceiroService;

        public frmPrincipal(IServiceProvider serviceProvider, MovimentacaoFinanceiraServices _movimentoFinaceiroService)
        {
            _serviceProvider = serviceProvider;
            _MovimentoFinaceiroService = _movimentoFinaceiroService;
            InitializeComponent();

        }

        private void adicionarEntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetService<frmEntrada>();
            form.Show();
        }

        private void cadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //var form1 = _serviceProvider.GetService<frmCadastroTiposEntradaESaida>();
            //form1.Show();

        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //var valorEntrada = _MovimentoFinaceiroService.ValorUltimoMesEntrada();
            //var valorSaida = _MovimentoFinaceiroService.ValorUltimoMesSaida();
            //var valorTotal = _MovimentoFinaceiroService.ValorUltimoMesTotal();

            txtValorEntrada.Text = valorEntrada.ToString("N2");
            txtValorSaida.Text = valorSaida.ToString("N2");
            txtValorTotal.Text = valorTotal.ToString("N2");
            lblValorTotal.Text =   valorTotal.ToString("N2");

            if (valorTotal > 0)
                lblValorTotal.ForeColor = Color.LightGreen;
            else
                lblValorTotal.ForeColor = Color.FromArgb(255, 91, 96);
            //txtValorTotal.ForeColor = Color.FromArgb(255, 91, 96);

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
