/******************************************************************************/
/*                                                                            */
/*   Program: MyAppAutoReStart                                                */
/*   How to restart an application, by itself.                                */
/*                                                                            */
/*   07.04.2014 0.0.0.0 uhwgmxorg Start                                       */
/*                                                                            */
/******************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyAppAutoReStart
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// button_ThrowExeption_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_ThrowExeption_Click(object sender, RoutedEventArgs e)
        {
            throw new Exception("Fatal Error!");
        }
    }
}
