using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.Identity.Client;
using WebDemo.Infrastructure.Data.Enums;

namespace WebDemo.Infrastructure.Data.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public int Year { get; set; }
        public int Price { get; set; }
        public int Odometer { get; set; }
        public bool IsUsed { get; set; }
        public bool IsLeftHandDrive { get; set; }
        public bool IsAutomatic { get; set; }
        public Color Color { get; set; }
        public CarType Type { get; set; }

        public string OwnerId { get; set; } = string.Empty;
        [ForeignKey(nameof(OwnerId))]
        public IdentityUser Owner { get; set; } = null!;

        public int EngineId { get; set; }
        [ForeignKey(nameof(EngineId))]
        public Engine Engine { get; set; } = null!;


    }
}