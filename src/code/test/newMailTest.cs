using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ProyectoModulo2.src.code.page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoModulo2.src.code.session;

namespace ProyectoModulo2.src.code.test
{
    [TestClass]
    public class newMailTest : testBase
    {
        mainPage mainPage = new mainPage();
        secondPage secondPage = new secondPage();
        inboxPage inboxPage = new inboxPage();
        FrameSection frameSection = new FrameSection();
        FrameIboxSection frameIboxSection = new FrameIboxSection();

        [TestMethod]
        public void VerifyTheCreationSuccessfully()
        {
            mainPage.newMailButton.Click();
            secondPage.checkMail.Click();

            Thread.Sleep(2000);

            inboxPage.createMail.Click();

            Assert.IsTrue(inboxPage.createMail.IsControlDisplayed(),
                "ERROR !! the creation was not successfully, review your conection please");

            Thread.Sleep(3000);
            Session.Instance().switchToFrame("ifmail");

            string r = frameIboxSection.remitente.getText();

            frameSection.destinatario.SetText(r);
            frameSection.asunto.Click();
            frameSection.asunto.SetText("Saludos");
            frameSection.content.Click();
            frameSection.content.SetText("Hola");
            frameSection.send.Click();

            Thread.Sleep(3000);
            Session.Instance().switchToMainFrame();

            inboxPage.refresh.Click();

            Assert.IsTrue(inboxPage.refresh.IsControlDisplayed(),
                "ERROR !! the mail was not successfully, review your please");
        }
    }
}
