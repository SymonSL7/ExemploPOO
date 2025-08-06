
using ExemploPOO.Models;

// Pessoa p1 = new Pessoa("Symon", 27);

// p1.Apresentar();

Console.Clear();

Conta c1 = new Conta(123456);

c1.Depositar(1000M);

c1.Sacar(1500M);

c1.Sacar(500M);

c1.ConsultarSaldo();