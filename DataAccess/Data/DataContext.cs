using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    public DbSet<Category> Categories => Set<Category>();
    public DbSet<Product> Products => Set<Product>();
    public DbSet<ProductFeature> ProductFeatures => Set<ProductFeature>();
}