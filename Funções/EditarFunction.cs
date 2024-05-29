using ControleDeGastos;
using ControleDeGastos.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleGastos.Service
{
    internal class EditarFunction
    {
        string opcao = Program.RetornarOpcao();
        public void Editar() {
            Console.WriteLine("---- Editar ----");

            Console.WriteLine("Digite o Id que deseja editar:");
            int id = int.Parse(Console.ReadLine()!);

            DespesasReceitas? item;

            if(opcao == "1")
            {
                item = Manager.despesas.FirstOrDefault(d => d.Id == id);
            }
            else if(opcao == "2")
            {
                item = Manager.receitas.FirstOrDefault(d => d.Id == id);
            }
            else
            {
                Console.WriteLine("Opção inválida!");
                return;
            }

            if( item == null)
            {
                Console.WriteLine($"{(opcao == "1" ? "Desepesa" : "Receita")} não encontrada!");
                return;
            }

            Console.WriteLine("Digite os novos valores");

            Console.WriteLine("\nData: (dd/MM/yyyy):");
            string data = Console.ReadLine()!;

            if (!DateOnly.TryParse(data, out DateOnly dataTime))
            {
                Console.WriteLine("Formato inválido, por favor use o formato (dd/MM/yyyy)");
            }

            Console.WriteLine("Valor:");
            float valor = float.Parse(Console.ReadLine()!);
            Console.WriteLine("Descrição:");
            string descricao = Console.ReadLine()!;
            Console.WriteLine("Categoria:");
            string categoria = Console.ReadLine()!;

            item.Date = dataTime;
            item.Valor = valor;
            item.Descricao = descricao;
            item.Categoria = categoria;

            Console.Clear();
            Console.WriteLine($"Data: {item.Date}, Valor: {item.Valor}, Descrição: {item.Descricao}, Categoria: {item.Categoria}");
            Console.WriteLine($"{(opcao == "1" ? "Despesa" : "Receita")} atualizada com sucesso!");
        }
    }
}
