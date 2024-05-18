using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace Bfl.Netflix_Tv.Core.DTO.Shared
{
    public class Response<T> where T : class
    {
        public StatusCodeResult  Status { get; set; }
        public T Data { get; set; }
        public string Message { get; set; }
    }
    public static class BaseControllerExtension
    {

        public static Response<T> ResponseResult<T>(this ControllerBase controller,int status, T data, string message) where T : class 
        {
            return new Response<T>()
            {
                Status = new StatusCodeResult(status),
                Data = data,
                Message = message
        };
        }
    }

}
