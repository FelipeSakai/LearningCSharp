using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Bancaria
    {
        public int Numero { get; private set; }
        public string Nome { get; private set; }

        public double Saldo { get; private set; }

        public Bancaria(int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
        }

        public Bancaria(int numero, string nome, double saldo) : this(numero, nome)
        {
            Saldo = saldo;
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5;
        }

        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", Nome: "
                + Nome
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
