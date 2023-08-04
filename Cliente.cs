using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ContaBancaria
{
    internal class Cliente : Pessoa
    {
        public string CPF;
        public int saldoBancario;

        public Cliente(string cpf, int saldobancario) : base("Lucas", "Moura")
        {
            CPF = cpf;
            saldoBancario = saldobancario;
        }

        public void setCPF(string Newcpf)
        {
            this.CPF = Newcpf;
        }
        public string getCPF()
        {
            return this.CPF;
        }
        public void setsaldoBancario(int NewSaldo)
        {
            this.saldoBancario = NewSaldo;
        }
        public int getsaldoBancario()
        {
            return saldoBancario; 
        }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, me chamo {Nome} {Sobrenome}. Meu CPF é {CPF}");
        }
    }

    
}
