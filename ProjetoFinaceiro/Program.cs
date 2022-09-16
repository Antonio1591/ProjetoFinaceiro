using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using ProjetoFinaceiro.Data;
using ProjetoFinaceiro.Designer;
using ProjetoFinaceiro.Modelo;
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
            services.AddTransient<frmPrincipal>();
            services.AddTransient<frmCadastroTiposEntradaESaida>();
            services.AddTransient<MovimentoFinaceiro>();
            services.AddTransient<MovimentoFinaceiroService>();
            services.AddTransient<EntradaFinaceira>();
            services.AddTransient<EntradaFinaceiraService>();
            services.AddTransient<SaidaFinaceira>();
            services.AddTransient<SaidaFinaceiraService>();
            services.AddTransient<frmEntrada>();
            services.AddTransient<TiposService>();
            services.AddTransient<frmSaida>();
            services.AddTransient<frmRelatorio>();

            var serverVersion = new MySqlServerVersion(new Version(8, 0, 29));

            services.AddDbContext<FinanceiroDbContext>(opt =>
            {
                opt.UseMySql("Server=localhost;port=3306;User Id=root; database=projetofinaceiro;password=GH#@Mn47spW!HH$yvv76", serverVersion)
                .LogTo(Console.WriteLine, LogLevel.Information);
            });


            ServiceProvider = services.BuildServiceProvider();

            var formPrincipal = ServiceProvider.GetService<frmPrincipal>();
            Application.Run(formPrincipal);
        }
    }
}