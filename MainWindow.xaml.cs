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

namespace Praktika1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Registr(object sender, RoutedEventArgs e)
        {
            Registr reg = new Registr();
            reg.Show();
            this.Close();
        }

        private void Avtor(object sender, RoutedEventArgs e)
        {
            Avtoriz avt = new Avtoriz();
            avt.Show();
            this.Close();
        }
    }
}
