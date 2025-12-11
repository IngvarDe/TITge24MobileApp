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
                    "https://science.nasa.gov/wp-content/uploads/2023/11/mercury-messenger-globe-pia15162.jpg",
                    "https://science.nasa.gov/wp-content/uploads/2023/09/spectra-mercury.jpg?w=1024",
                    "https://cdn.mos.cms.futurecdn.net/v2/t:0,l:240,cw:1440,ch:1080,q:80,w:1440/w3kqDGBSTqVnNTpd5pajWm.jpg",
                }
            },
            new()
            {
                Name = "Venus",
                Subtitle = "The pressure cooker",
                HeroImage = "venus.png",
                Description ="Venus is the second planet from the Sun. It is a terrestrial " +
                "planet and is the closest in mass and size to its orbital neighbour" +
                " Earth. Venus has by far the densest atmosphere of the terrestrial " +
                "planets, composed mostly of carbon dioxide with a thick, global " +
                "sulfuric acid cloud cover. At the surface it has a mean temperature " +
                "of 737 K (464 °C; 867 °F) and a pressure 92 times that of Earth's " +
                "at sea level.",
                AccentColorStart = Color.FromArgb("#a6393b"),
                AccentColorEnd = Color.FromArgb("#d17f21"),
                Images = new()
                {
                    "https://assets.science.nasa.gov/dynamicimage/assets/science/cds/general/images/2024/03/venus-mariner-10-pia23791-fig2.jpg?w=1096&h=1096&fit=clip&crop=faces%2Cfocalpoint",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/8/85/Venus_globe.jpg/500px-Venus_globe.jpg",
                    "https://ichef.bbci.co.uk/ace/standard/976/cpsprodpb/CEAA/production/_114360925_jaxa-isas-akatsuki-project-team.jpg",
                }
            },
            new()
            {
                Name = "Earth",
                Subtitle = "The cradle of life",
                HeroImage = "earth.png",
                Description = "The Earth is the only planet known where life " +
                "exists. Almost 1.5 million species of animals and plants have been " +
                "discovered so far, and many more have yet to be found. While " +
                "other planets may have small amounts of ice or steam, the Earth " +
                "is 2/3 water. Earth has perfect conditions for a breathable atmosphere. ",
                AccentColorStart = Color.FromArgb("#0e3d68"),
                AccentColorEnd = Color.FromArgb("#2e97c7"),
                Images = new()
                {
                    "https://images-assets.nasa.gov/image/GSFC_20171208_Archive_e002131/GSFC_20171208_Archive_e002131~large.jpg",
                    "https://cdn.mos.cms.futurecdn.net/FaWKMJQnr2PFcYCmEyfiTm-1200-80.jpg",
                    "https://onetreeplanted.org/cdn/shop/articles/planet_earth_sun_7354ba86-5359-4c08-919a-54a7d5aec991_1600x.jpg?v=1745336570",
                }
            },
            new()
            {
                Name = "Mars",
                Subtitle = "The red beauty",
                HeroImage = "mars.png",
                Description = "No planet has sparked the imaginations of humans as much " +
                "as Mars. It may be the reddish color of Mars, or the fact that it can " +
                "often be easily seen in the night sky, that has caused people to wonder " +
                "about this close neighbor of ours. Tales of “Martians” invading Earth " +
                "have been around for well over fifty years. But is it likely that any " +
                "kind of life really does exist on Mars? ",
                AccentColorStart = Color.FromArgb("#a23036"),
                AccentColorEnd = Color.FromArgb("#eb3333"),
                Images = new()
                {
                    "https://researchfdi.com/wp-content/uploads/2021/10/8944_1-PIA24546-1280.jpeg",
                    "https://www.worldatlas.com/r/w1300-q80/upload/bb/c3/32/shutterstock-1041249343.jpg",
                    "https://www.openaccessgovernment.org/wp-content/uploads/2021/04/dreamstime_xxl_121672573-scaled.jpg"
                }
            },
            new()
            {
                Name = "Jupiter",
                Subtitle = "The gas giant",
                HeroImage = "jupiter.png",
                Description = "Jupiter is the fifth planet from the Sun and the " +
                "largest in the Solar System. It is a gas giant with a mass more " +
                "than 2.5 times that of all the other planets in the Solar System " +
                "combined, and slightly less than one-thousandth the mass of the " +
                "Sun. Its diameter is eleven times that of Earth, and a tenth " +
                "that of the Sun. ",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#cd8026"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/11_Full_Jupiter-800.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/10_Jupiter_Io_Juno-800.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/13_PIA24237_Jupiter_Cyclones-800.jpg"
                }
            },
            new()
            {
                Name = "Saturn",
                Subtitle = "The ring planet",
                HeroImage = "saturn.png",
                Description = "Saturn is the sixth planet from the Sun and " +
                            "the second-largest in the Solar System, after " +
                            "Jupiter. It is a gas giant with an average " +
                            "radius of about nine and a half times that " +
                            "of Earth. It has only one-eighth the average " +
                            "density of Earth, but is over 95 times more massive.",
                AccentColorStart = Color.FromArgb("#996237"),
                AccentColorEnd = Color.FromArgb("#c6502f"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/151_saturn_carousel_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/152_saturn_carousel_2.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/155_saturn_carousel_5.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/153_saturn_carousel_3.jpg"
                }
            },
            new()
            {
                Name = "Uranus",
                Subtitle = "The Herschel planet",
                HeroImage = "uranus.png",
                Description = "Uranus is the seventh planet from the Sun. " +
                            "It is named after Greek sky deity Uranus (Caelus), who in " +
                            "Greek mythology is the father of Cronus (Saturn), a grandfather " +
                            "of Zeus (Jupiter) and great-grandfather of Ares (Mars). Uranus " +
                            "has the third-largest planetary radius and fourth-largest " +
                            "planetary mass in the Solar System.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#996237"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/88_carousel_uranus.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/89_uranus_carousel_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/88_carousel_uranus.jpg"
                }
            },
            new()
            {
                Name = "Neptune",
                Subtitle = "The god of the sea",
                HeroImage = "neptune.png",
                Description = "Neptune is the eighth planet from the Sun and " +
                            "the farthest known planet in the Solar System. It is the " +
                            "fourth-largest planet in the Solar System by diameter, the " +
                            "third-most-massive planet, and the densest giant planet. " +
                            "It is 17 times the mass of Earth, and slightly more " +
                            "massive than its near-twin Uranus.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/82_carousel_neptune_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/86_carousel_neptune_5.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/84_neptune_carousel_2.jpg"
                }
            },
            new()
            {
                Name = "Pluto",
                Subtitle = "The dwarf planet",
                HeroImage = "pluto.png",
                Description = "Pluto (minor-planet designation: 134340 Pluto) is a dwarf planet in the Kuiper belt, a ring of bodies beyond the orbit of Neptune. It is the ninth-largest and tenth-most-massive known object to directly orbit the Sun. It is the largest known trans-Neptunian object by volume by a small margin, but is less massive than Eris. Like other Kuiper belt objects, Pluto is made primarily of ice and rock and is much smaller than the inner planets. Pluto has roughly one-sixth the mass of the Moon and one-third of its volume. Originally considered a planet, its status was changed when astronomers adopted a new definition of the word with new criteria.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ef/Pluto_in_True_Color_-_High-Res.jpg/1200px-Pluto_in_True_Color_-_High-Res.jpg",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSlkkUQ4jSYg3rB4JnPO91xFgf1nWh54RPd7A&s",
                    "https://www.eurokidsindia.com/blog/wp-content/uploads/2025/01/Facts-about-pluto-planet-for-kids-870x437.jpg"
                }
            },
            new()
            {
                Name = "Ceres",
                Subtitle = "The inner dwarf",
                HeroImage = "ceres.png",
                Description = "Ceres (minor-planet designation: 1 Ceres) is a dwarf planet in the main asteroid belt between the orbits of Mars and Jupiter. It was the first known asteroid, discovered on 1 January 1801 by Giuseppe Piazzi at Palermo Astronomical Observatory in Sicily, and announced as a new planet. Ceres was later classified as an asteroid and more recently as a dwarf planet, the only one not beyond the orbit of Neptune and the largest that does not have a moon.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQKO99qlqWs_eiytc6BbMAoN8B_kFZ6bDpKfg&s",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRcZq-lIQbKZLn0ygwXemkuPmGhVpeORUaVFg&s",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQg7R7v88cJocMvPqDI1SECFDncdlVQoqqlHQ&s"
                }
            },
            new()
            {
                Name = "Haumea",
                Subtitle = "The flat dwarf",
                HeroImage = "haumea.png",
                Description = "Haumea (minor-planet designation: 136108 Haumea) is a dwarf planet located beyond Neptune's orbit.[25] It was discovered in 2004 by a team headed by Mike Brown of Caltech at the Palomar Observatory, and formally announced in 2005 by a team headed by José Luis Ortiz Moreno at the Sierra Nevada Observatory in Spain, who had discovered it that year in precovery images taken by the team in 2003. From that announcement, it received the provisional designation 2003 EL61.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRzzhiLdOp7Ti9gOsSG8OVkVnvmxEi0zPZapg&s",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9c/Haumea_Rotation.gif/250px-Haumea_Rotation.gif",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR7pRuaxKT940shRmHXVmVuhWhMIo3YgGWqKg&s"
                }
            },
            new()
            {
                Name = "MakeMake",
                Subtitle = "The bright dwarf",
                HeroImage = "makemake.png",
                Description = "Makemake[g] (minor-planet designation: 136472 Makemake) is a dwarf planet in the Kuiper belt, a disk of icy bodies beyond the orbit of Neptune. It is the fourth largest trans-Neptunian object and the largest member of the classical Kuiper belt,[h] having a diameter 60% that of Pluto. It was discovered on March 31, 2005 by American astronomers Michael E. (\"Mike\") Brown, Chad Trujillo, and David Rabinowitz at Palomar Observatory. As one of the largest objects found by this team, the discovery of Makemake contributed to the reclassification of Pluto as a dwarf planet in 2006.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ0Niia49RiA22SffDhwP9bVdvSprCQq-odNA&s",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTSyZQ1EBTto8cy-fkKnNHKTcqm7bGmMt50ZQ&s",
                    "https://cdn.mos.cms.futurecdn.net/v2/t:0,l:420,cw:1080,ch:1080,q:80,w:1080/TAchMPa9r9zS4KWcFUaZLe.jpg"
                }
            },
            new()
            {
                Name = "Eris",
                Subtitle = "The largest dwarf",
                HeroImage = "eris.png",
                Description = "Eris (minor-planet designation: 136199 Eris) is the most massive and second-largest known dwarf planet in the Solar System.[23] It is a trans-Neptunian object (TNO) in the scattered disk and has a high-eccentricity orbit. Eris was discovered in January 2005 by a Palomar Observatory–based team led by Mike Brown and verified later that year. It was named in September 2006 after the Greco–Roman goddess of strife and discord. Eris is the ninth-most massive known object orbiting the Sun and the sixteenth-most massive in the Solar System (counting moons). It is also the largest known object in the Solar System that has not been visited by a spacecraft. Eris has been measured at 2,326 ± 12 kilometres (1,445 ± 7 mi) in diameter;[13] its mass is 0.28% that of the Earth and 27% greater than that of Pluto,[24][25] although Pluto is slightly larger by volume.[26] Both Eris and Pluto have a surface area that is comparable to that of Russia or South America.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRaSL91330iDlgQhUHsppK6pj2jhY2SDN-1qQ&s",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSG6gj2_jvLR_vafhxvRxJMZvvR3EEo1a6Ufg&s",
                    "https://cff2.earth.com/uploads/2024/02/20135637/Eris_icy-dwarf-planet_kuiper-belt_1m-1400x850.jpg"
                }
            },
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
