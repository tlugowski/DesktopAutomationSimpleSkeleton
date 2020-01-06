using DesktopAutomationSimpleSkeleton.WindowElements;
using NUnit.Framework;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAutomationSimpleSkeleton.Tests
{
    [TestFixture]
    class AlarmClockTests :BaseTests
    {
        /// <summary>
        /// 1. Pobrac https://nodejs.org/en/
        /// 2. ZAinstalowac http://digitalab.org/2017/03/ui-automation-using-appium-winappdriver/#.XhHWyEdKg2w
        /// </summary>

        [Test]
        public void NotepadTests()
        {
            //var ChangeWindow = ApplicationSession.SwitchTo().Window("windowName");

           // ApplicationSession.FindElementByClassName("Scintilla").SendKeys("This is an automated text......");
            //System.Threading.Thread.Sleep(3000);
            FirstWindow fw = new FirstWindow();
            fw.WriteSomethingInNotepad();
           // Assert.IsNotNull(ApplicationSession);
        }
    }
}
