using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriviaPro.Logica
{
    public class TemporizadorTrivia
    {
        private Timer _timer;
        private int _segundosRestantes;

        public event Action TiempoFinalizado;
        public event Action<int> TiempoActualizado;

        public int TiempoInicial { get; private set; }

        public TemporizadorTrivia()
        {
            _timer = new Timer();
            _timer.Interval = 1000; // 1 segundo
            _timer.Tick += Timer_Tick;
        }

        public void Iniciar(int segundos)
        {
            Detener(); // por si estaba corriendo antes
            TiempoInicial = segundos;
            _segundosRestantes = segundos;
            _timer.Start();
            TiempoActualizado?.Invoke(_segundosRestantes);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _segundosRestantes--;

            if (_segundosRestantes <= 0)
            {
                _timer.Stop();
                TiempoActualizado?.Invoke(0);
                TiempoFinalizado?.Invoke();
            }
            else
            {
                TiempoActualizado?.Invoke(_segundosRestantes);
            }
        }

        public void Detener()
        {
            _timer.Stop();
        }

        public void Reiniciar()
        {
            Iniciar(TiempoInicial);
        }

        public int ObtenerTiempoRestante()
        {
            return _segundosRestantes;
        }
    }
}
