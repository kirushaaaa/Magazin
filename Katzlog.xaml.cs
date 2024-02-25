using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Intrinsics.X86;
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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static Praktika1.Avtoriz;

namespace Praktika1
{
    public partial class Katzlog : Window
    {

        public List<Product> GetRandomProducts()
        {
            using (var dbContext = new AppDbContext())
            {
                var randomProducts = dbContext.Products.OrderBy(x => Guid.NewGuid()).ToList();

                return randomProducts;
            }
        }

        public Katzlog()
        {
            InitializeComponent();

            List<Product> randomProducts = GetRandomProducts();
            ProductListBox.ItemsSource = randomProducts;

            if (!string.IsNullOrEmpty(UserData.Username))
            {
                txt1.Text = UserData.Username;
            }

        }

        private void AddToCart_Click(object sender, RoutedEventArgs e)
        {
            
        }


        private void korzina(object sender, RoutedEventArgs e)
        {
            Korzina korzina = new Korzina();
            korzina.Show();
            this.Close();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {


            Lk lk = new Lk(UserData.Username);
            lk.Show();
            this.Close();
        }



    }

}
