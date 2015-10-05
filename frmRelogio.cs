# RelogioDigital
código do relogio digital

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RelógioDigital
{
    public partial class frmRelogioDigital : Form
    {
        int hora, horad, minuto, minutod, segundo, segundod;

        public frmRelogioDigital()
        {
            InitializeComponent();
            tmrSegundos.Enabled = true;
            tmrMinutos.Enabled = true;
            tmrHoras.Enabled = true;            
        }        

        
        private void tmrSegundos_Tick(object sender, EventArgs e)
        {
            segundo = Convert.ToInt16(DateTime.Now.ToString().Remove(0, 18));
            definirN1(segundo);
            segundod = Convert.ToInt16(DateTime.Now.ToString().Remove(0, 17).Remove(1, 1));
            definirN2(segundod);
        }

        private void tmrMinutos_Tick(object sender, EventArgs e)
        {
            minuto = Convert.ToInt16(DateTime.Now.ToString().Remove(0, 15).Remove(1, 3));
            definirN3(minuto);
            minutod = Convert.ToInt16(DateTime.Now.ToString().Remove(0, 14).Remove(1, 4));
            definirN4(minutod);
        }

        private void tmrHoras_Tick(object sender, EventArgs e)
        {
            hora = Convert.ToInt16(DateTime.Now.ToString().Remove(0, 12).Remove(1, 6));
            definirN5(hora);
            horad = Convert.ToInt16(DateTime.Now.ToString().Remove(0, 11).Remove(1, 7));
            definirN6(horad);
        }

        public void definirN1(int n1)
        {
            switch (n1)
            {
                case 0:
                    n1v1.Visible = true;
                    n1v2.Visible = true;
                    n1v3.Visible = true;
                    n1v4.Visible = true;
                    n1h1.Visible = true;
                    n1h2.Visible = false;
                    n1h3.Visible = true;
                    break;
                case 1:
                    n1v1.Visible = false;
                    n1v2.Visible = true;
                    n1v3.Visible = false;
                    n1v4.Visible = true;
                    n1h1.Visible = false;
                    n1h2.Visible = false;
                    n1h3.Visible = false;
                    break;
                case 2:
                    n1v1.Visible = false;
                    n1v2.Visible = true;
                    n1v3.Visible = true;
                    n1v4.Visible = false;
                    n1h1.Visible = true;
                    n1h2.Visible = true;
                    n1h3.Visible = true;
                    break;
                case 3:
                    n1v1.Visible = false;
                    n1v2.Visible = true;
                    n1v3.Visible = false;
                    n1v4.Visible = true;
                    n1h1.Visible = true;
                    n1h2.Visible = true;
                    n1h3.Visible = true;
                    break;
                case 4:
                    n1v1.Visible = true;
                    n1v2.Visible = true;
                    n1v3.Visible = false;
                    n1v4.Visible = true;
                    n1h1.Visible = false;
                    n1h2.Visible = true;
                    n1h3.Visible = false;
                    break;
                case 5:
                    n1v1.Visible = true;
                    n1v2.Visible = false;
                    n1v3.Visible = false;
                    n1v4.Visible = true;
                    n1h1.Visible = true;
                    n1h2.Visible = true;
                    n1h3.Visible = true;
                    break;
                case 6:
                    n1v1.Visible = true;
                    n1v2.Visible = false;
                    n1v3.Visible = true;
                    n1v4.Visible = true;
                    n1h1.Visible = true;
                    n1h2.Visible = true;
                    n1h3.Visible = true;
                    break;
                case 7:
                    n1v1.Visible = false;
                    n1v2.Visible = true;
                    n1v3.Visible = false;
                    n1v4.Visible = true;
                    n1h1.Visible = true;
                    n1h2.Visible = false;
                    n1h3.Visible = false;
                    break;
                case 8:
                    n1v1.Visible = true;
                    n1v2.Visible = true;
                    n1v3.Visible = true;
                    n1v4.Visible = true;
                    n1h1.Visible = true;
                    n1h2.Visible = true;
                    n1h3.Visible = true;
                    break;
                case 9:
                    n1v1.Visible = true;
                    n1v2.Visible = true;
                    n1v3.Visible = false;
                    n1v4.Visible = true;
                    n1h1.Visible = true;
                    n1h2.Visible = true;
                    n1h3.Visible = true;
                    break;
            }
        }

        public void definirN2(int n2)
        {
            switch (n2)
            {
                case 0:
                    n2v1.Visible = true;
                    n2v2.Visible = true;
                    n2v3.Visible = true;
                    n2v4.Visible = true;
                    n2h1.Visible = true;
                    n2h2.Visible = false;
                    n2h3.Visible = true;
                    break;
                case 1:
                    n2v1.Visible = false;
                    n2v2.Visible = true;
                    n2v3.Visible = false;
                    n2v4.Visible = true;
                    n2h1.Visible = false;
                    n2h2.Visible = false;
                    n2h3.Visible = false;
                    break;
                case 2:
                    n2v1.Visible = false;
                    n2v2.Visible = true;
                    n2v3.Visible = true;
                    n2v4.Visible = false;
                    n2h1.Visible = true;
                    n2h2.Visible = true;
                    n2h3.Visible = true;
                    break;
                case 3:
                    n2v1.Visible = false;
                    n2v2.Visible = true;
                    n2v3.Visible = false;
                    n2v4.Visible = true;
                    n2h1.Visible = true;
                    n2h2.Visible = true;
                    n2h3.Visible = true;
                    break;
                case 4:
                    n2v1.Visible = true;
                    n2v2.Visible = true;
                    n2v3.Visible = false;
                    n2v4.Visible = true;
                    n2h1.Visible = false;
                    n2h2.Visible = true;
                    n2h3.Visible = false;
                    break;
                case 5:
                    n2v1.Visible = true;
                    n2v2.Visible = false;
                    n2v3.Visible = false;
                    n2v4.Visible = true;
                    n2h1.Visible = true;
                    n2h2.Visible = true;
                    n2h3.Visible = true;
                    break;
                case 6:
                    n2v1.Visible = true;
                    n2v2.Visible = false;
                    n2v3.Visible = true;
                    n2v4.Visible = true;
                    n2h1.Visible = true;
                    n2h2.Visible = true;
                    n2h3.Visible = true;
                    break;
                case 7:
                    n2v1.Visible = false;
                    n2v2.Visible = true;
                    n2v3.Visible = false;
                    n2v4.Visible = true;
                    n2h1.Visible = true;
                    n2h2.Visible = false;
                    n2h3.Visible = false;
                    break;
                case 8:
                    n2v1.Visible = true;
                    n2v2.Visible = true;
                    n2v3.Visible = true;
                    n2v4.Visible = true;
                    n2h1.Visible = true;
                    n2h2.Visible = true;
                    n2h3.Visible = true;
                    break;
                case 9:
                    n2v1.Visible = true;
                    n2v2.Visible = true;
                    n2v3.Visible = false;
                    n2v4.Visible = true;
                    n2h1.Visible = true;
                    n2h2.Visible = true;
                    n2h3.Visible = true;
                    break;
            }
        }

        public void definirN3(int n3)
        {
            switch (n3)
            {
                case 0:
                    n3v1.Visible = true;
                    n3v2.Visible = true;
                    n3v3.Visible = true;
                    n3v4.Visible = true;
                    n3h1.Visible = true;
                    n3h2.Visible = false;
                    n3h3.Visible = true;
                    break;
                case 1:
                    n3v1.Visible = false;
                    n3v2.Visible = true;
                    n3v3.Visible = false;
                    n3v4.Visible = true;
                    n3h1.Visible = false;
                    n3h2.Visible = false;
                    n3h3.Visible = false;
                    break;
                case 2:
                    n3v1.Visible = false;
                    n3v2.Visible = true;
                    n3v3.Visible = true;
                    n3v4.Visible = false;
                    n3h1.Visible = true;
                    n3h2.Visible = true;
                    n3h3.Visible = true;
                    break;
                case 3:
                    n3v1.Visible = false;
                    n3v2.Visible = true;
                    n3v3.Visible = false;
                    n3v4.Visible = true;
                    n3h1.Visible = true;
                    n3h2.Visible = true;
                    n3h3.Visible = true;
                    break;
                case 4:
                    n3v1.Visible = true;
                    n3v2.Visible = true;
                    n3v3.Visible = false;
                    n3v4.Visible = true;
                    n3h1.Visible = false;
                    n3h2.Visible = true;
                    n3h3.Visible = false;
                    break;
                case 5:
                    n3v1.Visible = true;
                    n3v2.Visible = false;
                    n3v3.Visible = false;
                    n3v4.Visible = true;
                    n3h1.Visible = true;
                    n3h2.Visible = true;
                    n3h3.Visible = true;
                    break;
                case 6:
                    n3v1.Visible = true;
                    n3v2.Visible = false;
                    n3v3.Visible = true;
                    n3v4.Visible = true;
                    n3h1.Visible = true;
                    n3h2.Visible = true;
                    n3h3.Visible = true;
                    break;
                case 7:
                    n3v1.Visible = false;
                    n3v2.Visible = true;
                    n3v3.Visible = false;
                    n3v4.Visible = true;
                    n3h1.Visible = true;
                    n3h2.Visible = false;
                    n3h3.Visible = false;
                    break;
                case 8:
                    n3v1.Visible = true;
                    n3v2.Visible = true;
                    n3v3.Visible = true;
                    n3v4.Visible = true;
                    n3h1.Visible = true;
                    n3h2.Visible = true;
                    n3h3.Visible = true;
                    break;
                case 9:
                    n3v1.Visible = true;
                    n3v2.Visible = true;
                    n3v3.Visible = false;
                    n3v4.Visible = true;
                    n3h1.Visible = true;
                    n3h2.Visible = true;
                    n3h3.Visible = true;
                    break;
            }
        }

        public void definirN4(int n4)
        {
            switch (n4)
            {
                case 0:
                    n4v1.Visible = true;
                    n4v2.Visible = true;
                    n4v3.Visible = true;
                    n4v4.Visible = true;
                    n4h1.Visible = true;
                    n4h2.Visible = false;
                    n4h3.Visible = true;
                    break;
                case 1:
                    n4v1.Visible = false;
                    n4v2.Visible = true;
                    n4v3.Visible = false;
                    n4v4.Visible = true;
                    n4h1.Visible = false;
                    n4h2.Visible = false;
                    n4h3.Visible = false;
                    break;
                case 2:
                    n4v1.Visible = false;
                    n4v2.Visible = true;
                    n4v3.Visible = true;
                    n4v4.Visible = false;
                    n4h1.Visible = true;
                    n4h2.Visible = true;
                    n4h3.Visible = true;
                    break;
                case 3:
                    n4v1.Visible = false;
                    n4v2.Visible = true;
                    n4v3.Visible = false;
                    n4v4.Visible = true;
                    n4h1.Visible = true;
                    n4h2.Visible = true;
                    n4h3.Visible = true;
                    break;
                case 4:
                    n4v1.Visible = true;
                    n4v2.Visible = true;
                    n4v3.Visible = false;
                    n4v4.Visible = true;
                    n4h1.Visible = false;
                    n4h2.Visible = true;
                    n4h3.Visible = false;
                    break;
                case 5:
                    n4v1.Visible = true;
                    n4v2.Visible = false;
                    n4v3.Visible = false;
                    n4v4.Visible = true;
                    n4h1.Visible = true;
                    n4h2.Visible = true;
                    n4h3.Visible = true;
                    break;
                case 6:
                    n4v1.Visible = true;
                    n4v2.Visible = false;
                    n4v3.Visible = true;
                    n4v4.Visible = true;
                    n4h1.Visible = true;
                    n4h2.Visible = true;
                    n4h3.Visible = true;
                    break;
                case 7:
                    n4v1.Visible = false;
                    n4v2.Visible = true;
                    n4v3.Visible = false;
                    n4v4.Visible = true;
                    n4h1.Visible = true;
                    n4h2.Visible = false;
                    n4h3.Visible = false;
                    break;
                case 8:
                    n4v1.Visible = true;
                    n4v2.Visible = true;
                    n4v3.Visible = true;
                    n4v4.Visible = true;
                    n4h1.Visible = true;
                    n4h2.Visible = true;
                    n4h3.Visible = true;
                    break;
                case 9:
                    n4v1.Visible = true;
                    n4v2.Visible = true;
                    n4v3.Visible = false;
                    n4v4.Visible = true;
                    n4h1.Visible = true;
                    n4h2.Visible = true;
                    n4h3.Visible = true;
                    break;
            }
        }

        public void definirN5(int n5)
        {
            switch (n5)
            {
                case 0:
                    n5v1.Visible = true;
                    n5v2.Visible = true;
                    n5v3.Visible = true;
                    n5v4.Visible = true;
                    n5h1.Visible = true;
                    n5h2.Visible = false;
                    n5h3.Visible = true;
                    break;
                case 1:
                    n5v1.Visible = false;
                    n5v2.Visible = true;
                    n5v3.Visible = false;
                    n5v4.Visible = true;
                    n5h1.Visible = false;
                    n5h2.Visible = false;
                    n5h3.Visible = false;
                    break;
                case 2:
                    n5v1.Visible = false;
                    n5v2.Visible = true;
                    n5v3.Visible = true;
                    n5v4.Visible = false;
                    n5h1.Visible = true;
                    n5h2.Visible = true;
                    n5h3.Visible = true;
                    break;
                case 3:
                    n5v1.Visible = false;
                    n5v2.Visible = true;
                    n5v3.Visible = false;
                    n5v4.Visible = true;
                    n5h1.Visible = true;
                    n5h2.Visible = true;
                    n5h3.Visible = true;
                    break;
                case 4:
                    n5v1.Visible = true;
                    n5v2.Visible = true;
                    n5v3.Visible = false;
                    n5v4.Visible = true;
                    n5h1.Visible = false;
                    n5h2.Visible = true;
                    n5h3.Visible = false;
                    break;
                case 5:
                    n5v1.Visible = true;
                    n5v2.Visible = false;
                    n5v3.Visible = false;
                    n5v4.Visible = true;
                    n5h1.Visible = true;
                    n5h2.Visible = true;
                    n5h3.Visible = true;
                    break;
                case 6:
                    n5v1.Visible = true;
                    n5v2.Visible = false;
                    n5v3.Visible = true;
                    n5v4.Visible = true;
                    n5h1.Visible = true;
                    n5h2.Visible = true;
                    n5h3.Visible = true;
                    break;
                case 7:
                    n5v1.Visible = false;
                    n5v2.Visible = true;
                    n5v3.Visible = false;
                    n5v4.Visible = true;
                    n5h1.Visible = true;
                    n5h2.Visible = false;
                    n5h3.Visible = false;
                    break;
                case 8:
                    n5v1.Visible = true;
                    n5v2.Visible = true;
                    n5v3.Visible = true;
                    n5v4.Visible = true;
                    n5h1.Visible = true;
                    n5h2.Visible = true;
                    n5h3.Visible = true;
                    break;
                case 9:
                    n5v1.Visible = true;
                    n5v2.Visible = true;
                    n5v3.Visible = false;
                    n5v4.Visible = true;
                    n5h1.Visible = true;
                    n5h2.Visible = true;
                    n5h3.Visible = true;
                    break;
            }
        }

        public void definirN6(int n6)
        {
            switch (n6)
            {
                case 0:
                    n6v1.Visible = true;
                    n6v2.Visible = true;
                    n6v3.Visible = true;
                    n6v4.Visible = true;
                    n6h1.Visible = true;
                    n6h2.Visible = false;
                    n6h3.Visible = true;
                    break;
                case 1:
                    n6v1.Visible = false;
                    n6v2.Visible = true;
                    n6v3.Visible = false;
                    n6v4.Visible = true;
                    n6h1.Visible = false;
                    n6h2.Visible = false;
                    n6h3.Visible = false;
                    break;
                case 2:
                    n6v1.Visible = false;
                    n6v2.Visible = true;
                    n6v3.Visible = true;
                    n6v4.Visible = false;
                    n6h1.Visible = true;
                    n6h2.Visible = true;
                    n6h3.Visible = true;
                    break;
                case 3:
                    n6v1.Visible = false;
                    n6v2.Visible = true;
                    n6v3.Visible = false;
                    n6v4.Visible = true;
                    n6h1.Visible = true;
                    n6h2.Visible = true;
                    n6h3.Visible = true;
                    break;
                case 4:
                    n6v1.Visible = true;
                    n6v2.Visible = true;
                    n6v3.Visible = false;
                    n6v4.Visible = true;
                    n6h1.Visible = false;
                    n6h2.Visible = true;
                    n6h3.Visible = false;
                    break;
                case 5:
                    n6v1.Visible = true;
                    n6v2.Visible = false;
                    n6v3.Visible = false;
                    n6v4.Visible = true;
                    n6h1.Visible = true;
                    n6h2.Visible = true;
                    n6h3.Visible = true;
                    break;
                case 6:
                    n6v1.Visible = true;
                    n6v2.Visible = false;
                    n6v3.Visible = true;
                    n6v4.Visible = true;
                    n6h1.Visible = true;
                    n6h2.Visible = true;
                    n6h3.Visible = true;
                    break;
                case 7:
                    n6v1.Visible = false;
                    n6v2.Visible = true;
                    n6v3.Visible = false;
                    n6v4.Visible = true;
                    n6h1.Visible = true;
                    n6h2.Visible = false;
                    n6h3.Visible = false;
                    break;
                case 8:
                    n6v1.Visible = true;
                    n6v2.Visible = true;
                    n6v3.Visible = true;
                    n6v4.Visible = true;
                    n6h1.Visible = true;
                    n6h2.Visible = true;
                    n6h3.Visible = true;
                    break;
                case 9:
                    n6v1.Visible = true;
                    n6v2.Visible = true;
                    n6v3.Visible = false;
                    n6v4.Visible = true;
                    n6h1.Visible = true;
                    n6h2.Visible = true;
                    n6h3.Visible = true;
                    break;
            }
        }

        private void azulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n6v1.BackColor = System.Drawing.Color.Blue;
            n6v2.BackColor = System.Drawing.Color.Blue;
            n6v3.BackColor = System.Drawing.Color.Blue;
            n6v4.BackColor = System.Drawing.Color.Blue;
            n6h1.BackColor = System.Drawing.Color.Blue;
            n6h2.BackColor = System.Drawing.Color.Blue;
            n6h3.BackColor = System.Drawing.Color.Blue;

            n5v1.BackColor = System.Drawing.Color.Blue;
            n5v2.BackColor = System.Drawing.Color.Blue;
            n5v3.BackColor = System.Drawing.Color.Blue;
            n5v4.BackColor = System.Drawing.Color.Blue;
            n5h1.BackColor = System.Drawing.Color.Blue;
            n5h2.BackColor = System.Drawing.Color.Blue;
            n5h3.BackColor = System.Drawing.Color.Blue;

            n4v1.BackColor = System.Drawing.Color.Blue;
            n4v2.BackColor = System.Drawing.Color.Blue;
            n4v3.BackColor = System.Drawing.Color.Blue;
            n4v4.BackColor = System.Drawing.Color.Blue;
            n4h1.BackColor = System.Drawing.Color.Blue;
            n4h2.BackColor = System.Drawing.Color.Blue;
            n4h3.BackColor = System.Drawing.Color.Blue;

            n3v1.BackColor = System.Drawing.Color.Blue;
            n3v2.BackColor = System.Drawing.Color.Blue;
            n3v3.BackColor = System.Drawing.Color.Blue;
            n3v4.BackColor = System.Drawing.Color.Blue;
            n3h1.BackColor = System.Drawing.Color.Blue;
            n3h2.BackColor = System.Drawing.Color.Blue;
            n3h3.BackColor = System.Drawing.Color.Blue;

            n2v1.BackColor = System.Drawing.Color.Blue;
            n2v2.BackColor = System.Drawing.Color.Blue;
            n2v3.BackColor = System.Drawing.Color.Blue;
            n2v4.BackColor = System.Drawing.Color.Blue;
            n2h1.BackColor = System.Drawing.Color.Blue;
            n2h2.BackColor = System.Drawing.Color.Blue;
            n2h3.BackColor = System.Drawing.Color.Blue;

            n1v1.BackColor = System.Drawing.Color.Blue;
            n1v2.BackColor = System.Drawing.Color.Blue;
            n1v3.BackColor = System.Drawing.Color.Blue;
            n1v4.BackColor = System.Drawing.Color.Blue;
            n1h1.BackColor = System.Drawing.Color.Blue;
            n1h2.BackColor = System.Drawing.Color.Blue;
            n1h3.BackColor = System.Drawing.Color.Blue;
        }

        private void verdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n6v1.BackColor = System.Drawing.Color.Green;
            n6v2.BackColor = System.Drawing.Color.Green;
            n6v3.BackColor = System.Drawing.Color.Green;
            n6v4.BackColor = System.Drawing.Color.Green;
            n6h1.BackColor = System.Drawing.Color.Green;
            n6h2.BackColor = System.Drawing.Color.Green;
            n6h3.BackColor = System.Drawing.Color.Green;

            n5v1.BackColor = System.Drawing.Color.Green;
            n5v2.BackColor = System.Drawing.Color.Green;
            n5v3.BackColor = System.Drawing.Color.Green;
            n5v4.BackColor = System.Drawing.Color.Green;
            n5h1.BackColor = System.Drawing.Color.Green;
            n5h2.BackColor = System.Drawing.Color.Green;
            n5h3.BackColor = System.Drawing.Color.Green;

            n4v1.BackColor = System.Drawing.Color.Green;
            n4v2.BackColor = System.Drawing.Color.Green;
            n4v3.BackColor = System.Drawing.Color.Green;
            n4v4.BackColor = System.Drawing.Color.Green;
            n4h1.BackColor = System.Drawing.Color.Green;
            n4h2.BackColor = System.Drawing.Color.Green;
            n4h3.BackColor = System.Drawing.Color.Green;

            n3v1.BackColor = System.Drawing.Color.Green;
            n3v2.BackColor = System.Drawing.Color.Green;
            n3v3.BackColor = System.Drawing.Color.Green;
            n3v4.BackColor = System.Drawing.Color.Green;
            n3h1.BackColor = System.Drawing.Color.Green;
            n3h2.BackColor = System.Drawing.Color.Green;
            n3h3.BackColor = System.Drawing.Color.Green;

            n2v1.BackColor = System.Drawing.Color.Green;
            n2v2.BackColor = System.Drawing.Color.Green;
            n2v3.BackColor = System.Drawing.Color.Green;
            n2v4.BackColor = System.Drawing.Color.Green;
            n2h1.BackColor = System.Drawing.Color.Green;
            n2h2.BackColor = System.Drawing.Color.Green;
            n2h3.BackColor = System.Drawing.Color.Green;

            n1v1.BackColor = System.Drawing.Color.Green;
            n1v2.BackColor = System.Drawing.Color.Green;
            n1v3.BackColor = System.Drawing.Color.Green;
            n1v4.BackColor = System.Drawing.Color.Green;
            n1h1.BackColor = System.Drawing.Color.Green;
            n1h2.BackColor = System.Drawing.Color.Green;
            n1h3.BackColor = System.Drawing.Color.Green;
        }

        private void vermelhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n6v1.BackColor = System.Drawing.Color.Red;
            n6v2.BackColor = System.Drawing.Color.Red;
            n6v3.BackColor = System.Drawing.Color.Red;
            n6v4.BackColor = System.Drawing.Color.Red;
            n6h1.BackColor = System.Drawing.Color.Red;
            n6h2.BackColor = System.Drawing.Color.Red;
            n6h3.BackColor = System.Drawing.Color.Red;

            n5v1.BackColor = System.Drawing.Color.Red;
            n5v2.BackColor = System.Drawing.Color.Red;
            n5v3.BackColor = System.Drawing.Color.Red;
            n5v4.BackColor = System.Drawing.Color.Red;
            n5h1.BackColor = System.Drawing.Color.Red;
            n5h2.BackColor = System.Drawing.Color.Red;
            n5h3.BackColor = System.Drawing.Color.Red;

            n4v1.BackColor = System.Drawing.Color.Red;
            n4v2.BackColor = System.Drawing.Color.Red;
            n4v3.BackColor = System.Drawing.Color.Red;
            n4v4.BackColor = System.Drawing.Color.Red;
            n4h1.BackColor = System.Drawing.Color.Red;
            n4h2.BackColor = System.Drawing.Color.Red;
            n4h3.BackColor = System.Drawing.Color.Red;

            n3v1.BackColor = System.Drawing.Color.Red;
            n3v2.BackColor = System.Drawing.Color.Red;
            n3v3.BackColor = System.Drawing.Color.Red;
            n3v4.BackColor = System.Drawing.Color.Red;
            n3h1.BackColor = System.Drawing.Color.Red;
            n3h2.BackColor = System.Drawing.Color.Red;
            n3h3.BackColor = System.Drawing.Color.Red;

            n2v1.BackColor = System.Drawing.Color.Red;
            n2v2.BackColor = System.Drawing.Color.Red;
            n2v3.BackColor = System.Drawing.Color.Red;
            n2v4.BackColor = System.Drawing.Color.Red;
            n2h1.BackColor = System.Drawing.Color.Red;
            n2h2.BackColor = System.Drawing.Color.Red;
            n2h3.BackColor = System.Drawing.Color.Red;

            n1v1.BackColor = System.Drawing.Color.Red;
            n1v2.BackColor = System.Drawing.Color.Red;
            n1v3.BackColor = System.Drawing.Color.Red;
            n1v4.BackColor = System.Drawing.Color.Red;
            n1h1.BackColor = System.Drawing.Color.Red;
            n1h2.BackColor = System.Drawing.Color.Red;
            n1h3.BackColor = System.Drawing.Color.Red;
        }

        private void pretoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n6v1.BackColor = System.Drawing.Color.Black;
            n6v2.BackColor = System.Drawing.Color.Black;
            n6v3.BackColor = System.Drawing.Color.Black;
            n6v4.BackColor = System.Drawing.Color.Black;
            n6h1.BackColor = System.Drawing.Color.Black;
            n6h2.BackColor = System.Drawing.Color.Black;
            n6h3.BackColor = System.Drawing.Color.Black;

            n5v1.BackColor = System.Drawing.Color.Black;
            n5v2.BackColor = System.Drawing.Color.Black;
            n5v3.BackColor = System.Drawing.Color.Black;
            n5v4.BackColor = System.Drawing.Color.Black;
            n5h1.BackColor = System.Drawing.Color.Black;
            n5h2.BackColor = System.Drawing.Color.Black;
            n5h3.BackColor = System.Drawing.Color.Black;

            n4v1.BackColor = System.Drawing.Color.Black;
            n4v2.BackColor = System.Drawing.Color.Black;
            n4v3.BackColor = System.Drawing.Color.Black;
            n4v4.BackColor = System.Drawing.Color.Black;
            n4h1.BackColor = System.Drawing.Color.Black;
            n4h2.BackColor = System.Drawing.Color.Black;
            n4h3.BackColor = System.Drawing.Color.Black;

            n3v1.BackColor = System.Drawing.Color.Black;
            n3v2.BackColor = System.Drawing.Color.Black;
            n3v3.BackColor = System.Drawing.Color.Black;
            n3v4.BackColor = System.Drawing.Color.Black;
            n3h1.BackColor = System.Drawing.Color.Black;
            n3h2.BackColor = System.Drawing.Color.Black;
            n3h3.BackColor = System.Drawing.Color.Black;

            n2v1.BackColor = System.Drawing.Color.Black;
            n2v2.BackColor = System.Drawing.Color.Black;
            n2v3.BackColor = System.Drawing.Color.Black;
            n2v4.BackColor = System.Drawing.Color.Black;
            n2h1.BackColor = System.Drawing.Color.Black;
            n2h2.BackColor = System.Drawing.Color.Black;
            n2h3.BackColor = System.Drawing.Color.Black;

            n1v1.BackColor = System.Drawing.Color.Black;
            n1v2.BackColor = System.Drawing.Color.Black;
            n1v3.BackColor = System.Drawing.Color.Black;
            n1v4.BackColor = System.Drawing.Color.Black;
            n1h1.BackColor = System.Drawing.Color.Black;
            n1h2.BackColor = System.Drawing.Color.Black;
            n1h3.BackColor = System.Drawing.Color.Black;
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desenvolvido por Alan H. Ribeiro. Envie sugestões e dicas para 

alan.sonicssa@gmail.com \nAceito críticas tmb :) \nE sim, eu sei, esse programa não faz porra 

nenhuma kkkk \nObrigado por testar!", "Sobre Relógio Digital");
        }
 
    }
}
