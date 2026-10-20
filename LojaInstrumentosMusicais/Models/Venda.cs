using System;
using System.Collections.Generic;
using System.Text;

namespace LojaInstrumentosMusicais.Models
{
    public class Venda
    {
        public string Cliente;
        public decimal Preco;
        public string Instrumento;
        public decimal Total;
        public decimal OutroPreco;

        public string cliente
        {
            get => Cliente; set => Cliente = value;
        }
        public decimal preco
        {
            get => Preco; set => Preco = value > 0 ? value : 0;
        }
        public string instrumento
        {
            get => Instrumento; set => Instrumento = value;
        }
        public decimal total
        {
            get => Total; set => Total = value > 0 ? value : 0;
        }

        public decimal outropreco
        {
            get => OutroPreco; set => OutroPreco = value > 0 ? value : 0;
        }

        public Venda(string cliente, decimal preco, string instrumento,
                     decimal total, decimal outroPreco)
        {
            Cliente = cliente;
            Preco = preco > 0 ? preco : 0;
            Instrumento = instrumento;
            Total = total > 0 ? total : 0;
            OutroPreco = outroPreco > 0 ? outroPreco : 0;
        }

        public virtual decimal CalcularTotal()
        {
            return Total = Preco + OutroPreco;
        }
    }
}
