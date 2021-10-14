using System;

namespace calculadora_dotnet
{
    class Program
    {
        static void Main(string[] args){
            int opcao;
            double n1;
            double n2;
            double resultado;
            bool validate = true;
            Program program =new Program();
            
            Console.WriteLine("### sejam bem vindos a calculadora DOTNET####");
        do {
            Console.WriteLine("Qual a operação desjada ? : ");
            Console.WriteLine("(1)soma");
            Console.WriteLine("(2)subtração");
            Console.WriteLine("(3)multiplicação");
            Console.WriteLine("(4)divisão");
            Console.WriteLine("(5)Sair ");
            
            Console.WriteLine("Digite a sua opção: ");
            opcao = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Digite o primeiro valor :");
            n1 = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Digite o segundo valor :");
            n2 = Convert.ToInt32(Console.ReadLine());

            switch (opcao){ 
              case 1 :
                resultado =program.soma(n1,n2);
                Console.WriteLine("O resultado da minha soma é {0}", resultado);
              break;  
              case 2 :
                resultado =program.subtracao(n1,n2);
                Console.WriteLine("O resultado da minha subtração é {0}", resultado);
                Console.Clear();
                break;
              case 3 :
                resultado =program.multiplicaçao(n1,n2);
                Console.WriteLine("O resultado da minha multiplicação é {0}", resultado);
                break;
              case 4 :
                resultado =program.divisao(n1,n2);
                Console.WriteLine("O resultado da minha divisao é {0}", resultado);
                break;

              case 5 :
              validate = false;
              break;
              
              default:
              Console.WriteLine("opção invalida");
              break;
            }
            
            Console.WriteLine("pressione ENTER para continuar : ");
            Console.ReadLine();
            Console.Clear();
    
        }while(validate);
    }

        public double soma(double n1,double n2)
        {
            return n1+n2;
        }
        public double subtracao(double n1, double n2)
        {    return n1-n2;
        }
        public double multiplicaçao(double n1 ,double n2)
        {
            return n1 * n2;
        }
        public double divisao (double n1 ,double n2)
        {
            return n1 / n2;
        }
    }
}