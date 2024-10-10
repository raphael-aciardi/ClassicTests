using System.Formats.Asn1;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {

        //Fibonacci

        List<int> fibonacciNumbers = new List<int>();

        Console.Write("Type a number: ");

        int userNumber = Convert.ToInt32(Console.ReadLine());

  
        int a = 0; 
        int b = 1; 

        Console.WriteLine("Fibonacci sequence:");

 
        while (a <= userNumber)
        {
            Console.WriteLine(a); 
            fibonacciNumbers.Add(a); 

          
            int next = a + b; 
            a = b;            
            b = next;       
        }

        int foundNumber = fibonacciNumbers.FirstOrDefault(num => num == userNumber);

        if (foundNumber != 0 || fibonacciNumbers.Contains(0) && userNumber == 0)
        {
            Console.WriteLine($"{userNumber} is in the Fibonacci sequence.");
        }
        else
        {
            Console.WriteLine($"{userNumber} is not in the Fibonacci sequence.");
        }

        //Count letter A
        Console.Write("Type a sentence: ");
        string answer = Console.ReadLine().ToLower();
        int count = answer.Count(c => c == 'a');
        Console.WriteLine($"There are {count} letters A in this sentence");

        int INDICE = 12; 
        int SOMA = 0;   
        int K = 1;      

        //Logic test
        while (K < INDICE)
        {
            K = K + 1; 
            SOMA = SOMA + K; 
        }

        Console.WriteLine($"The value of soma is {SOMA}"); 
    }
}
