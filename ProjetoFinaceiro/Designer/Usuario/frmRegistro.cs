using apiProjetoFinaceiro.Model.Domain;
using apiProjetoFinaceiro.Model.Domain.UsuarioIdentityRepositorio;
using apiProjetoFinaceiro.Model.Imput;
using apiProjetoFinaceiro.Model.View;
using apiProjetoFinaceiro.services;
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

namespace ProjetoFinaceiro.Designer.Tela_de_Cadastro
{
    public partial class frmRegistro : Form
    {
        private readonly IUsuarioServices _IUsuariosService;
        private readonly IServiceProvider _serviceProvider;
        public frmRegistro(IUsuarioServices iUsuariosService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _IUsuariosService = iUsuariosService;
            _serviceProvider = serviceProvider;

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            var usuarioCadastro = new UsuarioCadastroRequest(txtEmail.Text, txtSenha.Text,txtSenhaConfirmacao.Text);


            var resultado = _IUsuariosService.CadastrarUsuarioIdentity(usuarioCadastro);
            if(resultado != null)
                MessageBox.Show("Usuario Cadastrado");

            this.Close();
           
        }

        private async void frmRegistro_Load(object sender, EventArgs e)
        {
           
        }
    }
}
