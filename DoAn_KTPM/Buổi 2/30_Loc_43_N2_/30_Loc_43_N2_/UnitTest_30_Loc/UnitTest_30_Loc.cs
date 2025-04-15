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

        // Thuộc tính TestContext cho phép truy cập thông tin về môi trường kiểm thử hiện tại,
        // bao gồm cả dữ liệu đầu vào từ DataSource (CSV, DB,...)
        public TestContext TestContext { get; set; }

        
        // Sử dụng nguồn dữ liệu từ file CSV có tên "TestData_Pass_3Cols.csv"
        // để chạy kiểm thử nhiều lần với dữ liệu khác nhau (Data-Driven Testing)
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
             @".\Data_30_Loc\TestData_Pass_3Cols_30_Loc.csv",
             "TestData_Pass_3Cols_30_Loc#csv",
             DataAccessMethod.Sequential)]
        // Phương thức kiểm thử TC9_TestWithDataSource_30_Loc_5pass_0fail_3cols
        public void TC9_TestWithDataSource_30_Loc_5pass_0fail_3cols()
        {
            // Đọc giá trị từ 3 cột đầu tiên của dòng dữ liệu hiện tại
            // Giá trị đầu vào thứ 1
            int a_30_Loc = int.Parse(TestContext.DataRow[0].ToString());
            // Giá trị đầu vào thứ 2
            int b_30_Loc = int.Parse(TestContext.DataRow[1].ToString());
            // Kết quả mong đợi
            int expected_30_Loc = int.Parse(TestContext.DataRow[2].ToString());

            // Tạo đối tượng Caculation_30_Loc với 2 giá trị đầu vào
            Caculation_30_Loc c_30_Loc = new Caculation_30_Loc(a_30_Loc, b_30_Loc);

            // Thực thi phép tính cộng (dấu "+")
            int actual_30_Loc = c_30_Loc.Execute("+");

            // Kiểm tra kết quả thực tế có đúng với kỳ vọng không
            Assert.AreEqual(expected_30_Loc, actual_30_Loc);
        }
        

        // Sử dụng nguồn dữ liệu từ file CSV có tên "TestData_Pass_3Cols.csv"
        // để chạy kiểm thử nhiều lần với dữ liệu khác nhau (Data-Driven Testing)
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
             @".\Data_30_Loc\TestData_Fail_3Cols_30_Loc.csv",
             "TestData_Fail_3Cols_30_Loc#csv",
             DataAccessMethod.Sequential)]
        // Phương thức kiểm thử TC10_TestWithDataSource_30_Loc_4pass_1fail_3cols
        public void TC10_TestWithDataSource_30_Loc_4pass_1fail_3cols()
        {
            // Đọc giá trị từ 3 cột đầu tiên của dòng dữ liệu hiện tại
            // Giá trị đầu vào thứ 1
            int a_30_Loc = int.Parse(TestContext.DataRow[0].ToString());
            // Giá trị đầu vào thứ 2
            int b_30_Loc = int.Parse(TestContext.DataRow[1].ToString());
            // Kết quả mong đợi
            int expected_30_Loc = int.Parse(TestContext.DataRow[2].ToString());

            // Tạo đối tượng Caculation_30_Loc với 2 giá trị đầu vào
            Caculation_30_Loc c_30_Loc = new Caculation_30_Loc(a_30_Loc, b_30_Loc);

            // Thực thi phép tính cộng (dấu "+")
            int actual_30_Loc = c_30_Loc.Execute("+");

            // Kiểm tra kết quả thực tế có đúng với kỳ vọng không
            Assert.AreEqual(expected_30_Loc, actual_30_Loc);
        }


        [TestMethod]
        // Là một test case sử dụng Data-Driven Testing, nghĩa là dữ liệu test nằm trong file CSV bên ngoài.
        // File CSV có 4 cột: số a, số b, toán tử và kết quả mong đợi tương ứng.

        // Test sẽ chạy nhiều lần tương ứng với từng dòng trong file CSV.
        // Mỗi lần chạy sẽ lấy dữ liệu khác nhau để thực thi phép toán và kiểm tra kết quả.

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
             @".\Data\TestData_Pass_4cols_30_Loc.csv",
             "TestData_Pass_4cols_30_Loc#csv",
             DataAccessMethod.Sequential)]
        // TC11_TestWithDataSource_cotToanTu_30_Loc_4pass_0fail_4cols
        public void TC11_TestWithDataSource_cotToanTu_30_Loc_4pass_0fail_4cols()
        {
            // Đọc dữ liệu từ từng cột của dòng hiện tại:
            // Đọc Cột 1:
            int a_30_Loc = int.Parse(TestContext.DataRow[0].ToString());
            // Đọc Cột 2:      
            int b_30_Loc = int.Parse(TestContext.DataRow[1].ToString());
            // Đọc Cột 3:      
            string operation_30_Loc = (TestContext.DataRow[2].ToString());

            // Xử lý chuỗi toán tử nếu có dấu nháy đơn đầu (do format trong CSV)
            // Ví dụ: nếu trong file ghi là '+', thì sẽ xóa dấu nháy đầu tiên để còn "+"
            operation_30_Loc = operation_30_Loc.Remove(0, 1);

            int expected_30_Loc = int.Parse(TestContext.DataRow[3].ToString());
            // Tạo đối tượng tính toán với 2 giá trị a và b
            Caculation_30_Loc c_30_Loc_30_Loc = new Caculation_30_Loc(a_30_Loc, b_30_Loc);

            // Gọi hàm Execute với toán tử tương ứng để tính kết quả thực tế
            int actual_30_Loc = c_30_Loc.Execute(operation_30_Loc);

            // Kiểm tra kết quả thực tế có bằng kết quả mong đợi không
            Assert.AreEqual(expected_30_Loc, actual_30_Loc);
        }

        // Đánh dấu đây là một test method sử dụng MSTest
        [TestMethod]
        // Cấu hình để đọc dữ liệu kiểm thử từ file CSV (4 cột: a, b, toán tử, kết quả mong đợi)
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
             @".\Data\TestData_Fail_4cols_30_Loc.csv",
             "TestData_Fail_4cols_30_Loc#csv",
             DataAccessMethod.Sequential)]
        // TC12_TestWithDataSource_cotToanTu_30_Loc_3pass_1fail_4cols
        public void TC12_TestWithDataSource_cotToanTu_30_Loc_3pass_1fail_4cols()
        {
            // Đọc số a từ cột 1 của dòng hiện tại trong file CSV
            int a_30_Loc = int.Parse(TestContext.DataRow[0].ToString());

            // Đọc số b từ cột 2
            int b_30_Loc = int.Parse(TestContext.DataRow[1].ToString());

            // Đọc toán tử từ cột 3, thường có dấu nháy đơn nên cần xử lý
            string operation_30_Loc = TestContext.DataRow[2].ToString();
            // Xóa dấu nháy đơn đầu dòng
            operation_30_Loc = operation_30_Loc.Remove(0, 1);

            // Đọc kết quả mong đợi từ cột 4
            int expected_30_Loc = int.Parse(TestContext.DataRow[3].ToString());

            // Tạo đối tượng tính toán với a và b
            Caculation_30_Loc c_30_Loc = new Caculation_30_Loc(a_30_Loc, b_30_Loc);

            // Gọi hàm Execute thực hiện phép tính dựa trên toán tử
            int actual_30_Loc = c_30_Loc.Execute(operation_30_Loc);

            // Kiểm tra kết quả thực tế có đúng với mong đợi không
            Assert.AreEqual(expected_30_Loc, actual_30_Loc);
        }





    }
}

