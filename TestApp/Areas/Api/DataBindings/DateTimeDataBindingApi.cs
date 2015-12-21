using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.ModelBinding;

namespace TestApp.Areas.Api.DataBindings
{
    public class DateTimeDataBindinApi : IModelBinder
    {
        public bool BindModel(ModelBindingExecutionContext modelBindingExecutionContext, ModelBindingContext bindingContext)
        {
            var value = bindingContext.ValueProvider.GetValue(bindingContext.ModelName);
            bindingContext.Model = value.ConvertTo(typeof(DateTime), Thread.CurrentThread.CurrentCulture);
            return true;
        }
    }
}