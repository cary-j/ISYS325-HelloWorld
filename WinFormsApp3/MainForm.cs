namespace WinFormsApp3
{
    public partial class MainForm : Form
    {
        private const string HElLO_MSG = "Hello world!";
        private const string CAR_MSG = "Vroom Vroom!";

        public MainForm()
        {
            InitializeComponent();
        }

        private void pushMeButton_Click(object sender, EventArgs e)
        {
           HelloWordLabel.ForeColor = Color.Red;
           HelloWordLabel.Text = HElLO_MSG;
           carPicutureBox.Visible = !carPicutureBox.Visible;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void carPicutureBox_Click(object sender, EventArgs e)
        {
            HelloWordLabel.Text = CAR_MSG;
            carPicutureBox.Visible = !carPicutureBox.Visible;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            HelloWordLabel.Text = "";
        }
    }
}
