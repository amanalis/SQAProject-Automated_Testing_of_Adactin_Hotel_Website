using Newtonsoft.Json.Linq;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Group Members (Aahil Ali_2012326_Sec_B, Anwer Aslam (2012334)_Sec_B & Aman Ali (2012375)_Sec_A//

namespace SpecFlowProject
{
    public class BaseClass
    {
        public static ChromeDriver chromeDriver;

        public void DriverConfigure()
        {

            chromeDriver = new ChromeDriver();
        }
        public void OpenBrowserAndURL()
        {
            var jsonData = JObject.Parse(File.ReadAllText("C:\\Users\\aman\\Downloads\\SQE_Project_Aahil (2012326)_Anwer(2012334)_Aman(2012375)\\SpecFlowProject\\SpecFlowProject\\data.json"));
            string url = jsonData["url"].ToString();
            chromeDriver.Manage().Window.Maximize();
            chromeDriver.Navigate().GoToUrl(url);
        }

        public void CloseBrowser()
        {
            chromeDriver.Close();

        }
    }
}
