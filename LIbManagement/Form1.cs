namespace LIbManagement
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Members members = new Members();
            members.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            books.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Loan books = new Loan();
            books.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Points point = new Points();
            point.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
