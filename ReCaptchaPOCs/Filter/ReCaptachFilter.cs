using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReCaptchaPOCs.Filter
{
    public class ReCaptachFilter : ActionFilterAttribute
    {
        //private readonly ReCAPTCHAService _ReCAPTCHAService;
        //public ReCaptachFilter(ReCAPTCHAService ReCAPTCHAService)
        //{
        //    _ReCAPTCHAService = ReCAPTCHAService;
           
        //}
        //public async override void OnActionExecuting(ActionExecutingContext context)
        //{

        //    string cAPTCHAToken = JsonConvert.DeserializeObject<CAPTCHAModel>(JsonConvert.SerializeObject(context?.ActionArguments.Values.FirstOrDefault()))?.ReCAPTCHAToken;

        //    if (!string.IsNullOrEmpty(cAPTCHAToken))
        //    {
        //        var captia = _ReCAPTCHAService.VerifyCAPTCHA(cAPTCHAToken);

        //        if (!captia.Result.success && captia.Result.score <= 0.5)
        //        {
        //            context.Result = new BadRequestObjectResult("Invalid Token!");
        //        }
        //    }

        //}

        //public override void OnActionExecuted(ActionExecutedContext context)
        //{

        //}
    }
}
