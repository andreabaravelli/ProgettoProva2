using Microsoft.EntityFrameworkCore;
using progettoProva2.Data;

namespace progettoProva2.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
           
            using (var context = new progettoProva2Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<progettoProva2Context>>()))

            {
                if (context.Job.Any())
                {
                    return;
                }
                context.Job.AddRange(
                    new Job
                    {
                        Name = "Job1"
                    },
                    new Job
                    {
                        Name= "Job2"
                    },
                    new Job
                    {
                        Name= "Job3"
                    });

                context.SaveChanges();
            }
        }
    }
}
