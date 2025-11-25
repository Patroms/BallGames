namespace CatchMe2WinFormsApp
{
    partial class MainForm
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
            startButton = new Button();
            clearButton = new Button();
            countBallLabel = new Label();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.Location = new Point(713, 12);
            startButton.Name = "startButton";
            startButton.Size = new Size(75, 23);
            startButton.TabIndex = 0;
            startButton.Text = "Создать";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(713, 41);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 1;
            clearButton.Text = "Очистить";
            clearButton.UseVisualStyleBackColor = true;
            // 
            // countBallLabel
            // 
            countBallLabel.AutoSize = true;
            countBallLabel.Location = new Point(661, 15);
            countBallLabel.Name = "countBallLabel";
            countBallLabel.Size = new Size(13, 15);
            countBallLabel.TabIndex = 2;
            countBallLabel.Text = "0";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(countBallLabel);
            Controls.Add(clearButton);
            Controls.Add(startButton);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            MouseDown += MainForm_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startButton;
        private Button clearButton;
        private Label countBallLabel;
    }
}
