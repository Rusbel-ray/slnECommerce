using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
    public class Producto
    {
        private string calidad;
        private string denominacion;
        private string id;
        private string proveedor;

        public string Calidad { get => calidad; set => calidad = value; }
        public string Denominacion { get => denominacion; set => denominacion = value; }
        public string Id { get => id; set => id = value; }
        public string Proveedor { get => proveedor; set => proveedor = value; }

        public string Deteriorar()
        {
            return "El Método Deteriorar todavía no se ha implementado";
        }

        public string Destacar()
        {
            return "El Método Destacar todavía no se ha implementado";
        }
    }
}