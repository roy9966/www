using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ruanj1801.Filters
{
    public class ActionResultExceptionFilterAttribute : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            filterContext.ExceptionHandled = true;
            if (filterContext.Exception is UnauthorizedException)
            {
                filterContext.Result = new RedirectResult("/Account/login");
            }
        }
    }
}