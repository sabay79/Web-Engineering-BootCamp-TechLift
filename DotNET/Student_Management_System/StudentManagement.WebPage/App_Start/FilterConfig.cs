﻿using System.Web;
using System.Web.Mvc;

namespace StudentManagement.WebPage
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
