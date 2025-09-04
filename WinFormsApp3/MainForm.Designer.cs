namespace WinFormsApp3
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
            pushMeButton = new Button();
            HelloWordLabel = new Label();
            closeButton = new Button();
            carPicutureBox = new PictureBox();
            testTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)carPicutureBox).BeginInit();
            SuspendLayout();
            // 
            // pushMeButton
            // 
            pushMeButton.Location = new Point(415, 12);
            pushMeButton.Name = "pushMeButton";
            pushMeButton.Size = new Size(237, 119);
            pushMeButton.TabIndex = 0;
            pushMeButton.Text = "&Push me!";
            pushMeButton.UseVisualStyleBackColor = true;
            pushMeButton.Click += pushMeButton_Click;
            // 
            // HelloWordLabel
            // 
            HelloWordLabel.AutoSize = true;
            HelloWordLabel.Font = new Font("Meiryo UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HelloWordLabel.Location = new Point(466, 160);
            HelloWordLabel.Name = "HelloWordLabel";
            HelloWordLabel.Size = new Size(127, 26);
            HelloWordLabel.TabIndex = 1;
            HelloWordLabel.Text = "HelloWord";
            // 
            // closeButton
            // 
            closeButton.ForeColor = Color.Red;
            closeButton.Location = new Point(636, 363);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(131, 40);
            closeButton.TabIndex = 2;
            closeButton.Text = "&Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // carPicutureBox
            // 
            carPicutureBox.Image = ISYS325_HelloWorld.Properties.Resources.Blackcar;
            carPicutureBox.Location = new Point(392, 223);
            carPicutureBox.Name = "carPicutureBox";
            carPicutureBox.Size = new Size(297, 123);
            carPicutureBox.TabIndex = 3;
            carPicutureBox.TabStop = false;
            carPicutureBox.Click += carPicutureBox_Click;
            // 
            // testTextBox
            // 
            testTextBox.Font = new Font("SimHei", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            testTextBox.Location = new Point(37, 43);
            testTextBox.Name = "testTextBox";
            testTextBox.Size = new Size(257, 55);
            testTextBox.TabIndex = 4;
            testTextBox.TextChanged += testTextBox_TextChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(testTextBox);
            Controls.Add(carPicutureBox);
            Controls.Add(closeButton);
            Controls.Add(HelloWordLabel);
            Controls.Add(pushMeButton);
            Name = "MainForm";
            Text = "My Application";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)carPicutureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button pushMeButton;
        private Label HelloWordLabel;
        private Button closeButton;
        private PictureBox carPicutureBox;
        public TextBox testTextBox;
    }
}
