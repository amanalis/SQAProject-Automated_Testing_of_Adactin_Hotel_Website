# 🧪 Adactin Hotel Website - Automated Testing Project

This project demonstrates **automated software testing** for the [Adactin Hotel Booking Website](http://adactinhotelapp.com/) using **C# .NET**, **Selenium WebDriver**, and **Behavior Driven Development (BDD)** with **SpecFlow**.

All test executions are integrated with **Allure Reporting** to visualize and analyze results effectively.

---

## 🔧 Tech Stack

- **Language**: C# (.NET Framework)
- **Automation Tool**: Selenium WebDriver
- **BDD Framework**: SpecFlow (Gherkin)
- **Design Pattern**: Page Object Model (POM)
- **Reporting**: Allure Reports
- **Test Runner**: NUnit

---

## ✅ Tested Scenarios

### 🔐 Login Page
- Valid login with correct credentials
- Invalid login attempt
- Empty fields validation

### 🏨 Booking Page
- Room selection and booking flow
- Date picker validations
- Booking confirmation

### 📋 Itinerary Page
- View existing bookings
- Modify or cancel bookings
- Booking details verification

---

## 📸 Reporting

All test results are generated using **Allure Reports** for a rich UI-based test history and step-by-step visibility.

To view reports:
```bash
allure serve bin\Debug\net6.0\allure-results
