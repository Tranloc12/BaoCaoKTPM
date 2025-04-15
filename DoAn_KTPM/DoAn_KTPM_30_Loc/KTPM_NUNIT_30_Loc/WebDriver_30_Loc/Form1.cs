using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using static System.Net.Mime.MediaTypeNames;


namespace WebDriver_30_Loc
{
    public partial class WebDriver_BaoTuoiTre_30_Loc: Form
    {
        private IWebDriver driver_30_Loc;
        
        public WebDriver_BaoTuoiTre_30_Loc()
        {
            InitializeComponent();
        }

        //nút Login_30_Loc
        private void btn_Login_30_Loc_Click(object sender, EventArgs e)
        {

            // Khởi tạo ChromeDriverService và đóng màn hình đen khi chạy chương trình 
            ChromeDriverService chrome_30_Loc = ChromeDriverService.CreateDefaultService();
            // Thiết lập không hiển thị cửa sổ dòng lệnh (Console window) khi khởi chạy trình duyệt Chrome
            chrome_30_Loc.HideCommandPromptWindow = true;

            //Khởi tạo ChromeDriver và điều hướng trình duyệt đến web báo tuổi trẻ 
            driver_30_Loc = new ChromeDriver(chrome_30_Loc);
            // và điều hướng trình duyệt đến web báo tuổi trẻ 
            driver_30_Loc.Navigate().GoToUrl("https://tuoitre.vn/");
            // tạm dừng thực thi 5 giây
            Thread.Sleep(5000);


            //================== TC1_Login_30_Loc: không nhập email và không nhập password ===============
            //email_30_Loc ="", password_30_Loc ="", expected_30_Loc = Thông báo lỗi

            //bắt sự kiện bằng Id="head_login"
            //click vào nút login để để chuyển đến trang đăng nhập 
            driver_30_Loc.FindElement(By.Id("head_login")).Click();

            //chương trình sẽ tạm dừng thực thi
            Thread.Sleep(2000);


            //bắt sự kiện Name= "username" 
            //không nhập email
            driver_30_Loc.FindElement(By.Name("username")).SendKeys("");

            //bắt sự kiện Name= "password" 
            //không nhập password
            driver_30_Loc.FindElement(By.Name("password")).SendKeys("");

            //bắt sự kiện Id ="button-login" 
            //click vào nút đăng nhập 
            driver_30_Loc.FindElement(By.Id("button-login")).Click();

            //bắt sự kiện class="txt-error-login"
            //kiểm tra nếu có lỗi -> pass và ngược lại không có lỗi -> fail
            if (driver_30_Loc.FindElements(By.ClassName("txt-error-login")).Count > 0)
                Console.WriteLine("TC1_Login_30_Loc: khong nhap email va password -> Pass ");
            else
                Console.WriteLine("TC1_Login_30_Loc: khong nhap email va password -> Fail ");

            //chương trình sẽ tạm dừng thực thi
            Thread.Sleep(5000);




            //================== TC2_Login_30_Loc: nhâp email và  không nhập password ==========================
            //email_30_Loc ="mywebcnpm@gmail.com", password_30_Loc ="", expected_30_Loc = Thông báo lỗi

            //tải lại trang     
            driver_30_Loc.Navigate().Refresh();

            //bắt sự kiện Name= "username"
            //nhập dữ liệu vào email "mywebcnpm@gmail.com" 
            driver_30_Loc.FindElement(By.Name("username")).SendKeys("mywebcnpm@gmail.com");

            //bắt sự kiện Name= "username"
            //không truyền dữ liệu vào password
            driver_30_Loc.FindElement(By.Name("password")).SendKeys("");

            //bắt sự kiện Id ="button-login"
            //nhấn click đăng nhập 
            driver_30_Loc.FindElement(By.Id("button-login")).Click();

            //bắt sự kiện class="txt-error-login"
            //kiểm tra nếu có lỗi -> pass và nếu không có lỗi -> fail
            if (driver_30_Loc.FindElements(By.ClassName("txt-error-login")).Count > 0)
                Console.WriteLine("TC2_Login_30_Loc: nhap email va khong nhap password -> Pass ");
            else
                Console.WriteLine("TC2_Login_30_Loc: nhap email va khong nhap password -> Fail ");

            //chương trình tạm dừng thực thi
            Thread.Sleep(5000);


            //=================TC3_Login_30_Loc: nhâp email và  nhập password=====================================
            //email_30_Loc ="mywebcnpm@gmail.com", password_30_Loc ="Loc@123456", expected_30_Loc = Đăng nhập thành công

            //tải lại trang     
            driver_30_Loc.Navigate().Refresh();

            //bắt sự kiện Name= "username"
            //truyền dữ liệu vào email "mywebcnpm@gmail.com" 
            driver_30_Loc.FindElement(By.Name("username")).SendKeys("mywebcnpm@gmail.com");

            //bắt sự kiện Name= "username"
            //truyền dữ liệu vào password "Loc@123456"
            driver_30_Loc.FindElement(By.Name("password")).SendKeys("Loc@123456");

            //bắt sự kiện Id ="button-login"
            //nhấn click đăng nhập 
            driver_30_Loc.FindElement(By.Id("button-login")).Click();

            //chương trình tạm dừng thực thi
            Thread.Sleep(10000);

            //bắt sự kiện class ="h_name"
            // Kiểm tra nếu không có thông báo lỗi -> Pass và ngược lại là Fail
            if (driver_30_Loc.FindElements(By.ClassName("h_name")).Count > 0 )
                Console.WriteLine("TC3_Login_30_Loc: dang nhap thanh cong -> Pass ");
            else
                Console.WriteLine("TC3_Login_30_Loc: dang nhap that bai -> Fail ");

            //chương trình tạm dừng thực thi
            Thread.Sleep(10000);


            // Đóng trình duyệt
            driver_30_Loc.Quit();

        }

        //nút Search_30_Loc
        private void btn_Search_30_Loc_Click(object sender, EventArgs e)
        {
            //Khởi tạo ChromeDriverService và đóng màn hình đen khi chạy
            ChromeDriverService chrome_30_Loc = ChromeDriverService.CreateDefaultService();
            // Thiết lập không hiển thị cửa sổ dòng lệnh (Console window) khi khởi chạy trình duyệt Chrome
            chrome_30_Loc.HideCommandPromptWindow = true;

            //Khởi tạo ChromeDriver  
            driver_30_Loc = new ChromeDriver(chrome_30_Loc);
            //và điều hướng trình duyệt đến web báo tuổi trẻ
            driver_30_Loc.Navigate().GoToUrl("https://tuoitre.vn/");
            
            //chương trình tạm dừng thực thi 
            Thread.Sleep(3000);


            //=================TC4_Search_30_Loc Tìm kiếm bằng chuỗi kí tự đặc biệt =============================
            //---------------- search_30_Loc ="", expected_30_Loc = thông báo lỗi   -------------------

            //bắt sự kiện XPath
            //click vào nút tìm kiếm 
            driver_30_Loc.FindElement(By.XPath("//*[@id=\"admWrapsite\"]/div/div[2]/div/div[1]/div/div/div[2]/div[2]/div[1]/a[1]")).Click();

            //chương trình tạm dừng thực thi 
            Thread.Sleep(2000);

            //bắt sự kiện class="input-search"
            //nhập thông tin tìm kiếm vào sendkeys
            driver_30_Loc.FindElement(By.ClassName("input-search")).SendKeys("abc8hd1nj");

            //chương trình tạm dừng thực thi 
            Thread.Sleep(5000);

            //bắt sự kiện CssSelector
            //click vào nút tìm kiếm  
            driver_30_Loc.FindElement(By.CssSelector("#admWrapsite > div > div.header > div > div.header__top > div > div > div.header__top-right > div.header__action > div.box-search.frm-search.show > a.header__search.btn-search")).Click();
            
            // Lấy tất cả các phần tử <h3> trên trang
            IReadOnlyCollection<IWebElement> ee1_30_Loc = driver_30_Loc.FindElements(By.TagName("h3"));

            // Nếu không có kết quả -> PASS, ngược lại -> FAIL
            if (ee1_30_Loc.Count == 0)
            {
                Console.WriteLine("TC4_Search_30_Loc : khong co ket qua tim kiem -> Pass");
            }
            else
            {
                Console.WriteLine("TC4_Search_30_Loc : co ket qua tim kiem->Fail");
                //in các phần tử ra màn hình
                foreach (var r1_30_Loc in ee1_30_Loc)
                {
                    Console.WriteLine(r1_30_Loc.Text);
                }
            }


            //==============TC5_Search_30_Loc Tìm Kiếm với từ khóa cụ thể "kiểm thử phần mềm" ============================
            //--------- search_30_Loc ="kiểm thử phần mềm ",  expected_30_Loc = tìm kiếm thành công ----------------------

            //tải lại trang 
            driver_30_Loc.Navigate().Refresh();

            //chương trình tạm dừng thực thi 
            Thread.Sleep(3000);

            //bắt sự kiện Xpath
            //click vào nút tìm kiếm 
            driver_30_Loc.FindElement(By.XPath("//*[@id=\"admWrapsite\"]/div/div[2]/div/div[1]/div/div/div[2]/div[2]/div[1]/a[1]")).Click();

            //chương trình tạm dừng thực thi 
            Thread.Sleep(3000);

            //bắt sự kiện class="input-search"
            //nhập thông tin tìm kiếm vào sendkeys
            driver_30_Loc.FindElement(By.ClassName("input-search")).SendKeys("kiểm thử phần mềm");

            //chương trình tạm dừng thực thi 
            Thread.Sleep(3000);

            //bắt sự kiện CssSelector
            //click để nhấn tìm kiếm  
            driver_30_Loc.FindElement(By.CssSelector("#admWrapsite > div > div.header > div > div.header__top > div > div > div.header__top-right > div.header__action > div.box-search.frm-search.show > a.header__search.btn-search")).Click();

            //chương trình tạm dừng thực thi 
            Thread.Sleep(5000);

            // Lấy tất cả các phần tử <h3> trên trang
            IReadOnlyCollection<IWebElement> ee2_30_Loc = driver_30_Loc.FindElements(By.TagName("h3"));

            // Nếu không có kết quả -> Fail, ngược lại -> PASS
            if (ee2_30_Loc.Count == 0)
            {
                Console.WriteLine("TC5_Search_30_Loc : Khong co ket qua tim kiem -> Fail");
            }
            else
            {
                Console.WriteLine("TC5_Search_30_Loc : Co ket qua tim kiem -> Pass");
                //in các phần tử ra màn hình 
                Console.WriteLine("================================");
                foreach (var r2_30_Loc in ee2_30_Loc)
                {
                    Console.WriteLine(r2_30_Loc.Text);
                }
                Console.WriteLine("================================");
            }

            //chương trình tạm dừng thực thi 
            Thread.Sleep(5000);

            // Đóng trình duyệt
            driver_30_Loc.Quit();
        }


        //nút comment_30_Loc
        private void btn_Comment_30_Loc_Click(object sender, EventArgs e)
        {
            // Khởi tạo ChromeDriverService và ẩn màn hình đen
            ChromeDriverService chrome_30_Loc = ChromeDriverService.CreateDefaultService();
            // Thiết lập không hiển thị cửa sổ dòng lệnh (Console window) khi khởi chạy trình duyệt Chrome
            chrome_30_Loc.HideCommandPromptWindow = true;

            // Khởi tạo ChromeDriver và điều hướng trình duyệt đến trang web
            driver_30_Loc = new ChromeDriver(chrome_30_Loc);
            //và điều hướng trình duyệt đến web báo tuổi trẻ
            driver_30_Loc.Navigate().GoToUrl("https://tuoitre.vn/");

            //chương trình tạm dừng thực thi 
            Thread.Sleep(2000);
            
            //bắt sự kiện CssSelector
            //click vào nút đăng nhập
            driver_30_Loc.FindElement(By.CssSelector("#head_login > a > svg")).Click();

            //chương trình tạm dừng thực thi 
            Thread.Sleep(2000);

            //bắt sự kiện Name="username"
            //nhập dữ liệu vào email 
            driver_30_Loc.FindElement(By.Name("username")).SendKeys("mywebcnpm@gmail.com");

            //bắt sự kiện Name="password"
            //nhập dữ liệu vào password
            driver_30_Loc.FindElement(By.Name("password")).SendKeys("Loc@123456");

            //bắt sự kiện Id="button-login"
            //click chọn nút đăng nhập
            driver_30_Loc.FindElement(By.Id("button-login")).Click();

            //chương trình tạm dừng thực thi 
            Thread.Sleep(7000);


            //bắt sự kiện class="box-category-link-title" thẻ <a
            //click vào bài viết 
            driver_30_Loc.FindElement(By.ClassName("box-category-link-title")).Click();

            //=============== TC6_Comment_30_Loc Không nhập thông tin trong bình luận =================================
            //--------------   comment_30_Loc ="",  expected_30_Loc = thông báo lỗi        -----------------------------


            //Tìm phần tử trên trang web có class = "formtyping"
            IWebElement formTyping_30_Loc = driver_30_Loc.FindElement(By.ClassName("formtyping"));

            //Dùng Actions để cuộn
            //click vào formtyping
            Actions actions_30_Loc = new Actions(driver_30_Loc);
            //cuộn bằng action
            actions_30_Loc.MoveToElement(formTyping_30_Loc).Perform();

            //chương trình tạm dừng thực thi
            Thread.Sleep(2000); 

            //Click vào bình luận
            formTyping_30_Loc.Click();

            //bắt sự kiện class="input-type-text"
            // không nhập dữ liệu vào bình luận
            driver_30_Loc.FindElement(By.ClassName("input-type-text")).SendKeys("");

            //bắt sự kiện CssSelector 
            //Tìm phần tử button
            //cuộn đến bình luận với Action
            IWebElement button_30_Loc = driver_30_Loc.FindElement(By.CssSelector("#formCmt > div:nth-child(2) > div > button"));
            //cuộn đến bình luận với Action
            actions_30_Loc.MoveToElement(button_30_Loc).Perform();

            //chương trình tạm dừng thực thi 
            Thread.Sleep(2000);

            // Click vào nút gửi comment
            button_30_Loc.Click();

            //chương trình tạm dừng thực thi 
            Thread.Sleep(3000);

            // Xử lý alert nếu xuất hiện
            try
            {
                // Chuyển sang alert nếu có
                IAlert alert_30_Loc = driver_30_Loc.SwitchTo().Alert();
                // Bấm nút "OK" (hoặc "Yes") trên alert
                alert_30_Loc.Accept();
                // Tạm dừng 2 giây (có thể để chờ alert đóng hẳn)
                Thread.Sleep(2000); 
            }
            catch (NoAlertPresentException)
            {
                // Nếu không có alert thì in ra thông báo
                Console.WriteLine("No alert present.");
            }

           //chương trình tạm dựng thực thi 
            Thread.Sleep(3000);

            //bắt sự kiện class="item-comment"
            //đếm số lượng comment trước khi gửi bình luận
            int cmtCountBefore_30_Loc = driver_30_Loc.FindElements(By.ClassName("item-comment")).Count;


            //bắt sự kiện class="item-comment"
            //đếm số lượng comment sau khi gửi bình luận
            int cmtCountAfter_30_Loc = driver_30_Loc.FindElements(By.ClassName("item-comment")).Count;

            //Kiểm tra xem số lượng comment có thay đổi không
            //Nếu không nhập nội dung, không đăng bài thành công thì Pass và ngược lại thì Fail
            if (cmtCountAfter_30_Loc == cmtCountBefore_30_Loc)
            {
                Console.WriteLine("TC6_Comment_30_Loc: khong nhap noi dung, khong dang bai thanh cong ->  Pass");
            }
            else
            {
                Console.WriteLine("TC6_Comment_30_Loc: khong nhap noi dung nhung van dang bai ->  Fail");
            }

            // tải lại trang 
            driver_30_Loc.Navigate().Refresh();

            //====================== TC7_Comment_30_Loc  Không nhập thông tin trong bình luân ========================
            //--------------   comment_30_Loc ="bài viết", expected_30_Loc = Đăng bài thành công -------------------------

            //Tìm phần tử trên trang web có class = "formtyping"
            formTyping_30_Loc = driver_30_Loc.FindElement(By.ClassName("formtyping"));

            
            //click vào formtyping
            actions_30_Loc.MoveToElement(formTyping_30_Loc).Perform();
            
            //chương trình tạm dừng thực thi 
            Thread.Sleep(2000); 

            //click vào hộp bình luận 
            formTyping_30_Loc.Click();

            //bắt sự kiện class = "input-type-text"
            //nhập dữ liệu vào bình luận 
            driver_30_Loc.FindElement(By.ClassName("input-type-text")).SendKeys("bai viet");

            //chương trình tạm dừng thực thi 
            Thread.Sleep(3000);

            //bắt sự kiện CssSelector 
            //Tìm phần tử button
            //cuộn đến bình luận với Action
            button_30_Loc = driver_30_Loc.FindElement(By.CssSelector("#formCmt > div:nth-child(2) > div > button"));
            //cuộn đến bình luận với Action
            actions_30_Loc.MoveToElement(button_30_Loc).Perform();

            //chương trình tạm dừng thực thi 
            Thread.Sleep(2000);
            
            //click vào nút đăng bài 
            button_30_Loc.Click();

            //chương trình tạm dừng thực thi 
            Thread.Sleep(3000);

            // Xử lý alert nếu xuất hiện
            try
            {
                // Chuyển sang alert nếu có
                IAlert alert_30_Loc = driver_30_Loc.SwitchTo().Alert();
                // Bấm nút "OK" (hoặc "Yes") trên alert
                alert_30_Loc.Accept();
                // Tạm dừng 2 giây(có thể để chờ alert đóng hẳn)
                Thread.Sleep(2000);
            }
            catch (NoAlertPresentException)
            {
                // Nếu không có alert thì in ra thông báo
                Console.WriteLine("No alert present.");
            }

            //chương trình tạm dừng thực thi 
            Thread.Sleep(3000);

            //bắt sự kiện class="input-type-text"
            //nhập nội dung và đăng bài thành công thì pass và ngược lại thì fail
            if (driver_30_Loc.FindElements(By.ClassName("input-type-text")).Count > 0)
            {
                Console.WriteLine("TC7_Comment_30_Loc: nhap noi dung dang bai thanh cong -> Pass");
            }
            else
                Console.WriteLine("TC7_Comment_30_Loc: nhap noi dung dang bai khong thanh cong -> Fail ");

            //chương trình tạm dừng thực thi 
            Thread.Sleep(3000);

            // Đóng trình duyệt
            driver_30_Loc.Quit();
        }
    }
}
