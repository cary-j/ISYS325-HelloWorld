namespace WinFormsApp3
{
    public partial class MainForm : Form
    {
        private const string HElLO_MSG = "Hello world!";
        public MainForm()
        {
            InitializeComponent();
        }

        private void pushMeButton_Click(object sender, EventArgs e)
        {
           HelloWordLabel.ForeColor = Color.Red;
           HelloWordLabel.Text = HElLO_MSG;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            HelloWordLabel.Text = "";
        }
    }
}
