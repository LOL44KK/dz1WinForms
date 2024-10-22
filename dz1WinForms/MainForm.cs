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
            int M = 6;
            int N = 6;

            Button[,] buttons = new Button[M, N];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Size = new Size(60, 60);
                    buttons[i, j].Location = new Point(i * 65, j * 65);
                    buttons[i, j].Name = (i + 1).ToString() + "|" +(j + 1).ToString();
                    buttons[i, j].Click += Button_Click;
                    buttons[i, j].BackColor = Color.FromKnownColor((KnownColor)new Random().Next(0, 175));
                    Controls.Add(buttons[i, j]);
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show(((Button)sender).Name);
        }
    }
}
