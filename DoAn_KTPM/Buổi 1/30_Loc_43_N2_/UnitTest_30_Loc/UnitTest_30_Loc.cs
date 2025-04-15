using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _30_Loc_43_N2_;


namespace UnitTest_30_Loc
{
    // Đánh dấu lớp này chứa các phương thức test.
    [TestClass]
    public class UnitTest_30_Loc
    {
        // Khai báo biến private của lớp Caculation_30_Loc.
        private Caculation_30_Loc c_30_Loc;

        // Phương thức này sẽ chạy trước mỗi test case để thiết lập dữ liệu chung.
        [TestInitialize]
        public void SetUp_30_Loc()

        {
            // Tạo một đối tượng Caculation_30_Loc với giá trị đầu vào (4, 2).
            c_30_Loc = new Caculation_30_Loc(4, 2);
        }

        [TestMethod]
        // Test case 1: a = 4, b = 2, kết quả  = 6
        public void TC1_Cong_30_Loc()
        {     // khai báo expected_30_Loc là kết quả mong đợi, actual_30_Loc là kết quả thực tế
            int expected_30_Loc, actual_30_Loc;
            // Đặt kết quả mong đợi cho phép cộng.
            expected_30_Loc = 6;
            // Thực thi phép cộng bằng toán tử "+".
            actual_30_Loc = c_30_Loc.Execute("+");
            // Kiểm tra xem kết quả mong đợi có khớp với kết quả thực tế từ phương thức Execute không.
            Assert.AreEqual(expected_30_Loc, actual_30_Loc);
        }

        [TestMethod]
        // Test case 2: a = 4, b = 2, kết quả  = 2
        public void TC2_Tru_30_Loc()
        {   // khai báo expected_30_Loc là kết quả mong đợi, actual_30_Loc là kết quả thực tế
            int expected_30_Loc, actual_30_Loc;
            // Đặt kết quả mong đợi cho phép trừ
            expected_30_Loc = 2;
            // Thực thi phép trừ bằng toán tử "-".
            actual_30_Loc = c_30_Loc.Execute("-");
            // Kiểm tra xem kết quả mong đợi có khớp với kết quả thực tế từ phương thức Execute không.
            Assert.AreEqual(expected_30_Loc, actual_30_Loc);
        }

        [TestMethod]
        // Test case 3: a = 4, b = 2, kết quả  = 8
        public void TC3_Nhan_30_Loc()
        {   // khai báo expected_30_Loc là kết quả mong đợi, actual_30_Loc là kết quả thực tế
            int expected_30_Loc, actual_30_Loc;
            // Đặt kết quả mong đợi cho phép nhân
            expected_30_Loc = 8;
            // Thực thi phép nhân bằng toán tử "*".
            actual_30_Loc = c_30_Loc.Execute("*");
            // Kiểm tra xem kết quả mong đợi có khớp với kết quả thực tế từ phương thức Execute không.
            Assert.AreEqual(expected_30_Loc, actual_30_Loc);
        }

        [TestMethod]
        // Test case 4: a = 4, b = 2, kết quả  = 2
        public void TC4_Chia_30_Loc()
        {   // khai báo expected_30_Loc là kết quả mong đợi, actual_30_Loc là kết quả thực tế
            int expected_30_Loc, actual_30_Loc;
            // Đặt kết quả mong đợi cho phép chia
            expected_30_Loc = 2;
            // Thực thi phép cộng bằng toán tử "/".
            actual_30_Loc = c_30_Loc.Execute("/");
            // Kiểm tra xem kết quả mong đợi có khớp với kết quả thực tế từ phương thức Execute không.

            Assert.AreEqual(expected_30_Loc, actual_30_Loc);
        }

        [TestMethod]
        // Test case 5 : a =4, b = 2, kết quả  = 5
        public void TC5_Cong_Fail_30_Loc()
        {   // khai báo expected_30_Loc là kết quả mong đợi, actual_30_Loc là kết quả thực tế

            int expected_30_Loc, actual_30_Loc;
            // Đặt kết quả mong đợi cho phép cộng.
            expected_30_Loc = 5;
            // Thực thi phép cộng bằng toán tử "+".
            actual_30_Loc = c_30_Loc.Execute("+");
            // Kiểm tra xem kết quả mong đợi có khớp với kết quả thực tế từ phương thức Execute không.
            Assert.AreEqual(expected_30_Loc, actual_30_Loc);
        }

        [TestMethod]
        // Test case 6: a = 4, b = 2, kết quả  = 6
        public void TC6_Tru_Fail_30_Loc()
        {   // khai báo expected_30_Loc là kết quả mong đợi, actual_30_Loc là kết quả thực tế
            int expected_30_Loc, actual_30_Loc;
            // Đặt kết quả mong đợi cho phép trừ
            expected_30_Loc = 6;
            // Thực thi phép trừ bằng toán tử "-".
            actual_30_Loc = c_30_Loc.Execute("-");
            // Kiểm tra xem kết quả mong đợi có khớp với kết quả thực tế từ phương thức Execute không.
            Assert.AreEqual(expected_30_Loc, actual_30_Loc);
        }

        [TestMethod]
        // Test case 7: a = 4, b = 2, kết quả  = 2

        public void TC7_Nhan_Fail_30_Loc()
        {   // khai báo expected_30_Loc là kết quả mong đợi, actual_30_Loc là kết quả thực tế
            int expected_30_Loc, actual_30_Loc;
            // Đặt kết quả mong đợi cho phép nhân
            expected_30_Loc = 2;
            // Thực thi phép nhân bằng toán tử "*".
            actual_30_Loc = c_30_Loc.Execute("*");
            // Kiểm tra xem kết quả mong đợi có khớp với kết quả thực tế từ phương thức Execute không.
            Assert.AreEqual(expected_30_Loc, actual_30_Loc);
        }

        [TestMethod]
        // Test case 8: a = 4, b = 2, kết quả  = 6
        public void TC8_Chia_Fial_30_Loc()
        {     // khai báo expected_30_Loc là kết quả mong đợi, actual_30_Loc là kết quả thực tế
            int expected_30_Loc, actual_30_Loc;
            // Đặt kết quả mong đợi cho phép chia
            expected_30_Loc = 6;
            // Thực thi phép cộng bằng toán tử "/".
            actual_30_Loc = c_30_Loc.Execute("/");
            // Kiểm tra xem kết quả mong đợi có khớp với kết quả thực tế từ phương thức Execute không.
            Assert.AreEqual(expected_30_Loc, actual_30_Loc);
        }


        // Kiểm tra trường hợp chia cho 0 (xử lý ngoại lệ).
        [ExpectedException(typeof(DivideByZeroException))]
        public void Test_ChiaZero()
        {
            // Khởi tạo đối tượng Caculation_30_Loc với tử số là 10 và mẫu số là 0
            c_30_Loc = new Caculation_30_Loc(10, 0);
            // Thực hiện phép chia ("/") – do mẫu số là 0 nên kỳ vọng sẽ ném ra ngoại lệ DivideByZeroException
            c_30_Loc.Execute("/");
        }
    }
}
