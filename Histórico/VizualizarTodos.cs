using ControleDeGastos.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleGastos.Histórico
{
    internal class VizualizarTodos
    {
        public void BuscarTodos()
        {
            if (!Manager.despesas.Any() && !Manager.receitas.Any())
            {
                Console.WriteLine("Nenhuma despesa e receita foi adicionada!");
                return;
            }

            Console.Clear();
            Console.WriteLine("Despesas:");
            Manager.despesas.ForEach(item => Console.WriteLine($"Id: {item.Id}, Data: {item.Date}, Valor: R$-{item.Valor}, Descrição: {item.Descricao}, Categoria: {item.Categoria}"));

            if (Manager.despesas.Count == 0)
            {
                Console.WriteLine("Não foi adicionado nenhuma despesa!");
            }

            Console.WriteLine("Receitas:");
            Manager.receitas.ForEach(item => Console.WriteLine($"Id: {item.Id}, Data: {item.Date}, Valor: R${item.Valor}, Descrição: {item.Descricao}, Categoria: {item.Categoria}"));

            if (Manager.receitas.Count == 0)
            {
                Console.WriteLine("Não foi adicionado nenhuma receita!");
            }
        }
    }
}
