using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AcademiaDoZe.Dominio.Entidades
{
    public class Aluno : Pessoa
    {
        public Aluno(string nome, string cpf, DateOnly dataNascimento, string telefone, string email, string senha, string foto, Logradouro nomelogradouro, int numero, int complemento) : base(nome, cpf, dataNascimento, telefone, email, senha, foto, nomelogradouro, numero, complemento)
        {
        }
        public Logradouro logradouro{ get; set; }
    }
}
//leandro jader