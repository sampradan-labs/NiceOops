namespace ForEvents
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            button1.Click += MyCustomHandler;
            button1.Click += OpenForm2;

            textBox1.LostFocus += OnTextboxLostFocus;
            textBox1.LostFocus += CheckValidEmail;
        }

        private void OpenForm2(object? sender, EventArgs e)
        {
            Form2 objForm2 = new Form2();
            objForm2.Show();
        }

        private void MyCustomHandler(object? sender, EventArgs e)
        {
            MessageBox.Show("Using MyCustomhandler to handle button1.Click");
            
        }

        private void CheckValidEmail(object? sender, EventArgs e)
        {
            bool isValidEmail = textBox1.Text.ToLower().Contains("@kpmg.com");
            if (isValidEmail)
            {
                textBox1.BackColor = Color.Green;
                textBox1.ForeColor = Color.Blue;
            }
            else
            {
                textBox1.BackColor = Color.Red;
                textBox1.ForeColor = Color.Yellow;
                MessageBox.Show("Invalid email");
            }
        }

        private void OnTextboxLostFocus(object? sender, EventArgs e)
        {
            textBox1.Text = "KPMG-"+textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Handling button1.Click");
        }
    }
}