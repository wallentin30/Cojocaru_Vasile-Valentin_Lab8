using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cojocaru_Vasile_Valentin_Lab8.Models;

namespace Cojocaru_Vasile_Valentin_Lab8.Data
{
    public class Cojocaru_Vasile_Valentin_Lab8Context : DbContext
    {
        public Cojocaru_Vasile_Valentin_Lab8Context (DbContextOptions<Cojocaru_Vasile_Valentin_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Cojocaru_Vasile_Valentin_Lab8.Models.Book> Book { get; set; }

        public DbSet<Cojocaru_Vasile_Valentin_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Cojocaru_Vasile_Valentin_Lab8.Models.Category> Category { get; set; }
    }
}
