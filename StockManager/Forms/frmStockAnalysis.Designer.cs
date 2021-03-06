﻿namespace StockManager
{
    partial class frmStockAnalysis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockAnalysis));
            this.lblInformations = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lvList = new System.Windows.Forms.ListView();
            this.Guid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StockCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BuyPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SellPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gain = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInformations
            // 
            this.lblInformations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInformations.AutoSize = true;
            this.lblInformations.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblInformations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInformations.Font = new System.Drawing.Font("Hermit", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformations.ForeColor = System.Drawing.Color.PaleGreen;
            this.lblInformations.Location = new System.Drawing.Point(1, 474);
            this.lblInformations.Name = "lblInformations";
            this.lblInformations.Size = new System.Drawing.Size(110, 22);
            this.lblInformations.TabIndex = 10;
            this.lblInformations.Text = "information";
            this.lblInformations.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Font = new System.Drawing.Font("Hermit", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.refreshToolStripMenuItem.Text = "refresh";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(163, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Font = new System.Drawing.Font("Hermit", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.deleteToolStripMenuItem.Text = "delete";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Font = new System.Drawing.Font("Hermit", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.addToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.addToolStripMenuItem.Text = "add";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Hermit", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.editToolStripMenuItem.Text = "edit";
            // 
            // listMenu
            // 
            this.listMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.listMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator1,
            this.refreshToolStripMenuItem});
            this.listMenu.Name = "listMenu";
            this.listMenu.Size = new System.Drawing.Size(167, 106);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Hermit", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PaleGreen;
            this.label1.Location = new System.Drawing.Point(1, 474);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1266, 25);
            this.label1.TabIndex = 9;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lvList
            // 
            this.lvList.AllowColumnReorder = true;
            this.lvList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvList.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Guid,
            this.StockCode,
            this.Status,
            this.TotalAmount,
            this.BuyPrice,
            this.SellPrice,
            this.Gain,
            this.Date,
            this.TotalValue});
            this.lvList.Font = new System.Drawing.Font("Hermit", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvList.ForeColor = System.Drawing.Color.Lime;
            this.lvList.FullRowSelect = true;
            this.lvList.GridLines = true;
            this.lvList.HideSelection = false;
            this.lvList.LabelEdit = true;
            this.lvList.Location = new System.Drawing.Point(1, -3);
            this.lvList.Name = "lvList";
            this.lvList.Size = new System.Drawing.Size(1268, 475);
            this.lvList.TabIndex = 8;
            this.lvList.UseCompatibleStateImageBehavior = false;
            this.lvList.View = System.Windows.Forms.View.Details;
            this.lvList.DoubleClick += new System.EventHandler(this.lvList_DoubleClick);
            // 
            // Guid
            // 
            this.Guid.DisplayIndex = 8;
            this.Guid.Width = 0;
            // 
            // StockCode
            // 
            this.StockCode.DisplayIndex = 0;
            this.StockCode.Text = "stock-code";
            this.StockCode.Width = 155;
            // 
            // Status
            // 
            this.Status.DisplayIndex = 1;
            this.Status.Text = "status";
            this.Status.Width = 151;
            // 
            // TotalAmount
            // 
            this.TotalAmount.DisplayIndex = 2;
            this.TotalAmount.Text = "total-amount";
            this.TotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TotalAmount.Width = 150;
            // 
            // BuyPrice
            // 
            this.BuyPrice.DisplayIndex = 3;
            this.BuyPrice.Text = "buy-price";
            this.BuyPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BuyPrice.Width = 150;
            // 
            // SellPrice
            // 
            this.SellPrice.DisplayIndex = 4;
            this.SellPrice.Text = "sell-price";
            this.SellPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SellPrice.Width = 150;
            // 
            // Gain
            // 
            this.Gain.DisplayIndex = 5;
            this.Gain.Text = "gain";
            this.Gain.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Gain.Width = 150;
            // 
            // Date
            // 
            this.Date.Text = "date";
            this.Date.Width = 135;
            // 
            // TotalValue
            // 
            this.TotalValue.DisplayIndex = 6;
            this.TotalValue.Text = "total-value";
            this.TotalValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TotalValue.Width = 150;
            // 
            // frmStockAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 499);
            this.Controls.Add(this.lblInformations);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(854, 304);
            this.Name = "frmStockAnalysis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "stock-analysis";
            this.Load += new System.EventHandler(this.frmStockAnalysis_Load);
            this.listMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInformations;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip listMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvList;
        private System.Windows.Forms.ColumnHeader TotalAmount;
        private System.Windows.Forms.ColumnHeader BuyPrice;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ColumnHeader Gain;
        private System.Windows.Forms.ColumnHeader SellPrice;
        private System.Windows.Forms.ColumnHeader StockCode;
        private System.Windows.Forms.ColumnHeader TotalValue;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Guid;
    }
}