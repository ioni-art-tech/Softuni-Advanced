string[] input = Console.ReadLine()
    .Split(' ')
    .ToArray();

Stack<string> tokens= new Stack<string>(input.Reverse());

int result = int.Parse(tokens.Pop());
while (tokens.Count>0)
{
    string operation = tokens.Pop();
    int num=int.Parse(tokens.Pop());

    if (operation=="+")
    {
        result += num;
    }
    else if (operation=="-")
    {
        result -= num;
    }
}

Console.WriteLine(result);