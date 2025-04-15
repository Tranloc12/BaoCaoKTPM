using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//thêm 
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace _30_Loc_27_N2
{
    public partial class Form_30_Loc : Form
    {
        public Form_30_Loc()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // nút btnf_30_Loc_Click tìm facebook bằng Id - Name
        private void btnf_30_Loc_Click(object sender, EventArgs e)
        {
            // Đường dẫn mặc định
            string defaultUrl_30_Loc = "https://www.facebook.com/?locale=vi_VN";

            // Tạo ChromeDriverService để ẩn cửa sổ command prompt
            ChromeDriverService chrome_30_Loc = ChromeDriverService.CreateDefaultService();
            // Ẩn cửa sổ command prompt
            chrome_30_Loc.HideCommandPromptWindow = true; 

            // Khởi tạo ChromeDriver với ChromeDriverService đã cấu hình
            IWebDriver driver_30_Loc = new ChromeDriver(chrome_30_Loc);

            // Mở trình duyệt và đi tới URL mặc định
            driver_30_Loc.Navigate().GoToUrl(defaultUrl_30_Loc);

            // Lấy URL hiện tại
            String link_hientai_30_Loc = driver_30_Loc.Url;
            // In ra URL hiện tại
            Console.WriteLine(link_hientai_30_Loc);

            // Tìm phần tử input có thuộc tính name="email" (trên trang Facebook, đây là ô nhập Email hoặc số điện thoại)
            IWebElement element_30_Loc = driver_30_Loc.FindElement(By.Name("email"));

            // Gửi (gõ) nội dung "0842491239" vào ô nhập email — đây là số điện thoại hoặc email dùng để đăng nhập Facebook
            element_30_Loc.SendKeys("0842491239");

            // Tìm phần tử input có thuộc tính id="pass" — chính là ô nhập mật khẩu trên Facebook
            IWebElement element_30_Loc_ = driver_30_Loc.FindElement(By.Id("pass"));

            // Gửi (gõ) nội dung "Loc@123" vào ô nhập mật khẩu
            element_30_Loc_.SendKeys("Loc@123");

            // Tìm nút Login và click vào nó
            IWebElement e_Login_30_Loc = driver_30_Loc.FindElement(By.Name("login")); 
            // nhấn click vào nút login 
            e_Login_30_Loc.Click();

            // Sau khi hoàn thành các tác vụ, đóng trình duyệt và tất cả cửa sổ liên quan
            // driver_30_Loc.Quit(); // Đảm bảo đóng trình duyệt và dọn dẹp tài nguyên
        }
        // nút btnf2_30_Loc_Click tìm facebook bằng class - Name
        private void btnf2_30_Loc_Click(object sender, EventArgs e)
        {
            // Đường dẫn mặc định
            string defaultUrl_30_Loc = "https://www.facebook.com/?locale=vi_VN";

            // Tạo ChromeDriverService để ẩn cửa sổ command prompt
            ChromeDriverService chrome_30_Loc = ChromeDriverService.CreateDefaultService();
            // Ẩn cửa sổ command prompt
            chrome_30_Loc.HideCommandPromptWindow = true; 

            // Khởi tạo ChromeDriver với ChromeDriverService đã cấu hình
            IWebDriver driver_30_Loc = new ChromeDriver(chrome_30_Loc);

            // Mở trình duyệt và đi tới URL mặc định
            driver_30_Loc.Navigate().GoToUrl(defaultUrl_30_Loc);

            // Lấy URL hiện tại
            String link_hientai_30_Loc = driver_30_Loc.Url;
            // In ra URL hiện tại
            Console.WriteLine(link_hientai_30_Loc);


            // Tìm phần tử đầu tiên có class name là "inputtext" — trên Facebook, class này thường được dùng cho các ô input (như Email hoặc Password)
            IWebElement element_30_Loc = driver_30_Loc.FindElement(By.ClassName("inputtext"));

            // Gửi (gõ) chuỗi "0842491239" vào ô input đã tìm được (giả sử đây là ô nhập Email hoặc SĐT đăng nhập Facebook)
            element_30_Loc.SendKeys("0842491239");

            // Tìm phần tử input có thuộc tính id="pass" — chính là ô nhập mật khẩu trên Facebook
            IWebElement element_30_Loc_ = driver_30_Loc.FindElement(By.Name("pass"));

            // Gửi (gõ) nội dung "Loc@123" vào ô nhập mật khẩu
            element_30_Loc_.SendKeys("Loc@123");

            // Tìm nút Login và click vào nó
            IWebElement e_Login_30_Loc = driver_30_Loc.FindElement(By.Name("login")); 
            //nhấn vào nút login
            e_Login_30_Loc.Click();

            // Sau khi hoàn thành các tác vụ, đóng trình duyệt và tất cả cửa sổ liên quan
            // driver_30_Loc.Quit(); 

        }

        //nút btnT_30_Loc in ra tagname 
        private void btnT_30_Loc_Click(object sender, EventArgs e)
        {
            // Khởi tạo trình điều khiển ChromeDriver để điều khiển trình duyệt Chrome
            IWebDriver driver_30_Loc = new ChromeDriver();

            // Mở trang Wikipedia với URL chỉ định
            driver_30_Loc.Url = "https://en.wikipedia.org/wiki/I_Love_You";

            // Thực hiện điều hướng trình duyệt (thực ra dòng này có thể bỏ vì .Url đã điều hướng rồi)
            driver_30_Loc.Navigate();

            // Tìm tất cả các phần tử có thẻ <h2> trong trang
            IReadOnlyCollection<IWebElement> ee = driver_30_Loc.FindElements(By.TagName("h2"));

            // Duyệt qua từng phần tử <h2> tìm được và in nội dung (text) ra Console
            foreach (var element_30_Loc in ee)
            {
                //in ra kết quả 
                Console.WriteLine(element_30_Loc.Text);
            }

        }
   

        

       
        private void btn_upload_30_Loc_Click(object sender, EventArgs e)
       {
            // Đường dẫn mặc định
            string defaultUrl_30_Loc = "https://www.demo.guru99.com/test/upload/";

            // Tạo ChromeDriverService để ẩn cửa sổ command prompt
            ChromeDriverService chrome_30_Loc = ChromeDriverService.CreateDefaultService();
            // Ẩn cửa sổ command prompt
            chrome_30_Loc.HideCommandPromptWindow = true;

            // Khởi tạo ChromeDriver với ChromeDriverService đã cấu hình
            IWebDriver driver_30_Loc = new ChromeDriver(chrome_30_Loc);

            // Mở trình duyệt và đi tới URL mặc định
            driver_30_Loc.Navigate().GoToUrl(defaultUrl_30_Loc);

            // Đợi một chút để trang load
            System.Threading.Thread.Sleep(2000);


            // Tìm phần tử HTML có thuộc tính id="uploadfile_0" — thường là một ô input dạng <input type="file">
            IWebElement e_upload_30_Loc = driver_30_Loc.FindElement(By.Id("uploadfile_0"));


            // Chỉ định đường dẫn của file ảnh cần tải lên
            string filePath_30_Loc = @"D:\pic";

            // Sử dụng SendKeys để nhập đường dẫn file vào phần tử input
            e_upload_30_Loc.SendKeys(filePath_30_Loc);

            // Bắt sự kiện Name="terms"
            IWebElement e_itemsCheckbox_30_Loc = driver_30_Loc.FindElement(By.Name("terms"));
            // Nhấn click vào
            e_itemsCheckbox_30_Loc.Click();

            // Tìm và nhấn nút submit để tải lên (giả sử có id là 'submitbutton')
            IWebElement e_uploadButton_30_Loc = driver_30_Loc.FindElement(By.Id("submitbutton"));
            // Nhấn click vào
            e_uploadButton_30_Loc.Click();

            // Đợi một chút rồi đóng trình duyệt
            System.Threading.Thread.Sleep(3000);


        }

        private void btn5_30_Loc_Click(object sender, EventArgs e)
        {
            // URL mặc định
            string defaultUrl_30_Loc = "https://demo.guru99.com/test/delete_customer.php";

            // Tạo ChromeDriverService để ẩn cửa sổ CMD
            ChromeDriverService chrome_30_Loc = ChromeDriverService.CreateDefaultService();
            // Ẩn cửa sổ command prompt
            chrome_30_Loc.HideCommandPromptWindow = true;

            // Khởi tạo trình duyệt
            IWebDriver driver_30_Loc = new ChromeDriver(chrome_30_Loc);

            // Truy cập trang Guru99
            driver_30_Loc.Navigate().GoToUrl(defaultUrl_30_Loc);

            // Bắt sự kiện Name = "cusid"
            IWebElement inputCusId_30_Loc = driver_30_Loc.FindElement(By.Name("cusid"));
            //truyền giá trị vào 
            inputCusId_30_Loc.SendKeys("53920");

            // Băt sự kiện Name ="submit"
            IWebElement btnSubmit_30_Loc = driver_30_Loc.FindElement(By.Name("submit"));
            //truyền giá trị vào 
            btnSubmit_30_Loc.Click();

            // Xử lý Alert 1: Thường là hộp thoại xác nhận việc xóa
            // Chuyển quyền điều khiển từ trình duyệt sang cửa sổ alert đầu tiên
            IAlert alert_1_30_Loc = driver_30_Loc.SwitchTo().Alert();

            // Lấy nội dung văn bản hiển thị trên hộp thoại alert 1 (ví dụ: "Bạn có chắc muốn xóa?")
            string alertText_1_30_Loc = alert_1_30_Loc.Text;

            // In nội dung của alert 1 ra console để kiểm tra
            Console.WriteLine("Alert 1: " + alertText_1_30_Loc);

            // Chấp nhận (nhấn OK) để đồng ý với hộp thoại cảnh báo — có thể thay bằng Dismiss() nếu muốn nhấn Cancel
            alert_1_30_Loc.Accept(); 


            // Xử lý Alert 2: Hộp thoại thông báo kết quả sau khi xác nhận xóa
            // Sau khi xử lý alert 1, hệ thống có thể hiển thị alert thứ hai thông báo "Xóa thành công" chẳng hạn
            IAlert alert_2_30_Loc = driver_30_Loc.SwitchTo().Alert();

            // Lấy nội dung từ alert thứ hai
            string alertText_2_30_Loc = alert_2_30_Loc.Text;

            // In nội dung của alert 2 ra console
            Console.WriteLine("Alert 2: " + alertText_2_30_Loc);

            // Nhấn OK để đóng hộp thoại alert thứ hai
            alert_2_30_Loc.Accept();

        }


        //reset
        private void btnReset_30_Loc_Click(object sender, EventArgs e)
        {
            // URL mặc định để truy cập trang xóa khách hàng của Guru99
            string defaultUrl_30_Loc = "https://demo.guru99.com/test/delete_customer.php";

            // Tạo đối tượng ChromeDriverService để cấu hình cho trình duyệt Chrome
            ChromeDriverService chrome_30_Loc = ChromeDriverService.CreateDefaultService();
            // Ẩn cửa sổ command prompt đen khi chạy ChromeDriver
            chrome_30_Loc.HideCommandPromptWindow = true;

            // Khởi tạo trình duyệt Chrome với cấu hình đã tạo
            IWebDriver driver_30_Loc = new ChromeDriver(chrome_30_Loc);

            // Dùng trình duyệt điều hướng tới URL của trang web
            driver_30_Loc.Navigate().GoToUrl(defaultUrl_30_Loc);

            // Tìm ô nhập "Customer ID" theo thuộc tính name="cusid"
            IWebElement inputCusId_30_Loc = driver_30_Loc.FindElement(By.Name("cusid"));

            // Nhập mã khách hàng vào ô input (ví dụ: 53920)
            inputCusId_30_Loc.SendKeys("53920");

            // Tìm và click vào nút "Reset" (name="res") để xóa nội dung vừa nhập
            driver_30_Loc.FindElement(By.Name("res")).Click();

        }

        private void btnCancel_30_Loc_Click(object sender, EventArgs e)
        {
            // URL mặc định trỏ đến trang form xóa khách hàng trên Guru99
            string defaultUrl_30_Loc = "https://demo.guru99.com/test/delete_customer.php";

            // Tạo dịch vụ điều khiển ChromeDriver và ẩn cửa sổ CMD (Command Prompt)
            ChromeDriverService chrome_30_Loc = ChromeDriverService.CreateDefaultService();
            // Ẩn cửa sổ lệnh đen khi chạy ChromeDriver
            chrome_30_Loc.HideCommandPromptWindow = true; 

            // Khởi tạo trình duyệt Chrome mới sử dụng dịch vụ đã tạo
            IWebDriver driver_30_Loc = new ChromeDriver(chrome_30_Loc);

            // Truy cập vào URL của trang form xóa khách hàng
            driver_30_Loc.Navigate().GoToUrl(defaultUrl_30_Loc);

            // Tìm ô input để nhập mã khách hàng theo thuộc tính name="cusid"
            IWebElement inputCusId_30_Loc = driver_30_Loc.FindElement(By.Name("cusid"));

            // Gửi dữ liệu "53920" vào ô input (giống như nhập bằng bàn phím)
            inputCusId_30_Loc.SendKeys("53920");

            // Tìm và click vào nút "Submit" để gửi form (name="submit")
            IWebElement btnSubmit_30_Loc = driver_30_Loc.FindElement(By.Name("submit"));
            btnSubmit_30_Loc.Click();

            // Sau khi nhấn Submit, trình duyệt hiển thị hộp thoại xác nhận (Alert)
            // → Sử dụng SwitchTo().Alert() để chuyển quyền điều khiển đến Alert
            IAlert alert_30_Loc = driver_30_Loc.SwitchTo().Alert();

            // In ra nội dung thông báo của Alert (hộp xác nhận)
            Console.WriteLine("Alert (Cancel): " + alert_30_Loc.Text);

            // Nhấn "Cancel" bằng cách gọi Dismiss() → Từ chối xóa khách hàng
            alert_30_Loc.Dismiss();


        }


    }
}
