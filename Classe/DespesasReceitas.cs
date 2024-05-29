using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeGastos
{
    public class DespesasReceitas
    {
        public int Id { get; set; }
        public DateOnly Date { get; set; }
        public float Valor { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }

        public DespesasReceitas(int id, DateOnly date, float valor, string descricao, string categoria)
        {
            Id = id;
            Date = date;
            Valor = valor;
            Descricao = descricao;
            Categoria = categoria;
        }



    }
}
