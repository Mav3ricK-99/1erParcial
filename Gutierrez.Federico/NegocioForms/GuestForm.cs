using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace NegocioForms {
    public partial class GuestForm : Form {

        public GuestForm() {
            InitializeComponent();
        }
        private void GuestForm_Load(object sender, EventArgs e) {
            this.lblBienvenida.Text += Negocio.NombreNegocio;
        }

        private void txtBoxUsername_TextChanged(object sender, EventArgs e) {
            HabilitarRegistroInvitado();
        }

        private void txtBoxDNI_TextChanged(object sender, EventArgs e) {
            HabilitarRegistroInvitado();
        }

        private void HabilitarRegistroInvitado() {

            if (this.txtBoxUsername.Text.Length > 1 && this.txtBoxDNI.Text.Length == 8) {
                this.btnIngresoInvitado.Enabled = true;
            }
            else {
                this.btnIngresoInvitado.Enabled = false;
            }
        }

        private void btnIngresoInvitado_Click(object sender, EventArgs e) {

            int dniUsuario;
            if(int.TryParse(this.txtBoxDNI.Text, out dniUsuario)) {
                Invitado nuevoInvitado = Negocio.AgregarInvitado(this.txtBoxUsername.Text, dniUsuario);
                this.Hide();
                new ControlPanelForm(nuevoInvitado).Show();
            }
            else {
                MessageBox.Show("Ya hay ingresado un Cliente con ese DNI", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void GuestForm_FormClosing(object sender, FormClosingEventArgs e) {

            Form loginForm = Application.OpenForms["loginForm"];
            loginForm.Show();
        }

        private void linkLblIngreso_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {

            this.Close();
        }

        private void linkLblRegistrarte_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {

            this.Close();
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }

        private void txtBoxDNI_KeyPress(object sender, KeyPressEventArgs e) {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
            
        }
        private void txtBoxUsername_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter && this.btnIngresoInvitado.Enabled == true) {
                this.btnIngresoInvitado_Click(sender, e);
            }
        }

        private void txtBoxDNI_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter && this.btnIngresoInvitado.Enabled == true) {
                this.btnIngresoInvitado_Click(sender, e);
            }
        }

        private void txtBoxUsername_KeyPress(object sender, KeyPressEventArgs e) {

            if (char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }
    }
}
