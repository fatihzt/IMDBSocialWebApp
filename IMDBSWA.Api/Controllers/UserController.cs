using IMDBSWA.Business.Abstract;
using IMDBSWA.Business.Request.User;
using IMDBSWA.Core.Authentication;
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
        [HttpPost("Register")]
        public IActionResult Register(UserCreateRequest dto)
        {
            UserAuthentication.CreatePasswordHash(dto.Password,out byte[] passwordHash,out byte[] passwordSalt);
            User entity = new() {FirstName=dto.FirstName,SecondName=dto.SecondName,NickName=dto.NickName, Age=dto.Age, Gender=dto.Gender, Mail=dto.Mail, TelNo=dto.TelNo, PasswordHash=passwordHash, PasswordSalt=passwordSalt};
            int result = _userService.Add(entity);
            return Ok(result > 0 ? "Success" : "Error");
        }
        [HttpPost("Login")]
        public IActionResult Login(UserCreateRequest dto)
        {
            User entity = new() { NickName = dto.NickName };
            if (entity.NickName != dto.NickName)
            {
                return BadRequest("User Not Found!");

            }
            return Ok("Success");
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var result=_userService.GetAll();
            return Ok(result);
        }
    }
}
