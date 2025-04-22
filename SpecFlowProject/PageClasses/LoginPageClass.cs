using Newtonsoft.Json.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Group Members (Aahil Ali_2012326_Sec_B, Anwer Aslam (2012334)_Sec_B & Aman Ali (2012375)_Sec_A//

namespace SpecFlowProject
{
    internal class LoginPageClass : BaseClass
    {

        public void LoginMethod()
        {
            var jsonData = JObject.Parse(File.ReadAllText("C:\\Users\\aman\\Downloads\\SQE_Project_Aahil (2012326)_Anwer(2012334)_Aman(2012375)\\SpecFlowProject\\SpecFlowProject\\data.json"));
            string url = jsonData["url"].ToString();
            string userName = jsonData["username"].ToString();
            string password = jsonData["password"].ToString();
            chromeDriver.FindElement(By.Id(Locators.UserName)).SendKeys(userName);
            chromeDriver.FindElement(By.Id(Locators.Password)).SendKeys(password);
            chromeDriver.FindElement(By.Id(Locators.LoginButton)).Click();

        }

        public void ValidateSuccessfullLogin()
        {
            var jsonData = JObject.Parse(File.ReadAllText("C:\\Users\\aman\\Downloads\\SQE_Project_Aahil (2012326)_Anwer(2012334)_Aman(2012375)\\SpecFlowProject\\SpecFlowProject\\data.json"));
            string url = jsonData["url"].ToString();
            string welcomeText = jsonData["welcometext"].ToString();
            string text = chromeDriver.FindElement(By.XPath(Locators.WelcomeText)).Text;
            Assert.AreEqual(text, welcomeText);
        }

        public void InvalidLoginMethod()
        {
            var jsonData = JObject.Parse(File.ReadAllText("C:\\Users\\aman\\Downloads\\SQE_Project_Aahil (2012326)_Anwer(2012334)_Aman(2012375)\\SpecFlowProject\\SpecFlowProject\\data.json"));
            string url = jsonData["url"].ToString();
            string userName = jsonData["username"].ToString();
            string password = jsonData["wrongpassword"].ToString();
            chromeDriver.FindElement(By.Id(Locators.UserName)).SendKeys(userName);
            chromeDriver.FindElement(By.Id(Locators.Password)).SendKeys(password);
            chromeDriver.FindElement(By.Id(Locators.LoginButton)).Click();
        }

        public void ValidateUnsuccessssulLogin()
        {
            var jsonData = JObject.Parse(File.ReadAllText("C:\\Users\\aman\\Downloads\\SQE_Project_Aahil (2012326)_Anwer(2012334)_Aman(2012375)\\SpecFlowProject\\SpecFlowProject\\data.json"));
            string url = jsonData["url"].ToString();
            string expectedMessage = jsonData["notvalidusertext"].ToString(); ;
            string displayedMessage = chromeDriver.FindElement(By.XPath(Locators.NotLoginMessage)).Text;
            Assert.AreEqual(displayedMessage, expectedMessage);
        }

        public void NoUsernameLoginMethod()
        {
            var jsonData = JObject.Parse(File.ReadAllText("C:\\Users\\aman\\Downloads\\SQE_Project_Aahil (2012326)_Anwer(2012334)_Aman(2012375)\\SpecFlowProject\\SpecFlowProject\\data.json"));
            string url = jsonData["url"].ToString();
            string userName = jsonData["username"].ToString();
            string password = jsonData["password"].ToString();
            //chromeDriver.FindElement(By.Id(Locators.UserName)).SendKeys(userName);
            chromeDriver.FindElement(By.Id(Locators.Password)).SendKeys(password);
            chromeDriver.FindElement(By.Id(Locators.LoginButton)).Click();
        }

        public void usernameNotEntered()
        {
            var jsonData = JObject.Parse(File.ReadAllText("C:\\Users\\aman\\Downloads\\SQE_Project_Aahil (2012326)_Anwer(2012334)_Aman(2012375)\\SpecFlowProject\\SpecFlowProject\\data.json"));
            string url = jsonData["url"].ToString();
            string expectedMessage = jsonData["noUsername"].ToString(); ;
            string displayedMessage = chromeDriver.FindElement(By.XPath(Locators.NotUsername)).Text;
            Assert.AreEqual(displayedMessage, expectedMessage);
        }

        public void NoPasswordLoginMethod()
        {
            var jsonData = JObject.Parse(File.ReadAllText("C:\\Users\\aman\\Downloads\\SQE_Project_Aahil (2012326)_Anwer(2012334)_Aman(2012375)\\SpecFlowProject\\SpecFlowProject\\data.json"));
            string url = jsonData["url"].ToString();
            string userName = jsonData["username"].ToString();
            string password = jsonData["password"].ToString();
            chromeDriver.FindElement(By.Id(Locators.UserName)).SendKeys(userName);
            //chromeDriver.FindElement(By.Id(Locators.Password)).SendKeys(password);
            chromeDriver.FindElement(By.Id(Locators.LoginButton)).Click();
        }

        public void passwordNotEntered()
        {
            var jsonData = JObject.Parse(File.ReadAllText("C:\\Users\\aman\\Downloads\\SQE_Project_Aahil (2012326)_Anwer(2012334)_Aman(2012375)\\SpecFlowProject\\SpecFlowProject\\data.json"));
            string url = jsonData["url"].ToString();
            string expectedMessage = jsonData["noPassword"].ToString(); ;
            string displayedMessage = chromeDriver.FindElement(By.XPath(Locators.NotPassword)).Text;
            Assert.AreEqual(displayedMessage, expectedMessage);
        }

        public void NoUsernameAndPasswordLoginMethod()
        {
            chromeDriver.FindElement(By.Id(Locators.LoginButton)).Click();
        }
    }
}
