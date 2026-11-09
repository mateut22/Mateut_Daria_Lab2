using Mateut_Daria_Lab2.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class Mateut_Daria_Lab2Context(DbContextOptions<Mateut_Daria_Lab2Context> options) : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Mateut_Daria_Lab2.Models.Book> Book { get; set; } = default!;
    public DbSet<Mateut_Daria_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    public DbSet<Mateut_Daria_Lab2.Models.Authors> Authors { get; set; } = default!;
    public DbSet<Mateut_Daria_Lab2.Models.Category> Category { get; set; } = default!;
    public DbSet<Mateut_Daria_Lab2.Models.Member> Member { get; set; } = default!;
    public DbSet<Mateut_Daria_Lab2.Models.Borrowing> Borrowing { get; set; } = default!;
}
