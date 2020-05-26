using netcore_nunit.Models;
using netcore_nunit.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcore_nunit.Services
{
    public class UserInfoService : IUserInfoService
    {
        private readonly IRepository<UserInfoModel, int> _repository;
        public UserInfoService(IRepository<UserInfoModel, int> repository)
        {
            _repository = repository;
        }
        public ResultViewModel CreateUserInfo(UserInfoModel userInfoModel)
        {
            var result = new ResultViewModel();
            if (_repository.Create(userInfoModel) == 1)
                result.IsSuccess = true;

            return result;
        }
        public ResultViewModel UpdateUserInfo(UserInfoModel userInfoModel)
        {
            var result = new ResultViewModel();
            try
            {
                _repository.Update(userInfoModel);
                result.IsSuccess = true;
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.IsSuccess = false;
            }

            return result;
        }
        public void Delete(int id)
        {
            _repository.Delete(id);
        }
        public ResultViewModel FindUserInfoById(int id)
        {
            var result = new ResultViewModel();
            if (_repository.FindById(id) != null)
            {
                result.Data = _repository.FindById(id);
                result.IsSuccess = true;
            }
            return result;
        }
        public ResultViewModel GetAllUser()
        {
            var result = new ResultViewModel();
            var data = _repository.Find(d => d.Id > 0);
            result.IsSuccess = true;
            result.Data = data;

            return result;
        }
    }
}
