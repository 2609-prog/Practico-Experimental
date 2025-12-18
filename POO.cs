using System;

// Namespace del proyecto
namespace CPE01
{
    // Clase AgendaTelefonica
    // Gestiona la lógica de la agenda usando estructuras de datos
    class AgendaTelefonica
    {
        // Arreglo de tipo Contacto para almacenar los registros
        private Contacto[] contactos;

        // Contador que controla la cantidad de contactos almacenados
        private int contador;

        // Constructor de la clase
        // Inicializa el arreglo con el tamaño indicado
        public AgendaTelefonica(int tamaño)
        {
            contactos = new Contacto[tamaño];
            contador = 0;
        }

        // Método para agregar un nuevo contacto a la agenda
        public void AgregarContacto()
        {
            // Verifica si existe espacio disponible
            if (contador < contactos.Length)
            {
                Contacto c = new Contacto();

                // Ingreso de los datos del contacto
                Console.Write("Ingrese el nombre: ");
                c.Nombre = Console.ReadLine() ?? "";

                Console.Write("Ingrese el teléfono: ");
                c.Telefono = Console.ReadLine() ?? "";

                Console.Write("Ingrese el correo: ");
                c.Correo = Console.ReadLine() ?? "";

                Console.Write("Ingrese la dirección: ");
                c.Direccion = Console.ReadLine() ?? "";

                // Se almacena el contacto en el arreglo
                contactos[contador] = c;
                contador++;

                Console.WriteLine("Contacto agregado correctamente.");
            }
            else
            {
                // Mensaje cuando la agenda está llena
                Console.WriteLine("La agenda se encuentra llena.");
            }
        }

        // Método para mostrar todos los contactos registrados
        public void MostrarContactos()
        {
            Console.WriteLine("\nLISTA DE CONTACTOS REGISTRADOS");

            // Recorre el arreglo hasta el número de contactos almacenados
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine($"{i + 1}. {contactos[i].Nombre} - {contactos[i].Telefono}");
            }
        }

        // Método para buscar un contacto por su nombre
        public void BuscarContacto(string nombre)
        {
            // Búsqueda secuencial en el arreglo
            for (int i = 0; i < contador; i++)
            {
                if (!string.IsNullOrEmpty(contactos[i].Nombre) &&
                    contactos[i].Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("\nCONTACTO ENCONTRADO");
                    Console.WriteLine($"Nombre: {contactos[i].Nombre}");
                    Console.WriteLine($"Teléfono: {contactos[i].Telefono}");
                    Console.WriteLine($"Correo: {contactos[i].Correo}");
                    Console.WriteLine($"Dirección: {contactos[i].Direccion}");
                    return;
                }
            }

            // Mensaje si el contacto no fue encontrado
            Console.WriteLine("El contacto no fue encontrado.");
        }
    }
}
