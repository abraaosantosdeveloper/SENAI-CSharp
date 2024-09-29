//Console.WriteLine("Bem vindo ao sistema! ");
//Console.WriteLine("Digite seu nome abaixo...");
//string nome = Console.ReadLine();

//Console.WriteLine("Você é aluno do SENAI?(S/N)");
//string resposta = Console.ReadLine();

//if (resposta.ToLower() == "s")
//{
//    Console.WriteLine($"Parabéns, {nome}! Está no lugar certo.");
//}
//else if (resposta.ToLower() == "n")
//{
//    Console.WriteLine("Deveria considerar a opção...");
//}
//else
//{
//    Console.WriteLine($"A resposta ({resposta}) é inválida. ");
//}

//TimeSpan time = new TimeSpan(0, 0, 45);

//Console.ForegroundColor = ConsoleColor.Red;

//while(true)
//{
//    Thread.Sleep(1000);
//    time = time - TimeSpan.FromSeconds(1);
//    Console.Clear();
//    Console.WriteLine(time.ToString(@"hh\:mm\:ss"));
//    if (time.TotalMilliseconds == 0) break;

//}

//Console.WriteLine("Kabum");
//Console.ReadLine();


//Console.ForegroundColor = ConsoleColor.Green;
//while (true)
//{
//    string character = char.ConvertFromUtf32(Random.Shared.Next(50, 150));
//    Console.Write(character);
//}
using MeuProjeto;

List<Carro> carros = new List<Carro>();

void adicionarCarro()
{
    Carro c = new Carro();

    Console.Write("Digite o modelo do veículo: "); c.modelo = Console.ReadLine();
    Console.Write("Digite o ano de fabricação: "); c.ano = int.Parse(Console.ReadLine());
    Console.Write("Digite o fabricante: "); c.fabricante = Console.ReadLine();
    Console.Write("Preço do veículo: "); c.preco = double.Parse(Console.ReadLine());

    // se a lista estiver vazia o id será 1
    if (carros.Count == 0) c.id = 1;
    // se não, o id será o valor máximo de ids já existentes + 1
    else { c.id = carros.Max(q => q.id) + 1; }

    carros.Add(c);
    Console.Clear();
}


while (true) { 
    Console.BackgroundColor = ConsoleColor.Magenta;
    Console.ForegroundColor = ConsoleColor.Black;

    Console.WriteLine("----- Locadora de veículos -----");

    Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.White;

    Console.WriteLine("1 - Cadastrar Veículo");
    Console.WriteLine("2 - Cadastrar Cliente");
    Console.WriteLine("3 - Alugar Veículo");
    Console.WriteLine("4 - Listar Veículos");
    Console.WriteLine("5 - Listar Clientes");
    Console.WriteLine("6 - Listar Contratos");
    Console.WriteLine("7 - Sair");
    Console.Write("Digite a opção: "); int opcao = int.Parse(Console.ReadLine());


if (opcao == 1)
{
    Console.WriteLine($"Opção escolhida: {opcao}");
    adicionarCarro();
}
else if (opcao == 2)
{
    Console.WriteLine($"Opção escolhida: {opcao}"); continue;
    
}
else if (opcao == 3)
{
    Console.WriteLine($"Opção escolhida: {opcao}"); continue;
}
else if (opcao == 4)
{
    Console.WriteLine($"Opção escolhida: {opcao}"); continue;
    //listarVeiculos();
    }
else if (opcao == 5)
{
    Console.WriteLine($"Opção escolhida: {opcao}"); continue;
}
else if (opcao == 6)
{
    Console.WriteLine($"Opção escolhida: {opcao}"); continue;
}
else if (opcao == 7)
{
    Console.WriteLine($"Opção escolhida: {opcao}"); continue;
}
else if (opcao == 8)
{
    Console.WriteLine("Adeus!"); break;
}
}




