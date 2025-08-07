using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {

        public decimal Salario { get; set; }
        public Professor(string nome, int idade, decimal salario) : base(nome, idade)
        {
            Salario = salario;
        }


        public override void Apresentar()
        {
            // Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, sou um professor e meu salário é de {Salario} ");
            base.Apresentar();
            Console.WriteLine($"Sou um professor e meu salário é de {Salario.ToString("C")}");

        }

    }
}