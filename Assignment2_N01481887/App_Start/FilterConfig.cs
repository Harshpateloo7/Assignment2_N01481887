﻿using System.Web;
using System.Web.Mvc;

namespace Assignment2_N01481887
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
