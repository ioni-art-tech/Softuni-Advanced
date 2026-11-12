
string num =Console.ReadLine();
int n = int.Parse(num);


for (int i = num.Length-1; i >0; i--)
{
    int curr = num[i];
    if (curr <= num[i-1])
    {
        Console.WriteLine("NO");
        return;
    }
}
Console.WriteLine("Yes");
