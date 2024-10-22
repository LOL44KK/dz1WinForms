namespace dz1WinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Button[,] buttons = new Button[6, 6];
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Size = new Size(30, 30);
                    buttons[i, j].Location = new Point(i * 35, j * 35);
                    Controls.Add(buttons[i, j]);
                }
            }
        }
    }
}
