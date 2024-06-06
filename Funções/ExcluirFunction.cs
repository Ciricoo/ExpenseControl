using ControleDeGastos;
using ControleDeGastos.Managers;

namespace ControleGastos.Service
{
    internal class ExcluirFunction
    {
        string opcao = Program.RetornarOpcao();
        public void Excluir() {

            Console.WriteLine("Excluir\n");

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
                Console.WriteLine($"{(opcao == "1" ? "Despesa" : "Receita")} não encontrada!");
                return;
            }
            Console.Clear();
            Console.WriteLine($"{(opcao == "1" ? "Despesa" : "Receita")} removida com sucesso!");
            Console.WriteLine($"Data: {item!.Date}, {(opcao == "1" ? $"Valor: R$-{item.Valor}" : $"Valor: R${item.Valor}")}, Descrição: {item.Descricao}, Categoria: {item.Categoria}");
            
        }
    }
}
