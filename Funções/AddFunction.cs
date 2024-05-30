using ControleDeGastos.Managers;
using ControleGastos.Funções;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeGastos.Service
{
    public class AddFunction
    {

        public void Adicionar()
        {
            string opcao = Program.RetornarOpcao();
            Console.WriteLine("Adicionar");

            var Valores = PegaValores.Valores();

            if (opcao == "1")
            {
                Console.Clear();
                Console.WriteLine("Despesa adicionada com sucesso!");
                Manager.despesas.Add(new DespesasReceitas(Valores.Id, Valores.Date, Valores.Valor, Valores.Descricao, Valores.Categoria));
                Console.WriteLine($"Data: {Valores.Date}, Valor: R$-{Valores.Valor}, Descrição: {Valores.Descricao}, Categoria: {Valores.Categoria}");
            }
            else if (opcao == "2")
            {
                Console.Clear();
                Console.WriteLine("Receita adicionada com sucesso!");
                Manager.receitas.Add(new DespesasReceitas(Valores.Id, Valores.Date, Valores.Valor, Valores.Descricao, Valores.Categoria));
                Console.WriteLine($"Data: {Valores.Date}, Valor: R${Valores.Valor}, Descrição: {Valores.Descricao}, Categoria: {Valores.Categoria}");
            }
        }
    }
}
