using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace DrawingLines {
    public partial class Form1 : Form {
        Pen myPen = new Pen(Color.Black);
        Graphics g = null;
        static int start_x, start_y;
        static int end_x, end_y;
        static int my_angle = 0;
        static int my_lenght = 0;
        static int my_increment = 0;
        static Hashtable lastValidTexts = new Hashtable();

        public Form1() {
            InitializeComponent();
            start_x = panel2.Width / 2; start_y = panel2.Height / 2;

        }

        private void btColor_Click(object sender, EventArgs e) {
            Random bGCol = new Random();
            panel2.BackColor = Color.FromArgb(bGCol.Next(255), bGCol.Next(255), bGCol.Next(255));
            panel2.Refresh();

        }

        private void btLineColor_Click(object sender, EventArgs e) {
            Random randomCol = new Random();
            myPen.Color = Color.FromArgb(randomCol.Next(255), randomCol.Next(255), randomCol.Next(255));

        }

        private void btLinCol_default_Click(object sender, EventArgs e) {
            myPen.Color = Color.Black;
        }

        private void btColor_default_Click(object sender, EventArgs e) {
            panel2.BackColor = Color.White;
        }

        private void txLines_TextChanged(object sender, EventArgs e) {
            TextBox tb = (TextBox)sender;
            validText(tb);
        }
        private void txLenght_TextChanged(object sender, EventArgs e) {
            TextBox tb = (TextBox)sender;
            validText(tb);
        }

        private void txAngle_TextChanged(object sender, EventArgs e) {
            TextBox tb = (TextBox)sender;
            validText(tb);
        }

        private void txIncrement_TextChanged(object sender, EventArgs e) {
            TextBox tb = (TextBox)sender;
            validText(tb);
        }
        private void panel2_Paint(object sender, PaintEventArgs e) {
            myPen.Width = 1;
            my_lenght = int.Parse(txLenght.Text);
            g = panel2.CreateGraphics();
            for (int i = 0; i < int.Parse(txLines.Text); i++)
                drawLine();

        }

        private void drawLine() {

            my_angle += int.Parse(txAngle.Text);
            my_lenght += int.Parse(txIncrement.Text);

            end_x = (int)(start_x + Math.Cos(my_angle * .017453292519) * my_lenght);
            end_y = (int)(start_y + Math.Sin(my_angle * .017453292519) * my_lenght);

            Point[] points = {
                new Point(start_x, start_y),
                new Point(end_x,end_y )
                };
            start_x = end_x;
            start_y = end_y;
            g.DrawLines(myPen, points);
        }
        private void btGo_Click(object sender, EventArgs e) {
            my_lenght = int.Parse(txLenght.Text);
            my_angle = int.Parse(txAngle.Text);
            my_increment = int.Parse(txIncrement.Text);
            start_x = panel2.Width / 2; start_y = panel2.Height / 2;
            panel2.Refresh();
        }

        private void validText(TextBox tx) {
            tx.Text = (tx.Text == "") ? "0" : tx.Text;

            if (int.TryParse(tx.Text, out int _)) {
                if (!lastValidTexts.ContainsKey(tx))
                    lastValidTexts.Add(tx, tx.Text);
                else
                    lastValidTexts[tx] = tx.Text;

            } else {
                if (lastValidTexts.ContainsKey(tx)) {
                    tx.Text = lastValidTexts[tx].ToString();
                    tx.SelectionStart = tx.Text.Length;
                }
            }
        }




    }
}

