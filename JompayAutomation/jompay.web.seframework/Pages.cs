using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System;

namespace jompay.web.seframework
{
    public static class Pages
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(Browser.Driver,page);
            return page;
        }

        public static LoginPage Login
        {
            get { return GetPage<LoginPage>(); }
        }

        public static RegisterPage RegisterPage
        {
            get { return GetPage<RegisterPage>(); }
        }

        public static SimulatorPage Simulator
        {
            get { return GetPage<SimulatorPage>(); }
        }
    }
}
