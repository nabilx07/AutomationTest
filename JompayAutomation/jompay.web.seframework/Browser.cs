using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;

namespace jompay.web.seframework
{
    public static class Browser
    {
        //private static string baseUrl = ConfigurationManager.AppSettings("JompayPageUrl").ToString();
        private static string baseUrl = ConfigurationManager.AppSettings["JompayPageUrl"];
        //private static string baseUrl = "https://sit.jompay.com.my/";
        private static string simulatorUrl = "https://simulator.jompay.com.my/sit/";
        private static IWebDriver webDriver = new ChromeDriver();
        
        public static void Initialize()
        {
            Goto("");
        }

        public static string Title
        {
            get { return webDriver.Title; }
        }

        public static ISearchContext Driver
        {
            get { return webDriver; }
        }

        public static void Goto(string url)
        {
            if (url.Equals("simulator"))
            {
                webDriver.Url = simulatorUrl;
            }
            else
	        {
                webDriver.Url = baseUrl + url;
	        }
            
        }

        public static void Close()
        {
            webDriver.Close();
        }
    }
}