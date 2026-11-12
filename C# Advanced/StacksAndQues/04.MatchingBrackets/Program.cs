string expression =Console.ReadLine();
Stack<int> stack = new Stack<int>();

for (int i = 0; i < expression.Length; i++)
{
    if (expression[i]=='(')
    {
        stack.Push(i);
    }
    else if (expression[i]==')')
    {
        int openBracketIndex = stack.Pop();

        for (int j = openBracketIndex; j <= i; j++)
        {
            Console.Write(expression[j]);
        }
        Console.WriteLine();
    }
}