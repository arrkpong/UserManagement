using Microsoft.EntityFrameworkCore;
using UserManagement.Models;

namespace UserManagement.Data
{
    // คลาส ApplicationDbContext สืบทอดมาจาก DbContext และเป็นตัวแทนของเซสชันกับฐานข้อมูล
    public class ApplicationDbContext : DbContext
    {
        // คอนสตรัคเตอร์ที่รับ DbContextOptions และส่งผ่านไปยังคลาส DbContext ฐาน
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // คุณสมบัติ DbSet ที่เป็นตัวแทนของตาราง Users ในฐานข้อมูล
        public DbSet<User> Users { get; set; }
    }
}
