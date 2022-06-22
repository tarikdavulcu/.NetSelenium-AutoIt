using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using AutoIt;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutoIt
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IWebDriver driver = new ChromeDriver(@"c:\driver");
            driver.Navigate().GoToUrl("https://tarikdavulcu.com/Tarik/Login");
            Thread.Sleep(5000);
            driver.FindElement(By.Name("email")).SendKeys("admin");
            driver.FindElement(By.Name("password")).SendKeys("20342034");
            driver.FindElement(By.Id("login")).Click();
            Thread.Sleep(5000);

            AutoItX.Run("notepad.exe", @"C:\Windows\System32");
            AutoItX.WinWaitActive("Untitled");
            AutoItX.Send("I'm in notepad");
            IntPtr winHandle = AutoItX.WinGetHandle("Untitled");
            AutoItX.WinKill(winHandle);
        }
    }
}
