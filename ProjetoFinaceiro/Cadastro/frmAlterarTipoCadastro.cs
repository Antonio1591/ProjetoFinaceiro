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

namespace ProjetoFinaceiro.Designer.Cadastro
{
    public partial class frmAlterarTipoCadastro : Form
    {
        //private readonly TiposService _tiposService;

        //private Tipos _tipos;
        //public frmAlterarTipoCadastro(TiposService tiposService)
        //{
        //    InitializeComponent();
        //    _tiposService = tiposService;
        //}

        //private void frmAlterarTipoCadastro_Load(object sender, EventArgs e)
        //{
        //    cmbTipoOperacao.Enabled = false;
        //    txtDescriscao.Enabled = false;
        //    cmbSituacao.Enabled = false;
        //}

        //private void btnCancelar_Click(object sender, EventArgs e)
        //{
        //    //if (MessageBox.Show("Deseja fechar essa tela? ", "Fechar tela", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //    //    this.Close();
        //    txtCodigo.Clear();
        //    txtNomeOperacao.Clear();
        //    txtDescriscao.Clear();
        //    cmbSituacao.SelectedIndex = -1;
        //    cmbTipoOperacao.SelectedIndex = -1;
        //    txtDescriscao.Enabled = false;
        //    cmbSituacao.Enabled = false;
        //    cmbTipoOperacao.Enabled = false;
        //    btnInserir.Enabled = false;
        //    btnInserir.Visible = false;
        //    btnBuscar.Enabled = true;
        //    btnBuscar.Visible = true;
        //    txtCodigo.Enabled = true;
        //    lblPesquisar.Text = "Buscar Cadastro";


        //}

        //private void btnBuscar_Click(object sender, EventArgs e)
        //{

        //    Modelo.Tipos tipo = _tiposService.obterTipo(string.IsNullOrWhiteSpace(txtCodigo.Text) ? 0 : int.Parse(txtCodigo.Text), txtNomeOperacao.Text);
        //    if (tipo == null)
        //    {
        //        MessageBox.Show("Informação Invalida, codigo ou nome não encontrado");
        //        return;
        //    }

        //    _tipos = tipo;
        //    if (tipo.Id == 0) return;

        //    txtCodigo.Text = tipo.Id.ToString();
        //    txtNomeOperacao.Text = tipo.Nome;
        //    cmbTipoOperacao.Text = tipo.Tipo;
        //    txtDescriscao.Text = tipo.Descricao.ToString();
        //    cmbSituacao.Text = tipo.Situacao;
        //    lblPesquisar.Text = "Alterar Cadastro";
        //    btnInserir.Enabled = true;
        //    btnInserir.Visible = true;
        //    txtCodigo.Enabled = false;
        //    cmbSituacao.Enabled = true;
        //    cmbTipoOperacao.Enabled = true;
        //    txtDescriscao.Enabled = true;
        //    btnBuscar.Enabled = false;
        //    btnBuscar.Visible = false;
        //}

        //private void btnInserir_Click(object sender, EventArgs e)
        //{

        //    if (_tipos.Id == 0)
        //    {
        //        _tipos = new Modelo.Tipos(Convert.ToInt32(txtCodigo.Text), txtNomeOperacao.Text, cmbTipoOperacao.Text, txtDescriscao.Text, cmbSituacao.Text);
        //        _tiposService.Inserir(_tipos);

        //    }
        //    else
        //    {
        //        _tipos.Id = Convert.ToInt32(txtCodigo.Text);
        //        _tipos.Nome = txtNomeOperacao.Text;
        //        _tipos.Tipo = cmbTipoOperacao.Text;
        //        _tipos.Descricao = txtDescriscao.Text;
        //        _tipos.Situacao = cmbSituacao.Text;

        //        _tiposService.Update(_tipos);
        //    }
        //    _tiposService.Commit();
        //    MessageBox.Show("Tipo Atualizado", "Atualizar Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //}
    }
}
