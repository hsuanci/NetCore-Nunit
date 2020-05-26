using Microsoft.EntityFrameworkCore;
using netcore_nunit.Models;
using System.Threading;
using System.Threading.Tasks;

namespace netcore_nunit.common
{
    public interface ITempDBContext
    {
        DbSet<UserInfoModel> userInfoModel { get; set; }
    }
    public class TempDBContext : DbContext, ITempDBContext
    {
        public TempDBContext(DbContextOptions<TempDBContext> options) : base(options)
        {
        }
        public DbSet<UserInfoModel> userInfoModel { get; set; }

    }
}
