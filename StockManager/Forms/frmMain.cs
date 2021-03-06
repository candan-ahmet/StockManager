﻿using StockManager.Business;
using StockManager.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManager
{
    public partial class frmMain : Form
    {
        bool left = false;
        Period period;
        string periodSelectedText;
        List<Stock> stocks;

        public frmMain()
        {
            InitializeComponent();
            setTranslateMessage();
        }

        private void setTranslateMessage()
        {
            StockCode.Text = Translate.GetMessage("stock-code");
            StockName.Text = Translate.GetMessage("stock-name");
            UnitPrice.Text = Translate.GetMessage("unit-price");
            Amount.Text = Translate.GetMessage("amount");
            Type.Text = Translate.GetMessage("type");
            TotalPrice.Text = Translate.GetMessage("total-price");
            Const.Text = Translate.GetMessage("const");
            Date.Text = Translate.GetMessage("date");
            editToolStripMenuItem.Text = Translate.GetMessage("edit");
            refreshToolStripMenuItem.Text = Translate.GetMessage("refresh");
            addToolStripMenuItem.Text = Translate.GetMessage("add");
            deleteToolStripMenuItem.Text = Translate.GetMessage("delete");
            analysisToolStripMenuItem.Text = Translate.GetMessage("analysis");
            changeAccountToolStripMenuItem.Text = Translate.GetMessage("change-account");
            periodListToolStripMenuItem.Text = Translate.GetMessage("period-list");
            getcurrentvaluesToolStripMenuItem.Text = Translate.GetMessage("get-current-values");
            getcurrentvaluesToolStripMenuItem1.Text = Translate.GetMessage("get-current-values");
            exitToolStripMenuItem.Text = Translate.GetMessage("exit");
            notifyIcon.Text = Translate.GetMessage("stock-tracing");
            lblInformations.Text = Translate.GetMessage("information");
            lblInformation2.Text = Translate.GetMessage("information");
            label4.Text = $"{Translate.GetMessage("stock")} : ";
            label5.Text = $"{Translate.GetMessage("period")} : ";
            translateMessagesToolStripMenuItem.Text = Translate.GetMessage("translate-message");
            Text = $"{Translate.GetMessage("stock-tracing")} - [{(period != null ? period.PeriodName : "")}]";
            label2.Text = $"{Translate.GetMessage("language")} : ";
            periodtransToolStripMenuItem.Text = Translate.GetMessage("period-transaction-chart");
            addcurrentstockpriceToolStripMenuItem.Text = Translate.GetMessage("add-current-stock-price");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            timer1.Start();
            cbLanguage_Fill();
            cbLanguage.Text = Session.Entities.GetSetting().LanguageCode;
            DateTime now = DateTime.Now.SmallDate();
            period = Session.Entities.GetPeriods().Where(c => (c.StartDate <= now && c.EndDate >= now)).OrderByDescending(c => c.StartDate).FirstOrDefault();
            if (period == null)
                period = Session.Entities.GetPeriods().OrderByDescending(c => c.StartDate).FirstOrDefault();
            if (period == null)
                period = new Period() { AccountId = Session.DefaultAccount.AccountId, StartDate = DateTime.Now, EndDate = DateTime.Now.AddYears(1), PeriodName = "All" };
            cbPeriod_Fill();
            if (period == null)
            {
                var endDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                endDate = endDate.AddMonths(1);
                endDate = endDate.AddDays(-1);
                period = new Period()
                {
                    StartDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1),
                    EndDate = endDate
                };
                periodSelectedText = string.Empty;
            }
            else
            {
                periodSelectedText = period.PeriodName;
                cbPeriod.Text = periodSelectedText;
            }
            cbStock_Fill();
            cbStock.SelectedIndex = 0;
        }

        private void cbStock_Fill()
        {
            cbStock.Items.Clear();
            cbStock.ValueMember = "Value";
            cbStock.Items.Add(new ComboboxItem
            {
                Code = "",
                Value = Translate.GetMessage("all")
            });
            DateTime startDate = period.StartDate;
            DateTime endDate = period.EndDate;
            stocks = (from st in Session.Entities.GetStockTransactions()
                      join s in Session.Entities.GetStocks() on st.StockCode equals s.StockCode
                      where st.Date >= startDate && st.Date <= endDate
                      orderby st.Date descending
                      select s).Distinct().ToList();
            foreach (var stock in stocks)
            {
                cbStock.Items.Add(new ComboboxItem
                {
                    Code = stock.StockCode,
                    Value = stock.StockCode
                });
            }
        }

        private void cbLanguage_Fill()
        {
            cbLanguage.Items.Clear();
            foreach (var language in Session.Entities.GetLanguageCodeList())
            {
                cbLanguage.Items.Add(new ComboboxItem
                {
                    Code = language,
                    Object = language,
                    Value = language
                });
            }
        }

        private void cbPeriod_Fill()
        {
            cbPeriod.Items.Clear();
            foreach (var period in Session.Entities.GetPeriods().Where(c => c.StartDate <= DateTime.Now).OrderByDescending(c => c.StartDate))
            {
                cbPeriod.Items.Add(new ComboboxItem
                {
                    Code = period.PeriodId.ToString(),
                    Value = period.PeriodName,
                    Object = period
                });
            }
            cbPeriod.Text = periodSelectedText;
        }

        private void refreshList()
        {
            Text = $"{Translate.GetMessage("stock-tracing")} - [{Session.DefaultAccount.AccountName} - {Session.DefaultAccount.MoneyType.MoneyTypeToString()}]";
            string selectedStockCode = (cbStock.SelectedItem != null && !string.IsNullOrEmpty(cbStock.Text)) ? ((ComboboxItem)cbStock.SelectedItem).Code : "";
            DateTime startDate = period.StartDate;
            DateTime endDate = period.EndDate;
            lvList.Items.Clear();
            var list = from st in Session.Entities.GetStockTransactions()
                       join s in Session.Entities.GetStocks() on st.StockCode equals s.StockCode
                       where (string.IsNullOrEmpty(selectedStockCode) || s.StockCode == selectedStockCode)
                       && st.Date >= startDate
                       && st.Date <= endDate
                       orderby st.Date descending
                       select new
                       {
                           Stock = s,
                           StockTransaction = st
                       };

            foreach (var item in list)
            {
                var li = new ListViewItem();
                li.Text = item.StockTransaction.StockTransactionId.ToString();
                li.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Name = "StockCode",
                    Text = item.Stock.StockCode
                });
                li.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Name = "StockName",
                    Text = item.Stock.Name
                });
                li.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Name = "UnitPrice",
                    Text = item.StockTransaction.UnitPrice.ToMoneyStirng(6)
                });
                li.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Name = "Amount",
                    Text = item.StockTransaction.Amount.ToMoneyStirng(0)
                });
                li.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Name = "Status",
                    Text = item.StockTransaction.TransactionType == TransactionType.Buy ? Translate.GetMessage("buy") : Translate.GetMessage("sell")
                });
                li.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Name = "TotalPrice",
                    Text = (item.StockTransaction.UnitPrice * item.StockTransaction.Amount).ToMoneyStirng(2)
                });
                li.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Name = "Const",
                    Text = (item.StockTransaction.Const).ToMoneyStirng(2)
                });
                li.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Name = "Date",
                    Text = item.StockTransaction.Date.ToShortDateString()
                });

                lvList.Items.Add(li);
            }

            var liTotal = new ListViewItem();
            liTotal.Text = "0";
            liTotal.SubItems.Add(new ListViewItem.ListViewSubItem()
            {
                Name = "StockCode",
                Text = ""
            });
            liTotal.SubItems.Add(new ListViewItem.ListViewSubItem()
            {
                Name = "StockName",
                Text = ""
            });
            liTotal.SubItems.Add(new ListViewItem.ListViewSubItem()
            {
                Name = "UnitPrice",
                Text = ""
            });
            liTotal.SubItems.Add(new ListViewItem.ListViewSubItem()
            {
                Name = "Amount",
                Text = ""
            });
            liTotal.SubItems.Add(new ListViewItem.ListViewSubItem()
            {
                Name = "Status",
                Text = Translate.GetMessage("total")
            }); ;
            var totalPrice = list.Sum(c => c.StockTransaction.TotalPrice * (c.StockTransaction.TransactionType == TransactionType.Buy ? -1 : 1));
            liTotal.SubItems.Add(new ListViewItem.ListViewSubItem()
            {
                Name = "TotalPrice",
                Text = totalPrice.ToMoneyStirng(2)
            });
            var totalConst = list.Sum(c => c.StockTransaction.Const);
            liTotal.SubItems.Add(new ListViewItem.ListViewSubItem()
            {
                Name = "Const",
                Text = totalConst.ToMoneyStirng(2)
            });
            liTotal.SubItems.Add(new ListViewItem.ListViewSubItem()
            {
                Name = "Date",
                Text = ""
            });
            liTotal.BackColor = Color.DarkSlateGray;

            lvList.Items.Add(liTotal);
            refreshInformations();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStockTransaction frm = new frmStockTransaction();
            frm.ShowDialog();
            refreshList();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refreshList();
        }

        private void listMenu_Opening(object sender, CancelEventArgs e)
        {
            editToolStripMenuItem.Enabled = lvList.SelectedItems.Count > 0 && !(lvList.SelectedItems.Count == 1 && lvList.SelectedItems[0].Text == "0");
            deleteToolStripMenuItem.Enabled = editToolStripMenuItem.Enabled;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editStockTransaction();
        }

        private void editStockTransaction()
        {
            if (lvList.SelectedItems.Count == 0 || (lvList.SelectedItems.Count == 1 && lvList.SelectedItems[0].Text == "0")) return;
            int stockTransactionId = int.Parse(lvList.SelectedItems[0].Text);
            frmStockTransaction frm = new frmStockTransaction(stockTransactionId);
            frm.ShowDialog();
            refreshList();
        }

        private void lvList_DoubleClick(object sender, EventArgs e)
        {
            editStockTransaction();
        }

        private void lvList_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                editStockTransaction();
        }

        private void lvList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvList.SelectedItems.Count > 0 && !(lvList.SelectedItems.Count == 1 && lvList.SelectedItems[0].Text == "0"))
            {
                List<int> ids = new List<int>();
                for (int i = 0; i < lvList.SelectedItems.Count; i++)
                    ids.Add(int.Parse(lvList.SelectedItems[i].Text));
                refreshInformations(ids);
            }
            else refreshInformations();
        }

        private void refreshInformations(List<int> ids = null)
        {
            lblInformations.Text = string.Empty;
            var result = from st in Session.Entities.GetStockTransactions()
                         join s in Session.Entities.GetStocks() on st.StockCode equals s.StockCode
                         where (ids == null || ids.Contains(st.AccountTransactionId))
                         orderby st.Date
                         select new
                         {
                             Stock = s,
                             StockTransaction = st
                         };
            var stocks = from s in Session.Entities.GetStocks()
                         where result.Select(c => c.Stock.StockCode).Contains(s.StockCode)
                         select new StockInformation
                         {
                             Stock = s,
                             TotalAmount = result.Where(c => c.Stock.StockCode == s.StockCode)
                                            .Sum(c => c.StockTransaction.Amount *
                                                (c.StockTransaction.TransactionType == TransactionType.Sell ? -1 : 1)),
                             TotalPrice = result.Where(c => c.Stock.StockCode == s.StockCode)
                                            .Sum(c => c.StockTransaction.UnitPrice * c.StockTransaction.Amount *
                                                (c.StockTransaction.TransactionType == TransactionType.Buy ? -1 : 1)),
                             Const = result.Where(c => c.Stock.StockCode == s.StockCode).Sum(c => c.StockTransaction.Const)
                         };

            foreach (var item in stocks)
            {
                lblInformations.Text += $"[{Translate.GetMessage("stock-code")}: {item.Stock.StockCode}, {Translate.GetMessage("total-amount")}: {item.TotalAmount.ToMoneyStirng(0)}, {Translate.GetMessage("total-price")}: {(item.TotalPrice).ToMoneyStirng(2)}] | ";
            }
            lblInformations.Text += $"[{Translate.GetMessage("const")}: {stocks.Sum(c => c.Const).ToMoneyStirng(2)}, {Translate.GetMessage("total-price")}: {stocks.Sum(c => c.TotalPrice - c.Const).ToMoneyStirng(2)}]";
            lblInformation2.Text = lblInformations.Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lblInformations.Size.Width > label1.Size.Width)
            {
                lblInformations.Location = new Point(lblInformations.Location.X + 1, lblInformations.Location.Y);
                if (lblInformations.Location.X > label1.Size.Width)
                    lblInformations.Location = lblInformation2.Location;

                lblInformation2.Location = new Point(lblInformations.Location.X - lblInformation2.Size.Width - 50, lblInformations.Location.Y);
                lblInformation2.Visible = true;
            }
            else
            {
                lblInformation2.Visible = false;
                if (left)
                    lblInformations.Location = new Point(lblInformations.Location.X - 1, lblInformations.Location.Y);
                else
                    lblInformations.Location = new Point(lblInformations.Location.X + 1, lblInformations.Location.Y);

                if (left && lblInformations.Location.X <= 0)
                    left = false;
                else if (!left && (lblInformations.Location.X + lblInformations.Size.Width) >= label1.Size.Width)
                    left = true;
            }
        }

        private void lblInformations_TextChanged(object sender, EventArgs e)
        {
            if (lblInformations.Size.Width < label1.Size.Width)
                lblInformations.Location = new Point(0, lblInformations.Location.Y);
            else lblInformations.Location = new Point(label1.Size.Width - lblInformations.Size.Width - 500, lblInformations.Location.Y);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Translate.GetMessage("delete-record"), Translate.GetMessage("delete"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Session.Entities.DeleteStockTransaction(int.Parse(lvList.SelectedItems[0].Text));
                refreshList();
            }
        }

        private void analysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockAnalysisRequest request = new StockAnalysisRequest();
            for (int i = 0; i < lvList.SelectedItems.Count; i++)
                if (!string.IsNullOrEmpty(lvList.SelectedItems[i].SubItems["StockCode"].Text))
                    request.StockCodes.Add(lvList.SelectedItems[i].SubItems["StockCode"].Text);
            request.Period = period;
            request.StockCodes = request.StockCodes.Distinct().ToList();
            frmStockAnalysis frm = new frmStockAnalysis(request);
            frm.ShowDialog();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void changeAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccountChoose frm = new frmAccountChoose();
            frm.ShowDialog();
            cbPeriod_Fill();
            refreshList();
        }

        private void createAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccount frm = new frmAccount();
            frm.ShowDialog();
        }

        private void cbStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshList();
        }

        private void dtDateStart_ValueChanged(object sender, EventArgs e)
        {
            refreshList();
        }

        private void dtDateEnd_ValueChanged(object sender, EventArgs e)
        {
            refreshList();
        }

        private void periodListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPeriodList frm = new frmPeriodList();
            frm.ShowDialog();
            cbPeriod_Fill();
        }

        private void cbPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            periodSelectedText = cbPeriod.Text;
            period = (Period)((ComboboxItem)cbPeriod.SelectedItem).Object;
            cbStock_Fill();
            cbStock.SelectedIndex = 0;
        }

        private void translateMessagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTranslateMessageList frm = new frmTranslateMessageList();
            frm.ShowDialog();
        }

        bool first = true;
        private void cbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session.Entities.GetSetting().LanguageCode = cbLanguage.Text;
            Session.User.LanguageCode = Session.Entities.GetSetting().LanguageCode;
            Task.Run(() => Session.SaveChanges());
            //Session.SaveChanges();

            if (!first)
            {
                setTranslateMessage();
                int cbStockSelectedIndex = cbStock.SelectedIndex;
                cbStock_Fill();
                cbStock.SelectedIndex = cbStockSelectedIndex;
                refreshInformations();
            }
            else first = false;
        }

        private void addcurrentstockpriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCurrentStock frm = new frmCurrentStock();
            frm.ShowDialog();
        }

        private void getcurrentvaluesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task.Run(() => getCurrentValues());
        }

        void getCurrentValues()
        {
            try
            {
                DovizComApi api = new DovizComApi();
                if (api.IsError)
                {
                    MessageBox.Show(Translate.GetMessage("get-current-stock-values-failed"), Translate.GetMessage("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                foreach (var item in (from s in Session.Entities.GetStocks()
                                      join cs in api.StockCurrents on s.StockCode equals cs.StockCode
                                      select new
                                      {
                                          Stock = s,
                                          CurrentStock = cs
                                      }))
                {
                    Session.Entities.GetCurrentStocks().Add(item.CurrentStock);
                    item.Stock.Name = item.CurrentStock.StockName;
                }
                Session.SaveChanges();
                MessageBox.Show(Translate.GetMessage("get-current-stock-values-success"), Translate.GetMessage("success"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show(Translate.GetMessage("get-current-stock-values-failed"), Translate.GetMessage("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void periodtransToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPeriodGain frm = new frmPeriodGain();
            frm.ShowDialog();
        }
    }

    class ComboboxItem
    {
        public string Value { get; set; }
        public string Code { get; set; }
        public object Object { get; set; }

        public override string ToString()
        {
            return Value;
        }
    }

    class StockInformation
    {
        public Stock Stock { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal Const { get; set; }
    }
}
