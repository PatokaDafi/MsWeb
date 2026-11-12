using AlvionStudios.Models;
using Microsoft.EntityFrameworkCore;

namespace AlvionStudios.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(
        DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<PortfolioProject> Projects => Set<PortfolioProject>();
}