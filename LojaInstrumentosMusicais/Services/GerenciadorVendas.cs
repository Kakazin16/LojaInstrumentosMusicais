using System.Collections.Generic;
using System.Linq;
using LojaInstrumentosMusicais.Models;

namespace LojaInstrumentosMusicais.Services
{
    public class GerenciadorVendas
    {
        private List<Venda> vendas = new List<Venda>();

        public void CadastrarVenda(Venda venda)
        {
            venda.CalcularTotal();
            vendas.Add(venda);
        }

        public List<Venda> ListarVendas()
        {
            return vendas;
        }

        public Venda BuscarVenda(string cliente)
        {
            return vendas.FirstOrDefault(
                v => v.Cliente == cliente
            );
        }

        public decimal CalcularFaturamento()
        {
            return vendas.Sum(v => v.Total);
        }

        public int QuantidadeVendas()
        {
            return vendas.Count;
        }
    }
}