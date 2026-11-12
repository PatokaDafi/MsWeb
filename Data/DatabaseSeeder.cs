using AlvionStudios.Models;

namespace AlvionStudios.Data;

public static class DatabaseSeeder
{
    public static void Seed(ApplicationDbContext context)
    {
        // Only add starter projects when the table is empty.
        if (context.Projects.Any())
        {
            return;
        }

        context.Projects.AddRange(
            new PortfolioProject
            {
                Id = 1,
                Title = "Sculpted by Time",
                Category = "Nature",
                CoverImagePath = "~/images/portfolio/sandstone.JPG",
                CoverImageAlt =
                    "Curving orange sandstone canyon walls framing a narrow opening of blue sky."
            },
            new PortfolioProject
            {
                Id = 2,
                Title = "Above the Quiet",
                Category = "Nature",
                CoverImagePath = "~/images/portfolio/mountain.jpg",
                CoverImageAlt =
                    "A white radar dome on a rocky mountain ridge above red and green vegetation."
            },
            new PortfolioProject
            {
                Id = 3,
                Title = "Wall Street",
                Category = "Travel",
                CoverImagePath = "~/images/portfolio/wall-street.jpg",
                CoverImageAlt =
                    "An American flag and Wall Street sign outside the columned entrance of the New York Stock Exchange."
            }
        );

        context.SaveChanges();
    }
}