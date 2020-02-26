﻿namespace StockManager
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lvList = new System.Windows.Forms.ListView();
            this.StockTransactionId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StockCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StockName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UnitPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Const = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripComboBox();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.changeAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.periodListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblInformations = new System.Windows.Forms.Label();
            this.lblInformation2 = new System.Windows.Forms.Label();
            this.cbStock = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbPeriod = new System.Windows.Forms.ComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.translateMessagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listMenu.SuspendLayout();
            this.menuNotify.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvList
            // 
            this.lvList.AllowColumnReorder = true;
            this.lvList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvList.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StockTransactionId,
            this.StockCode,
            this.StockName,
            this.UnitPrice,
            this.Amount,
            this.Type,
            this.TotalPrice,
            this.Const,
            this.Date});
            this.lvList.ContextMenuStrip = this.listMenu;
            this.lvList.Font = new System.Drawing.Font("Hermit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvList.ForeColor = System.Drawing.Color.Lime;
            this.lvList.FullRowSelect = true;
            this.lvList.GridLines = true;
            this.lvList.HideSelection = false;
            this.lvList.LabelEdit = true;
            this.lvList.Location = new System.Drawing.Point(0, 40);
            this.lvList.Margin = new System.Windows.Forms.Padding(4);
            this.lvList.Name = "lvList";
            this.lvList.Size = new System.Drawing.Size(1360, 414);
            this.lvList.TabIndex = 2;
            this.lvList.UseCompatibleStateImageBehavior = false;
            this.lvList.View = System.Windows.Forms.View.Details;
            this.lvList.SelectedIndexChanged += new System.EventHandler(this.lvList_SelectedIndexChanged);
            this.lvList.DoubleClick += new System.EventHandler(this.lvList_DoubleClick);
            this.lvList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lvList_KeyPress);
            // 
            // StockTransactionId
            // 
            this.StockTransactionId.Text = "StockTransactionId";
            this.StockTransactionId.Width = 0;
            // 
            // StockCode
            // 
            this.StockCode.Text = Translate.GetMessage("stock-code");
            this.StockCode.Width = 119;
            // 
            // StockName
            // 
            this.StockName.Text = Translate.GetMessage("stock-name");
            this.StockName.Width = 250;
            // 
            // UnitPrice
            // 
            this.UnitPrice.Text = Translate.GetMessage("unit-price");
            this.UnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.UnitPrice.Width = 114;
            // 
            // Amount
            // 
            this.Amount.Text = Translate.GetMessage("amount");
            this.Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Amount.Width = 116;
            // 
            // Type
            // 
            this.Type.Text = Translate.GetMessage("type");
            this.Type.Width = 117;
            // 
            // TotalPrice
            // 
            this.TotalPrice.Text = Translate.GetMessage("total-price");
            this.TotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TotalPrice.Width = 135;
            // 
            // Const
            // 
            this.Const.Text = Translate.GetMessage("const");
            this.Const.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Const.Width = 100;
            // 
            // Date
            // 
            this.Date.Text = Translate.GetMessage("date");
            this.Date.Width = 154;
            // 
            // listMenu
            // 
            this.listMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.listMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.toolStripSeparator1,
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.analysisToolStripMenuItem,
            this.toolStripSeparator2,
            this.changeAccountToolStripMenuItem,
            this.periodListToolStripMenuItem,
            this.toolStripSeparator3,
            this.translateMessagesToolStripMenuItem,
            this.languageToolStripMenuItem});
            this.listMenu.Name = "listMenu";
            this.listMenu.Size = new System.Drawing.Size(298, 306);
            this.listMenu.Opening += new System.ComponentModel.CancelEventHandler(this.listMenu_Opening);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Hermit", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(297, 32);
            this.editToolStripMenuItem.Text = Translate.GetMessage("edit");
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            //
            // languageToolStripMenuItem
            //
            this.languageToolStripMenuItem.Font = new System.Drawing.Font("Hermit", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(297, 32);
            this.languageToolStripMenuItem.Text = Translate.GetMessage("language-choose");
            this.languageToolStripMenuItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.languageToolStripMenuItem.SelectedIndexChanged += new System.EventHandler(this.languageToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Font = new System.Drawing.Font("Hermit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(297, 32);
            this.refreshToolStripMenuItem.Text = Translate.GetMessage("refresh");
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(294, 6);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Font = new System.Drawing.Font("Hermit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.addToolStripMenuItem.Size = new System.Drawing.Size(297, 32);
            this.addToolStripMenuItem.Text = Translate.GetMessage("add");
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Font = new System.Drawing.Font("Hermit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(297, 32);
            this.deleteToolStripMenuItem.Text = Translate.GetMessage("delete");
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // analysisToolStripMenuItem
            // 
            this.analysisToolStripMenuItem.Font = new System.Drawing.Font("Hermit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analysisToolStripMenuItem.Name = "analysisToolStripMenuItem";
            this.analysisToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.analysisToolStripMenuItem.Size = new System.Drawing.Size(297, 32);
            this.analysisToolStripMenuItem.Text = Translate.GetMessage("analysis");
            this.analysisToolStripMenuItem.Click += new System.EventHandler(this.analysisToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(294, 6);
            // 
            // changeAccountToolStripMenuItem
            // 
            this.changeAccountToolStripMenuItem.Font = new System.Drawing.Font("Hermit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeAccountToolStripMenuItem.Name = "changeAccountToolStripMenuItem";
            this.changeAccountToolStripMenuItem.Size = new System.Drawing.Size(297, 32);
            this.changeAccountToolStripMenuItem.Text = Translate.GetMessage("change-account");
            this.changeAccountToolStripMenuItem.Click += new System.EventHandler(this.changeAccountToolStripMenuItem_Click);
            // 
            // periodListToolStripMenuItem
            // 
            this.periodListToolStripMenuItem.Font = new System.Drawing.Font("Hermit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periodListToolStripMenuItem.Name = "periodListToolStripMenuItem";
            this.periodListToolStripMenuItem.Size = new System.Drawing.Size(297, 32);
            this.periodListToolStripMenuItem.Text = Translate.GetMessage("period-list");
            this.periodListToolStripMenuItem.Click += new System.EventHandler(this.periodListToolStripMenuItem_Click);
            // 
            // menuNotify
            // 
            this.menuNotify.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuNotify.Name = "menuNotify";
            this.menuNotify.Size = new System.Drawing.Size(103, 28);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.exitToolStripMenuItem.Text = Translate.GetMessage("exit");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = Translate.GetMessage("stock-tracing");
            this.notifyIcon.Visible = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Hermit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PaleGreen;
            this.label1.Location = new System.Drawing.Point(0, 454);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1360, 30);
            this.label1.TabIndex = 6;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblInformations
            // 
            this.lblInformations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInformations.AutoSize = true;
            this.lblInformations.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblInformations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInformations.Font = new System.Drawing.Font("Hermit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformations.ForeColor = System.Drawing.Color.PaleGreen;
            this.lblInformations.Location = new System.Drawing.Point(0, 454);
            this.lblInformations.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInformations.Name = "lblInformations";
            this.lblInformations.Size = new System.Drawing.Size(170, 30);
            this.lblInformations.TabIndex = 7;
            this.lblInformations.Text = Translate.GetMessage("information");
            this.lblInformations.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblInformations.TextChanged += new System.EventHandler(this.lblInformations_TextChanged);
            // 
            // lblInformation2
            // 
            this.lblInformation2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInformation2.AutoSize = true;
            this.lblInformation2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblInformation2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInformation2.Font = new System.Drawing.Font("Hermit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformation2.ForeColor = System.Drawing.Color.PaleGreen;
            this.lblInformation2.Location = new System.Drawing.Point(0, 454);
            this.lblInformation2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInformation2.Name = "lblInformation2";
            this.lblInformation2.Size = new System.Drawing.Size(170, 30);
            this.lblInformation2.TabIndex = 8;
            this.lblInformation2.Text = Translate.GetMessage("information");
            this.lblInformation2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbStock
            // 
            this.cbStock.BackColor = System.Drawing.Color.Black;
            this.cbStock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStock.Font = new System.Drawing.Font("Hermit", 12F);
            this.cbStock.ForeColor = System.Drawing.Color.Lime;
            this.cbStock.FormattingEnabled = true;
            this.cbStock.Items.AddRange(new object[] {
            Translate.GetMessage("buy"),
            Translate.GetMessage("sell")});
            this.cbStock.Location = new System.Drawing.Point(131, 3);
            this.cbStock.Margin = new System.Windows.Forms.Padding(4);
            this.cbStock.Name = "cbStock";
            this.cbStock.Size = new System.Drawing.Size(248, 36);
            this.cbStock.TabIndex = 0;
            this.cbStock.SelectedIndexChanged += new System.EventHandler(this.cbStock_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Hermit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.PaleGreen;
            this.label4.Location = new System.Drawing.Point(0, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 36);
            this.label4.TabIndex = 10;
            this.label4.Text = $"{Translate.GetMessage("stock")} : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Hermit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.PaleGreen;
            this.label5.Location = new System.Drawing.Point(387, 3);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 36);
            this.label5.TabIndex = 12;
            this.label5.Text = $"{Translate.GetMessage("period")} : ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbPeriod
            // 
            this.cbPeriod.BackColor = System.Drawing.Color.Black;
            this.cbPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPeriod.Font = new System.Drawing.Font("Hermit", 12F);
            this.cbPeriod.ForeColor = System.Drawing.Color.Lime;
            this.cbPeriod.FormattingEnabled = true;
            this.cbPeriod.Items.AddRange(new object[] {
            Translate.GetMessage("buy"),
            Translate.GetMessage("sell")});
            this.cbPeriod.Location = new System.Drawing.Point(525, 3);
            this.cbPeriod.Margin = new System.Windows.Forms.Padding(4);
            this.cbPeriod.Name = "cbPeriod";
            this.cbPeriod.Size = new System.Drawing.Size(248, 36);
            this.cbPeriod.TabIndex = 1;
            this.cbPeriod.SelectedIndexChanged += new System.EventHandler(this.cbPeriod_SelectedIndexChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(294, 6);
            // 
            // translateMessagesToolStripMenuItem
            // 
            this.translateMessagesToolStripMenuItem.Font = new System.Drawing.Font("Hermit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translateMessagesToolStripMenuItem.Name = "translateMessagesToolStripMenuItem";
            this.translateMessagesToolStripMenuItem.Size = new System.Drawing.Size(297, 32);
            this.translateMessagesToolStripMenuItem.Text = Translate.GetMessage("translate-message");
            this.translateMessagesToolStripMenuItem.Click += new System.EventHandler(this.translateMessagesToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1361, 484);
            this.Controls.Add(this.cbPeriod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbStock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblInformation2);
            this.Controls.Add(this.lblInformations);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1025, 400);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = Translate.GetMessage("stock-trancing");
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.listMenu.ResumeLayout(false);
            this.menuNotify.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvList;
        private System.Windows.Forms.ColumnHeader StockCode;
        private System.Windows.Forms.ColumnHeader StockName;
        private System.Windows.Forms.ColumnHeader UnitPrice;
        private System.Windows.Forms.ColumnHeader TotalPrice;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ContextMenuStrip menuNotify;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip listMenu;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox languageToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader StockTransactionId;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.Label lblInformations;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader Const;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analysisToolStripMenuItem;
        private System.Windows.Forms.Label lblInformation2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem changeAccountToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem periodListToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbPeriod;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem translateMessagesToolStripMenuItem;
    }
}

