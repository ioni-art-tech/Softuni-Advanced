int n = int.Parse(Console.ReadLine());
int nCmd = 0;


Stack<char> text = new Stack<char>();
Stack<string[]> operationsStack = new();

for (int i = 0; i < n; i++)
{
    string[] cmdArg = Console.ReadLine()
        .Split(" ");
    nCmd = int.Parse(cmdArg[0]);

    switch(nCmd)
    {
        case 1:
            operationsStack.Push(new string[] { cmdArg[0], cmdArg[1]});

            string textToAdd=cmdArg[1];
            for (int j = 0; j < textToAdd.Length; j++)
            {
                text.Push(textToAdd[j]);
            }
            break;
        case 2:

            string arg = "";
            for (int j = 0; j < int.Parse(cmdArg[1]); j++)
            {
                if (text.Any())
                {
                    arg+=text.Pop();
                }
                
            }
            operationsStack.Push(new string[] { cmdArg[0], arg });
            break;
        case 3:
            char[] curr=text.ToArray();
            
            int index = int.Parse(cmdArg[1]);
            Array.Reverse(curr);
            Console.WriteLine(curr[index-1]);

            break;
        case 4:
            
            if (operationsStack.Any())
            {
                string[] currArr = operationsStack.Pop();
                int num = int.Parse(currArr[0]);
                char[] argument=currArr[1].ToCharArray();
                Array.Reverse(argument);
                if (num==1)
                {
                    for (int j = 0; j < argument.Length; j++)
                    {
                        text.Pop();
                    }
                }
                else if (num==2)
                {
                    for (int j = 0; j < argument.Length; j++)
                    {
                        text.Push(argument[j]);
                    }
                }
            }
            break;
    }
    
}