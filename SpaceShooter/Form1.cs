using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EZInput;
namespace SpaceShooter
{
    public partial class Form1 : Form
    {
        private PictureBox spaceship;

        public Form1()
        {
            InitializeComponent();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Keyboard.IsKeyPressed(Key.RightArrow))
            {
                if(spaceship.Right+20<this.Width)
                {
                    spaceship.Left=spaceship.Left + 10;
                }
            }
            else if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                if(spaceship.Left>0)
                {
                    spaceship.Left = spaceship.Left - 10;
                }
            }
            if (Keyboard.IsKeyPressed(Key.UpArrow))
            {
                if(spaceship.Top<this.Height)
                {
                    spaceship.Top = spaceship.Top - 5;
                }
            }
            else if (Keyboard.IsKeyPressed(Key.DownArrow))
            {
                if (spaceship.Bottom+40 < this.Height)
                {
                    spaceship.Top = spaceship.Top + 5;
                }
            }
            if (Keyboard.IsKeyPressed(Key.Space))
            {
                
            }
        }
        public void fire()
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetPlayer();
        }
        private void SetPlayer()
        {
            spaceship = new PictureBox();
            Image img = SpaceShooter.Properties.Resources.ZKZz;
            spaceship.Image = img;
            spaceship.Width = img.Width;
            spaceship.Height=img.Height;
            spaceship.BackColor = Color.Transparent;
            System.Drawing.Point location = new System.Drawing.Point();
            spaceship.Size= new Size(150, 150);
            spaceship.SizeMode = PictureBoxSizeMode.StretchImage;
            location.X = this.Width / 2;
            location.Y = this.Height / 2;
            spaceship.Location = location;
            this.Controls.Add(spaceship);
        }
    }
}
