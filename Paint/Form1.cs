using Paint.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        Drawer d;
        public Form1()
        {
            InitializeComponent();
            d = new Drawer(pictureBox1);
            toolStripLabel2.Text = d.Shape.ToString();
        }

       

        private void pictureBox1_MouseMove_1(object sender, MouseEventArgs e)
        {
            toolStripLabel1.Text = e.Location.ToString();

            if(d.Shape == Shape.Eraser)
            {

            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Shapes_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            switch (btn.Name)
            {
                case "Pencil":
                    d.Shape = Shape.Pencil;
                    break;
                case "pen1":
                    d.Shape = Shape.pen1;
                    break;
                case "Line":
                    d.Shape = Shape.Line;
                    break;
                case "Ellipse":
                    d.Shape = Shape.Ellipse;
                    break;
                case "Rectangle":
                    d.Shape = Shape.Rectangle;
                    break;
                case "Triangle":
                    d.Shape = Shape.Triangle;
                    break;
                case "Eraser":
                    d.Shape = Shape.Eraser;
                    break;
                case "trapezoid":
                    d.Shape = Shape.trapezoid;
                    break;
                case "octagon":
                    d.Shape = Shape.octagon;
                    break;
                case "hexagon":
                    d.Shape = Shape.hexagon;
                    break;
                case "hexagon2":
                    d.Shape = Shape.hexagon2;
                    break;
                case "cube":
                    d.Shape = Shape.cube;
                    break;
                case "star":
                    d.Shape = Shape.star;
                    break;
                case "romb":
                    d.Shape = Shape.romb;
                    break;
            }
            toolStripLabel2.Text = d.Shape.ToString();
        }

        private void Colors_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            d.pen.Color = btn.BackColor;
            
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            d.g.Clear(Color.White);
            pictureBox1.Refresh();
            d.IsImage = false;
        }

        //private void Plus_Minus_Click(object sender, EventArgs e)
        //{
           // Button btn = sender as Button;
            //switch (btn.Text)
            //{
               // case "+":
                  //  if(int.Parse(FontOfPen.Text) < 3)
                    //{
                     //   FontOfPen.Text = (int.Parse(FontOfPen.Text) + 1).ToString();
                        //d.pen.Width += 1;
                    //}
                   // break;
                //case "-":
                    //if (int.Parse(FontOfPen.Text) > 1)
                   // {
                     //   FontOfPen.Text = (int.Parse(FontOfPen.Text) - 1).ToString();
                      //  d.pen.Width -= 1;
                   // }
                    //break;
          //  }
        //}

        private void ColorDialog_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            colorDialog1.ShowDialog();

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btn.BackColor = colorDialog1.Color;
                d.pen.Color = colorDialog1.Color;
            }


        }

        private void Open_click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                d.Load(openFileDialog1.FileName);
            }

        }

        public void Save_click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();

            if(saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName.Length > 0)
            {
                d.Save(saveFileDialog1.FileName);
            }

            
        }

        private void Exit_click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Create_click(object sender, EventArgs e)
        {
            if (!d.IsImage)
            {
                MessageBox.Show("Picturebox is empty!");

            }
            else
            {
                DialogResult result1 = MessageBox.Show("save ?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);


                switch (result1)
                {
                    case DialogResult.Yes:
                        Save_click("save", e);
                        break;
                    case DialogResult.No:
                        d.g.Clear(Color.White);
                        d.pBox.Refresh();
                        break;
                    case DialogResult.Cancel:
                        break;
                }
            }


        }

        private void FontOfPen_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            d.pen.Width += 1;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            d.pen.Width -= 1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
