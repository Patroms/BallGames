namespace SalutWinFormsApp
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
            salutButton = new Button();
            SuspendLayout();
            // 
            // salutButton
            // 
            salutButton.Location = new Point(713, 12);
            salutButton.Name = "salutButton";
            salutButton.Size = new Size(75, 23);
            salutButton.TabIndex = 0;
            salutButton.Text = "Салют";
            salutButton.UseVisualStyleBackColor = true;
            salutButton.Click += button1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(salutButton);
            Name = "MainForm";
            Text = "Салют";
            MouseDown += MainForm_MouseDown;
            ResumeLayout(false);
        }

        #endregion

        private Button salutButton;
    }
}
