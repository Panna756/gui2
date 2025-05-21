namespace gui2
{
    partial class Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control));
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(59, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(468, 423);
            panel1.TabIndex = 0;
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
            panel2.Location = new Point(59, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(68, 423);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(9, 0);
            label1.Name = "label1";
            label1.Size = new Size(52, 59);
            label1.TabIndex = 0;
            label1.Text = "C";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 32.25F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(9, 59);
            label2.Name = "label2";
            label2.Size = new Size(58, 59);
            label2.TabIndex = 1;
            label2.Text = "O";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 32.25F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(9, 118);
            label3.Name = "label3";
            label3.Size = new Size(59, 59);
            label3.TabIndex = 2;
            label3.Text = "N";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 32.25F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(9, 177);
            label4.Name = "label4";
            label4.Size = new Size(50, 59);
            label4.TabIndex = 3;
            label4.Text = "T";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 32.25F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(9, 236);
            label5.Name = "label5";
            label5.Size = new Size(53, 59);
            label5.TabIndex = 4;
            label5.Text = "R";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 32.25F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(9, 295);
            label6.Name = "label6";
            label6.Size = new Size(58, 59);
            label6.TabIndex = 5;
            label6.Text = "O";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 32.25F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(13, 354);
            label7.Name = "label7";
            label7.Size = new Size(47, 59);
            label7.TabIndex = 6;
            label7.Text = "L";
            // 
            // Control
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1334, 525);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Control";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Control";
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
    }
}