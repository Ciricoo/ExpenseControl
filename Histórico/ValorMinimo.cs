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
                Console.WriteLine("Nenhuma despesa ou receita foi adicionada!");
                return;
            }

            var menorDespesa = Manager.despesas.Any() ? Manager.despesas.Min(d => d.Valor) : (double?)null;
            var menorReceita = Manager.receitas.Any() ? Manager.receitas.Min(d => d.Valor) : (double?)null;

            if (menorDespesa.HasValue)
            {
                Console.Clear();
                Console.WriteLine("Menor Despesa:");
                ExibirDetalhes(Manager.despesas.First(d => d.Valor == menorDespesa.Value));
            }
            else
            {
                Console.WriteLine("Não foi adicionado nenhuma despesa!");
            }

            Console.WriteLine();

            if (menorReceita.HasValue)
            {
                Console.Clear();
                Console.WriteLine("Menor Receita:");
                ExibirDetalhes(Manager.receitas.First(d => d.Valor == menorReceita.Value));
            }
            else
            {
                Console.WriteLine("Não foi adicionado nenhuma despesa!");
            }
        }

        public static void ExibirDetalhes(DespesasReceitas item)
        {
            Console.WriteLine($"Data: {item.Date}, Valor: {item.Valor}, Descrição: {item.Descricao}, Categoria: {item.Categoria}");
        }
    }
}
