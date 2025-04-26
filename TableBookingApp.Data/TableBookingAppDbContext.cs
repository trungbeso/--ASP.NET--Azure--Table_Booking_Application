using Microsoft.EntityFrameworkCore;

namespace TableBookingApp.Data
{
    public class TableBookingAppDbContext : DbContext
    {
        public TableBookingAppDbContext(DbContextOptions<TableBookingAppDbContext> options) : base(options) 
        { 
                
        }
    }
}