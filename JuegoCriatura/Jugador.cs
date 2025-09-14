using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoCriatura
{
    public class Jugador
    {

        // Atributos

        private string nombre;
        private List<Criatura> criaturas;
        private int puntaje;
        private int victorias;

        // Constructor
        public Jugador(string nombre)
        {
            this.criaturas = new List<Criatura>();
            this.nombre = nombre;
            this.puntaje = 0;
            this.victorias = 0;
        }

        // Metodos
        public List<Criatura> SeleccionarCriatura(string nombre)
        {
            // Lógica para seleccionar una criatura
        
        }

        public void jugarTurno()
        {
            // Lógica para jugar un turno
        }
    }
}
