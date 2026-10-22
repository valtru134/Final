using System;


namespace ProyectoFinal
{
    internal class Program

    {

        // Constante para el límite estricto de 20 registros
        const int registros = 20;

        

        static void Main(string[] args)
        {
        }

        static void ModuloUsuarios()
        {
            bool salSubmenu = false;
            while (salSubmenu == false)
            {
                Console.Clear(); // elimina el menu principal 
                Console.WriteLine($"---Modulo de Usuarios maximo: {registros}---");
                Console.WriteLine("1. Ver lista de usuarios");
                Console.WriteLine("2. Nuevo usuario");
                Console.WriteLine("3. Editar información de usuario (buscar por c.c)");
                Console.WriteLine("4. Salir de Gestión de usuarios (Menú principal)");
                Console.write("Seleccione una opción: ");
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case 1:

                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4

                        break;
                    default
                        Console.WriteLine("Opción no válida");
                        Console.ReadKey();
                        break;
                }

            }
        }

        static 


    }
}
