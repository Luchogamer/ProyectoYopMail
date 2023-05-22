using ProyectoModulo2.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ProyectoModulo2.src.code.session;

namespace ProyectoModulo2.src.code.page
{
    
	public class FrameSection 
       
	{
        public TextBox destinatario = new TextBox(By.Id("msgto"));
        public TextBox asunto = new TextBox(By.Id("msgsubject"));
        public TextBox content = new TextBox(By.Id("msgbody"));
        public Button send = new Button(By.Id("msgsend"));
    }
}

