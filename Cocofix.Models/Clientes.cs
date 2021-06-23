namespace Cocofix.Models
{
    public class Cliente
    {
        public string NombreCliente;
        public string ApellidoCliente;
        public int DNI;
        public uint Celular;
        public uint CelularContacto;
        public string Domicilio;
        public string Mail;

        public Cliente(string nombre, string apellido, int dni, uint celular, uint celularContacto, string domicilio, string mail) {
            NombreCliente = nombre;
            ApellidoCliente = apellido;
            DNI = dni;
            Celular = celular;
            CelularContacto = celularContacto;
            Domicilio = domicilio;
            Mail = mail;
        }
    }
}