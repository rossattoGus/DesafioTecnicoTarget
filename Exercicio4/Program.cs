using System.ComponentModel.DataAnnotations;

class Exercicio4 
{
    static void Main(string[] args)
    {
        string[,] arr = {
            {"SP", "67836.43"},
            {"RJ", "36678.66"},
            {"MG", "29229.88"},
            {"ES", "27165.48"},
            {"Outros", "19849.53"}};
        
        double total = 0;

        for (int i = 0; i <= 4; i++)
        {
            total += Convert.ToDouble(arr[i,1]);
        }

        for (int i = 0; i <= 4; i++)
        {
            double result = Convert.ToDouble(arr[i,1]);
            result = result / total * 100;
            Console.WriteLine($"The {arr[i,0]} represents {String.Format("{0:0.00}", result)}% of the total sales value at the distributor.");
        }
    }
}