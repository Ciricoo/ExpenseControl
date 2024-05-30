﻿using ControleGastos;
using System;

namespace ControleDeGastos
{
    public class Program
    {
        private static string opcao = "";
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Bem Vindo ao Sistema de Controle de Gastos!");
                Console.WriteLine("\n[1] - Despesas");
                Console.WriteLine("[2] - Receitas");
                Console.WriteLine("[3] - Histórico");
                Console.WriteLine("[4] - Sair");
                Console.Write("Opção: ");
                opcao = Console.ReadLine()!;


                switch (opcao)
                {
                    case "1":
                        Console.Clear();
                        Perguntas.Despesas();
                        break;
                    case "2":
                        Console.Clear();
                        Perguntas.Receitas();
                        break;
                    case "3":
                        Console.Clear();
                        PerguntasHistorico.HistoricoPerguntas();
                        break;
                    case "4":
                        Console.WriteLine("Saindo do programa!");
                        return;
                    default:
                        Console.WriteLine("Digite uma opção válida!");
                        break;
                }
            }
        }
        public static string RetornarOpcao()
        {
            return opcao;
        }
    }
}