using DataAccess;
using QlyRapPhim.BL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace GUI_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<QlyRapPhimContext>());
            InitializeComponent();
        }

        private void btnThemNhanVien_Click(object sender, RoutedEventArgs e)
        {
            var wd = new wdQlyNhanVien();
            wd.Show();
        }

        private void btnDatVe_Click(object sender, RoutedEventArgs e)
        {
            ActiveItem.Content = new DatVe();
        }

        private void btnDkyThanhVien_Click(object sender, RoutedEventArgs e)
        {
            ActiveItem.Content = new DangKyThanhVien();
        }

        private void btnThemPhim_Click(object sender, RoutedEventArgs e)
        {
            ActiveItem.Content = new uctThemPhim_();
        }

        private void btnThemLichChieu_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
