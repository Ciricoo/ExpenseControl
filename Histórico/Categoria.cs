using ControleDeGastos.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleGastos.Histórico
{
    internal class Categoria
    {
        public void BuscarCategoria()
        {
            bool encontrado = false;
            string categoria;
            Console.WriteLine("Buscar por Categoria");
            while (true)
            {
                Console.WriteLine("Digite a categoria que deseja buscar:");
                categoria = Console.ReadLine()!.Trim();
                if (string.IsNullOrEmpty(categoria))
                {
                    Console.WriteLine("A categoria não pode ser vazia!");
                }
                else
                {
                    break;
                }
            }

            if (!Manager.despesas.Any() && !Manager.receitas.Any())
            {
                Console.WriteLine("Não existem despesas e receitas na lista!");
                return;
            }


            Console.Clear();

            foreach (var item in Manager.despesas)
            {
                if (item.Categoria.Equals(categoria, StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("Despesa:");
                    Console.WriteLine($"Data: {item.Date}, Valor: R$-{item.Valor}, Descrição: {item.Descricao}, Categoria: {item.Categoria}");
                    encontrado = true;
                }
            }
            foreach (var item in Manager.receitas)
            {
                if (item.Categoria.Equals(categoria, StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("Receita:");
                    Console.WriteLine($"Data: {item.Date}, Valor: R${item.Valor}, Descrição: {item.Descricao}, Categoria: {item.Categoria}");
                    encontrado = true;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("Não foi possível encontrar despesas e receitas com essa descrição!");
            }
        }
    }
}
