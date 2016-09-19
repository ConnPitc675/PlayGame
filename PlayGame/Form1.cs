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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ClickToPlay_Click(object sender, EventArgs e)
        {
            SoundPlayer beep1 = new SoundPlayer(Properties.Resources.beep_01a); //sets sound files to be used
            SoundPlayer beep2 = new SoundPlayer(Properties.Resources.LastBeep);
            Graphics formGraphics = this.CreateGraphics();
            Graphics fg = this.CreateGraphics();
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
            fg.DrawString("C", CFont, Whitebrush, 70, 125); //create white 'c' on ellipse
            fg.DrawString("rams", RamFont, Whitebrush, 115, 150); //create white 'rams' on ellipse
            fg.TranslateTransform(275, 140);
            fg.RotateTransform(90);
            fg.DrawString("Central Rams Arcade", drawFont, drawBrush, new Rectangle());
            fg.ResetTransform();
            ClickToPlay.BackColor = Color.Green;

            Thread.Sleep(1000);
            Controls.Clear();
            BackColor = Color.Black;

            Graphics Lines = this.CreateGraphics();
            Graphics Dot = this.CreateGraphics();
            Pen BorderLine = new Pen(Color.Blue);
            SolidBrush PacMan = new SolidBrush(Color.Yellow);

            Lines.DrawLine(BorderLine, 0, 0, 100, 100);


        }
    }
}
