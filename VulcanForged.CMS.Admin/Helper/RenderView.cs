//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.AspNetCore.Mvc.ViewEngines;
//using Microsoft.AspNetCore.Mvc.ViewFeatures;
//using System.IO;
//using System.Threading.Tasks;

//namespace VulcanForged.CMS.Admin.Helper.Render
//{
//    public static class ControllerExtensions
//    {
//        public static async Task<string> RenderViewAsync<TModel>(this Controller controller, string viewNamePath, TModel model, bool partial = false)
//        {
//            if (string.IsNullOrEmpty(viewNamePath))
//            {
//                viewNamePath = controller.ControllerContext.ActionDescriptor.ActionName;
//            }

//            controller.ViewData.Model = model;

//            using (var writer = new StringWriter())
//            {
//                //IViewEngine viewEngine = controller.HttpContext.RequestServices.GetService(typeof(ICompositeViewEngine)) as ICompositeViewEngine;
//                //ViewEngineResult viewResult = viewEngine.FindView(controller.ControllerContext, viewName, !partial);

//                IViewEngine viewEngine = controller.HttpContext.RequestServices.GetService(typeof(ICompositeViewEngine)) as ICompositeViewEngine;

//                ViewEngineResult viewResult = null;

//                if (viewNamePath.EndsWith(".cshtml"))
//                    viewEngine.GetView()
//                    viewResult = viewEngine.GetView(viewNamePath, viewNamePath, false);
//                else
//                    viewResult = viewEngine.FindView(controller.ControllerContext, viewNamePath, false);

//                if (!viewResult.Success)
//                    return $"A view with the name '{viewNamePath}' could not be found";


//                if (viewResult.Success == false)
//                {
//                    return $"A view with the name {viewNamePath} could not be found";
//                }

//                ViewContext viewContext = new ViewContext(
//                    controller.ControllerContext,
//                    viewResult.View,
//                    controller.ViewData,
//                    controller.TempData,
//                    writer,
//                    new HtmlHelperOptions()
//                );

//                await viewResult.View.RenderAsync(viewContext);

//                return writer.GetStringBuilder().ToString();
//            }
//        }
//    }
//}