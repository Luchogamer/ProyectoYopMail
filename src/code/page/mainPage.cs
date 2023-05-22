using ProyectoModulo2.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ProyectoModulo2.src.code.page
{
	public class mainPage
	{
		public Button newMailButton = new Button(By.XPath("//div[@class='ycol3']/../div//a[@href='email-generator']"));

	}
}