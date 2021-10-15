using System;

namespace bank_app
{
    class Cliente_app
    {
        public string nome {get; set ;}
        public  string CPF { get; set;}
        public  string profissão {get; set;}
        
        public Cliente_app( string nome , string CPF ,string profissao)
        {
            this.setnome(nome);
            this.setCPF(CPF);
            this.setprofissao(profissao);
        }
        public string getNome()
        {
            return this.nome;
        }
         public void  setnome(string nome)
        {
            this.nome = nome;
        }
         public string getCPF()
        {
            return this.CPF;
        }
         public void setCPF(string CPF)
        {
            this.CPF = CPF;
        }
         public static getprofissao()
        {
            return this.profissao;
        }
         public void setprofissao(string profissao)
        {
            this.profissão = profissao;
        }
    }
}
