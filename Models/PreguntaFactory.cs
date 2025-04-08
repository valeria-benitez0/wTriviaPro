using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaPro.Models
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
                new PreguntaFacil("¿Cuál es el planeta más cercano al Sol?", new List<string> { "Mercurio", "Venus", "Marte", "Júpiter" }, "Mercurio", "Ciencia"),
    new PreguntaFacil("¿Qué gas respiramos para vivir?", new List<string> { "Nitrógeno", "Oxígeno", "Hidrógeno", "Dióxido de carbono" }, "Oxígeno", "Ciencia"),
    new PreguntaFacil("¿Qué órgano bombea la sangre en el cuerpo humano?", new List<string> { "Cerebro", "Pulmones", "Corazón", "Estómago" }, "Corazón", "Ciencia"),
    new PreguntaFacil("¿Cuántos planetas hay en el sistema solar?", new List<string> { "7", "8", "9", "10" }, "8", "Ciencia"),
    new PreguntaFacil("¿Qué líquido es esencial para la vida?", new List<string> { "Aceite", "Agua", "Alcohol", "Gasolina" }, "Agua", "Ciencia"),
    new PreguntaFacil("¿Qué astro da luz y calor a la Tierra?", new List<string> { "Luna", "Sol", "Marte", "Venus" }, "Sol", "Ciencia"),
    new PreguntaFacil("¿Qué animal pone huevos?", new List<string> { "Perro", "Gato", "Gallina", "Elefante" }, "Gallina", "Ciencia"),
    new PreguntaFacil("¿Qué material usamos para escribir en una pizarra?", new List<string> { "Tiza", "Carbón", "Piedra", "Goma" }, "Tiza", "Ciencia"),
    new PreguntaFacil("¿Cuál es el estado del agua a 0°C?", new List<string> { "Líquido", "Gas", "Sólido", "Plasma" }, "Sólido", "Ciencia"),
    new PreguntaFacil("¿Cuál es el animal más grande del planeta?", new List<string> { "Elefante", "Ballena azul", "Jirafa", "Dinosaurio" }, "Ballena azul", "Ciencia"),
    new PreguntaFacil("¿Qué insecto produce miel?", new List<string> { "Mosca", "Hormiga", "Abeja", "Mariposa" }, "Abeja", "Ciencia"),
    new PreguntaFacil("¿Qué planeta es conocido como el planeta rojo?", new List<string> { "Júpiter", "Venus", "Marte", "Saturno" }, "Marte", "Ciencia"),
    new PreguntaFacil("¿Qué parte del cuerpo usamos para oír?", new List<string> { "Ojos", "Boca", "Orejas", "Manos" }, "Orejas", "Ciencia"),
    new PreguntaFacil("¿Qué animal vive en el agua y tiene tentáculos?", new List<string> { "Pulpo", "Tiburón", "Camarón", "Cangrejo" }, "Pulpo", "Ciencia"),
    new PreguntaFacil("¿Cuál es el metal más usado en cables eléctricos?", new List<string> { "Oro", "Aluminio", "Cobre", "Plomo" }, "Cobre", "Ciencia"),

    // 15 PreguntaMedia
    new PreguntaMedia("¿Qué científico formuló la teoría de la relatividad?", new List<string> { "Newton", "Einstein", "Bohr", "Tesla" }, "Einstein", "Ciencia"),
    new PreguntaMedia("¿Cuál es el símbolo químico del sodio?", new List<string> { "Na", "So", "S", "Sn" }, "Na", "Ciencia"),
    new PreguntaMedia("¿Qué tipo de energía produce una batería?", new List<string> { "Mecánica", "Térmica", "Eléctrica", "Nuclear" }, "Eléctrica", "Ciencia"),
    new PreguntaMedia("¿Qué instrumento mide la temperatura?", new List<string> { "Barómetro", "Termómetro", "Altímetro", "Higrómetro" }, "Termómetro", "Ciencia"),
    new PreguntaMedia("¿Qué gas es más abundante en la atmósfera?", new List<string> { "Oxígeno", "Nitrógeno", "Hidrógeno", "CO2" }, "Nitrógeno", "Ciencia"),
    new PreguntaMedia("¿Qué parte del cuerpo humano tiene 206 huesos?", new List<string> { "El corazón", "El esqueleto", "El cerebro", "El intestino" }, "El esqueleto", "Ciencia"),
    new PreguntaMedia("¿Qué científico inventó el primer telescopio?", new List<string> { "Newton", "Galileo Galilei", "Copérnico", "Kepler" }, "Galileo Galilei", "Ciencia"),
    new PreguntaMedia("¿Cómo se llama el proceso por el cual las plantas hacen su alimento?", new List<string> { "Digestión", "Fotosíntesis", "Respiración", "Fermentación" }, "Fotosíntesis", "Ciencia"),
    new PreguntaMedia("¿Qué órgano del cuerpo produce insulina?", new List<string> { "Hígado", "Páncreas", "Riñón", "Estómago" }, "Páncreas", "Ciencia"),
    new PreguntaMedia("¿Qué científico descubrió la penicilina?", new List<string> { "Alexander Fleming", "Marie Curie", "Louis Pasteur", "Isaac Newton" }, "Alexander Fleming", "Ciencia"),
    new PreguntaMedia("¿Cuál es la distancia entre la Tierra y el Sol?", new List<string> { "150 millones de km", "93 millones de km", "384 mil km", "1 millón de km" }, "150 millones de km", "Ciencia"),
    new PreguntaMedia("¿Qué unidad se utiliza para medir la intensidad de la corriente eléctrica?", new List<string> { "Voltios", "Watts", "Amperios", "Ohmios" }, "Amperios", "Ciencia"),
    new PreguntaMedia("¿Qué sistema controla las funciones del cuerpo humano?", new List<string> { "Respiratorio", "Digestivo", "Nervioso", "Excretor" }, "Nervioso", "Ciencia"),
    new PreguntaMedia("¿Qué tipo de sangre es considerado donante universal?", new List<string> { "A", "B", "AB", "O negativo" }, "O negativo", "Ciencia"),
    new PreguntaMedia("¿Qué tipo de célula no tiene núcleo?", new List<string> { "Eucariota", "Procariota", "Vegetal", "Animal" }, "Procariota", "Ciencia"),

    // 15 PreguntaDificil
    new PreguntaDificil("¿Cuál es la fórmula química del ozono?", new List<string> { "O2", "O3", "H2O", "CO2" }, "O3", "Ciencia"),
    new PreguntaDificil("¿Qué partícula subatómica tiene carga negativa?", new List<string> { "Protón", "Neutrón", "Electrón", "Fotón" }, "Electrón", "Ciencia"),
    new PreguntaDificil("¿Qué científico propuso la tabla periódica moderna?", new List<string> { "Mendeleyev", "Bohr", "Rutherford", "Dalton" }, "Mendeleyev", "Ciencia"),
    new PreguntaDificil("¿Cuál es el número atómico del carbono?", new List<string> { "6", "8", "12", "14" }, "6", "Ciencia"),
    new PreguntaDificil("¿Qué órgano del cuerpo produce bilis?", new List<string> { "Páncreas", "Hígado", "Intestino", "Riñón" }, "Hígado", "Ciencia"),
    new PreguntaDificil("¿Qué se mide con la escala de Richter?", new List<string> { "Vientos", "Temblores", "Temperatura", "Presión" }, "Temblores", "Ciencia"),
    new PreguntaDificil("¿Cuál es el nombre del proceso que crea estrellas?", new List<string> { "Fusión nuclear", "Fisión", "Fotosíntesis", "Evaporación" }, "Fusión nuclear", "Ciencia"),
    new PreguntaDificil("¿Qué planeta tiene un gran sistema de anillos?", new List<string> { "Júpiter", "Saturno", "Urano", "Neptuno" }, "Saturno", "Ciencia"),
    new PreguntaDificil("¿Qué elemento químico tiene el símbolo Fe?", new List<string> { "Fósforo", "Hierro", "Flúor", "Francio" }, "Hierro", "Ciencia"),
    new PreguntaDificil("¿Cuál es el gen que determina el sexo masculino?", new List<string> { "X", "Z", "Y", "W" }, "Y", "Ciencia"),
    new PreguntaDificil("¿Qué ciencia estudia los fósiles?", new List<string> { "Geología", "Paleontología", "Biología", "Mineralogía" }, "Paleontología", "Ciencia"),
    new PreguntaDificil("¿Qué parte del cerebro controla el equilibrio?", new List<string> { "Corteza", "Hipotálamo", "Cerebelo", "Tronco cerebral" }, "Cerebelo", "Ciencia"),
    new PreguntaDificil("¿Qué tipo de onda es la luz?", new List<string> { "Sonora", "Mecánica", "Electromagnética", "Gravitacional" }, "Electromagnética", "Ciencia"),
    new PreguntaDificil("¿Cuál es el estado de la materia que ocurre a temperaturas extremadamente altas?", new List<string> { "Gas", "Sólido", "Plasma", "Líquido" }, "Plasma", "Ciencia"),
    new PreguntaDificil("¿Qué instrumento se usa para observar átomos?", new List<string> { "Microscopio óptico", "Telescopio", "Microscopio electrónico", "Lupa" }, "Microscopio electrónico", "Ciencia"),

            };

            bancoPreguntas["Historia"] = new List<Pregunta>
            {
                new PreguntaFacil("¿En qué año se descubrió América?", new List<string> { "1492", "1500", "1600", "1400" }, "1492", "Historia"),
    new PreguntaFacil("¿Quién fue Cristóbal Colón?", new List<string> { "Explorador", "Rey", "Científico", "Soldado" }, "Explorador", "Historia"),
    new PreguntaFacil("¿Qué país lideró la conquista de América?", new List<string> { "Francia", "Inglaterra", "España", "Italia" }, "España", "Historia"),
    new PreguntaFacil("¿Qué civilización construyó las pirámides?", new List<string> { "Griega", "Egipcia", "Romana", "China" }, "Egipcia", "Historia"),
    new PreguntaFacil("¿Quién fue el primer presidente de EE.UU.?", new List<string> { "George Washington", "Abraham Lincoln", "John Adams", "Thomas Jefferson" }, "George Washington", "Historia"),
    new PreguntaFacil("¿Qué guerra dividió EE.UU. en el siglo XIX?", new List<string> { "Civil", "Mundial", "Revolución", "Coreana" }, "Civil", "Historia"),
    new PreguntaFacil("¿Qué inventó Gutenberg?", new List<string> { "Teléfono", "Imprenta", "Televisión", "Internet" }, "Imprenta", "Historia"),
    new PreguntaFacil("¿Qué evento inició la Segunda Guerra Mundial?", new List<string> { "Ataque a Pearl Harbor", "Invasión a Polonia", "Caída del muro de Berlín", "Tratado de Versalles" }, "Invasión a Polonia", "Historia"),
    new PreguntaFacil("¿Quién fue Simón Bolívar?", new List<string> { "Libertador sudamericano", "Escritor", "Científico", "Conquistador" }, "Libertador sudamericano", "Historia"),
    new PreguntaFacil("¿Cuál fue el imperio de Alejandro Magno?", new List<string> { "Romano", "Persa", "Macedonio", "Egipcio" }, "Macedonio", "Historia"),
    new PreguntaFacil("¿Qué país usó bombas atómicas en 1945?", new List<string> { "Alemania", "Japón", "Estados Unidos", "Rusia" }, "Estados Unidos", "Historia"),
    new PreguntaFacil("¿Quién fue Napoleón Bonaparte?", new List<string> { "General francés", "Presidente", "Científico", "Artista" }, "General francés", "Historia"),
    new PreguntaFacil("¿Dónde se firmó la Declaración de Independencia de EE.UU.?", new List<string> { "Washington", "Filadelfia", "Boston", "Nueva York" }, "Filadelfia", "Historia"),
    new PreguntaFacil("¿Qué invento revolucionó la navegación?", new List<string> { "Brújula", "Tornillo", "Catalejo", "Reloj de sol" }, "Brújula", "Historia"),
    new PreguntaFacil("¿Quién liberó a México del dominio español?", new List<string> { "Benito Juárez", "Miguel Hidalgo", "Porfirio Díaz", "Pancho Villa" }, "Miguel Hidalgo", "Historia"),

    // 15 PreguntaMedia
    new PreguntaMedia("¿Qué imperio cayó en 476 d.C.?", new List<string> { "Egipcio", "Romano de Occidente", "Griego", "Inca" }, "Romano de Occidente", "Historia"),
    new PreguntaMedia("¿Quién escribió el 'Contrato Social'?", new List<string> { "Voltaire", "Rousseau", "Locke", "Montesquieu" }, "Rousseau", "Historia"),
    new PreguntaMedia("¿Qué país lideró la revolución industrial?", new List<string> { "Francia", "Alemania", "Reino Unido", "Estados Unidos" }, "Reino Unido", "Historia"),
    new PreguntaMedia("¿Qué monarca fue ejecutado durante la Revolución Francesa?", new List<string> { "Luis XIV", "Luis XVI", "Napoleón", "Luis XVIII" }, "Luis XVI", "Historia"),
    new PreguntaMedia("¿Qué país construyó la Muralla China?", new List<string> { "Japón", "China", "India", "Mongolia" }, "China", "Historia"),
    new PreguntaMedia("¿Qué tratado terminó la Primera Guerra Mundial?", new List<string> { "Versalles", "Tordesillas", "París", "Paz de Westfalia" }, "Versalles", "Historia"),
    new PreguntaMedia("¿Qué guerra ocurrió entre 1914 y 1918?", new List<string> { "Segunda Guerra", "Guerra Fría", "Primera Guerra Mundial", "Guerra de Vietnam" }, "Primera Guerra Mundial", "Historia"),
    new PreguntaMedia("¿Qué evento ocurrió en 1989 en Alemania?", new List<string> { "Unificación", "Caída del Muro de Berlín", "Revolución", "Tratado de paz" }, "Caída del Muro de Berlín", "Historia"),
    new PreguntaMedia("¿Quién fue el dictador de la Alemania nazi?", new List<string> { "Stalin", "Hitler", "Mussolini", "Franco" }, "Hitler", "Historia"),
    new PreguntaMedia("¿Qué cultura precolombina vivió en Perú?", new List<string> { "Azteca", "Maya", "Inca", "Tolteca" }, "Inca", "Historia"),
    new PreguntaMedia("¿Quién descubrió el Pacífico?", new List<string> { "Colón", "Magallanes", "Balboa", "Drake" }, "Balboa", "Historia"),
    new PreguntaMedia("¿Qué presidente abolió la esclavitud en EE.UU.?", new List<string> { "Lincoln", "Washington", "Roosevelt", "Kennedy" }, "Lincoln", "Historia"),
    new PreguntaMedia("¿Qué civilización inventó la escritura cuneiforme?", new List<string> { "Egipcios", "Sumerios", "Griegos", "Romanos" }, "Sumerios", "Historia"),
    new PreguntaMedia("¿Qué guerra involucró a Corea en los años 50?", new List<string> { "Vietnam", "Segunda Guerra", "Corea", "Guerra Fría" }, "Corea", "Historia"),
    new PreguntaMedia("¿Qué revolucionario argentino luchó en Cuba?", new List<string> { "Perón", "Che Guevara", "Bolívar", "San Martín" }, "Che Guevara", "Historia"),

    // 15 PreguntaDificil
    new PreguntaDificil("¿Qué emperador dividió el Imperio Romano?", new List<string> { "Julio César", "Constantino", "Diocleciano", "Nerón" }, "Diocleciano", "Historia"),
    new PreguntaDificil("¿Qué batalla marcó el fin de Napoleón?", new List<string> { "Austerlitz", "Waterloo", "Borodino", "Jena" }, "Waterloo", "Historia"),
    new PreguntaDificil("¿Qué acuerdo creó la ONU?", new List<string> { "Carta de San Francisco", "Tratado de París", "Acuerdo de Potsdam", "Pacto de Varsovia" }, "Carta de San Francisco", "Historia"),
    new PreguntaDificil("¿Qué evento ocurrió en Hiroshima en 1945?", new List<string> { "Bombardeo atómico", "Batalla naval", "Protesta", "Cumbre" }, "Bombardeo atómico", "Historia"),
    new PreguntaDificil("¿Qué zar fue derrocado en la Revolución Rusa?", new List<string> { "Pedro el Grande", "Nicolás II", "Iván IV", "Alejandro III" }, "Nicolás II", "Historia"),
    new PreguntaDificil("¿Qué guerra duró más de 100 años?", new List<string> { "Guerra de los 100 años", "Guerra Civil Española", "Guerras Napoleónicas", "Guerra de los 30 años" }, "Guerra de los 100 años", "Historia"),
    new PreguntaDificil("¿Quién fue el primer emperador romano?", new List<string> { "Julio César", "Augusto", "Nerón", "Trajano" }, "Augusto", "Historia"),
    new PreguntaDificil("¿Qué país colonizó Angola?", new List<string> { "España", "Portugal", "Francia", "Alemania" }, "Portugal", "Historia"),
    new PreguntaDificil("¿Qué guerra comenzó en 1939?", new List<string> { "Primera Guerra", "Segunda Guerra Mundial", "Guerra Fría", "Guerra del Golfo" }, "Segunda Guerra Mundial", "Historia"),
    new PreguntaDificil("¿Qué cultura antigua usó jeroglíficos?", new List<string> { "Griegos", "Romanos", "Egipcios", "Persas" }, "Egipcios", "Historia"),
    new PreguntaDificil("¿Qué imperio cayó con la toma de Constantinopla?", new List<string> { "Romano", "Bizantino", "Mongol", "Otómano" }, "Bizantino", "Historia"),
    new PreguntaDificil("¿Qué evento se conoce como el 'Holocausto'?", new List<string> { "Genocidio armenio", "Guerra Civil", "Exterminio judío", "Revolución rusa" }, "Exterminio judío", "Historia"),
    new PreguntaDificil("¿Quién lideró la independencia de Argentina?", new List<string> { "Belgrano", "San Martín", "Rivadavia", "Mitre" }, "San Martín", "Historia"),
    new PreguntaDificil("¿Qué tratado acabó con el Imperio Austrohúngaro?", new List<string> { "Saint-Germain", "Versalles", "París", "Potsdam" }, "Saint-Germain", "Historia"),
    new PreguntaDificil("¿Qué ciudad fue saqueada en 1204 durante las cruzadas?", new List<string> { "Roma", "Constantinopla", "Jerusalén", "París" }, "Constantinopla", "Historia"),

            };

            bancoPreguntas["Cultura General"] = new List<Pregunta>
            {
                new PreguntaFacil("¿Cuál es la capital de Francia?", new List<string> { "Londres", "Madrid", "París", "Roma" }, "París", "Cultura General"),
    new PreguntaFacil("¿Qué instrumento tiene cuerdas?", new List<string> { "Violín", "Tambor", "Flauta", "Piano" }, "Violín", "Cultura General"),
    new PreguntaFacil("¿Qué color resulta de mezclar azul y amarillo?", new List<string> { "Rojo", "Verde", "Morado", "Naranja" }, "Verde", "Cultura General"),
    new PreguntaFacil("¿En qué continente está Brasil?", new List<string> { "Europa", "Asia", "América", "África" }, "América", "Cultura General"),
    new PreguntaFacil("¿Cuántos días tiene una semana?", new List<string> { "5", "6", "7", "8" }, "7", "Cultura General"),
    new PreguntaFacil("¿Qué animal es conocido como el rey de la selva?", new List<string> { "Tigre", "León", "Elefante", "Pantera" }, "León", "Cultura General"),
    new PreguntaFacil("¿Qué fruta es amarilla y curva?", new List<string> { "Plátano", "Manzana", "Pera", "Piña" }, "Plátano", "Cultura General"),
    new PreguntaFacil("¿Qué día sigue después del viernes?", new List<string> { "Sábado", "Domingo", "Lunes", "Jueves" }, "Sábado", "Cultura General"),
    new PreguntaFacil("¿Qué estación viene después de primavera?", new List<string> { "Verano", "Invierno", "Otoño", "Ninguna" }, "Verano", "Cultura General"),
    new PreguntaFacil("¿Qué parte del cuerpo usamos para ver?", new List<string> { "Manos", "Pies", "Ojos", "Orejas" }, "Ojos", "Cultura General"),
    new PreguntaFacil("¿Qué moneda se usa en Estados Unidos?", new List<string> { "Euro", "Dólar", "Peso", "Libra" }, "Dólar", "Cultura General"),
    new PreguntaFacil("¿Qué objeto usamos para cortar papel?", new List<string> { "Cuchillo", "Tijeras", "Piedra", "Lápiz" }, "Tijeras", "Cultura General"),
    new PreguntaFacil("¿Qué número viene después del 9?", new List<string> { "8", "10", "11", "9" }, "10", "Cultura General"),
    new PreguntaFacil("¿Qué animal hace 'miau'?", new List<string> { "Perro", "Gato", "Vaca", "Pato" }, "Gato", "Cultura General"),
    new PreguntaFacil("¿Qué comida italiana es redonda y lleva queso?", new List<string> { "Pizza", "Lasaña", "Espagueti", "Panini" }, "Pizza", "Cultura General"),

    // 15 PreguntaMedia
    new PreguntaMedia("¿Cuántos colores tiene el arcoíris?", new List<string> { "6", "7", "8", "5" }, "7", "Cultura General"),
    new PreguntaMedia("¿Quién escribió 'Don Quijote de la Mancha'?", new List<string> { "Cervantes", "Shakespeare", "García Márquez", "Borges" }, "Cervantes", "Cultura General"),
    new PreguntaMedia("¿Cuál es el idioma más hablado del mundo?", new List<string> { "Inglés", "Español", "Chino", "Árabe" }, "Chino", "Cultura General"),
    new PreguntaMedia("¿En qué país se encuentra la Torre Eiffel?", new List<string> { "Italia", "Alemania", "Francia", "Inglaterra" }, "Francia", "Cultura General"),
    new PreguntaMedia("¿Qué océano es el más grande del mundo?", new List<string> { "Atlántico", "Índico", "Pacífico", "Ártico" }, "Pacífico", "Cultura General"),
    new PreguntaMedia("¿Qué día se celebra la Navidad?", new List<string> { "31 de diciembre", "6 de enero", "25 de diciembre", "24 de noviembre" }, "25 de diciembre", "Cultura General"),
    new PreguntaMedia("¿Qué país inventó el sushi?", new List<string> { "China", "Japón", "Corea", "Tailandia" }, "Japón", "Cultura General"),
    new PreguntaMedia("¿Quién pintó la Mona Lisa?", new List<string> { "Picasso", "Van Gogh", "Da Vinci", "Michelangelo" }, "Da Vinci", "Cultura General"),
    new PreguntaMedia("¿Qué número romano representa 100?", new List<string> { "L", "C", "X", "D" }, "C", "Cultura General"),
    new PreguntaMedia("¿Cuál es la capital de Canadá?", new List<string> { "Toronto", "Vancouver", "Ottawa", "Montreal" }, "Ottawa", "Cultura General"),
    new PreguntaMedia("¿Qué animal es símbolo de la sabiduría?", new List<string> { "Búho", "Zorro", "Perro", "Caballo" }, "Búho", "Cultura General"),
    new PreguntaMedia("¿Cuál es la bebida nacional de Argentina?", new List<string> { "Mate", "Té", "Café", "Cerveza" }, "Mate", "Cultura General"),
    new PreguntaMedia("¿Cuántos minutos tiene una hora?", new List<string> { "60", "90", "100", "30" }, "60", "Cultura General"),
    new PreguntaMedia("¿Qué país tiene forma de bota?", new List<string> { "España", "Italia", "Portugal", "Grecia" }, "Italia", "Cultura General"),
    new PreguntaMedia("¿Cuál es el deporte más popular del mundo?", new List<string> { "Béisbol", "Baloncesto", "Fútbol", "Tenis" }, "Fútbol", "Cultura General"),

    // 15 PreguntaDificil
    new PreguntaDificil("¿Quién escribió 'Cien años de soledad'?", new List<string> { "Mario Vargas Llosa", "Gabriel García Márquez", "Isabel Allende", "Pablo Neruda" }, "Gabriel García Márquez", "Cultura General"),
    new PreguntaDificil("¿Cuál es el himno nacional de Francia?", new List<string> { "La Marseillaise", "Ode to Joy", "God Save the Queen", "Bella Ciao" }, "La Marseillaise", "Cultura General"),
    new PreguntaDificil("¿Cuál es el país más pequeño del mundo?", new List<string> { "Mónaco", "San Marino", "Nauru", "Ciudad del Vaticano" }, "Ciudad del Vaticano", "Cultura General"),
    new PreguntaDificil("¿En qué año cayó el muro de Berlín?", new List<string> { "1987", "1989", "1991", "1993" }, "1989", "Cultura General"),
    new PreguntaDificil("¿Qué filósofo griego fue maestro de Alejandro Magno?", new List<string> { "Platón", "Sócrates", "Aristóteles", "Demócrito" }, "Aristóteles", "Cultura General"),
    new PreguntaDificil("¿Qué autor escribió 'La Odisea'?", new List<string> { "Sófocles", "Homero", "Eurípides", "Esquilo" }, "Homero", "Cultura General"),
    new PreguntaDificil("¿En qué ciudad está el Coliseo?", new List<string> { "Atenas", "París", "Roma", "Madrid" }, "Roma", "Cultura General"),
    new PreguntaDificil("¿Quién fue el primer ser humano en el espacio?", new List<string> { "Neil Armstrong", "Yuri Gagarin", "Buzz Aldrin", "Alan Shepard" }, "Yuri Gagarin", "Cultura General"),
    new PreguntaDificil("¿Qué país organizó los Juegos Olímpicos de 2008?", new List<string> { "Grecia", "China", "Japón", "Brasil" }, "China", "Cultura General"),
    new PreguntaDificil("¿Cuál es el idioma oficial de Brasil?", new List<string> { "Español", "Portugués", "Francés", "Inglés" }, "Portugués", "Cultura General"),
    new PreguntaDificil("¿Qué cantante es conocida como 'La Reina del Pop'?", new List<string> { "Lady Gaga", "Beyoncé", "Madonna", "Rihanna" }, "Madonna", "Cultura General"),
    new PreguntaDificil("¿Cuál es el símbolo químico del oro?", new List<string> { "Au", "Ag", "O", "Gd" }, "Au", "Cultura General"),
    new PreguntaDificil("¿Quién pintó 'La noche estrellada'?", new List<string> { "Da Vinci", "Picasso", "Van Gogh", "Monet" }, "Van Gogh", "Cultura General"),
    new PreguntaDificil("¿Qué religión tiene como texto sagrado el Corán?", new List<string> { "Cristianismo", "Judaísmo", "Islam", "Budismo" }, "Islam", "Cultura General"),
    new PreguntaDificil("¿Qué premio se entrega en Suecia cada año?", new List<string> { "Grammy", "Oscar", "Nobel", "Pulitzer" }, "Nobel", "Cultura General"),
            };

        }
    }
}
