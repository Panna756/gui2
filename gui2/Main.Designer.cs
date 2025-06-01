namespace gui2
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            pictureBox1 = new PictureBox();
            btnEnter = new Button();
            panel1 = new Panel();
            testBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-3, 115);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(861, 500);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnEnter
            // 
            btnEnter.BackColor = Color.White;
            btnEnter.FlatStyle = FlatStyle.Popup;
            btnEnter.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnter.ForeColor = Color.Black;
            btnEnter.Location = new Point(719, 553);
            btnEnter.Margin = new Padding(4, 5, 4, 5);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(121, 50);
            btnEnter.TabIndex = 1;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = false;
            btnEnter.Click += btnEnter_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(-1, 613);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(860, 137);
            panel1.TabIndex = 2;
            // 
            // testBtn
            // 
            testBtn.BackColor = Color.White;
            testBtn.FlatStyle = FlatStyle.Popup;
            testBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            testBtn.ForeColor = Color.Black;
            testBtn.Location = new Point(719, 484);
            testBtn.Margin = new Padding(4, 5, 4, 5);
            testBtn.Name = "testBtn";
            testBtn.Size = new Size(121, 50);
            testBtn.TabIndex = 3;
            testBtn.Text = "Test mode";
            testBtn.UseVisualStyleBackColor = false;
            testBtn.Click += testBtn_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(857, 750);
            Controls.Add(testBtn);
            Controls.Add(btnEnter);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnEnter;
        private Panel panel1;
        private Button testBtn;
    }
}
