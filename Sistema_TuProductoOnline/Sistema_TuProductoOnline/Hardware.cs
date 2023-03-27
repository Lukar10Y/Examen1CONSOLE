using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_TuProductoOnline
{
    /* Atributos: Los heredados de DatosBase(Precio,Marca,Nombre,Descripcion,Cantidad)
                    y Propiedades Fisicas(Tamano, Color)         

    /*Metodos: La sobreescritura de MostrarInfo*/
    public class Hardware : PropiedadesFisicas
    {
        private RGB _rgb = new RGB();
        private Inalambrico _inalambrico = new Inalambrico();
        private bool ManipuladorInfo = false; //Es un booleano que dice cuando mostrar caracteristicas extras

        //Constructor por Default
        public Hardware() { }

        //Constructor Parametrico Normal
        public Hardware(string Marca, string Nombre, string Color, double Tamano, double Precio, int Cantidad, string Descripcion) : base(Marca, Nombre, Color, Tamano, Precio, Cantidad, Descripcion)
        {
            
        }

        //Constructor Parametrico Con caracteristicas Extras
        public Hardware(string Marca, string Nombre, string Color, double Tamano, double Precio, int Cantidad, string Descripcion, bool Inalambrico, bool RGB) : base(Marca, Nombre, Color, Tamano, Precio, Cantidad, Descripcion)
        {
            _rgb.Bool = RGB;
            _inalambrico.Bool = Inalambrico;
            ManipuladorInfo = true;
        }
        public override string MostrarInfo()
        {
            if (ManipuladorInfo == true) return $"{base.MostrarInfo()} {_inalambrico.Comprobar()} {_rgb.Comprobar()} {VerCantidad()}\n\n {Descripcion}\n";
            else return $"{base.MostrarInfo()} {VerCantidad()}\n\n {Descripcion}\n";
        }
    }
}
