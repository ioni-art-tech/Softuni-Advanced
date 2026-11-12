using System.Linq.Expressions;

string[] input = Console.ReadLine()
    .Split(", ");

Queue<string> songs = new Queue<string>(input);

while (songs.Count>0)
{
    string[] cmdArg = Console.ReadLine()
        .Split(" ");

    switch (cmdArg[0])
    {
        case "Play":
            songs.Dequeue();
            break;
        case "Add":
            string song = string.Join(" ", cmdArg.Skip(1));
            if (songs.Contains(song))
            {
                Console.WriteLine($"{song} is already contained!");
            }
            else
            {
                songs.Enqueue(song);
            }
                break;
        case "Show":
            Console.WriteLine( string.Join(", ", songs));
            break;
        
    }

}

Console.WriteLine("No more songs!");