using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaPro.Models
{
    public static class Puntaje
    {
        public static int CalcularPuntaje(Pregunta pregunta, bool esCorrecta)
        {
            if (esCorrecta)
            {
                return pregunta.ObtenerPuntaje();
            }
            else
            {
                return -2;
            }
        }
    }
}
