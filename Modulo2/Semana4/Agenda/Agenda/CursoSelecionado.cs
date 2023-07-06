using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Agenda
{
    internal class CursoSelecionado
    {
        private List<CursoSelecionado> cursoSelecionadoList { get; }
                        

        public CursoSelecionado(string curso)
        {
            cursoSelecionadoList = new List<CursoSelecionado>();
        }
        
        public string Inserir(CursoSelecionado curso)
        {
            curso = cursoSelecionadoList.Find(c => c.cursoSelecionadoList == curso.cursoSelecionadoList);
            if(curso == null)
            {
                cursoSelecionadoList.Add(curso);
            }
            else
            {
                return curso.Inserir(curso);
            }

            return curso.Inserir(curso);
        }

        

    }
}
