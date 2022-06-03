namespace TicTacToe
{
    public partial class Form1 : Form
    {
        String BtnValue = "X";
        int player = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_1_Click(object sender, EventArgs e)
        {
            if (Btn_1.Text == "")
            {
                Btn_1.Text = BtnValue;
                if (BtnValue == "X")
                {
                    BtnValue = "O";
                }
                else
                {
                    BtnValue = "X";
                }
            }
        }

        private void Btn_2_Click(object sender, EventArgs e)
        {
            if (Btn_2.Text == "")
            {
                Btn_2.Text = BtnValue;
                if (BtnValue == "X")
                {
                    BtnValue = "O";
                }
                else
                {
                    BtnValue = "X";
                }
            }
        }

        private void Btn_3_Click(object sender, EventArgs e)
        {
            if (Btn_3.Text == "")
            {
                Btn_3.Text = BtnValue;
                if (BtnValue == "X")
                {
                    BtnValue = "O";
                }
                else
                {
                    BtnValue = "X";
                }
            }
        }
    }
}