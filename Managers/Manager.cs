using ControleDeGastos.Service;
using ControleGastos.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeGastos.Managers
{
    public class Manager
    {
        AddFunction AddFuncion = new AddFunction();
        VizualizarFunction VizualizarFunction = new VizualizarFunction();
        EditarFunction EditarFunction = new EditarFunction();
        ExcluirFunction ExcluirFunction = new ExcluirFunction();

        public static List<DespesasReceitas> despesas = new List<DespesasReceitas>();
        public static List<DespesasReceitas> receitas = new List<DespesasReceitas>();

        public void Adicionar()
        {
            Console.Clear();
            AddFuncion.Adicionar();
        }

        public void Vizualizar()
        {
            Console.Clear();
            VizualizarFunction.Vizualizar();
        }

        public void Editar()
        {
            Console.Clear();
            EditarFunction.Editar();
        }

        public void Excluir()
        {
            Console.Clear();
            ExcluirFunction.Excluir();
        }
    }
}
