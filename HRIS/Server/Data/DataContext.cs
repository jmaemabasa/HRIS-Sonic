namespace HRIS.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        //Master Data
        public DbSet<DDivisionT> DDivisionT { get; set; }
    }
}
