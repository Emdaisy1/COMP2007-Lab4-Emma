﻿using System.Web;
using System.Web.Mvc;

namespace COMP2007_Lab4_Emma
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
