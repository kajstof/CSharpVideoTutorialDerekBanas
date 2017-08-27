using System;

namespace derek_csharp_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Derek";
            string name2 = "Derek";
            if (name.Equals(name2, StringComparison.Ordinal))
            {
                Console.WriteLine("Names are Equal");
            }
            Random rnd = new Random();
            int secretNumber = rnd.Next(1, 11);
            int numberGuessed = 0;
            do
            {
                Console.Write("Enter a number between 1 & 10 : ");
                numberGuessed = Convert.ToInt32(Console.ReadLine());
            } while (secretNumber != numberGuessed);

            double num1 = 5;
            double num2 = 0;
            try
            {
                DoDivision(num1, num2);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You can't divide by zero");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Cleaning Up");
            }
            Console.ReadKey();
        }

        static double DoDivision(double x, double y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException();
            }
            return x / y;
        }
    }
}
