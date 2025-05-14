class Exercicio5
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nWrite a world:");
        string? text = Console.ReadLine();

        if (text == null)
        {
            System.Console.WriteLine("\nNull input.");
        }

        char[] inverse = new char[text.Length];
        for (int i = 0; i < text.Length; i++)
        {
            inverse[i] = text[text.Length - i - 1];
        }
        
        string result = new string(inverse);
        Console.WriteLine(result);
    }
}