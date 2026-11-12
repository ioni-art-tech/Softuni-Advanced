//char[] input =Console.ReadLine().ToArray();

//Stack<char> paranthesis= new Stack<char>();

//foreach (char item in input)
//{
//    switch (item)
//    {
//        case '[':
//        case '(':
//        case '{':
//            paranthesis.Push(item);
//            break;
//        case ')':
//            if (paranthesis.Pop()!='(' && paranthesis.Count>0)
//            {
//                Console.WriteLine("NO");
//            }
//            break;
//    }

//}

//if (paranthesis.Count==0)
//{
//    Console.WriteLine("YES");
//}
//else
//{
//    Console.WriteLine("NO");
//}
char[] input = Console.ReadLine().ToArray();

Stack<char> paranthesis = new Stack<char>();

foreach (char item in input)
{
    if (item == '(' || item == '{' || item == '[')
    {
        paranthesis.Push(item);
    }
    else
    {
        if (paranthesis.Count==0)
        {
            Console.WriteLine("NO");
            return;
        }

        char opening = paranthesis.Pop();
         if (opening != '(' && item == ')'
            || opening!='{' && item=='}'
            || opening !='[' && item==']')
        {
            Console.WriteLine("NO");
            return;
        }
    }
   

}


if (paranthesis.Count==0)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}
