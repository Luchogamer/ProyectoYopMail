using ProyectoModulo2.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ProyectoModulo2.src.code.factoryBrowser;

namespace ProyectoModulo2.src.code.page
{
	public class inboxPage 
	{
        public Button createMail = new Button(By.Id("newmail"));
        public Button refresh = new Button(By.Id("refresh"));

    }
}