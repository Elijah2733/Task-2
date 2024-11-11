using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Task_2.Models;

namespace Task_2.Data
{
    public class Task_2Context : DbContext
    {
        public Task_2Context (DbContextOptions<Task_2Context> options)
            : base(options)
        {
        }

        public DbSet<Task_2.Models.Project> Project { get; set; } = default!;
    }
}
