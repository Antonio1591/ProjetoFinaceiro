using ProjetoFinaceiro.Modelo;
using ProjetoFinaceiro.Services;
using System.Globalization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinaceiro.Designer.Movimentação
{
    public partial class frmAlteracaoDeMovimentacao : Form
    {
        //private readonly MovimentoFinaceiroService _movimentoFinaceiroService;
        //private MovimentoFinaceiro _movimentoFinaceiro;

        //public frmAlteracaoDeMovimentacao(MovimentoFinaceiroService movimentoFinaceiroService)
        //{
        //    InitializeComponent();
        //    _movimentoFinaceiroService = movimentoFinaceiroService;
        //}

        //private void btnBuscar_Click(object sender, EventArgs e)
        //{
           

        //    Modelo.MovimentoFinaceiro movimentacao = _movimentoFinaceiroService.ObtermovimentoFinaceiro(string.IsNullOrWhiteSpace(txtCodigo.Text) ? 0 : int.Parse(txtCodigo.Text), txtNomeOperacao.Text);
        //    if (movimentacao == null)
        //    {
        //        MessageBox.Show("Informação Invalida, codigo ou nome não encontrado");
        //        return;
        //    }
        //    if (movimentacao.TipoOperacao_Finaceiro == "Entrada")
        //    {
        //        txtValorSaida.Text = 0.ToString();
        //        txtValorSaida.Visible = false;
        //        txtValorSaida.Enabled = false;
        //        txtValorEntrada.Visible = true;
        //        txtValorEntrada.Enabled = true;
        //    }
        //    else
        //    {
        //        txtValorEntrada.Text = 0.ToString();
        //        txtValorEntrada.Visible = false;
        //        txtValorEntrada.Enabled = false;
        //        txtValorSaida.Visible = true;
        //        txtValorSaida.Enabled = true;
        //    }
        //    _movimentoFinaceiro = movimentacao;
        //    if (movimentacao.Id == 0) return;

        //    txtCodigo.Text = movimentacao.Id.ToString();
        //    txtNomeOperacao.Text = movimentacao.NomeOperacao_Finaceiro;
        //    cmbTipoOperacao.Text = movimentacao.TipoOperacao_Finaceiro;
        //    txtValorEntrada.Text = movimentacao.ValorEntrada_Finaceiro.ToString();
        //    txtValorSaida.Text= movimentacao.ValorSaida_Finaceiro.ToString();
        //    dtMovimentacao.Value = _movimentoFinaceiro.DataMovimentacao_Finaceiro;
        //    cmbSituacao.Text= movimentacao.Situacao_Finaceiro.ToString();
         

        //    lblPesquisar.Text = "Alterar Cadastro";
        //    btnInserir.Enabled = true;
        //    btnInserir.Visible = true;
        //    txtCodigo.Enabled = false;
        //    cmbSituacao.Enabled = true;
        //    dtMovimentacao.Enabled = true;
        //  // cmbTipoOperacao.Enabled = true;
        //    txtValorEntrada.Enabled = true;
        //    btnBuscar.Enabled = false;
        //    btnBuscar.Visible = false;
          
        //}

        //private void btnInserir_Click(object sender, EventArgs e)
        //{
           
        //    if (_movimentoFinaceiro.Id == 0)
        //    {
        //        _movimentoFinaceiro = new Modelo.MovimentoFinaceiro(Convert.ToInt32(txtCodigo.Text), txtNomeOperacao.Text, cmbTipoOperacao.Text, double.Parse(txtValorEntrada.Text), double.Parse(txtValorSaida.Text), DateTime.Now, cmbSituacao.Text);

        //        _movimentoFinaceiroService.InserirMovimentacao(_movimentoFinaceiro);

        //    }
        //    else
        //    {
        //        _movimentoFinaceiro.Id = Convert.ToInt32(txtCodigo.Text);
        //        _movimentoFinaceiro.NomeOperacao_Finaceiro = txtNomeOperacao.Text;
        //        _movimentoFinaceiro.TipoOperacao_Finaceiro = cmbTipoOperacao.Text;
        //        _movimentoFinaceiro.ValorEntrada_Finaceiro = double.Parse(txtValorEntrada.Text);
        //        _movimentoFinaceiro.ValorSaida_Finaceiro = double.Parse(txtValorSaida.Text);
        //        _movimentoFinaceiro.DataMovimentacao_Finaceiro = dtMovimentacao.Value;
        //        _movimentoFinaceiro.Situacao_Finaceiro = cmbSituacao.Text;

        //        _movimentoFinaceiroService.UpdateMovimentacao(_movimentoFinaceiro);
        //    }
        //    _movimentoFinaceiroService.CommitMovimentacao();
        //    MessageBox.Show("Tipo Atualizado", "Atualizar Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    this.Close();
        //}

        //private void btbLimpar_Click(object sender, EventArgs e)
        //{
        //    txtCodigo.Clear();
        //    txtNomeOperacao.Clear();
        //    txtValorEntrada.Clear();
        //    txtValorSaida.Clear();
        //    cmbSituacao.SelectedIndex = -1;
        //    cmbTipoOperacao.SelectedIndex = -1;
        //    txtValorEntrada.Enabled = false;
        //    dtMovimentacao.Enabled = false;
        //    txtValorSaida.Enabled = false;
        //    cmbSituacao.Enabled = false;
        //    cmbTipoOperacao.Enabled = false;
        //    btnInserir.Enabled = false;
        //    btnInserir.Visible = false;
        //    btnBuscar.Enabled = true;
        //    btnBuscar.Visible = true;
        //    txtCodigo.Enabled = true;
        //    lblPesquisar.Text = "Buscar Cadastro";
        //}

        //private void frmAlteracaoDeMovimentacao_Load(object sender, EventArgs e)
        //{
        //    dtMovimentacao.Value = DateTime.Now;
        //    //.ToString("yyyy-MM-dd  HH:mm:ss")
        //    dtMovimentacao.Enabled = false;
        //    cmbTipoOperacao.Enabled = false;
        //    txtValorEntrada.Enabled = false;
        //    txtValorSaida.Enabled = false;
        //    cmbSituacao.Enabled = false;
        //    btnInserir.Visible = false;
        //    btnInserir.Enabled = false;
        //}
    }
}
