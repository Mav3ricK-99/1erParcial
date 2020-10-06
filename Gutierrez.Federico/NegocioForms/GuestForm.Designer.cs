namespace NegocioForms {
    partial class GuestForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestForm));
            this.btnIngresoInvitado = new System.Windows.Forms.Button();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.lblMensajeIngresoDatos = new System.Windows.Forms.Label();
            this.txtBoxDNI = new System.Windows.Forms.TextBox();
            this.lblMensajeAbajo = new System.Windows.Forms.Label();
            this.linkLblIngreso = new System.Windows.Forms.LinkLabel();
            this.lblContinuar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLblRegistrarte = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnIngresoInvitado
            // 
            this.btnIngresoInvitado.BackColor = System.Drawing.Color.LimeGreen;
            this.btnIngresoInvitado.Enabled = false;
            this.btnIngresoInvitado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresoInvitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresoInvitado.ForeColor = System.Drawing.SystemColors.Control;
            this.btnIngresoInvitado.Location = new System.Drawing.Point(48, 240);
            this.btnIngresoInvitado.Name = "btnIngresoInvitado";
            this.btnIngresoInvitado.Padding = new System.Windows.Forms.Padding(5);
            this.btnIngresoInvitado.Size = new System.Drawing.Size(104, 39);
            this.btnIngresoInvitado.TabIndex = 7;
            this.btnIngresoInvitado.TabStop = false;
            this.btnIngresoInvitado.Text = "Ingresar";
            this.btnIngresoInvitado.UseVisualStyleBackColor = false;
            this.btnIngresoInvitado.Click += new System.EventHandler(this.btnIngresoInvitado_Click);
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblBienvenida.Location = new System.Drawing.Point(19, 28);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(194, 24);
            this.lblBienvenida.TabIndex = 1;
            this.lblBienvenida.Text = "Gracias por confiar en";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblPass.Location = new System.Drawing.Point(45, 179);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(26, 14);
            this.lblPass.TabIndex = 5;
            this.lblPass.Text = "DNI";
            this.lblPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblUsername.Location = new System.Drawing.Point(45, 116);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(82, 14);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Primer nombre";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxUsername.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBoxUsername.Location = new System.Drawing.Point(48, 133);
            this.txtBoxUsername.Multiline = true;
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(238, 26);
            this.txtBoxUsername.TabIndex = 4;
            this.txtBoxUsername.TextChanged += new System.EventHandler(this.txtBoxUsername_TextChanged);
            this.txtBoxUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxUsername_KeyDown);
            this.txtBoxUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxUsername_KeyPress);
            // 
            // lblMensajeIngresoDatos
            // 
            this.lblMensajeIngresoDatos.AutoSize = true;
            this.lblMensajeIngresoDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeIngresoDatos.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblMensajeIngresoDatos.Location = new System.Drawing.Point(32, 70);
            this.lblMensajeIngresoDatos.Name = "lblMensajeIngresoDatos";
            this.lblMensajeIngresoDatos.Size = new System.Drawing.Size(232, 45);
            this.lblMensajeIngresoDatos.TabIndex = 2;
            this.lblMensajeIngresoDatos.Text = "Para continuar como Invitado ingrese los \r\nsiguientes datos. (No expondran).\r\n\r\n";
            // 
            // txtBoxDNI
            // 
            this.txtBoxDNI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxDNI.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBoxDNI.Location = new System.Drawing.Point(48, 196);
            this.txtBoxDNI.MaxLength = 8;
            this.txtBoxDNI.Multiline = true;
            this.txtBoxDNI.Name = "txtBoxDNI";
            this.txtBoxDNI.Size = new System.Drawing.Size(172, 25);
            this.txtBoxDNI.TabIndex = 6;
            this.txtBoxDNI.TextChanged += new System.EventHandler(this.txtBoxDNI_TextChanged);
            this.txtBoxDNI.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxDNI_KeyDown);
            this.txtBoxDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxDNI_KeyPress);
            // 
            // lblMensajeAbajo
            // 
            this.lblMensajeAbajo.AutoSize = true;
            this.lblMensajeAbajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeAbajo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMensajeAbajo.Location = new System.Drawing.Point(31, 312);
            this.lblMensajeAbajo.Name = "lblMensajeAbajo";
            this.lblMensajeAbajo.Size = new System.Drawing.Size(183, 15);
            this.lblMensajeAbajo.TabIndex = 8;
            this.lblMensajeAbajo.Text = "Si ya tienes una cuenta haz click";
            // 
            // linkLblIngreso
            // 
            this.linkLblIngreso.AutoSize = true;
            this.linkLblIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblIngreso.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLblIngreso.Location = new System.Drawing.Point(211, 312);
            this.linkLblIngreso.Name = "linkLblIngreso";
            this.linkLblIngreso.Size = new System.Drawing.Size(31, 15);
            this.linkLblIngreso.TabIndex = 9;
            this.linkLblIngreso.TabStop = true;
            this.linkLblIngreso.Text = "aqui";
            this.linkLblIngreso.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLblIngreso.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblIngreso_LinkClicked);
            // 
            // lblContinuar
            // 
            this.lblContinuar.AutoSize = true;
            this.lblContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContinuar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblContinuar.Location = new System.Drawing.Point(241, 312);
            this.lblContinuar.Name = "lblContinuar";
            this.lblContinuar.Size = new System.Drawing.Size(80, 15);
            this.lblContinuar.TabIndex = 10;
            this.lblContinuar.Text = "para ingresar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(31, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "¿No tenes una cuenta?";
            // 
            // linkLblRegistrarte
            // 
            this.linkLblRegistrarte.AutoSize = true;
            this.linkLblRegistrarte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblRegistrarte.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLblRegistrarte.Location = new System.Drawing.Point(164, 335);
            this.linkLblRegistrarte.Name = "linkLblRegistrarte";
            this.linkLblRegistrarte.Size = new System.Drawing.Size(63, 15);
            this.linkLblRegistrarte.TabIndex = 12;
            this.linkLblRegistrarte.TabStop = true;
            this.linkLblRegistrarte.Text = "Registrate";
            this.linkLblRegistrarte.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLblRegistrarte.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblRegistrarte_LinkClicked);
            // 
            // GuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(356, 374);
            this.Controls.Add(this.linkLblRegistrarte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblContinuar);
            this.Controls.Add(this.linkLblIngreso);
            this.Controls.Add(this.lblMensajeAbajo);
            this.Controls.Add(this.txtBoxDNI);
            this.Controls.Add(this.lblMensajeIngresoDatos);
            this.Controls.Add(this.btnIngresoInvitado);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtBoxUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GuestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso Invitado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GuestForm_FormClosing);
            this.Load += new System.EventHandler(this.GuestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresoInvitado;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.Label lblMensajeIngresoDatos;
        private System.Windows.Forms.TextBox txtBoxDNI;
        private System.Windows.Forms.Label lblMensajeAbajo;
        private System.Windows.Forms.LinkLabel linkLblIngreso;
        private System.Windows.Forms.Label lblContinuar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLblRegistrarte;
    }
}