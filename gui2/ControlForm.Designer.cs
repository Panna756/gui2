namespace gui2
{
    partial class ControlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlForm));
            panel1 = new Panel();
            rollLabel = new Label();
            pitchLabel = new Label();
            middleBtn = new Button();
            readyBtn = new Button();
            stopBtn = new Button();
            startBtn = new Button();
            panel2 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(rollLabel);
            panel1.Controls.Add(pitchLabel);
            panel1.Controls.Add(middleBtn);
            panel1.Controls.Add(readyBtn);
            panel1.Controls.Add(stopBtn);
            panel1.Controls.Add(startBtn);
            panel1.Location = new Point(84, 73);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(669, 705);
            panel1.TabIndex = 0;
            // 
            // rollLabel
            // 
            rollLabel.AutoSize = true;
            rollLabel.Location = new Point(498, 232);
            rollLabel.Name = "rollLabel";
            rollLabel.Size = new Size(37, 25);
            rollLabel.TabIndex = 5;
            rollLabel.Text = "roll";
            // 
            // pitchLabel
            // 
            pitchLabel.AutoSize = true;
            pitchLabel.Location = new Point(498, 182);
            pitchLabel.Name = "pitchLabel";
            pitchLabel.Size = new Size(51, 25);
            pitchLabel.TabIndex = 4;
            pitchLabel.Text = "pitch";
            // 
            // middleBtn
            // 
            middleBtn.Location = new Point(189, 545);
            middleBtn.Name = "middleBtn";
            middleBtn.Size = new Size(112, 34);
            middleBtn.TabIndex = 3;
            middleBtn.Text = "Middle";
            middleBtn.UseVisualStyleBackColor = true;
            middleBtn.Click += middleBtn_Click;
            // 
            // readyBtn
            // 
            readyBtn.Location = new Point(189, 462);
            readyBtn.Name = "readyBtn";
            readyBtn.Size = new Size(112, 34);
            readyBtn.TabIndex = 2;
            readyBtn.Text = "Ready";
            readyBtn.UseVisualStyleBackColor = true;
            readyBtn.Click += readyBtn_Click;
            // 
            // stopBtn
            // 
            stopBtn.Location = new Point(189, 380);
            stopBtn.Name = "stopBtn";
            stopBtn.Size = new Size(112, 34);
            stopBtn.TabIndex = 1;
            stopBtn.Text = "Stop";
            stopBtn.UseVisualStyleBackColor = true;
            stopBtn.Click += stopBtn_Click;
            // 
            // startBtn
            // 
            startBtn.Location = new Point(189, 295);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(112, 34);
            startBtn.TabIndex = 0;
            startBtn.Text = "Start";
            startBtn.UseVisualStyleBackColor = true;
            startBtn.Click += startBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.IndianRed;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(84, 73);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(97, 705);
            panel2.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 32.25F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(19, 590);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(70, 87);
            label7.TabIndex = 6;
            label7.Text = "L";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 32.25F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(13, 492);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(86, 87);
            label6.TabIndex = 5;
            label6.Text = "O";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 32.25F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(13, 393);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(79, 87);
            label5.TabIndex = 4;
            label5.Text = "R";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 32.25F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(13, 295);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(75, 87);
            label4.TabIndex = 3;
            label4.Text = "T";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 32.25F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(13, 197);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(88, 87);
            label3.TabIndex = 2;
            label3.Text = "N";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 32.25F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(13, 98);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 87);
            label2.TabIndex = 1;
            label2.Text = "O";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(13, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 87);
            label1.TabIndex = 0;
            label1.Text = "C";
            // 
            // ControlForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1906, 875);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "ControlForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Control";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button readyBtn;
        private Button stopBtn;
        private Button startBtn;
        private Button middleBtn;
        private Label rollLabel;
        private Label pitchLabel;
    }
}