﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAppealTestSuite
{
    enum PropertyType
    {
        Id,
        Name,
        LinkTest,
        ClassName,
        CssName
    }
    class PropertiesCollection
    {
        public static IWebDriver driver { get; set; }
        
    }
}
