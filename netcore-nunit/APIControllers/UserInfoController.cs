using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using netcore_nunit.Models;
using netcore_nunit.Services;

namespace netcore_nunit.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserInfoController : ControllerBase
    {
        private readonly IUserInfoService _service;
        public UserInfoController(IUserInfoService service)
        {
            _service = service;
        }

        public IActionResult FindUserById(int id)
        {
            return Ok(_service.FindUserInfoById(id));
        }
        public IActionResult GetAllUser()
        {
            return Ok(_service.GetAllUser());
        }
        public IActionResult CreateUserInfo(UserInfoModel userInfoModel)
        {
            return Ok(_service.CreateUserInfo(userInfoModel));
        }
    }
}
