using ControleDeGastos;
using ControleDeGastos.Managers;
using ControleGastos.Funções;

namespace ControleGastos.Service
{
    internal class EditarFunction
    {
        string opcao = Program.RetornarOpcao();
        public void Editar()
        {
            Console.WriteLine("Editar\n");

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
            }
            else if (opcao == "2")
            {
                item = Manager.receitas.Find(d => d.Id == id);
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

            Console.WriteLine("Digite os novos valores");

            DespesasReceitas Valores = PegaValores.Valores();

            item.Date = Valores.Date;
            item.Valor = Valores.Valor;
            item.Descricao = Valores.Descricao;
            item.Categoria = Valores.Categoria;

            Console.Clear();
            Console.WriteLine($"{(opcao == "1" ? "Despesa" : "Receita")} atualizada com sucesso!");
            Console.WriteLine($"Id: {item.Id}, Data: {item.Date}, {(opcao == "1" ? $"Valor: R$-{item.Valor}" : $"Valor: R${item.Valor}")}, Descrição: {item.Descricao}, Categoria: {item.Categoria}");

        }
    }
}
