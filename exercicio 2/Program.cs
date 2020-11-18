using System;

namespace exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = "";
            string senha = "";
            do
            {
            Console.WriteLine("digite seu usuario");
             user = Console.ReadLine();

            Console.WriteLine("digite sua senha ");
             senha  = Console.ReadLine();
            
            if ( user == senha ){
                Console.WriteLine("fail");
            }
            }while( user == senha);

        }
    }
}
