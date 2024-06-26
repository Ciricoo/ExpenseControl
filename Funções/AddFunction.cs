﻿using ControleDeGastos.Managers;
using ControleGastos.Funções;

namespace ControleDeGastos.Service
{
    public class AddFunction
    {
        public static int idDespesas = 0;
        public static int idReceitas = 0;
        string opcao = Program.RetornarOpcao();
        public void Adicionar()
        {
            Console.WriteLine("Adicionar\n");

            DespesasReceitas Valores = PegaValores.Valores();

            if (opcao == "1")
            {
                idDespesas++;
                Valores.Id = idDespesas;
                Console.Clear();
                Console.WriteLine("Despesa adicionada com sucesso!");
                Manager.despesas.Add(new DespesasReceitas(Valores.Id, Valores.Date, Valores.Valor, Valores.Descricao, Valores.Categoria));
                Console.WriteLine($"Id: {Valores.Id} Data: {Valores.Date}, Valor: R$-{Valores.Valor}, Descrição: {Valores.Descricao}, Categoria: {Valores.Categoria}");
            }
            else if (opcao == "2")
            {
                idReceitas++;
                Valores.Id = idReceitas;
                Console.Clear();
                Console.WriteLine("Receita adicionada com sucesso!");
                Manager.receitas.Add(new DespesasReceitas(Valores.Id, Valores.Date, Valores.Valor, Valores.Descricao, Valores.Categoria));
                Console.WriteLine($"Id: {Valores.Id}, Data: {Valores.Date}, Valor: R${Valores.Valor}, Descrição: {Valores.Descricao}, Categoria: {Valores.Categoria}");
            }
        }
    }
}
