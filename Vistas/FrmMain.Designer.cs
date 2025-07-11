namespace Vistas
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaPrestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verPrestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verPrestamosPorFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verPrestamosPorDestinoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anularPrestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.destinosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.verDestinosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.periodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.verPagosPorClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verPagosPorFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verCuotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.prestamosToolStripMenuItem,
            this.destinosToolStripMenuItem,
            this.periodosToolStripMenuItem,
            this.pagosToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sALIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(682, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem,
            this.verUsuariosToolStripMenuItem});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // altaToolStripMenuItem
            // 
            this.altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            this.altaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.altaToolStripMenuItem.Text = "Alta";
            this.altaToolStripMenuItem.Click += new System.EventHandler(this.altaToolStripMenuItem_Click);
            // 
            // verUsuariosToolStripMenuItem
            // 
            this.verUsuariosToolStripMenuItem.Name = "verUsuariosToolStripMenuItem";
            this.verUsuariosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.verUsuariosToolStripMenuItem.Text = "Ver Usuarios";
            this.verUsuariosToolStripMenuItem.Click += new System.EventHandler(this.verUsuariosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem1,
            this.verClientesToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // altaToolStripMenuItem1
            // 
            this.altaToolStripMenuItem1.Name = "altaToolStripMenuItem1";
            this.altaToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.altaToolStripMenuItem1.Text = "Alta";
            this.altaToolStripMenuItem1.Click += new System.EventHandler(this.altaToolStripMenuItem1_Click);
            // 
            // verClientesToolStripMenuItem
            // 
            this.verClientesToolStripMenuItem.Name = "verClientesToolStripMenuItem";
            this.verClientesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.verClientesToolStripMenuItem.Text = "Ver Clientes";
            this.verClientesToolStripMenuItem.Click += new System.EventHandler(this.verClientesToolStripMenuItem_Click);
            // 
            // prestamosToolStripMenuItem
            // 
            this.prestamosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaPrestamoToolStripMenuItem,
            this.verPrestamosToolStripMenuItem,
            this.verPrestamosPorFechaToolStripMenuItem,
            this.verPrestamosPorDestinoToolStripMenuItem,
            this.anularPrestamoToolStripMenuItem});
            this.prestamosToolStripMenuItem.Name = "prestamosToolStripMenuItem";
            this.prestamosToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.prestamosToolStripMenuItem.Text = "Prestamos";
            this.prestamosToolStripMenuItem.Click += new System.EventHandler(this.prestamosToolStripMenuItem_Click);
            // 
            // altaPrestamoToolStripMenuItem
            // 
            this.altaPrestamoToolStripMenuItem.Name = "altaPrestamoToolStripMenuItem";
            this.altaPrestamoToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.altaPrestamoToolStripMenuItem.Text = "Alta";
            this.altaPrestamoToolStripMenuItem.Click += new System.EventHandler(this.altaPrestamoToolStripMenuItem_Click);
            // 
            // verPrestamosToolStripMenuItem
            // 
            this.verPrestamosToolStripMenuItem.Name = "verPrestamosToolStripMenuItem";
            this.verPrestamosToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.verPrestamosToolStripMenuItem.Text = "Ver Prestamos";
            this.verPrestamosToolStripMenuItem.Click += new System.EventHandler(this.verPrestamosToolStripMenuItem_Click);
            // 
            // verPrestamosPorFechaToolStripMenuItem
            // 
            this.verPrestamosPorFechaToolStripMenuItem.Name = "verPrestamosPorFechaToolStripMenuItem";
            this.verPrestamosPorFechaToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.verPrestamosPorFechaToolStripMenuItem.Text = "Ver Prestamos por fecha";
            this.verPrestamosPorFechaToolStripMenuItem.Click += new System.EventHandler(this.verPrestamosPorFechaToolStripMenuItem_Click);
            // 
            // verPrestamosPorDestinoToolStripMenuItem
            // 
            this.verPrestamosPorDestinoToolStripMenuItem.Name = "verPrestamosPorDestinoToolStripMenuItem";
            this.verPrestamosPorDestinoToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.verPrestamosPorDestinoToolStripMenuItem.Text = "Ver Prestamos por destino";
            this.verPrestamosPorDestinoToolStripMenuItem.Click += new System.EventHandler(this.verPrestamosPorDestinoToolStripMenuItem_Click);
            // 
            // anularPrestamoToolStripMenuItem
            // 
            this.anularPrestamoToolStripMenuItem.Name = "anularPrestamoToolStripMenuItem";
            this.anularPrestamoToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.anularPrestamoToolStripMenuItem.Text = "Anular Prestamo";
            this.anularPrestamoToolStripMenuItem.Click += new System.EventHandler(this.anularPrestamoToolStripMenuItem_Click);
            // 
            // destinosToolStripMenuItem
            // 
            this.destinosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem2,
            this.verDestinosToolStripMenuItem});
            this.destinosToolStripMenuItem.Name = "destinosToolStripMenuItem";
            this.destinosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.destinosToolStripMenuItem.Text = "Destinos";
            // 
            // altaToolStripMenuItem2
            // 
            this.altaToolStripMenuItem2.Name = "altaToolStripMenuItem2";
            this.altaToolStripMenuItem2.Size = new System.Drawing.Size(138, 22);
            this.altaToolStripMenuItem2.Text = "Alta";
            this.altaToolStripMenuItem2.Click += new System.EventHandler(this.altaToolStripMenuItem2_Click);
            // 
            // verDestinosToolStripMenuItem
            // 
            this.verDestinosToolStripMenuItem.Name = "verDestinosToolStripMenuItem";
            this.verDestinosToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.verDestinosToolStripMenuItem.Text = "Ver Destinos";
            this.verDestinosToolStripMenuItem.Click += new System.EventHandler(this.verDestinosToolStripMenuItem_Click);
            // 
            // periodosToolStripMenuItem
            // 
            this.periodosToolStripMenuItem.Name = "periodosToolStripMenuItem";
            this.periodosToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.periodosToolStripMenuItem.Text = "Periodos";
            this.periodosToolStripMenuItem.Click += new System.EventHandler(this.periodosToolStripMenuItem_Click);
            // 
            // pagosToolStripMenuItem
            // 
            this.pagosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem3,
            this.verPagosPorClienteToolStripMenuItem,
            this.verPagosPorFechaToolStripMenuItem});
            this.pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
            this.pagosToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.pagosToolStripMenuItem.Text = "Pagos";
            // 
            // altaToolStripMenuItem3
            // 
            this.altaToolStripMenuItem3.Name = "altaToolStripMenuItem3";
            this.altaToolStripMenuItem3.Size = new System.Drawing.Size(184, 22);
            this.altaToolStripMenuItem3.Text = "Pagar una cuota";
            this.altaToolStripMenuItem3.Click += new System.EventHandler(this.altaToolStripMenuItem3_Click);
            // 
            // verPagosPorClienteToolStripMenuItem
            // 
            this.verPagosPorClienteToolStripMenuItem.Name = "verPagosPorClienteToolStripMenuItem";
            this.verPagosPorClienteToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.verPagosPorClienteToolStripMenuItem.Text = "Ver Pagos por cliente";
            this.verPagosPorClienteToolStripMenuItem.Click += new System.EventHandler(this.verPagosPorClienteToolStripMenuItem_Click);
            // 
            // verPagosPorFechaToolStripMenuItem
            // 
            this.verPagosPorFechaToolStripMenuItem.Name = "verPagosPorFechaToolStripMenuItem";
            this.verPagosPorFechaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.verPagosPorFechaToolStripMenuItem.Text = "Ver pagos por fecha";
            this.verPagosPorFechaToolStripMenuItem.Click += new System.EventHandler(this.verPagosPorFechaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verCuotasToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(56, 20);
            this.toolStripMenuItem1.Text = "Cuotas";
            // 
            // verCuotasToolStripMenuItem
            // 
            this.verCuotasToolStripMenuItem.Name = "verCuotasToolStripMenuItem";
            this.verCuotasToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.verCuotasToolStripMenuItem.Text = "Ver Cuotas";
            this.verCuotasToolStripMenuItem.Click += new System.EventHandler(this.verCuotasToolStripMenuItem_Click);
            // 
            // sALIRToolStripMenuItem
            // 
            this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sALIRToolStripMenuItem.Text = "SALIR";
            this.sALIRToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sALIRToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.sALIRToolStripMenuItem.Click += new System.EventHandler(this.sALIRToolStripMenuItem_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(12, 38);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(35, 13);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "label1";
            this.lblUsuario.Click += new System.EventHandler(this.lblUsuario_Click);
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(12, 63);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(35, 13);
            this.lblRol.TabIndex = 2;
            this.lblRol.Text = "label1";
            // 
            // txtTitulo
            // 
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(15, 112);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(103, 24);
            this.txtTitulo.TabIndex = 29;
            this.txtTitulo.Text = "GRUPO 03";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 484);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem destinosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem periodosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagosToolStripMenuItem;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem verDestinosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaPrestamoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verPrestamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verPrestamosPorFechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verPagosPorClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem verPrestamosPorDestinoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anularPrestamoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verCuotasToolStripMenuItem;
        private System.Windows.Forms.Label txtTitulo;
        private System.Windows.Forms.ToolStripMenuItem verPagosPorFechaToolStripMenuItem;
    }
}