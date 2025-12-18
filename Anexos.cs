// Definicion del registro Contacto
//Se utiliza una estructura (struct) para agrupar
//Los datos principales de un contacto telefonico: nombre, telefono, correo y direccion.

using System.Diagnostics.Contracts;

public struct Contacto
{
    public string Nombre; // Nombre completo del contacto
    public string Telefono; // Número de teléfono del contacto
    public string Correo; // Dirección de correo electrónico del contacto
    public string Direccion; // Dirección física del contacto
}
