//leandro jader
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AcademiaDoZe.Dominio.Entidades
{
   public class Logradouro : EntidadeBase
    {
        public string Cep { get; set; }
        public string Pais { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string NomeLogradouro { get; set; }

        private Logradouro(string cep, string pais, string estado, string cidade, string bairro, string nomelogradouro)
        {
            Cep = cep;
            Pais = pais;
            Estado = estado;
            Cidade = cidade;
            Bairro = bairro;
            NomeLogradouro = nomelogradouro;
      
        }
        public static Logradouro Validar(string cep, string pais, string estado, string cidade, string bairro, string nomeloradouro)
        {
            if (string.IsNullOrWhiteSpace(cep)) throw new DomainException("O campo Cep é Obrigatorio");
            if (string.IsNullOrWhiteSpace(pais)) throw new DomainException("O campo país é Obrigatorio");
            if (string.IsNullOrWhiteSpace(estado)) throw new DomainException("O campo estado é Obrigatorio");
            if (string.IsNullOrWhiteSpace(cidade)) throw new DomainException("O campo cidade é Obrigatorio");
            if (string.IsNullOrWhiteSpace(bairro)) throw new DomainException("O campo Cep é Obrigatorio");
            if (string.IsNullOrWhiteSpace(nomeloradouro)) throw new DomainException("O campo Nome Logradouro é Obrigatorio");

            if (!cep.All(char.IsDigit)) throw new DomainException("Cep_Números");
            if (cep.Length != 8) throw new DomainException("Cep Digitos");

            return new Logradouro(cep, pais, estado, cidade, bairro, nomeloradouro);
        } 
    }
}
//leandro jader