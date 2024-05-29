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
        
            DespesasReceitas? menorDespesas = Manager.despesas.OrderBy(d => d.Valor).FirstOrDefault();
            DespesasReceitas? menorReceitas = Manager.receitas.OrderBy(d => d.Valor).FirstOrDefault();  

            if(menorDespesas != null && menorReceitas != null)
            {
                Console.WriteLine("Menor despesa: ");
                ExibirDetalhes(menorDespesas);
                Console.WriteLine("\nMenor receita:");
                ExibirDetalhes(menorReceitas);
            }
            else if(menorDespesas != null)
            {
                Console.WriteLine("Menor despesa: ");
                ExibirDetalhes(menorDespesas);
                Console.WriteLine("\nNenhuma receita adicionada!");
            }
            else if(menorReceitas != null)
            {
                Console.Write("Menor receita: ");
                ExibirDetalhes(menorReceitas);
                Console.WriteLine("\nNenhuma despesa adicionada!");
            }
            else
            {
                Console.WriteLine("Nenhuma despesa e receita foi adicionada!");
            }
        
        }

        public static void ExibirDetalhes(DespesasReceitas item)
        {
            Console.WriteLine($"Id: {item.Id}");
            Console.WriteLine($"Data: {item.Date}");
            Console.WriteLine($"Valor: {item.Valor}");
            Console.WriteLine($"Descrição: {item.Descricao}");
            Console.WriteLine($"Categoria: {item.Categoria}");
        }
    }
}
