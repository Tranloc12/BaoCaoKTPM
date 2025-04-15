using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_Loc_43_N2_
{
    public class Caculation_30_Loc
    {// Hai biến lưu giá trị đầu vào
        private int a_30_Loc, b_30_Loc;

        // Constructor khởi tạo giá trị cho hai biến
        public Caculation_30_Loc(int a_30_Loc, int b_30_Loc)
        {   //giá trị cho biến thứ nhất 
            this.a_30_Loc = a_30_Loc;
            //giá trị cho biến thứ hai
            this.b_30_Loc = b_30_Loc;
        }

        // Phương thức thực hiện phép toán dựa trên toán tử truyền vào
        public int Execute(string operation_30_Loc)
        {
            // Biến lưu kết quả
            int result_30_Loc = 0;
            //kiểm tra với swith case 
            switch (operation_30_Loc)
            {
                // Phép cộng
                case "+":
                    //tính phép cộng 
                    result_30_Loc = a_30_Loc + b_30_Loc;
                    //thoát ra 
                    break;
                // Phép trừ
                case "-":
                    //tính phép trừ
                    result_30_Loc = a_30_Loc - b_30_Loc;
                    //thoát ra 
                    break;
                // Phép nhân
                case "*":
                    //tính phép nhân 
                    result_30_Loc = a_30_Loc * b_30_Loc;
                    //thoát ra 
                    break;
                // Phép chia
                case "/":
                    //tính phép chia
                    result_30_Loc = a_30_Loc / b_30_Loc;
                    //thoát ra 
                    break;
            }

            // Trả về kết quả
            return result_30_Loc;
        }
    }
}
