using apiProjetoFinaceiro.Model.Domain;
using apiProjetoFinaceiro.Model.Imput;
using apiProjetoFinaceiro.Model.View;
using apiProjetoFinaceiro.services;
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

namespace ProjetoFinaceiro.Designer.Usuario
{
    public partial class frmAlterarSenha : Form
    {
        private readonly IUsuarioServices _IUsuariosService;
        private readonly IServiceProvider _serviceProvider;
        public frmAlterarSenha(IUsuarioServices iUsuariosService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _IUsuariosService = iUsuariosService;
            _serviceProvider = serviceProvider;

        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            //if(string.IsNullOrEmpty(txtEmail.Text)||string.IsNullOrEmpty(mskCPF.Text))
            //{
            //    MessageBox.Show("Favor preencher todos os dados");
            //    return;
            //}
            //var usuarios =await _IUsuariosService.ListaUsuarios();
            //var BuscarUsuario = usuarios.FirstOrDefault(U => U.CPF == mskCPF.Text && U.Email == txtEmail.Text);
            //if ( BuscarUsuario == null)
            //{
            //    MessageBox.Show("Usuario não encontrado");
            //    return;
            //}
            //txtNome.Text = BuscarUsuario.Nome;
            //txtEmailAlterar.Text = BuscarUsuario.Email;
            //mskCpfAlterar.Text = BuscarUsuario.CPF;
            //txtEmail.Enabled = false;
            //mskCPF.Enabled = false;
            //mskSenha.Enabled = true;
            //btnAlterarSenha.Enabled=true;
        }

        private async void btnAlterarSenha_ClickAsync(object sender, EventArgs e)
        {
            //var usuarios = await _IUsuariosService.ListaUsuarios();
            //var BuscarUsuario = usuarios.FirstOrDefault(U => U.CPF == mskCPF.Text && U.Email == txtEmail.Text);

            //var cidade = _cidadesViweModel.FirstOrDefault(C => C.Nome == BuscarUsuario.Cidade);
            //if (cidade == null)
            //    return;
            //var cidadeInput = new Cidade(cidade.Id, cidade.Nome, cidade.Cep, cidade.Situacao);
            //var bairro = _bairrosViewModel.FirstOrDefault(B => B.Nome == BuscarUsuario.Bairro);
            //if (bairro == null)
            //    return;
            //var bairroInput = new Bairro(bairro.Id, bairro.Nome, bairro.Situacao);

            //var AlterarSenhaUsuario = new UsuarioImputModel(BuscarUsuario.Nome, mskSenha.Text, BuscarUsuario.Email, BuscarUsuario.Telefone, cidadeInput, bairroInput, BuscarUsuario.CPF, BuscarUsuario.DataNascimento, BuscarUsuario.Situacao);
            //var resultado = _IUsuariosService.AlterarSenha(AlterarSenhaUsuario);
        }

        private async void frmAlterarSenha_LoadAsync(object sender, EventArgs e)
        {
        }
    }
}
