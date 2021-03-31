using Business1.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecapProjectWEB.Controllers
{
    public class UserController : ControllerBase
    {
        IUserService _userService;

        public UserController(IUserService ıuserservice)
        {
            _userService = ıuserservice;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _userService.GetAll();

            if (result.Success)
            {
                Ok(result);
            }
            return BadRequest(result);
        }
    }
}
