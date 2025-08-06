using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Conta
    {

        public Conta(int numeroConta)
        {

            NumeroConta = numeroConta;

        }

        public int NumeroConta { get; set; }
        private decimal saldo;

        public void Depositar(decimal valor)
        {

            Console.WriteLine($"Depósito no valor de {valor}, realizado com sucesso!");
            saldo = saldo + valor;

        }
        public void Sacar(decimal valor)
        {

            if (saldo < valor)
            {

                Console.WriteLine($"Não é possível sacar o dinheiro, pois seu saldo é {saldo} " +
                $"e você está tentando sacar {valor}");

            }
            else
            {

                Console.WriteLine($"Saque no valor de {valor}, realizado com sucesso!");
                saldo = saldo - valor;

            }

        }

        public void ConsultarSaldo()
        {

            Console.WriteLine($"O saldo da conta {NumeroConta} é: {saldo}");

        }

    }
}