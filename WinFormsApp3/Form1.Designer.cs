namespace WinFormsApp3
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
            pushMeButton = new Button();
            SuspendLayout();
            // 
            // pushMeButton
            // 
            pushMeButton.Location = new Point(306, 127);
            pushMeButton.Name = "pushMeButton";
            pushMeButton.Size = new Size(237, 119);
            pushMeButton.TabIndex = 0;
            pushMeButton.Text = "Push me!";
            pushMeButton.UseVisualStyleBackColor = true;
            pushMeButton.Click += pushMeButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pushMeButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button pushMeButton;
    }
}
