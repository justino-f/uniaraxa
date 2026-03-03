namespace Aula03;

internal class Program
{
  static void Main(string[] args)
  {
    string rawString = """
    [1] - Cadastrar Produto
    [2] - Cadastrar Loja
    [3] - Cadastrar Cliente
    [4] - Cadastrar Pedido
    [5] - Calcular Pedido
    [0] - Sair
    : 
    """;
    Produto? produto = null;
    Loja? loja = null;
    Cliente? cliente = null;
    Pedido? pedido = null;

    int input = -1;
    while (input != 0)
    {
      Console.Clear();
      Console.Write(rawString);
      input = int.Parse(Console.ReadLine()!);

      switch (input)
      {
        case 1:
          Console.Clear();
          produto = new Produto();
          Console.Write("Insira o nome do produto: ");
          produto.Nome = Console.ReadLine()!;
          Console.Write("Insira o preço do produto: ");
          produto.Preco = double.Parse(Console.ReadLine()!);
          Console.Write("Insira a categoria do produto: ");
          produto.Categoria = Console.ReadLine()!;
          Console.Write("Insira o peso do produto: ");
          produto.Peso = double.Parse(Console.ReadLine()!);
          break;

        case 2:
          Console.Clear();
          loja = new Loja();
          Console.Write("Insira o nome da loja: ");
          loja.Nome = Console.ReadLine()!;
          Console.Write("Insira a cidade da loja: ");
          loja.Cidade = Console.ReadLine()!;
          Console.Write("Insira a taxa de entrega: ");
          loja.TaxaEntrega = double.Parse(Console.ReadLine()!);
          break;

        case 3:
          Console.Clear();
          cliente = new Cliente();
          Console.Write("Insira o nome do cliente: ");
          cliente.Nome = Console.ReadLine()!;
          Console.Write("Insira a cidade do cliente: ");
          cliente.Cidade = Console.ReadLine()!;
          Console.Write("Insira a idade do cliente: ");
          cliente.Idade = int.Parse(Console.ReadLine()!);
          break;

        case 4:
          Console.Clear();
          pedido = new Pedido();
          Console.Write("Insira o número do pedido: ");
          pedido.NumeroPedido = int.Parse(Console.ReadLine()!);
          Console.Write("Insira a quantidade de itens: ");
          pedido.Quantidade = int.Parse(Console.ReadLine()!);
          Console.Write("Insira o desconto percentual: ");
          pedido.DescontoPercentual = double.Parse(Console.ReadLine()!);
          break;

        case 5:
          Console.Clear();

          if (produto is null || loja is null || cliente is null || pedido is null)
          {
            Console.WriteLine("Cadastre Produto, Loja, Cliente e Pedido antes de calcular.");
            Console.ReadKey();
            break;
          }

          double valorBruto = produto.Preco * pedido.Quantidade;
          double valorDesconto = valorBruto * (pedido.DescontoPercentual / 100);
          double valorFinal = valorBruto - valorDesconto;
          double valorTotal = valorFinal + loja.TaxaEntrega;
          double pesoTotal = produto.Peso * pedido.Quantidade;

          if (cliente.Idade < 18) valorTotal *= 0.95;
          else if (pesoTotal > 10) valorTotal += 10;

          Console.WriteLine($"\nValor Bruto: R${valorBruto} | Valor Desconto: R${valorDesconto} | Valor Final: R${valorFinal} | Valor Total: R${valorTotal} | Peso Total: {pesoTotal}");
          Console.ReadKey();
          break;
      }
    }

    Console.Clear();

  }
}