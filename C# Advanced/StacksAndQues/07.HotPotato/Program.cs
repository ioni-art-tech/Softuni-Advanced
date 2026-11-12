string[] children = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .ToArray();

Queue<string> queue = new Queue<string>(children);

int n = int.Parse(Console.ReadLine());

string currChild = string.Empty;
int br = 1;
while (queue.Count>1)
{
    currChild=queue.Dequeue();
    if (br<n)
    {
        queue.Enqueue(currChild);
        br++;
    }
    else
    {
        Console.WriteLine($"Removed {currChild}");
        br = 1;
    }

}
Console.WriteLine($"Last is {queue.Dequeue()}");