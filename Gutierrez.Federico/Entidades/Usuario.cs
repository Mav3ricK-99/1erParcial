using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public abstract class Usuario {

        protected static int idClaseUsuario;
        private int idUsuario = idClaseUsuario++;
        protected string nombreUsuario = string.Empty;
        protected string apellidoUsuario = string.Empty;
        protected int dniUsuario;

        public Usuario(string nombreUsuario, int dniUsuario) {

            this.idUsuario = idClaseUsuario;
            this.nombreUsuario = nombreUsuario;
            this.dniUsuario = dniUsuario;
        }

        public Usuario(string nombreUsuario, string apellidoUsuario, int dniUsuario): this(nombreUsuario, dniUsuario) {

            this.apellidoUsuario = apellidoUsuario;
        }
        public int IdUsuario { get => idUsuario; }
        public string NombreUsuario {
            get {
                return this.nombreUsuario;
            }
            set {
                if (Validaciones.EsNombre(value)) {
                    Validaciones.LimpiarNombre(value);
                    this.nombreUsuario = value;
                }
            }
        }

        public string ApellidoUsuario {
            get {
                return this.apellidoUsuario;
            }
            set {
                if (Validaciones.EsNombre(value)) {
                    Validaciones.LimpiarNombre(value);
                    this.apellidoUsuario = value;
                }
            }
        }

        public string NombreCompleto {
            get {
                return $"{this.nombreUsuario} {this.apellidoUsuario}";
            }
        }


        public int DniUsuario { 
            get => dniUsuario;
            set {
                if (Validaciones.EsDNI(dniUsuario)) {
                    dniUsuario = value;
                }   
            }
        }
        public string RolUsuario {
            get { 
                return this.GetRolUsuario(); 
            }
        }


        public void IsSimpson() {
            if (this.apellidoUsuario == "Simpson")
                this.CarritoCliente().DarDescuentoTotal(15);
        }

        public abstract string UltimaCompraPretty();
        public abstract string GetRolUsuario();
        public abstract Carrito CarritoCliente();
        public abstract string PassUsuario();
        public abstract Boolean Comprar(EMetodoPago metodoPago, string cuentaPago);
        
        public override string ToString() {

            string strUsuario = string.Empty;
            strUsuario = $"{this.NombreCompleto}\nDNI - {this.DniUsuario}\n";

            return strUsuario;
        }
    }
}
