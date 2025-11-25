namespace BillyardBallsWinFormsApp
{
    partial class BillyardForm
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
            leftLabel = new Label();
            topLabel = new Label();
            downLabel = new Label();
            rightLabel = new Label();
            rightLabel2 = new Label();
            downLabel2 = new Label();
            topLabel2 = new Label();
            leftLabel2 = new Label();
            SuspendLayout();
            // 
            // leftLabel
            // 
            leftLabel.AutoSize = true;
            leftLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            leftLabel.ForeColor = Color.Blue;
            leftLabel.Location = new Point(12, 205);
            leftLabel.Name = "leftLabel";
            leftLabel.Size = new Size(19, 21);
            leftLabel.TabIndex = 0;
            leftLabel.Text = "0";
            // 
            // topLabel
            // 
            topLabel.AutoSize = true;
            topLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            topLabel.ForeColor = Color.Blue;
            topLabel.Location = new Point(377, 9);
            topLabel.Name = "topLabel";
            topLabel.Size = new Size(19, 21);
            topLabel.TabIndex = 1;
            topLabel.Text = "0";
            // 
            // downLabel
            // 
            downLabel.AutoSize = true;
            downLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            downLabel.ForeColor = Color.Blue;
            downLabel.Location = new Point(377, 426);
            downLabel.Name = "downLabel";
            downLabel.Size = new Size(19, 21);
            downLabel.TabIndex = 2;
            downLabel.Text = "0";
            // 
            // rightLabel
            // 
            rightLabel.AutoSize = true;
            rightLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rightLabel.ForeColor = Color.Blue;
            rightLabel.Location = new Point(785, 191);
            rightLabel.Name = "rightLabel";
            rightLabel.Size = new Size(19, 21);
            rightLabel.TabIndex = 3;
            rightLabel.Text = "0";
            // 
            // rightLabel2
            // 
            rightLabel2.AutoSize = true;
            rightLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rightLabel2.ForeColor = Color.Red;
            rightLabel2.Location = new Point(785, 212);
            rightLabel2.Name = "rightLabel2";
            rightLabel2.Size = new Size(19, 21);
            rightLabel2.TabIndex = 7;
            rightLabel2.Text = "0";
            // 
            // downLabel2
            // 
            downLabel2.AutoSize = true;
            downLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            downLabel2.ForeColor = Color.Red;
            downLabel2.Location = new Point(402, 426);
            downLabel2.Name = "downLabel2";
            downLabel2.Size = new Size(19, 21);
            downLabel2.TabIndex = 6;
            downLabel2.Text = "0";
            // 
            // topLabel2
            // 
            topLabel2.AutoSize = true;
            topLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            topLabel2.ForeColor = Color.Red;
            topLabel2.Location = new Point(402, 9);
            topLabel2.Name = "topLabel2";
            topLabel2.Size = new Size(19, 21);
            topLabel2.TabIndex = 5;
            topLabel2.Text = "0";
            // 
            // leftLabel2
            // 
            leftLabel2.AutoSize = true;
            leftLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            leftLabel2.ForeColor = Color.Red;
            leftLabel2.Location = new Point(12, 226);
            leftLabel2.Name = "leftLabel2";
            leftLabel2.Size = new Size(19, 21);
            leftLabel2.TabIndex = 4;
            leftLabel2.Text = "0";
            // 
            // BillyardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rightLabel2);
            Controls.Add(downLabel2);
            Controls.Add(topLabel2);
            Controls.Add(leftLabel2);
            Controls.Add(rightLabel);
            Controls.Add(downLabel);
            Controls.Add(topLabel);
            Controls.Add(leftLabel);
            Name = "BillyardForm";
            Text = "Form1";
            Load += BilliardForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label leftLabel;
        private Label topLabel;
        private Label downLabel;
        private Label rightLabel;
        private Label rightLabel2;
        private Label downLabel2;
        private Label topLabel2;
        private Label leftLabel2;
    }
}
