using System.ComponentModel.DataAnnotations.Schema;

namespace WebDemo.Infrastructure.Data.Models
{
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        
    }
}