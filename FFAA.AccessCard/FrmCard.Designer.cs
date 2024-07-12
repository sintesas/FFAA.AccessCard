namespace FFAA.AccessCard
{
    partial class FrmCard
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCard));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmnuSeeCard = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuMinimize = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTarjetaID = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblGrado = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblDependencia = new System.Windows.Forms.Label();
            this.lblNombreFirma = new System.Windows.Forms.Label();
            this.lblCargoFirma = new System.Windows.Forms.Label();
            this.lblVigencia = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Tarjeta de Acceso";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmnuSeeCard,
            this.tsmnuMinimize,
            this.tsmnuClose});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(185, 70);
            this.contextMenuStrip1.Text = "Mostrar";
            // 
            // tsmnuSeeCard
            // 
            this.tsmnuSeeCard.Name = "tsmnuSeeCard";
            this.tsmnuSeeCard.Size = new System.Drawing.Size(184, 22);
            this.tsmnuSeeCard.Text = "Ver Tarjeta de Acceso";
            this.tsmnuSeeCard.ToolTipText = "Ver Tarjeta de Acceso";
            this.tsmnuSeeCard.Click += new System.EventHandler(this.tsmnuSeeCard_Click);
            // 
            // tsmnuMinimize
            // 
            this.tsmnuMinimize.Name = "tsmnuMinimize";
            this.tsmnuMinimize.Size = new System.Drawing.Size(184, 22);
            this.tsmnuMinimize.Text = "Minimizar";
            this.tsmnuMinimize.ToolTipText = "Minimizar";
            this.tsmnuMinimize.Click += new System.EventHandler(this.tsmnuMinimize_Click);
            // 
            // tsmnuClose
            // 
            this.tsmnuClose.Name = "tsmnuClose";
            this.tsmnuClose.Size = new System.Drawing.Size(184, 22);
            this.tsmnuClose.Text = "Cerrar";
            this.tsmnuClose.Click += new System.EventHandler(this.tsmnuClose_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 300000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTarjetaID
            // 
            this.lblTarjetaID.BackColor = System.Drawing.Color.Transparent;
            this.lblTarjetaID.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarjetaID.Location = new System.Drawing.Point(255, 113);
            this.lblTarjetaID.Name = "lblTarjetaID";
            this.lblTarjetaID.Size = new System.Drawing.Size(133, 23);
            this.lblTarjetaID.TabIndex = 1;
            this.lblTarjetaID.Text = "TarjetaID";
            this.lblTarjetaID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaInicio.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.Location = new System.Drawing.Point(461, 115);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(136, 23);
            this.lblFechaInicio.TabIndex = 2;
            this.lblFechaInicio.Text = "FechaInicio";
            this.lblFechaInicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGrado
            // 
            this.lblGrado.BackColor = System.Drawing.Color.Transparent;
            this.lblGrado.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrado.Location = new System.Drawing.Point(110, 267);
            this.lblGrado.Name = "lblGrado";
            this.lblGrado.Size = new System.Drawing.Size(135, 23);
            this.lblGrado.TabIndex = 3;
            this.lblGrado.Text = "Grado";
            this.lblGrado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(265, 264);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(370, 23);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Apellidos";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.BackColor = System.Drawing.Color.Transparent;
            this.lblIdentificacion.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificacion.Location = new System.Drawing.Point(742, 267);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(154, 23);
            this.lblIdentificacion.TabIndex = 5;
            this.lblIdentificacion.Text = "Identificacion";
            this.lblIdentificacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCargo
            // 
            this.lblCargo.BackColor = System.Drawing.Color.Transparent;
            this.lblCargo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(260, 347);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(375, 23);
            this.lblCargo.TabIndex = 6;
            this.lblCargo.Text = "Cargo";
            this.lblCargo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDependencia
            // 
            this.lblDependencia.BackColor = System.Drawing.Color.Transparent;
            this.lblDependencia.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDependencia.Location = new System.Drawing.Point(675, 332);
            this.lblDependencia.Name = "lblDependencia";
            this.lblDependencia.Size = new System.Drawing.Size(292, 38);
            this.lblDependencia.TabIndex = 7;
            this.lblDependencia.Text = "Dependencia";
            this.lblDependencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombreFirma
            // 
            this.lblNombreFirma.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreFirma.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreFirma.Location = new System.Drawing.Point(456, 423);
            this.lblNombreFirma.Name = "lblNombreFirma";
            this.lblNombreFirma.Size = new System.Drawing.Size(404, 23);
            this.lblNombreFirma.TabIndex = 8;
            this.lblNombreFirma.Text = "NombreFirma";
            this.lblNombreFirma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCargoFirma
            // 
            this.lblCargoFirma.BackColor = System.Drawing.Color.Transparent;
            this.lblCargoFirma.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargoFirma.Location = new System.Drawing.Point(461, 454);
            this.lblCargoFirma.Name = "lblCargoFirma";
            this.lblCargoFirma.Size = new System.Drawing.Size(399, 23);
            this.lblCargoFirma.TabIndex = 9;
            this.lblCargoFirma.Text = "CargoFirma";
            this.lblCargoFirma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVigencia
            // 
            this.lblVigencia.BackColor = System.Drawing.Color.White;
            this.lblVigencia.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVigencia.ForeColor = System.Drawing.Color.Red;
            this.lblVigencia.Location = new System.Drawing.Point(558, 497);
            this.lblVigencia.Name = "lblVigencia";
            this.lblVigencia.Size = new System.Drawing.Size(336, 29);
            this.lblVigencia.TabIndex = 10;
            this.lblVigencia.Text = "Vigencia";
            this.lblVigencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVigencia.Visible = false;
            // 
            // FrmCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FFAA.AccessCard.Properties.Resources.brown;
            this.ClientSize = new System.Drawing.Size(1029, 582);
            this.Controls.Add(this.lblVigencia);
            this.Controls.Add(this.lblCargoFirma);
            this.Controls.Add(this.lblNombreFirma);
            this.Controls.Add(this.lblDependencia);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblIdentificacion);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblGrado);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.lblTarjetaID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarjeta de Acceso";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCard_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmnuSeeCard;
        private System.Windows.Forms.ToolStripMenuItem tsmnuMinimize;
        private System.Windows.Forms.ToolStripMenuItem tsmnuClose;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTarjetaID;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblGrado;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblDependencia;
        private System.Windows.Forms.Label lblNombreFirma;
        private System.Windows.Forms.Label lblCargoFirma;
        private System.Windows.Forms.Label lblVigencia;
    }
}

