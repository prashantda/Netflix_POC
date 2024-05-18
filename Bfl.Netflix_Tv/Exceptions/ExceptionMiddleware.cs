using Bfl.Netflix_Tv.Core.DTO.Shared;
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
                                            response.Message= ex.Message;
                

                context.Response.ContentType = "application/json";
                context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                string stringResponse=JsonConvert.SerializeObject(response);
               await context.Response.WriteAsync(stringResponse);

            }
        }
    }
}
