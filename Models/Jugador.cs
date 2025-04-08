using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnsayoTrivia.Models
{
    public class Jugador
    {
        public string Nombre { get; private set; }
        public int Puntaje { get; private set; }
        public int PreguntasCorrectas { get; private set; }
        public int PreguntasIncorrectas { get; private set; }

        public Jugador(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre del jugador no puede estar vacío.");

            Nombre = nombre;
            Puntaje = 0;
            PreguntasCorrectas = 0;
            PreguntasIncorrectas = 0;
        }

        public void AcertarPregunta(int puntos)
        {
            Puntaje += puntos;
            PreguntasCorrectas++;
        }

        public void FallarPregunta()
        {
            Puntaje -= 2;
            if (Puntaje < 0) Puntaje = 0;
            PreguntasIncorrectas++;
        }

        public void Reiniciar()
        {
            Puntaje = 0;
            PreguntasCorrectas = 0;
            PreguntasIncorrectas = 0;
        }
    }
}
