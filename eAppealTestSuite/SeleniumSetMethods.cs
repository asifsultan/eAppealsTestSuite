﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoItX3Lib;
using System.Threading;

namespace eAppealTestSuite
{
    public static class SeleniumSetMethods
    {
        // Enter Test
        // Extended method for entering text in the control
        public static void EnterText(this IWebElement element,  string value)
        {
            element.SendKeys(value);         
        }
        public static void EnterDate(this IWebElement element, int value)
        {
            new SelectElement(element).SelectByIndex(value);
        }

        // click into a button, checkbox, option etc

        public static void Clicks(this IWebElement element)
        {
            element.Click();
     
        }

        public static void ClearText(this IWebElement element, string value)
        {
            element.Clear();
            element.SendKeys(value);
        }

        public static void Submits(this IWebElement element)
        {
            element.Submit();

        }

        // Selecting a drop down control

        public static void SelectDropDown(this  IWebElement element, int index)
        {
            new SelectElement(element).SelectByIndex(index);

            
        }

        public static string GetElementText(this IWebElement element)
        {
            return element.Text;


        }





        public static void UploadFile(this IWebElement element, string filePath)
        {
            element.Clicks();

            // element = PropertiesCollection.driver.FindElement(By.CssSelector("[id$=trigger-filebutton]"));

            // Sendkey

            // element.SendKeys(filePath);

            //AutoIT for file uploading
            Thread.Sleep(1000);
            AutoItX3 autoIt = new AutoItX3();
            autoIt.WinActivate("Open");

            autoIt.Send(filePath);
            Thread.Sleep(2000);
            autoIt.Send("{ENTER}");

        }

    }
}

