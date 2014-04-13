using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MyAppAutoReStart
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public App()
        {
            this.Dispatcher.UnhandledException += OnDispatcherUnhandledException;
        }

        /// <summary>
        /// OnDispatcherUnhandledException
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnDispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            string ErrorMessage = string.Format("An unhandled exception occurred: {0}", e.Exception.Message);
            Debug.WriteLine(ErrorMessage);
            e.Handled = true;
            ApplicationReStart();
        }

        /// <summary>
        /// ApplicationReStart
        /// </summary>
        void ApplicationReStart()
        {
            string ErrorMessage = string.Format("The application has encountered a problem and needs to be restarted!");
            MessageBox.Show(ErrorMessage, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
            System.Windows.Application.Current.Shutdown();
        }
    }
}
