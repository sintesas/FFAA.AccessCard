using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FFAA.AccessCard.Entity;
using FFAA.AccessCard.Services;

namespace FFAA.AccessCard
{
    public partial class FrmCard : Form
    {
        bool isClosed = false;

        public FrmCard()
        {
            InitializeComponent();

            notifyIcon1.Text = "Ver Tarjeta de Acceso";

            notifyIcon1.Visible = true;

            notifyIcon1.ShowBalloonTip(15, "Tarjeta de Acceso", "Presione clic para ver su tarjeta de acceso", ToolTipIcon.Info);

            GetCard();
        }

        private string GetConfigurationByName(string pName)
        {
            var config = System.Configuration.ConfigurationManager.AppSettings[pName];
            return config;
        }

        private void GetCard()
        {
            string username = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

            CardInfo cardInfo = CardService.GetCard(username, GetConfigurationByName("urlAccessCard"));

            if (cardInfo != null)
            {
                switch (cardInfo.Clasificacion.ToLower())
                {
                    case "secreto":
                        this.BackgroundImage = FFAA.AccessCard.Properties.Resources.yellow;
                        break;
                    case "confidencial":
                        this.BackgroundImage = FFAA.AccessCard.Properties.Resources.red;
                        break;
                    case "ultrasecreto":
                        this.BackgroundImage = FFAA.AccessCard.Properties.Resources.green;
                        break;
                    case "restringido":
                        this.BackgroundImage = FFAA.AccessCard.Properties.Resources.brown;
                        break;
                }

                lblTarjetaID.Text = cardInfo.TarjetaID.ToString();
                lblFechaInicio.Text = cardInfo.FechaInicio.ToString("yyyy-MM-dd");
                lblGrado.Text = cardInfo.Grado;
                lblName.Text = string.Format("{0} {1}", cardInfo.Apellidos, cardInfo.Nombres);
                lblIdentificacion.Text = cardInfo.Identificacion.ToString();
                lblCargo.Text = cardInfo.Cargo;
                lblDependencia.Text = cardInfo.Dependencia;
                lblNombreFirma.Text = cardInfo.NombreFirma;
                lblCargoFirma.Text = cardInfo.CargoFirma;

                int tiempo = (cardInfo.FechaFin - cardInfo.FechaInicio).Days;

                if (tiempo <= 15 && tiempo > 0)
                {
                    lblVigencia.Text = string.Format("{0} días restantes", tiempo);
                    lblVigencia.Visible = true;
                }
                else if (tiempo == 0)
                {
                    lblVigencia.Visible = false;

                    isClosed = true;

                    this.Close();
                }
            }
            else
            {
                isClosed = true;

                this.Close();
            }
        }

        private void FrmCard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isClosed)
            {
                this.Visible = false;
                e.Cancel = true;
                notifyIcon1.Visible = true;

                notifyIcon1.ShowBalloonTip(15, "Tarjeta de Acceso", "Presione clic para ver su tarjeta de acceso", ToolTipIcon.Info);
            }
        }

        private void tsmnuSeeCard_Click(object sender, EventArgs e)
        {
            this.Visible = true;
        }

        private void tsmnuMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tsmnuClose_Click(object sender, EventArgs e)
        {
            isClosed = true;

            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetCard();
        }        
    }
}
