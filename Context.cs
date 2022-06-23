using Microsoft.EntityFrameworkCore;
using GreenhavenMgmt.Models;

public class Context : DbContext
{
   public Context() : base(){}
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to sqlite database
        options.UseSqlite(@"Data Source=GreenhavenCemetery.db");
    }
   
   public DbSet<Person>Person {get;set;}
}