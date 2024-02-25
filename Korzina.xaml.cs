using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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

namespace Praktika1
{
    public partial class Korzina : Window
    {

        public Korzina()
        {
            InitializeComponent();

            using (var context = new AppDbContext())
            {
                var users = context.Products.ToList();

                cartDataGrid.Items.Add(new { Product = Name, Pricee = 10, Kol = 1 });
            }
        }
        private void Checkout_Click(object sender, RoutedEventArgs e)
        {
            // логика оформления заказа
        }
    }
}
