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
        {
            Console.WriteLine("Buscar por Valor Máximo");

            if (!Manager.despesas.Any() && !Manager.receitas.Any())
            {
                Console.WriteLine("Nenhuma despesa ou receita foi adicionada!");
                return;
            }

            var maiorDespesa = Manager.despesas.Any() ? Manager.despesas.Max(d => d.Valor) : (double?)null;
            var maiorReceita = Manager.receitas.Any() ? Manager.receitas.Max(d => d.Valor) : (double?)null;

            if (maiorDespesa.HasValue)
            {
                Console.Clear();
                Console.WriteLine("Maior Despesa:");
                ValorMinimo.ExibirDetalhes(Manager.despesas.First(d => d.Valor == maiorDespesa.Value));
            }
            else
            {
                Console.WriteLine("Não foi adicionado nenhuma despesa!");
            }

            Console.WriteLine();

            if (maiorReceita.HasValue)
            {
                Console.Clear();
                Console.WriteLine("Maior Receita:");
                ValorMinimo.ExibirDetalhes(Manager.receitas.First(d => d.Valor == maiorReceita.Value));
            }
            else
            {
                Console.WriteLine("Não foi adicionado nenhuma despesa!");
            }
        }
    }
}

