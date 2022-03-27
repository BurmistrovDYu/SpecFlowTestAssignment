﻿using SpecFlowTests.PageObjects;

namespace SpecFlowTests.Constants
{
    public static class XPaths
    {
        public static class GoogleMainPage
        {
            public static string InputSearchFieldXPath = "//input[@role='combobox']",
                ButtonGoogleSearchXPath = "//div[contains(@jsaction, 'mouseout')]//input[@name='btnK' and not(ancestor::div[contains(@style, 'display:none')])]";
        }
    }
}