using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;


namespace TheGardenRoomFlower.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesFlowerContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesFlowerContext>>()))
            {
                // Look for any flowers
                if (context.Flower.Any())
                {
                    return;   // DB has been seeded
                }

                context.Flower.AddRange(
                    new Flower
                    {
                        Name = "Rose",
                        LatinName = "Rosa",
                        Colour = "Red",
                        Price = 10.99M
                    },
                    new Flower
                    {
                        Name = "Carnation",
                        LatinName = "Dianthus",
                        Colour = "Pink",
                        Price = 5.99M
                    },
                    new Flower
                    {
                        Name = "Lily",
                        LatinName = "Lillium",
                        Colour = "White",
                        Price = 8.99M
                    },
                    new Flower
                    {
                        Name = "Sunflower",
                        LatinName = "Helianus",
                        Colour = "Yellow",
                        Price = 15.99M
                    },
                    new Flower
                    {
                        Name = "Orchid",
                        LatinName = "Orchidaceae",
                        Colour = "Lavender",
                        Price = 24.99M
                    }
        

                );
                    
                
                context.SaveChanges();
                
            }
        }
    }
}