using Microsoft.EntityFrameworkCore;
using MoviesDatabase.Data;

namespace MoviesDatabase.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ScriptureJournalContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ScriptureJournalContext>>()))
            {
                // Look for any movies.
                if (context.Scriptured.Any())
                {
                    return;   // DB has been seeded
                }

                context.Scriptured.AddRange(
                    new Scriptured
                    {
                        Scripture = "will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them",
                        CreationDate= DateTime.Parse("1989-2-12"),
                        Book = "1 Nephi 3:16"
              
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
