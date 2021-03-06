﻿using StockManager.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace StockManager
{
    public partial class frmStockTransaction : Form
    {
        StockTransaction stockTransaction;
        Stock stock;
        decimal amount = 0;
        decimal unitPrice = 0;

        public frmStockTransaction(int? stockTransactionId = null)
        {
            InitializeComponent();
            setTranslateMessage();
            if (stockTransactionId.HasValue)
            {
                stockTransaction = Session.Entities.GetStockTransaction(stockTransactionId.Value);
                stock = stockTransaction.Stock;
                txtAmount.Text = stockTransaction.Amount.ToMoneyStirng(2);
                txtStockCode.Text = stockTransaction.StockCode;
                txtStockName.Text = stock.Name;
                txtTotalPrice.Text = stockTransaction.TotalPrice.ToMoneyStirng(2);
                txtUnitPrice.Text = stockTransaction.UnitPrice.ToMoneyStirng(6);
                cbType.Text = stockTransaction.TransactionType == TransactionType.Buy ? Translate.GetMessage("buy") : Translate.GetMessage("sell");
                dtDate.Value = stockTransaction.Date;
            }
            else
            {
                stockTransaction = new StockTransaction();
                stock = new Stock();
            }
            dtDate.Value = DateTime.Now;
        }

        private void setTranslateMessage()
        {
            btnSave.Text = Translate.GetMessage("save");
            label1.Text = $"{Translate.GetMessage("stock-code")} : ";
            label2.Text = $"{Translate.GetMessage("stock-name")} : ";
            label3.Text = $"{Translate.GetMessage("amount")} : ";
            label4.Text = $"{Translate.GetMessage("type")} : ";
            cbType.Items.AddRange(new object[] {
            Translate.GetMessage("buy"),
            Translate.GetMessage("sell")});
            label5.Text = $"{Translate.GetMessage("date")} : ";
            label6.Text = $"{Translate.GetMessage("unit-price")} : ";
            label7.Text = $"{Translate.GetMessage("total-price")} : ";
            btnCancel.Text = Translate.GetMessage("cancel");
            Text = Translate.GetMessage("stock-transaction");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (validation())
            {
                stock.Name = txtStockName.Text;
                decimal amount = decimal.Parse(txtAmount.Text);
                decimal unitPrice = decimal.Parse(txtUnitPrice.Text);
                stock.StockCode = txtStockCode.Text.ToUpper();
                stock.UpdateDate = DateTime.Now;


                decimal currentAmount = Session.Entities.GetStockTransactions().Where(c => c.StockCode == stock.StockCode).Sum(c => c.Amount * (c.TransactionType == TransactionType.Sell ? -1 : 1));
                if (stockTransaction.StockTransactionId > 0)
                    currentAmount += stockTransaction.Amount;

                if (cbType.Text == Translate.GetMessage("Sell") && amount > currentAmount)
                {
                    MessageBox.Show(Translate.GetMessage("there-is-not-enough-stock"), Translate.GetMessage("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                stockTransaction.StockCode = txtStockCode.Text.ToUpper();
                stockTransaction.Date = dtDate.Value;
                stockTransaction.UnitPrice = stock.Value;

                if (cbType.Text == Translate.GetMessage("buy"))
                    stockTransaction.TransactionType = TransactionType.Buy;
                else if (cbType.Text == Translate.GetMessage("sell"))
                    stockTransaction.TransactionType = TransactionType.Sell;

                stockTransaction.Amount = amount;
                stockTransaction.UnitPrice = unitPrice;
                stockTransaction.TotalPrice = stockTransaction.UnitPrice * stockTransaction.Amount;

                Session.Entities.PostStock(stock);
                Session.Entities.PostStockTransaction(stockTransaction);
                Session.SaveChanges();
                Close();
            }
        }

        private bool validation()
        {
            decimal amount;
            decimal unitPrice;
            bool result = true;
            if (string.IsNullOrEmpty(cbType.Text))
            {
                result = false;
                errorProvider1.SetError(cbType, Translate.GetMessage("cant-be-empty"));
            }

            if (string.IsNullOrEmpty(txtAmount.Text))
            {
                result = false;
                errorProvider1.SetError(txtAmount, Translate.GetMessage("cant-be-empty"));
            }
            else if (!decimal.TryParse(txtAmount.Text, out amount))
            {
                result = false;
                errorProvider1.SetError(txtAmount, Translate.GetMessage("enter-a-numerical-value"));
            }

            if (string.IsNullOrEmpty(txtUnitPrice.Text))
            {
                result = false;
                errorProvider1.SetError(txtUnitPrice, Translate.GetMessage("cant-be-empty"));
            }
            else if (!decimal.TryParse(txtUnitPrice.Text, out unitPrice))
            {
                result = false;
                errorProvider1.SetError(txtUnitPrice, Translate.GetMessage("enter-a-numerical-value"));
            }

            if (string.IsNullOrEmpty(txtStockCode.Text))
            {
                result = false;
                errorProvider1.SetError(txtStockCode, Translate.GetMessage("cant-be-empty"));
            }

            if (string.IsNullOrEmpty(txtStockName.Text))
            {
                result = false;
                errorProvider1.SetError(txtStockName, Translate.GetMessage("cant-be-empty"));
            }

            return result;
        }

        private void frmStock_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(stock.StockCode))
                getStock(stock.StockCode);
        }

        private void calculateTotalPrice()
        {
            txtTotalPrice.Text = (unitPrice * amount).ToMoneyStirng(2);
        }

        private void getStock(string stockCode)
        {
            if (!string.IsNullOrEmpty(stockCode))
            {
                stock = Session.Entities.GetStock(stockCode);
                txtStockCode.Text = stockCode;
                txtStockName.Enabled = stock == null;
                if (stock != null)
                {
                    txtStockName.Text = stock.Name;
                    txtStockCode.Text = string.IsNullOrEmpty(stock.StockCode) ? stockCode.ToUpper() : stockCode;
                }
                else
                {
                    stock = new Stock()
                    {
                        StockCode = stockCode
                    };
                }
            }
        }

        private void txtUnitPrice_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUnitPrice.Text))
                errorProvider1.SetError(txtUnitPrice, Translate.GetMessage("cant-be-empty"));
            else if (!decimal.TryParse(txtUnitPrice.Text, out unitPrice))
                errorProvider1.SetError(txtUnitPrice, Translate.GetMessage("enter-a-numerical-value"));
            else
            {
                stockTransaction.UnitPrice = unitPrice;
                stock.Value = unitPrice;
                calculateTotalPrice();
            }
        }

        private void txtAmount_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAmount.Text))
                errorProvider1.SetError(txtAmount, Translate.GetMessage("cant-be-empty"));
            else if (!decimal.TryParse(txtAmount.Text, out amount))
                errorProvider1.SetError(txtAmount, Translate.GetMessage("enter-a-numerical-value"));
            else
            {
                calculateTotalPrice();
            }
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtStockCode_Leave(object sender, EventArgs e)
        {
            if (txtStockCode.Text.Length >= 4)
                getStock(txtStockCode.Text.ToUpper());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
