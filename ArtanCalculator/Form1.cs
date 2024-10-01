using System;
using System.Windows.Forms;

namespace ArtanCalculator
{
    public partial class Form1 : Form
    {
        Double result = 0;
        string operation = string.Empty;
        string fstNum, secNum;
        bool enterValue = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textDisplay1_TextChanged(object sender, EventArgs e)
        {

        }
        private void BtnMathOperation_Click(object sender, EventArgs e)
        {
            if (result != 0) BtnEqual.PerformClick();
            else result = Double.Parse(textDisplay.Text);

            Button button = (Button)sender;
            operation = button.Text;
            enterValue = true;
            if (textDisplay.Text != "0")
            {  
                textPreview.Text = fstNum = $"{result}{operation}";
                textDisplay.Text = string.Empty;
            }
        }
        private void BtnEqual_Click(object sender, EventArgs e)
        {
            secNum = textDisplay.Text;
            textPreview.Text = $"{textPreview.Text} {secNum} = ";
            if (textDisplay.Text != string.Empty)
            {
                if (textDisplay.Text == "0") textPreview.Text = string.Empty;
                try
                {
                    switch (operation)
                    {
                        case "+":
                            textDisplay.Text = (result + Double.Parse(textDisplay.Text)).ToString();
                            RtBoxDisplayHistory.AppendText($"{fstNum} {secNum} = {textDisplay.Text} \n");
                            break;
                        case "-":
                            textDisplay.Text = (result - Double.Parse(textDisplay.Text)).ToString();
                            RtBoxDisplayHistory.AppendText($"{fstNum} {secNum} = {textDisplay.Text} \n");
                            break;
                        case "×":
                            textDisplay.Text = (result * Double.Parse(textDisplay.Text)).ToString();
                            RtBoxDisplayHistory.AppendText($"{fstNum} {secNum} = {textDisplay.Text} \n");
                            break;
                        case "÷":
                            textDisplay.Text = (result / Double.Parse(textDisplay.Text)).ToString();
                            RtBoxDisplayHistory.AppendText($"{fstNum} {secNum} = {textDisplay.Text} \n");
                            if (Double.Parse(textDisplay.Text) == 0)
                            {
                                MessageBox.Show("Cannot divide by zero.");
                                return;
                            }
                            break;
                        default:
                            textPreview.Text = $"{textDisplay.Text} = ";
                            break;
                    }
                }
                catch (Exception ex)
                {
                    textPreview.Text = ex.Message;
                }
                result = Double.Parse(textDisplay.Text);
                operation = string.Empty;
            }
        }
        private void BtnHistory_Click(object sender, EventArgs e)
        {
            PnlHistory.Height = (PnlHistory.Height == 5) ? PnlHistory.Height = 345 : 5;
        }
        private void BtnClearHistory_Click(object sender, EventArgs e)
        {
            RtBoxDisplayHistory.Clear();
            if (RtBoxDisplayHistory.Text == string.Empty)
                RtBoxDisplayHistory.Text = "There's nothing saved in memory.";
        }
        private void BtnBackspace_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text.Length > 0)
                textDisplay.Text = textDisplay.Text.Remove(textDisplay.Text.Length - 1, 1);
            if (textDisplay.Text == string.Empty) textDisplay.Text = "0";
        }
        private void BtnC_Click(object sender, EventArgs e)
        {
            textDisplay.Text = "0";
            textPreview.Text = string.Empty;
            result = 0;
        }
        private void BtnCE_Click(object sender, EventArgs e)
        {
            textDisplay.Text = "0";
        }

        private void BtnPercent_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textPreview.Text = $"%({textDisplay.Text})";
            textDisplay.Text = Convert.ToString(Convert.ToDouble(textDisplay.Text) / Convert.ToDouble(100));
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {

        }

        private void textPreview_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnNum_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0" || enterValue) textDisplay.Text = string.Empty;

            enterValue = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textDisplay.Text.Contains("."))
                    textDisplay.Text = textDisplay.Text + button.Text;
            }
            else textDisplay.Text = textDisplay.Text + button.Text;

        }
    }
}
