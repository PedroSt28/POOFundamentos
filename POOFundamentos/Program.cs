// objeto é uma variavel

//TIPO E NOME

using POOFundamentos;

//instanciar
Carro carroPedro = new Carro();

carroPedro.Modelo = "Corsinha";
carroPedro.Marca = "sla vei";
carroPedro.Ano = 2013;

carroPedro.ExibirInformacoes();  

//instanciar novo objeto

Carro car1 = new Carro();
car1.Modelo = "Celta";
car1.Marca = "play";
car1.Ano = 1978;

car1.ExibirInformacoes();





//Criar uma clase pedido 
// Nome do cliente, Item, Quantidade, preço

Pedido pedido1 = new Pedido();

pedido1.Nome = "Pedro";
pedido1.Item = "Pizza";
pedido1.Quantidade = 2;
pedido1.Preco = 90.50;

pedido1.ExibirPedido();