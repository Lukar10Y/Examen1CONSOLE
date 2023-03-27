using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_TuProductoOnline
{
    //Atributos: Nombre del Cliente, Arreglos de enteros donde llevo la cuenta de cuantos productos se han seleccionado
    //           Por cada Categoria, y un doble para llevar la Deuda total segun lo que se vaya comprando

    //Metodos: getters y Setters para los atributos mencionados anteriormente
    public class CarritoDeCompras
    {
        private string _nombre;
        private int[] _softwares = new int[5];
        private int[] _hardwares = new int[5];
        private int[] _electronicos = new int[5];
        private double _cuenta;

        // Constructor por Default
        public CarritoDeCompras()
        {
            _nombre = "Null";
            _cuenta = 0;
            Reiniciar();
        }

        // Funcion para reiniciar los valores de los vectores en 0
        public void Reiniciar()
        {
            for(int i=0; i<5; i++) 
            {
                _softwares[i] = 0;
                _hardwares[i] = 0;
                _electronicos[i] = 0;
            }
        }

        // Funcion Para retornar la cantidad total de productos de los vectores
        public int TotalProductos(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        public string MostrarDatos()
        {
            return $"\n  Carrito de {_nombre}\n\n Deuda Actual: {_cuenta}$\n Softwares Seleccionados: {TotalProductos(_softwares)}\n Hardwares Seleccionados: {TotalProductos(_hardwares)}\n Electronicos Seleccionados: {TotalProductos(_electronicos)}\n";
        }
        public double Cuenta { set { _cuenta = value; } get { return _cuenta; } }
        public string Nombre { set { _nombre = value; } get { return _nombre; } }
        public int[] Softwares { set { _softwares = value; } get { return _softwares; } }
        public int[] Hardwares { set { _hardwares = value; } get { return _hardwares; } }
        public int[] Electronicos { set { _electronicos = value; } get { return _electronicos; } }
    }
}
