namespace NumerosPrimos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: ");
            var num = int.TryParse(Console.ReadLine(), out var num2);

            var primo = IsPrime(num2);

            if (primo)
            {
                Console.WriteLine("Es un numero primo");
            }
            else
            {
                Console.WriteLine("No es un numero primo");
            }

            Console.ReadLine();        
        }

        static bool IsPrime(int number)
        {
            if(number < 2)
            {
                return false;
            }
            else
            {
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}