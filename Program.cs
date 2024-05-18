using Heranca_polimorfismo.Models;



//***********************************************************************
//Herança e polimorfismo

Aluno a1 = new Aluno();

a1.Nome = "Juanito";
a1.Idade = 17;
a1.Nota = 10;
a1.Email = "juanito@gmail.com";
a1.Apresentar();

Professor p1 = new Professor();

p1.Nome = "Eduardo";
p1.Idade = 30;
p1.Salario = 1000;
p1.Apresentar();

//***********************************************************************
//encapsulamiente
// ContaCorrente c1 = new ContaCorrente(12312312, 1000);

// c1.ExibirSaldo();
// c1.Sacar(350);
// c1.ExibirSaldo();
//***********************************************************************
// Pessoa p1 = new Pessoa();
// p1.Nome = "Alejandro";
// p1.Idade = 29;

// p1.Apresentar();
