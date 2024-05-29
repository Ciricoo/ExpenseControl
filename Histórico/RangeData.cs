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
            bool verificaData = true;
            DateOnly dataInicial;
            DateOnly dataFinal;
            bool encontrou = false;
            while (verificaData)
            {
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
                    verificaData = false;
                }
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

            if(Manager.despesas.Count <= 0 && Manager.receitas.Count <= 0)
            {
                Console.WriteLine("Não existem item na lista!");
            }
            else if (!encontrou)
            {
                Console.WriteLine("Não foi encontrado Despesas ou Receitas nas Datas estipuladas!");
            }
        }
    }
}
