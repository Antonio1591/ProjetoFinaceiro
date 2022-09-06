using Microsoft.Extensions.DependencyInjection;
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
        public frmPrincipal(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void adicionarEntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmEntrada().Show();
        }

        private void tiposDeEntradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetService<frmCadastroTiposEntradaESaida>();

            form.Show();
        }
    }
}
