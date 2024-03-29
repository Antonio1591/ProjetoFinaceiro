﻿using ProjetoFinaceiro.Model.Enum;
using ProjetoFinaceiro.Model.Imput;
using ProjetoFinaceiro.Modelo.Domain;
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
    public partial class frmCadastroTiposEntradaESaida : Form
    {
        private readonly ITipoMovimentacaoServices _ITipoMovimentacaoServices;
        public frmCadastroTiposEntradaESaida(ITipoMovimentacaoServices tiposService)
        {
            _ITipoMovimentacaoServices = tiposService;
            InitializeComponent();

        }
        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtNomeOperacao.Text == "" || cmbTipoOperacao.Text == "" || txtDescriscao.Text == "")
            {
                MessageBox.Show("Não pode haver campos vazios", "Campos vazios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            TipoMovimentacaoEnum tipoOperacao = (TipoMovimentacaoEnum)Enum.Parse(typeof(TipoMovimentacaoEnum),cmbTipoOperacao.Text);

            var InputTipoMovimentacao = new TipoMovimentacaoInputModel(tipoOperacao, txtDescriscao.Text,SituacaoEnum.ATIVO);

            _ITipoMovimentacaoServices.CadastrarTipos(InputTipoMovimentacao);
          
            txtNomeOperacao.Clear();
            txtDescriscao.Clear();
            cmbTipoOperacao.SelectedIndex = -1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fechar essa tela? ", "Fechar tela", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    } 
}