using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa41024
{
    internal class menu
    {


        //MENU PRINCIPAL

        public static void principal()
        {
            int opcion = 0;


                do
            {
                Console.WriteLine("1- Inicializar arreglos");
                Console.WriteLine("2- Ingresar Articulos");
                Console.WriteLine("3- Modificar Articulos");
                Console.WriteLine("4- Borrar Articulos");
                Console.WriteLine("5- Consultar Articulos");
                Console.WriteLine("6- Consultar Bodegas");
                Console.WriteLine("7- Salir");
                Console.WriteLine("Digite una opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {

                        case 1: articulos.inicializarArreglos(); break;
                        case 2: articulos.ingresarProductos();  break;
                        case 3: articulos.modificarProductos(); break;
                        case 4: articulos.excluirProductos(); break;
                        case 5: articulos.consultarProductos(); break;
                        case 6: articulos.bodega(); break;
                        case 7: Console.WriteLine("Saliendo del sistema......."); break;
                        default: Console.WriteLine("*** Opcion Incorrecta ***"); break; 
                    
                }

            } while (opcion != 7); //mientras opcion sea diferente de 7  ==> 


            


        }
       











    }
}
