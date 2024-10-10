using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace programa41024
{
    internal class articulos
    {
        public static int[] id = new int[3];
        public static string[] nombre = new string[3];
        public static float[] precio = new float[3];
        public static int[] cantidadProductos = new int[3];
        public static int[] bodegas = new int[3];

        // Método para inicializar arreglos
        public static void inicializarArreglos()
        {
            for (int i = 0; i < id.Length; i++)
            {
                id[i] = 0;
                nombre[i] = "";
                precio[i] = 0;
                cantidadProductos[i] = 0;
                bodegas[i] = 0;
            }
            Console.WriteLine("Los arreglos han sido inicializados");
            Console.Clear();
        }

        // Método para ingresar productos
        public static void ingresarProductos()
        {
            int indice = 0;
            while (indice < id.Length)
            {
                Console.WriteLine("Digite un código: ");
                id[indice] = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite un artículo: ");
                nombre[indice] = Console.ReadLine();

                Console.WriteLine("Digite el precio del artículo: ");
                precio[indice] = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite el stock del producto: ");
                cantidadProductos[indice] = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a la bodega que quiere enviar los productos (1, 2 o 3): ");
                bodegas[indice] = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite la cantidad que quiere enviar a la bodega: ");
                int cantidadBodega = int.Parse(Console.ReadLine());

                cantidadProductos[indice] = cantidadBodega;
                indice++;
                Console.Clear();
            }
            Console.WriteLine("Los artículos han sido ingresados");
        }

        // Método para modificar productos
        public static void modificarProductos()
        {
            Console.Clear();
            Console.WriteLine("Digite el código del artículo que desea modificar: ");
            int nuevoCodigo = int.Parse(Console.ReadLine());

            for (int i = 0; i < id.Length; i++)
            {
                if (nuevoCodigo == id[i])
                {
                    Console.WriteLine($"Código : {id[i]} Nombre: {nombre[i]} Precio: $ {precio[i]} Stock: {cantidadProductos[i]}");
                    Console.WriteLine("Digite un nuevo nombre: ");
                    nombre[i] = Console.ReadLine();
                    Console.WriteLine("Digite un nuevo precio: ");
                    precio[i] = float.Parse(Console.ReadLine());
                    Console.WriteLine("Digite el nuevo stock: ");
                    cantidadProductos[i] = int.Parse(Console.ReadLine());
                    break;
                }
            }
        }

        // Método para consultar productos
        public static void consultarProductos()
        {
            Console.Clear();
            Console.WriteLine("***REPORTE DE ARTÍCULOS***");

            for (int i = 0; i < id.Length; i++)
            {
                Console.WriteLine($"Código : {id[i]} Nombre: {nombre[i]} Precio: $ {precio[i]} Stock: {cantidadProductos[i]}");
            }
            Console.WriteLine("***FIN DEL REPORTE***");
        }

        // Método para eliminar productos
        public static void excluirProductos()
        {
            Console.Clear();
            Console.WriteLine("Digite el código del producto que desea eliminar: ");
            int codigoEliminar = int.Parse(Console.ReadLine());

            for (int i = 0; i < id.Length; i++)
            {
                if (id[i] == codigoEliminar)
                {
                    Console.WriteLine($"Producto '{nombre[i]}' eliminado.");
                    id[i] = -1;  // Marcar como eliminado
                    nombre[i] = "Eliminado";
                    cantidadProductos[i] = 0;
                    bodegas[i] = 0;
                    break;
                }
            }
        }

        // Método para consultar cantidad en una bodega específica con nombres de productos
        public static void bodega()
        {
            Console.WriteLine("Digite la bodega que quiere consultar (1, 2 o 3): ");
            int bodegaSeleccionada = int.Parse(Console.ReadLine());

            int cantidadTotalEnBodega = 0;
            bool hayProductos = false;

            Console.WriteLine($"Productos en la Bodega {bodegaSeleccionada}:");
            for (int i = 0; i < bodegas.Length; i++)
            {
                if (bodegas[i] == bodegaSeleccionada)
                {
                    hayProductos = true;
                    cantidadTotalEnBodega += cantidadProductos[i];
                    Console.WriteLine($"Producto: {nombre[i]}, Cantidad: {cantidadProductos[i]}");
                }
            }

            if (!hayProductos)
            {
                Console.WriteLine($"No hay productos almacenados en la Bodega {bodegaSeleccionada}.");
            }
            else
            {
                Console.WriteLine($"Total de productos en la Bodega {bodegaSeleccionada}: {cantidadTotalEnBodega}");
            }
        }
    }
}

