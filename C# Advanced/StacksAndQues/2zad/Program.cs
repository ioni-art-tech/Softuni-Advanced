int[] input =Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
Stack<int> stack = new Stack<int>(input);

string line = string.Empty;
while ((line =Console.ReadLine().ToLower())!="end")
{
    string[] commandArg = line.Split(' ');
    string command=commandArg[0];

    if (command=="add")
    {
        int fnum = int.Parse(commandArg[1]);
        int snum = int.Parse(commandArg[2]);
        stack.Push(fnum);
        stack.Push(snum);
    }
    else if (command=="remove")
    {
        int n=int.Parse(commandArg[1]);

        if (stack.Count()<n)
        {
            continue;
        }
        for (int i = 0; i < n; i++)
        {
            stack.Pop();
        }
    }
}

int sum = 0;
while (stack.Count>0)
{
    sum+= stack.Pop();
}

Console.WriteLine($"Sum: {sum}");