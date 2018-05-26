using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JesusLlaullipoma
{
    class Consumibles
    {
        public string nombreConsumible;
        public float maxCantidad;
        public float cantidad;
        public bool maduro;
        public bool limpio;
        public bool picado;
        public bool frito;
        public bool cocido;
        public bool pelado;
        public bool hervido;

        public void Fresco()
        {
            maduro = true;
        }

        public void Lavar()
        {
            limpio = true;
        }

        public void Picar()
        {
            picado = true;
        }

        public void Freir()
        {
            frito = true;
        }

        public void Cocer()
        {
            cocido = true;
        }

        public void Pelar()
        {
            pelado = true;
        }

        public void Hervir()
        {
            hervido = true;
        }

        public Consumibles(string nombreConsumible, float maxCantidad, float cantidad)
        {
            this.nombreConsumible = nombreConsumible;
            this.maxCantidad = maxCantidad;
            this.cantidad = cantidad;
        }
    }
}
