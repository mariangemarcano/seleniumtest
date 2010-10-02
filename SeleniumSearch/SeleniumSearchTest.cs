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
    /// </summary>
    [TestClass]
    public class SeleniumSearchTest
    {
        private ISelenium selenium;

        [TestInitialize()]
        public void MyTestInitialize() 
        {
            selenium = new DefaultSelenium("localhost", 4441, "*googlechrome", "http://www.google.com.mx/");
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
            GoogleSearch("Selenium Search 1");
        }

        [TestMethod]
        public void TestSeleniumSearch2()
        {
            GoogleSearch("Selenium Search 2");
        }

        private void GoogleSearch(string keyword)
        {
            selenium.Open("http://www.google.com");
            selenium.Type("q", keyword);
        }
    }
}
