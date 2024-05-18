using Azure.Storage.Blobs;
using Azure.Storage.Sas;
using Azure.Storage;
using Bfl.Netflix_Movies.Core.DTO.Accounts;
using Bfl.Netflix_Movies.Core.DTO.FrontEnd;
using Bfl.Netflix_Service1.Core.DTO.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Bfl.Netflix_Movies.Core.ServiceContracts;

namespace Bfl.Netflix_Movies.Controllers
{
    [Route("api/movie/[controller]/[action]")]
    [ApiController]
    [AllowAnonymous]
    public class FrontEndController : ControllerBase
    {
        private readonly IFrontEndService _frontEndService;

        public FrontEndController(IFrontEndService frontEndService)
        {
            _frontEndService = frontEndService;
        }

        [HttpPost]
        public async Task<ActionResult<Response<string>>> SignUp(SignUpRequest request)
        {
            
            return this.ResponseResult(200, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9", "SignUp Successfull");
        }
        [HttpPost]
        public async Task<ActionResult<Response<string>>> SelectPlan(SelectPlanRequest selectedPlanRequest)
        {
            return this.ResponseResult<string>(200, "Plan Selected Successfully", "Success");
        }
        [HttpPost]   
        public async Task<ActionResult<Response<string>>> SignIn(SignUpRequest request)
        {

            return this.ResponseResult(200, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9", "SignUp Successfull");
        }

        [HttpGet]
        public async Task<ActionResult<Response<string>>> GetBlobUrl(string blobName)
        {
            var response=  await _frontEndService.GetBlobUrl(blobName);
            return this.ResponseResult(200, response,"Url fetched Successfully");
        }

    }
}
