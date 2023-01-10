using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace MyFirstProgram
    {
        class Program
        {
        static void Main(string[] args)
        {
            //conditional operator = used in conditional assignment if a condition is true/false

            // condition ? x:y

            double temperature = 20;
            String message;

           /* if(temperature < -15)
            {
                message = "its warm outside";
            }
            else
            {
                message = "its warm outside";
            }*/   
            
            message = (temperature >= 15) ? "its warm outside" : "its warm outside";

            Console.WriteLine(message);

           

        









            Console.ReadKey();
        }
        
    }
    }





   
