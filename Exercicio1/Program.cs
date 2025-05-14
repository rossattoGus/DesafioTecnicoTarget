class Sum 
{
    public static void Main(string[] args) 
    {
        const int index = 13;
        int sum = 0,
        k = 0;

        while (index > k)
        {
            k += 1;
            sum += k;
        }
        Console.WriteLine($"The sum between 1 and {index} is {sum}.");
    }
}