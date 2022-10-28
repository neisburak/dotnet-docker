using Entities.Abstract;

namespace Entities;

public class Product : IEntity
{
    public int Id { get; set; }
    public int CategoryId { get; set; }
    public string Name { get; set; } = default!;
    public decimal Price { get; set; }
    public int Stock { get; set; }

    public virtual Category Category { get; set; } = default!;
    public virtual ICollection<ProductFeature> Features { get; set; } = default!;
}