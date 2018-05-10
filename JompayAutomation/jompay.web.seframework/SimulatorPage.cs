using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace jompay.web.seframework
{
    public class SimulatorPage 
    {

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div[2]/div/div[3]/button")]
        private IWebElement TestBank3;

        [FindsBy(How = How.XPath, Using = "//*[@id='accounttype']/option[2]")]
        private IWebElement ddlAccountType;

        [FindsBy(How = How.XPath, Using ="//*[@id='billercode']")]
        private IWebElement txtBillerCode;

        [FindsBy(How = How.XPath, Using ="//*[@id='RRN']")]
        private IWebElement txtRRN;

        [FindsBy(How = How.XPath, Using = "//*[@id='amount']")]
        private IWebElement txtAmount;

        [FindsBy(How = How.XPath, Using = "//*[@id='validate-payment-btn']")]
        private IWebElement btnValidatePayment;

        [FindsBy(How = How.XPath, Using = "//*[@id='selectionTab']/li[2]/a")]
        private IWebElement linkNotifyCompletion;

        [FindsBy(How = How.XPath, Using = "//*[@id='bvmSuccess']")]
        private IWebElement divMessageVP;

        [FindsBy(How = How.XPath, Using = "//*[@id='sErrorCode']")]
        private IWebElement divMessageErrorCode;
                
        [FindsBy(How = How.XPath, Using = "//*[@id='notifySuccess']")]
        private IWebElement divMessageNC;        

        [FindsBy(How = How.XPath, Using = "//*[@id='notify-completion-btn']")]
        private IWebElement btnNotifyCompletion;
                

        public void GoTo()
        {
            Browser.Goto("simulator"); 
        }
                               
        public string PerformValidatePaymentSucess(string billerCode , string ref1 , string amount)
        {
            TestBank3.Click();
            ddlAccountType.Click();
            txtBillerCode.SendKeys(billerCode);
            txtRRN.SendKeys(ref1);
            txtAmount.SendKeys(amount);
            btnValidatePayment.Click();
            return divMessageVP.Text;
         }

        public string PerformValidatePaymentFail(string billerCode, string ref1, string amount, string errorCode)
        {
            TestBank3.Click();
            ddlAccountType.Click();
            txtBillerCode.SendKeys(billerCode);
            txtRRN.SendKeys(ref1);
            txtAmount.SendKeys(amount);
            btnValidatePayment.Click();
            PerformErrorCodeAction(errorCode);
            return divMessageErrorCode.Text;
        }

        public void PerformErrorCodeAction(string errorcode)         
        {
            switch (errorcode)
            {
                case "20001":
                    //Console.WriteLine("LETTUCE");
                    break;
                case "20002":
                    //Console.WriteLine("SQUASH");
                    break;
                case "20003":
                    //Console.WriteLine("TURNIP");
                    break;
                default:
                    break;
            }
        }

        public void PerformNotifyCompletion() 
        {
            linkNotifyCompletion.Click();
        }

        public string ClickNotifyCompletionButton()
        {
            linkNotifyCompletion.Click();
            btnNotifyCompletion.Click();
            return divMessageNC.Text;
        }

         public void CloseBrower()
         {
             Browser.Close();
         }

    }
}
