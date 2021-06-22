using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Linq;
using System;

namespace InAndOut.ActionFilters
{
    public class ValidationFilterAtribute : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            
            throw new NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            //var param = context.ActionArguments.SingleOrDefault(p => p.Value is IEntity);
            throw new NotImplementedException();
        }
    }
}
