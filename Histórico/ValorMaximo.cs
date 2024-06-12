using ControleDeGastos;
using ControleDeGastos.Managers;

namespace ControleGastos.Histórico
{
    internal class ValorMaximo
    {
        public void BucarValorMaximo()
        {;
            Console.WriteLine("Buscar por Valor Máximo\n");

            if (!Manager.despesas.Any() && !Manager.receitas.Any())
            {
                Console.WriteLine("Nenhuma despesa e receita foi adicionada!");
                return;
            }

            if(!Manager.despesas.Any())
            {
                Console.WriteLine("Não foi adicionado nenhuma despesa!");
            }
            else
            {
                float maiorDespesa = Manager.despesas.Max(d => d.Valor);
                Console.WriteLine("Maior Despesa:");
                List<DespesasReceitas> itemDespesa = Manager.despesas.Where(d => d.Valor == maiorDespesa).ToList();
                foreach (DespesasReceitas item in itemDespesa)
                {
                    Console.WriteLine($"Id: {item.Id}, Data: {item.Date}, Valor: R$-{item.Valor}, Descrição: {item.Descricao}, Categoria: {item.Categoria}");
                }
            }
            if(!Manager.receitas.Any())
            {
                Console.WriteLine("Não foi adicionado nenhuma receita!");
            }
            else
            {
                float maiorReceita = Manager.receitas.Max(d => d.Valor);
                Console.WriteLine("Maior Receita:");
                List<DespesasReceitas> itemReceita = Manager.receitas.Where(d => d.Valor == maiorReceita).ToList();
                foreach (DespesasReceitas item in itemReceita)
                {
                    Console.WriteLine($"Id: {item.Id}, Data: {item.Date}, Valor: R${item.Valor}, Descrição: {item.Descricao}, Categoria: {item.Categoria}");
                }
            }
        }
    }
}

