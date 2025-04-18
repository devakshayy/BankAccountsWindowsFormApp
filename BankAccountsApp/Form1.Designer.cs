﻿namespace BankAccountsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            OwnerTxt = new TextBox();
            AmountNum = new NumericUpDown();
            CreateAccountBtn = new Button();
            WithdrawBtn = new Button();
            DepositBtn = new Button();
            BankAccountsGrid = new DataGridView();
            label3 = new Label();
            InterestRateNum = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)AmountNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InterestRateNum).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 35);
            label1.Name = "label1";
            label1.Size = new Size(78, 28);
            label1.TabIndex = 0;
            label1.Text = "Owner :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 374);
            label2.Name = "label2";
            label2.Size = new Size(92, 28);
            label2.TabIndex = 1;
            label2.Text = "Amount :";
            label2.Click += label2_Click;
            // 
            // OwnerTxt
            // 
            OwnerTxt.Location = new Point(123, 38);
            OwnerTxt.Name = "OwnerTxt";
            OwnerTxt.Size = new Size(208, 31);
            OwnerTxt.TabIndex = 2;
            OwnerTxt.TextChanged += OwnerTxt_TextChanged;
            // 
            // AmountNum
            // 
            AmountNum.Location = new Point(123, 371);
            AmountNum.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            AmountNum.Minimum = new decimal(new int[] { 99999999, 0, 0, int.MinValue });
            AmountNum.Name = "AmountNum";
            AmountNum.Size = new Size(208, 31);
            AmountNum.TabIndex = 4;
            // 
            // CreateAccountBtn
            // 
            CreateAccountBtn.Location = new Point(212, 156);
            CreateAccountBtn.Name = "CreateAccountBtn";
            CreateAccountBtn.Size = new Size(119, 45);
            CreateAccountBtn.TabIndex = 6;
            CreateAccountBtn.Text = "Create Acc.";
            CreateAccountBtn.UseVisualStyleBackColor = true;
            CreateAccountBtn.Click += CreateAccountBtn_Click;
            // 
            // WithdrawBtn
            // 
            WithdrawBtn.Location = new Point(571, 356);
            WithdrawBtn.Name = "WithdrawBtn";
            WithdrawBtn.Size = new Size(189, 51);
            WithdrawBtn.TabIndex = 7;
            WithdrawBtn.Text = "Withdraw";
            WithdrawBtn.UseVisualStyleBackColor = true;
            WithdrawBtn.Click += WithdrawBtn_Click;
            // 
            // DepositBtn
            // 
            DepositBtn.Location = new Point(362, 356);
            DepositBtn.Name = "DepositBtn";
            DepositBtn.Size = new Size(189, 51);
            DepositBtn.TabIndex = 8;
            DepositBtn.Text = "Deposit";
            DepositBtn.UseVisualStyleBackColor = true;
            DepositBtn.Click += DepositBtn_Click;
            // 
            // BankAccountsGrid
            // 
            BankAccountsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BankAccountsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BankAccountsGrid.Location = new Point(362, 38);
            BankAccountsGrid.Name = "BankAccountsGrid";
            BankAccountsGrid.RowHeadersWidth = 62;
            BankAccountsGrid.Size = new Size(398, 261);
            BankAccountsGrid.TabIndex = 9;
            BankAccountsGrid.CellContentClick += BankAccountsGrid_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(33, 101);
            label3.Name = "label3";
            label3.Size = new Size(135, 30);
            label3.TabIndex = 10;
            label3.Text = "Interest (%) :";
            // 
            // InterestRateNum
            // 
            InterestRateNum.Location = new Point(212, 99);
            InterestRateNum.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            InterestRateNum.Minimum = new decimal(new int[] { 99999999, 0, 0, int.MinValue });
            InterestRateNum.Name = "InterestRateNum";
            InterestRateNum.Size = new Size(119, 31);
            InterestRateNum.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(InterestRateNum);
            Controls.Add(label3);
            Controls.Add(BankAccountsGrid);
            Controls.Add(DepositBtn);
            Controls.Add(WithdrawBtn);
            Controls.Add(CreateAccountBtn);
            Controls.Add(AmountNum);
            Controls.Add(OwnerTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)AmountNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)InterestRateNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox OwnerTxt;
        private NumericUpDown AmountNum;
        private Button CreateAccountBtn;
        private Button WithdrawBtn;
        private Button DepositBtn;
        private DataGridView BankAccountsGrid;
        private Label label3;
        private NumericUpDown InterestRateNum;
    }
}
