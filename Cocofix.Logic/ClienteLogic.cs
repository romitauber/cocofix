using System;
using System.Collections.Generic;
using Cocofix.Models;


namespace Cocofix.Logic
{
    public class Clientes
    {
        List<Cliente> agenda = new List<Cliente>(); 
        
        public void Guardar(Cliente cliente) 
        {
            if (!string.IsNullOrWhiteSpace(cliente.NombreCliente) && !string.IsNullOrWhiteSpace(cliente.ApellidoCliente) && !string.IsNullOrWhiteSpace(cliente.Domicilio)) {
                this.agenda.Add(cliente);
                

            } else {
                throw new Exception("Los campos nombre, apellido y domicilio no pueden estar vacios");
            }
        }


        public List<Cliente> Listar() {
            return agenda;
        }
    }
}