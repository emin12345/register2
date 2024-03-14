using frontback.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;

namespace frontback.Contexts;

public class PronioDbContext : DbContext
{


    public PronioDbContext(DbContextOptions<PronioDbContext> options) : base(options)
    {

 }


    public DbSet<Slider> Sliders { get; set; } = null!;
    public DbSet<Shipping> Shippings { get; set; } = null!;


}
