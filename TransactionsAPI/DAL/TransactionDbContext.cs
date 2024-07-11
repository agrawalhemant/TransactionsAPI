namespace TransactionsAPI.DAL
{
    public class TransactionDbContext : DbContext
    {
        public TransactionDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<Profile> Profile { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Transaction>()
        //        .HasNoKey();
        //    modelBuilder.Entity<Profile>()
        //        .HasNoKey();
        //    // other configurations if needed

        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
