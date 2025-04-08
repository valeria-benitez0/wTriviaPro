using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnsayoTrivia.Models
{
    public static class PreguntaFactory
    {
        private static readonly Dictionary<string, List<Pregunta>> bancoPreguntas = new Dictionary<string, List<Pregunta>>();
        private static readonly Random random = new Random();
        private static readonly HashSet<Pregunta> preguntasUtilizadas = new HashSet<Pregunta>();

        // Constructor estático para inicializar las preguntas
        static PreguntaFactory()
        {
            AgregarPreguntasEjemplo();
        }

        public static void ReiniciarPreguntas()
        {
            preguntasUtilizadas.Clear();
        }

        public static Pregunta ObtenerPregunta(string categoria, string nivel)
        {
            if (!bancoPreguntas.ContainsKey(categoria))
                throw new ArgumentException("Categoría inválida.");

            var disponibles = bancoPreguntas[categoria]
                .Where(p => p.Nivel == nivel && !preguntasUtilizadas.Contains(p))
                .ToList();

            if (disponibles.Count == 0)
                throw new InvalidOperationException("No hay más preguntas disponibles para esta combinación.");

            var preguntaSeleccionada = disponibles[random.Next(disponibles.Count)];
            preguntasUtilizadas.Add(preguntaSeleccionada);
            return preguntaSeleccionada;
        }

        private static void AgregarPreguntasEjemplo()
        {

            bancoPreguntas["Ciencia"] = new List<Pregunta>
            {
                new PreguntaFacil("¿Cuál es el planeta más cercano al Sol?",
                    new List<string> { "Mercurio", "Venus", "Marte", "Júpiter" }, "Mercurio", "Ciencia"),
                
                new PreguntaFacil("¿Qué gas respiramos para vivir?",
                    new List<string> { "Oxígeno", "Hidrógeno", "Nitrógeno", "Dióxido de carbono" }, "Oxígeno", "Ciencia"),

                new PreguntaFacil("¿Cuál es el órgano principal del sistema circulatorio?",
                    new List<string> { "Pulmón", "Cerebro", "Hígado", "Corazón" }, "Corazón", "Ciencia"),

                new PreguntaFacil("¿Qué estado de la materia es el agua a temperatura ambiente?",
                    new List<string> { "Sólido", "Líquido", "Gaseoso", "Plasma" }, "Líquido", "Ciencia"),

                new PreguntaFacil("¿Qué astro da luz y calor a la Tierra?",
                    new List<string> { "Luna", "Sol", "Marte", "Júpiter" }, "Sol", "Ciencia"),

    // Medias
                new PreguntaMedia("¿Qué científico formuló la teoría de la relatividad?",
                    new List<string> { "Newton", "Einstein", "Bohr", "Tesla" }, "Einstein", "Ciencia"),

                new PreguntaMedia("¿Cuál es el símbolo químico del oro?",
                    new List<string> { "O", "Go", "Au", "Ag" }, "Au", "Ciencia"),

                new PreguntaMedia("¿Cómo se llama el proceso por el cual las plantas producen su alimento?",
                    new List<string> { "Digestión", "Fotosíntesis", "Evaporación", "Respiración" }, "Fotosíntesis", "Ciencia"),

                new PreguntaMedia("¿Cuántos huesos tiene el cuerpo humano adulto?",
                    new List<string> { "206", "208", "210", "212" }, "206", "Ciencia"),

                new PreguntaMedia("¿Cuál es el planeta más grande del sistema solar?",
                    new List<string> { "Saturno", "Tierra", "Neptuno", "Júpiter" }, "Júpiter", "Ciencia"),

    // Difíciles
                new PreguntaDificil("¿Cuál es la fórmula química del ozono?",
                    new List<string> { "O2", "O3", "H2O", "CO2" }, "O3", "Ciencia"),

                new PreguntaDificil("¿Qué parte del átomo tiene carga positiva?",
                    new List<string> { "Electrón", "Neutrón", "Protón", "Núcleo" }, "Protón", "Ciencia"),

                new PreguntaDificil("¿Qué científico propuso las leyes del movimiento?",
                    new List<string> { "Newton", "Galileo", "Faraday", "Einstein" }, "Newton", "Ciencia"),

                new PreguntaDificil("¿Qué unidad mide la intensidad de corriente eléctrica?",
                    new List<string> { "Voltio", "Ohmio", "Amperio", "Vatio" }, "Amperio", "Ciencia"),

               new PreguntaDificil("¿Cuál es el nombre del tejido que transporta agua en las plantas?",
                    new List<string> { "Xilema", "Flema", "Corteza", "Estoma" }, "Xilema", "Ciencia"),
            };

            bancoPreguntas["Historia"] = new List<Pregunta>
            {
                new PreguntaFacil("¿En qué año se descubrió América?",
                    new List<string> { "1492", "1500", "1600", "1400" }, "1492", "Historia"),

                new PreguntaFacil("¿Quién fue el primer presidente de Estados Unidos?",
                    new List<string> { "George Washington", "Abraham Lincoln", "John Adams", "Thomas Jefferson" }, "George Washington", "Historia"),

                new PreguntaFacil("¿Qué imperio construyó el Coliseo?",
                    new List<string> { "Griego", "Egipcio", "Romano", "Persa" }, "Romano", "Historia"),

                new PreguntaFacil("¿Quién fue Cristóbal Colón?",
                    new List<string> { "Un filósofo", "Un conquistador", "Un explorador", "Un emperador" }, "Un explorador", "Historia"),

                new PreguntaFacil("¿Qué civilización construyó las pirámides de Giza?",
                    new List<string> { "Aztecas", "Egipcios", "Mayas", "Incas" }, "Egipcios", "Historia"),

    // Medias
                new PreguntaMedia("¿Quién fue Simón Bolívar?",
                    new List<string> { "Un emperador romano", "Un libertador sudamericano", "Un presidente mexicano" },
                    "Un libertador sudamericano", "Historia"),

                new PreguntaMedia("¿Cuál fue la causa principal de la Segunda Guerra Mundial?",
                    new List<string> { "La caída del Imperio Romano", "El asesinato del Archiduque", "El ascenso del nazismo", "La guerra fría" }, "El ascenso del nazismo", "Historia"),

                new PreguntaMedia("¿Qué país fue gobernado por Napoleón Bonaparte?",
                    new List<string> { "España", "Inglaterra", "Francia", "Alemania" }, "Francia", "Historia"),

                new PreguntaMedia("¿Cuál fue la civilización más antigua?",
                    new List<string> { "Romana", "Egipcia", "Mesopotámica", "Griega" }, "Mesopotámica", "Historia"),

                new PreguntaMedia("¿Qué país usó por primera vez la bomba atómica en guerra?",
                    new List<string> { "Alemania", "Rusia", "Japón", "Estados Unidos" }, "Estados Unidos", "Historia"),

    // Difíciles
                new PreguntaDificil("¿Qué tratado puso fin a la Primera Guerra Mundial?",
                    new List<string> { "Tratado de Versalles", "Tratado de París", "Tratado de Tordesillas" },
                   "Tratado de Versalles", "Historia"),

                new PreguntaDificil("¿Qué líder encabezó la Revolución Cubana?",
                    new List<string> { "Che Guevara", "Fidel Castro", "Hugo Chávez", "Raúl Castro" }, "Fidel Castro", "Historia"),

                new PreguntaDificil("¿En qué año cayó el Muro de Berlín?",
                    new List<string> { "1987", "1989", "1991", "1993" }, "1989", "Historia"),

                new PreguntaDificil("¿Qué rey francés fue conocido como 'El Rey Sol'?",
                    new List<string> { "Luis XIV", "Luis XVI", "Carlos V", "Enrique VIII" }, "Luis XIV", "Historia"),

               new PreguntaDificil("¿Cuál fue el imperio más grande de la historia en extensión?",
                   new List<string> { "Romano", "Mongol", "Británico", "Persa" }, "Británico", "Historia"),
            };

            bancoPreguntas["Cultura General"] = new List<Pregunta>
{
    new PreguntaFacil("¿Cuál es la capital de Francia?",
        new List<string> { "Londres", "Madrid", "París", "Roma" }, "París", "Cultura General"),

    new PreguntaFacil("¿Quién pintó la Mona Lisa?",
        new List<string> { "Vincent van Gogh", "Leonardo da Vinci", "Pablo Picasso", "Claude Monet" }, "Leonardo da Vinci", "Cultura General"),

    new PreguntaFacil("¿De qué país es originario el tango?",
        new List<string> { "España", "Argentina", "Brasil", "México" }, "Argentina", "Cultura General"),

    new PreguntaFacil("¿Cuántos continentes hay en el mundo?",
        new List<string> { "5", "6", "7", "8" }, "7", "Cultura General"),

    new PreguntaFacil("¿Cuál es el idioma más hablado en el mundo?",
        new List<string> { "Español", "Inglés", "Chino mandarín", "Árabe" }, "Chino mandarín", "Cultura General"),

    // Medias
    new PreguntaMedia("¿Cuántos jugadores componen un equipo de fútbol en el campo?",
        new List<string> { "9", "10", "11", "12" }, "11", "Cultura General"),

    new PreguntaMedia("¿Qué instrumento musical tiene 88 teclas?",
        new List<string> { "Guitarra", "Piano", "Acordeón", "Violín" }, "Piano", "Cultura General"),

    new PreguntaMedia("¿Quién fue el primer hombre en caminar sobre la Luna?",
        new List<string> { "Neil Armstrong", "Buzz Aldrin", "Yuri Gagarin", "John Glenn" }, "Neil Armstrong", "Cultura General"),

    new PreguntaMedia("¿En qué continente se encuentra el desierto del Sahara?",
        new List<string> { "Asia", "África", "América", "Oceanía" }, "África", "Cultura General"),

    new PreguntaMedia("¿Qué famoso músico compuso la ópera 'La Flauta Mágica'?",
        new List<string> { "Beethoven", "Mozart", "Bach", "Chopin" }, "Mozart", "Cultura General"),

    // Difíciles
    new PreguntaDificil("¿Quién escribió 'Cien años de soledad'?",
        new List<string> { "Mario Vargas Llosa", "Gabriel García Márquez", "Isabel Allende", "Pablo Neruda" },
        "Gabriel García Márquez", "Cultura General"),

    new PreguntaDificil("¿Qué ciudad fue destruida por un volcán en el año 79 d.C.?",
        new List<string> { "Roma", "Pompeya", "Hércules", "Nápoles" }, "Pompeya", "Cultura General"),

    new PreguntaDificil("¿En qué año terminó la Segunda Guerra Mundial?",
        new List<string> { "1941", "1943", "1945", "1947" }, "1945", "Cultura General"),

    new PreguntaDificil("¿Cuál es el río más largo del mundo?",
        new List<string> { "Nilo", "Amazonas", "Yangtsé", "Misisipi" }, "Amazonas", "Cultura General"),

    new PreguntaDificil("¿Qué país inventó la cerveza?",
        new List<string> { "Irlanda", "Bélgica", "México", "Mesopotamia" }, "Mesopotamia", "Cultura General"),
};



            /*bancoPreguntas["Ciencia"] = new List<Pregunta>
            {
                new PreguntaFacil("¿Cuál es el planeta más cercano al Sol?",
                    new List<string> { "Mercurio", "Venus", "Marte", "Júpiter" },
                    "Mercurio", "Ciencia"),

                new PreguntaMedia("¿Qué científico formuló la teoría de la relatividad?",
                    new List<string> { "Newton", "Einstein", "Bohr", "Tesla" },
                    "Einstein", "Ciencia"),

                new PreguntaDificil("¿Cuál es la fórmula química del ozono?",
                    new List<string> { "O2", "O3", "H2O", "CO2" },
                    "O3", "Ciencia"),
            };

            bancoPreguntas["Historia"] = new List<Pregunta>
            {
                new PreguntaFacil("¿En qué año se descubrió América?",
                    new List<string> { "1492", "1500", "1600", "1400" },
                    "1492", "Historia"),

                new PreguntaMedia("¿Quién fue Simón Bolívar?",
                    new List<string> { "Un emperador romano", "Un libertador sudamericano", "Un presidente mexicano" },
                    "Un libertador sudamericano", "Historia"),

                new PreguntaDificil("¿Qué tratado puso fin a la Primera Guerra Mundial?",
                    new List<string> { "Tratado de Versalles", "Tratado de París", "Tratado de Tordesillas" },
                    "Tratado de Versalles", "Historia"),
            };

            bancoPreguntas["Cultura General"] = new List<Pregunta>
            {
                new PreguntaFacil("¿Cuál es la capital de Francia?",
                    new List<string> { "Londres", "Madrid", "París", "Roma" },
                    "París", "Cultura General"),

                new PreguntaMedia("¿Cuántos colores tiene el arcoíris?",
                    new List<string> { "6", "7", "8", "5" },
                    "7", "Cultura General"),

                new PreguntaDificil("¿Quién escribió 'Cien años de soledad'?",
                    new List<string> { "Mario Vargas Llosa", "Gabriel García Márquez", "Isabel Allende", "Pablo Neruda" },
                    "Gabriel García Márquez", "Cultura General"),
            };*/
        }
    }
}
