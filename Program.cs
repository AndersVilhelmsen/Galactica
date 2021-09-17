using System;

namespace Galactica
{
    class Program
    {
        static void Main(string[] args)
        {
            Star sun = new Star()
            {
                Id = 1,
                Name = "Sun",
                //Da Position er read-only kan den ikke tilskrives en position gennem et nyt objekt ...
                //position = new SpaceObjects.Position() { X = 1, Y = 2 },

                //Men position kan godt tilskrives direkte når stjernen oprettes 
                position = { X = 0, Y = 0 },
                Type = Startype.YellowDwarf,
                Temperature = 5500
            };
            //Test for at sun.position er read-only
            //sun.position = new SpaceObjects.Position { X = 2, Y = 3 };

            Planet mercury = new Planet()
            {
                Id = 1,
                Name = "Mercury",
                position = { X = 2, Y = 2 },
                Type = Planettype.Terrestial,
                Diameter = 4880000,
                RotationPeriod = 1407,
                RevolutionPeriod = 88
            };

            Planet venus = new Planet()
            {
                Id = 2,
                Name = "Venus",
                position = { X = 0, Y = 0 },
                Type = Planettype.Terrestial,
                Diameter = 6051800,
                RotationPeriod = 5832,
                RevolutionPeriod = 225
            };

            Planet earth = new Planet()
            {
                Id = 3,
                Name = "Earth",
                position = { X = 0, Y = 0 },
                Type = Planettype.Terrestial,
                Diameter = 6371000,
                RotationPeriod = 24,
                RevolutionPeriod = 365
            };
            earth.position = new SpaceObjects.Position { X = 2, Y = 3 };

            Planet mars = new Planet()
            {
                Id = 4,
                Name = "Mars",
                //position = { X = 0, Y = 0 },
                Type = Planettype.Terrestial,
                Diameter = 6371000,
                RotationPeriod = 25,
                RevolutionPeriod = 687
            };

            Planet jupiter = new Planet()
            {
                Id = 5,
                Name = "Jupiter",
                //position = { X = 0, Y = 0 },
                Type = Planettype.Gas_Giant,
                Diameter = 6371000,
                RotationPeriod = 10,
                RevolutionPeriod = 4332
            };

            Planet saturn = new Planet()
            {
                Id = 6,
                Name = "Saturn",
                //position = { X = 0, Y = 0 },
                Type = Planettype.Gas_Giant,
                Diameter = 6371000,
                RotationPeriod = 11,
                RevolutionPeriod = 4332
            };

            Planet uranus = new Planet()
            {
                Id = 7,
                Name = "Uranus",
                position = { X = 0, Y = 0 },
                Type = Planettype.Giant,
                Diameter = 6371000,
                RotationPeriod = 17,
                RevolutionPeriod = 4332
            };

            Planet neptune = new Planet()
            {
                Id = 8,
                Name = "Neptune",
                position = { X = 0, Y = 0 },
                Type = Planettype.Giant,
                Diameter = 6371000,
                RotationPeriod = 16,
                RevolutionPeriod = 4332
            };

            Moon luna = new Moon()
            {
                Id = 1,
                Name = "Luna",
                position = { X = 0, Y = 0 },
                Orbiting = earth
            };

            Moon titan = new Moon()
            {
                Id = 2,
                Name = "Titan",
                position = { X = 0, Y = 0 },
                Orbiting = saturn
            };

            sun.planets.Add(mercury);
            sun.planets.Add(venus);
            sun.planets.Add(earth);
            sun.planets.Add(mars);
            sun.planets.Add(jupiter);
            sun.planets.Add(saturn);
            sun.planets.Add(uranus);
            sun.planets.Add(neptune);
            earth.moons.Add(luna);
            saturn.moons.Add(titan);

            Console.WriteLine($"{sun.Id} {sun.Name} - Type: {sun.Type}, Temp: {sun.Temperature} ");
            foreach (Planet planet in sun.planets)
            {
                Console.WriteLine($"\n\t\t\t{planet.Id}  {planet.Name}\n\t" +
                    $"Type: {planet.Type}, Diameter: {planet.Diameter}, Rotationstid: {planet.RotationPeriod}, Omløbstid: {planet.RevolutionPeriod}\n\t" +
                    $"Position: {planet.position}, Afstand til {sun.Name}: {planet.Distance(sun)}");
                
                foreach (Moon moon in planet.moons)
                {
                    Console.WriteLine($"\t\t{moon.Id}, {moon.Name}, Pos: {moon.position}, Afstand til {planet.Name}: {moon.Distance()}, Afstand til {sun.Name}: {moon.Distance(sun)}");
                }
            }
        }
    }
}
