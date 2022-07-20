using SimpleMVVMModel.View;
using SimpleMVVMModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SimpleMVVMModel
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Mainpage window = new Mainpage();
            UserViewModel VM = new UserViewModel();
            window.DataContext = VM;
            window.ShowDialog();
        }
    }
}
