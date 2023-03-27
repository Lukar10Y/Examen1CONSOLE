using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_TuProductoOnline
{
    //Compilacion de Funciones Usadas a lo Largo del programa
    /*Funciones: -Para dar valores a los productos de forma pseudoaleatoria
                 -Para Mostrar los productos de cada Clase
                 -Para anadir o retirar productos en el menu
                 -para llenar datos tanto de la factura como del cliente
                 -Funcion PRINCIPAL: SISTEMA DE COMPRAS (Linea 126)*/
    public class Funcion
    {
        public static string DarColor(Random random)
        {
            int num = random.Next(1, 5);
            if (num == 1) return "Negro";
            else if (num == 2) return "Blanco";
            else if (num == 3) return "Gris";
            else return "Azul";
        }
        public static void LlenarValores(Random random, ProductoTecnologico[] ArrayDeProductos)
        {
            int num;
            string Descripcion;
            for (int i = 0; i < 5; i++)
            {
                num = random.Next(1, 4);
                if (num == 1)
                {
                    Descripcion = "El nuevo BLU G60 es un teléfono inteligente Android de clase básica";
                    ArrayDeProductos[i] = new ProductoTecnologico("Blu", "Telefono", "G60", 2018, DarColor(random), random.Next(100, 141), random.Next(10, 51), Descripcion);
                }
                else if (num == 2)
                {
                    Descripcion = "La Laptop Lenovo Smart ofrece componentes de calidad combinado con un diseño moderno y elegante\n para que uses a gusto tu ordenador para tareas cotidianas.";
                    ArrayDeProductos[i] = new ProductoTecnologico("Lenovo", "Laptop", "Smart", 2022, DarColor(random), random.Next(500, 751), random.Next(20, 31), Descripcion);
                }
                else
                {
                    Descripcion = "EL Samsung Series 2019 continua con la gran calidad de sus predecesores, increible sonorizacion\n e imagen para horas de entretenimiento.";
                    ArrayDeProductos[i] = new ProductoTecnologico("Samsung", "Televisor", "Series", 2019, "Negro", random.Next(47,53), random.Next(300, 401), random.Next(30, 41), Descripcion);
                }
            }
        }
        public static void LlenarValores(Random random, Software[] ArrayDeProductos)
        {
            int num;
            string Descripcion;
            for (int i = 0; i < 5; i++)
            {
                num = random.Next(1, 4);
                if (num == 1)
                {
                    Descripcion = "Antivirus de interfaz muy intuitiva, protección avanzada de aplicaciones en paralelo.";
                    ArrayDeProductos[i] = new Software("MacAfee", "Antivirus", random.Next(8, 11), random.Next(3, 9), 1, random.Next(20, 40), 0, random.Next(100, 251), Descripcion);
                }
                else if (num == 2)
                {
                    Descripcion = "Windows es el nombre de una familia de distribuciones de software para PC,\n teléfonos inteligentes, servidores y sistemas empotrados, desarrollados y vendidos por Microsoft\n y disponibles para múltiples arquitecturas";
                    ArrayDeProductos[i] = new Software("Windows", "Sistema Operativo", random.Next(10, 12), random.Next(20, 29), 12, random.Next(39, 50), random.Next(19, 30), random.Next(300, 400), Descripcion, true);
                }
                else
                {
                    Descripcion = "Spotify es una aplicación imprescindible para los usuarios de servicio de música online.\n Con ella podremos escuchar nuestra música y podcasts favoritos estemos donde estemos.";
                    ArrayDeProductos[i] = new Software("Spotify", "App", 8.8, 5, random.Next(0, 2), random.Next(29, 39), random.Next(49, 350), Descripcion);
                }
            }
        }
        public static void LlenarValores(Random random, Hardware[] ArrayDeProductos)
        {
            int num;
            string Descripcion;
            for (int i = 0; i < 5; i++)
            {
                num = random.Next(1, 4);
                if (num == 1)
                {
                    Descripcion = "Dispositivo de reproduccion de audio Xiaomi de Impresionante Calidad.";
                    ArrayDeProductos[i] = new Hardware("Xiaomi", "Corneta", DarColor(random), random.Next(10, 16), random.Next(20, 26), random.Next(100, 125), Descripcion);
                }
                else if (num == 2)
                {
                    Descripcion = "El esencial Razer conserva la forma ergonómica clásica que ha sido un sello\n distintivo de las generaciones anteriores. Su cuerpo elegante y distinto está diseñado para la comodidad";
                    ArrayDeProductos[i] = new Hardware("Razer", "Mouse", DarColor(random), random.Next(3, 6), 20.99, random.Next(80, 100), Descripcion, Bool(random), Bool(random));
                }
                else
                {
                    Descripcion = "Disfruta de tus partidas en otro nivel con Redragon, marca reconocida que se \n especializa en brindar la mejor experiencia de juego al público gamer desde hace más de 20 años.\n Sus teclados se adaptan a todo tipo de jugadores.";
                    ArrayDeProductos[i] = new Hardware("RedDragon", "Teclado", DarColor(random), 15.5, random.Next(60, 80), random.Next(29, 39), Descripcion, Bool(random), Bool(random));
                }
            }
        }

        public static bool Bool(Random random)
        {
            int num = random.Next(1, 3);
            if (num == 1) return true;
            else return false;
        }

         public static void MostrarContenidoLista(ProductoTecnologico[] ArrayDeProductos)
         {
             for (int i = 0; i < 5; i++)
             {
                 Console.WriteLine($"{ArrayDeProductos[i].MostrarInfo()}");
             }
         }
         public static void MostrarContenidoLista(Software[] ArrayDeProductos)
         {
             for (int i = 0; i < 5; i++)
             {
                 Console.WriteLine($"{ArrayDeProductos[i].MostrarInfo()}");
             }
         }
         public static void MostrarContenidoLista(Hardware[] ArrayDeProductos)
         {
             for (int i = 0; i < 5; i++)
             {
                 Console.WriteLine($"{ArrayDeProductos[i].MostrarInfo()}");
             }
         }
        public static void SistemaDeCompras(Software[] softwares, Hardware[] hardwares, ProductoTecnologico[] Electronicos)
        {
            ConsoleKeyInfo key1;
            ConsoleKeyInfo key2;
            CarritoDeCompras Carrito = new CarritoDeCompras();
            int Contador = 0;
            do
            {
                Console.WriteLine("\n   Bienvenid@ a TuProductoOnline");
                if (Contador == 0)
                {
                    Console.WriteLine("\n Podria indicarnos su Nombre de Usuario:");
                    Carrito.Nombre = Console.ReadLine();
                    Contador = 1;
                    Console.Clear();
                }
                Console.WriteLine("\n Que desea hacer?\n\n 1. Ver Lista de Productos\n 2. Ver Carrito de Compras\n 3. Salir");
                key1 = Console.ReadKey();
                Console.Clear();
                if (key1.KeyChar == '1')
                {
                    do
                    {
                        Console.WriteLine("\n   TuProductoOnline");
                        Console.WriteLine("\n Que Tipo de Productos desea Ver?\n\n 1. Electronicos\n 2. Softwares\n 3. Hardwares\n 4. Regresar");
                        key2 = Console.ReadKey();
                        Console.Clear();
                        if(key2.KeyChar=='1'|| key2.KeyChar == '2' || key2.KeyChar == '3' ) MenuCompra(hardwares, softwares, Electronicos, Carrito, key2.KeyChar);
                    }
                    while (key2.KeyChar != '4');
                }
                else if(key1.KeyChar == '2')
                {
                    FuncionCarrito(softwares,hardwares,Electronicos,Carrito);
                }
            }
            while (key1.KeyChar != '3');
        }
        public static void MenuCompra(Hardware[] Hardwares, Software[] softwares, ProductoTecnologico[] Electronicos, CarritoDeCompras Carrito, char Opcion)
        {
            ConsoleKeyInfo key;
            do
            {
                if (Opcion == '1') MostrarContenidoLista(Electronicos);
                else if (Opcion == '2') MostrarContenidoLista(softwares);
                else if (Opcion == '3') MostrarContenidoLista(Hardwares);
                Console.WriteLine("\n Escoja una de las siguientes opciones:");
                Console.WriteLine("\n 1. Comprar\n 2. Ver carrito de Compras\n 3. Regresar");
                key = Console.ReadKey();
                Console.Clear();
                if (key.KeyChar == '1')
                {
                    if (Opcion == '1')
                    {
                        MostrarContenidoLista(Electronicos);
                        AnadirCompra(Electronicos, Carrito, Opcion);
                    }
                    else if (Opcion == '2')
                    {
                        MostrarContenidoLista(softwares);
                        AnadirCompra(softwares, Carrito, Opcion);
                    }
                    else if (Opcion == '3') 
                    {
                        MostrarContenidoLista(Hardwares);
                        AnadirCompra(Hardwares, Carrito, Opcion); 
                    }
                }
                else if (key.KeyChar == '2')
                {
                    FuncionCarrito(softwares,Hardwares,Electronicos,Carrito);
                }
            }
            while (key.KeyChar != '3');
        }
        public static void AnadirCompra(DatosBase[] ArrayDeProductos, CarritoDeCompras Compras, char Opcion)
        {
            ConsoleKeyInfo Key;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($" {i + 1}. {ArrayDeProductos[i].DataCompra()}");
            }
            Console.WriteLine("\n Indique el Numero del producto que desea: (O Presione Cualquier Otro Numero para Regresar)\n");
            Key = Console.ReadKey();
            int Posicion = int.Parse(Key.KeyChar.ToString());
            if (Posicion > 0 && Posicion < 6 )
            {
                if (ArrayDeProductos[Posicion - 1].Cantidad > 0)
                {
                    ArrayDeProductos[Posicion - 1].Cantidad--;
                    Compras.Cuenta += ArrayDeProductos[Posicion - 1].Precio;
                    if (Opcion == '1') Compras.Electronicos[Posicion - 1]++;
                    else if (Opcion == '2') Compras.Softwares[Posicion - 1]++;
                    else if (Opcion == '3') Compras.Hardwares[Posicion - 1]++;
                    Console.Clear();
                    Console.WriteLine($"\n Producto Anadido Correctamente!\n\n {ArrayDeProductos[Posicion - 1].NombreYMarca()}\n");
                    Console.WriteLine(" Presione Cualquier Tecla para Continuar.");
                    Console.ReadKey();
                }
                else if (ArrayDeProductos[Posicion - 1].Cantidad == 0)
                {
                    Console.WriteLine("\n No hay suficiente Inventario del Producto Seleccionado\n\n");
                    Console.WriteLine(" Presione Cualquier Tecla para Continuar.");
                    Console.ReadKey();
                }
            }
            Console.Clear();
        }
        public static void RetirarProducto(DatosBase[] ArrayDeProductos, CarritoDeCompras Compras, char Opcion)
        {
            bool Confirmacion = true;
            Console.WriteLine("\n");
            for (int i = 0; i < 5; i++)
            {
                if (Opcion == '1')
                {
                    if (Compras.TotalProductos(Compras.Electronicos) != 0)
                    {
                        if (Compras.Electronicos[i] != 0)
                        {
                            Console.WriteLine($" {i+1}. {ArrayDeProductos[i].NombreYMarca()}, Adquiridos: {Compras.Electronicos[i]}");
                        }
                    }
                    else 
                    {
                        Console.Clear();
                        Console.WriteLine("\n No hay Electronico Alguno Para retirar.");
                        Confirmacion = false;
                        Console.WriteLine("\n Presione Cualquier Tecla para Continuar.");
                        Console.ReadKey();
                        i = 6;
                    }
                }
                else if (Opcion == '2') 
                {
                    if (Compras.TotalProductos(Compras.Softwares) != 0)
                    {
                        if (Compras.Softwares[i] != 0)
                        {
                            Console.WriteLine($" {i+1}. {ArrayDeProductos[i].NombreYMarca()}, Adquiridos: {Compras.Softwares[i]}");
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\n No hay Software Alguno Para retirar.");
                        Confirmacion = false;
                        Console.WriteLine("\n Presione Cualquier Tecla para Continuar.");
                        Console.ReadKey();
                        i = 6;
                    }
                }
                else if (Opcion == '3')
                {
                    if (Compras.TotalProductos(Compras.Hardwares) != 0)
                    {
                        if (Compras.Hardwares[i] != 0)
                        {
                            Console.WriteLine($" {i+1}. {ArrayDeProductos[i].NombreYMarca()}, Adquiridos: {Compras.Hardwares[i]}"); ;
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\n No hay Hardware Alguno Para retirar.");
                        Confirmacion = false;
                        Console.WriteLine("\n Presione Cualquier Tecla para Continuar.");
                        Console.ReadKey();
                        i = 6;
                    }
                }
            }
            if(Confirmacion==true)Retirar(ArrayDeProductos, Compras, Opcion);
            Console.Clear();
        }
        public static void Retirar(DatosBase[] ArrayDeProductos, CarritoDeCompras Compras, char Opcion)
        {
            ConsoleKeyInfo Key;
            bool Confirmacion = false;
            Console.WriteLine("\n Indique el numero del producto que desea retirar: (O Presione Cualquier Otro Numero para Regresar)\n");
            Key = Console.ReadKey();
            int Posicion = int.Parse(Key.KeyChar.ToString());
            if (Posicion > 0 && Posicion < 6)
            {
                if (Opcion == '1')
                {
                    if (Compras.Electronicos[Posicion - 1] > 0)
                    {
                        Compras.Electronicos[Posicion - 1]--;
                        Confirmacion = true;
                    }
                }
                else if (Opcion == '2')
                {
                    if (Compras.Softwares[Posicion - 1] > 0)
                    {
                        Compras.Softwares[Posicion - 1]--;
                        Confirmacion = true;
                    }
                }
                else if (Opcion == '3')
                {
                    if (Compras.Hardwares[Posicion - 1] > 0)
                    {
                        Compras.Hardwares[Posicion - 1]--;
                        Confirmacion = true;
                    }
                }
                if (Confirmacion == true)
                {
                    ArrayDeProductos[Posicion - 1].Cantidad++;
                    Compras.Cuenta -= ArrayDeProductos[Posicion - 1].Precio;
                    Console.Clear();
                    Console.WriteLine($"\n Producto Retirado Correctamente!\n\n {ArrayDeProductos[Posicion - 1].NombreYMarca()}\n");
                    Console.WriteLine(" Presione Cualquier Tecla para Continuar.");
                    Console.ReadKey();
                }
            }
            Console.Clear();
        }
        public static void MostrarAdquiridos(Software[] softwares, Hardware[] hardwares, ProductoTecnologico[] Electronicos, CarritoDeCompras Compras)
        {
            int NumeroDeProducto = 1;
            Console.Clear();
            Console.WriteLine("\n");
            for (int i = 0; i < 5; i++)
            {
                if (Compras.Electronicos[i] != 0)
                {
                    Console.WriteLine($" {NumeroDeProducto}. {Electronicos[i].NombreYMarca()}, Adquiridos: {Compras.Electronicos[i]}");
                    NumeroDeProducto++;
                }
            }
            for (int i = 0; i < 5; i++)
            {
                if (Compras.Hardwares[i] != 0)
                {
                    Console.WriteLine($" {NumeroDeProducto}. {hardwares[i].NombreYMarca()}, Adquiridos: {Compras.Hardwares[i]}");
                    NumeroDeProducto++;
                }
            }
            for (int i = 0; i < 5; i++)
            {
                if (Compras.Softwares[i] != 0)
                {
                    Console.WriteLine($" {NumeroDeProducto}. {softwares[i].NombreYMarca()}, Adquiridos: {Compras.Softwares[i]}");
                    NumeroDeProducto++;
                }
            }
            if(Compras.TotalProductos(Compras.Hardwares) == 0 && Compras.TotalProductos(Compras.Softwares) == 0 && Compras.TotalProductos(Compras.Electronicos) == 0)
            {
                Console.WriteLine(" Aun no ha adquirido algun producto de ninguno de nuestros Catalogos");
            }
            Console.WriteLine("\n Presione cualquier tecla para Regresar");
            Console.ReadKey();
        }
        public static void FuncionCarrito(Software[] softwares, Hardware[] hardwares, ProductoTecnologico[] Electronicos, CarritoDeCompras Carrito)
        {
            ConsoleKeyInfo Key;
            ConsoleKeyInfo Key2;
            bool Salir = false;
            do
            {
                if (Carrito.TotalProductos(Carrito.Hardwares)!=0 || Carrito.TotalProductos(Carrito.Softwares)!=0 || Carrito.TotalProductos(Carrito.Electronicos)!=0)
                {
                    Console.Clear();
                    Console.WriteLine(Carrito.MostrarDatos());
                    Console.WriteLine("\n 1. Confirmar Compra\n 2. Retirar Algun Producto\n 3. Mostrar Detalles de Productos Anadidos\n 4. Regresar\n\n");
                    Key = Console.ReadKey();
                    Console.Clear();
                    if (Key.KeyChar == '1')
                    {
                        GenerarFactura(softwares, hardwares, Electronicos, Carrito);
                    }
                    else if (Key.KeyChar == '2')
                    {
                        do
                        {
                            Console.WriteLine("\n   TuProductoOnline");
                            Console.WriteLine("\n Que Tipo de Productos desea Retirar?\n\n 1. Electronicos\n 2. Softwares\n 3. Hardwares\n 4. Regresar");
                            Key2 = Console.ReadKey();
                            Console.Clear();
                            if (Key2.KeyChar == '1') RetirarProducto(Electronicos, Carrito, Key2.KeyChar);
                            else if (Key2.KeyChar == '2') RetirarProducto(softwares, Carrito, Key2.KeyChar);
                            else if (Key2.KeyChar == '3') RetirarProducto(hardwares, Carrito, Key2.KeyChar);
                        }
                        while (Key2.KeyChar != '4');
                    }
                    else if (Key.KeyChar == '3')
                    {
                        MostrarAdquiridos(softwares, hardwares, Electronicos, Carrito);
                    }
                    else if (Key.KeyChar == '4') Salir = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(Carrito.MostrarDatos());
                    Console.WriteLine("\n Presione Cualquier Tecla Para Regresar");
                    Console.ReadKey();
                    Salir = true;
                    Console.Clear();
                }
            }
            while(Salir == false);  
        }
        public static Cliente LlenarDatosCliente()
        {
            Console.WriteLine("\n Por Favor indiquenos su Nombre:");
            string Nombre = Console.ReadLine();
            Console.WriteLine("\n Por Favor indiquenos su Apellido:");
            string Apellido = Console.ReadLine();
            Console.WriteLine("\n Por Favor indiquenos su Numero de identificacion:");
            long Cedula = long.Parse(Console.ReadLine());
            Console.WriteLine("\n Por Favor indiquenos su Numero de Telefono:");
            long Tlf = long.Parse(Console.ReadLine());
            Console.WriteLine("\n Por Favor indiquenos su Domicilio:");
            string Direccion = Console.ReadLine();
            return new Cliente(Nombre,Apellido,Direccion,Tlf,Cedula);
        }
        public static void LlenarProductosV2(DatosBase[] softwares, DatosBase[] hardwares, DatosBase[] Electronicos, CarritoDeCompras Compras, Factura Factura)
        {
            for (int i = 0; i < 5; i++)
            {
                if (Compras.Electronicos[i] != 0)
                {
                    Factura.Productos[i] = $"{Electronicos[i].MostrarInfo()} (c/u)\n";
                }
            }
            for (int i = 5; i < 10; i++)
            {
                if (Compras.Hardwares[i-5] != 0)
                {
                    Factura.Productos[i] = $"{hardwares[i-5].MostrarInfo()} (c/u)\n";
                }
            }
            for (int i = 10; i < 15; i++)
            {
                if (Compras.Softwares[i-10] != 0)
                {
                    Factura.Productos[i] = $"|{softwares[i-10].NombreYMarca()}| Precio: {softwares[i - 10].VerPrecio()} (c/u)\n";
                }
            }
        }
        public static void GenerarFactura(Software[] softwares, Hardware[] hardwares, ProductoTecnologico[] Electronicos, CarritoDeCompras Carrito)
        {
            ConsoleKeyInfo Key;
            Console.WriteLine("\n\n   Generando Factura");
            Factura factura1 = new Factura(1, 2, 22, Carrito.Cuenta, ((Carrito.Cuenta * 10) / 100));
            LlenarProductosV2(softwares, hardwares, Electronicos, Carrito, factura1);
            factura1.Cliente = LlenarDatosCliente();
            Console.Clear();
            Console.WriteLine($"\n\n      Factura {factura1.Anio} - #{factura1.Serie}\n");
            Console.WriteLine(factura1.MostrarFactura(Carrito));
            Console.WriteLine("\n Si todos los datos son Correctos\n Presione 1 Para Continuar y Confirmar la Compra\n En caso contrario, Presione cualquier otra tecla");
            Key = Console.ReadKey();
            if(Key.KeyChar == '1')
            {
                Carrito.Cuenta = 0;
                Carrito.Reiniciar();
                Console.Clear();
                Console.WriteLine("\n\n Proceso Realizado exitosamente");
                Console.WriteLine("\n Presione Cualquier Tecla Para Continuar");
                Console.ReadKey();
            }
            Console.Clear();
        }
    }
}
