using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_TuProductoOnline
{
    //CLASE EXTRA PARA COMPLEMENTAR LA CLASE SOFTWARE

    //Atributos: Precio,Duracion y Periocidad (para saber si es anual o mensual

    //Metodos: Los suficientes como para acceder y modificar los atributos mencionados
    public class Suscripcion
    {
        private double _precio; // Precio de la suscripcion
        private int _duracion; // Periodo de uso desde su compra, si es que hay un limite, en caso contrario no habra limite
        private bool _periocidad;

        //Contructor por Default
        public Suscripcion()
        {
            _precio = -1;
            _duracion = -1;
            _periocidad = false;
        }

        //Constructor Parametrico mensual
        public Suscripcion(double Precio, int Duracion)
        {
            _precio = Precio;
            _duracion = Duracion;
            _periocidad = false;
        }

        //Constructor Parametrico Anual
        public Suscripcion(double Precio, int Duracion, bool Periocidad)
        {
            _precio = Precio;
            _duracion = Duracion;
            _periocidad = Periocidad;
        }
        public double Precio { set { _precio = value; } get { return _precio; } }
        public int Duracion { set { _duracion = value; } get { return _duracion; } }
        public bool Periocidad { set { _periocidad = value; } get { return _periocidad; } }
    }
}
