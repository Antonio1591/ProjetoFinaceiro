using apiProjetoFinaceiro.Model.Domain;
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
        private IEnumerable<CidadeViewModel> _cidadesViweModel;
        private IEnumerable<BairroViewModel> _bairrosViewModel;
        public frmRegistro(IUsuarioServices iUsuariosService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _IUsuariosService = iUsuariosService;
            _serviceProvider = serviceProvider;

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            var cidade = _cidadesViweModel.FirstOrDefault(C => C.Nome == cmbCidade.Text);
            if (cidade == null)
                return;
            var cidadeInput = new Cidade(cidade.Id, cidade.Nome, cidade.Cep, cidade.Situacao);
            var bairro = _bairrosViewModel.FirstOrDefault(C => C.Nome == cmbBairro.Text);
            if (bairro == null)
                return;
            var bairroInput = new Bairro(bairro.Id, bairro.Nome, bairro.Situacao);

            var usuarioCadastro = new UsuarioImputModel(txtNome.Text, mskSenha.Text, txtEmail.Text, txtTelefone.Text, cidadeInput, bairroInput, mskCPF.Text, dtNascimento.Value, "ativo");
            _IUsuariosService.CadastrarUsuario(usuarioCadastro);

            MessageBox.Show("Usuario Cadastrado");
        }

        private async void frmRegistro_Load(object sender, EventArgs e)
        {
            _cidadesViweModel = await _IUsuariosService.BuscarCidades();
            _bairrosViewModel = await _IUsuariosService.BuscarBairros();

            foreach (var bairro in _bairrosViewModel)
            {
                cmbBairro.Items.Add(bairro.Nome);
            }

            var cidades = _IUsuariosService.BuscarCidades();
            foreach (var cidade in _cidadesViweModel)
            {
                cmbCidade.Items.Add(cidade.Nome);
            }
        }
    }
}
