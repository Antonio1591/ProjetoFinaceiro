using apiProjetoFinaceiro.services;
using Microsoft.Extensions.DependencyInjection;
using ProjetoFinaceiro.Designer.Tela_de_Cadastro;
using ProjetoFinaceiro.Designer.Tela_de_logim;
using ProjetoFinaceiro.Designer.Usuario;

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
            //services.AddTransient<frmPrincipal>();
            //services.AddTransient<frmCadastroTiposEntradaESaida>();
            ////services.AddTransient<MovimentoFinaceiro>();
            //services.AddTransient<MovimentoFinaceiroService>();
            ////services.AddTransient<EntradaFinaceira>();
            //services.AddTransient<EntradaFinaceiraService>();
            ////services.AddTransient<SaidaFinaceira>();
            //services.AddTransient<SaidaFinaceiraService>();
            //services.AddTransient<frmEntrada>();
            //services.AddTransient<TiposService>();
            //services.AddTransient<frmSaida>();
            //services.AddTransient<frmRelatorio>();
            //services.AddTransient<frmAlterarTipoCadastro>();
            //services.AddTransient<frmAlteracaoDeMovimentacao>();
            services.AddTransient<frmLogim>();
            services.AddTransient<frmRegistro>();
            services.AddTransient<frmAlterarSenha>();
            services.AddTransient<IUsuarioServices,UsuarioServices>();


            ServiceProvider = services.BuildServiceProvider();

            var formPrincipal = ServiceProvider.GetService<frmLogim>();

            Application.Run(formPrincipal);
          
        }
    }
}