using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAutomationSimpleSkeleton.WindowElements
{
    public class FirstWindow : Base
    {
        readonly string Icona = "File";
        public void WriteSomethingInNotepad()
        {
            ClickOnElementByName(Icona);
            System.Threading.Thread.Sleep(13000);
        }
    }
}
