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
    public partial class frmEntrada : Form
    {
        private readonly TiposService _tiposService;
        private readonly EntradaFinaceiraService _EntradaFinaceiraService;
        private readonly MovimentoFinaceiroService _MovimentoFinaceiroService;

        public frmEntrada(TiposService tiposService, EntradaFinaceiraService _entradaFinaceiraService, MovimentoFinaceiroService movimentoFinaceiroService)
        {
            _tiposService = tiposService;
            _EntradaFinaceiraService = _entradaFinaceiraService;
            _MovimentoFinaceiroService = movimentoFinaceiroService;
            InitializeComponent();
        }

        private void frmEntrada_Load(object sender, EventArgs e)
        {
            var tipo = _tiposService.obterTipoEntrada();

            foreach (var tipos in tipo)
            {
                cmbEntradas.Items.Add(tipos.Nome);

            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cmbEntradas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

            double valor = Convert.ToDouble(substituicaoTxtValor1.Text.Replace("R$ ", "")); ;

            DateTime data= DateTime.Now;
            MessageBox.Show(valor.ToString(), data.ToString());


            if (cmbEntradas.Text == "" || substituicaoTxtValor1.Text == "")
            {
                MessageBox.Show("Não pode ter campos vazios! ", "Campos vazios! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            _EntradaFinaceiraService.Salvar(new Modelo.EntradaFinaceira(cmbEntradas.Text,valor, DateTime.Now, "ATIVO"));
            MessageBox.Show("Operação cadastrada! ", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _MovimentoFinaceiroService.Salvar(new Modelo.MovimentoFinaceiro(cmbEntradas.Text, "Entrada", valor, 0, DateTime.Now, "ATIVO"));
        }
    }
}

