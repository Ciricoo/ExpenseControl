using ControleDeGastos;
using ControleDeGastos.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleGastos.Histórico
{
    internal class RangeData
    {
        public void BuscarDatas()
        {
            DateOnly dataInicial;
            DateOnly dataFinal;
            bool encontrou = false;
            while (true)
            {
                Console.WriteLine("Buscar por Range de Datas");

                Console.WriteLine("Data inicial: (dd/MM/yyyy)");
                string data1 = Console.ReadLine()!;
                Console.WriteLine("Data final: (dd/MM/yyyy)");
                string data2 = Console.ReadLine()!;

                if (!DateOnly.TryParse(data1, out dataInicial) || !DateOnly.TryParse(data2, out dataFinal))
                {
                    Console.WriteLine("Data inválida, use o formato: (dd/MM/yyyy)");
                }

                else
                {
                    break;
                }
            }
            Console.Clear();

            if (!Manager.despesas.Any() && !Manager.receitas.Any())
            {
                Console.WriteLine("Não existem despesas e receitas na lista!");
                return;
            }

            foreach (DespesasReceitas item in Manager.despesas)
            {
                if (item.Date >= dataInicial && item.Date <= dataFinal)
                {
                    encontrou = true;
                    Console.Write("\nDespesa:");
                    Console.WriteLine($"Data: {item.Date}, Valor: R$-{item.Valor}, Descrição: {item.Descricao}, Categoria: {item.Categoria}");
                }
            }

            foreach (DespesasReceitas item in Manager.receitas)
            {
                if (item.Date >= dataInicial && item.Date <= dataFinal)
                {
                    encontrou = true;
                    Console.Write("\nReceita:");
                    Console.WriteLine($"Data: {item.Date}, Valor: R${item.Valor}, Descrição: {item.Descricao}, Categoria: {item.Categoria}");
                }
            }
      
            if (!encontrou)
            {
                Console.WriteLine("Não foi encontrado Despesas ou Receitas nas Datas estipuladas!");
            }
        }
    }
}
