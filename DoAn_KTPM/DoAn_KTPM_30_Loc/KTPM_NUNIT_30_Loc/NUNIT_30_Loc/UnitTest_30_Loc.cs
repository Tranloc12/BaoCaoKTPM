using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KTPM_NUNIT_30_Loc;

namespace NUNIT_30_Loc
{
    [TestClass]
    public class UnitTest_30_Loc
    {

        [TestMethod]
        // TC1_DR_Valid_30_Loc: d_30_Loc = 5, r_30_Loc = 4, expected_30_Loc = 18
        public void TC1_DR_Valid_30_Loc()
        {
            // Tạo đối tượng Rectangle_30_Loc với chiều dài 5 và chiều rộng 4
            Rectangle_30_Loc rectangle_30_Loc = new Rectangle_30_Loc(5, 4);
            // Khởi tạo giá trị chu vi mong đợi (expected perimeter) là 18
            int expected_30_Loc = 18;
            // để tính chu vi thực tế (actual perimeter)
            int actual_30_Loc = rectangle_30_Loc.CalculatePerimeter_30_Loc();
            // So sánh kết quả
            Assert.AreEqual(expected_30_Loc, actual_30_Loc);
        }

        [TestMethod]
        // TC2_DR_Valid_Min_30_Loc: d_30_Loc = 1, r_30_Loc = 1, expected_30_Loc = 4
        public void TC2_DR_Valid_Min_30_Loc()
        {
            // Tạo đối tượng với chiều dài và chiều rộng đều là 1
            Rectangle_30_Loc rectangle_30_Loc = new Rectangle_30_Loc(1, 1);
            // Khởi tạo giá trị chu vi mong đợi (expected perimeter) là 4
            int expected_30_Loc = 4;
            // để tính chu vi thực tế (actual perimeter)
            int actual_30_Loc = rectangle_30_Loc.CalculatePerimeter_30_Loc();
            // So sánh kết quả
            Assert.AreEqual(expected_30_Loc, actual_30_Loc);
        }

        [TestMethod]
        // TC3_DR_Valid_Max_30_Loc: d_30_Loc = 100, r_30_Loc = 100, expected_30_Loc = 400

        public void TC3_DR_Valid_Max_30_Loc()
        {
            // Tạo đối tượng với chiều dài và chiều rộng đều là 100
            Rectangle_30_Loc rectangle_30_Loc = new Rectangle_30_Loc(100, 100);
            // Khởi tạo giá trị chu vi mong đợi (expected perimeter) là 400
            int expected_30_Loc = 400;
            // để tính chu vi thực tế (actual perimeter)
            int actual_30_Loc = rectangle_30_Loc.CalculatePerimeter_30_Loc();
            // So sánh kết quả
            Assert.AreEqual(expected_30_Loc, actual_30_Loc);
        }

        [TestMethod]
        // TC4_D_Negative_30_Loc: d_30_Loc = -5, r_30_Loc = 4, expected_30_Loc = Exception
        // Mong đợi chương trình ném ra ngoại lệ ArgumentException khi xử lý dữ liệu không hợp lệ
        [ExpectedException(typeof(ArgumentException))]
        public void TC4_D_Negative_30_Loc()
        {
            // Tạo đối tượng với chiều dài âm
            Rectangle_30_Loc rectangle_30_Loc = new Rectangle_30_Loc(-5, 4);
            // Gọi phương thức tính chu vi của hình chữ nhật
            // kiểm tra hợp lệ trong phương thức này   
            rectangle_30_Loc.CalculatePerimeter_30_Loc(); 
        }

        [TestMethod]
        // TC5_R_Negative_30_Loc: d_30_Loc = 5, r_30_Loc = -4, expected_30_Loc = Exception
        // Mong đợi chương trình ném ra ngoại lệ ArgumentException khi xử lý dữ liệu không hợp lệ
        [ExpectedException(typeof(ArgumentException))]
        public void TC5_R_Negative_30_Loc()
        {
            // Tạo đối tượng với chiều rộng âm
            Rectangle_30_Loc rectangle_30_Loc = new Rectangle_30_Loc(5, -4);
            // Gọi phương thức tính chu vi của hình chữ nhật
            // kiểm tra hợp lệ trong phương thức này   
            rectangle_30_Loc.CalculatePerimeter_30_Loc(); 
        }

        [TestMethod]
        // TC6_DR_Zero_30_Loc: d_30_Loc = 0, r_30_Loc = 0, expected_30_Loc = Exception
        // Mong đợi chương trình ném ra ngoại lệ ArgumentException khi xử lý dữ liệu không hợp lệ
        [ExpectedException(typeof(ArgumentException))]
        public void TC6_DR_Zero_30_Loc()
        {
            // Tạo đối tượng với chiều dài và chiều rộng bằng 0
            Rectangle_30_Loc rectangle_30_Loc = new Rectangle_30_Loc(0, 0);
            // Gọi phương thức tính chu vi của hình chữ nhật
            // kiểm tra hợp lệ trong phương thức này   

            rectangle_30_Loc.CalculatePerimeter_30_Loc();  
        }

        [TestMethod]
        // TC7_DR_Negative_30_Loc: d_30_Loc = -5, r_30_Loc = -4, expected_30_Loc = Exception
        // Mong đợi chương trình ném ra ngoại lệ ArgumentException khi xử lý dữ liệu không hợp lệ
        [ExpectedException(typeof(ArgumentException))]
        public void TC7_DR_Negative_30_Loc()
        {
            // Tạo đối tượng với chiều dài và chiều rộng đều âm
            Rectangle_30_Loc rectangle_30_Loc = new Rectangle_30_Loc(-5, -4);
            // Gọi phương thức tính chu vi của hình chữ nhật
            // kiểm tra hợp lệ trong phương thức này   

            rectangle_30_Loc.CalculatePerimeter_30_Loc(); 
        }


        // file database CSV
        // Khai báo context để truy cập dữ liệu từ file CSV
        public TestContext TestContext { get; set; }
        //thiết lập dữ liệu
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                    @".\Data_30_Loc\Data_Rectangle_30_Loc.csv", "Data_Rectangle_30_Loc#csv",
                    DataAccessMethod.Sequential)]
        [TestMethod]
        //TC8: test datasource 3 cột, 4  hàng dữ liệu
        // d_30_Loc = 5, r_30_Loc = 4, expected_30_Loc = 18
        // d_30_Loc = 7, r_30_Loc = 3, expected_30_Loc = 20
        // d_30_Loc = 10, r_30_Loc = 2, expected_30_Loc = 24
        // d_30_Loc = 2, r_30_Loc = 3, expected_30_Loc = 9     
        public void TC8_3Cot4Dong_CSV_30_Loc()
        {

            // Lấy giá trị từ từng dòng trong CSV
            // Lấy giá trị chiều dài từ cột đầu tiên của dòng hiện tại trong file CSV
            int d_30_Loc = int.Parse(TestContext.DataRow[0].ToString());
            // Lấy giá trị chiều rộng từ cột thứ hai
            int r_30_Loc = int.Parse(TestContext.DataRow[1].ToString());
            // Lấy giá trị chu vi kỳ vọng từ cột thứ ba (có thể bị thêm dấu nháy đơn khi import CSV, nên dùng Trim)
            int expected_30_Loc = int.Parse(TestContext.DataRow[2].ToString().Trim('\''));

            // Gọi tính chu vi từ class
            Rectangle_30_Loc s_30_Loc = new Rectangle_30_Loc(d_30_Loc, r_30_Loc);
            // Gọi phương thức tính chu vi thực tế
            int actual_30_Loc = s_30_Loc.CalculatePerimeter_30_Loc();

            // So sánh kết quả thực tế và kỳ vọng, nếu khác nhau thì test sẽ fail và in thông báo lỗi
            Assert.AreEqual(expected_30_Loc, actual_30_Loc, $"Lỗi: Chu vi không đúng. Dài = {d_30_Loc}, Rộng = {r_30_Loc}, " +
                              $"Kỳ vọng = {expected_30_Loc}, Thực tế = {actual_30_Loc}");

            // In kết quả ra console
            Console.WriteLine($"Chu vi của HCN ({d_30_Loc} x {r_30_Loc}): " +
                              $"Kỳ vọng = {expected_30_Loc}, Thực tế = {actual_30_Loc}");
        }



    }
}
