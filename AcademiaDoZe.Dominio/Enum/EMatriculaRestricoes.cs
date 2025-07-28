using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AcademiaDoZe.Dominio.Enum
{
    [Flags]
  public enum EMatriculaRestricoes
    {
        [Display (Name ="Nenhuma Restrição" )] 
        none =0,

        [Display(Name = "Diabetes")]
        Diabetes = 1,

        [Display(Name = "Pressão Alta")]
        PressaoAlta = 2,


        [Display(Name = "Labirintite")]
        Labirintite = 4,

        [Display(Name ="alergias")]
        Alergias = 8,

        [Display(Name = "Problemas Respiratórios")]
        ProblemasRespiratorios = 16,

        [Display(Name = "Remédio Continuo")]
        RemedioContinuo = 32
    }
}
//leandro jader