using ControleDeGastos;
using ControleDeGastos.Managers;

namespace ControleGastos.Histórico
{
    internal class ValorMinimo
    {
        public void BuscarValorMinimo() {

            Console.WriteLine("Buscar por Valor Mínimo\n");

            if(!Manager.despesas.Any() && !Manager.receitas.Any()) {
                Console.WriteLine("Nenhuma despesa e receita foi adicionada!");
                return;
            }

            if (!Manager.despesas.Any())
            {
                Console.WriteLine("Não foi adicionado nenhuma despesa!");
            }
            else
            {
                float menorDespesa = Manager.despesas.Min(d => d.Valor);
                Console.WriteLine("Menor Despesa:");
                List<DespesasReceitas> itemDespesa = Manager.despesas.Where(d => d.Valor == menorDespesa).ToList();
                foreach (DespesasReceitas item in itemDespesa)
                {
                    Console.WriteLine($"Id: {item.Id}, Data: {item.Date}, Valor: R$-{item.Valor}, Descrição: {item.Descricao}, Categoria: {item.Categoria}");
                }
                
            }

            if (!Manager.receitas.Any())
            {
                Console.WriteLine("Não foi adicionado nenhuma receita!");
            }
            else
            {
                float menorReceita = Manager.receitas.Min(d => d.Valor);
                Console.WriteLine("Menor Receita:");
                List<DespesasReceitas> itemReceita = Manager.receitas.Where(d => d.Valor == menorReceita).ToList();
                foreach (DespesasReceitas item in itemReceita)
                {
                    Console.WriteLine($"Id: {item.Id}, Data: {item.Date}, Valor: R${item.Valor}, Descrição: {item.Descricao}, Categoria: {item.Categoria}");
                }
                
            }
        }
    }
}
