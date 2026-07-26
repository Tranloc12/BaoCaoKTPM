# 🧪 BÁO CÁO ĐỒ ÁN MÔN KIỂM THỬ PHẦN MỀM (KTPM)
> **Học phần**: Kiểm thử phần mềm (KTPM)  
> **Sinh viên thực hiện**: Trần Lộc (STT: 30)  
> **Repository**: [Tranloc12/BaoCaoKTPM](https://github.com/Tranloc12/BaoCaoKTPM)  
---
![C#](https://img.shields.io/badge/Language-C%23-blue.svg?style=for-the-badge&logo=csharp)
![.NET](<https://img.shields.io/badge/Framework-.NET Framework-purple.svg?style=for-the-badge&logo=dotnet>)
![NUnit](https://img.shields.io/badge/Unit_Test-NUnit%2FMSTest-green.svg?style=for-the-badge&logo=nunit)
![Selenium](https://img.shields.io/badge/UI_Test-Selenium_WebDriver-orange.svg?style=for-the-badge&logo=selenium)
![Postman](https://img.shields.io/badge/API_Test-Postman-red.svg?style=for-the-badge&logo=postman)
![JSON Server](https://img.shields.io/badge/Mock_API-JSON_Server-yellow.svg?style=for-the-badge&logo=node.js)
---
## 📌 MỤC LỤC
1. [📖 Giới Thiệu Dự Án](#1-giới-thiệu-dự-án)
2. [📁 Cấu Trúc Thư Mục Dự Án](#2-cấu-trúc-thư-mục-dự-án)
3. [🧩 Chi Tiết Các Phần Kiểm Thử](#3-chi-tiết-các-phần-kiểm-thử)
   - [3.1. Unit Test - Tính Chu Vi Hình Chữ Nhật (NUnit / MSTest)](#31-unit-test---tính-chu-vi-hình-chữ-nhật-nunit--mstest)
   - [3.2. UI Automation Test - Báo Tuổi Trẻ (Selenium WebDriver)](#32-ui-automation-test---báo-tuổi-trẻ-selenium-webdriver)
   - [3.3. API Testing - RESTful API (Postman & JSON Server)](#33-api-testing---restful-api-postman--json-server)
4. [📊 Bảng Kịch Bản Test Cases Mẫu](#4-bảng-kịch-bản-test-cases-mẫu)
5. [🛠️ Hướng Dẫn Cài Đặt Môi Trường](#5-hướng-dẫn-cài-đặt-môi-trường)
6. [🚀 Hướng Dẫn Thực Thi Kiểm Thử (Run Tests)](#6-hướng-dẫn-thực-thi-kiểm-thử-run-tests)
7. [📑 Tài Liệu Báo Cáo Đồ Án](#7-tài-liệu-báo-cáo-đồ-án)
---
## 1. 📖 GIỚI THIỆU DỰ ÁN
Dự án **BaoCaoKTPM** tổng hợp toàn bộ các bài thực hành theo tuần và đồ án môn học **Kiểm thử phần mềm (KTPM)**. Nội dung đồ án bao phủ 3 phương pháp kiểm thử quan trọng nhất trong quy trình phát triển phần mềm:
1. **Kiểm thử đơn vị (Unit Testing)**: Kiểm thử các hàm/phương thức logic toán học (Tính chu vi, diện tích Hình Chữ Nhật) sử dụng NUnit/MSTest trên nền tảng C# / .NET.
2. **Kiểm thử tự động giao diện (UI Automation Testing)**: Sử dụng **Selenium WebDriver (C#)** để giả lập hành vi người dùng, kiểm thử luồng đăng nhập và điều hướng trên trang báo điện tử [Tuổi Trẻ](https://tuoitre.vn).
3. **Kiểm thử API (API Testing)**: Khởi tạo Mock REST API server bằng **JSON Server** (Node.js) và xây dựng bộ kịch bản kiểm thử tự động trên **Postman** (Validate Status Code, Response Schema, Response Time).
---
## 2. 📁 CẤU TRÚC THƯ MỤC DỰ ÁN
```text
BaoCaoKTPM/
├── README.md
└── DoAn_KTPM/
    ├── Buổi 1/                       # Buổi 1: Unit Test NUnit cơ bản
    │   └── 30_Loc_43_N2_/
    │       ├── 30_Loc_43_N2_.sln     # Visual Studio Solution
    │       ├── UnitTest_30_Loc/      # Dự án Unit Test
    │       └── 30_Loc_43_N2.docx     # Báo cáo Buổi 1
    │
    ├── Buổi 2/                       # Buổi 2: Selenium WebDriver UI Test
    │   └── WebDriver_BaoTuoiTre/     # Test Automation trên Tuoitre.vn
    │
    ├── Buổi 3/                       # Buổi 3: API Testing
    │   └── 30_Loc_50_N2/
    │       ├── db.json               # Cơ sở dữ liệu JSON Server
    │       └── Postman_Collection/   # Export file Postman Collection & Environment
    │
    ├── Buổi 4/                       # Buổi 4: Các kịch bản mở rộng
    │   └── 30_Loc_27_N2/
    │
    └── DoAn_KTPM_30_Loc/             # 🏆 THƯ MỤC ĐỒ ÁN TỔNG HỢP (FINAL PROJECT)
        ├── KTPM_BaoCao_30_Loc.docx   # File báo cáo Word chi tiết
        ├── KTPM_BangTestCase_30_Loc.xlsx # File Ma trận Test Cases Excel
        ├── KTPM_NUNIT_30_Loc/        # Solution C# tổng hợp (NUnit + Selenium)
        │   ├── NUNIT_30_Loc/         # Source code Unit Test C#
        │   │   └── UnitTest_30_Loc.cs
        │   └── WebDriver_30_Loc/     # Source code WinForms Selenium UI Test
        │       └── Form1.cs
        └── JsonServer_30_Loc/        # Thư mục chứa API Mock Server & Postman Tests
```
---
## 3. 🧩 CHI TIẾT CÁC PHẦN KIỂM THỬ
### 3.1. Unit Test - Tính Chu Vi Hình Chữ Nhật (NUnit / MSTest)
* **Đối tượng kiểm thử**: Lớp `Rectangle_30_Loc` với phương thức `CalculatePerimeter_30_Loc()`.
* **Công thức toán học**: P = (d + r) * 2 (trong đó d: chiều dài, r: chiều rộng).
* **Kỹ thuật thiết kế Test Case**: Phân hoạch tương đương (Equivalence Partitioning) & Phân tích giá trị biên (Boundary Value Analysis).
#### 🛠️ Code Demo (UnitTest_30_Loc.cs):
```csharp
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KTPM_NUNIT_30_Loc;
namespace NUNIT_30_Loc
{
    [TestClass]
    public class UnitTest_30_Loc
    {
        // TC1: Kiểm thử trường hợp giá trị hợp lệ ngẫu nhiên (d = 5, r = 4) -> Chu vi = 18
        [TestMethod]
        public void TC1_DR_Valid_30_Loc()
        {
            Rectangle_30_Loc rectangle_30_Loc = new Rectangle_30_Loc(5, 4);
            int expected_30_Loc = 18;
            int actual_30_Loc = rectangle_30_Loc.CalculatePerimeter_30_Loc();
            Assert.AreEqual(expected_30_Loc, actual_30_Loc);
        }
        // TC2: Kiểm thử trường hợp giá trị biên nhỏ nhất hợp lệ (d = 1, r = 1) -> Chu vi = 4
        [TestMethod]
        public void TC2_DR_Valid_Min_30_Loc()
        {
            Rectangle_30_Loc rectangle_30_Loc = new Rectangle_30_Loc(1, 1);
            int expected_30_Loc = 4;
            int actual_30_Loc = rectangle_30_Loc.CalculatePerimeter_30_Loc();
            Assert.AreEqual(expected_30_Loc, actual_30_Loc);
        }
    }
}
```
---
### 3.2. UI Automation Test - Báo Tuổi Trẻ (Selenium WebDriver)
* **Website kiểm thử**: `https://tuoitre.vn/`
* **Công nghệ sử dụng**: C# WinForms, `Selenium.WebDriver`, `ChromeDriverService`.
* **Kịch bản kiểm thử tiêu biểu**: Tự động mở trình duyệt Chrome, truy cập trang chủ, kích hoạt popup đăng nhập, để trống tài khoản/mật khẩu và kiểm tra thông báo lỗi hiển thị (`txt-error-login`).
#### 🛠️ Code Demo (Form1.cs):
```csharp
using System;
using System.Threading;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace WebDriver_30_Loc
{
    public partial class WebDriver_BaoTuoiTre_30_Loc : Form
    {
        private IWebDriver driver_30_Loc;
        private void btn_Login_30_Loc_Click(object sender, EventArgs e)
        {
            // Ẩn cửa sổ CMD của ChromeDriver để tối ưu giao diện
            ChromeDriverService chrome_30_Loc = ChromeDriverService.CreateDefaultService();
            chrome_30_Loc.HideCommandPromptWindow = true;
            // Khởi tạo WebDriver và điều hướng đến trang Báo Tuổi Trẻ
            driver_30_Loc = new ChromeDriver(chrome_30_Loc);
            driver_30_Loc.Navigate().GoToUrl("https://tuoitre.vn/");
            Thread.Sleep(3000);
            // Click vào nút Đăng nhập trên Header
            driver_30_Loc.FindElement(By.Id("head_login")).Click();
            Thread.Sleep(2000);
            // Để trống Username & Password và click Đăng nhập
            driver_30_Loc.FindElement(By.Name("username")).SendKeys("");
            driver_30_Loc.FindElement(By.Name("password")).SendKeys("");
            driver_30_Loc.FindElement(By.Id("button-login")).Click();
            // Kiểm tra xem Element thông báo lỗi có xuất hiện hay không
            if (driver_30_Loc.FindElements(By.ClassName("txt-error-login")).Count > 0)
                Console.WriteLine("TC1_Login_30_Loc: Không nhập email và password -> PASS");
            else
                Console.WriteLine("TC1_Login_30_Loc: Không nhập email và password -> FAIL");
        }
    }
}
```
---
### 3.3. API Testing - RESTful API (Postman & JSON Server)
* **Mock Server**: Khởi chạy API server local qua `json-server` port `3000`.
* **Endpoints thử nghiệm**:
  - `GET /posts`: Lấy danh sách bài viết.
  - `POST /posts`: Thêm bài viết mới.
  - `PUT /posts/:id`: Cập nhật bài viết.
  - `DELETE /posts/:id`: Xóa bài viết.
#### 🛠️ Postman Test Scripts (JS):
```javascript
// Test 1: Kiểm tra Status Code trả về là 200 OK
pm.test("Status code is 200 OK", function () {
    pm.response.to.have.status(200);
});
// Test 2: Kiểm tra thời gian phản hồi API nhỏ hơn 500ms
pm.test("Response time is less than 500ms", function () {
    pm.expect(pm.response.responseTime).to.be.below(500);
});
// Test 3: Validate dữ liệu JSON trả về đúng thuộc tính mong đợi
pm.test("Check post title property", function () {
    var jsonData = pm.response.json();
    pm.expect(jsonData[0]).to.have.property("title");
});
```
---
## 4. 📊 BẢNG KỊCH BẢN TEST CASES MẪU

| Test Case ID | Phân Loại | Kịch Bản Kiểm Thử | Kết Quả Mong Đợi | Kết Quả |
| :--- | :--- | :--- | :--- | :---: |
| **TC1_NUNIT_01** | Unit Test | Tính chu vi số hợp lệ (d=5, r=4) | Chu vi = 18 | `PASS` |
| **TC2_NUNIT_02** | Unit Test | Tính chu vi số biên (d=1, r=1) | Chu vi = 4 | `PASS` |
| **TC1_UI_01** | UI Test | Đăng nhập để trống thông tin | Hiển thị lỗi `txt-error-login` | `PASS` |
| **TC2_UI_02** | UI Test | Tìm kiếm bài viết "KTPM" | Chuyển trang kết quả tìm kiếm | `PASS` |
| **TC1_API_01** | API Test | Lấy danh sách tài nguyên (GET) | Status `200 OK` | `PASS` |
| **TC2_API_02** | API Test | Thêm mới tài nguyên (POST) | Status `201 Created` | `PASS` |
---
## 5. 🛠️ HƯỚNG DẪN CÀI ĐẶT MÔI TRƯỜNG
Để khởi chạy toàn bộ dự án trên máy cục bộ, cần chuẩn bị các công cụ sau:
1. **Visual Studio 2019 / 2022**:
   - Cài đặt Workload: `.NET desktop development`.
   - Cài đặt NuGet Packages: `NUnit`, `NUnitTestAdapter`, `MSTest.TestFramework`, `Selenium.WebDriver`, `Selenium.Support`.
2. **Node.js & npm** (Dùng cho API Testing):
   - Tải và cài đặt Node.js từ [nodejs.org](https://nodejs.org/).
   - Cài đặt **JSON Server** toàn cục:
     ```bash
     npm install -g json-server
     ```
3. **Postman Desktop**:
   - Tải ứng dụng Postman tại [postman.com/downloads](https://www.postman.com/downloads/).
4. **Google Chrome & ChromeDriver**:
   - Đảm bảo phiên bản Google Chrome và `chromedriver.exe` đồng bộ với nhau.
---
## 6. 🚀 HƯỚNG DẪN THỰC THI KIỂM THỬ (RUN TESTS)
### 🔹 Bước 1: Clone Repository
```bash
git clone https://github.com/Tranloc12/BaoCaoKTPM.git
cd BaoCaoKTPM
```
### 🔹 Bước 2: Chạy Unit Test & UI Test (Visual Studio)
1. Truy cập thư mục `DoAn_KTPM/DoAn_KTPM_30_Loc/KTPM_NUNIT_30_Loc/`.
2. Mở file solution **`KTPM_NUNIT_30_Loc.sln`** bằng Visual Studio.
3. Trên thanh menu, chọn `Test` ➔ `Test Explorer` (Hoặc nhấn tổ hợp phím `Ctrl + E, T`).
4. Nhấn **Run All Tests** để thực thi toàn bộ bộ kiểm thử NUnit và Selenium WebDriver.
### 🔹 Bước 3: Chạy API Testing (JSON Server + Postman)
1. Mở cửa sổ Terminal/Command Prompt tại thư mục chứa file `db.json` (`DoAn_KTPM/DoAn_KTPM_30_Loc/JsonServer_30_Loc/`).
2. Khởi chạy Mock REST Server:
   ```bash
   json-server --watch db.json --port 3000
   ```
   *Server sẽ sẵn sàng tại địa chỉ `http://localhost:3000`.*
3. Mở ứng dụng **Postman**:
   - Chọn **Import** ➔ Nhập file Postman Collection (`.json`) và Environment từ thư mục `JsonServer_30_Loc`.
   - Nhấn nút **Run Collection** ➔ Chọn **Run KTPM_API_Tests** để chạy kiểm thử tự động toàn bộ API endpoints.
---
## 7. 📑 TÀI LIỆU BÁO CẢO ĐỒ ÁN
Tất cả các tài liệu báo cáo nghiệm thu chi tiết được lưu trữ tại thư mục `DoAn_KTPM/DoAn_KTPM_30_Loc/`:
* 📄 **File Báo Cáo Word**: [`KTPM_BaoCao_30_Loc.docx`](./DoAn_KTPM/DoAn_KTPM_30_Loc/KTPM_BaoCao_30_Loc.docx) (Trình bày cơ sở lý thuyết, sơ đồ luồng kiểm thử, chụp màn hình kết quả chạy thực tế).
* 📊 **File Excel Test Cases**: [`KTPM_BangTestCase_30_Loc.xlsx`](./DoAn_KTPM/DoAn_KTPM_30_Loc/KTPM_BangTestCase_30_Loc.xlsx) (Bảng ma trận chi tiết các điều kiện kiểm thử, input, output và status).
---
### 👨‍💻 Sinh Viên Thực Hiện
* **Họ và tên**: Trần Lộc
* **Mã SV / STT**: 30
* **GitHub Profile**: [@Tranloc12](https://github.com/Tranloc12)
