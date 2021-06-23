using System;
using Cocofix.Models;
using Cocofix.Logic;
using System.Collections.Generic;

namespace Cocofix.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Clientes logic = new Clientes();

            logic.Guardar(new Cliente ("Facundo","Laya", 32104799, 2235762207, 2235572111,"Santiago del Estero 4165","facumdq@hotmail.com"));
            

           List<Cliente> lista = logic.Listar(); 
           foreach (var item in lista)
           {
               Console.WriteLine(item.NombreCliente);
               Console.WriteLine(item.ApellidoCliente);
               Console.WriteLine(item.Celular);
               Console.WriteLine(item.DNI);
               Console.WriteLine(item.Mail);
           }
        }
    }
}
