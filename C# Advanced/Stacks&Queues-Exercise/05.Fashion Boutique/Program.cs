Stack<int> clothes = new Stack<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

int capacityRack = int.Parse(Console.ReadLine());

int brRacks = 1;
int currsize = capacityRack;
while (clothes.Any())
{
    currsize -= clothes.Peek();
    if (currsize<0)
    {
        brRacks++;
        //sum -=capacityRack;
        currsize = capacityRack;
        continue;
    }
    clothes.Pop();
}

Console.WriteLine(brRacks);