using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_TuProductoOnline
{
    /* Atributos: Nombre de la Empresa, Serie de la Factura, dia, mes y anio de emision, rif, direccion,
     correo y Numero de Telefono de la Empresa. Monto total e impuesto de la compra. Ademas de un arreglo donde
     se podran guardar datos de los productos en strings y una instancia de la clase Cliente para
     identificar al mismo*/

    /*Metodos: Getters y Setters de algunos Parametros ya mencionados (Se terminan usando muy pocos)
      Una funcion para llenar cada espacio del vector de productos con "null" para mayor comodidad.
      Y otra Funcion para mostrar la factura en si ya hecha*/  
    public class Factura
    {
        private string _empresa;
        private int _serie;
        private int _anio;
        private int _mes;
        private int _dia;
        private string _rif;
        private string _direccion;
        private string _correo;
        private long _numeroDeTlf;
        private double _total;
        private double _impuesto;
        private string[] _productos = new string[15];
        private Cliente _cliente;
        public Factura()
        {
            _empresa = "Desconocida";
            _serie = -1;
            _anio = -1;
            _mes = -1;
            _dia = -1;
            _rif = "null";
            _direccion = "Desconocida";
            _correo = "null";
            _numeroDeTlf = -1;
            _total = -1;
            _impuesto = -1;
        }
        public Factura(int serie, int mes, int dia, double total, double impuesto)
        {
            _empresa = "TuProductoOnline";
            _serie = serie;
            _anio = 2023;
            _mes = mes;
            _dia = dia;
            _rif = "J452678911";
            _direccion = "2090 Kaylee Stravenue Suite 400";
            _correo = "TuProductoOnline@gmail.com";
            _numeroDeTlf = 02747041370;
            _total = total;
            _impuesto = impuesto;
            Null();
        }
        private void Null()
        {
            for (int i=0; i<15; i++)
            {
                _productos[i] = "null";
            }
        }
        public string MostrarFactura(CarritoDeCompras Compras)
        {
            string Lista = "\n";
            int NumeroProducto = 1;
            for (int i = 0; i < 5; i++)
            {
                if (_productos[i] != "null")
                {
                    Lista += $" {NumeroProducto}' {Compras.Electronicos[i]}x {_productos[i]}";
                    NumeroProducto++;
                }
            }
            for (int i = 0; i < 5; i++)
            {
                if (_productos[i+5] != "null")
                {
                    Lista += $" {NumeroProducto}' {Compras.Hardwares[i]}x {_productos[i+5]}";
                    NumeroProducto++;
                }
            }
            for (int i = 0; i < 5; i++)
            {
                if (_productos[i+10] != "null")
                {
                    Lista += $" {NumeroProducto}' {Compras.Softwares[i]}x {_productos[i+10]}";
                    NumeroProducto++;
                }
            }
            return $" {_empresa} rif: {_rif}\n\n  {_dia}/{_mes}/{_anio}\n\n Direccion: {_direccion}\n Correo: {_correo}\n Telefono: {_numeroDeTlf}\n\n Cliente: {_cliente.Nombre} {_cliente.Apellido}\n C.I o RIF: {_cliente.Cedula}\n\n Direccion: {_cliente.Direccion}\n Numero de Contacto: {_cliente.NumeroDeTlf}\n {Lista}\n Impuesto(10%): {_impuesto}$\n Total: {(_impuesto+_total)}$";
        }
        public string[] Productos { get { return _productos; } set { _productos = value; } }
        public Cliente Cliente { get { return _cliente; } set { _cliente = value; } }
        public int Anio { get { return _anio; } set { _anio = value; } }
        public int Serie { get { return _serie; } set { _serie = value; } }
        public int Mes { get { return _mes; } set { _mes = value; } }
        public int dia { get { return _dia; } set { _dia = value; } }
        public double Total { get { return _total;} set { _total = value; } }
        public double Impuesto { get { return _impuesto; } set { _impuesto= value; } }
    }
}
