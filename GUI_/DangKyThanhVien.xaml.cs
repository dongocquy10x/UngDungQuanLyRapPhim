using DataAccess;
using System.Data.Entity.Validation;
using System.Windows;
using System.Windows.Controls;
using System.Linq;
using QlyRapPhim.BL;
using System.Data.Entity;

namespace GUI_
{
    /// <summary>
    /// Interaction logic for DangKyThanhVien.xaml
    /// </summary>
    public partial class DangKyThanhVien : UserControl
    {
        public DangKyThanhVien()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, RoutedEventArgs e)
        {
            var user = new User
            {
                TenDangNhap = txtTenDangNhap.Text,
                MatKhau = txtMatKhau.Password
            };

            if (User.KiemTraInput(user).Item1)
            {
                try
                {
                    using (var context = new QlyRapPhimContext())
                    {
                        // Kiểm tra tên đăng nhập có tồn tại trong hệ thống hay chưa ?
                        var username =
                            from u in context.Users
                            where u.TenDangNhap == user.TenDangNhap
                            select u;
                        if (username.Count() > 0)
                        {
                            MessageBox.Show("Ten dang nhap da ton tai", "Error");
                            return;
                        } 

                        context.Users.Add(user);
                        context.SaveChanges();
                        MessageBox.Show(User.KiemTraInput(user).Item2, "Success");
                    }
                }
                // Lỗi với MaxLength(10), MaxLength(50)
                catch (DbEntityValidationException)
                {
                    MessageBox.Show("Loi~");
                }
            }
            else
            {
                MessageBox.Show(User.KiemTraInput(user).Item2, "Error");
            }
        }

    }
}

