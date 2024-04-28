using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            resetten();
            bilderlegen();
        }

        int[] feld = new int[36];
        int spieler = 1;
        int buttonnummer1 = 0;
        int buttonnummer2 = 0;
        bool ende = false;
        int richtigefelder = 0;
        int spieler1 = 0;
        int spieler2 = 0;




        private void button37_Click(object sender, EventArgs e)
        {
            resetten();
            bilderlegen();
            buttonenable();
        }

        private void resetten()
        {
            button1.BackgroundImage = Image.FromFile("Rückseite.jpg");
            button2.BackgroundImage = Image.FromFile("Rückseite.jpg");
            button3.BackgroundImage = Image.FromFile("Rückseite.jpg");
            button4.BackgroundImage = Image.FromFile("Rückseite.jpg");
            button5.BackgroundImage = Image.FromFile("Rückseite.jpg");
            button6.BackgroundImage = Image.FromFile("Rückseite.jpg");
            button7.BackgroundImage = Image.FromFile("Rückseite.jpg");
            button8.BackgroundImage = Image.FromFile("Rückseite.jpg");
            button9.BackgroundImage = Image.FromFile("Rückseite.jpg");
            button10.BackgroundImage = Image.FromFile("Rückseite.jpg");
            button11.BackgroundImage = Image.FromFile("Rückseite.jpg");
            button12.BackgroundImage = Image.FromFile("Rückseite.jpg");
            button13.BackgroundImage = Image.FromFile("Rückseite.jpg");
            button14.BackgroundImage = Image.FromFile("Rückseite.jpg");
            button15.BackgroundImage = Image.FromFile("Rückseite.jpg");
            button16.BackgroundImage = Image.FromFile("Rückseite.jpg");
            button17.BackgroundImage = Image.FromFile("Rückseite.jpg");
            button18.BackgroundImage = Image.FromFile("Rückseite.jpg");
            button19.BackgroundImage = Image.FromFile("Rückseite.jpg");
            button20.BackgroundImage = Image.FromFile("Rückseite.jpg");
            button21.BackgroundImage = Image.FromFile("Rückseite.jpg");
            button22.BackgroundImage = Image.FromFile("Rückseite.jpg");
            button23.BackgroundImage = Image.FromFile("Rückseite.jpg");
            button24.BackgroundImage = Image.FromFile("Rückseite.jpg");
            button25.BackgroundImage = Image.FromFile("Rückseite.jpg");
            button26.BackgroundImage = Image.FromFile("Rückseite.jpg");
            button27.BackgroundImage = Image.FromFile("Rückseite.jpg");
            button28.BackgroundImage = Image.FromFile("Rückseite.jpg");
            button29.BackgroundImage = Image.FromFile("Rückseite.jpg");
            button30.BackgroundImage = Image.FromFile("Rückseite.jpg");
            button31.BackgroundImage = Image.FromFile("Rückseite.jpg");
            button32.BackgroundImage = Image.FromFile("Rückseite.jpg");
            button33.BackgroundImage = Image.FromFile("Rückseite.jpg");
            button34.BackgroundImage = Image.FromFile("Rückseite.jpg");
            button35.BackgroundImage = Image.FromFile("Rückseite.jpg");
            button36.BackgroundImage = Image.FromFile("Rückseite.jpg");
            spieler = 1;
            spieler1 = 0;
            spieler2 = 0;
            buttonnummer1 = 0;
            buttonnummer2 = 0;
            ende = false;
        }

        private void bilderlegen()
        {
            for (int i = 0; i < 36; i++)
            {
                feld[i] = 0;
            }
            Random zufallszahl = new Random();
            int z = 0;
            while (z < 18)
            {
                int x1 = zufallszahl.Next(0, 36);
                int x2 = zufallszahl.Next(1, 37) - 1;

                if (x1 != x2)
                {
                    if (feld[x1] == 0)
                    {
                        if (feld[x2] == 0)
                        {
                            feld[x1] = z;
                            feld[x2] = z;
                            z++;
                        }
                    }
                }
            }

        }

        void zudecken(int butnummer)
        {
            if (ende == true)
            {
                //nix da
            }
            else
            {
                string bildname = "Rückseite.jpg";
                switch (butnummer)
                {                  // Verzweigung anhand der Buttonnummer
                case 1:
                    button1.BackgroundImage = Image.FromFile(bildname);
                    break;
                case 2:
                    button2.BackgroundImage = Image.FromFile(bildname);
                    break;
                case 3:
                    button3.BackgroundImage = Image.FromFile(bildname);
                    break;
                case 4:
                    button4.BackgroundImage = Image.FromFile(bildname);
                    break;
                case 5:
                    button5.BackgroundImage = Image.FromFile(bildname);
                    break;
                case 6:
                    button6.BackgroundImage = Image.FromFile(bildname);
                    break;
                case 7:
                    button7.BackgroundImage = Image.FromFile(bildname);
                    break;
                case 8:
                    button8.BackgroundImage = Image.FromFile(bildname);
                    break;
                case 9:
                    button9.BackgroundImage = Image.FromFile(bildname);
                    break;
                case 10:
                    button10.BackgroundImage = Image.FromFile(bildname);
                    break;
                case 11:
                    button11.BackgroundImage = Image.FromFile(bildname);
                    break;
                case 12:
                    button12.BackgroundImage = Image.FromFile(bildname);
                    break;
                case 13:
                    button13.BackgroundImage = Image.FromFile(bildname);
                    break;
                case 14:
                    button14.BackgroundImage = Image.FromFile(bildname);
                    break;
                case 15:
                    button15.BackgroundImage = Image.FromFile(bildname);
                    break;
                case 16:
                    button16.BackgroundImage = Image.FromFile(bildname);
                    break;
                case 17:
                    button17.BackgroundImage = Image.FromFile(bildname);
                    break;
                case 18:
                    button18.BackgroundImage = Image.FromFile(bildname);
                    break;
                case 19:
                    button19.BackgroundImage = Image.FromFile(bildname);
                    break;
                case 20:
                    button20.BackgroundImage = Image.FromFile(bildname);
                    break;
                case 21:
                    button21.BackgroundImage = Image.FromFile(bildname);
                    break;
                case 22:
                    button22.BackgroundImage = Image.FromFile(bildname);
                    break;
                case 23:
                    button23.BackgroundImage = Image.FromFile(bildname);
                    break;
                case 24:
                    button24.BackgroundImage = Image.FromFile(bildname);
                    break;
                case 25:
                    button25.BackgroundImage = Image.FromFile(bildname);
                    break;
                case 26:
                    button26.BackgroundImage = Image.FromFile(bildname);
                    break;
                case 27:
                    button27.BackgroundImage = Image.FromFile(bildname);
                    break;
                case 28:
                    button28.BackgroundImage = Image.FromFile(bildname);
                    break;
                case 29:
                    button29.BackgroundImage = Image.FromFile(bildname);
                    break;
                case 30:
                    button30.BackgroundImage = Image.FromFile(bildname);
                    break;
                case 31:
                    button31.BackgroundImage = Image.FromFile(bildname);
                    break;
                case 32:
                    button32.BackgroundImage = Image.FromFile(bildname);
                    break;
                case 33:
                    button33.BackgroundImage = Image.FromFile(bildname);
                    break;
                case 34:
                    button34.BackgroundImage = Image.FromFile(bildname);
                    break;
                case 35:
                    button35.BackgroundImage = Image.FromFile(bildname);
                    break;
                case 36:
                    button36.BackgroundImage = Image.FromFile(bildname);
                    break;

                default:
                    break;

                }
            }
        }

        void aufdecken(int butnummer)
        {
            int bildnummer = feld[butnummer - 1];   // -2, da Buttons bei 2 beginnen
            string bildname;                        // Variable für den String Bildnamen
            switch (bildnummer)                     // Verzweigung anhand der Bildnummer
            {
                case 0:                             // Fall 0
                    bildname = "Bild1.jpg";         // Bild1 zuweisen
                    break;
                case 1:
                    bildname = "Bild2.jpg";
                    break;
                case 2:
                    bildname = "Bild3.jpg";
                    break;
                case 3:
                    bildname = "Bild4.jpg";
                    break;
                case 4:
                    bildname = "Bild5.jpg";
                    break;
                case 5:
                    bildname = "Bild6.jpg";
                    break;
                case 6:
                    bildname = "Bild7.jpg";
                    break;
                case 7:
                    bildname = "Bild8.jpg";
                    break;
                case 8:
                    bildname = "Bild9.jpg";
                    break;
                case 9:
                    bildname = "Bild10.jpg";
                    break;
                case 10:
                    bildname = "Bild11.jpg";
                    break;
                case 11:
                    bildname = "Bild12.jpg";
                    break;
                case 12:
                    bildname = "Bild13.jpg";
                    break;
                case 13:
                    bildname = "Bild14.jpg";
                    break;
                case 14:
                    bildname = "Bild15.jpg";
                    break;
                case 15:
                    bildname = "Bild16.jpg";
                    break;
                case 16:
                    bildname = "Bild17.jpg";
                    break;
                case 17:
                    bildname = "Bild18.jpg";
                    break;
                default:
                    bildname = "Rueckseite.jpg";
                    break;
            }

            if (ende == true)
            {
                // Nichts
            }
            else
            {
                switch (butnummer)                  // Verweigung anhand der Buttonnummer
                {
                    case 1:
                        button1.BackgroundImage = Image.FromFile(bildname);
                        break;
                    case 2:
                        button2.BackgroundImage = Image.FromFile(bildname);
                        break;
                    case 3:
                        button3.BackgroundImage = Image.FromFile(bildname);
                        break;
                    case 4:
                        button4.BackgroundImage = Image.FromFile(bildname);
                        break;
                    case 5:
                        button5.BackgroundImage = Image.FromFile(bildname);
                        break;
                    case 6:
                        button6.BackgroundImage = Image.FromFile(bildname);
                        break;
                    case 7:
                        button7.BackgroundImage = Image.FromFile(bildname);
                        break;
                    case 8:
                        button8.BackgroundImage = Image.FromFile(bildname);
                        break;
                    case 9:
                        button9.BackgroundImage = Image.FromFile(bildname);
                        break;
                    case 10:
                        button10.BackgroundImage = Image.FromFile(bildname);
                        break;
                    case 11:
                        button11.BackgroundImage = Image.FromFile(bildname);
                        break;
                    case 12:
                        button12.BackgroundImage = Image.FromFile(bildname);
                        break;
                    case 13:
                        button13.BackgroundImage = Image.FromFile(bildname);
                        break;
                    case 14:
                        button14.BackgroundImage = Image.FromFile(bildname);
                        break;
                    case 15:
                        button15.BackgroundImage = Image.FromFile(bildname);
                        break;
                    case 16:
                        button16.BackgroundImage = Image.FromFile(bildname);
                        break;
                    case 17:
                        button17.BackgroundImage = Image.FromFile(bildname);
                        break;
                    case 18:
                        button18.BackgroundImage = Image.FromFile(bildname);
                        break;
                    case 19:
                        button19.BackgroundImage = Image.FromFile(bildname);
                        break;
                    case 20:
                        button20.BackgroundImage = Image.FromFile(bildname);
                        break;
                    case 21:
                        button21.BackgroundImage = Image.FromFile(bildname);
                        break;
                    case 22:
                        button22.BackgroundImage = Image.FromFile(bildname);
                        break;
                    case 23:
                        button23.BackgroundImage = Image.FromFile(bildname);
                        break;
                    case 24:
                        button24.BackgroundImage = Image.FromFile(bildname);
                        break;
                    case 25:
                        button25.BackgroundImage = Image.FromFile(bildname);
                        break;
                    case 26:
                        button26.BackgroundImage = Image.FromFile(bildname);
                        break;
                    case 27:
                        button27.BackgroundImage = Image.FromFile(bildname);
                        break;
                    case 28:
                        button28.BackgroundImage = Image.FromFile(bildname);
                        break;
                    case 29:
                        button29.BackgroundImage = Image.FromFile(bildname);
                        break;
                    case 30:
                        button30.BackgroundImage = Image.FromFile(bildname);
                        break;
                    case 31:
                        button31.BackgroundImage = Image.FromFile(bildname);
                        break;
                    case 32:
                        button32.BackgroundImage = Image.FromFile(bildname);
                        break;
                    case 33:
                        button33.BackgroundImage = Image.FromFile(bildname);
                        break;
                    case 34:
                        button34.BackgroundImage = Image.FromFile(bildname);
                        break;
                    case 35:
                        button35.BackgroundImage = Image.FromFile(bildname);
                        break;
                    case 36:
                        button36.BackgroundImage = Image.FromFile(bildname);
                        break;
                    default:
                        break;
                }
            }
        }

        void feldclick(int buttonnummer)
        {
            if (ende != false)
            {
                // nix
            }
            else
            {
                aufdecken(buttonnummer);                // Karte aufdecken
                sperren(buttonnummer);                  // Karte speren für neue Eingabe
                if (buttonnummer1 == 0)                 // Prüfen erste karte
                {
                    buttonnummer1 = buttonnummer;       // Nummer des ersten Zugs merken
                }
                else
                {

                    if (feld[buttonnummer1 - 1] != feld[buttonnummer - 1])      // Pruefen, ob Bilder gleich sind -2, da Buttons bei 2 beginnen
                    {
                        buttonnummer2 = buttonnummer;                           // Globale Variable belegen für timer1
                        Timer.Enabled = true;                                  // timer aktivieren, welcher die Karten zudeckt
                        buttondisable();                                        // Buttons sperren

                        if (spieler == 1)                                       // Prüfen, ob Spieler 1 
                        {
                            spieler1++;                                         // Spieler 1 hochzählen
                        }
                        else
                        {
                            spieler2++;                                         // Spieler 1 hochzählen
                        }
                        spielerwechsel();                                       // Spielerwechsel
                        textBox2.Text = "Leider Falsch!\r\nSpieler " + Convert.ToString(spieler) + " bitte!";    // Textausgabe
                        textBox1.Text = Convert.ToString(spieler);              // Anzeige Spieler
                    }
                    else
                    {
                        richtigefelder++;
                        if (richtigefelder == 18)
                        {
                            if (spieler1 > spieler2)                            // Prüfen, ob Spieler 1 gewonnen hat
                            {
                                textBox2.Text = "Gratulation! \r\nSpieler 1 hat gewonnen!";      // Textausgabe
                            }
                            else
                                if (spieler2 > spieler1)                         // Prüfen, ob Spieler 2 gewonnen hat
                            {
                                textBox2.Text = "Gratulation! \r\nSpieler 2 hat gewonnen!";  // Textausgabe
                            }
                            else                                            // Prüfen, ob unentschieden
                            {
                                textBox2.Text = "Leider Unentschieden!";           // Textausgabe
                            }
                            ende = true;
                        }
                        else
                        {
                            textBox2.Text = "Stimmt! \n\rNächstes Kartenpaar!";        // Textausgabe
                            sperren(buttonnummer1);                             // Erste Karte sperren
                            sperren(buttonnummer2);                             // Zweite Karte sperren
                            buttonnummer1 = 0;                                  // Nummer der ersten Karte zuruecksetzen
                            buttonnummer2 = 0;                                  // Nummer der zweiten Karte zuruecksetzen
                        }
                    }
                }
            }
        }

        void sperren(int butnummer)
        {
            switch (butnummer)
            {
                case 1:
                    button1.Enabled = false;
                    break;
                case 2:
                    button2.Enabled = false;
                    break;
                case 3:
                    button3.Enabled = false;
                    break;
                case 4:
                    button4.Enabled = false;
                    break;
                case 5:
                    button5.Enabled = false;
                    break;
                case 6:
                    button6.Enabled = false;
                    break;
                case 7:
                    button7.Enabled = false;
                    break;
                case 8:
                    button8.Enabled = false;
                    break;
                case 9:
                    button9.Enabled = false;
                    break;
                case 10:
                    button10.Enabled = false;
                    break;
                case 11:
                    button11.Enabled = false;
                    break;
                case 12:
                    button12.Enabled = false;
                    break;
                case 13:
                    button13.Enabled = false;
                    break;
                case 14:
                    button14.Enabled = false;
                    break;
                case 15:
                    button15.Enabled = false;
                    break;
                case 16:
                    button16.Enabled = false;
                    break;
                case 17:
                    button17.Enabled = false;
                    break;
                case 18:
                    button18.Enabled = false;
                    break;
                case 19:
                    button19.Enabled = false;
                    break;
                case 20:
                    button20.Enabled = false;
                    break;
                case 21:
                    button21.Enabled = false;
                    break;
                case 22:
                    button22.Enabled = false;
                    break;
                case 23:
                    button23.Enabled = false;
                    break;
                case 24:
                    button24.Enabled = false;
                    break;
                case 25:
                    button25.Enabled = false;
                    break;
                case 26:
                    button26.Enabled = false;
                    break;
                case 27:
                    button27.Enabled = false;
                    break;
                case 28:
                    button28.Enabled = false;
                    break;
                case 29:
                    button29.Enabled = false;
                    break;
                case 30:
                    button30.Enabled = false;
                    break;
                case 31:
                    button31.Enabled = false;
                    break;
                case 32:
                    button32.Enabled = false;
                    break;
                case 33:
                    button33.Enabled = false;
                    break;
                case 34:
                    button34.Enabled = false;
                    break;
                case 35:
                    button35.Enabled = false;
                    break;
                case 36:
                    button36.Enabled = false;
                    break;
                default:
                    break;
            }

        }

        void buttondisable()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button21.Enabled = false;
            button22.Enabled = false;
            button23.Enabled = false;
            button24.Enabled = false;
            button25.Enabled = false;
            button26.Enabled = false;
            button27.Enabled = false;
            button28.Enabled = false;
            button29.Enabled = false;
            button30.Enabled = false;
            button31.Enabled = false;
            button32.Enabled = false;
            button33.Enabled = false;
            button34.Enabled = false;
            button35.Enabled = false;
            button36.Enabled = false;

        }

        void buttonenable()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;
            button21.Enabled = true;
            button22.Enabled = true;
            button23.Enabled = true;
            button24.Enabled = true;
            button25.Enabled = true;
            button26.Enabled = true;
            button27.Enabled = true;
            button28.Enabled = true;
            button29.Enabled = true;
            button30.Enabled = true;
            button31.Enabled = true;
            button32.Enabled = true;
            button33.Enabled = true;
            button34.Enabled = true;
            button35.Enabled = true;
            button36.Enabled = true;

        }
        
        void spielerwechsel()
        {
            if (spieler1 == 0)
            {
                spieler1 = 1;
                spieler2 = 0;
            }
            else
            {
                spieler1 = 0;
                spieler2 = 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            feldclick(1);            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            feldclick(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            feldclick(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            feldclick(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            feldclick(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            feldclick(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            feldclick(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            feldclick(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            feldclick(9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            feldclick(10);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            feldclick(11);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            feldclick(12);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            feldclick(13);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            feldclick(14);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            feldclick(15);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            feldclick(16);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            feldclick(17);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            feldclick(18);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            feldclick(19);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            feldclick(20);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            feldclick(21);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            feldclick(22);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            feldclick(23);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            feldclick(24);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            feldclick(25);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            feldclick(26);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            feldclick(27);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            feldclick(28);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            feldclick(29);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            feldclick(30);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            feldclick(31);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            feldclick(32);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            feldclick(33);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            feldclick(34);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            feldclick(35);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            feldclick(36);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            zudecken(buttonnummer1);    // Zudecken 1. Karte
            zudecken(buttonnummer2);    // Zudecken 2. Karte
                                        // entsperren(buttonnummer1);  // Karte 1 wieder entsperren
                                        // entsperren(buttonnummer2);  // Karte 2 wieder entsperren
            buttonnummer1 = 0;          // Variable zurücksetzen
            buttonnummer2 = 0;          // Variable zurücksetzen
            Timer.Enabled = false;     // Timer stoppen
            buttonenable();             // Buttons wieder aktivieren
        }

        private void button39_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 37; i++)
            {
                aufdecken(i);
                buttondisable();
            }
            textBox2.Text = "Spielende, \r\n aufgedeckt! ";
            ende = true;
        }
    }
}
