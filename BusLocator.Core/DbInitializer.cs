using BusLocator.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace BusLocator.Core
{
    public class DbInitializer
    {
        public static void InitDb(BusLocatorContext context)
        {
            context.Database.Migrate();

            if (context.Lines.Any())
            {
                Console.WriteLine("Already have data - no need to seed");
                return;
            }

            var lines = new List<Line>
            {
                new Line
                {
                    Number = "6",
                    Name = "Bisce polje - Sjeverni logor",
                    Duration = 45,
                    Price = 1.50m
                },
                new Line
                {
                    Number = "10",
                    Name = "Blagaj - Sjeverni logor",
                    Duration = 70,
                    Price = 2.10m
                },
                new Line
                {
                    Number = "23",
                    Name = "Avenija - Bijelo Polje",
                    Duration = 45,
                    Price = 2.10m
                },
                new Line
                {
                    Number = "90",
                    Name = "Mostar - Međugorje",
                    Duration = 90,
                    Price = 2.80m
                },
            };

            context.AddRange(lines);
            context.SaveChanges();
        }

    }
}
