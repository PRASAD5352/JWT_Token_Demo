using JWT_API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWT_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Employee : ControllerBase
    {
        [Authorize]
        [HttpGet]
        [Route("getdata")]
        public string getdata()
        {
            return "Authentication with Jwt";
        }
        [HttpGet]
        [Route("getdetails")]
        public string getdetails()
        {
            return "without authenticate called method";
        }
        [Authorize]
        [HttpPost]
        [Route("adduser")]
        public string adduser(Users user)
        {
            return $"User Added with username : {user.Username}";
        }
    }
}
