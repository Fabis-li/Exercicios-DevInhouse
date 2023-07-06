using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Agenda
{
    static class FormatacaoTexto
    {
        public static string Formatacao(string nome, string curso, decimal valorCurso)
        {
            return $"Nome: {nome}, Curso: {curso}, Valor Curso:{valorCurso}";
        }
        public static string Formatacao(string nome, string curso, decimal valorCurso, decimal valorDesconto)
        {
            return $"Nome: {nome}, Curso: {curso}, Valor Curso: {valorCurso}, Valor Desconto: {valorDesconto}";
        }
        public static string Formatacao(string nome, string curso, decimal valorCurso,decimal valorDesconto, int idade)
        {
            return $"Nome: {nome}, Curso: {curso}, Valor Curso: {valorCurso}, Valor Desconto: {valorDesconto}, Idade: {idade}";
        }

    }
}
