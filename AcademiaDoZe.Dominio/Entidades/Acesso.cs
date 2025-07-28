using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaDoZe.Dominio.Entidades
{
   public class Acesso
    {
        public Pessoa AlunoColaborador { get; set; }
        public DateTime DataHora { get; set; }

        public Acesso(Pessoa alunoColaborador, DateTime dataHora)
        {
            AlunoColaborador = alunoColaborador;
            DataHora = dataHora;
        }
    }
    //leandro jader
}
