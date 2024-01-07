using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHerança
{
    public class Conta
    {
        // atributos
        public int Numero { get; set; }
        public string? Titular { get; set; }
        public decimal Saldo { get; set; } = 0.00m;
        public virtual double Juros { get; set; } = 0.00;

        // comportamentos

        private decimal CalculaRemuneracao(double juros)
        {
            return Saldo * (decimal)Juros;
        }

        public virtual decimal Sacar(decimal valor)
        {
            Saldo -= valor;
            return Saldo;
        }

        public decimal Deposito(decimal valor)
        {
            Saldo += valor;
            Saldo = Saldo + CalculaRemuneracao(Juros);
            return Saldo;
        }
    }
}
