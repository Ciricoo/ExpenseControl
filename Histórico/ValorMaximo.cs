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
            DespesasReceitas? maiorDespesas = Manager.despesas.OrderByDescending(d => d.Valor).FirstOrDefault();
            DespesasReceitas? maiorReceitas = Manager.receitas.OrderByDescending(d => d.Valor).FirstOrDefault();


            if(maiorDespesas != null && maiorReceitas != null)
            {
                Console.WriteLine("Menor despesa: ");
                ValorMinimo.ExibirDetalhes(maiorDespesas);
                Console.WriteLine("\nMenor receita:");
                ValorMinimo.ExibirDetalhes(maiorReceitas);
            }
            else if (maiorDespesas != null)
            {
                Console.WriteLine("Menor despesa: ");
                ValorMinimo.ExibirDetalhes(maiorDespesas);
                Console.WriteLine("\nNenhuma receita adicionada!");
            }
            else if (maiorReceitas != null)
            {
                Console.Write("Menor receita: ");
                ValorMinimo.ExibirDetalhes(maiorReceitas);
                Console.WriteLine("\nNenhuma despesa adicionada!");
            }
            else
            {
                Console.WriteLine("Nenhuma despesa e receita foi adicionada!");
            }

        }

    }
}
