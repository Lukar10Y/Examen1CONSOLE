using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_TuProductoOnline
{
    public class Program
    {
        static void Main()
        {
            Random random= new Random();
            ProductoTecnologico[] Electronicos = new ProductoTecnologico[5];
            Software[] softwares= new Software[5];
            Hardware[] hardwares= new Hardware[5];
            Funcion.LlenarValores(random, Electronicos);
            Funcion.LlenarValores(random, softwares);
            Funcion.LlenarValores(random, hardwares);
            Funcion.SistemaDeCompras(softwares, hardwares, Electronicos);
        }
    }
}
