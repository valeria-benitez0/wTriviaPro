using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnsayoTrivia.Models
{
    public class PreguntaDificil : Pregunta
    {
        public PreguntaDificil(string texto, List<string> opciones, string respuestaCorrecta, string categoria)
            : base(texto, opciones, respuestaCorrecta, categoria, "Difícil")
        { }

        public override bool EvaluarRespuesta(string seleccionada)
        {
            return seleccionada == RespuestaCorrecta;
        }

        public override int ObtenerPuntaje()
        {
            return 15;
        }

        public override int ObtenerTiempo()
        {
            return 10;
        }
    }
}
