using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace SeleniumTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestInitialize]
        public void m1()
        {
            Console.WriteLine("intilize method");
        }
        [TestCleanup]
        public void m2()
        {
            Console.WriteLine("intilize method");
        }

        [TestMethod]
        public void TestMethod1()
        {
            //IWebDriver driver = new FirefoxDriver();
            //IWebDriver driver1 = new ChromeDriver(@"G:\\selenium drivers\\chromedriver_win32 (1)");
            Console.WriteLine("mstest");

        }
    }
    
}
