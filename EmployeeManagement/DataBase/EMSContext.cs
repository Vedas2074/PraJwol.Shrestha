using Microsoft.EntityFrameworkCore;
namespace EmployeeManagement.DataBase
{
public class EMSContext : DbContext
{
     public EMSContext()
     {
         
     }
    public EMSContext(DbContextOptions<EMSContext> options) : base(options)
    {
        
    }

    public DbSet<Employee> People { get; set; }
  

}
}