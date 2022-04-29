namespace remindersapp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reminderbox6 = new System.Windows.Forms.Panel();
            this.reminderbox4 = new System.Windows.Forms.Panel();
            this.reminderbox5 = new System.Windows.Forms.Panel();
            this.reminderbox3 = new System.Windows.Forms.Panel();
            this.reminderbox2 = new System.Windows.Forms.Panel();
            this.reminderbox1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.reminderbox1title = new System.Windows.Forms.Label();
            this.reminderbox1desc = new System.Windows.Forms.Label();
            this.reminderbox2desc = new System.Windows.Forms.Label();
            this.reminderbox2title = new System.Windows.Forms.Label();
            this.reminderbox3desc = new System.Windows.Forms.Label();
            this.reminderbox3title = new System.Windows.Forms.Label();
            this.reminderbox4desc = new System.Windows.Forms.Label();
            this.reminderbox4title = new System.Windows.Forms.Label();
            this.reminderbox5desc = new System.Windows.Forms.Label();
            this.reminderbox5title = new System.Windows.Forms.Label();
            this.reminderbox6desc = new System.Windows.Forms.Label();
            this.reminderbox6title = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.reminderbox6.SuspendLayout();
            this.reminderbox4.SuspendLayout();
            this.reminderbox5.SuspendLayout();
            this.reminderbox3.SuspendLayout();
            this.reminderbox2.SuspendLayout();
            this.reminderbox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1375, 53);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::remindersapp.Properties.Resources.linenone;
            this.pictureBox2.Location = new System.Drawing.Point(1269, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 53);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::remindersapp.Properties.Resources.closenone;
            this.pictureBox1.Location = new System.Drawing.Point(1322, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 53);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "REMINDERS";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::remindersapp.Properties.Resources.addnone;
            this.pictureBox3.Location = new System.Drawing.Point(1250, 668);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 100);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseEnter += new System.EventHandler(this.pictureBox3_MouseEnter);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.reminderbox6);
            this.panel2.Controls.Add(this.reminderbox4);
            this.panel2.Controls.Add(this.reminderbox5);
            this.panel2.Controls.Add(this.reminderbox3);
            this.panel2.Controls.Add(this.reminderbox2);
            this.panel2.Controls.Add(this.reminderbox1);
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1225, 740);
            this.panel2.TabIndex = 4;
            // 
            // reminderbox6
            // 
            this.reminderbox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.reminderbox6.Controls.Add(this.reminderbox6desc);
            this.reminderbox6.Controls.Add(this.reminderbox6title);
            this.reminderbox6.Location = new System.Drawing.Point(825, 250);
            this.reminderbox6.Name = "reminderbox6";
            this.reminderbox6.Size = new System.Drawing.Size(375, 200);
            this.reminderbox6.TabIndex = 4;
            this.reminderbox6.Visible = false;
            // 
            // reminderbox4
            // 
            this.reminderbox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.reminderbox4.Controls.Add(this.reminderbox4desc);
            this.reminderbox4.Controls.Add(this.reminderbox4title);
            this.reminderbox4.Location = new System.Drawing.Point(25, 250);
            this.reminderbox4.Name = "reminderbox4";
            this.reminderbox4.Size = new System.Drawing.Size(375, 200);
            this.reminderbox4.TabIndex = 1;
            this.reminderbox4.Visible = false;
            // 
            // reminderbox5
            // 
            this.reminderbox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.reminderbox5.Controls.Add(this.reminderbox5desc);
            this.reminderbox5.Controls.Add(this.reminderbox5title);
            this.reminderbox5.Location = new System.Drawing.Point(425, 250);
            this.reminderbox5.Name = "reminderbox5";
            this.reminderbox5.Size = new System.Drawing.Size(375, 200);
            this.reminderbox5.TabIndex = 3;
            this.reminderbox5.Visible = false;
            // 
            // reminderbox3
            // 
            this.reminderbox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.reminderbox3.Controls.Add(this.reminderbox3desc);
            this.reminderbox3.Controls.Add(this.reminderbox3title);
            this.reminderbox3.Location = new System.Drawing.Point(825, 25);
            this.reminderbox3.Name = "reminderbox3";
            this.reminderbox3.Size = new System.Drawing.Size(375, 200);
            this.reminderbox3.TabIndex = 2;
            this.reminderbox3.Visible = false;
            // 
            // reminderbox2
            // 
            this.reminderbox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.reminderbox2.Controls.Add(this.reminderbox2desc);
            this.reminderbox2.Controls.Add(this.reminderbox2title);
            this.reminderbox2.Location = new System.Drawing.Point(425, 25);
            this.reminderbox2.Name = "reminderbox2";
            this.reminderbox2.Size = new System.Drawing.Size(375, 200);
            this.reminderbox2.TabIndex = 1;
            this.reminderbox2.Visible = false;
            // 
            // reminderbox1
            // 
            this.reminderbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.reminderbox1.Controls.Add(this.reminderbox1desc);
            this.reminderbox1.Controls.Add(this.reminderbox1title);
            this.reminderbox1.Location = new System.Drawing.Point(25, 25);
            this.reminderbox1.Name = "reminderbox1";
            this.reminderbox1.Size = new System.Drawing.Size(375, 200);
            this.reminderbox1.TabIndex = 0;
            this.reminderbox1.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(341, 231);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(700, 276);
            this.panel3.TabIndex = 0;
            this.panel3.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Gray;
            this.textBox2.Location = new System.Drawing.Point(24, 104);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(657, 82);
            this.textBox2.TabIndex = 3;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "Enter your description here...";
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Gray;
            this.textBox1.Location = new System.Drawing.Point(24, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(657, 25);
            this.textBox1.TabIndex = 1;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Enter your title here...";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Title";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panel4.Controls.Add(this.label5);
            this.panel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel4.Location = new System.Drawing.Point(263, 203);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(221, 50);
            this.panel4.TabIndex = 10;
            this.panel4.Click += new System.EventHandler(this.panel4_Click);
            this.panel4.MouseEnter += new System.EventHandler(this.panel4_MouseEnter);
            this.panel4.MouseLeave += new System.EventHandler(this.panel4_MouseLeave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panel5.Controls.Add(this.label4);
            this.panel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel5.Location = new System.Drawing.Point(24, 203);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(221, 50);
            this.panel5.TabIndex = 9;
            this.panel5.Click += new System.EventHandler(this.panel5_Click);
            this.panel5.MouseEnter += new System.EventHandler(this.panel5_MouseEnter);
            this.panel5.MouseLeave += new System.EventHandler(this.panel5_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(94, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "OK";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            this.label4.MouseEnter += new System.EventHandler(this.label4_MouseEnter);
            this.label4.MouseLeave += new System.EventHandler(this.label4_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(79, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "CANCEL";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            this.label5.MouseEnter += new System.EventHandler(this.label5_MouseEnter);
            this.label5.MouseLeave += new System.EventHandler(this.label5_MouseLeave);
            // 
            // reminderbox1title
            // 
            this.reminderbox1title.AutoSize = true;
            this.reminderbox1title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reminderbox1title.ForeColor = System.Drawing.Color.White;
            this.reminderbox1title.Location = new System.Drawing.Point(20, 20);
            this.reminderbox1title.Name = "reminderbox1title";
            this.reminderbox1title.Size = new System.Drawing.Size(0, 21);
            this.reminderbox1title.TabIndex = 11;
            // 
            // reminderbox1desc
            // 
            this.reminderbox1desc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reminderbox1desc.ForeColor = System.Drawing.Color.White;
            this.reminderbox1desc.Location = new System.Drawing.Point(20, 60);
            this.reminderbox1desc.Name = "reminderbox1desc";
            this.reminderbox1desc.Size = new System.Drawing.Size(328, 115);
            this.reminderbox1desc.TabIndex = 11;
            // 
            // reminderbox2desc
            // 
            this.reminderbox2desc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reminderbox2desc.ForeColor = System.Drawing.Color.White;
            this.reminderbox2desc.Location = new System.Drawing.Point(21, 60);
            this.reminderbox2desc.Name = "reminderbox2desc";
            this.reminderbox2desc.Size = new System.Drawing.Size(328, 115);
            this.reminderbox2desc.TabIndex = 12;
            // 
            // reminderbox2title
            // 
            this.reminderbox2title.AutoSize = true;
            this.reminderbox2title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reminderbox2title.ForeColor = System.Drawing.Color.White;
            this.reminderbox2title.Location = new System.Drawing.Point(21, 20);
            this.reminderbox2title.Name = "reminderbox2title";
            this.reminderbox2title.Size = new System.Drawing.Size(0, 21);
            this.reminderbox2title.TabIndex = 13;
            // 
            // reminderbox3desc
            // 
            this.reminderbox3desc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reminderbox3desc.ForeColor = System.Drawing.Color.White;
            this.reminderbox3desc.Location = new System.Drawing.Point(27, 60);
            this.reminderbox3desc.Name = "reminderbox3desc";
            this.reminderbox3desc.Size = new System.Drawing.Size(328, 115);
            this.reminderbox3desc.TabIndex = 14;
            // 
            // reminderbox3title
            // 
            this.reminderbox3title.AutoSize = true;
            this.reminderbox3title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reminderbox3title.ForeColor = System.Drawing.Color.White;
            this.reminderbox3title.Location = new System.Drawing.Point(27, 20);
            this.reminderbox3title.Name = "reminderbox3title";
            this.reminderbox3title.Size = new System.Drawing.Size(0, 21);
            this.reminderbox3title.TabIndex = 15;
            // 
            // reminderbox4desc
            // 
            this.reminderbox4desc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reminderbox4desc.ForeColor = System.Drawing.Color.White;
            this.reminderbox4desc.Location = new System.Drawing.Point(20, 58);
            this.reminderbox4desc.Name = "reminderbox4desc";
            this.reminderbox4desc.Size = new System.Drawing.Size(328, 115);
            this.reminderbox4desc.TabIndex = 16;
            // 
            // reminderbox4title
            // 
            this.reminderbox4title.AutoSize = true;
            this.reminderbox4title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reminderbox4title.ForeColor = System.Drawing.Color.White;
            this.reminderbox4title.Location = new System.Drawing.Point(20, 18);
            this.reminderbox4title.Name = "reminderbox4title";
            this.reminderbox4title.Size = new System.Drawing.Size(0, 21);
            this.reminderbox4title.TabIndex = 17;
            // 
            // reminderbox5desc
            // 
            this.reminderbox5desc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reminderbox5desc.ForeColor = System.Drawing.Color.White;
            this.reminderbox5desc.Location = new System.Drawing.Point(23, 58);
            this.reminderbox5desc.Name = "reminderbox5desc";
            this.reminderbox5desc.Size = new System.Drawing.Size(328, 115);
            this.reminderbox5desc.TabIndex = 18;
            // 
            // reminderbox5title
            // 
            this.reminderbox5title.AutoSize = true;
            this.reminderbox5title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reminderbox5title.ForeColor = System.Drawing.Color.White;
            this.reminderbox5title.Location = new System.Drawing.Point(23, 18);
            this.reminderbox5title.Name = "reminderbox5title";
            this.reminderbox5title.Size = new System.Drawing.Size(0, 21);
            this.reminderbox5title.TabIndex = 19;
            // 
            // reminderbox6desc
            // 
            this.reminderbox6desc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reminderbox6desc.ForeColor = System.Drawing.Color.White;
            this.reminderbox6desc.Location = new System.Drawing.Point(27, 58);
            this.reminderbox6desc.Name = "reminderbox6desc";
            this.reminderbox6desc.Size = new System.Drawing.Size(328, 115);
            this.reminderbox6desc.TabIndex = 20;
            // 
            // reminderbox6title
            // 
            this.reminderbox6title.AutoSize = true;
            this.reminderbox6title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reminderbox6title.ForeColor = System.Drawing.Color.White;
            this.reminderbox6title.Location = new System.Drawing.Point(27, 18);
            this.reminderbox6title.Name = "reminderbox6title";
            this.reminderbox6title.Size = new System.Drawing.Size(0, 21);
            this.reminderbox6title.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1375, 793);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0D;
            this.Text = "1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.reminderbox6.ResumeLayout(false);
            this.reminderbox6.PerformLayout();
            this.reminderbox4.ResumeLayout(false);
            this.reminderbox4.PerformLayout();
            this.reminderbox5.ResumeLayout(false);
            this.reminderbox5.PerformLayout();
            this.reminderbox3.ResumeLayout(false);
            this.reminderbox3.PerformLayout();
            this.reminderbox2.ResumeLayout(false);
            this.reminderbox2.PerformLayout();
            this.reminderbox1.ResumeLayout(false);
            this.reminderbox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel reminderbox1;
        private System.Windows.Forms.Panel reminderbox3;
        private System.Windows.Forms.Panel reminderbox2;
        private System.Windows.Forms.Panel reminderbox6;
        private System.Windows.Forms.Panel reminderbox4;
        private System.Windows.Forms.Panel reminderbox5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label reminderbox1desc;
        private System.Windows.Forms.Label reminderbox1title;
        private System.Windows.Forms.Label reminderbox6desc;
        private System.Windows.Forms.Label reminderbox6title;
        private System.Windows.Forms.Label reminderbox4desc;
        private System.Windows.Forms.Label reminderbox4title;
        private System.Windows.Forms.Label reminderbox5desc;
        private System.Windows.Forms.Label reminderbox5title;
        private System.Windows.Forms.Label reminderbox3desc;
        private System.Windows.Forms.Label reminderbox3title;
        private System.Windows.Forms.Label reminderbox2desc;
        private System.Windows.Forms.Label reminderbox2title;
    }
}

