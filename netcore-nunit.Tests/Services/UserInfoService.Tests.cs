using netcore_nunit.Models;
using netcore_nunit.Repositories;
using NSubstitute;
using NUnit.Framework;
using netcore_nunit.Services;
using netcore_nunit.common;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq.Expressions;
using System;

namespace netcore_nunit.Tests.Services
{
    class UserInfoServiceTests
    {
        private IRepository<UserInfoModel, int> _fakeRepository;
        private IUserInfoService _target;

        [SetUp]
        public void SetUp()
        {
            _fakeRepository = Substitute.For<IRepository<UserInfoModel, int>>();
            _target = new UserInfoService(_fakeRepository);
        }
        [Test]
        public void CreateUserInfo()
        {
            // Arrange
            var obj = new UserInfoModel();
            _fakeRepository.Create(obj).Returns(1);

            // Act
            var result = _target.CreateUserInfo(obj);
            // Assert
            Assert.IsTrue(result.IsSuccess);
        }
        [Test]
        public void UpdateUserInfo()
        {
            // Arrange
            var obj = new UserInfoModel();
            _fakeRepository.Update(obj);

            // Act
            var result = _target.UpdateUserInfo(obj);
            // Assert
            Assert.IsTrue(result.IsSuccess);
        }
        [Test]
        public void FindUserInfoById()
        {
            // Arrange
            var obj = new UserInfoModel { Id = 1 };
            _fakeRepository.FindById(Arg.Any<int>()).Returns(obj);

            // Act
            var result = _target.FindUserInfoById(1);
            // Assert
            Assert.AreEqual(obj, result.Data);
        }
        [Test]
        public void GetAllUser()
        {
            // Arrange
            var obj = new UserInfoModel { Id = 1 };
            _fakeRepository.Find(Arg.Any<Expression<Func<UserInfoModel, bool>>>())
                .Returns(new List<UserInfoModel> { obj });

            // Act
            var result = _target.GetAllUser();
            // Assert
            Assert.IsTrue(result.IsSuccess);
        }

    }
}
