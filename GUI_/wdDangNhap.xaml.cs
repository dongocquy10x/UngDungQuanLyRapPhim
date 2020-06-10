using DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Linq;
using System.Data.Entity;

namespace GUI_
{
    /// <summary>
    /// Interaction logic for wdDangNhap.xaml
    /// </summary>
    public partial class wdDangNhap : Window
    {
        public wdDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new QlyRapPhimContext())
            {
                if(IsValidUser(txtTenDangNhap.Text, txtMatKhau.Password))
                {
                    MainWindow wd = new MainWindow();
                    wd.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai ten dang nhap hoac mat khau");
                }
            }
        }
        private bool IsValidUser(string username, string password)
        {
            using (var context = new QlyRapPhimContext())
            {
                var user = from u in context.Users
                           where u.TenDangNhap == txtTenDangNhap.Text && u.MatKhau == txtMatKhau.Password
                           select u;
                if (user.Any()) return true;
                else return false;
            }
        }
    }
}
