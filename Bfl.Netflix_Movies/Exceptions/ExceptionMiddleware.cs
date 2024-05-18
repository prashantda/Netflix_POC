using Bfl.Netflix_Service1.Core.DTO.Shared;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Bfl.Netflix.Exceptions
{
    public class ExceptionMiddleware  
    {
        private readonly RequestDelegate _next;
        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
       {
            try
            {
                await _next(context);
            }
            catch(Exception ex)
            {
                Response<string> response = new Response<string>();
                response.Status = new StatusCodeResult(500);
                response.Data = "Error has Occured";
                response.Message= ex.Message??"Error occured";
                /*var error=new Error() { Message = ex.Message };             
                error.Type = (ex) switch {
                    ArgumentException  =>"ArgumentException" ,
                    NullReferenceException=> "NullReferenceException",
                   _ => error.Type = "InternalServerError"
                };*/

                context.Response.ContentType = "application/json";
                context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                string stringResponse=JsonConvert.SerializeObject(response);
               await context.Response.WriteAsync(stringResponse);

            }
        }
    }
}
