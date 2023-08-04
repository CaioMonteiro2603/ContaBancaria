using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    internal class Pessoa
    {
        protected string Nome;
        protected string Sobrenome;

        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        public void setNome(string Newname)
        {
            this.Nome = Newname;
        }
        public string getNome()
        {
            return this.Nome;
        }
        public void setSobrenome(string Newlast)
        {
            this.Sobrenome = Newlast;
        }
        public string getSobrenome()
        {
            return this.Sobrenome;
        }

        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá, me chamo {Nome} {Sobrenome}");
        }
    }
        

}
