using Microsoft.Data.SqlClient;
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
using System.Windows.Shapes;
using static Azure.Core.HttpHeader;
using static Praktika1.Registr;

namespace Praktika1
{
    public partial class Lk : Window
    {
        public Lk(string Login2)
        {
            InitializeComponent();

            Imya_polz.Text = $"{Login2}";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void katalog(object sender, RoutedEventArgs e)
        {
            Katzlog katzlog = new Katzlog();
            katzlog.Show();
            this.Close();
        }

        private void korzina(object sender, RoutedEventArgs e)
        {
            Korzina korza = new Korzina();  
            korza.Show();
            this.Close();
        }
    }
}
