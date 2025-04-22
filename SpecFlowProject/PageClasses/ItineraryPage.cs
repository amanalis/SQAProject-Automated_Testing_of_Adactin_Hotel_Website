using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
// Group Members (Aahil Ali_2012326_Sec_B, Anwer Aslam (2012334)_Sec_B & Aman Ali (2012375)_Sec_A//

namespace SpecFlowProject.PageClasses
{
    internal class ItineraryPage : BaseClass
    {
        public void Menu_Itinerarybtn()
        {
            chromeDriver.FindElement(By.XPath(Locators.menu_Itinerary)).Click();
        }
         public void BookedItinerary_txt()
        {
            var jsonData = JObject.Parse(File.ReadAllText("C:\\Users\\aman\\Downloads\\SQE_Project_Aahil (2012326)_Anwer(2012334)_Aman(2012375)\\SpecFlowProject\\SpecFlowProject\\data.json"));
            string expected = jsonData["BookedItinerary"].ToString();
            string actual = chromeDriver.FindElement(By.XPath(Locators.Booked_Itinerary)).Text;
            Assert.AreEqual(expected, actual);
        }

        public void CancelSingleOrder()
        {
            chromeDriver.FindElement(By.XPath(Locators.order_cancelbtn)).Click();
            chromeDriver.SwitchTo().Alert().Accept();
        }

        public void BookingCancel_txt()
        {
            var jsonData = JObject.Parse(File.ReadAllText("C:\\Users\\aman\\Downloads\\SQE_Project_Aahil (2012326)_Anwer(2012334)_Aman(2012375)\\SpecFlowProject\\SpecFlowProject\\data.json"));
            string expected = jsonData["BookingCancelled"].ToString();
            string actual = chromeDriver.FindElement(By.XPath(Locators.booking_canceled)).Text;
            Assert.AreEqual(expected, actual);
        }

        public void Search_OrderId()
        {
            var jsonData = JObject.Parse(File.ReadAllText("C:\\Users\\aman\\Downloads\\SQE_Project_Aahil (2012326)_Anwer(2012334)_Aman(2012375)\\SpecFlowProject\\SpecFlowProject\\data.json"));
            string orderid= jsonData["orderId"].ToString();
            Console.WriteLine(orderid);
            chromeDriver.FindElement(By.Id(Locators.order_id_text)).SendKeys("orderId");
            chromeDriver.FindElement(By.Id(Locators.search_hotel_id)).Click();
        }

        public void Searched_OrderId()
        {
            var jsonData = JObject.Parse(File.ReadAllText("C:\\Users\\aman\\Downloads\\SQE_Project_Aahil (2012326)_Anwer(2012334)_Aman(2012375)\\SpecFlowProject\\SpecFlowProject\\data.json"));
            string expected = jsonData["orderId"].ToString();
            string actual = chromeDriver.FindElement(By.XPath(Locators.orderid_Xpath)).Text;
            Assert.AreEqual(expected, actual);
        }

        public void Logout_btn()
        {
            chromeDriver.FindElement(By.Id(Locators.logout)).Click();
        }
    }
}
