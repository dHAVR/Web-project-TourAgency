using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CourseProject.Models;

namespace CourseProject.Data
{
    public class CourseProjectContext : DbContext
    {
        public CourseProjectContext (DbContextOptions<CourseProjectContext> options)
            : base(options)
        {
        }

        public DbSet<CourseProject.Models.Tour> Tour { get; set; } = default!;
        public DbSet<CourseProject.Models.User> User { get; set; } = default!;
        public DbSet<CourseProject.Models.Booking> Booking { get; set; } = default!;
        public DbSet<CourseProject.Models.Review> Review { get; set; } = default!;
        public DbSet<CourseProject.Models.Cart> Cart { get; set; } = default!;
        public DbSet<CourseProject.Models.Message> Message { get; set; } = default!;
    }
}
