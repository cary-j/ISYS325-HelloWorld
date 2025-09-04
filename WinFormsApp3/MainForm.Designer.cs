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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pushMeButton
            // 
            pushMeButton.Location = new Point(268, 65);
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
            HelloWordLabel.Location = new Point(316, 257);
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
            // pictureBox1
            // 
            pictureBox1.Image = ISYS325_HelloWorld.Properties.Resources.Blackcar;
            pictureBox1.Location = new Point(246, 315);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(297, 88);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(closeButton);
            Controls.Add(HelloWordLabel);
            Controls.Add(pushMeButton);
            Name = "MainForm";
            Text = "My Application";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button pushMeButton;
        private Label HelloWordLabel;
        private Button closeButton;
        private PictureBox pictureBox1;
    }
}
