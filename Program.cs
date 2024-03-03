using System;

namespace ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string convertir = "";
            bool intentar = false;

            Console.WriteLine("Si deseas convertir a Celsius a Fahrenheit presione la tecla C \nSi desea convertir de Fahrenheit a Celsius presione la tecla F");

             while (!intentar)
             {
                try
                {
                    convertir = Console.ReadLine().ToUpper();

                    if (convertir == "C" || convertir == "F")
                        intentar = false;
                    else
                        Console.WriteLine("Caracter erroneo"); 
                    

                }
                catch (Exception ex)
                {
                     Console.WriteLine("Has cometido una excepción de tipo : " + ex.Message);

                     Console.WriteLine("\nIntente nuevamente presionar la tecla C o F");

                }
             }

            

            switch (convertir)
            {

                case "C":
                    
                    Console.WriteLine("Ingrese la temperatura Celsius");
                    double temC = double.Parse(Console.ReadLine());

                    double F = temC * (9 / 5) + 32;
                    
                    Console.WriteLine($"{temC} grados °C es igual a {F} grados Fahrenheit");

                    break;

                case "F":

                    Console.WriteLine("Ingrese la temperatura Fahrenheit");
                    double temF = double.Parse(Console.ReadLine());

                    double C = (temF - 32) * 5 / 9;

                    Console.WriteLine($"{temF} grados °F es igual a {C} grados °C");
                    
                break;

                
                default:
                    throw new ArgumentOutOfRangeException();
                    
                break;
            }

        }
    }
}
