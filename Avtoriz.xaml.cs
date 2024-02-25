using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Threading;
using static Praktika1.Registr;

namespace Praktika1
{
    public partial class Avtoriz : Window
    {

        public Avtoriz()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Registr rg = new Registr();
            rg.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var login1 = vxod_login.Text;
            var pass1 = vxod_parol.Text;
            var context = new AppDbContext();

            var user1 = context.Users.SingleOrDefault(x => x.Login == login1 && x.Password == pass1);
            UserData.Username = user1.Name;
            var Login2 = user1.Name;

            if(user1 != null && user1.Password == pass1)
            {
                Hide();
                var Lk = new Lk(UserData.Username);
                Lk.Show();
            }

            else
            {
                MessageBox.Show("Неправильный логин или пароль");
            }
        }
    }
}
