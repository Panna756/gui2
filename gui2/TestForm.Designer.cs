namespace gui2
{
    partial class TestForm
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
            startBtn = new Button();
            readyBtn = new Button();
            stopBtn = new Button();
            backBtn = new Button();
            pitchTrackBar = new TrackBar();
            rollTrackBar = new TrackBar();
            pitchLabel = new Label();
            rollLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pitchTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rollTrackBar).BeginInit();
            SuspendLayout();
            // 
            // startBtn
            // 
            startBtn.Location = new Point(107, 359);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(112, 34);
            startBtn.TabIndex = 0;
            startBtn.Text = "Start";
            startBtn.UseVisualStyleBackColor = true;
            startBtn.Click += startBtn_Click;
            // 
            // readyBtn
            // 
            readyBtn.Location = new Point(254, 359);
            readyBtn.Name = "readyBtn";
            readyBtn.Size = new Size(112, 34);
            readyBtn.TabIndex = 1;
            readyBtn.Text = "Ready";
            readyBtn.UseVisualStyleBackColor = true;
            readyBtn.Click += readyBtn_Click;
            // 
            // stopBtn
            // 
            stopBtn.Location = new Point(397, 359);
            stopBtn.Name = "stopBtn";
            stopBtn.Size = new Size(112, 34);
            stopBtn.TabIndex = 2;
            stopBtn.Text = "Stop";
            stopBtn.UseVisualStyleBackColor = true;
            stopBtn.Click += stopBtn_Click;
            // 
            // backBtn
            // 
            backBtn.Location = new Point(12, 12);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(112, 34);
            backBtn.TabIndex = 3;
            backBtn.Text = "<Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // pitchTrackBar
            // 
            pitchTrackBar.Location = new Point(107, 52);
            pitchTrackBar.Name = "pitchTrackBar";
            pitchTrackBar.Size = new Size(298, 69);
            pitchTrackBar.TabIndex = 4;
            this.pitchTrackBar.Scroll += new System.EventHandler(this.pitchTrackBar_Scroll);
            // 
            // rollTrackBar
            // 
            rollTrackBar.Location = new Point(107, 136);
            rollTrackBar.Name = "rollTrackBar";
            rollTrackBar.Size = new Size(298, 69);
            rollTrackBar.TabIndex = 5;
            this.rollTrackBar.Scroll += new System.EventHandler(this.rollTrackBar_Scroll);
            // 
            // pitchLabel
            // 
            pitchLabel.AutoSize = true;
            pitchLabel.Location = new Point(450, 52);
            pitchLabel.Name = "pitchLabel";
            pitchLabel.Size = new Size(54, 25);
            pitchLabel.TabIndex = 6;
            pitchLabel.Text = "Pitch:";
            // 
            // rollLabel
            // 
            rollLabel.AutoSize = true;
            rollLabel.Location = new Point(450, 136);
            rollLabel.Name = "rollLabel";
            rollLabel.Size = new Size(45, 25);
            rollLabel.TabIndex = 7;
            rollLabel.Text = "Roll:";
            // 
            // TestForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rollLabel);
            Controls.Add(pitchLabel);
            Controls.Add(rollTrackBar);
            Controls.Add(pitchTrackBar);
            Controls.Add(backBtn);
            Controls.Add(stopBtn);
            Controls.Add(readyBtn);
            Controls.Add(startBtn);
            Name = "TestForm";
            Text = "TestForm";
            ((System.ComponentModel.ISupportInitialize)pitchTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)rollTrackBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startBtn;
        private Button readyBtn;
        private Button stopBtn;
        private Button backBtn;
        private TrackBar pitchTrackBar;
        private TrackBar rollTrackBar;
        private Label pitchLabel;
        private Label rollLabel;
    }
}