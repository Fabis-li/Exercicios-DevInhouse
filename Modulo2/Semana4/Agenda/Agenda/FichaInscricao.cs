using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public class FichaInscricao
    {
        public string Nome { get; set; }
        public int Idade { get; }
        public string Curso { get; set; }
        public string Escolaridade { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public decimal ValorCurso { get; set; }
        public decimal ValorDeDesconto { get; set; }
        public decimal ValorMulta { get; set; }

        public FichaInscricao(string nome, string curso, string escolaridade,
                             DateTime dataDeNascimento, decimal valorCurso,
                             decimal valorDeDesconto, decimal valorMulta)
        {
            Nome = nome;            
            Curso = curso;
            Escolaridade = escolaridade;
            DataDeNascimento = dataDeNascimento;
            ValorCurso = valorCurso;
            ValorDeDesconto = valorDeDesconto;
            ValorMulta = valorMulta;
            Idade = CalcularIdade();


        }

        internal int CalcularIdade()
        {
           return  DateTime.Now.Year - Convert.ToDateTime(DataDeNascimento).Year;
        }

        
    }

    /* var idade = 0;
            idade = DateTime.Today.Year - dataDeNascimento.Year;
            if (DateTime.Today.DayOfYear < dataDeNascimento.DayOfYear)
                idade = idade - 1;
            return idade;*/
}


