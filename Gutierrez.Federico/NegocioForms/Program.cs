using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace NegocioForms {
    static class Program {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main() {

            Negocio.NombreNegocio = " Kwik - E - Mart";
            Negocio.AgregarUsuariosDefault();
            Negocio.AgregarProductosDefault();
            Negocio.AgregarComprasDefault();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
            
           


            //if (login.showControlPanel) {
            //    Application.Run(new ControlPanelForm());
            //}
        }
    }
}