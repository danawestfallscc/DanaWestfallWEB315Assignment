using System;
using System.ComponentModel.DataAnnotations;

namespace TheGardenRoomFlower.Models
{
public class Flower
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }
    public string LatinName { get; set; }
    public string Colour { get; set; }

    [Range(0.01, 9999.99)]
    public decimal Price { get; set; }
}
};