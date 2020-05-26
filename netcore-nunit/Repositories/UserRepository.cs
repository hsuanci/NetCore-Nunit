using netcore_nunit.common;
using netcore_nunit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace netcore_nunit.Repositories
{
    public class UserRepository : IRepository<UserInfoModel, int>
    {
        private readonly TempDBContext _context;

        public UserRepository(TempDBContext context)
        {
            _context = context;
        }

        public int Create(UserInfoModel entity)
        {
            _context.userInfoModel.Add(entity);
            _context.SaveChanges();
            return entity.Id;
        }

        public void Update(UserInfoModel entity)
        {
            var oriUser = _context.userInfoModel.Single(x => x.Id == entity.Id);
            _context.Entry(oriUser).CurrentValues.SetValues(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context.userInfoModel.Remove(_context.userInfoModel.Single(x => x.Id == id));
            _context.SaveChanges();
        }

        public IEnumerable<UserInfoModel> Find(Expression<Func<UserInfoModel, bool>> expression)
        {
            return _context.userInfoModel.Where(expression);
        }

        public UserInfoModel FindById(int id)
        {
            return _context.userInfoModel.SingleOrDefault(x => x.Id == id);
        }
    }
}
