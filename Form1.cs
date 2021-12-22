using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGR
{
    public partial class Form1 : Form
    {
        private float cmax;
        private int selectedState, selectedPoint, chord;
        private Point[] firstGrafUp = 
        { 
            new Point(0, 0), 
            new Point(20, 48), 
            new Point(50, 78), 
            new Point(100, 104), 
            new Point(150, 117), 
            new Point(200, 122), 
            new Point(300, 119),
            new Point(400, 109),
            new Point(500, 94),
            new Point(700, 57),
            new Point(900, 19),
            new Point(1000, 0)
        };
        private Point[] firstGrafDown =
        {
            new Point(0, 0),
            new Point(20, -19),
            new Point(50, -26),
            new Point(100, -31),
            new Point(150, -32),
            new Point(200, -33),
            new Point(300, -33),
            new Point(400, -31),
            new Point(500, -27),
            new Point(700, -19),
            new Point(900, -6),
            new Point(1000, 0)
        };
        private Point[] secondGrafUp =
        {
            new Point(0, 0),
            new Point(25, 34),
            new Point(50, 47),
            new Point(100, 66),
            new Point(150, 79),
            new Point(200, 88),
            new Point(300, 97),
            new Point(400, 98),
            new Point(500, 92),
            new Point(700, 67),
            new Point(900, 27),
            new Point(1000, 0)
        };
        private Point[] secondGrafDown =
        {
            new Point(0, 0),
            new Point(25, -20),
            new Point(50, -25),
            new Point(100, -28),
            new Point(150, -29),
            new Point(200, -27),
            new Point(300, -23),
            new Point(400, -18),
            new Point(500, -14),
            new Point(700, -7),
            new Point(900, -2),
            new Point(1000, 0)
        };
        private Point[] thirdGrafUp =
        {
            new Point(0, 0),
            new Point(25, 20),
            new Point(50, 30),
            new Point(100, 45),
            new Point(150, 60),
            new Point(200, 73),
            new Point(300, 80),
            new Point(400, 70),
            new Point(500, 60),
            new Point(700, 40),
            new Point(900, 15),
            new Point(1000, 0)
        };
        private Point[] thirdGrafDown =
        {
            new Point(0, 0),
            new Point(25, -10),
            new Point(50, -15),
            new Point(100, -25),
            new Point(150, -27),
            new Point(200, -30),
            new Point(300, -24),
            new Point(400, -18),
            new Point(500, -14),
            new Point(700, -8),
            new Point(900, -4),
            new Point(1000, 0)
        };
        private Point[] customGrafUp = 
        {
            new Point(0, 0),
            new Point(20, 48),
            new Point(50, 78),
            new Point(100, 104),
            new Point(150, 117),
            new Point(200, 122),
            new Point(300, 119),
            new Point(400, 109),
            new Point(500, 94),
            new Point(700, 57),
            new Point(900, 19),
            new Point(1000, 0)
        };
        private Point[] customGrafDown =
     {
            new Point(0, 0),
            new Point(20, -19),
            new Point(50, -26),
            new Point(100, -31),
            new Point(150, -32),
            new Point(200, -33),
            new Point(300, -33),
            new Point(400, -31),
            new Point(500, -27),
            new Point(700, -19),
            new Point(900, -6),
            new Point(1000, 0)
        };
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            pointSwitch.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           switch(selectedState)
            {
                case 0:
                    Draw(firstGrafUp, firstGrafDown);
                    maxThickness(firstGrafUp, firstGrafDown);
                    chordLength(firstGrafUp, firstGrafDown);
                    relativeThickness(firstGrafUp, firstGrafDown);
                    break;
                case 1:
                    Draw(secondGrafUp, secondGrafDown);
                    maxThickness(secondGrafUp, secondGrafDown);
                    chordLength(secondGrafUp, secondGrafDown);
                    relativeThickness(secondGrafUp, secondGrafDown);
                    break;
                case 2:
                    Draw(thirdGrafUp, thirdGrafDown);
                    maxThickness(thirdGrafUp, thirdGrafDown);
                    chordLength(thirdGrafUp, thirdGrafDown);
                    relativeThickness(thirdGrafUp, thirdGrafDown);
                    break;
                case 3:
                    Draw(customGrafUp, customGrafDown);
                    maxThickness(customGrafUp, customGrafDown);
                    chordLength(customGrafUp, customGrafDown);
                    relativeThickness(customGrafUp, customGrafDown);
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedState = comboBox1.SelectedIndex;
            if(selectedState==3)
            {
                resetButton.Visible = true;
                pointTextBox.Visible = true;
                pointSwitch.Visible = true;
                xTextBox.Visible = true;
                xValue.Visible = true;
                yButtomTexBox.Visible = true;
                yButtomValue.Visible = true;
                yTopTextBox.Visible = true;
                yTopValue.Visible = true;
            }
            else
            {
                resetButton.Visible = false;
                pointTextBox.Visible = false;
                pointSwitch.Visible = false;
                xTextBox.Visible = false;
                xValue.Visible = false;
                yButtomTexBox.Visible = false;
                yButtomValue.Visible = false;
                yTopTextBox.Visible = false;
                yTopValue.Visible = false;
            }
        }

        private void pointSwitch_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedPoint = pointSwitch.SelectedIndex;
            xValue.Text = customGrafDown[selectedPoint].X.ToString();
            yButtomValue.Text = customGrafDown[selectedPoint].Y.ToString();
            yTopValue.Text = customGrafUp[selectedPoint].Y.ToString();    
        }

        private void xValue_TextChanged(object sender, EventArgs e)
        {
            int customX;
            if(int.TryParse(xValue.Text,out customX))
            {
                customGrafDown[selectedPoint].X = customX;
                customGrafUp[selectedPoint].X = customX;
            }
            else
            {
                xValue.Text = customGrafDown[selectedPoint].X.ToString();
            }
        }

        private void yTopValue_TextChanged(object sender, EventArgs e)
        {
            int customYTop;
            if (int.TryParse(yTopValue.Text, out customYTop))
            {
                customGrafUp[selectedPoint].Y = customYTop;
            }
            else
            {
                yTopValue.Text = customGrafUp[selectedPoint].Y.ToString();
            }
        }
        private void yButtomValue_TextChanged(object sender, EventArgs e)
        {
            int customYButtom;
            if (int.TryParse(yButtomValue.Text, out customYButtom))
            {
                customGrafDown[selectedPoint].Y = customYButtom;
            }
            else
            {
                yButtomValue.Text = customGrafDown[selectedPoint].Y.ToString();
            }
        }

        private void Draw(Point[] up,Point[] down)
        {
            Graphics graphics = grafWind.CreateGraphics();
            graphics.Clear(Color.White);
            graphics.TranslateTransform(0,grafWind.ClientSize.Height/2);
            Pen pen = new Pen(Color.Black, 3f);
            graphics.ScaleTransform(0.6f, -0.6f);
            graphics.DrawLines(pen, up);
            graphics.DrawLines(pen, down);
        }
        private void resetButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < customGrafDown.Length; i++)
            {
                customGrafDown[i] = firstGrafDown[i];
                customGrafUp[i] = firstGrafUp[i];
            }
            xValue.Text = customGrafDown[selectedPoint].X.ToString();
            yTopValue.Text = customGrafUp[selectedPoint].Y.ToString();
            yButtomValue.Text = customGrafDown[selectedPoint].Y.ToString();
            Draw(customGrafUp, customGrafDown);
            maxThickness(customGrafUp, customGrafDown);
            chordLength(customGrafUp, customGrafDown);
            relativeThickness(customGrafUp, customGrafDown);
        }
        private void maxThickness(Point[] up, Point[] down)
        {
            Cmax.Visible=true;
            int max = 0;
            if (up.Length == down.Length)
            {
                for (int i = 0; i < up.Length; i++)
                {
                    if (up[i].Y - down[i].Y > max)
                        max = up[i].Y - down[i].Y;
                }
                cmax = max/10f;
                Cmax.Text = "Cmax = " + cmax.ToString("0.0");
            }
            else
                Cmax.Text = "error";
        }

        private void chordLength(Point[] up, Point[] down)
        {
            b.Visible = true;
            if (up.Length == down.Length)
            {
                chord = (up[up.Length - 1].X - up[0].X)/10;
                b.Text = "b = " + chord.ToString();
            }
            else
                b.Text = "error";
        }

        private void relativeThickness(Point[] up, Point[] down)
        {
            Xcmax.Visible = true;
            if (up.Length == down.Length)
            {
                Xcmax.Text = "Xcmax = " + ((cmax*100)/chord).ToString("0.0") + "%";
            }
            else
                Xcmax.Text = "error";
        }
    }
}
