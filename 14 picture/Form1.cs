using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_picture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.GetImage;
        }
         Point piste = new Point(0, 0);
         Bitmap bit;
         Graphics Graf; 
         
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graf = e.Graphics;
            //kuva
            bit = new Bitmap(Properties.Resources.hessu2);
            //läåinäkyvä
            bit.MakeTransparent();
            //kuvan tulostaminen
            Graf.DrawImage(bit, piste);
            // Poista vilkkuminen!
            DoubleBuffered = true;
            //koordinaatit 
            DrawCordinates(Graf);

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
           if(e.Button == MouseButtons.Left)
           {
                piste = e.Location;
                Invalidate();
           }
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                piste = e.Location;
                Invalidate();
            }
        }
        private void DrawCordinates(Graphics Graf)

        {

            // Piirretään piikoordinaattien arvot näytölle. 

            Graf.DrawString("(" + piste.X + " ," + piste.Y + ")", new Font("Arial", 14, System.Drawing.FontStyle.Regular), new SolidBrush(Color.Red), 8, 30);

        }
    }
}
