namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = (int.Parse(textBox1.Text) * int.Parse(textBox2.Text)).ToString();
            listBox1.Items.Add(textBox3.Text.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = (int.Parse(textBox1.Text) + int.Parse(textBox2.Text)).ToString();
            listBox1.Items.Add(textBox3.Text.ToString());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = (int.Parse(textBox1.Text) - int.Parse(textBox2.Text)).ToString();
            listBox1.Items.Add(textBox3.Text.ToString());
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox3.Text = (int.Parse(textBox1.Text) / int.Parse(textBox2.Text)).ToString();
            listBox1.Items.Add(textBox3.Text.ToString());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}