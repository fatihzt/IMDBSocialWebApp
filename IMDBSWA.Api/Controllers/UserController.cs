using IMDBSWA.Business.Abstract;
using IMDBSWA.Business.Request.User;
using IMDBSWA.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IMDBSWA.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        //[HttpPost]
        //public IActionResult Post([FromBody] UserCreateRequest dto)
        //{
        //    User entity = new() { Age = dto.Age };
        //}
    }
}
