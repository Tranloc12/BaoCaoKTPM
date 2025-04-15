using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Thêm các thư viện cần thiết để sử dụng Selenium WebDriver và trình điều khiển Chrome.
using OpenQA.Selenium;
// Thêm các thư viện cần thiết để sử dụng Selenium WebDriver và trình điều khiển Chrome.
using OpenQA.Selenium.Chrome;

namespace _30_Loc_50_N2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //bài 1 
        // Phương thức xử lý sự kiện khi người dùng nhấn nút "btn_30_Loc"
        private void btn_30_Loc_Click(object sender, EventArgs e)
        {
            // Khởi tạo một đối tượng ChromeDriver để điều khiển trình duyệt Chrome.
            // ChromeDriver sẽ tự động mở trình duyệt Chrome khi được khởi tạo
            IWebDriver driver_30_Loc = new ChromeDriver();
            // Điều hướng trình duyệt vừa mở đến trang web 
            driver_30_Loc.Navigate().GoToUrl("https://www.google.com/");
        }


       
    

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }
        //bài 2 
        // Sự kiện khi người dùng nhấn nút "btn1_30_Loc"
        private void btn1_30_Loc_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem TextBox có chứa URL hợp lệ không
            string url_30_Loc = txt1_30_Loc.Text;
            // Kiểm tra xem chuỗi người dùng nhập có phải là một URL hợp lệ hay không
            if (Uri.IsWellFormedUriString(url_30_Loc, UriKind.Absolute)) 
            {
                // Mở trình duyệt và đi tới URL
                IWebDriver driver_30_Loc = new ChromeDriver();
                // Dùng WebDriver để điều hướng tới URL đã nhập
                driver_30_Loc.Navigate().GoToUrl(url_30_Loc);
            }
            else
            {
                // Nếu URL không hợp lệ, hiển thị hộp thoại thông báo lỗi cho người dùng
                MessageBox.Show("Đường dẫn không hợp lệ. Vui lòng nhập URL hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


       




        //bài 3
        // Sự kiện khi người dùng nhấn nút "btn2_30_Loc"
        private void btn2_30_Loc_Click(object sender, EventArgs e)
        {
            // Đường dẫn mặc định
            string defaultUrl_30_Loc = "https://www.google.com/?hl=vi";

            //Câu C
            // Tạo ChromeDriverService để ẩn cửa sổ command prompt
            ChromeDriverService chrome_30_Loc = ChromeDriverService.CreateDefaultService();
            // Ẩn cửa sổ command prompt
            chrome_30_Loc.HideCommandPromptWindow = true; 

            // Khởi tạo ChromeDriver với ChromeDriverService đã cấu hình
            IWebDriver driver_30_Loc = new ChromeDriver(chrome_30_Loc);

            // Mở trình duyệt và đi tới URL mặc định
            driver_30_Loc.Navigate().GoToUrl(defaultUrl_30_Loc);

            //câu E

            // Lấy URL hiện tại
            String link_hientai_30_Loc = driver_30_Loc.Url;
            Console.WriteLine(link_hientai_30_Loc);


            //Câu D
            // Sau khi hoàn thành các tác vụ, đóng trình duyệt và tất cả cửa sổ liên quan
            //driver_30_Loc.Quit(); // Đảm bảo đóng trình duyệt và dọn dẹp tài nguyên
           
          
        }


        //bài 3 câu f - g 
        // Sự kiện khi người dùng nhấn nút "btn3_30_Loc"
        private void btn3_30_Loc_Click(object sender, EventArgs e)
        {
            // Đường dẫn mặc định
            string defaultUrl_30_Loc = "https://www.google.com/?hl=vi";

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

            //Câu F

            // Lấy tiêu đề của trang hiện tại
            string pageTitle = driver_30_Loc.Title;

            // Hiển thị tiêu đề trang vào TextBox (giả sử TextBox có tên là textBox1)
            txt_30_Loc.Text = pageTitle;

            //Câu G
            // Lấy toàn bộ mã HTML của trang web hiện tại mà trình duyệt đang hiển thị
            String PageSource_30_Loc = driver_30_Loc.PageSource;
            // In toàn bộ nội dung HTML (Page Source) đó ra cửa sổ console
            Console.WriteLine(PageSource_30_Loc);

            // Sau khi hoàn thành các tác vụ, đóng trình duyệt và tất cả cửa sổ liên quan
            // driver_30_Loc.Quit(); // Đảm bảo đóng trình duyệt và dọn dẹp tài nguyên
        }

        //bài 3 câu h 
        // Sự kiện khi người dùng nhấn nút "btnh_30_Loc"
        private void btnh_30_Loc_Click(object sender, EventArgs e)
        {
            // Đường dẫn mặc định
            string defaultUrl_30_Loc = "https://www.google.com/?hl=vi";
            // Đường dẫn thứ 2 mặc định 
            string defaultUrl_30_Loc_web_Ou = "https://lms.ou.edu.vn/";

            // Tạo ChromeDriverService để ẩn cửa sổ command prompt
            ChromeDriverService chrome_30_Loc = ChromeDriverService.CreateDefaultService();
            // Ẩn cửa sổ command prompt
            chrome_30_Loc.HideCommandPromptWindow = true;

            // Khởi tạo ChromeDriver với ChromeDriverService đã cấu hình
            IWebDriver driver_30_Loc = new ChromeDriver(chrome_30_Loc);

            // Mở trình duyệt và đi tới URL mặc định
            driver_30_Loc.Navigate().GoToUrl(defaultUrl_30_Loc);

            // Chuyển tới trang kế tiếp (Forward)
            driver_30_Loc.Navigate().Forward();
            // Đợi 2 giây
            System.Threading.Thread.Sleep(2000); 

            // Mở trình duyệt và đi tới URL mặc định
            driver_30_Loc.Navigate().GoToUrl(defaultUrl_30_Loc_web_Ou);

            // Đợi một giây
            System.Threading.Thread.Sleep(1000); 

            // Quay lại trang trước(Back)
            driver_30_Loc.Navigate().Back();
            // Đợi 1 giây
            System.Threading.Thread.Sleep(1000); 

            // Chuyển tới trang kế tiếp (Forward)
            driver_30_Loc.Navigate().Forward();
            // Đợi 1 giây
            System.Threading.Thread.Sleep(1000); 

            // Làm mới trang hiện tại (Refresh)
            driver_30_Loc.Navigate().Refresh();
            // Đợi 1 giây
            System.Threading.Thread.Sleep(1000); 



            // Sau khi hoàn thành các tác vụ, đóng trình duyệt và tất cả cửa sổ liên quan
            // driver_30_Loc.Quit();
        }


        //bài 4 
        // Sự kiện khi người dùng nhấn nút "btn4_30_Loc"
        private void btn4_30_Loc_Click(object sender, EventArgs e)
        {
            // Đường dẫn mặc định
            string defaultUrl_30_Loc = "https://www.google.com/?hl=vi";

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

            // Lấy nội dung người dùng nhập từ TextBox có tên là txt4Input_30_Loc
            String text_30_Loc = txt4Input_30_Loc.Text;

            // Tìm phần tử trên trang web có thuộc tính `name="q"`
            IWebElement element_30_Loc = driver_30_Loc.FindElement(By.Name("q"));

            // Gửi chuỗi văn bản (text_30_Loc) vào ô tìm kiếm của Google
            element_30_Loc.SendKeys(text_30_Loc);


            // Sau khi hoàn thành các tác vụ, đóng trình duyệt và tất cả cửa sổ liên quan
            // driver_30_Loc.Quit(); 
        }

    }
    
}
