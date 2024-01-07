using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHerança
{
    public class ContaPoupanca : Conta
    {
        public override double Juros { get; set; } = 0.005;

        public override decimal Sacar(decimal valor)
        {
            if( Saldo >= valor)
            {
                Saldo -= valor;
                return Saldo;
            }
            else
            {
                Console.WriteLine("Saldo Indisponível");
                return Saldo;
            }
        }

  
    }
}
