using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoCriatura
{
    public class Juego 
    {

        // Atributos
        private List<Jugador> jugadores;
        private List<Criatura> criaturas;

        // Constructor
        public Juego(string nombre)
        {
            this.jugadores = new List<Jugador>();
            this.criaturas = new List<Criatura>();
        }

        //metodos

        public void IniciarJuego()
        {
            // Lógica para iniciar el juego
        }

        public void decidirTurno()
        {
            // Lógica para decidir el turno
        }
        public void verificaGanador()
        {
            // Lógica para determinar el ganador
        }
    }
}
