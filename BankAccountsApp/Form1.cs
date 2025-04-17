using BankAccountsApp;

namespace BankAccountsApp
{
    public partial class Form1 : Form
    {
        List<BankAccount> BankAccounts = new List<BankAccount>();
        public Form1()
        {
            InitializeComponent();
        }
        private void CreateAccountBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(OwnerTxt.Text))
                return;
            if(InterestRateNum.Value > 0)
            {
                SavingsAccount savingsAccount = new SavingsAccount(OwnerTxt.Text, InterestRateNum.Value);
                BankAccounts.Add(savingsAccount);
            }else
            {
                BankAccount account = new BankAccount(OwnerTxt.Text);
                BankAccounts.Add(account);
            }
            RefreshGrid();
            OwnerTxt.Text = string.Empty;
            InterestRateNum.Value = 0;
        }
        private void RefreshGrid()
        {
            BankAccountsGrid.DataSource = null;
            BankAccountsGrid.DataSource = BankAccounts;
        }

        private void DepositBtn_Click(object sender, EventArgs e)
        {
            if (BankAccountsGrid.SelectedRows.Count == 1 && AmountNum.Value > 0)
            {
                BankAccount SelectedBankAccount = BankAccountsGrid.SelectedRows[0].DataBoundItem as BankAccount;

                string Message = SelectedBankAccount.Deposit(AmountNum.Value);
                RefreshGrid();
                AmountNum.Value = 0;

                MessageBox.Show(Message);
            }
        }

        private void WithdrawBtn_Click(object sender, EventArgs e)
        {
            if (BankAccountsGrid.SelectedRows.Count == 1 && AmountNum.Value  > 0)
            {
                BankAccount SelectedBankAccount = BankAccountsGrid.SelectedRows[0].DataBoundItem as BankAccount;

                string Message = SelectedBankAccount.WithDraw(AmountNum.Value);
                RefreshGrid();
                AmountNum.Value = 0;

                MessageBox.Show(Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void OwnerTxt_TextChanged(object sender, EventArgs e)
        {
            // You can leave this empty if it's not needed
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BankAccountsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
