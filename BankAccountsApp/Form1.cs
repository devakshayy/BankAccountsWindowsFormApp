namespace BankAccountsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            BankAccount account1 = new BankAccount();
            account1.Owner = "Akshay";
            account1.AccountNumber = Guid.NewGuid();
            account1.Balance = 25000;

            BankAccount account2 = new BankAccount();
            account2.Owner = "Anu Ganeshan";
            account2.AccountNumber = Guid.NewGuid();
            account2.Balance = 34565;

            BankAccount account3 = new BankAccount();
            account3.Owner = "Aswin Jojo";
            account3.AccountNumber = Guid.NewGuid();
            account3.Balance = 545354;

            BankAccount account4 = new BankAccount();
            account4.Owner = "Sandra";
            account4.AccountNumber = Guid.NewGuid();
            account4.Balance = 35345;

            List<BankAccount> BankAccounts = new List<BankAccount>();
            BankAccounts.Add(account1);
            BankAccounts.Add(account2);
            BankAccounts.Add(account3);

            BankAccountsGrid.DataSource = BankAccounts;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
