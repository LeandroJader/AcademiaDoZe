using AcademiaDoZe.Dominio.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaDoZe.Dominio.Entidades
{
    class Colaboradores : Pessoa
    {
        public Colaboradores(string nome, string cpf, DateOnly dataNascimento, string telefone, string email, string senha, string foto, Logradouro endereco, int numero, int complemento) : base(nome, cpf, dataNascimento, telefone, email, senha, foto, endereco, numero, complemento)
        {
        }
        public DateOnly DataAdmissao { get; set; }
        public ETipoColaborador TipoColaborador { get; set; }
        public EVinculoTrabalhista VinculoTrabalhista { get; set; }
    }
}
//leandro jader