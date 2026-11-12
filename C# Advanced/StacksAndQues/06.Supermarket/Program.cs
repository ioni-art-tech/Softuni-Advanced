Queue<string> names = new Queue<string>();

string line = "";
while ((line=Console.ReadLine().ToLower())!="end")
{
    if (line!="paid")
    {
        names.Enqueue(line);
    }
    else
    {
        while (names.Count>0)
        {
            Console.WriteLine(names.Dequeue());
        }
    }
}

Console.WriteLine($"{names.Count} people remaining.");