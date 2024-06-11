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
                DespesasReceitas itemDespesa = Manager.despesas.First(d => d.Valor == menorDespesa);
                Console.WriteLine($"Data: {itemDespesa.Date}, Valor: R$-{itemDespesa.Valor}, Descrição: {itemDespesa.Descricao}, Categoria: {itemDespesa.Categoria}");
            }

            if (!Manager.receitas.Any())
            {
                Console.WriteLine("Não foi adicionado nenhuma receita!");
            }
            else
            {
                float menorReceita = Manager.receitas.Min(d => d.Valor);
                Console.WriteLine("Menor Receita:");
                DespesasReceitas itemReceita = Manager.receitas.First(d => d.Valor == menorReceita);
                Console.WriteLine($"Data: {itemReceita.Date}, Valor: R${itemReceita.Valor}, Descrição: {itemReceita.Descricao}, Categoria: {itemReceita.Categoria}");
            }
        }
    }
}
