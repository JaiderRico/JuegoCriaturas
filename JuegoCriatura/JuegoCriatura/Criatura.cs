using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoCriatura
{
    public abstract class Criatura
    {
        public required string Nombre;
        public decimal Vida;
        public decimal energia;
        public required string habilidadEspecial;

        public abstract void recibirDanio(decimal danio);
        public abstract bool estaVivo();
        public abstract void accion();
    }
}
