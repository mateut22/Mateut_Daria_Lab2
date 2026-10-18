using Microsoft.EntityFrameworkCore;

public class Mateut_Daria_Lab2Context(DbContextOptions<Mateut_Daria_Lab2Context> options) : DbContext(options)
{
    public DbSet<Mateut_Daria_Lab2.Models.Book> Book { get; set; } = default!;
    public DbSet<Mateut_Daria_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    public DbSet<Mateut_Daria_Lab2.Models.Authors> Authors { get; set; } = default!;
}
