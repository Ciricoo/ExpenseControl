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
            Console.WriteLine("Buscar por Categoria");
            Console.WriteLine("Digite a categoria que deseja buscar:");
            string categoria = Console.ReadLine()!;
            bool encontrado = false;

            Console.Clear();

            foreach (var item in Manager.despesas)
            {
                if (item.Categoria.Equals(categoria, StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("Despesa:");
                    Console.WriteLine($"Data: {item.Date}, Valor: {item.Valor}, Descrição: {item.Descricao}, Categoria: {item.Categoria}");
                    encontrado = true;
                }
            }
            foreach (var item in Manager.receitas)
            {
                if (item.Categoria.Equals(categoria, StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("Receita:");
                    Console.WriteLine($"Data: {item.Date}, Valor: {item.Valor}, Descrição: {item.Descricao}, Categoria: {item.Categoria}");
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
