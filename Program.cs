using System;

namespace primeira_aula
{
    class Program
    {
        static void NumerosCrescentes(string[] args)
        {
            var count = 1;

            while (count >= 10){
                System.Console.WriteLine(count);
                count++;
            }
                   
                 
         }

         static void NumerosDecrescentes(string[] args)
        {
            var count = 10;

            while (count > 0){
                System.Console.WriteLine(count);
                count--;
            }
                   
                 
         }

         static void NumerosCrescentesPares(string[] args)
        {
            var count = 1;

            while (count <= 10){
                if(count % 2 == 0){
                    System.Console.WriteLine(count);
                }
                count++;
            }
                   
                 
         }
        static void SomaDe1a100(string[] args)
        {
            var count = 1;
            int n = 0;

            while (count <= 100){
                n +=count;
                System.Console.WriteLine(n);
                count++;
            }
            
                 
         }

        static void ImparesMenosresQue200(string[] args)
        {
            int count = 1;
            while (count < 200){
                if(count % 2 != 0){
                    System.Console.WriteLine(count);
                }
                count++;
            }
            
                 
         }
         
         static void MediaIdade(string[] args)
        {
            double sum = 0.0;
            double count = 0.0;

            while (true)
            {
                System.Console.WriteLine("Digite uma idade");
                var idade = Int32.Parse(System.Console.ReadLine());

                if(idade == 0){
                    break;
                }
                sum += idade;
                count++;
            }

            System.Console.WriteLine($"A média de idades da turma é" + String.Format("(0:0.00)", sum/count));

                 
         }

          static void IdadesPercentagemMulheres(string[] args)
        {
            
            var age = 0.0;
            var womenNames = "";
            var count = 0.0;

            while (count < 5)
            {
                System.Console.WriteLine("Digit woman's name: ");
                womenNames = System.Console.ReadLine();
                System.Console.WriteLine("Digit woman's age: ");
                int n = Int32.Parse(System.Console.ReadLine());
                
                if(n >= 18 && n <= 35 ){
                    age++;    
                }
                count++;

            }
            System.Console.WriteLine($"A porcentagem de mulher com idades entre 18 e 35 é: {(age/count)*100} ");
            
                 
         }

           static void Main(string[] args)
        {
            var candidates = new string[2];   
            var option = 0;
            var candidate1Vote = 0;
            var candidate2Vote = 0;
            var counterInputCandidates = 0;
            
            while(true){
                System.Console.WriteLine("Selecione o modo de operação da urna:");
                System.Console.WriteLine(" 1) Cadastrar candidato/ 2) Votação / 3) Apuração de votos");
                option = Int32.Parse(System.Console.ReadLine());
                if(option == 1){
                    System.Console.WriteLine("Por favor, insira a senha: ");
                    var password = System.Console.ReadLine(); 
                    if(password == "Pa$$w0rd"){
                        while(counterInputCandidates < 2){
                            var intermediateCandidates = System.Console.ReadLine();
                            candidates[counterInputCandidates] = intermediateCandidates;
                            counterInputCandidates++;
                        }
                    }else{
                        System.Console.WriteLine("Senha errada!!");
                        continue;
                    }
                }else if(option == 2){
                    if(candidates.Length == 0){
                        System.Console.WriteLine("Por favor, insira os candidados primeiro");
                        continue;
                    }
                    var optionVoteOrExit = 0;
                    System.Console.WriteLine($"Aperte 1 para o candidato {candidates[0]} ou 2 para o {candidates[1]}. Pressione 0 para encerrar a votação");

                    while(optionVoteOrExit != 0){
                        //ToDoAtHome  
                        if(optionVoteOrExit == 1){

                        }  
                    }
                    }
                }

            }
        }
     }
 }
