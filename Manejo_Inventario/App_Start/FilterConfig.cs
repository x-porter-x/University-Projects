﻿using System.Web;
using System.Web.Mvc;

namespace Manejo_Inventario
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
