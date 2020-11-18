using System;

namespace exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "";
            int idade = 0; 
            double salario= 0;  
            string estado = "";


            do
            {
            Console.WriteLine("digite nome");
             nome = Console.ReadLine();
            
            if (nome == "" ){
                Console.WriteLine("fail");

            }
            }while( nome == "");

            Console.WriteLine("nome valiodo");


            do
            {
            Console.WriteLine("digite sua idade");
             idade = int.Parse(Console.ReadLine());
            
            if ( ( idade<0 ) || (idade > 150) ) {
                Console.WriteLine("idade invalida");
            }

            }while( ( idade<0 ) || (idade > 150));

            Console.WriteLine("idade valida ");

              

            do
            {
            Console.WriteLine("digite seu salario ");
             salario = int.Parse(Console.ReadLine());
            
            if ( salario <= 0 ) {
                Console.WriteLine("salario invalido");
            }

            }while( salario <= 0 ); 

            Console.WriteLine("salario maior que  R$0");

            

             do
            {
            Console.WriteLine("digite seu estado civil ");
             estado = (Console.ReadLine());
            
            if ( (estado != "casado") || (estado!="solteiro") || (estado!="viuvo") || (estado!="divorciado ") || (estado!="solteira") || (estado!="casada") || (estado!="viuva ") ||(estado!="divorciada") ) {
                Console.WriteLine("estado civil invalido ");
            }

            }while( (estado!="casado") || (estado!="solteiro") || (estado!="viuvo") || (estado!="divorciado ") || (estado!="solteira") || (estado!="casada") || (estado!="viuva ") ||(estado!="divorciada") ); 


          
        }
    }
}
