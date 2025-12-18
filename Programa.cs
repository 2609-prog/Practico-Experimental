using System;
using CPE01;

// Clase principal del programa, punto de inicio de la aplicacion
//Contiene el metodo Main

class Program
{
    
    static void Main()
    {
        //Se crea un objeto de la clase AgendaTelefonica: capacidad 10 contactos
        AgendaTelefonica agenda = new AgendaTelefonica(10);
        int opcion;


        //Menu principal de la aplicacion
        do
        {
            Console.WriteLine("\nAGENDA TELEFÓNICA");
            Console.WriteLine("1. Agregar contacto");
            Console.WriteLine("2. Mostrar contactos");
            Console.WriteLine("3. Buscar contacto");
            Console.WriteLine("4. Salir");
            Console.WriteLine("Seleccione una opción: ");


            opcion = int.Parse(Console.ReadLine() ?? "0");
            
            // Estructura de control para ejecutar la opcion seleccionada
            switch (opcion)
            {
                case 1:
                    agenda.AgregarContacto();
                    break;
                case 2:
                    agenda.MostrarContactos();
                    break;
                case 3:
                    Console.Write("Ingrese el nombre del contacto a buscar: ");
                    string nombre = Console.ReadLine() ?? "";
                    agenda.BuscarContacto(nombre);
                    break;
                case 4:
                    Console.WriteLine("Saliendo del sistema...");
                    break;        

            }        
        } while (opcion != 4);
    }
}

