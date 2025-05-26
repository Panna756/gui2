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
            label2 = new Label();
            InvertRollCheckBox = new CheckBox();
            InvertPitchCheckBox = new CheckBox();
            rollLabel = new Label();
            pitchLabel = new Label();
            middleBtn = new Button();
            readyBtn = new Button();
            stopBtn = new Button();
            startBtn = new Button();
            panel2 = new Panel();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(InvertRollCheckBox);
            panel1.Controls.Add(InvertPitchCheckBox);
            panel1.Controls.Add(rollLabel);
            panel1.Controls.Add(pitchLabel);
            panel1.Controls.Add(middleBtn);
            panel1.Controls.Add(readyBtn);
            panel1.Controls.Add(stopBtn);
            panel1.Controls.Add(startBtn);
            panel1.Location = new Point(59, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(468, 423);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 108);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 8;
            label2.Text = "Settings";
            // 
            // InvertRollCheckBox
            // 
            InvertRollCheckBox.AutoSize = true;
            InvertRollCheckBox.Location = new Point(84, 157);
            InvertRollCheckBox.Name = "InvertRollCheckBox";
            InvertRollCheckBox.Size = new Size(108, 19);
            InvertRollCheckBox.TabIndex = 7;
            InvertRollCheckBox.Text = "Invert Roll (+/-)";
            InvertRollCheckBox.UseVisualStyleBackColor = true;
            // 
            // InvertPitchCheckBox
            // 
            InvertPitchCheckBox.AutoSize = true;
            InvertPitchCheckBox.Location = new Point(84, 108);
            InvertPitchCheckBox.Name = "InvertPitchCheckBox";
            InvertPitchCheckBox.Size = new Size(115, 19);
            InvertPitchCheckBox.TabIndex = 6;
            InvertPitchCheckBox.Text = "Invert Pitch (+/-)";
            InvertPitchCheckBox.UseVisualStyleBackColor = true;
            // 
            // rollLabel
            // 
            rollLabel.AutoSize = true;
            rollLabel.Location = new Point(84, 179);
            rollLabel.Margin = new Padding(2, 0, 2, 0);
            rollLabel.Name = "rollLabel";
            rollLabel.Size = new Size(92, 15);
            rollLabel.TabIndex = 5;
            rollLabel.Text = "Global Roll: N/A";
            // 
            // pitchLabel
            // 
            pitchLabel.AutoSize = true;
            pitchLabel.Location = new Point(84, 130);
            pitchLabel.Margin = new Padding(2, 0, 2, 0);
            pitchLabel.Name = "pitchLabel";
            pitchLabel.Size = new Size(99, 15);
            pitchLabel.TabIndex = 4;
            pitchLabel.Text = "Global Pitch: N/A";
            // 
            // middleBtn
            // 
            middleBtn.BackColor = Color.White;
            middleBtn.FlatAppearance.BorderColor = Color.LightGray;
            middleBtn.FlatStyle = FlatStyle.Flat;
            middleBtn.ForeColor = Color.Black;
            middleBtn.Location = new Point(269, 350);
            middleBtn.Margin = new Padding(2);
            middleBtn.Name = "middleBtn";
            middleBtn.Size = new Size(95, 45);
            middleBtn.TabIndex = 3;
            middleBtn.Text = "Middle";
            middleBtn.UseVisualStyleBackColor = false;
            middleBtn.Click += middleBtn_Click;
            // 
            // readyBtn
            // 
            readyBtn.BackColor = Color.White;
            readyBtn.Cursor = Cursors.Hand;
            readyBtn.FlatAppearance.BorderColor = Color.LightGray;
            readyBtn.FlatStyle = FlatStyle.Flat;
            readyBtn.ForeColor = Color.Black;
            readyBtn.Location = new Point(118, 344);
            readyBtn.Margin = new Padding(2);
            readyBtn.Name = "readyBtn";
            readyBtn.Size = new Size(95, 45);
            readyBtn.TabIndex = 2;
            readyBtn.Text = "Ready";
            readyBtn.UseVisualStyleBackColor = false;
            readyBtn.Click += readyBtn_Click;
            // 
            // stopBtn
            // 
            stopBtn.BackColor = Color.White;
            stopBtn.Cursor = Cursors.Hand;
            stopBtn.FlatAppearance.BorderColor = Color.LightGray;
            stopBtn.FlatStyle = FlatStyle.Flat;
            stopBtn.ForeColor = Color.Black;
            stopBtn.Location = new Point(269, 271);
            stopBtn.Margin = new Padding(2);
            stopBtn.Name = "stopBtn";
            stopBtn.Size = new Size(95, 45);
            stopBtn.TabIndex = 1;
            stopBtn.Text = "Stop";
            stopBtn.UseVisualStyleBackColor = false;
            stopBtn.Click += stopBtn_Click;
            // 
            // startBtn
            // 
            startBtn.BackColor = Color.White;
            startBtn.Cursor = Cursors.Hand;
            startBtn.FlatAppearance.BorderColor = Color.LightGray;
            startBtn.FlatStyle = FlatStyle.Flat;
            startBtn.ForeColor = Color.Black;
            startBtn.Location = new Point(118, 271);
            startBtn.Margin = new Padding(2);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(95, 45);
            startBtn.TabIndex = 0;
            startBtn.Text = "Start";
            startBtn.UseVisualStyleBackColor = false;
            startBtn.Click += startBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.IndianRed;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(59, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(468, 68);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 32.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(65, 5);
            label1.Name = "label1";
            label1.Size = new Size(335, 62);
            label1.TabIndex = 0;
            label1.Text = "CONTROL PANEL";
            // 
            // ControlForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1334, 525);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ControlForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Control";
            Load += ControlForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button readyBtn;
        private Button stopBtn;
        private Button startBtn;
        private Button middleBtn;
        private Label rollLabel;
        private Label pitchLabel;
        private CheckBox InvertRollCheckBox;
        private CheckBox InvertPitchCheckBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label2;
    }
}