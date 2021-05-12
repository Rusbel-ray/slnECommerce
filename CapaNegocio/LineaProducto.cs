using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
    public class LineaProducto
    {
        private string cantidad;
        private string categoria;
        private string precio;

        public string Cantidad { get => cantidad; set => cantidad = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public string Precio { get => precio; set => precio = value; }

        public string ActualizarStock()
        {
            return "El Método Actualizar Stock todavía no se ha implementado";
        }

        public string Ofertas()
        {
            return "El Método Ofertas todavía no se ha implementado";
        }

        public string Reseñas()
        {
            return "El Método Reseñas todavía no se ha implementado";
        }

        public string Comentarios()
        {
            return "El Método Comentarios todavía no se ha implementado";
        }

        public string Destacar()
        {
            return "El Método Destacar todavía no se ha implementado";
        }
    }
}