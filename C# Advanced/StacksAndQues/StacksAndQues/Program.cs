string input = Console.ReadLine();
Stack<char> myStack = new Stack<char>();

foreach (var item in input)
{
    myStack.Push(item);
}

string result=String.Empty;
while (myStack.Count > 0)
{
   result+=myStack.Pop();
}

Console.WriteLine(result);