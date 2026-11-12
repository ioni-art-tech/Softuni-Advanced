int[] input = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();
List<int> result = new List<int>();

Queue<int> queue = new Queue<int>(input);

int currnum = 0;
while (queue.Count > 0)
{
    currnum=queue.Dequeue();
    if (currnum%2==0)
    {
        result.Add(currnum);
    }
}

Console.WriteLine(string.Join(", ", result));