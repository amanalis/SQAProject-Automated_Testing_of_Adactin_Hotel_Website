using Amazon.DynamoDBv2;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
// Group Members (Aahil Ali_2012326_Sec_B, Anwer Aslam (2012334)_Sec_B & Aman Ali (2012375)_Sec_A//
namespace SpecFlowProject.PageClasses
{
    internal class Booking : BaseClass
    {
        public void SearchTap()
        {
            chromeDriver.FindElement(By.Id(Locators.Search)).Click();
        }

        public void LocationError()
        {
            var jsonData = JObject.Parse(File.ReadAllText("C:\\Users\\aman\\Downloads\\SQE_Project_Aahil (2012326)_Anwer(2012334)_Aman(2012375)\\SpecFlowProject\\SpecFlowProject\\data.json"));
            string location_error = jsonData["location_error"].ToString();
            string validLocationError = chromeDriver.FindElement(By.XPath(Locators.SearchError)).Text;
            Assert.AreEqual(location_error, validLocationError);
        }

        public void Reset_btn()
        {
            var jsonData = JObject.Parse(File.ReadAllText("C:\\Users\\aman\\Downloads\\SQE_Project_Aahil (2012326)_Anwer(2012334)_Aman(2012375)\\SpecFlowProject\\SpecFlowProject\\data.json"));
            IWebElement location_drop_down = chromeDriver.FindElement(By.Id(Locators.location));
            SelectElement select = new SelectElement(location_drop_down);
            select.SelectByText("Sydney");
            chromeDriver.FindElement(By.Id(Locators.Reset_btn)).Click();
            IWebElement selectedOption = select.SelectedOption;
            string selected_txt = selectedOption.Text;
            Console.WriteLine(selected_txt);
            Assert.AreEqual(selected_txt, "- Select Location -");
        }

        public void SearchHotel()
        {
            var jsonData = JObject.Parse(File.ReadAllText("C:\\Users\\aman\\Downloads\\SQE_Project_Aahil (2012326)_Anwer(2012334)_Aman(2012375)\\SpecFlowProject\\SpecFlowProject\\data.json"));
            IWebElement location_drop_down = chromeDriver.FindElement(By.Id(Locators.location));
            SelectElement select = new SelectElement(location_drop_down);
            select.SelectByText("Sydney");
            chromeDriver.FindElement(By.Id(Locators.Search)).Click();
            string selecthotel = jsonData["selecthotel"].ToString();
            string validSelectHotel = chromeDriver.FindElement(By.XPath(Locators.SelectHotel_Text)).Text;
            Assert.AreEqual(selecthotel, validSelectHotel);
        }

        public void ContinueTap()
        {
            chromeDriver.FindElement(By.Id(Locators.ContinueBtn)).Click();
        }
        public void SelectHotel_Error()
        {
            var jsonData = JObject.Parse(File.ReadAllText("C:\\Users\\aman\\Downloads\\SQE_Project_Aahil (2012326)_Anwer(2012334)_Aman(2012375)\\SpecFlowProject\\SpecFlowProject\\data.json"));
            string expected = jsonData["selecthotelerr"].ToString();
            string actual = chromeDriver.FindElement(By.XPath(Locators.SelectHotel_error)).Text;
            Assert.AreEqual(expected, actual);
        }

        public void SelectHotel()
        {
            var jsonData = JObject.Parse(File.ReadAllText("C:\\Users\\aman\\Downloads\\SQE_Project_Aahil (2012326)_Anwer(2012334)_Aman(2012375)\\SpecFlowProject\\SpecFlowProject\\data.json"));
            chromeDriver.FindElement(By.Id(Locators.SelectHotel)).Click();
            chromeDriver.FindElement(By.Id(Locators.ContinueBtn)).Click();
            string BookHotel = jsonData["Book A Hotel"].ToString();
            string validBookHotel = chromeDriver.FindElement(By.XPath(Locators.BookHotel_Text)).Text;
            Assert.AreEqual(BookHotel, validBookHotel);
        }

        public void BookNowTap()
        {
            chromeDriver.FindElement(By.Id(Locators.book_now)).Click();
        }

        public void BookNow_Error()
        {
            var jsonData = JObject.Parse(File.ReadAllText("C:\\Users\\aman\\Downloads\\SQE_Project_Aahil (2012326)_Anwer(2012334)_Aman(2012375)\\SpecFlowProject\\SpecFlowProject\\data.json"));
            string expected = jsonData["firstnameerr"].ToString();
            string actual = chromeDriver.FindElement(By.XPath(Locators.firstname_error)).Text;
            Assert.AreEqual(expected, actual);
        }

        public void BookAHotel()
        {
            var jsonData = JObject.Parse(File.ReadAllText("C:\\Users\\aman\\Downloads\\SQE_Project_Aahil (2012326)_Anwer(2012334)_Aman(2012375)\\SpecFlowProject\\SpecFlowProject\\data.json"));
            string firstname = jsonData["firstname"].ToString();
            string lastname = jsonData["lastname"].ToString();
            string billaddress = jsonData["billaddress"].ToString();
            string creditcardno = jsonData["creditcardno"].ToString();
            string cvvno = jsonData["cvvno"].ToString();

            chromeDriver.FindElement(By.Id(Locators.first_name)).SendKeys(firstname);
            chromeDriver.FindElement(By.Id(Locators.last_name)).SendKeys(lastname);
            chromeDriver.FindElement(By.Id(Locators.address)).SendKeys(billaddress);
            chromeDriver.FindElement(By.Id(Locators.cc_num)).SendKeys(creditcardno);

            IWebElement CCType_drop_down = chromeDriver.FindElement(By.Id(Locators.cc_type));
            SelectElement selectCCType = new SelectElement(CCType_drop_down);
            selectCCType.SelectByText("American Express");

            IWebElement Month_drop_down = chromeDriver.FindElement(By.Id(Locators.cc_exp_month));
            SelectElement selectMonth = new SelectElement(Month_drop_down);
            selectMonth.SelectByText("April");

            IWebElement Year_drop_down = chromeDriver.FindElement(By.Id(Locators.cc_exp_year));
            SelectElement selectYear = new SelectElement(Year_drop_down);
            selectYear.SelectByText("2026");

            chromeDriver.FindElement(By.Id(Locators.cc_cvv)).SendKeys(cvvno);
            chromeDriver.FindElement(By.Id(Locators.book_now)).Click();
        }

        public void SuccessfullBooking()
        {
            var jsonData = JObject.Parse(File.ReadAllText("C:\\Users\\aman\\Downloads\\SQE_Project_Aahil (2012326)_Anwer(2012334)_Aman(2012375)\\SpecFlowProject\\SpecFlowProject\\data.json"));
            string bookingConfirm = jsonData["bookingconfirm"].ToString();
            string validbookingconfirm = chromeDriver.FindElement(By.XPath(Locators.BookingConfirmation_text)).Text;
            Assert.AreEqual(bookingConfirm, validbookingconfirm);
        }

        public void Logout_Successfulbooking()
        {
            chromeDriver.FindElement(By.Id(Locators.logout_btn)).Click();
        }

        public void Successful_logouttxt() 
        {
            var jsonData = JObject.Parse(File.ReadAllText("C:\\Users\\aman\\Downloads\\SQE_Project_Aahil (2012326)_Anwer(2012334)_Aman(2012375)\\SpecFlowProject\\SpecFlowProject\\data.json"));
            string expected = jsonData["successfully_logged_out"].ToString();
            string actual = chromeDriver.FindElement(By.XPath(Locators.successful_logout_txt)).Text;
            Assert.AreEqual(expected, actual);
        }

        public void Menu_Logout()
        {
            chromeDriver.FindElement(By.XPath(Locators.menu_logout)).Click();
        }
    }
}
