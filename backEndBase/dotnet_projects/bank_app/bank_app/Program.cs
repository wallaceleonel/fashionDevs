using System;

namespace bank_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente_app cliente = new Cliente_app("Wallace Leonel","xxx.xxx.xxx-xx","Desenvolvedor");
            
            /*
            metodo alternativo
            cliente.setNome("Wallace Leonel");
            cliente.setCPF("xxx.xxx.xxx-xx");
            cliente.setProfissão("Desenvolvedor");
            */

            conta_corret_app conta = new conta_corret_app();
            
            conta.titular =cliente;
            conta.agencia = 01;
            conta.conta = 000012;
            conta.saldo = 1000000000000.00;

            Console.WriteLine("conta Corrente Criada ");
            Console.WriteLine("Titular : {0}", conta.titular.nome);
             Console.WriteLine("Agencia  : {0}", conta.agencia);
              Console.WriteLine("Conta : {0}", conta.conta);
        }
    }
}
