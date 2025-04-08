using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnsayoTrivia.Models
{
    public class PreguntaFacil : Pregunta
    {
        public PreguntaFacil(string texto, List<string> opciones, string respuestaCorrecta, string categoria)
            : base(texto, opciones, respuestaCorrecta, categoria, "Fácil")
        { }

        public override bool EvaluarRespuesta(string seleccionada)
        {
            return seleccionada == RespuestaCorrecta;
        }

        public override int ObtenerPuntaje()
        {
            return 5;
        }

        public override int ObtenerTiempo()
        {
            return 20;
        }
    }
}
