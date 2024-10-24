namespace PresentationLayer.forms
{
    public partial class FormAgent : Form
    {
        public FormAgent()
        {
            InitializeComponent();

            // Suscribir eventos MouseEnter y MouseLeave para cada botón
            btnExit.MouseEnter += Button_MouseEnter;
            btnExit.MouseLeave += Button_MouseLeave;
            btnFinish.MouseEnter += Button_MouseEnter;
            btnFinish.MouseLeave += Button_MouseLeave;
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.LightGreen;
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.DarkGreen;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}