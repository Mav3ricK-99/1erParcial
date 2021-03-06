﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public enum EMetodoPago {

        TarjetaDebito,
        TarjetaCredito,
        Efectivo,
        BTC

    }
    public class Factura {

        private int dniComprador;
        private EMetodoPago metodoPago;
        private string nombreComprador;
        private string cuentaPago = string.Empty;
        private string idFactura = string.Empty;
        private Carrito productosFacturados;
        private DateTime fechaAlta;

        public Factura(EMetodoPago metodoPago, string cuentaPago, Carrito productosFacturados, string nombreComprador, int dniComprador) {

            this.fechaAlta = DateTime.Now;
            this.metodoPago = metodoPago;
            this.nombreComprador = nombreComprador+" ";
            this.dniComprador = dniComprador;
            this.cuentaPago = cuentaPago;
            this.productosFacturados = productosFacturados;
            this.idFactura = this.GenerarNumeroFactura();

        }

        private string GenerarNumeroFactura() {
            //F29102020-02-42000844G//
            Random rand = new Random();
            StringBuilder idFactura = new StringBuilder();

            idFactura.AppendFormat("{0}", this.nombreComprador[0]); 
            idFactura.AppendFormat("{0:ddMMyyyy}", this.fechaAlta);
            idFactura.AppendFormat("-{0:000}-", rand.Next(DateTime.Now.Millisecond, 999));
            idFactura.AppendFormat(this.dniComprador.ToString());
            int primerEspacioNombre = this.nombreComprador.IndexOf(' ');
            idFactura.AppendFormat("{0}", this.nombreComprador[primerEspacioNombre+1]);

            return idFactura.ToString();
        }
        public string ToStringPretty() {

            StringBuilder strFactura = new StringBuilder();
            strFactura.Append($"ID Factura - {this.idFactura}\n");
            strFactura.Append($"Metodo de Pago - {this.metodoPago}\n");
            strFactura.Append($"Cuenta del Pago - {this.cuentaPago}\n");
            strFactura.Append($"Fecha Factura - {this.fechaAlta}\n");
            strFactura.Append($"Total compra - ${this.productosFacturados.PrecioTotal.ToString()}\n");

            return strFactura.ToString();
        }

        public override string ToString() {

            StringBuilder strFactura = new StringBuilder();
            strFactura.Append($"ID Factura - {this.idFactura}\n");
            strFactura.Append($"Nombre cliente - {this.nombreComprador}\n");
            strFactura.Append($"DNI - {this.dniComprador}\n");
            strFactura.Append($"Metodo de Pago - {this.metodoPago}\n");
            strFactura.Append($"Cuenta del Pago - {this.cuentaPago}\n");
            strFactura.Append($"Fecha Factura - {this.fechaAlta}\n");
            strFactura.Append($"Productos - {this.productosFacturados.ToString()}\n");

            return strFactura.ToString();
        }

    }
}
