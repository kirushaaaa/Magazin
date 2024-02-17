using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer.Server;
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
using System.Text.RegularExpressions;
using System.Windows.Threading;

namespace Praktika1
{
    public partial class Registr : Window
    {
        public class User
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Login { get; set; }
            public string Password { get; set; }

        }

        public class AppDbContext : DbContext
        {
            public DbSet<User> Users { get; set; }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Pchelyakova_magaz;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            }
        }

        public Registr()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Avtoriz av = new Avtoriz();
            av.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var imya = vvod_imeni.Text;
            var login = vvod_logina.Text;
            var pass = vvod_parol.Text;

            var context = new AppDbContext();
            var user_exists = context.Users.FirstOrDefault(x => x.Login == login);

            if(user_exists is not null)
            {
                MessageBox.Show("Такой пльзователь уже зарегистрирован");
                return;
            }



            var user = new User { Login = login, Name = imya, Password = pass };
            context.Users.Add(user);
            context.SaveChanges();

            MessageBox.Show("Вы зарегистрировались!");

            Avtoriz avtoriz = new Avtoriz();
            avtoriz.Show();
            this.Close();
        }
    }
}
