﻿using ControleDeGastos;

namespace ControleGastos.Funções
{
    internal class PegaValores
    {
        public static DespesasReceitas Valores()
        {
            DateOnly dataTime;
            float valor;
            string categoria;
            string descricao;

            while (true)
            {
                while (true)
                {
                    Console.WriteLine("Data: (dd/MM/yyyy):");
                    string data = Console.ReadLine()!.Trim();

                    if (!DateOnly.TryParse(data, out dataTime))
                    {
                        Console.WriteLine("Formato inválido, por favor use o formato (dd/MM/yyyy)");
                    }
                    else
                    {
                        break;
                    }
                }

                while (true)
                {
                    Console.WriteLine("Valor:");
                    string valorString = Console.ReadLine()!.Trim();

                    if (string.IsNullOrEmpty(valorString) || !float.TryParse(valorString, out valor))
                    {

                        Console.WriteLine("Valor inválido!");
                        continue;
                    }
                    else if(valor <= 0)
                    {
                        Console.WriteLine("Não pode ser adicionado um valor negativo ou sem valor!");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }

                while (true)
                {
                    Console.WriteLine("Descrição:");
                     descricao = Console.ReadLine()!.Trim();

                    if (string.IsNullOrEmpty(descricao))
                    {
                        Console.WriteLine("Descrição não pode ser vazia!");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                while (true)
                {
                    Console.WriteLine("Categoria:");
                    categoria = Console.ReadLine()!.Trim();

                    if (string.IsNullOrEmpty(categoria))
                    {

                        Console.WriteLine("Categoria não pode ser vazia!");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }

                return new DespesasReceitas(0, dataTime, valor, descricao, categoria);
            }
        }
    }
}
