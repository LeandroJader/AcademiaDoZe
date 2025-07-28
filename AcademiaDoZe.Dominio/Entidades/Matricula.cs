using AcademiaDoZe.Dominio.Enum;
using AcademiaDoZe.Dominio.ValuesObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaDoZe.Dominio.Entidades
{

    public class Matricula
    {
        public Aluno Aluno { get; private set; }
        public EPlanoAcademia Plano { get; private set; }
        public TimeSpan DataInicio { get; private set; }
        public TimeSpan DataFinal { get; private set; }
        public string Objetivo { get; private set; }
        public string? Restricoes { get; private set; }
        public string? ObsRestricoes { get; private set; }
        public Arquivo? LaudoMedico { get; private set; }

        private Matricula(Aluno aluno, EPlanoAcademia plano, TimeSpan dataInicio, TimeSpan dataFinal, string objetivo, string restricoes, string obsRestricoes, Arquivo laudoMedico)
        {
            Aluno = aluno;
            Plano = plano;
            DataInicio = dataInicio;
            DataFinal = dataFinal;
            Objetivo = objetivo;
            Restricoes = restricoes;
            ObsRestricoes = obsRestricoes;
            LaudoMedico = laudoMedico;
        }
        public static Matricula Validar(Aluno aluno, EPlanoAcademia planoAcademia, TimeSpan datainicio, TimeSpan datafinal, string objetivo, string restrioes, string obsrestricoes, Arquivo laudoMedico)
        {
            if (aluno ==null ) throw new DomainException("O campo Aluno é Obrigatorio");
            if (planoAcademia == null) throw new DomainException("O Campo Mtricula é Obrigatorio");
            if (string.IsNullOrWhiteSpace(objetivo)) throw new DomainException("O campo Objetivo é Obrigatorio");
            if (string.IsNullOrWhiteSpace(restrioes)) throw new DomainException("O Campo Restrições é Obrigatorio");
            if (string.IsNullOrWhiteSpace(obsrestricoes)) throw new DomainException("");
            if (laudoMedico == null ) throw new DomainException("O campo Laudo Médico é Obrigatorio");

            
            

            return new Matricula(aluno,planoAcademia, datainicio, datafinal, objetivo, restrioes, obsrestricoes, laudoMedico);
        }

    }
}
//leandro jader