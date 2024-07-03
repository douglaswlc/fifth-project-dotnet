
// int numero = 7;

// for(int contador = 1; contador <= 10; contador++)
// {
//   Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }

// int numero = 7;
// int contador = 0;

// while (contador <= 10)
// {
//   Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//   contador++;
// }


// int soma = 0, numero = 0;

// do
// {
//   Console.WriteLine("Digite um valor (0 para parar)");
//   numero = Convert.ToInt32(Console.ReadLine());

//   soma += numero;

// } while(numero != 0);

// Console.WriteLine($"Total de soma dos números digitador é: {soma}");


string opcao;
bool exibirMenu = true;

while(exibirMenu)
{
  Console.Clear();
  Console.WriteLine("Digite a opção:");
  Console.WriteLine("1 - Cadastras cliente");
  Console.WriteLine("2 - Buscar Cliente");
  Console.WriteLine("3 - Apagar Cliente");
  Console.WriteLine("4 - Encerrar");

  opcao = Console.ReadLine();

  switch(opcao)
  {
    case "1":
      Console.WriteLine("Cadastro de cliente");
      break;

    case "2":
      Console.WriteLine("Buscar Cliente");
      break;

    case "3":
      Console.WriteLine("Apagar Cliente");
      break;

    case "4":
      Console.WriteLine("Encerrar");
      exibirMenu = false;
      break;

    default:
      Console.WriteLine("Opção inválida");
      break;
  }
}