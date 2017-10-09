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
                    Box.Location = new System.Drawing.Point(cColumn * 128, cRow * 128);
                    Box.Name = "pictureBox" + i;
                    Box.Size = new System.Drawing.Size(128, 128);
                    Plaatjes[i] = Box;
                    i++;
                    this.Controls.Add(Box);
                    Box.Click += Box_Click;
                }
            }
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void Box_Click(object sender, EventArgs e)
        {
            PictureBox Boxje = (PictureBox)sender;
            Boxje.BackColor = Color.Black;
            string imgpath = (Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName).ToString() + @"\placeholder\kaartje1" + ".png";
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
    }
}
