namespace Lab10
{
    public partial class Form1 : Form
    {
        private string selectName; 
        private int price;
        private int qty;
        private int total;
        private string payment;        
        private bool delivery = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            string name = comboBox1.SelectedItem.ToString();
            if (name == "Code1")
            {
                textBox4.Text = "Apple";
                textBox1.Text = "10";
                pictureBox1.Image = Image.FromFile("../Resources/1.jpg");
                selectName = textBox4.Text;

                price = Convert.ToInt32(textBox1.Text);
                qty = Convert.ToInt32(numericUpDown1.Value);
                total = price * qty;
                textBox3.Text = total.ToString();
            }
            else if (name == "Code2")
            {
                textBox4.Text = "Banana";
                textBox1.Text = "20";
                pictureBox1.Image = Image.FromFile("../Resources/11.jpg");
                selectName = textBox4.Text;

                price = Convert.ToInt32(textBox1.Text);
                qty = Convert.ToInt32(numericUpDown1.Value);
                total = price * qty;
                textBox3.Text = total.ToString();
            }
            else if (name == "Code3")
            {
                textBox4.Text = "Orange";
                textBox1.Text = "30";
                pictureBox1.Image = Image.FromFile("../Resources/12.jpg");
                selectName = textBox4.Text;

                price = Convert.ToInt32(textBox1.Text);
                qty = Convert.ToInt32(numericUpDown1.Value);
                total = price * qty;
                textBox3.Text = total.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "Code1";
            textBox3.Text = "0";
            radioButton1.Checked = true;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            price = Convert.ToInt32(textBox1.Text);
            qty = Convert.ToInt32(numericUpDown1.Value);
            total = price * qty;
            textBox3.Text = total.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            payment = "Cash";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            payment = "Visa";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            delivery = checkBox1.Checked;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (delivery == true)
            {
                MessageBox.Show("You have ordered " + qty + " units of " + selectName + " with total cost equal to HK$ " + total + "\nPayment is " + payment + " with free delivery.");
            }
            else if (delivery == false)
            {
                MessageBox.Show("You have ordered " + qty + " units of " + selectName + " with total cost equal to HK$ " + total + "\nPayment is " + payment + ". ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "Code1";
            numericUpDown1.Value = 0;
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            checkBox1.Checked = false;
            textBox3.Text = "0";
        }
    }
}