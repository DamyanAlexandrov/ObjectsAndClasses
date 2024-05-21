List<int> input = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

int l = input.Count;

Random rnd = new Random();

for (int i = 0; i < l; i++)
{
    int randomized = rnd.Next(input.Count);
    Console.WriteLine(input[randomized]);
    input.RemoveAt(randomized);
}
