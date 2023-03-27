using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_TuProductoOnline
{
    /*En un contexto en el cual los productos son de un negocio de electronicos,
         considero que los atributos definidos en esta clase son los que
         se relacionan apropiadamente al producto en si y a su venta*/

    //Atributos: Precio,Marca,Nombre,Descripcion,Cantidad

    /*Metodos: Getters y Setters del precio
                Metodos para ver el nombre, marca, precio y cantidad disponible
                Ademas de otro que se encarga de ver si el articulo es gratuito*/
    
    //Funciones extras: Especificas para mostrar ciertas combinaciones de atributos 
    public abstract class DatosBase
    {
        private double _precio;
        private string _marca;
        private string _nombre;
        private string _descripcion;
        private int _cantidad; // numero de productos disponibles en inventario

        // Constructor por Default
        public DatosBase()
        {
            _precio = -1;
            _marca = "Desconocido";
            _nombre = "Producto";
            _cantidad = 0;
            _descripcion = "null";
        }

        // Constructor Para Productos Gratuitos
        public DatosBase(string Marca, string Nombre, int Cantidad, string descripcion)
        {
            _marca = Marca;
            _nombre = Nombre;
            _precio = 0;
            _cantidad = Cantidad;
            _descripcion = descripcion;
        }

        // Constructor Parametrico Normal
        public DatosBase(string Marca, string Nombre, double Precio, int Cantidad, string descripcion)
        {
            _marca = Marca;
            _nombre = Nombre;
            _precio = Precio;
            _cantidad = Cantidad;
            _descripcion = descripcion;
        }

        public string VerPrecio()
        {
            if (_precio == 0) return "Gratuito";
            else return $"{_precio}$";
        }
        protected string VerCantidad()
        {
            return $"Cantidad Disponible: {_cantidad}";
        }
        public string NombreYMarca()
        {
            return $"{_nombre} {_marca}";
        }
        public virtual string MostrarInfo()
        {
            return $"|{NombreYMarca()}| Precio: {VerPrecio()}";
        }
        public string DataCompra()
        {
            return $"{NombreYMarca()}, {VerCantidad()}";
        }
        public double Precio { set { _precio = value; } get { return _precio; } }
        public int Cantidad { set { _cantidad = value;} get { return _cantidad; } }
        protected string Descripcion { get { return $"Descripcion: {_descripcion}"; } }
    }
}  
