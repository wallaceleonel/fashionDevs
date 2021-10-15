using System;

namespace ConsoleClassePessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa  pessoa = new Pessoa();
            
            Console.WriteLine("Digite seu nome :");
            pessoa.nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade  :");
            pessoa.idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite seu rg :");
            pessoa.rg = Console.ReadLine();

            Console.WriteLine("Digite seu cpf :");
            pessoa.cpf = Console.ReadLine();

            Console.WriteLine ("nome : {0}",pessoa.nome);
            Console.WriteLine ("idade {0}", pessoa.idade);
            Console.WriteLine ("rg :{0}",pessoa.rg);
            Console.WriteLine ("cpf : {0}",pessoa.cpf);

            
            Pessoa pessoaSilvia = new Pessoa();
            pessoaSilvia.nome = "Silviva Mendes";
            pessoaSilvia.idade =28;
            pessoaSilvia.rg ="000.000.00-0";
            pessoaSilvia.cpf ="00.000.000.00";

            Console.WriteLine ("nome : {0}",pessoa.nome);
            Console.WriteLine ("idade {0}", pessoa.idade);
            Console.WriteLine ("rg :{0}",pessoa.rg);
            Console.WriteLine ("cpf : {0}",pessoa.cpf);

            pessoa.Acenar(pessoaSilvia);
            pessoa.PerguntaIdade(pessoaSilvia);
        }
    }
}
