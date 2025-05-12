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
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using ExternalTestLibrary;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using XtraFormsTest.Forms;
using XtraFormsTest.Services;
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
            //visual configuration
            //https://docs.devexpress.com/WindowsForms/403964/build-an-application/choose-application-ui/windows-11-UI
            UserLookAndFeel.Default.SetSkinStyle(SkinStyle.WXI);
            //UserLookAndFeel.Default.SetSkinStyle(SkinStyle.Office2019Black);
            WindowsFormsSettings.CompactUIMode = DevExpress.Utils.DefaultBoolean.True;

            //Enable DirectX Hardware Acceleration
            WindowsFormsSettings.ForceDirectXPaint();

            DevExpress.XtraEditors.WindowsFormsSettings.DefaultFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            //makes the app more touch screen friendly by eg.increasing controls size by a specific factor
            //DevExpress.XtraEditors.WindowsFormsSettings.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.True;
            //DevExpress.XtraEditors.WindowsFormsSettings.TouchScaleFactor = 2F;


            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            ServiceProvider = serviceCollection.BuildServiceProvider();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Program.ServiceProvider.GetRequiredService<NavigationFrameTest>());
        }

        public static IServiceProvider ServiceProvider { get; private set; }

        private static void ConfigureServices(IServiceCollection services)
        {
            //services
            services.AddTransient<IPersonRepository, PersonRepository>();
            services.AddTransient<IUIConfigService, UIConfigService>();
            services.AddSingleton<ILocalisationProvider, LocalisationProvider>();

            //viewModels
            services.AddTransient<PersonViewModel>();
            services.AddTransient<EditPersonViewModel>();
            services.AddTransient<TextManipulationViewModel>();

            //views
            services.AddTransient<NavigationFrameTest>();
            services.AddTransient<GridViewTest>();
            services.AddTransient<TableLayoutPanelTest>();
            services.AddTransient<TextManipulationView>();
            services.AddTransient<EditPersonForm>();

            //factories needed to create new forms with required by them dependencies
            services.AddTransient<Func<TableLayoutPanelTest>>(provider =>
                () => provider.GetRequiredService<TableLayoutPanelTest>());
            services.AddTransient<Func<GridViewTest>>(provider =>
                () => provider.GetRequiredService<GridViewTest>());
            services.AddTransient<Func<TextManipulationView>>(provider =>
                () => provider.GetRequiredService<TextManipulationView>());
            services.AddTransient<Func<EditPersonForm>>(provider =>
                () => provider.GetRequiredService<EditPersonForm>());
            services.AddTransient<Func<NavigationFrameTest>>(provider =>
                () => provider.GetRequiredService<NavigationFrameTest>());
        }
    }
}
