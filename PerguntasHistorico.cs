﻿using ControleDeGastos.Managers;
using ControleGastos.Histórico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleGastos
{
    public class PerguntasHistorico
    {
        public static void HistoricoPerguntas()
        {
            Manager Manager = new Manager();

            while (true)
            {
                Console.WriteLine("---- Histórico ----");
                Console.WriteLine("\nEscolha um método de filtragem:");
                Console.WriteLine("[1] - Por data (ex: 01/01/2022 à 01/01/2023)");
                Console.WriteLine("[2] - Valor mínimo");
                Console.WriteLine("[3] - Valor máximo");
                Console.WriteLine("[4] - Descrição");
                Console.WriteLine("[5] - Categoria");
                Console.WriteLine("[6] - Sair");
                string opcao = Console.ReadLine()!;

                switch (opcao)
                {
                    case "1":
                        Manager.BuscarRangeData();
                        break;
                    case "2":
                        Manager.BuscarValorMinimo();
                        break;
                    case "3":
                        Manager.BuscarValorMaximo();
                        break;
                    case "4":
                        break; 
                    case "5":
                        break;
                    case "6":
                        Console.Clear();
                        return;
                    default:
                        Console.WriteLine("Digite uma opção válida!");
                        break;

                }

            }

        }
    }
}