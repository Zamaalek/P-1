namespace P_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            var tb = (TextBox)sender;
            tb.BackColor = Color.Yellow;
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            var tb = (TextBox)sender;
            tb.BackColor = SystemColors.Window;
            tb.Text = tb.Text.Trim();
            if (!double.TryParse(tb.Text, out double result))
                tb.Focus();
            else if(result < 0)
                tb.Focus();
        }

        private void Button_oblicz_trojkat_Click(object sender, EventArgs e)
        {
            if (!((Button)sender).Focus())
                return;
            var podstawa = double.Parse(textBox_trojkat_podstawa.Text);
            var wysokosc = double.Parse(textBox_trojkat_wysokosc.Text);
            double pole = Math.Round(podstawa * wysokosc / 2, 2);
            label_wynik_trojkat.Text = $"{pole:n}";
        }

        private void Button_oblicz_kolo_Click(object sender, EventArgs e)
        {
            if (!((Button)sender).Focus())
                return;
            var promien = double.Parse(textBox_kolo_promien.Text);
            double pole = Math.Round(promien * promien * Math.PI, 2);
            label_wynik_kolo.Text = $"{pole:n}";
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            var tb = (TextBox)sender;
            if (tb.Parent == tabPage_trojkat)
                label_wynik_trojkat.Text = "???";
            else if (tb.Parent == tabPage_kolo)
                label_wynik_kolo.Text = "???";
        }
    }
}
