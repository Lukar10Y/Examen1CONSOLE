using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_TuProductoOnline
{
    /* Atributos: Los heredados de DatosBase(Precio,Marca,Nombre,Descripcion,Cantidad)
                        en adicion al color y el tamano ya que son caracteristicas fisicas
                        que se pueden describir facilmente y pueden interesar*/

    /*Metodos: La sobreescritura como NEW de la funcion MostrarInfo*/
    public abstract class PropiedadesFisicas : DatosBase
    {
        private double _tamano; //En pulgadas
        private string _color;

        //Constructor por Default
        public PropiedadesFisicas()
        {
            _tamano = 0;
            _color = "null";
        }

        //Constructor Parametrico
        public PropiedadesFisicas(string Marca, string Nombre, string Color, double Tamano, double Precio, int Cantidad, string Descripcion) : base(Marca, Nombre, Precio, Cantidad, Descripcion)
        {
            _color = Color;
            _tamano = Tamano;
        }
        public new virtual string MostrarInfo()
        {
            char cDoble = '"'; //ComillaDoble
            if(_tamano>0) return $"{base.MostrarInfo()}\n\n Color: {_color}\n Tamano: {_tamano}{cDoble}\n";
            else return $"{base.MostrarInfo()}\n\n Color: {_color}\n";
        }
    }
}
