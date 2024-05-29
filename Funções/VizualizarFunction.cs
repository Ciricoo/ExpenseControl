using ControleDeGastos.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeGastos.Service
{
    internal class VizualizarFunction
    {
        public void Vizualizar()
        {
            int contagem = 0;
            string opcao = Program.RetornarOpcao();

            Console.WriteLine("---- Vizualizar ----");

            if (opcao == "1")
            {
                Console.WriteLine("Despesas:");
                foreach (var item in Manager.despesas)
                {
                    Console.WriteLine($"Id: {item.Id}, Data: {item.Date}, Valor: R$-{item.Valor}, Descrição: {item.Descricao}, Categoria: {item.Categoria}");
                    contagem++;
                }

                if (contagem == 0) {
                    Console.WriteLine("Não foi adicionado nenhuma despesa!");
                }
            }
            else if (opcao == "2")
            {
                contagem = 0;
                Console.WriteLine("Receitas:");
                foreach (var item in Manager.receitas)
                {
                    Console.WriteLine($"Id: {item.Id}, Data: {item.Date}, Valor: R${item.Valor}, Descrição: {item.Descricao}, Categoria: {item.Categoria}");
                    contagem++;
                }

                if (contagem == 0)
                {
                    Console.WriteLine("Não foi adicionado nenhuma receita!");
                }
            }

        }
    }
}
