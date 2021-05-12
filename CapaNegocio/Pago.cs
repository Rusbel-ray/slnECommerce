using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
    public class Pago
    {
        private string fechaPago;
        private string id;
        private string pagos;

        public string FechaPago { get => fechaPago; set => fechaPago = value; }
        public string Id { get => id; set => id = value; }
        public string Pagos { get => pagos; set => pagos = value; }

        public string CancelarPago()
        {
            return "El Método Cancelar Pago todavía no se ha implementado";
        }

        public string Reembolso()
        {
            return "El Método Reembolso todavía no se ha implementado";
        }

        public string MetodoPago()
        {
            return "El Método 'Metodos pago' todavía no se ha implementado";
        }
    }
}