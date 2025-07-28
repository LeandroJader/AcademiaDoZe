using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaDoZe.Dominio.Entidades
{
   public  class EntidadeBase
    {
        public int Id { get; protected set; }

        public EntidadeBase(int id = 0)
        {
            Id = id;
        }
    }
    
}
//leandro jader
