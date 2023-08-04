using System;

namespace ContaBancaria
{
    class Program
    {
        static void Main()
        {
            Pessoa pessoa1 = new Pessoa("Lucas", "Alem");

            Cliente cliente1 = new Cliente("485.998.784-48", 01015445);
            
            Banqueiro banqueiro = new Banqueiro(2554, 12050058);

            cliente1.setsaldoBancario(26000); 

            

            cliente1.Apresentar();
            banqueiro.Apresentar();

        }
    }
}