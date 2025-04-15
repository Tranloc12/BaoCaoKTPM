using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30_Loc_43_N2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        // nút cộng 
        private void btCong_30_Loc_Click(object sender, EventArgs e)
        {
            int a_30_Loc, b_30_Loc, ketQua_30_Loc;

            // Lấy giá trị từ ô nhập txtSo1 và chuyển sang kiểu int
            a_30_Loc = int.Parse(txtSo1_30_Loc.Text);

            // Lấy giá trị từ ô nhập txtSo2 và chuyển sang kiểu int
            b_30_Loc = int.Parse(txtSo2_30_Loc.Text);

            // Tạo đối tượng Caculation_30_Loc với 2 số a và b
            Caculation_30_Loc c_30_Loc = new Caculation_30_Loc(a_30_Loc, b_30_Loc);

            // Thực hiện phép cộng ("+") thông qua phương thức Execute
            ketQua_30_Loc = c_30_Loc.Execute("+");

            // Hiển thị kết quả phép cộng lên ô txtKetQua
            txtKetQua_30_Loc.Text = ketQua_30_Loc.ToString();
        }
        // nút trừ 
        private void btnTru_30_Loc_Click(object sender, EventArgs e)
        {
            // Khai báo biến
            int a_30_Loc, b_30_Loc, ketQua_30_Loc;

            // Lấy giá trị từ ô nhập và chuyển sang kiểu int
            a_30_Loc = int.Parse(txtSo1_30_Loc.Text);
            // Lấy giá trị từ ô nhập và chuyển sang kiểu int
            b_30_Loc = int.Parse(txtSo2_30_Loc.Text);

            // Tạo đối tượng tính toán
            Caculation_30_Loc c_30_Loc = new Caculation_30_Loc(a_30_Loc, b_30_Loc);

            // Gọi phương thức Execute để thực hiện phép trừ
            ketQua_30_Loc = c_30_Loc.Execute("-");

            // Hiển thị kết quả ra giao diện
            txtKetQua_30_Loc.Text = ketQua_30_Loc.ToString();
        }
        // nút nhân 
        private void btnNhan_30_Loc_Click(object sender, EventArgs e)
        {
            // Khai báo biến
            int a_30_Loc, b_30_Loc, ketQua_30_Loc;

            // Lấy giá trị từ ô nhập và chuyển sang kiểu int
            a_30_Loc = int.Parse(txtSo1_30_Loc.Text);
            // Lấy giá trị từ ô nhập và chuyển sang kiểu int
            b_30_Loc = int.Parse(txtSo2_30_Loc.Text);

            // Tạo đối tượng Caculation để thực hiện phép toán
            Caculation_30_Loc c_30_Loc = new Caculation_30_Loc(a_30_Loc, b_30_Loc);

            // Gọi hàm thực hiện phép nhân
            ketQua_30_Loc = c_30_Loc.Execute("*");

            // Hiển thị kết quả phép nhân
            txtKetQua_30_Loc.Text = ketQua_30_Loc.ToString();
        }
        // nút chia 
        private void btnChia_30_Loc_Click(object sender, EventArgs e)
        {
            // Khai báo biến
            int a_30_Loc, b_30_Loc, ketQua_30_Loc;

            // Lấy số từ giao diện người dùng
            a_30_Loc = int.Parse(txtSo1_30_Loc.Text);
            // Lấy số từ giao diện người dùng
            b_30_Loc = int.Parse(txtSo2_30_Loc.Text);

            // Khởi tạo đối tượng để tính toán
            Caculation_30_Loc c_30_Loc = new Caculation_30_Loc(a_30_Loc, b_30_Loc);

            // Gọi phương thức chia
            ketQua_30_Loc = c_30_Loc.Execute("/");

            // Hiển thị kết quả chia lên textbox
            txtKetQua_30_Loc.Text = ketQua_30_Loc.ToString();
        }

        private void txtKetQua_30_Loc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSo2_30_Loc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSo1_30_Loc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
