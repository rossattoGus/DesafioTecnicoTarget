class Exercicio2 {
    static void Main(string[] args) {
        Console.WriteLine("\nFibonacci Sequence:");
        Console.WriteLine("\nEnter a number to check if it's in the Fibonacci sequence:");
        int x = Convert.ToInt32(Console.ReadLine());
        int sum = 0;


       List<int> arr = new  List<int>{0, 1};

       for (int i = 1; i <= x; i++) {
            sum = arr[i - 1] + arr[i];
            arr.Add(sum);
       }
        
        arr = arr.Where(num => num == x)
           .Select(num => num)
           .ToList();
        
        if (arr.Count > 0) {
            Console.WriteLine($"The number {x} is in the Fibonacci sequence.");
        }
        else {
            Console.WriteLine($"The number {x} is not in the Fibonacci sequence.");
        }
    }
}