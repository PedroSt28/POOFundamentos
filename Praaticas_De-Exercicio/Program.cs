using Praaticas_De_Exercicio;

Console.WriteLine("----------------- Exercicio 1 ----------------");

Pessoa p1  = new Pessoa();

Console.WriteLine("Qual é o seu nome?: ");
p1.nome = Console.ReadLine();

Console.WriteLine("Quantos anos voce tem?");
p1.idade = int.Parse(Console.ReadLine());
p1.Apresentar();


Pessoa p2 = new Pessoa();
Console.WriteLine("Qual é o seu nome?: ");
p2.nome  = Console.ReadLine();

Console.WriteLine("Quantos naos voce tem?: ");
p2.idade = int.Parse(Console.ReadLine());

p2.Apresentar();






Console.WriteLine("----------------- Exercicio 2 ----------------");


Retangulo Retangulo1 = new Retangulo();

Console.WriteLine("Qual a Largura do retangulo: ");
Retangulo1.Largura = double.Parse(Console.ReadLine());

Console.WriteLine("Qual a Altura do retangulo: ");
Retangulo1.Altura = double.Parse(Console.ReadLine());

Console.WriteLine($"Area:{Retangulo1.CalcularArea()}\nPerimetro:{Retangulo1.CalcularPerimetro()}");






Console.WriteLine("----------------- Exercicio 3 ----------------");

Lampada Lampada1 = new Lampada();

Console.WriteLine("a lampada ésta ligada? (true/False");
Lampada1.ligada = bool.Parse(Console.ReadLine());

Console.WriteLine(Lampada1.ligada);
Console.WriteLine(Lampada1.Alternar);



