using ControleDeGastos;
using ControleDeGastos.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleGastos.Service
{
    internal class ExcluirFunction
    {
        string opcao = Program.RetornarOpcao();
        public void Excluir() {

            Console.WriteLine("Excluir");

            Console.WriteLine("Digite o Id que deseja editar:");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Id inválido!");
                return;
            }

            DespesasReceitas? item;

            if (opcao == "1")
            {
                item = Manager.despesas.Find(d => d.Id == id);
                Manager.despesas.Remove(item!);
            }
            else if (opcao == "2")
            {
                item = Manager.receitas.Find(d => d.Id == id);
                Manager.despesas.Remove(item!);
            }
            else
            {
                Console.WriteLine("Opção inválida!");
                return;
            }

            if (item == null)
            {
                Console.WriteLine($"{(opcao == "1" ? "Despesa" : "Receit a")} não encontrada!");
                return;
            }
            Console.Clear();
            Console.WriteLine($"Data: {item!.Date}, {(opcao == "1" ? $"Valor: R$-{item.Valor}" : $"Valor: R${item.Valor}")}, Descrição: {item.Descricao}, Categoria: {item.Categoria}");
            Console.WriteLine($"{(opcao == "1" ? "Despesa" : "Receita")} removida com sucesso!");
        }
    }
}
