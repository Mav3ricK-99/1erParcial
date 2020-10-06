using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public class Invitado : Usuario{

        private Carrito carritoInvitado;
        private Compra ultimaCompra;
        
        public Invitado(string nombreUsuario, int dniUsuario) : base(nombreUsuario, dniUsuario) {

            this.carritoInvitado = new Carrito();
        }

        public override Carrito CarritoCliente() => carritoInvitado;
        public override string PassUsuario() { throw new NotImplementedException(); }
        public override bool Comprar(EMetodoPago metodoPago, string cuentaPago) {

            bool rtrnCompra = false;
            Compra nuevaCompra = new Compra(this, metodoPago, cuentaPago);
            this.carritoInvitado.DiccionarioProductos.Clear();
            if (nuevaCompra != null && nuevaCompra.FacturaCompra != null) {
                Negocio.ListaCompras.Add(nuevaCompra);
                this.ultimaCompra = nuevaCompra;
                rtrnCompra = true;
            }

            return rtrnCompra;
        }
        public override string GetRolUsuario() {
            string strRol = "Cliente";
            return strRol;
        }

        public override string UltimaCompraPretty() {

            string ultimaCompraStr = string.Empty;
            ultimaCompraStr += $"Ultima Compra \n{this.ultimaCompra.FacturaCompra.ToStringPretty()}\n";

            return ultimaCompraStr;
        }
    }
}
