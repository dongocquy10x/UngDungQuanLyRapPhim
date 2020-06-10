using DataAccess;
using System;
using System.Windows;
using System.Windows.Controls;
using QlyRapPhim.BL;

namespace GUI_
{
    /// <summary>
    /// Interaction logic for uctThemPhim_.xaml
    /// </summary>
    public partial class uctThemPhim_ : UserControl
    {
        public uctThemPhim_()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            var phim = new Phim
            {
                Ten = txtTenPhim.Text,
                NgayKhoiChieu = DateTime.Parse(ngayKhoiChieu.Text),
                theloai = new TheLoai { TenTheLoai = txtTheLoai.Text },
                ThoiLuong = int.Parse(txtThoiLuong.Text),
                NgonNgu = txtNgonNgu.Text,
                Rated = float.Parse(txtRated.Text)
            };

            if (Phim.KiemTraInputHopLe(phim).Item1)
            {
                try
                {
                    using (var context = new QlyRapPhimContext())
                    {
                        context.Phims.Add(phim);
                        context.SaveChanges();
                        MessageBox.Show(Phim.KiemTraInputHopLe(phim).Item2, "Success");
                    }
                }
                catch
                {
                    // .......
                }
            }
            else
            {
                MessageBox.Show(Phim.KiemTraInputHopLe(phim).Item2, "Error");
            }
        }
    }
}
