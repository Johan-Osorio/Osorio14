using Osorio14.DataContext;
using Osorio14.Interfaces;
using Osorio14.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Osorio14
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CompraView();
        }

        public static AppDbContext GetContext()
        {
            string DbPath = DependencyService.Get<IConfigDataBase>().GetFullPath("efCore.db");

            return new AppDbContext(DbPath);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
