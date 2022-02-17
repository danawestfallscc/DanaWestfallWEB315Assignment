using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TheGardenRoomFlower.Models;

    public class RazorPagesFlowerContext : DbContext
    {
        public RazorPagesFlowerContext (DbContextOptions<RazorPagesFlowerContext> options)
            : base(options)
        {
        }

        public DbSet<TheGardenRoomFlower.Models.Flower> Flower { get; set; }
    }
