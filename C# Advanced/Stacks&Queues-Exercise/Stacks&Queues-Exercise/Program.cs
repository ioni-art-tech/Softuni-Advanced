//initialising our variables
int[] input = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();
int[] numbers= Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

Stack<int> stack = new Stack<int>(numbers);

//Removing s elements
for (int i = 0; i < input[1]; i++)
{
    if (stack.Count>0)
    {
        stack.Pop();
    }
    else
    {
        break;
    }
}

int result = 0;
if (stack.Contains(input[2]))
{
    Console.WriteLine("true");
}
else if(stack.Any())
{
    Console.WriteLine(stack.Min());
}
else
{
    Console.WriteLine("0");
}

//int currNum = 0;
//int result = 0;
//bool flag = true;
//while (stack.Count>1)
//{
//    currNum=stack.Pop();
//    if (currNum == input[2])
//    {
//        result=currNum;
//        flag = false;
//        break;
//    }
//}
//if (flag)
//{
//    result = stack.Pop();
//}







