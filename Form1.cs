using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memory
{
    public partial class Form1 : Form
    {
        /* public static void CardsInArray(int[]Array)
         {
             Random Randomizer = new Random();
             int imageplacer = Randomizer.Next(1, 16);
             for(int i =0; i <16;i++)
             {
                 int varablele = Array[imageplacer];
                 Array[imageplacer]   =Array[i];
                 Array[i] = varablele;
             }
         } */
        int Rows = 4;
        int Columns = 4;
        PictureBox[] Plaatjes;
        public Form1()
        {

            /*
            private void Rand()
            {
                string[] shuf = new string[16] { "1", "2", "3", "4", "5", "6", "7", "8", "1", "2", "3", "4", "5", "6", "7", "8" };
                Random rnd = new Random();
                for (int t = 0; t < shuf.Length; t++)
                {
                    string tmp = shuf[t];
                    int r = rnd.Next(t, shuf.Length);
                    shuf[t] = shuf[r];
                    shuf[r] = tmp;
                }
            }
            */

            Random Randomizer = new Random();
            int imageplacer = Randomizer.Next(1, 16);
            int[] ImagesArray = new int[Rows * Columns];
            InitializeComponent();
            Plaatjes = new PictureBox[Rows * Columns];
            int i = 0;
            for (int cRow = 0; cRow < Rows; cRow++)
            {
                for (int cColumn = 0; cColumn < Columns; cColumn++)
                {
                    PictureBox Box = new PictureBox();
                    Box.Location = new System.Drawing.Point(10 + cColumn * 210, cRow * 210);
                    Box.Name = "" + i;
                    Box.Size = new System.Drawing.Size(128, 128);
                    string imgpath = (Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName).ToString() + @"\placeholder\kaartje" + 0 + ".png";
                    Box.Image = System.Drawing.Image.FromFile(imgpath);
                    Plaatjes[i] = Box;
                    i++;
                    this.Controls.Add(Box);
                    Box.Click += Box_Click;
                }
            }
        }
        /*
        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
        */

        private void Box_Click(object sender, EventArgs e)
        {
            PictureBox Boxje = (PictureBox)sender;
            Boxje.BackColor = Color.Black;
            string imgpath = (Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName).ToString() + @"\placeholder\kaartje" + Boxje.Name + ".png";
            Boxje.Image = System.Drawing.Image.FromFile(imgpath);

        }
        private int IndexPlaatjes(PictureBox Boks)
        {
            int i = 0;
            foreach (PictureBox b in Plaatjes)
            {
                if (b == Boks)
                    return i;
                i++;
            }
            return -1;
        }

        /*
                 secondClicked = clickedLabel;
        secondClicked.ForeColor = Color.Black;

        // If the player clicked two matching icons, keep them 
        // black and reset firstClicked and secondClicked 
        // so the player can click another icon
        if (firstClicked.Text == secondClicked.Text)
        {
            firstClicked = null;
            secondClicked = null;
            return;
        }

        // If the player gets this far, the player 
        // clicked two different icons, so start the 
        // timer (which will wait three quarters of 
        // a second, and then hide the icons)
        timer1.Start();
         
         */

    }
}
