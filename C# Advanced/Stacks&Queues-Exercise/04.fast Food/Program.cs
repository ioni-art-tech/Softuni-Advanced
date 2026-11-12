int n =int.Parse(Console.ReadLine());
int[] orders =Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray(); 
Queue<int> queue = new Queue<int>(orders);
int maxEl = queue.Max();

//int order = 0;
//while (queue.Count>0)
//{
//    order = queue.Peek();
//    if (order<=n )
//    {
//        queue.Dequeue();
//        n -= order;
//    }
//    else
//    {
//        break;
//    }


//}
int quantity = 0;
while (true)
{
    quantity-=queue.Peek();
    if (quantity<0)
    {
        break;
    }
    queue.Dequeue();
}

Console.WriteLine(maxEl);
if (queue.Any())
{
    Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
   
}
else
{
    Console.WriteLine("Orders complete");
}