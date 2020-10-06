using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {

    public enum ECategorias {

        Almacen,
        Limpieza,
        Perfumeria,
        Bebidas,
        Congelados,

    }
    public class Producto {

        static int idProductoClase;
        int idProducto;
        int stockProducto, cantVendidos;
        string nombreProducto;
        ECategorias categoriaProducto;
        float precioProducto;

        public Producto() {

            this.nombreProducto = "Sin nombre.";
            this.precioProducto = -1;
            this.categoriaProducto = 0;
            this.stockProducto = -1;
            this.cantVendidos = 0;

        }
        public Producto(string nombreProducto) : this() {

            this.nombreProducto = nombreProducto;
        }

        public Producto(string nombreProducto, float precioProducto) : this(nombreProducto) {

            this.idProducto = idProductoClase++;
            this.precioProducto = precioProducto;
        }

        public Producto(string nombreProducto, float precioProducto, ECategorias categoriaProducto, int stockProducto) : this(nombreProducto, precioProducto) {

            this.nombreProducto = nombreProducto;
            this.precioProducto = precioProducto;
            this.categoriaProducto = categoriaProducto;
            this.stockProducto = stockProducto;

        }

        public Producto(string nombreProducto, float precioProducto, ECategorias categoriaProducto, int stockProducto, int cantVendidos) : this(nombreProducto, precioProducto, categoriaProducto, stockProducto) {

            this.cantVendidos = cantVendidos;

        }

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public float PrecioProducto {
            get => precioProducto;
            set {
                precioProducto = value;
            }
        }
        public ECategorias CategoriaProducto { get => categoriaProducto; set => categoriaProducto = value; }
        public int StockProducto { get => stockProducto; set => stockProducto = value; }
        public int CantVendidos { get => cantVendidos; set => cantVendidos = value; }

    }
}
