using ControleDeGastos.Managers;
using ControleDeGastos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleGastos.Histórico
{
    internal class ValorMaximo
    {
        public void BucarValorMaximo()
        {;
            Console.WriteLine("Buscar por Valor Máximo");

            if (!Manager.despesas.Any() && !Manager.receitas.Any())
            {
                Console.WriteLine("Nenhuma despesa e receita foi adicionada!");
                return;
            }

            var maiorDespesa = Manager.despesas.Any() ? Manager.despesas.Max(d => d.Valor) : (double?)null;
            var maiorReceita = Manager.receitas.Any() ? Manager.receitas.Max(d => d.Valor) : (double?)null;

            Console.Clear();

            if( maiorDespesa.HasValue )
            {
                Console.WriteLine("Maior Despesa:");
                var itemDespesa = Manager.despesas.First(d => d.Valor == maiorDespesa.Value);
                Console.WriteLine($"Data: {itemDespesa.Date}, Valor: R$-{itemDespesa.Valor}, Descrição: {itemDespesa.Descricao}, Categoria: {itemDespesa.Categoria}");
            }
            else
            {
                Console.WriteLine("Não foi adicionado nenhuma despesa!");
            }
            if( maiorReceita.HasValue )
            {
                Console.WriteLine("Maior Receita:");
                var itemReceita = Manager.receitas.First(d => d.Valor == maiorReceita.Value);
                Console.WriteLine($"Data: {itemReceita.Date}, Valor: R${itemReceita.Valor}, Descrição: {itemReceita.Descricao}, Categoria: {itemReceita.Categoria}");
            }
            else
            {
                Console.WriteLine("Não foi adicionado nenhuma receita!");
            }
        }
    }
}

