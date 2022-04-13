

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace VulcanForged.CMS.Admin.Helper.AF
{
    public class App_Authorized_Filter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            // Do something before the action executes.

            #region Get Session

            string VeriAti_Admin_AccountID = context.HttpContext.Session.GetString("VeriAti_Admin_AccountID");

            if (VeriAti_Admin_AccountID != null)
            {
                //Session Exist
            }
            else
            {
                //Session Expired
                context.Result = new RedirectResult("~/Account/Login");
                return;
            }

            #endregion

        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            // Do something after the action executes.

        }
    }
}
