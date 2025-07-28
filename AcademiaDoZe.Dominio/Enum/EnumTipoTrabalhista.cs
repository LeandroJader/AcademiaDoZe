using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaDoZe.Dominio.Enum
{    
       public enum EVinculoTrabalhista
        {
            [Display(Name = "CLT")] CLT = 0,

            [Display(Name = "Estágio")] Estagio = 1
        }
    }

//leandro jader