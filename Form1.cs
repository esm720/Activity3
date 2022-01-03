namespace CardFlips
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cardBackButton_Click(object sender, EventArgs e)
        {
            cardBackPicture.Visible = true; // Turns back picture visible

            cardFacePictureBox.Visible = false;
            /*
                        writing a comment here allows mulitple lines to be
            covered.
                */
        }

        private void cardFaceButton_Click(object sender, EventArgs e)
        {
            cardBackPicture.Visible = false;
            cardFacePictureBox.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}