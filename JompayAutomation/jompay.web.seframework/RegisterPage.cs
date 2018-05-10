using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace jompay.web.seframework
{
    public class RegisterPage
    {
        public Extensions extensions = new Extensions();

        [FindsBy(How = How.Id, Using = "txtEmail")]
        private IWebElement txtEmail;

        [FindsBy(How = How.Id, Using = "txtregno")]
        private IWebElement txtregno;

        [FindsBy(How = How.Id, Using = "btnproceed")]
        private IWebElement btnproceed;

        [FindsBy(How = How.Id, Using = "txtCompanyName")]
        private IWebElement txtCompanyName;

        [FindsBy(How = How.XPath, Using = "//*[@id='ddlPriSalutation']/option[10]")]
        private IWebElement priSalutation;

        [FindsBy(How = How.Id, Using = "txtPContactName")]
        private IWebElement txtPContactName;

        [FindsBy(How = How.Id, Using = "txtPCNAreaCode")]
        private IWebElement txtPCNAreaCode;

        [FindsBy(How = How.Id, Using = "txtPContactNo")]
        private IWebElement txtPContactNo;

        [FindsBy(How = How.Id, Using = "txtPEmail")]
        private IWebElement txtPEmail;

        [FindsBy(How = How.XPath, Using = "//*[@id='ddlNotification']/option[2]")]
        private IWebElement ddlNotification;

        [FindsBy(How = How.XPath, Using = "//*[@id='ddlBillerbank']/option[2]")]
        private IWebElement ddlBillerbank;

        [FindsBy(How = How.Id, Using = "btnSave")]
        private IWebElement btnSave;

        [FindsBy(How = How.XPath, Using = "//*[@id='group2']/div[1]/h3")]
        private IWebElement billerRegistrationText;
                              

        public void GoTo()
        {
            //Driver.Instance.Navigate().GoToUrl("https://" + "sit.jompay.com.my" + "/reg/start.aspx");
            Browser.Goto("reg/start.aspx");
        }
                     
        
        public void PerformRegistration()
        {
            //2. Enter email
            txtEmail.SendKeys("ahmad.nabil@myclear.org.my");

            //3. Enter registration number
            string generateFakeRegNumber = DateTime.Now.ToString("yyyyMMddhhmmssfffzzz").Substring(10, 6);
            txtregno.SendKeys(generateFakeRegNumber + "-K");

            //4. Need to input image captcha manually
            Extensions.WaitTenSeconds();

            //5. Click Proceed
            btnproceed.Click();

            Extensions.WaitFiveSeconds();

            //6. Enter Company Name
            txtCompanyName.SendKeys("Test Company 001");

            //7. Select salutation
            priSalutation.Click();

            //8. Enter Primary contact no
            txtPContactName.SendKeys("Elon Musk");

            //8. Enter contact no
            txtPCNAreaCode.SendKeys("013");
            txtPContactNo.SendKeys("555555555");

            //9. Enter Primary contact no
            txtPEmail.SendKeys("not.real.elon@mail.com");

            //10. Select Notification - No
            ddlNotification.Click();

            //11. Select Biller Bank
            ddlBillerbank.Click();

            //12. Click save            
            btnSave.Click();

            Extensions.WaitFiveSeconds();
                      
        }

        public string BillerRegistrationSaved() 
        {
            Extensions.WaitFiveSeconds(); 
            return billerRegistrationText.Text;
        }

        public void CloseBrower()
        {
            Browser.Close();
        }

    }
}
