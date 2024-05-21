int[] first = Console.ReadLine().Split("-").Select(int.Parse).ToArray();
int[] second = Console.ReadLine().Split("-").Select(int.Parse).ToArray();

var firstDate = new DateTime(first[2], first[1], first[0]);
var secondDate = new DateTime(second[2], second[1], second[0]);

if (firstDate.DayOfWeek == secondDate.DayOfWeek)
{
    Console.WriteLine("Yes");
    Console.WriteLine(firstDate.DayOfWeek);
}
else
{
    Console.WriteLine("No");
}
