using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Autofac;
using DevExpress.Entity.Model;
using DevExpress.LookAndFeel;
using DevExpress.Mvvm;
using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.Utils.Design;
using DevExpress.Utils.MVVM.Services;
using DevExpress.Xpo.Logger.Transport;
using ExternalTestLibrary;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using XtraFormsTest.Forms;
using XtraFormsTest.ViewModels;

namespace XtraFormsTest
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Autofac.ContainerBuilder builder = new Autofac.ContainerBuilder();
            //builder.RegisterType<PersonRepository>().As<IPersonRepository>().SingleInstance();
            //var container = builder.Build();

            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            ServiceProvider = serviceCollection.BuildServiceProvider();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Program.ServiceProvider.GetRequiredService<GridViewTest>());
        }

        public static IServiceProvider ServiceProvider { get; private set; }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IPersonRepository, PersonRepository>();
            services.AddTransient<PersonViewModel>();
            services.AddTransient<GridViewTest>();
            services.AddTransient<TableLayoutPanelTest>();
            services.AddTransient<TextManipulationView>();

            services.AddTransient<Func<GridViewTest>>(provider =>
                () => provider.GetRequiredService<GridViewTest>());
            services.AddTransient<Func<TextManipulationView>>(provider =>
                () => provider.GetRequiredService<TextManipulationView>());
        }
    }
}
