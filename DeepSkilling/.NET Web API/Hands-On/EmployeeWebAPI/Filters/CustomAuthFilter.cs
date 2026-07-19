using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace EmployeeWebAPI.Filters;

public class CustomAuthFilter : ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        if (!context.HttpContext.Request.Headers.ContainsKey("Authorization"))
        {
            context.Result = new BadRequestObjectResult("Authorization header missing.");
            return;
        }

        var token = context.HttpContext.Request.Headers["Authorization"].ToString();

        if (!token.StartsWith("Bearer "))
        {
            context.Result = new BadRequestObjectResult("Invalid Bearer token.");
            return;
        }

        base.OnActionExecuting(context);
    }
}
