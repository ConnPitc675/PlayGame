using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace PlayGame
{
    public partial class Form1 : Form
    { 

        public Form1()
        {
            InitializeComponent();
        }

        private void ClickToPlay_Click(object sender, EventArgs e)
        {
            SoundPlayer beep1 = new SoundPlayer(Properties.Resources.beep_01a); //sets sound files to be used
            SoundPlayer beep2 = new SoundPlayer(Properties.Resources.LastBeep);
            SoundPlayer pacman = new SoundPlayer(Properties.Resources.pacmanSound);
            Graphics formGraphics = this.CreateGraphics();
            Font CFont = new Font("Lucida Console", 80, FontStyle.Bold);
            Font RamFont = new Font("Lucida Console", 40, FontStyle.Bold);
            SolidBrush Redbrush = new SolidBrush(Color.Red);
            SolidBrush Whitebrush = new SolidBrush(Color.White);
            Font drawFont = new Font("Arial", 6, FontStyle.Regular);
            SolidBrush drawBrush = new SolidBrush(Color.Gray);

            ClickToPlay.Text = " "; //changes text in click to play bex to nothing
            ClickToPlay.BorderStyle = BorderStyle.None; //changes the border to not appear

            Refresh();
            Thread.Sleep(500); //put thread to spleep
            GameWillStart.Text = "The Game Will Start In 3"; //display new line of text on the screen
            beep2.Play(); //play beep2 file as set earlier

            Refresh();
            Thread.Sleep(1000);
            GameWillStart.Text = "The Game Will Start In 2";
            beep2.Play();

            Refresh();
            Thread.Sleep(1000);
            GameWillStart.Text = "The Game Will Start In 1";
            beep2.Play();
            

            Refresh();
            Thread.Sleep(1000);
            BackColor = Color.Green; //changes the backgrond colour from black to green
            Go.BackColor = Color.Green; //change the text box color to green to prevent black box from appearing on screen
            GameWillStart.Text = ""; //gets rid of text from gamewillstart text box
            GameWillStart.BackColor = Color.Green;
            beep1.Play(); //play beep1 file as set earlier
            formGraphics.FillEllipse(Redbrush, 65, 125, 200, 100); //create red ellipse
            formGraphics.DrawString("C", CFont, Whitebrush, 70, 125); //create white 'c' on ellipse
            formGraphics.DrawString("rams", RamFont, Whitebrush, 115, 150); //create white 'rams' on ellipse
            formGraphics.TranslateTransform(275, 140);
            formGraphics.RotateTransform(90);
            formGraphics.DrawString("Central Rams Arcade", drawFont, drawBrush, new Rectangle());
            formGraphics.ResetTransform();
            ClickToPlay.BackColor = Color.Green;

            Thread.Sleep(1000);
            Controls.Clear();
            
            Pen BorderLine = new Pen(Color.Blue, 5);
            SolidBrush PacMan = new SolidBrush(Color.Yellow);

            formGraphics.Clear(Color.Black);
            formGraphics.DrawLine(BorderLine, 50, 0, 50, 200);
            formGraphics.DrawLine(BorderLine, 48, 200, 200, 200);
            formGraphics.DrawLine(BorderLine, 100, 0, 100, 150);
            formGraphics.DrawLine(BorderLine, 98, 150, 200, 150);

            Thread.Sleep(1000);

            formGraphics.FillEllipse(PacMan, 53, 3, 44, 44);

            Thread.Sleep(1000);
            formGraphics.Clear(Color.Black);
            formGraphics.DrawLine(BorderLine, 50, 0, 50, 200);
            formGraphics.DrawLine(BorderLine, 48, 200, 200, 200);
            formGraphics.DrawLine(BorderLine, 100, 0, 100, 150);
            formGraphics.DrawLine(BorderLine, 98, 150, 200, 150);
            formGraphics.FillPie(PacMan, 53, 53, 44, 44, 120, 300);
            pacman.Play();

            Thread.Sleep(1000);
            formGraphics.Clear(Color.Black);
            formGraphics.DrawLine(BorderLine, 50, 0, 50, 200);
            formGraphics.DrawLine(BorderLine, 48, 200, 200, 200);
            formGraphics.DrawLine(BorderLine, 100, 0, 100, 150);
            formGraphics.DrawLine(BorderLine, 98, 150, 200, 150);
            formGraphics.FillEllipse(PacMan, 53, 103, 44, 44);
            pacman.Play();

            Thread.Sleep(1000);
            formGraphics.Clear(Color.Black);
            formGraphics.DrawLine(BorderLine, 50, 0, 50, 200);
            formGraphics.DrawLine(BorderLine, 48, 200, 200, 200);
            formGraphics.DrawLine(BorderLine, 100, 0, 100, 150);
            formGraphics.DrawLine(BorderLine, 98, 150, 200, 150);
            formGraphics.FillPie(PacMan, 53, 153, 44, 44, 120, 300);
            pacman.Play();

            Thread.Sleep(1000);
            formGraphics.Clear(Color.Black);
            formGraphics.DrawLine(BorderLine, 50, 0, 50, 200);
            formGraphics.DrawLine(BorderLine, 48, 200, 200, 200);
            formGraphics.DrawLine(BorderLine, 100, 0, 100, 150);
            formGraphics.DrawLine(BorderLine, 98, 150, 200, 150);
            formGraphics.FillEllipse(PacMan, 103, 153, 44, 44);
            pacman.Play();

            Thread.Sleep(1000);
            formGraphics.Clear(Color.Black);
            formGraphics.DrawLine(BorderLine, 50, 0, 50, 200);
            formGraphics.DrawLine(BorderLine, 48, 200, 200, 200);
            formGraphics.DrawLine(BorderLine, 100, 0, 100, 150);
            formGraphics.DrawLine(BorderLine, 98, 150, 200, 150);
            formGraphics.FillPie(PacMan, 153, 153, 44, 44, 30, 290);
            pacman.Play();

            Thread.Sleep(1000);
            formGraphics.Clear(Color.Black);
            formGraphics.DrawLine(BorderLine, 50, 0, 50, 200);
            formGraphics.DrawLine(BorderLine, 48, 200, 200, 200);
            formGraphics.DrawLine(BorderLine, 100, 0, 100, 150);
            formGraphics.DrawLine(BorderLine, 98, 150, 200, 150);
            formGraphics.FillEllipse(PacMan, 203, 153, 44, 44);
            pacman.Play();

            Thread.Sleep(30);
            Font congrats = new Font("Courier New", 16, FontStyle.Bold);
            SolidBrush congratsBrush = new SolidBrush(Color.Yellow);
            formGraphics.DrawString("congrats", congrats, congratsBrush, 200, 200);
            

        }
    }
}
