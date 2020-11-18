using System;

namespace exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb = 0;
            do 
            {
            Console.WriteLine("digite a nota  de 0 a 10 ");
            numb = int.Parse(Console.ReadLine());

            if((numb < 0) || ( numb >10 ) ){
                Console.WriteLine("nota invalida");
            }

            }
            while((numb < 0) || ( numb >10 ) );
        }
    }
}
