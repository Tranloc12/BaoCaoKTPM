using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace KTPM_NUNIT_30_Loc
{
    // Lớp Rectangle_30_Loc mô tả hình chữ nhật
    public class Rectangle_30_Loc
    {
        
        // Chiều dài của hình chữ nhật
        public int d_30_Loc { get; set; } 
        // Chiều rộng của hình chữ nhật
        public int r_30_Loc { get; set; } 

        // Hàm khởi tạo Rectangle_30_Loc với hai tham số đầu vào: chiều dài và chiều rộng.
        public Rectangle_30_Loc(int length_30_Loc, int width_30_Loc)
        {
            // Kiểm tra xem chiều dài và chiều rộng có phải là số nguyên dương không.
            if (length_30_Loc <= 0 || width_30_Loc <= 0)
                // Nếu chiều dài hoặc chiều rộng không hợp lệ, ném một ngoại lệ với thông báo lỗi.
                throw new ArgumentException("không hợp lệ ");

            // Gán giá trị chiều dài 
            d_30_Loc = length_30_Loc;
            // chiều rộng vào thuộc tính của đối tượng.
            r_30_Loc = width_30_Loc;  
        }

        // Phương thức tính chu vi của hình chữ nhật.
        public int CalculatePerimeter_30_Loc()
        {
            // Công thức tính chu vi hình chữ nhật: P = 2 * (dài + rộng)
            return 2 * (d_30_Loc + r_30_Loc); 
        }

       
    }
}
