using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Selenium;

namespace SeleniumTest
{
    /// <summary>
    /// Summary description for UnitTest1
	/// Example
    /// </summary>
    [TestClass]
    public class SeleniumSearchTest
    {
        private ISelenium selenium;

        [TestInitialize()]
        public void MyTestInitialize() 
        {
            selenium = new DefaultSelenium("localhost", 4441, "*googlechrome", "http://seleniumhq.org/"); // "*iehta" IE -  "*firefoxproxy" FF - *googlechrome
            selenium.Start();
            selenium.WindowMaximize();
        }

        [TestCleanup()]
        public void MyTestCleanup()
        {
            selenium.Stop();
        }

        [TestMethod]
        public void TestSeleniumSearch1()
        {
            SeleniumPage("Get started with Selenium!");
        }

        [TestMethod]
        public void TestSeleniumSearch2()
        {
            SeleniumPage("Watch: see the magic");
        }

        private void SeleniumPage(string keyword)
        {
            selenium.Open("http://seleniumhq.org/");
            Assert.IsTrue(selenium.IsTextPresent(keyword));
        }
    }
}
