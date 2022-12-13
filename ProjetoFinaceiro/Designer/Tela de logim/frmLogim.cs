using apiProjetoFinaceiro.Model.Domain;
using apiProjetoFinaceiro.Model.Imput;
using apiProjetoFinaceiro.services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic;
using ProjetoFinaceiro.Designer.Tela_de_Cadastro;
using ProjetoFinaceiro.Modelo;
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


namespace ProjetoFinaceiro.Designer.Tela_de_logim
{
    public partial class frmLogim : Form
    {
        private readonly IUsuarioServices _IUsuariosService;
        private readonly IServiceProvider _serviceProvider;
        public frmLogim(IServiceProvider serviceProvider, IUsuarioServices frmLogim)
        {
            _serviceProvider = serviceProvider;
            _IUsuariosService = frmLogim;
            InitializeComponent();
          
        }


        private void btnLogar_Click(object sender, EventArgs e)
        {
           
            Login _login= new Login(txtEmail.Text,mskSenha.Text);
            
            _IUsuariosService.Logim(_login);


        }

        private void button2_Click(object sender, EventArgs e)
        {

            var form = _serviceProvider.GetService<frmRegistro>();
            form.Show();
        }
    }
}
