using ControleDeGastos.Managers;

namespace ControleGastos.Histórico
{
    internal class VizualizarTodos
    {
        public void BuscarTodos()
        {
            Console.WriteLine("Vizualizar Todos\n");
            if (!Manager.despesas.Any() && !Manager.receitas.Any())
            {
                Console.WriteLine("Nenhuma despesa e receita foi adicionada!");
                return;
            }

            if (!Manager.despesas.Any())
            {
                Console.WriteLine("Não foi adicionado nenhuma despesa!");
            }
            else
            {
                Console.WriteLine("Despesas:");
                Manager.despesas.ForEach(item => Console.WriteLine($"Id: {item.Id}, Data: {item.Date}, Valor: R$-{item.Valor}, Descrição: {item.Descricao}, Categoria: {item.Categoria}"));
            }

            if (!Manager.receitas.Any())
            {
                Console.WriteLine("Não foi adicionado nenhuma receita!");
            }
            else
            {
                Console.WriteLine("Receitas:");
                Manager.receitas.ForEach(item => Console.WriteLine($"Id: {item.Id}, Data: {item.Date}, Valor: R${item.Valor}, Descrição: {item.Descricao}, Categoria: {item.Categoria}"));
            }

        }
    }
}
