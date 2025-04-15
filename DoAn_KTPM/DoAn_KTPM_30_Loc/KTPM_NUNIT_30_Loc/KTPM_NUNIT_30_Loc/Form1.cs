using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace KTPM_NUNIT_30_Loc
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        //nút tính toán_30_Loc
        private void btn_30_Loc_Click(object sender, EventArgs e)
        {

            
                // Lấy giá trị chiều dài 
                int d_30_Loc = int.Parse(txtd_30_Loc.Text);
                // Lấy giá trị chiều rộng người dùng nhập vào
                int r_30_Loc = int.Parse(txtr_30_Loc.Text);

                // Kiểm tra điều kiện là số nguyên dương
                if (d_30_Loc <= 0 || r_30_Loc <= 0)
                    throw new ArgumentException("Chiều dài và chiều rộng phải là số nguyên dương!");

                // Khởi tạo đối tượng Rectangle_30_Loc 
                   Rectangle_30_Loc hcn_30_Loc = new Rectangle_30_Loc(d_30_Loc, r_30_Loc);

                // Gọi phương thức tính chu vi từ class
                int chuvi_30_Loc = hcn_30_Loc.CalculatePerimeter_30_Loc();

                // In kết quả ra textbox
                txtKetqua1_30_Loc.Text = chuvi_30_Loc.ToString();
           


        }
    }
}
