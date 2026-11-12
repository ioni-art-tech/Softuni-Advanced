int[] tokens = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();
int[] numbers= Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

Queue<int> queue = new Queue<int>(numbers);

for (int i = 0; i < tokens[1]; i++)
{
    if (queue.Count<0)
    {
        break;
    }
    queue.Dequeue();
}

if (queue.Contains(tokens[2]))
{
    Console.WriteLine("true");
}
else if(queue.Any()) //=queue.Count>0
{
    Console.WriteLine(queue.Min());
}
else
{
    Console.WriteLine("0");
}