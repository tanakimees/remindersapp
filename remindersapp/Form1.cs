using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace remindersapp
{
    public partial class Form1 : Form
    {

        //data
        string title = "";
        string description = "";
        int donereminders = 0;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // width of ellipse
           int nHeightEllipse // height of ellipse
       );

        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
            pictureBox3.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox3.Width, pictureBox3.Height, 100, 100));
            panel3.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width, panel3.Height, 30, 30));
            panel4.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel4.Width, panel4.Height, 30, 30));
            panel5.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel5.Width, panel5.Height, 30, 30));

            string fileName = @"C:\remindersapp\remindersData.txt";
            FileInfo fi = new FileInfo(fileName);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            foreach(Panel p in panel2.Controls.OfType<Panel>())
            {
                p.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, p.Width, p.Height, 30, 30));
            }
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.04;
            if(this.Opacity > 1)
            {
                timer1.Stop();
            }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.closeselected;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.closenone;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.04;
            if(this.Opacity == 0)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.lineselected;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.linenone;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.addselected;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.addnone;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            panel4.BackColor = Color.FromArgb(66, 66, 66);
        }

        private void panel5_MouseEnter(object sender, EventArgs e)
        {
            panel5.BackColor = Color.FromArgb(66, 66, 66);
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = Color.FromArgb(44, 44, 44);
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = Color.FromArgb(44, 44, 44);
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            panel5.BackColor = Color.FromArgb(66, 66, 66);
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = Color.FromArgb(44, 44, 44);
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            panel4.BackColor = Color.FromArgb(66, 66, 66);
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = Color.FromArgb(44, 44, 44);
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            cancelbutton();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            cancelbutton();
        }

        void cancelbutton()
        {
            title = "";
            description = "";
            textBox1.Text = "Enter your title here...";
            textBox2.Text = "Enter your description here...";
            panel3.Hide();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            okbutton();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            okbutton();
        }
        
        void okbutton()
        {
            donereminders += 1;
            foreach(Panel p in panel2.Controls.OfType<Panel>())
            {
                if(p.Name == "reminderbox" + donereminders.ToString())
                {
                    p.Visible = true;
                }
            }
            if(donereminders == 1)
            {
                reminderbox1title.Text = textBox1.Text;
                reminderbox1desc.Text = textBox2.Text;
            }
            if (donereminders == 2)
            {
                reminderbox2title.Text = textBox1.Text;
                reminderbox2desc.Text = textBox2.Text;
            }
            if (donereminders == 3)
            {
                reminderbox3title.Text = textBox1.Text;
                reminderbox3desc.Text = textBox2.Text;
            }
            if (donereminders == 4)
            {
                reminderbox4title.Text = textBox1.Text;
                reminderbox4desc.Text = textBox2.Text;
            }
            if (donereminders == 5)
            {
                reminderbox5title.Text = textBox1.Text;
                reminderbox5desc.Text = textBox2.Text;
            }
            if (donereminders == 6)
            {
                reminderbox6title.Text = textBox1.Text;
                reminderbox6desc.Text = textBox2.Text;
            }
            textBox1.Text = "";
            textBox2.Text = "";
            panel3.Hide();
        }
    }
}
