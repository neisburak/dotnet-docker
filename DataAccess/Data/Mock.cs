using Entities;

namespace DataAccess.Data;

public class Mock
{
    public static List<Category> Data()
    {
        return new List<Category>()
        {
            new()
            {
                Id = 1,
                Name = "Books",
                Products = new List<Product>()
                {
                    new()
                    {
                        Id = 1,
                        Name = "It ends with us",
                        Price = 19.99m,
                        Stock = 100,
                        Features = new List<ProductFeature>()
                        {
                            new() { Id = 1, Key = "Paperback", Value = "322" }
                        }
                    },
                    new()
                    {
                        Id = 2,
                        Name = "The outsiders",
                        Price = 15.66m,
                        Stock = 96,
                        Features = new List<ProductFeature>()
                        {
                            new() { Id = 1, Key = "Paperback", Value = "166" }
                        }
                    }
                }
            }
        };
    }
}