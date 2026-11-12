int n = int.Parse(Console.ReadLine());
Queue<string> cars= new Queue<string>();


string cmd = "";
int carsPassed = 0;
while ((cmd =Console.ReadLine())!="end")
{
    if (cmd=="green")
    {
           
         for (int i = 0; i < n; i++)
         {
            if (cars.Count==0)
            {
                break;
            }

            Console.WriteLine($"{cars.Dequeue()} passed!");
            carsPassed++;
         }
                
    }
    else
    {
        cars.Enqueue(cmd);
    }
}

Console.WriteLine($"{carsPassed} cars passed the crossroads.");