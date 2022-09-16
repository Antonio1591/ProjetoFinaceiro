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
    public partial class frmPrincipal : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly MovimentoFinaceiroService _MovimentoFinaceiroService;

        public frmPrincipal(IServiceProvider serviceProvider, MovimentoFinaceiroService _movimentoFinaceiroService)
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

        private void tiposDeEntradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var form = serviceProvider.GetService<frmCadastroTiposEntradaESaida>();
            var form1 = _serviceProvider.GetService<frmCadastroTiposEntradaESaida>();
            form1.Show();

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            var valorEntrada = _MovimentoFinaceiroService.ValorUltimoMesEntrada();
            var valorSaida = _MovimentoFinaceiroService.ValorUltimoMesSaida();
            var valorTotal = _MovimentoFinaceiroService.ValorUltimoMesTotal();

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
        private void adicionarValorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetService<frmSaida>();
            form.Show();
        }

        private void finaceiroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetService<frmRelatorio>();
            form.Show();
        }
    }
}
