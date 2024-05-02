using System.Text.Json.Serialization;

namespace DemoExam.Domain.Models;

public class Supplier
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    [JsonIgnore]
    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
