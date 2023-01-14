using System;
using System.Windows.Forms;


namespace Running_T_Rex
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            progressBar.Value = 0;
        }

        private void Splash_Load(object sender, EventArgs e) { }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar.Value += 1;
            progressLabel.Text = progressBar.Value.ToString() + "%";
            if (progressBar.Value == 100)
            {
                timer1.Enabled = false;
                Form1 main = new Form1();
                this.Hide();
                //this.Close();
                main.Show();
            }
        }
    }
}
