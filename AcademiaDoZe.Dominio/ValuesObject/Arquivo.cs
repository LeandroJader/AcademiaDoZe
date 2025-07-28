using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace AcademiaDoZe.Dominio.ValuesObject
{
public record Arquivo
    {
        public byte[] Conteudo { get; }
        public Arquivo(byte[] conteudo) 
        {
            Conteudo = conteudo;
        }
    }
}
//leandro jader