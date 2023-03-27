using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_TuProductoOnline
{
    //CLASES EXTRAS que trabajan con valores booleanos para indicar otra caracteristica distintiva

    //Clase para Describir Luces LED mayormente en Hardwares
    public class RGB
    {
        private bool _luces;

        public RGB()
        {
            _luces = false;
        }
        public RGB(bool Luces)
        {
            _luces = Luces;
        }

        public bool Bool { get { return _luces; } set { _luces = value; } }
        public string Comprobar()
        {
            if (Bool == true) return "Luces LED RGB: Si\n";
            else return "Luces LED RGB: No\n";
        }
    }

    //Clase para Describir productos posiblemente inalambricos; mayormente en Hardwares
    public class Inalambrico
    {
        private bool _inalambrico;

        public Inalambrico()
        {
            _inalambrico = false;
        }
        public Inalambrico(bool Inalambrico)
        {
            _inalambrico = Inalambrico;
        }

        public bool Bool { get { return _inalambrico; } set { _inalambrico = value; } }
        public string Comprobar()
        {
            if (Bool == true) return "Inalambrico\n";
            else return "Alambrico\n";
        }
    }
}
