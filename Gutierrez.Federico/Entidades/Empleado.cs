using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public class Empleado : Usuario{

        private string passUsuario;
        private DateTime fechaAlta;

        public Empleado(string nombreUsuario, string apellidoUsuario, int dniUsuario, string passUsuario) : base(nombreUsuario, apellidoUsuario, dniUsuario) {

            this.passUsuario = passUsuario;
            fechaAlta = new DateTime();
        }

        public override string PassUsuario() => passUsuario;
        public override Carrito CarritoCliente() { throw new NotImplementedException(); }
        public override bool Comprar(EMetodoPago metodoPago,string cuentaPago) { return false; }

        public override string ToString() {

            string strEmpleado = base.ToString();
            strEmpleado += $"Usuario - Empleado\nFecha de alta - {this.fechaAlta.ToString()}\n";
           
            return strEmpleado;
        }

        public override string GetRolUsuario() {
            string strRol = "Empleado";
            return strRol;
        }
        public override string UltimaCompraPretty() {
            throw new NotImplementedException();
        }

    }
}
