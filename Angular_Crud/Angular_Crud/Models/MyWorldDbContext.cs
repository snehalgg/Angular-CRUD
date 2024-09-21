
using Angular_Crud.Models;
using Microsoft.EntityFrameworkCore;



namespace Angular_Crud.Models
{
    public class MyWorldDbContext : DbContext
    {
        public MyWorldDbContext(DbContextOptions<MyWorldDbContext> options) : base(options)
        {



        }
        public DbSet<Angular_Crud.Models.Student> Student { get; set; }
    }
}