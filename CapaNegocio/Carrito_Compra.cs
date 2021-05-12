using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
    public class Carrito_Compra
    {
        private string fechaCreacion;
        private string cantidadProductos;

        public string FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        public string CantidadProductos { get => cantidadProductos; set => cantidadProductos = value; }

        public string Registrar()
        {
            return "El Método Registrar todavía no se ha implementado";
        }

        public string Detallar()
        {
            return "El Método Detallar todavía no se ha implementado";
        }

        public string Almacenar()
        {
            return "El Método Almacenar todavía no se ha implementado";
        }
    }
}