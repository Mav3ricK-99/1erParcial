using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public static class Negocio {

        private static Inventario invNegocio;
        private static string nombreNegocio;
        private static List<Usuario> listaUsuarios;
        private static List<Compra> listaCompras;

        static Negocio() {
            invNegocio = Inventario.Instancia;
            nombreNegocio = "NombreNegocio";
            listaUsuarios = new List<Usuario>(0);
            listaCompras = new List<Compra>(0);
        }
        public static string NombreNegocio { get => nombreNegocio; set => nombreNegocio = value; }
        public static Inventario InvNegocio { get => invNegocio; set => invNegocio = value; }
        public static List<Usuario> ListaUsuarios { get => listaUsuarios; set => listaUsuarios = value; }
        public static List<Compra> ListaCompras { get => listaCompras; set => listaCompras = value; }

        public static Invitado AgregarInvitado(string nombreUsuario, int dniUsuario) {

            Invitado invitadoIngresado = null;
            
            if (Negocio.ExisteUsuario(dniUsuario) == false) {
                invitadoIngresado = new Invitado(nombreUsuario, dniUsuario);
                listaUsuarios.Add(invitadoIngresado);
            }

            return invitadoIngresado;
        }

        public static void AgregarCliente(string nombreUsuario, string apellidoUsuario, int dniUsuario, string contraseñaCliente) {

            if (Negocio.ExisteUsuario(dniUsuario) == false) {
                listaUsuarios.Add(new Cliente(nombreUsuario, apellidoUsuario, dniUsuario, contraseñaCliente));
            }

        }

        public static Usuario IngresoUsuario(string nombreUsuario, string passUsuario) {

            Usuario rtrnUsuario = null;
            foreach (var usuario in listaUsuarios) {

                if (usuario.NombreUsuario.ToLower() == nombreUsuario.ToLower() && usuario.PassUsuario() == passUsuario)
                    {
                    rtrnUsuario = usuario;
                }

            }

            return rtrnUsuario;
        }
        public static void AgregarComprasDefault() {

            listaUsuarios[0].CarritoCliente().AgregarAlCarrito(invNegocio.ListaProductosInv[0]);
            listaUsuarios[0].Comprar(0, "3213 1232 4512 8214");
            listaUsuarios[0].CarritoCliente().AgregarAlCarrito(invNegocio.ListaProductosInv[0]);
            listaUsuarios[0].Comprar(0, "3213 1232 4512 8214");
            listaUsuarios[0].CarritoCliente().AgregarAlCarrito(invNegocio.ListaProductosInv[15]);
            listaUsuarios[0].Comprar(0, "3213 1232 4512 8214");
            listaUsuarios[0].CarritoCliente().AgregarAlCarrito(invNegocio.ListaProductosInv[10]);
            listaUsuarios[0].Comprar(0, "3213 1232 4512 8214");
            listaUsuarios[0].CarritoCliente().AgregarAlCarrito(invNegocio.ListaProductosInv[8]);
            listaUsuarios[0].Comprar(0, "3213 1232 4512 8214");
            listaUsuarios[0].CarritoCliente().AgregarAlCarrito(invNegocio.ListaProductosInv[14]);
            listaUsuarios[0].Comprar(0, "3213 1232 4512 8214");
            listaUsuarios[0].CarritoCliente().AgregarAlCarrito(invNegocio.ListaProductosInv[10]);
            listaUsuarios[0].Comprar(0, "3213 1232 4512 8214");
            listaUsuarios[0].CarritoCliente().AgregarAlCarrito(invNegocio.ListaProductosInv[2]);
            listaUsuarios[0].Comprar(0, "3213 1232 4512 8214");
            listaUsuarios[0].CarritoCliente().AgregarAlCarrito(invNegocio.ListaProductosInv[11]);
            listaUsuarios[0].Comprar(0, "3213 1232 4512 8214");
            listaUsuarios[0].CarritoCliente().AgregarAlCarrito(invNegocio.ListaProductosInv[8]);
            listaUsuarios[0].Comprar(0, "3213 1232 4512 8214");
            listaUsuarios[0].CarritoCliente().AgregarAlCarrito(invNegocio.ListaProductosInv[4]);
            listaUsuarios[0].Comprar(0, "3213 1232 4512 8214");
            listaUsuarios[0].CarritoCliente().AgregarAlCarrito(invNegocio.ListaProductosInv[7]);
            listaUsuarios[0].Comprar(0, "3213 1232 4512 8214");
            listaUsuarios[0].CarritoCliente().AgregarAlCarrito(invNegocio.ListaProductosInv[3]);
            listaUsuarios[0].Comprar(0, "3213 1232 4512 8214");
            listaUsuarios[0].CarritoCliente().AgregarAlCarrito(invNegocio.ListaProductosInv[6]);
            listaUsuarios[0].Comprar(0, "3213 1232 4512 8214");
            listaUsuarios[0].CarritoCliente().AgregarAlCarrito(invNegocio.ListaProductosInv[4]);
            listaUsuarios[0].Comprar(0, "3213 1232 4512 8214");
            listaUsuarios[1].CarritoCliente().AgregarAlCarrito(invNegocio.ListaProductosInv[2]);
            listaUsuarios[1].CarritoCliente().AgregarAlCarrito(invNegocio.ListaProductosInv[5]);
            listaUsuarios[1].CarritoCliente().AgregarAlCarrito(invNegocio.ListaProductosInv[7]);
            listaUsuarios[1].CarritoCliente().AgregarAlCarrito(invNegocio.ListaProductosInv[9]);
            listaUsuarios[1].Comprar(0, "2451 1511 1111 7766");
        }

        public static void AgregarUsuariosDefault() {

            listaUsuarios.Add(new Cliente("Federico", "Gutierrez", 42000844, "fefe99"));
            listaUsuarios.Add(new Cliente("Bart", "Simpson", 11223344, "123456"));
            listaUsuarios.Add(new Empleado("Eze", "Oggioni", 12230249, "examen1"));
            listaUsuarios.Add(new Empleado("Lucas", "Rodriguez", 12232490, "examen1"));
        }
        public static void AgregarProductosDefault() {

            invNegocio.AgregarProducto(new Producto("Salchicha rancia", (float)15.2, (ECategorias)4, 7));
            invNegocio.AgregarProducto(new Producto("Leche", (float)30.7, (ECategorias)4, 40));
            invNegocio.AgregarProducto(new Producto("Snack", 20, (ECategorias)4, 35));
            invNegocio.AgregarProducto(new Producto("6Pack Duff", 60, (ECategorias)4, 70));
            invNegocio.AgregarProducto(new Producto("Cereal", (float)50.65, (ECategorias)4, 10));
            invNegocio.AgregarProducto(new Producto("Harina 000", 20, (ECategorias)4, 20));
            invNegocio.AgregarProducto(new Producto("Lavandina", 45, (ECategorias)2, 10));
            invNegocio.AgregarProducto(new Producto("Trapos", (float)25.53, (ECategorias)2, 60));
            invNegocio.AgregarProducto(new Producto("Jabon liquido", 35, (ECategorias)2, 30));
            invNegocio.AgregarProducto(new Producto("Jabon en polvo", 30, (ECategorias)2, 20));
            invNegocio.AgregarProducto(new Producto("Pañuelos", 55, (ECategorias)2, 25));
            invNegocio.AgregarProducto(new Producto("Esponjas", 15, (ECategorias)2, 20));
            invNegocio.AgregarProducto(new Producto("Jabones", (float)20.5, (ECategorias)3, 15));
            invNegocio.AgregarProducto(new Producto("Pañales", (float)20.99, (ECategorias)3, 15));
            invNegocio.AgregarProducto(new Producto("Desodorante", (float)60.25, (ECategorias)3, 15));
            invNegocio.AgregarProducto(new Producto("Antitranspirante", (float)50.5, (ECategorias)3, 20));
            invNegocio.AgregarProducto(new Producto("Fosforos", (float)25.35, (ECategorias)3, 13));
        }

        private static Boolean ExisteUsuario(int dniUsuario) {

            Boolean rtrn = false;
            foreach (var usuario in listaUsuarios) {

                if (usuario.DniUsuario == dniUsuario) {
                    rtrn = true;
                    break;
                }
            }

            return rtrn;
        }

    }
}
