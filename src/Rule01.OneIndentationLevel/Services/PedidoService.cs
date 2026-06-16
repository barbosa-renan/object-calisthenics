using Rule01.OneIndentationLevel.Models;

namespace Rule01.OneIndentationLevel.Services;

public class PedidoService
{
    public string ProcessarPedido(Pedido pedido)
    {
        // TODO: Refatorar — complexidade ciclomática muito alta
        string resultado;

        if (pedido == null)
        {
            resultado = "Pedido nulo";
        }
        else
        {
            if (pedido.Itens == null || pedido.Itens.Count == 0)
            {
                resultado = "Pedido sem itens";
            }
            else
            {
                decimal total = 0;
                bool invalido = false;
                string mensagemErro = string.Empty;

                foreach (var item in pedido.Itens)
                {
                    if (item.Preco <= 0)
                    {
                        invalido = true;
                        mensagemErro = "Preço inválido";
                    }
                    else
                    {
                        if (item.Quantidade <= 0)
                        {
                            invalido = true;
                            mensagemErro = "Quantidade inválida";
                        }
                        else
                        {
                            total += item.Preco * item.Quantidade;
                        }
                    }
                }

                if (invalido)
                {
                    resultado = mensagemErro;
                }
                else
                {
                    if (total < 100)
                    {
                        resultado = "Pedido abaixo do mínimo";
                    }
                    else
                    {
                        if (total <= 500)
                        {
                            resultado = $"Pedido aprovado. Total: {total:C}";
                        }
                        else
                        {
                            if (total <= 1000)
                            {
                                resultado = $"Aprovado com 10% de desconto. Total: {total * 0.9m:C}";
                            }
                            else
                            {
                                resultado = $"Aprovado com 15% de desconto. Total: {total * 0.85m:C}";
                            }
                        }
                    }
                }
            }
        }

        return resultado;
    }
}
