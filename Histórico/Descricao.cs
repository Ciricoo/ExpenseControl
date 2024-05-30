using ControleDeGastos;
using ControleDeGastos.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleGastos.Histórico
{
    internal class Descricao
    {
        public void BuscarDescricao()
        {
            bool encontrado = false;
            string descricao;
            Console.WriteLine("Buscar por Descrição");
            while (true)
            {
                Console.WriteLine("Digite a descrição que deseja buscar:");
                descricao = Console.ReadLine()!.Trim();
                if (string.IsNullOrEmpty(descricao))
                {
                    Console.WriteLine("A descrição não pode ser vazia!");
                }
                else
                {
                    break;
                }
            }

            Console.Clear();

            if(!Manager.despesas.Any() && !Manager.receitas.Any()) {
                Console.WriteLine("Não existem despesas e receitas na lista!");
                return;
            }

            foreach (var item in Manager.despesas)
            {
                if(item.Descricao.Equals(descricao, StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("Despesa:");
                    Console.WriteLine($"Data: {item.Date}, Valor: {item.Valor}, Descrição: {item.Descricao}, Categoria: {item.Categoria}");
                    encontrado = true;
                }
            }
            foreach (var item in Manager.receitas)
            {
                if (item.Descricao.Equals(descricao, StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("Receita:");
                    Console.WriteLine($"Data: {item.Date}, Valor: {item.Valor}, Descrição: {item.Descricao}, Categoria: {item.Categoria}");
                    encontrado = true;
                }
            }

            if (!encontrado) {
                Console.WriteLine("Não foi possível encontrar despesas e receitas com essa descrição!");
            }

        }
    }
}
