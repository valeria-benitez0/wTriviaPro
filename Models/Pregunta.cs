using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaPro.Models
{
    public abstract class Pregunta
    {
        private string texto;
        private List<string> opciones;
        private string respuestaCorrecta;
        private string categoria;
        private string nivel;

        public string Texto
        {
            get => texto;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El texto de la pregunta no puede estar vacío.");
                texto = value;
            }
        }

        public List<string> Opciones
        {
            get => opciones;
            set
            {
                if (value == null || value.Count < 2)
                    throw new ArgumentException("Debe haber al menos dos opciones.");
                opciones = value;
            }
        }

        public string RespuestaCorrecta
        {
            get => respuestaCorrecta;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La respuesta correcta no puede estar vacía.");
                respuestaCorrecta = value;
            }
        }

        public string Categoria
        {
            get => categoria;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La categoría no puede estar vacía.");
                categoria = value;
            }
        }

        public string Nivel
        {
            get => nivel;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nivel no puede estar vacío.");
                nivel = value;
            }
        }

        public Pregunta(string texto, List<string> opciones, string respuestaCorrecta, string categoria, string nivel)
        {
            Texto = texto;
            Opciones = opciones;
            RespuestaCorrecta = respuestaCorrecta;
            Categoria = categoria;
            Nivel = nivel;
        }

        public abstract bool EvaluarRespuesta(string seleccionada);
        public abstract int ObtenerPuntaje();
        public abstract int ObtenerTiempo();
    }
}
