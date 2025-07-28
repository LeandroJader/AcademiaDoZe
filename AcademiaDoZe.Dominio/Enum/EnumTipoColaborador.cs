using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaDoZe.Dominio.Enum
{
    public enum ETipoColaborador
    {
        [Display(Name = "Administrador")] Administrador = 0,

        [Display(Name = "Atendente")] Atendente = 1,

        [Display(Name = "Instrutor")] instrutor = 2,
    }

}
//leandro jader