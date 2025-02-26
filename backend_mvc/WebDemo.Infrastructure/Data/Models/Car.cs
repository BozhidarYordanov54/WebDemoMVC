using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.Identity.Client;
using WebDemo.Infrastructure.Data.Enums;

namespace WebDemo.Infrastructure.Data.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
        public int Odometer { get; set; }
        public bool IsUsed { get; set; }
        public bool IsLeftHandDrive { get; set; }
        public bool IsAutomatic { get; set; }
        public bool IsAWD { get; set; }
        public Color Color { get; set; }
        public CarType Type { get; set; }
        public string Descirption { get; set; } = string.Empty;

        public int MakeId { get; set; }
        [ForeignKey(nameof(MakeId))]
        public Make Make { get; set; } = null!;

        public int ModelId { get; set; }
        [ForeignKey(nameof(ModelId))]
        public Model Model { get; set; } = null!;

        public string OwnerId { get; set; } = string.Empty;
        [ForeignKey(nameof(OwnerId))]
        public IdentityUser Owner { get; set; } = null!;

        public int EngineId { get; set; }
        [ForeignKey(nameof(EngineId))]
        public Engine Engine { get; set; } = null!;
    }
}