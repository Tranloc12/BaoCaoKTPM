using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _30_Loc_43_N2_; 


namespace UnitTest_30_Loc
{
    [TestClass] 
    public class UnitTest1
    {
        // Khai báo biến private của lớp Caculation_30_Loc.
        private Caculation_30_Loc c_30_Loc; 

        [TestInitialize]
        // Tạo một đối tượng Caculation_30_Loc với giá trị đầu vào (10, 5).
        public void SetUp_30_Loc()
        {
            c_30_Loc = new Caculation_30_Loc(10, 5); 
        }
        // Đánh dấu phương thức này là một test method.
        [TestMethod] 
        // Test case 1: a = 10, b = 5, kết quả  = 15.
        public void TC1_Cong_30_Loc()
        {
            int expected_30_Loc, actual_30_Loc;
            expected_30_Loc = 15;
            // Thực thi phép cộng bằng toán tử "+".
            actual_30_Loc = c_30_Loc.Execute("+");
            // Kiểm tra xem kết quả mong đợi có khớp với kết quả thực tế từ phương thức Execute không.
            Assert.AreEqual(expected_30_Loc, actual_30_Loc); 
        }

        [TestMethod]
        // Test case 2: a = 10, b = 5, kết quả  = 5
        public void TC2_Tru_30_Loc()
        {
            int expected_30_Loc, actual_30_Loc;
            expected_30_Loc = 5;
            // Thực thi phép trừ bằng toán tử "-".
            actual_30_Loc = c_30_Loc.Execute("-");
            // Kiểm tra xem kết quả mong đợi có khớp với kết quả thực tế từ phương thức Execute không.
            Assert.AreEqual(expected_30_Loc, actual_30_Loc); 
        }

        [TestMethod]
        // Test case 3: a = 10, b = 5, kết quả  = 50
        public void TC3_Nhan_30_Loc()
        {
            int expected_30_Loc, actual_30_Loc;
            expected_30_Loc = 50;
            // Thực thi phép nhân bằng toán tử "*".
            actual_30_Loc = c_30_Loc.Execute("*");
            // Kiểm tra xem kết quả mong đợi có khớp với kết quả thực tế từ phương thức Execute không.
            Assert.AreEqual(expected_30_Loc, actual_30_Loc);
        }

        [TestMethod]
        // Test case 4: a = 10, b = 5, kết quả  = 2

        public void TC4_Chia_30_Loc()
        {
            int expected_30_Loc, actual_30_Loc;
            expected_30_Loc = 2; 
            actual_30_Loc = c_30_Loc.Execute("/");
            // Kiểm tra xem kết quả mong đợi có khớp với kết quả thực tế từ phương thức Execute không.
            Assert.AreEqual(expected_30_Loc, actual_30_Loc); 
        }

        [TestMethod]
        // Test case 5: a = 10, b = 5, kết quả  = fail
        public void TC5_Cong_Fail_30_Loc()
        {
            int expected_30_Loc, actual_30_Loc;
            expected_30_Loc = 12;
            // Thực thi phép cộng bằng toán tử "+".
            actual_30_Loc = c_30_Loc.Execute("+"); 

            Assert.AreEqual(expected_30_Loc, actual_30_Loc);
        }
        [TestMethod]
        // Test case 6: a = 10, b = 5, kết quả  = fail
        public void TC6_Tru_Fail_30_Loc()
        {
            int expected_30_Loc, actual_30_Loc;
            expected_30_Loc = 10; 
            actual_30_Loc = c_30_Loc.Execute("-"); 

            Assert.AreEqual(expected_30_Loc, actual_30_Loc); 
        }

        [TestMethod]
        // Test case 7: a = 10, b = 5, kết quả  = fail
        public void TC7_Nhan_Fail_30_Loc()
        {
            int expected_30_Loc, actual_30_Loc;
            expected_30_Loc = 3; 
            actual_30_Loc = c_30_Loc.Execute("*");

            Assert.AreEqual(expected_30_Loc, actual_30_Loc); 
        }

        [TestMethod]
        // Test case 8: a = 10, b = 5, kết quả  = fail

        public void TC8_Chia_Fial_30_Loc()
        {
            int expected_30_Loc, actual_30_Loc;
            expected_30_Loc = 4; 
            actual_30_Loc = c_30_Loc.Execute("/"); 

            Assert.AreEqual(expected_30_Loc, actual_30_Loc); 
        }


        // Kiểm tra trường hợp chia cho 0 (xử lý ngoại lệ).
        [ExpectedException(typeof(DivideByZeroException))] 
        public void Test_ChiaZero()
        {
            c_30_Loc = new Caculation_30_Loc(10, 0);
            c_30_Loc.Execute("/");
        }
    }
}
