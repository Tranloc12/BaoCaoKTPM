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
