using BugApplication.RepositoryInterfaces;
using BugApplication.Services;
using BugInfrastructure;
using BugInfrastructure.DataAccess.Repos;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Presentation.Tabs;
using System.Configuration;

namespace Presentation
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var connectionString = ConfigurationManager.AppSettings["connectionString"];
            var sqlConnectionStringBuilder = new SqlConnectionStringBuilder(connectionString);
            var dbContextOptionsBuilder = new DbContextOptionsBuilder<BugsContext>()
                .UseSqlServer(sqlConnectionStringBuilder.ConnectionString,
                options => options.EnableRetryOnFailure(10, TimeSpan.FromSeconds(30), null));
            BugsContext bugsContext = new(dbContextOptionsBuilder.Options);
            bugsContext.Database.EnsureCreated();

            IAngajatRepo angajatRepo = new AngajatDbRepo(bugsContext);
            IProgramatorRepo programatorRepo = new ProgramatorDbRepo(bugsContext);
            IVerificatorRepo verificatorRepo = new VerificatorDbRepo(bugsContext);
            IBugRepo bugRepo = new BugDbRepo(bugsContext);
            IPasBugRepo pasBugRepo = new PasBugDbRepo(bugsContext);
            IMesajRepo mesajRepo = new MesajDbRepo(bugsContext);

            ServiceAngajat serviceAngajat = new(angajatRepo);
            ServiceBug serviceBug = new(bugRepo);
            ServicePasBug servicePasBug = new(pasBugRepo);
            ServiceMesaj serviceMesaj = new(mesajRepo);

            Application.Run(new FormMain(
                serviceAngajat, serviceBug, servicePasBug, serviceMesaj));
        }
    }
}