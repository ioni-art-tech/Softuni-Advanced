string expression = Console.ReadLine();
Stack<int> stack = new Stack<int>();

for (int i = 0; i < expression.Length; i++)
{
    if (expression[i] == '(')
    {
        stack.Push(i);
    }
    else if (expression[i] == ')')
    {
        int openBracketIndex = stack.Pop();

        string innerExpression = expression.Substring(openBracketIndex+1, expression.Length - openBracketIndex-1)
            .Trim();
        int value=EvaluateSum(innerExpression);
        expression=expression.Substring(0,openBracketIndex) +value+expression.Substring(i+1);

        //reset the for-loop parameters
        //i = -1;
        //stack.Clear();

        // THE BETTER OPTIMISED WAY OF CONTINUING THE LOOP
        string replacement=value.ToString();
        i = openBracketIndex - 1 + replacement.Length;

    }
}

int result= EvaluateSum(expression);

static int EvaluateSum(string expression)
{
    string[] input = expression
    .Split(' ')
    .ToArray();

    Stack<string> tokens = new Stack<string>(input.Reverse());

    int result = int.Parse(tokens.Pop());
    while (tokens.Count > 0)
    {
        string operation = tokens.Pop();
        int num = int.Parse(tokens.Pop());

        if (operation == "+")
        {
            result += num;
        }
        else if (operation == "-")
        {
            result -= num;
        }
        else if (operation=="/")
        {
            result /= num;
        }
        else if (operation=="*")
        {
            result *= num;
        }
    }

    return result;
}