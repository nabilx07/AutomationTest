using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jompay.web.seframework;
using System.Configuration;

namespace UnitTestAutomation
{
    [TestClass]
    public class LoginTest 
    {
        //[TestMethod]
        //public void Navigate_To_LoginPage()
        //{
        //    var loginText = "Login";
        //    var loginPage = Pages.Login;
        //    loginPage.GoTo();
        //    Assert.AreEqual(loginPage.Name , loginText);
        //    loginPage.CloseBrower();
        //}

        //[TestMethod]
        //public void Login_As_Admin()
        //{
        //    var JompayAdminText = "JomPAY Administration System";
        //    var loginPage = Pages.Login;
        //    loginPage.GoTo();
        //    Extensions.WaitFiveSeconds();
        //    loginPage.PerformLogin();
        //    Assert.AreEqual(loginPage.JomPayAdminSysText(), JompayAdminText);
        //    loginPage.CloseBrower();
            
        //}

        //[TestMethod]
        //public void Register_New_User()
        //{
        //    var BillerRegistration = "The registration form has been saved";
        //    var register = Pages.RegisterPage;
        //    register.GoTo();
        //    register.PerformRegistration();
        //    Assert.AreEqual(register.BillerRegistrationSaved(), BillerRegistration);
        //    register.CloseBrower();
        //}

        //[TestMethod]
        //public void Perform_Validate_Payment()
        //{
        //    var ncMessage = string.Empty;
        //    var ValidatePayment = "Validate Payment Successfully!";
        //    var NotifyCompletion = "Notify Completion Successfully!";            
        //    var simulator = Pages.Simulator;
        //    simulator.GoTo();
        //    string displayMessage = simulator.PerformValidatePaymentSucess("8086", "1234", "1000.00");
        //    if (displayMessage.Contains(ValidatePayment)) 
        //    {
        //       simulator.PerformNotifyCompletion();
        //       ncMessage = simulator.ClickNotifyCompletionButton();
        //    }
        //    Assert.IsTrue(ncMessage.Contains(NotifyCompletion));
        //    simulator.CloseBrower();
        //}

        [TestMethod]
        public void Perform_Validate_Payment_11()
        {
            var ncMessage = string.Empty;
            var txtMessage = "Validate Payment Successfully!";
            var simulator = Pages.Simulator;
            simulator.GoTo();
            string displayMessage = simulator.PerformValidatePaymentSucess("8086","1230","1000.00");
            Assert.IsTrue(displayMessage.Contains(txtMessage));
            simulator.CloseBrower();
        }

        [TestMethod]
        public void Perform_Validate_Payment_12()
        {
            var ncMessage = string.Empty;
            var txtMessage = "20001";
            var simulator = Pages.Simulator;
            simulator.GoTo();
            string displayMessage = simulator.PerformValidatePaymentFail("8711", "1230", "1000.00", txtMessage);
            Assert.IsTrue(displayMessage.Contains(txtMessage));
            simulator.CloseBrower();
        }

        [TestMethod]
        public void Perform_Validate_Payment_13()
        {
            var ncMessage = string.Empty;
            string txtMessage = "20002";
            var simulator = Pages.Simulator;
            simulator.GoTo();
            string displayMessage = simulator.PerformValidatePaymentFail("8011", "1230", "1000.00", txtMessage);
            Assert.IsTrue(displayMessage.Contains(txtMessage));
            simulator.CloseBrower();
        }

        [TestMethod]
        public void Perform_Validate_Payment_14()
        {
            var ncMessage = string.Empty;
            var txtMessage = "20003";
            var simulator = Pages.Simulator;
            simulator.GoTo();
            string displayMessage = simulator.PerformValidatePaymentFail("8029", "1230", "1000.00", txtMessage);
            Assert.IsTrue(displayMessage.Contains(txtMessage));
            simulator.CloseBrower();
        }

        [TestMethod]
        public void Perform_Validate_Payment_15()
        {
            var ncMessage = string.Empty;
            var txtMessage = "20004";
            var simulator = Pages.Simulator;
            simulator.GoTo();
            string displayMessage = simulator.PerformValidatePaymentFail("8086", "1230", "1000.00", txtMessage);
            Assert.IsTrue(displayMessage.Contains(txtMessage));
            simulator.CloseBrower();
        }

        [TestMethod]
        public void Perform_Validate_Payment_16()
        {
            var ncMessage = string.Empty;
            var txtMessage = "20004";
            var simulator = Pages.Simulator;
            simulator.GoTo();
            string displayMessage = simulator.PerformValidatePaymentFail("8086", "1230", "1000.00", txtMessage);
            Assert.IsTrue(displayMessage.Contains(txtMessage));
            simulator.CloseBrower();
        }

        [TestMethod]
        public void Perform_Validate_Payment_17()
        {
            var ncMessage = string.Empty;
            var txtMessage = "20005";
            var simulator = Pages.Simulator;
            simulator.GoTo();
            string displayMessage = simulator.PerformValidatePaymentFail("8086", "1230", "1000.00", txtMessage);
            Assert.IsTrue(displayMessage.Contains(txtMessage));
            simulator.CloseBrower();
        }

        [TestMethod]
        public void Perform_Validate_Payment_18()
        {
            var ncMessage = string.Empty;
            var txtMessage = "20006";
            var simulator = Pages.Simulator;
            simulator.GoTo();
            string displayMessage = simulator.PerformValidatePaymentFail("8086", "1230", "1000.00", txtMessage);
            Assert.IsTrue(displayMessage.Contains(txtMessage));
            simulator.CloseBrower();
        }

        [TestMethod]
        public void Perform_Validate_Payment_19()
        {
            var ncMessage = string.Empty;
            var txtMessage = "20007";
            var simulator = Pages.Simulator;
            simulator.GoTo();
            string displayMessage = simulator.PerformValidatePaymentFail("1230", "1230", "5.00", txtMessage);
            Assert.IsTrue(displayMessage.Contains(txtMessage));
            simulator.CloseBrower();
        }

        [TestMethod]
        public void Perform_Validate_Payment_110()
        {
            var ncMessage = string.Empty;
            var txtMessage = "20008";
            var simulator = Pages.Simulator;
            simulator.GoTo();
            string displayMessage = simulator.PerformValidatePaymentFail("1230", "1230", "8000.00", txtMessage);
            Assert.IsTrue(displayMessage.Contains(txtMessage));
            simulator.CloseBrower();
        }

        [TestMethod]
        public void Perform_Validate_Payment_111()
        {
            var ncMessage = string.Empty;
            var txtMessage = "20009";
            var simulator = Pages.Simulator;
            simulator.GoTo();
            string displayMessage = simulator.PerformValidatePaymentFail("1230", "1230", "8000.00", txtMessage);
            Assert.IsTrue(displayMessage.Contains(txtMessage));
            simulator.CloseBrower();
        }

        [TestMethod]
        public void Perform_Validate_Payment_112()
        {
            var ncMessage = string.Empty;
            var txtMessage = "20009";
            var simulator = Pages.Simulator;
            simulator.GoTo();
            string displayMessage = simulator.PerformValidatePaymentFail("8037", "1230", "100.00", txtMessage);
            Assert.IsTrue(displayMessage.Contains(txtMessage));
            simulator.CloseBrower();
        }
    }
}
