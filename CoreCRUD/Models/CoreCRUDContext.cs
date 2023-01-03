using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace CoreCRUD.Models
{
    public class CoreCRUDContext :DbContext
    {
        public CoreCRUDContext(DbContextOptions<CoreCRUDContext>options): base(options)
        {

        }
        public DbSet<Student> Students { get; set; }//Student tablosu
        public DbSet<Teacher> Teachers { get; set; }//Teacher tablosu

    }
}
