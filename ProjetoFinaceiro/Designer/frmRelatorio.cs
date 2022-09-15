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


        private void Relatorio_Load(object sender, EventArgs e)
        {

        }
    }
}
