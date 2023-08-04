using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    internal class Banqueiro : Pessoa
    {
        public int idBancario;
        public int Protocolo;

        public Banqueiro(int idBancario, int protocolo) : base ("Caio", "Monteiro")
        {
            this.idBancario = idBancario;
            Protocolo = protocolo;
        }

        public void setidBancario(int Newid)
        {
            this.idBancario = Newid;
        }
        public int getIdBancario()
        {
            return this.idBancario;
        }
        
        public void setProtocolo(int Newprotocolo)
        {
            this.Protocolo = Newprotocolo;
        }
        public int getProtocolo()
        {
            return this.Protocolo;
        }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, me chamo {Nome} {Sobrenome} e serei seu atendente. " +
                $"Seu protocolo de atendimento é {Protocolo}");
        }
    }
}
