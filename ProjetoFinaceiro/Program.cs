using apiProjetoFinaceiro.services;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using ProjetoFinaceiro.Designer;
using ProjetoFinaceiro.Designer.Tela_de_Cadastro;
using ProjetoFinaceiro.Designer.Tela_de_logim;
using ProjetoFinaceiro.Designer.Usuario;
using ProjetoFinaceiro.Services;

namespace ProjetoFinaceiro
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();
            services.AddScoped<frmPrincipal>();
            services.AddTransient<frmCadastroTiposEntradaESaida>();
            ////services.AddTransient<MovimentoFinaceiro>();
            //services.AddTransient<MovimentoFinaceiroService>();
            ////services.AddTransient<EntradaFinaceira>();
            //services.AddTransient<EntradaFinaceiraService>();
            ////services.AddTransient<SaidaFinaceira>();
            //services.AddTransient<SaidaFinaceiraService>();
            services.AddTransient<frmEntrada>();
            services.AddTransient<frmSaida>();
            //services.AddTransient<frmRelatorio>();
            //services.AddTransient<frmAlterarTipoCadastro>();
            //services.AddTransient<frmAlteracaoDeMovimentacao>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddHttpClient<ApiClient>();
            services.AddSingleton<AspNetUser>();
            services.AddTransient<frmLogim>();
            services.AddTransient<frmRegistro>();
            services.AddTransient<frmAlterarSenha>();
            services.AddTransient<IUsuarioServices, UsuarioServices>();
            services.AddTransient<IMovimentacaoFinanceiraServices, MovimentacaoFinanceiraServices>();
            services.AddTransient<ITipoMovimentacaoServices, TipoMovimentacaoServices>();

            ServiceProvider = services.BuildServiceProvider();
            var frmLogin = ServiceProvider.GetService<frmLogim>();

            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                var formPrincipal = ServiceProvider.GetService<frmPrincipal>();
                Application.Run(formPrincipal);
            }
            else
            {
                MessageBox.Show("Tente Novamente");
                return;
            }


        }
    }
}