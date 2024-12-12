
string[] snacks = { "sushit", "pitsat", "burgerit", "kanatiibu", "pannkooke", "juustu" };

Random rnd = new Random();

int randomIndex = rnd.Next(0,snacks.Length);

Console.WriteLine($"Täna õhtul me sööme: {snacks[randomIndex]}.");