using ControleDeGastos;
using ControleDeGastos.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleGastos.Histórico
{
    internal class ValorMinimo
    {
        public void BuscarValorMinimo() {

            Console.WriteLine("Buscar por Valor Mínimo");

            if(!Manager.despesas.Any() && !Manager.receitas.Any()) {
                Console.WriteLine("Nenhuma despesa e receita foi adicionada!");
                return;
            }

            var menorDespesa = Manager.despesas.Any() ? Manager.despesas.Min(d => d.Valor) : (double?)null;
            var menorReceita = Manager.receitas.Any() ? Manager.receitas.Min(d => d.Valor) : (double?)null;

            Console.Clear();

            if (menorDespesa.HasValue)
            {
                Console.WriteLine("Menor Despesa:");
                var itemDespesa = Manager.despesas.First(d => d.Valor == menorDespesa.Value);
                Console.WriteLine($"Data: {itemDespesa.Date}, Valor: R$-{itemDespesa.Valor}, Descrição: {itemDespesa.Descricao}, Categoria: {itemDespesa.Categoria}");
            }
            else
            {
                Console.WriteLine("Não foi adicionado nenhuma despesa!");
            }

            if (menorReceita.HasValue)
            {
                Console.WriteLine("Menor Receita:");
                var itemReceita = Manager.receitas.First(d => d.Valor == menorReceita.Value);
                Console.WriteLine($"Data: {itemReceita.Date}, Valor: R${itemReceita.Valor}, Descrição: {itemReceita.Descricao}, Categoria: {itemReceita.Categoria}");
            }
            else
            {
                Console.WriteLine("Não foi adicionado nenhuma receita!");
            }
        }
    }
}
