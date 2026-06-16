using System.Globalization;
using Rule01.OneIndentationLevel.Models;
using Rule01.OneIndentationLevel.Services;

Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("pt-BR");
Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("pt-BR");

var service = new PedidoService();

var pedido = new Pedido
{
    NomeCliente = "Fernanda",
    Itens = new List<Item>
    {
        new Item { Nome = "Monitor", Preco = 400.00m, Quantidade = 2 }
    }
};

Console.WriteLine($"Resultado: {service.ProcessarPedido(pedido)}");
Console.ReadKey();
