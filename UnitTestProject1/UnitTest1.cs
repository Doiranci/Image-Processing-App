using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.Factory;

namespace WinFormsAppTests
{
    [TestClass]
    public class MainFormTests
    {
        private Application application;
        private Window mainWindow;

        [TestInitialize]
        public void Setup()
        {
            string applicationPath = @"C:\Path\To\Your\WinFormsApp.exe";
            application = Application.Launch(applicationPath);
            mainWindow = application.GetWindow("MainForm", InitializeOption.NoCache);
        }

        [TestCleanup]
        public void Teardown()
        {
            if (mainWindow != null)
            {
                mainWindow.Close();
            }
            if (application != null)
            {
                application.Dispose();
            }
        }

        [TestMethod]
        public void TestButtonClick()
        {
            var button = mainWindow.Get<Button>(SearchCriteria.ByAutomationId("yourButtonAutomationId"));
            button.Click();
            var label = mainWindow.Get<Label>(SearchCriteria.ByAutomationId("yourLabelAutomationId"));
            Assert.AreEqual("Expected Text", label.Text);
        }
    }
}
