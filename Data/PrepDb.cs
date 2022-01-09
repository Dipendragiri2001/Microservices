using PlatformService.Data;
using PlatformService.Models;

namespace PlatfromService.Data
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using(var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
            }
        }

        private static void SeedData(AppDbContext context)
        {
            if(!context.Platforms.Any())
            {
                Console.WriteLine("Seeding Data...");

                context.Platforms.AddRange(
                    new Platform{
                        Name="Dotnet",Publisher="Microsoft",Cost="Free"
                    },
                    new Platform{
                        Name="SQL SERVER",Publisher="Microsoft",Cost="Free"
                    },
                    new Platform{
                        Name="Kubernetes",Publisher="Cloud Native computing foundation",Cost="Free"
                    }
                );
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("We Already have data in database");
            }
        }
    }
}