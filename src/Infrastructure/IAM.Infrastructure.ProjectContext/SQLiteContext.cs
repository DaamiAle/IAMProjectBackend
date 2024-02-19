using IAM.Domain.Entity.Model;
using Microsoft.EntityFrameworkCore;

namespace IAM.Infrastructure.ProjectContext;

public class SQLiteContext : DbContext
{
    public SQLiteContext(DbContextOptions<SQLiteContext> options) : base(options) { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // la ruta relativa a C:\Users\Damian Bruque\source\repos\IAMProjectBackend\database.db
        string databasePath = "Data Source=../../../assets/database.db";
        //string databasePath = "Data Source=assets/database.db";
        optionsBuilder.UseSqlite(databasePath);


        base.OnConfiguring(optionsBuilder);
    }

    // DbSets

    public DbSet<UserEntity> Users { get; set; }
    public DbSet<ProfileEntity> Roles { get; set; }
}

