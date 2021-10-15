using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClassePessoa
{
    class Pessoa
    {
         public string nome;
         public int idade;
        // Só define com int quando for fazer calculos com o numero  
        public string rg;
        public string cpf;

        public void Acenar(Pessoa pessoa)
        {
            Console.WriteLine ("{0} acenou para {1}",this.nome,pessoa.nome);
        }
        public void PerguntaIdade(Pessoa pessoa)
        {
            Console.WriteLine("{0} qual a sua idade? ",this.nome);
            pessoa.RespostaIdade();
        }
        public void RespostaIdade()
        {
            Console.ReadLine("eu tenho {0} anos",this.idade);
        }
    }
}