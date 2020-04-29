using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace JakiKurs
{
    public partial class Form1 : Form
    {
        #region funkcjaPobirajacaDane
        private void OdswiezDane()
        {
            List<string> plik = new List<string>();//do wczytania danych

            using (WebClient plikNet = new WebClient())
            {
                try
                {
                    plikNet.DownloadFile("http://www.nbp.pl/Kursy/xml/dir.txt", "dir.txt");
                }
                catch (WebException )
                {
                    MessageBox.Show("bład połączenia","Komunikat:", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }

            StreamReader wczytany = new StreamReader("dir.txt");
            string linia = "";

            while (linia != null)//ustalenie nazwy najnowszej tabelki
            {
                linia = wczytany.ReadLine();

                if (linia != null)
                {
                    if (linia.StartsWith("a"))
                    {
                        plik.Add(linia);
                    }
                }
            }
            wczytany.Close();

            try
            {
                XPathDocument document = new XPathDocument("http://www.nbp.pl/kursy/xml/" + plik[plik.Count - 1] + ".xml");//adres do tabelki
                XPathNavigator navigator = document.CreateNavigator();
                XPathNodeIterator iterator;
                iterator = navigator.Select("tabela_kursow");

                foreach (XPathNavigator nav in iterator)
                {
                    labelData.Text = nav.SelectSingleNode("data_publikacji").Value;
                    dataToolStripMenuItem.Text = "Data kursu: " + labelData.Text;
                }

                iterator = navigator.Select("tabela_kursow/pozycja");

                foreach (XPathNavigator nav in iterator)
                {
                    if (nav.SelectSingleNode("kod_waluty").Value == "USD")
                    {
                        labelDolar.Text = nav.SelectSingleNode("kurs_sredni").Value + " zł";
                        dolarToolStripMenuItem.Text = "USD: " + labelDolar.Text;

                    }
                    else if (nav.SelectSingleNode("kod_waluty").Value == "EUR")
                    {
                        labelEuro.Text = nav.SelectSingleNode("kurs_sredni").Value + " zł";
                        euroToolStripMenuItem.Text = "EUR: " + labelEuro.Text;
                    }
                    else if (nav.SelectSingleNode("kod_waluty").Value == "GBP")
                    {
                        labelFunt.Text = nav.SelectSingleNode("kurs_sredni").Value + " zł";
                        funtToolStripMenuItem.Text = "GBR: " + labelFunt.Text;
                    }
                    else if (nav.SelectSingleNode("kod_waluty").Value == "CHF")
                    {
                        labelFrank.Text = nav.SelectSingleNode("kurs_sredni").Value + " zł";
                        frankToolStripMenuItem.Text = "CHF: " + labelFrank.Text;
                    }
                }
            }
            catch (XPathException ex)
            {
                labelEuro.Text = "Błąd. Nie można pobrać kursu walut!" + ex;
            }
        }

        #endregion funkcjaPobirajacaDane

        public Form1()
        {
            InitializeComponent();
            OdswiezDane();
        }


        private void Timer1_Tick(object Sender, EventArgs e)
        {
            OdswiezDane();
        }


        private void buttonOdswiez_Click(object sender, EventArgs e)
        {
            if (buttonOdswiez.Text == "Wyłącz")
            {
                buttonOdswiez.Text = "Włącz";
                timer1.Enabled = false;
            }
            else
            {
                buttonOdswiez.Text = "Wyłącz";
                timer1.Enabled = true;
            }
        }












        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void odświeżToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OdswiezDane();
        }



        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                notifyIconTray.Visible = true;
                notifyIconTray.Text = euroToolStripMenuItem.Text + "||" + dolarToolStripMenuItem.Text + "||" + funtToolStripMenuItem.Text + "||" + frankToolStripMenuItem.Text;
                notifyIconTray.Icon = this.Icon;
                notifyIconTray.ContextMenuStrip = contextMenuStrip1;
                this.ShowInTaskbar = false;
            }
        }


        private void pokażNormalnieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;

            notifyIconTray.Visible = false;
            this.ShowInTaskbar = true;
            this.Visible = true;
        }

        private void notifyIconTray_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;

            notifyIconTray.Visible = false;
            this.ShowInTaskbar = true;
            this.Visible = true;
        }

 
 
    }
}
