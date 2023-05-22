using ProyectoModulo2.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ProyectoModulo2.src.code.page
{
	public class FrameIboxSection
	{
		public Label remitente = new Label(By.Id("msgfrom"));
	}
}

