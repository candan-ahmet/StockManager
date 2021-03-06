﻿namespace StockManager
{
    partial class frmPeriod
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
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPeriodName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblIsPublic = new System.Windows.Forms.Label();
            this.cbIsPublic = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Hermit", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.PaleGreen;
            this.btnSave.Location = new System.Drawing.Point(247, 179);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 35);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPeriodName
            // 
            this.txtPeriodName.BackColor = System.Drawing.Color.Black;
            this.txtPeriodName.Font = new System.Drawing.Font("Hermit", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeriodName.ForeColor = System.Drawing.Color.Lime;
            this.txtPeriodName.Location = new System.Drawing.Point(178, 9);
            this.txtPeriodName.MaxLength = 30;
            this.txtPeriodName.Name = "txtPeriodName";
            this.txtPeriodName.Size = new System.Drawing.Size(188, 30);
            this.txtPeriodName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Hermit", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PaleGreen;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "period-name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Crimson;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Hermit", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Pink;
            this.btnCancel.Location = new System.Drawing.Point(122, 179);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 35);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Hermit", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.PaleGreen;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "start-date";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Hermit", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.PaleGreen;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "end-date";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtStartDate
            // 
            this.dtStartDate.CalendarMonthBackground = System.Drawing.Color.Black;
            this.dtStartDate.Font = new System.Drawing.Font("Hermit", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStartDate.Location = new System.Drawing.Point(180, 45);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(187, 30);
            this.dtStartDate.TabIndex = 12;
            // 
            // dtEndDate
            // 
            this.dtEndDate.CalendarMonthBackground = System.Drawing.Color.Black;
            this.dtEndDate.Font = new System.Drawing.Font("Hermit", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEndDate.Location = new System.Drawing.Point(180, 80);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(187, 30);
            this.dtEndDate.TabIndex = 13;
            // 
            // lblIsPublic
            // 
            this.lblIsPublic.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblIsPublic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIsPublic.Font = new System.Drawing.Font("Hermit", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsPublic.ForeColor = System.Drawing.Color.PaleGreen;
            this.lblIsPublic.Location = new System.Drawing.Point(12, 115);
            this.lblIsPublic.Name = "lblIsPublic";
            this.lblIsPublic.Size = new System.Drawing.Size(160, 30);
            this.lblIsPublic.TabIndex = 2;
            this.lblIsPublic.Text = "is-public";
            this.lblIsPublic.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbIsPublic
            // 
            this.cbIsPublic.AutoSize = true;
            this.cbIsPublic.Font = new System.Drawing.Font("Hermit", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIsPublic.Location = new System.Drawing.Point(180, 124);
            this.cbIsPublic.Margin = new System.Windows.Forms.Padding(2);
            this.cbIsPublic.Name = "cbIsPublic";
            this.cbIsPublic.Size = new System.Drawing.Size(15, 14);
            this.cbIsPublic.TabIndex = 14;
            this.cbIsPublic.UseVisualStyleBackColor = true;
            // 
            // frmPeriod
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(398, 226);
            this.Controls.Add(this.cbIsPublic);
            this.Controls.Add(this.dtEndDate);
            this.Controls.Add(this.dtStartDate);
            this.Controls.Add(this.lblIsPublic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPeriodName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPeriod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "save";
            this.Load += new System.EventHandler(this.frmAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPeriodName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.Label lblIsPublic;
        private System.Windows.Forms.CheckBox cbIsPublic;
    }
}