using netcore_nunit.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Linq;
using System.Threading.Tasks;

namespace netcore_nunit.Services
{
    public interface IUserInfoService
    {
        public ResultViewModel CreateUserInfo(UserInfoModel userInfoModel);
        public ResultViewModel UpdateUserInfo(UserInfoModel userInfoModel);
        public void Delete(int id);
        public ResultViewModel FindUserInfoById(int id);
        public ResultViewModel GetAllUser();

    }
}
