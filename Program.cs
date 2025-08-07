
using ExemploPOO.Models;

Console.Clear();

Conta c1 = new Conta(123456);

c1.Depositar(1000M);

c1.Sacar(1500M);

c1.Sacar(500M);

c1.ConsultarSaldo();

Pessoa pe1 = new Pessoa("Symon", 27);

pe1.Apresentar();

Console.WriteLine("");

Aluno a1 = new Aluno("Pietro", 15, 7.7);

a1.Apresentar();

Console.WriteLine("");

Professor pr1 = new Professor("Clóvis", 35, 7500M);

pr1.Apresentar();