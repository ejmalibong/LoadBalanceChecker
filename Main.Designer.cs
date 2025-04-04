
namespace LoadBalanceChecker
{
    partial class Main
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
            this.lblScan = new System.Windows.Forms.Label();
            this.txtQrCodeInput = new System.Windows.Forms.TextBox();
            this.chkDateRange = new System.Windows.Forms.CheckBox();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.lblCurBalance = new System.Windows.Forms.Label();
            this.txtCurBalance = new System.Windows.Forms.Label();
            this.lsvItem = new System.Windows.Forms.ListView();
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colReceipt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtUseLoad = new System.Windows.Forms.Label();
            this.lblUseLoad = new System.Windows.Forms.Label();
            this.txtDeduction = new System.Windows.Forms.Label();
            this.lblDeduction = new System.Windows.Forms.Label();
            this.txtPurchase = new System.Windows.Forms.Label();
            this.lblPurchase = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblNote = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblScan
            // 
            this.lblScan.AutoSize = true;
            this.lblScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScan.Location = new System.Drawing.Point(21, 20);
            this.lblScan.Name = "lblScan";
            this.lblScan.Size = new System.Drawing.Size(160, 25);
            this.lblScan.TabIndex = 0;
            this.lblScan.Text = "SCAN YOUR ID:";
            // 
            // txtQrCodeInput
            // 
            this.txtQrCodeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQrCodeInput.Location = new System.Drawing.Point(26, 48);
            this.txtQrCodeInput.Name = "txtQrCodeInput";
            this.txtQrCodeInput.Size = new System.Drawing.Size(300, 30);
            this.txtQrCodeInput.TabIndex = 1;
            this.txtQrCodeInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQrCodeInput_KeyDown);
            // 
            // chkDateRange
            // 
            this.chkDateRange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDateRange.AutoSize = true;
            this.chkDateRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDateRange.Location = new System.Drawing.Point(630, 54);
            this.chkDateRange.Name = "chkDateRange";
            this.chkDateRange.Size = new System.Drawing.Size(128, 28);
            this.chkDateRange.TabIndex = 2;
            this.chkDateRange.Text = "Date Range";
            this.chkDateRange.UseVisualStyleBackColor = true;
            this.chkDateRange.CheckedChanged += new System.EventHandler(this.chkDateRange_CheckedChanged);
            // 
            // dtStart
            // 
            this.dtStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtStart.CustomFormat = "dddd MMM dd, yyyy";
            this.dtStart.Enabled = false;
            this.dtStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStart.Location = new System.Drawing.Point(762, 51);
            this.dtStart.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(256, 29);
            this.dtStart.TabIndex = 3;
            // 
            // dtEnd
            // 
            this.dtEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtEnd.CustomFormat = "dddd MMM dd, yyyy";
            this.dtEnd.Enabled = false;
            this.dtEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEnd.Location = new System.Drawing.Point(1024, 51);
            this.dtEnd.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(256, 29);
            this.dtEnd.TabIndex = 4;
            // 
            // lblCurBalance
            // 
            this.lblCurBalance.AutoSize = true;
            this.lblCurBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurBalance.Location = new System.Drawing.Point(21, 99);
            this.lblCurBalance.Name = "lblCurBalance";
            this.lblCurBalance.Size = new System.Drawing.Size(272, 25);
            this.lblCurBalance.TabIndex = 6;
            this.lblCurBalance.Text = "CURRENT LOAD BALANCE:";
            // 
            // txtCurBalance
            // 
            this.txtCurBalance.AutoSize = true;
            this.txtCurBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurBalance.Location = new System.Drawing.Point(299, 99);
            this.txtCurBalance.Name = "txtCurBalance";
            this.txtCurBalance.Size = new System.Drawing.Size(54, 25);
            this.txtCurBalance.TabIndex = 7;
            this.txtCurBalance.Text = "0.00";
            // 
            // lsvItem
            // 
            this.lsvItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsvItem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDate,
            this.colName,
            this.colReceipt,
            this.colProductName,
            this.colPrice,
            this.colQty,
            this.colAmount,
            this.colType});
            this.lsvItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvItem.FullRowSelect = true;
            this.lsvItem.GridLines = true;
            this.lsvItem.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsvItem.HideSelection = false;
            this.lsvItem.Location = new System.Drawing.Point(26, 130);
            this.lsvItem.MultiSelect = false;
            this.lsvItem.Name = "lsvItem";
            this.lsvItem.ShowGroups = false;
            this.lsvItem.Size = new System.Drawing.Size(1253, 422);
            this.lsvItem.TabIndex = 8;
            this.lsvItem.TabStop = false;
            this.lsvItem.UseCompatibleStateImageBehavior = false;
            this.lsvItem.View = System.Windows.Forms.View.Details;
            // 
            // colDate
            // 
            this.colDate.Tag = "2";
            this.colDate.Text = "Date";
            this.colDate.Width = 150;
            // 
            // colName
            // 
            this.colName.Tag = "2";
            this.colName.Text = "Name ";
            this.colName.Width = 230;
            // 
            // colReceipt
            // 
            this.colReceipt.Tag = "1";
            this.colReceipt.Text = "Receipt No";
            this.colReceipt.Width = 100;
            // 
            // colProductName
            // 
            this.colProductName.Tag = "3";
            this.colProductName.Text = "Product Name";
            this.colProductName.Width = 250;
            // 
            // colPrice
            // 
            this.colPrice.Tag = "1";
            this.colPrice.Text = "Price";
            this.colPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colPrice.Width = 80;
            // 
            // colQty
            // 
            this.colQty.Tag = "1";
            this.colQty.Text = "Qty";
            this.colQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colQty.Width = 80;
            // 
            // colAmount
            // 
            this.colAmount.Tag = "1";
            this.colAmount.Text = "Amount";
            this.colAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colAmount.Width = 80;
            // 
            // colType
            // 
            this.colType.Tag = "4";
            this.colType.Text = "Type";
            this.colType.Width = 150;
            // 
            // txtUseLoad
            // 
            this.txtUseLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtUseLoad.AutoSize = true;
            this.txtUseLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUseLoad.Location = new System.Drawing.Point(178, 563);
            this.txtUseLoad.Name = "txtUseLoad";
            this.txtUseLoad.Size = new System.Drawing.Size(50, 25);
            this.txtUseLoad.TabIndex = 10;
            this.txtUseLoad.Text = "0.00";
            // 
            // lblUseLoad
            // 
            this.lblUseLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUseLoad.AutoSize = true;
            this.lblUseLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUseLoad.Location = new System.Drawing.Point(21, 563);
            this.lblUseLoad.Name = "lblUseLoad";
            this.lblUseLoad.Size = new System.Drawing.Size(151, 25);
            this.lblUseLoad.TabIndex = 9;
            this.lblUseLoad.Text = "Total Use Load:";
            // 
            // txtDeduction
            // 
            this.txtDeduction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDeduction.AutoSize = true;
            this.txtDeduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeduction.Location = new System.Drawing.Point(708, 563);
            this.txtDeduction.Name = "txtDeduction";
            this.txtDeduction.Size = new System.Drawing.Size(50, 25);
            this.txtDeduction.TabIndex = 12;
            this.txtDeduction.Text = "0.00";
            // 
            // lblDeduction
            // 
            this.lblDeduction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDeduction.AutoSize = true;
            this.lblDeduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeduction.Location = new System.Drawing.Point(486, 563);
            this.lblDeduction.Name = "lblDeduction";
            this.lblDeduction.Size = new System.Drawing.Size(216, 25);
            this.lblDeduction.TabIndex = 11;
            this.lblDeduction.Text = "Total Salary Deduction:";
            // 
            // txtPurchase
            // 
            this.txtPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPurchase.AutoSize = true;
            this.txtPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurchase.Location = new System.Drawing.Point(1190, 563);
            this.txtPurchase.Name = "txtPurchase";
            this.txtPurchase.Size = new System.Drawing.Size(50, 25);
            this.txtPurchase.TabIndex = 14;
            this.txtPurchase.Text = "0.00";
            // 
            // lblPurchase
            // 
            this.lblPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPurchase.AutoSize = true;
            this.lblPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchase.Location = new System.Drawing.Point(961, 563);
            this.lblPurchase.Name = "lblPurchase";
            this.lblPurchase.Size = new System.Drawing.Size(234, 25);
            this.lblPurchase.TabIndex = 13;
            this.lblPurchase.Text = "Total Amount Purchased:";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1109, 596);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(171, 55);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(932, 596);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(171, 55);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblNote
            // 
            this.lblNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.Color.Red;
            this.lblNote.Location = new System.Drawing.Point(747, 27);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(545, 18);
            this.lblNote.TabIndex = 17;
            this.lblNote.Text = "Note: Select the preferred period for date range searches before scanning your ID" +
    ".";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1304, 656);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtPurchase);
            this.Controls.Add(this.lblPurchase);
            this.Controls.Add(this.txtDeduction);
            this.Controls.Add(this.lblDeduction);
            this.Controls.Add(this.txtUseLoad);
            this.Controls.Add(this.lblUseLoad);
            this.Controls.Add(this.lsvItem);
            this.Controls.Add(this.txtCurBalance);
            this.Controls.Add(this.lblCurBalance);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.chkDateRange);
            this.Controls.Add(this.txtQrCodeInput);
            this.Controls.Add(this.lblScan);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Canteen Purchases Viewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScan;
        private System.Windows.Forms.TextBox txtQrCodeInput;
        private System.Windows.Forms.CheckBox chkDateRange;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.Label lblCurBalance;
        private System.Windows.Forms.Label txtCurBalance;
        private System.Windows.Forms.ListView lsvItem;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colReceipt;
        private System.Windows.Forms.ColumnHeader colProductName;
        private System.Windows.Forms.ColumnHeader colPrice;
        private System.Windows.Forms.ColumnHeader colQty;
        private System.Windows.Forms.ColumnHeader colAmount;
        private System.Windows.Forms.ColumnHeader colType;
        private System.Windows.Forms.Label txtUseLoad;
        private System.Windows.Forms.Label lblUseLoad;
        private System.Windows.Forms.Label txtDeduction;
        private System.Windows.Forms.Label lblDeduction;
        private System.Windows.Forms.Label txtPurchase;
        private System.Windows.Forms.Label lblPurchase;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblNote;
    }
}

