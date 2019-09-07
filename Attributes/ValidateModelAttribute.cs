using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Etudiant.Attributes
{

    internal class ValidateModelAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.ModelState.IsValid == false)
            {
                context.Result = new BadRequestObjectResult(
                    context.ModelState.Values
                        .SelectMany(e => e.Errors)
                        .Select(e => e.ErrorMessage));
            }
        }
    }
}
