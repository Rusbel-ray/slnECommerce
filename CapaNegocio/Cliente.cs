using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Cliente
    {
        private string id;
        private string direccion;
        private string telefono;
        private string email;

        public string Id { get => id; set => id = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }


        //Métodos
        public string Comprar()
        {
            return "El Método Comprar todavía no se ha implementado";
        }

        public string Buscar()
        {
            return "El Método Buscar todavía no se ha implementado";
        }

        public string Recomendar()
        {
            return "El Método Recomendar todavía no se ha implementado";
        }

        public string Reclamar()
        {
            return "El Método Reclamar todavía no se ha implementado";
        }
    }
}
