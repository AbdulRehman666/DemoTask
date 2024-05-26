using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace TaskManagerAPI.Models
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options) : base(options) { }
        public DbSet<UserTasks> Tasks { get; set; }
    }
}
