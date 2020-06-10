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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Linq;
using QlyRapPhim.BL;

namespace GUI_
{
    /// <summary>
    /// Interaction logic for DatVe.xaml
    /// </summary>
    public partial class DatVe : UserControl
    {
        public DatVe()
        {
            InitializeComponent();
        }

        private void btnClick(object sender, RoutedEventArgs e)
        {
            var btn = (Button)e.Source;
            var id = btn.Content;

            var wd = new wdDatVe2();
            wd.Show();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            //using (var context = new QlyRapPhimContext())
            //{
            //    var query =
            //        from ghe in context.Ghes
            //        where ghe.IsValid == false
            //        select ghe;
                
            //}
        }
    }
}
