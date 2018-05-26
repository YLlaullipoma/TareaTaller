using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JesusLlaullipoma
{
    class Comida
    {
        public string nombrePlato;
        public string Ingredientes;
        //tiempo medidio en minutos
        public float tiempoPreparacion;
        public string instrumentos;
        public bool servido;

        public void Servir()
        {
            servido = true;
        }

        public Comida(string nombrePlato, string Ingredientes, float tiempoPreparacion, string instrumentos)
        {
            this.nombrePlato = nombrePlato;
            this.Ingredientes = Ingredientes;
            this.tiempoPreparacion = tiempoPreparacion;
            this.instrumentos = instrumentos;
        }
    }
}
