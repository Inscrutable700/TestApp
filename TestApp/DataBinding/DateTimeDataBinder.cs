using System;
using System.Globalization;
using System.Threading;
using System.Web.Mvc;

namespace TestApp.DataBinding
{
    public class DateTimeDataBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var value = bindingContext.ValueProvider.GetValue(bindingContext.ModelName);

            return value.ConvertTo(typeof(DateTime), Thread.CurrentThread.CurrentCulture);
        }
    }
}