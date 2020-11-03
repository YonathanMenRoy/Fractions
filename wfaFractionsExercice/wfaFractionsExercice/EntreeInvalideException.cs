using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaFractionsExercice
{
    public class EntreeInvalideException: Exception
    {
        public EntreeInvalideException():base("Se que vous avez entré est invalide. Assurez- vous que tout les nombres rentré sont des nomres entiers.")
        {

        }
    }
}
