using ProyectoModulo2.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ProyectoModulo2.src.code.page
{
	public class secondPage
	{
		public Button checkMail = new Button(By.XPath("//span[contains(.,('Revisa el correo'))]"));

	}
}