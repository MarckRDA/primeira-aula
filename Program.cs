using System;

namespace primeira_aula
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Qual é sua idade?");
            //Tranformando o texto que o usuário digitou para integer
            var userAge = Int32.Parse(Console.ReadLine());
            
            //Comparando se o valor da variável amILegalAge é true
            if(userAge > 15 && userAge < 51){
                Console.WriteLine("Sim, você tem idade para o entra21");
            }
            // else if(userAge == 14 || userAge == 15){
            //     //Se não, o valor da variável amILegalAge é false
            //     Console.WriteLine("Não, você não tem idade para o entra21, mas tem para o menor aprendiz");
            // }
            else
            {
                Console.WriteLine("Não tem idade para nenhum dos dois!");
            }
          
                 
         }
     }
 }
