using LoginAppApi.Login;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginAppApi.Controllers
{
    [Route("token")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        [HttpGet]
        public JsonResult Get()
        {
            return new JsonResult(new { Result = "This is a GET response." });
        }
        
        [HttpPost]
        public Token Post(LoginData loginData)
        {
            return new Token()
            {
                AccessToken = "KAlksdoopPoaspdoew"
            };
        }
    }
}
