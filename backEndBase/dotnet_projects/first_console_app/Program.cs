using System;

namespace first_console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade = 0;

            Console.WriteLine("Digite seu nome:");
             nome = Console.ReadLine();
            Console.WriteLine("informe a sua idade");
            idade = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Hello {0}",nome +"!");
             Console.WriteLine("Eu tenho {0} anos {1}",idade,nome);

             if (idade > 18)
             {
                 Console.WriteLine("Pessoa é de maior legal");
             } else{
                 Console.WriteLine("Voce precisa esta acompanhado de um maior legal");
             }
        }
    }
}
