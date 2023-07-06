using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    internal class CobrarCurso
    {
        private decimal ValorCurso { get; set; }

        private decimal ValorMulta { get; set; }

        private decimal ValorDesconto { get; set; }

        public decimal Resultado { get; set; }

        private CobrarCurso(decimal valorCurso, decimal valorMulta, decimal valorDesconto)
        {
            ValorCurso = valorCurso;
            ValorMulta = valorMulta;
            ValorDesconto = valorDesconto;
            Resultado = Calculo();
            
        }

        internal decimal Calculo()
        {
            decimal resultado = 0;

            if (ValorMulta > 0)
            {
                resultado = ValorCurso + ValorMulta;
            } 
            else if (ValorMulta == 0)
            {
                resultado = ValorCurso - ValorDesconto;
            }
            return resultado;
        }
    }
}
