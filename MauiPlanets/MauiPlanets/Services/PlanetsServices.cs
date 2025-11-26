using MauiPlanets.Models;


namespace MauiPlanets.Services
{
    internal class PlanetsServices
    {
        private static List<Planet> planets = new()
        {
            new()
            {
                Name = "Mercury",
                Subtitle = "The smallest planet",
                HeroImage = "mercury.png",
                Description = "Mercury is the first planet from the Sun and the smallest " +
                "in the Solar System. In English, it is named after the ancient Roman god " +
                "Mercurius (Mercury), god of commerce and communication, and the messenger " +
                "of the gods. Mercury is classified as a terrestrial planet, with roughly " +
                "the same surface gravity as Mars. The surface of Mercury is heavily " +
                "cratered, as a result of countless impact events that have accumulated " +
                "over billions of years.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://external-preview.redd.it/Pl5aSNxMB5u_M_fBRI0XKCAG8t3j1tWNf0N6hE5iJ0s.jpg?width=1080&crop=smart&auto=webp&s=f6c375e3baa9d092b363494180238c9483f28cdb",
                    "https://www.suse.com/c/wp-content/uploads/2023/07/Mercury_JeffR-1024x576.jpg",
                    "https://ichef.bbci.co.uk/ace/standard/976/cpsprodpb/115C8/production/_88621117_88621116.jpg.webp"
                }
            }
        };

        public static List<Planet> GetFeaturedPlanets()
        {
            var random = new Random();
            var randomizePlanets = planets
                .OrderBy(item => random.Next());

            return randomizePlanets
                .Take(2)
                .ToList();
        }

        public static List<Planet> GetAllPlanets()
            => planets;
    }
}
