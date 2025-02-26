using System.ComponentModel.DataAnnotations.Schema;

namespace WebDemo.Infrastructure.Data.Models
{
    public class Make
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string CountryId { get; set; } = string.Empty;
        [ForeignKey(nameof(CountryId))]
        public Country Country { get; set; } = null!;

        public List<Model> Models { get; set; } = new List<Model>();
    }
}