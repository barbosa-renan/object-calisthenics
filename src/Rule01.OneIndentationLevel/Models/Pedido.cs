namespace Rule01.OneIndentationLevel.Models;

public class Pedido
{
    public string NomeCliente { get; set; } = string.Empty;
    public List<Item> Itens { get; set; } = new();
}
