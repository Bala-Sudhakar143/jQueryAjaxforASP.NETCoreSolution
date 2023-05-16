using Microsoft.EntityFrameworkCore;

namespace jQueryAjaxforASP.NETCore.Models
{
    public class TransactionDbContext : DbContext
    {
        public TransactionDbContext(DbContextOptions<TransactionDbContext> options) : base(options)
        { }

        public DbSet<TransactionModel> Transactions { get; set; }
    }
}
