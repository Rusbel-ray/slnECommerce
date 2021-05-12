using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
    public class Envio
    {
        private string id;
        private string direccionfacturacion;
        private string compania;
        private string finalizado;
        private string fechaenvio;

        public string Id { get => id; set => id = value; }
        public string Direccionfacturacion { get => direccionfacturacion; set => direccionfacturacion = value; }

        public string Compania { get => compania; set => compania = value; }
        public string Finalizado { get => finalizado; set => finalizado = value; }
        public string Fechaenvio { get => fechaenvio; set => fechaenvio = value; }

        public string EntregarProducto()
        {
            return "El Método Entregar producto todavía no se ha implementado";
        }

        public string ConfirmarEntrega()
        {
            return "El Método Confirmar entregar todavía no se ha implementado";
        }
    }
}