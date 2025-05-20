namespace FinalsProject
{
    public partial class Form1 : Form
    {
        Dictionary<string, double> exchangeRates = new Dictionary<string, double>()
        {
            {"USD", 1.0},
            {"PHP", 57.0},
            {"EUR", 0.93},
            {"JPY", 155.0},
            {"CNY", 7.2},
            {"HKD", 7.85}
        };
        public Form1()
        {
            InitializeComponent();

            ComboBox1.Items.AddRange(exchangeRates.Keys.ToArray());
            ComboBox2.Items.AddRange(exchangeRates.Keys.ToArray());


            // Form background
            this.BackColor = Color.FromArgb(28, 28, 34);

            // Common font
            Font commonFont = new Font("Segoe UI", 12, FontStyle.Regular);

            // ComboBox1
            ComboBox1.Font = commonFont;
            ComboBox1.BackColor = Color.FromArgb(38, 38, 48);
            ComboBox1.ForeColor = Color.White;
            ComboBox1.FlatStyle = FlatStyle.Flat;
            ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            // ComboBox2
            ComboBox2.Font = commonFont;
            ComboBox2.BackColor = Color.FromArgb(38, 38, 48);
            ComboBox2.ForeColor = Color.White;
            ComboBox2.FlatStyle = FlatStyle.Flat;
            ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;

            // TextBox1
            textBox1.Font = commonFont;
            textBox1.BackColor = Color.FromArgb(38, 38, 48);
            textBox1.ForeColor = Color.White;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.TextAlign = HorizontalAlignment.Center;

            // TextBox2
            textBox2.Font = commonFont;
            textBox2.BackColor = Color.FromArgb(38, 38, 48);
            textBox2.ForeColor = Color.White;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.ReadOnly = true;
            textBox2.TabStop = false;

            //  label3 
            label3.Text = "Currency Calculator";
            label3.Font = new Font("Segoe UI", 22, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.BackColor = Color.Transparent;
            label3.TextAlign = ContentAlignment.MiddleCenter;





            // Button1
            button1.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            button1.BackColor = Color.FromArgb(60, 130, 246);
            button1.ForeColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.Cursor = Cursors.Hand;

            // Button hover effect
            button1.MouseEnter += (s, e) => button1.BackColor = Color.FromArgb(80, 150, 255);
            button1.MouseLeave += (s, e) => button1.BackColor = Color.FromArgb(60, 130, 246);

            // Labels
            label1.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            label1.ForeColor = Color.LightGray;
            label2.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            label2.ForeColor = Color.LightGray;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ComboBox1.SelectedItem == null || ComboBox2.SelectedItem == null)
            {
                MessageBox.Show("Please select both currencies.");
                return;
            }

            if (!double.TryParse(textBox1.Text, out double amount))
            {
                MessageBox.Show("Please enter a valid amount.");
                return;
            }

            string fromCurrency = ComboBox1.SelectedItem.ToString();
            string toCurrency = ComboBox2.SelectedItem.ToString();

            double fromRate = exchangeRates[fromCurrency];
            double toRate = exchangeRates[toCurrency];

            double amountInUSD = amount / fromRate;
            double convertedAmount = amountInUSD * toRate;

            textBox2.Text = convertedAmount.ToString("F2");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
