using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoModulo2.src.code.test
{
    [TestClass]
    
	public class testBase
	{

        [TestInitialize]
        public void OpenBrowser()
        {
            session.Session.Instance().GetBrowser().Navigate().GoToUrl("https://yopmail.com/es/");
            
        }

        [TestCleanup]
        public void CloseBrowser()
        {
            Thread.Sleep(2000);
           session.Session.Instance().CloseBrowser();
        }

    }
}

