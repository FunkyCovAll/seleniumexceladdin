﻿// Copyright (c) 2014 Takashi Yoshizawa

using System;
using System.Collections.Generic;
using OpenQA.Selenium.Support.UI;

namespace SeleniumExcelAddIn.TestCommands
{
    public class RefreshCommand : ITestCommand
    {
        public TestCommandSyntax Syntax
        {
            get
            {
                return TestCommandSyntax.None;
            }
        }

        public bool IsScreenCapture
        {
            get
            {
                return true;
            }
        }

        
        public string Description
        {
            get
            {
                return TestCommandResource.Refresh;
            }
        }

        public string TargetDescription
        {
            get
            {
                return TestCommandResource.Refresh_Target;
            }
        }

        public string ValueDescription
        {
            get
            {
                return TestCommandResource.Refresh_Value;
            }
        }

        public void Execute(ITestContext context)

        {
            if (null == context)
            {
                throw new ArgumentNullException("context");
            }
                ExecuteInternal(context);
        }

        public static void ExecuteInternal(ITestContext context)
        {
            if (null == context)
            {
                throw new ArgumentNullException("context");
            }

            context.Driver.Navigate().Refresh();
        }
    }
}
