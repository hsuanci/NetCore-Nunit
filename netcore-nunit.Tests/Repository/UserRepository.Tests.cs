//using EntityFrameworkCore.Testing.NSubstitute;
//using Microsoft.EntityFrameworkCore;
//using netcore_nunit.common;
//using netcore_nunit.Models;
//using NSubstitute;
//using NUnit.Framework;

//namespace netcore_nunit.Tests.Repository
//{
//    class UserRepository
//    {
//        private DbSet<UserInfoModel> _fakedbuserInfo;
//        [SetUp]
//        public void SetUp()
//        {
//            _fakedbuserInfo = Substitute.For<DbSet<UserInfoModel>>();
//        }
//        [Test]
//        public void Created()
//        {
//            var model = Substitute.For<UserInfoModel>();
//            var mockedDbContext = Create.MockedDbContextFor<TempDBContext>();
//            //Act 
//            _fakedbuserInfo.Add(model);
//            var mockContext = Substitute.For<TempDBContext>();
//            mockContext.SaveChanges();
//            //Assert 
//            Assert.AreEqual(1, 1);

//        }
//    }
//}
