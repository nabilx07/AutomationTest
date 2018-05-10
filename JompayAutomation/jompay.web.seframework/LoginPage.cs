using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace jompay.web.seframework
{
    public class LoginPage 
    {
        
        private string userName = "superadmin";
        private string password = "Pa$$w0rd";

        [FindsBy(How = How.XPath, Using = "//*[@id='txtusername']")]
        private IWebElement txtusername;

        [FindsBy(How = How.XPath, Using = "//*[@id='txtpassword']")]
        private IWebElement txtpassword;

        [FindsBy(How = How.XPath, Using ="//*[@id='ContentPlaceHolder1_btnLogin']")]
        private IWebElement btnLogin;

        [FindsBy(How = How.XPath, Using ="//*[@id='form1']/div[3]/div/div/div[1]/b")]
        private IWebElement loginH1;

        [FindsBy(How = How.XPath, Using = "//*[@id='form1']/div[3]/h1")]
        private IWebElement txtjompayAdminSys;
                

        public void GoTo()
        {
            Browser.Goto("login.aspx");
        }

        
        public string Name
        {
            get
            {
                var title = loginH1.Text;
                if (title != null)
                    return title;
                return String.Empty;
            }
        }

        
        public void PerformLogin()
        {
            txtusername.SendKeys(userName);

            txtpassword.SendKeys(password);

            btnLogin.Click();
            
         }

        public string JomPayAdminSysText()
        {
            return txtjompayAdminSys.Text ?? string.Empty;
        }

        public void CloseBrower()
        {
            Browser.Close();
        }

    }
}
