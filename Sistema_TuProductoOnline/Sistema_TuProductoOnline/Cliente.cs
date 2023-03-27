using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_TuProductoOnline
{
    // Atributos: Nombre, Apellido, Numero de Telefono, Cedula/Identificacion y Direccion del cliente
    // Metodos: Getters y Setters para los atributos mencionados
    public class Cliente
    {
        private string _nombre;
        private string _apellido;
        private long _numeroDeTlf;
        private long _cedula;
        private string _direccion;

        // Constructor por Default
        public Cliente()
        {
            _nombre = "null";
            _apellido = "null";
            _direccion= "null";
            _numeroDeTlf = -1;
            _cedula = -1;
        }

        // Constructor Parametrico
        public Cliente(string nombre, string apellido, string direccion, long numeroDeTlf, long cedula)
        {
            _nombre = nombre;
            _apellido = apellido;
            _numeroDeTlf = numeroDeTlf;
            _cedula = cedula;
            _direccion = direccion;
        }
        public string Direccion { set { _direccion = value; } get { return _direccion; } }
        public string Nombre { set { _nombre = value; } get { return _nombre; } }
        public string Apellido { set { _apellido = value;} get { return _apellido; } }
        public long NumeroDeTlf { set { _numeroDeTlf = value; } get { return _numeroDeTlf; } }
        public long Cedula { set { _cedula = value;} get { return _cedula; } }
    }
}
