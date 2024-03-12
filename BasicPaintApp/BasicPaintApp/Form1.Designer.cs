namespace BasicPaintApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Cursor = Cursors.Cross;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(827, 532);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(542, 21);
            panel2.Name = "panel2";
            panel2.Size = new Size(234, 36);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Black;
            pictureBox6.Location = new Point(193, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(32, 29);
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox2_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Purple;
            pictureBox5.Location = new Point(155, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(32, 29);
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox2_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Lime;
            pictureBox4.Location = new Point(117, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 29);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.RoyalBlue;
            pictureBox3.Location = new Point(79, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 29);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Gold;
            pictureBox2.Location = new Point(41, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 29);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Red;
            pictureBox1.Location = new Point(3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 29);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 532);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
    }
}
