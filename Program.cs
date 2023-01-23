

using System.Text;
using System.Xml;

public class Program
{

    public static void Main()
    {
        //FizzBuzz();
        Console.WriteLine("Enter the input string to reverse");
        string input = Console.ReadLine();
        string output = reversestring(input); 
        Console.WriteLine(output);
        FizzBuzz();
        Console.ReadLine();
    }

    public static void FizzBuzz()
    {
        for (int i = 0; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("fizzbuzz");
            }
            else
            {
                if (i % 3 == 0)
                { 
                    Console.WriteLine("fizz");
                }
                else if(i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
            }
        }
    
    }

    public static string reversestring(string input)
    {
        StringBuilder output = new StringBuilder();
        char[] chars = input.ToCharArray();
        for (int i = input.Length-1; i >=0 ; i--)
        { 
            output.Append(chars[i]);
        }

        return output.ToString();
    
    }

}
