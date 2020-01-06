//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using OpenQA.Selenium.Appium.Windows;
using NUnit.Framework;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesktopAutomationSimpleSkeleton.Tests
{
    /// <summary>
    /// https://www.youtube.com/watch?v=duC-lxJQeoY
    /// </summary>
    class BaseTests
    {
        // Note: append /wd/hub to the URL if you're directing the test at Appium
        protected const string WindowsApplicationDriverUrl = "http://127.0.0.1:4723/wd/hub";
        protected static WindowsDriver<WindowsElement> ApplicationSession;

        [SetUp]
        public virtual void TestInit()
        {
            if (ApplicationSession == null)
            {
                //launch the Notepad app
                DesiredCapabilities appCapabilities = new DesiredCapabilities();
                appCapabilities.SetCapability("deviceName", "WindowsPC");
                appCapabilities.SetCapability("app", @"C:\Windows\System32\notepad.exe");
                ApplicationSession = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), appCapabilities);
            }
        }

        [TearDown]
        public static void TestDispose()
        {
            if (ApplicationSession != null)
            {
                ApplicationSession.Dispose();
                ApplicationSession = null;
            }
        }
    }
}

