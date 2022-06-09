using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosAnonimos
{
    class Punto
    {
        public delegate void DelMensaje();
        public DelMensaje mensaje;

        private int x;
        private int y;

        public Punto(int px, int py)
        {
            x = px;
            y = py;
        }

        public override string ToString()
        {
            return string.Format("X={0} ,Y={1}", x, y);
        }
    }
}
