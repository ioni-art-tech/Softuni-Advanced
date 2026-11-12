int n = int.Parse(Console.ReadLine());

Queue<int[]> queue = new();
for (int i = 0; i < n; i++)
{
    int[] prm =Console.ReadLine()
        .Split(" ")
        .Select(int.Parse)
        .ToArray(); 

   queue.Enqueue(new int[] { i, prm[0], prm[1] });
}

int startIndex = 0;
int currPetrol = 0;
int brVisitedPumps = 0;

while (brVisitedPumps<n)
{
    int[] tokens = queue.Dequeue();
    currPetrol += tokens[1] - tokens[2];
    queue.Enqueue(tokens);
    if (currPetrol<0)
    {

        startIndex=tokens[0]+1;
        brVisitedPumps = 0;
        currPetrol = 0;
    }
    else
    {
        brVisitedPumps++;
    }
}

Console.WriteLine(startIndex);

