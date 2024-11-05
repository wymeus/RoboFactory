namespace RoboFactory
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private async void btnGenerate_Click(object sender, EventArgs e)
        {
            // Disable button and change its style
            btnGenerate.Text = "Generating...";
            btnGenerate.BackColor = Color.Gainsboro;
            btnGenerate.FlatAppearance.BorderColor = Color.Silver;
            btnGenerate.Enabled = false;
            // Create new robot
            var robot = await Robot.GenerateAsync();
            // Update elements
            lbName.Text = robot.Name;
            picAvatar.Image = robot.Avatar;
            lbSubtitle.Text = "Generated: " + robot.GeneratedAt.ToString("yyyy-MM-dd HH:mm:ss");
            // Enable the button and revert style back
            btnGenerate.Text = "Generate!";
            btnGenerate.BackColor = Color.SkyBlue;
            btnGenerate.FlatAppearance.BorderColor = Color.SteelBlue;
            btnGenerate.Enabled = true;
        }
    }
}
