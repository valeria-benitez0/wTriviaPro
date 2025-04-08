using TriviaPro.Logica;
using TriviaPro.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriviaPro
{
    public partial class Form1 : Form
    {
        private Pregunta preguntaActual;
        private Jugador jugador;
        private TemporizadorTrivia temporizador;
        private int totalPreguntas = 15;
        private int preguntasRespondidas = 0;

        private List<RadioButton> opcionesRadioButtons;
        public Form1()
        {
            InitializeComponent();
            InicializarComponentesPersonalizados();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InicializarComponentesPersonalizados()
        {
            // Iniciar combo boxes
            comboCategoria.Items.AddRange(new string[] { "Ciencia", "Historia", "Cultura General" });
            comboNivel.Items.AddRange(new string[] { "Fácil", "Medio", "Difícil" });

            // Crear lista de RadioButtons
            opcionesRadioButtons = new List<RadioButton> { rbOpcion1, rbOpcion2, rbOpcion3, rbOpcion4 };

            // Iniciar timer lógico
            temporizador = new TemporizadorTrivia();
            temporizador.TiempoFinalizado += TiempoAgotado;
            temporizador.TiempoActualizado += ActualizarTiempoVisual;

            btnResponder.Enabled = false;
            btnReiniciar.Enabled = false;
        }
        private void comboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (comboCategoria.SelectedItem == null || comboNivel.SelectedItem == null)
            {
                MessageBox.Show("Por favor selecciona una categoría y un nivel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            jugador = new Jugador("Jugador 1");
            PreguntaFactory.ReiniciarPreguntas();
            preguntasRespondidas = 0;
            listHistorial.Items.Clear();
            lblPuntaje.Text = "Puntaje: 0";
            lblPreguntasRestantes.Text = $"Preguntas: {totalPreguntas - preguntasRespondidas}";

            comboCategoria.Enabled = false;
            comboNivel.Enabled = false;
            btnIniciar.Enabled = false;
            btnResponder.Enabled = true;
            btnReiniciar.Enabled = true;

            CargarSiguientePregunta();
        }

        private void CargarSiguientePregunta()
        {
            try
            {
                preguntaActual = PreguntaFactory.ObtenerPregunta(comboCategoria.SelectedItem.ToString(), comboNivel.SelectedItem.ToString());

                lblPregunta.Text = preguntaActual.Texto;
                var opciones = preguntaActual.Opciones.OrderBy(o => Guid.NewGuid()).ToList();

                for (int i = 0; i < opcionesRadioButtons.Count; i++)
                {
                    if (i < opciones.Count)
                    {
                        opcionesRadioButtons[i].Text = opciones[i];
                        opcionesRadioButtons[i].Visible = true;
                        opcionesRadioButtons[i].Checked = false;
                    }
                    else
                    {
                        opcionesRadioButtons[i].Visible = false;
                    }
                }

                temporizador.Iniciar(preguntaActual.ObtenerTiempo());
                progressTiempo.Maximum = preguntaActual.ObtenerTiempo();
                progressTiempo.Value = preguntaActual.ObtenerTiempo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar pregunta: " + ex.Message);
            }
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            string respuestaSeleccionada = opcionesRadioButtons.FirstOrDefault(rb => rb.Checked)?.Text;

            if (respuestaSeleccionada == null)
            {
                MessageBox.Show("Selecciona una respuesta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            temporizador.Detener();

            bool correcta = preguntaActual.EvaluarRespuesta(respuestaSeleccionada);

            if (correcta)
            {
                jugador.AcertarPregunta(preguntaActual.ObtenerPuntaje());
                MessageBox.Show("¡Correcto!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                jugador.FallarPregunta();
                MessageBox.Show($"Incorrecto. La respuesta era: {preguntaActual.RespuestaCorrecta}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            preguntasRespondidas++;
            listHistorial.Items.Add($"{preguntasRespondidas}. {preguntaActual.Texto} - {(correcta ? "✅" : "❌")}");

            lblPuntaje.Text = $"Puntaje: {jugador.Puntaje}";
            lblPreguntasRestantes.Text = $"Preguntas: {totalPreguntas - preguntasRespondidas}";

            if (preguntasRespondidas >= totalPreguntas)
            {
                FinalizarJuego();
            }
            else
            {
                CargarSiguientePregunta();
            }
        }

        private void TiempoAgotado()
        {
            MessageBox.Show($"¡Se acabó el tiempo!\nLa respuesta era: {preguntaActual.RespuestaCorrecta}", "Tiempo Agotado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            jugador.FallarPregunta();

            preguntasRespondidas++;
            listHistorial.Items.Add($"{preguntasRespondidas}. {preguntaActual.Texto} - ⏱️");

            lblPuntaje.Text = $"Puntaje: {jugador.Puntaje}";
            lblPreguntasRestantes.Text = $"Preguntas: {totalPreguntas - preguntasRespondidas}";

            if (preguntasRespondidas >= totalPreguntas)
            {
                FinalizarJuego();
            }
            else
            {
                CargarSiguientePregunta();
            }
        }

        private void ActualizarTiempoVisual(int segundos)
        {
            lblTiempo.Text = $"Tiempo: {segundos}s";
            progressTiempo.Value = segundos;
        }

        private void FinalizarJuego()
        {
            btnResponder.Enabled = false;
            MessageBox.Show($"Juego finalizado.\nPuntaje final: {jugador.Puntaje}\nCorrectas: {jugador.PreguntasCorrectas}\nIncorrectas: {jugador.PreguntasIncorrectas}", "Resumen", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            comboCategoria.Enabled = true;
            comboNivel.Enabled = true;
            btnIniciar.Enabled = true;
            btnResponder.Enabled = false;
            btnReiniciar.Enabled = false;

            lblPregunta.Text = "Pregunta";
            foreach (var rb in opcionesRadioButtons)
            {
                rb.Text = "";
                rb.Visible = false;
            }

            lblTiempo.Text = "Tiempo: 0s";
            progressTiempo.Value = 0;
            lblPuntaje.Text = "Puntaje: 0";
            lblPreguntasRestantes.Text = "Preguntas: 15";
            listHistorial.Items.Clear();
        }


    }
}
