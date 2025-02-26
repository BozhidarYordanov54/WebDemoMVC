using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace WebDemo.Infrastructure.Data.Models
{
    public class Country
    {
        [Key]
        [Comment("ISO Country code")]
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
    }
}