using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
    public class Pedido
    {
        private string id;
        private string fechaRealizacion;
        private string estado;
        private string total;

        public string Id { get => id; set => id = value; }
        public string FechaRealizacion { get => fechaRealizacion; set => fechaRealizacion = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Total { get => total; set => total = value; }

        public string Descripcion()
        {
            return "El Método Descripcion todavía no se ha implementado";
        }

        public string ActualizacionStock()
        {
            return "El Método Actualizacion de Stock todavía no se ha implementado";
        }

        public string Cancelacion()
        {
            return "El Método Cancelacion todavía no se ha implementado";
        }

        public string Cotizar()
        {
            return "El Método Cotizar todavía no se ha implementado";
        }
    }
}