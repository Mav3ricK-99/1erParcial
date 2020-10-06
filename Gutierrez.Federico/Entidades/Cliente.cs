using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public class Cliente : Usuario {

        private string passUsuario;
        private DateTime fechaAlta;
        private Compra ultimaCompra;
        private Carrito carritoCliente;

        public Cliente(string nombreUsuario, string apellidoUsuario, int dniUsuario, string passUsuario) : base(nombreUsuario, apellidoUsuario, dniUsuario) {

            this.passUsuario = passUsuario;
            this.fechaAlta = DateTime.Now;
            this.carritoCliente = new Carrito();
            
        }
        internal Compra UltimaCompra { get => ultimaCompra; set => ultimaCompra = value; }
        public override string UltimaCompraPretty() {

            string ultimaCompraStr = string.Empty;
            if (this.UltimaCompra == null) {
                ultimaCompraStr += "No hubo compras.\n";
            }
            else {
                ultimaCompraStr += $"Ultima Compra \n{this.UltimaCompra.FacturaCompra.ToStringPretty()}\n";
            }

            return ultimaCompraStr;
        }

        public override string PassUsuario() => passUsuario;
        public override Carrito CarritoCliente() => carritoCliente;

        public override bool Comprar(EMetodoPago metodoPago, string cuentaPago) {

            bool rtrnCompra = false;
            Compra nuevaCompra = new Compra(this, metodoPago, cuentaPago);
            Negocio.InvNegocio.AgregarVendidos(this.carritoCliente);
            this.carritoCliente.DiccionarioProductos.Clear();
            if (nuevaCompra != null && nuevaCompra.FacturaCompra != null) {
                this.ultimaCompra = nuevaCompra;
                Negocio.ListaCompras.Add(nuevaCompra);
                rtrnCompra = true;
            }

            return rtrnCompra;
        }

        public override string ToString() {

            string strCliente = base.ToString();
            strCliente += $"Usuario Cliente\nFecha de alta - {this.fechaAlta.ToString()}\n";
            
            return strCliente;
        }

        public override string GetRolUsuario() {
            string strRol = "Cliente";
            return strRol;
        }

    }
}
