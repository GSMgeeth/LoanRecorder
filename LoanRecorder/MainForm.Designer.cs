﻿namespace LoanRecorder
{
    partial class MainForm
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
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.dashboardTab = new System.Windows.Forms.TabPage();
            this.loanManagerTab = new System.Windows.Forms.TabPage();
            this.customerManagerTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.searchCustomerByNameTxtBox = new System.Windows.Forms.TextBox();
            this.showAllBtnCustMan = new System.Windows.Forms.Button();
            this.customerDataGrid = new System.Windows.Forms.DataGridView();
            this.otherTab = new System.Windows.Forms.TabPage();
            this.addCustPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newCustNameTxtBox = new System.Windows.Forms.TextBox();
            this.newCustNicTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.newCustTelTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.newCustAddressTxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addCustBtn = new System.Windows.Forms.Button();
            this.addCustClearBtn = new System.Windows.Forms.Button();
            this.updateCustPanel = new System.Windows.Forms.Panel();
            this.updateCustClearBtn = new System.Windows.Forms.Button();
            this.updateCustBtn = new System.Windows.Forms.Button();
            this.updateCustAddressTxtBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.updateCustTelTxtBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.updateCustNicTxtBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.updateCustNameTxtBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.searchLoanByCustTxtBox = new System.Windows.Forms.TextBox();
            this.loanShowAllBtn = new System.Windows.Forms.Button();
            this.loanDataGrid = new System.Windows.Forms.DataGridView();
            this.addLoanPanel = new System.Windows.Forms.Panel();
            this.clearIssueLoanBtn = new System.Windows.Forms.Button();
            this.issueLoanBtn = new System.Windows.Forms.Button();
            this.issueLoanAmountTxtBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.issueLoanCustNicTxtBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.newLoanLabel = new System.Windows.Forms.Label();
            this.issueLoanCustCmbBox = new System.Windows.Forms.ComboBox();
            this.issueLoanTypeCmbBox = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.issueLoanNoOfTermsTxtBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.issueLoanTermPaymentTxtBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.issueLoanGuarName1TxtBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.issueLoanGuarAddress1TxtBox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.issueLoanGuarAddress2TxtBox = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.issueLoanGuarName2TxtBox = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.mainTabControl.SuspendLayout();
            this.loanManagerTab.SuspendLayout();
            this.customerManagerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGrid)).BeginInit();
            this.addCustPanel.SuspendLayout();
            this.updateCustPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loanDataGrid)).BeginInit();
            this.addLoanPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabControl.Controls.Add(this.dashboardTab);
            this.mainTabControl.Controls.Add(this.loanManagerTab);
            this.mainTabControl.Controls.Add(this.customerManagerTab);
            this.mainTabControl.Controls.Add(this.otherTab);
            this.mainTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTabControl.Location = new System.Drawing.Point(12, 12);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1040, 657);
            this.mainTabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.mainTabControl.TabIndex = 0;
            // 
            // dashboardTab
            // 
            this.dashboardTab.BackColor = System.Drawing.Color.Gainsboro;
            this.dashboardTab.Location = new System.Drawing.Point(4, 29);
            this.dashboardTab.Name = "dashboardTab";
            this.dashboardTab.Padding = new System.Windows.Forms.Padding(3);
            this.dashboardTab.Size = new System.Drawing.Size(1032, 624);
            this.dashboardTab.TabIndex = 0;
            this.dashboardTab.Text = "Dashboard";
            // 
            // loanManagerTab
            // 
            this.loanManagerTab.BackColor = System.Drawing.Color.Gainsboro;
            this.loanManagerTab.Controls.Add(this.addLoanPanel);
            this.loanManagerTab.Controls.Add(this.label12);
            this.loanManagerTab.Controls.Add(this.searchLoanByCustTxtBox);
            this.loanManagerTab.Controls.Add(this.loanShowAllBtn);
            this.loanManagerTab.Controls.Add(this.loanDataGrid);
            this.loanManagerTab.Location = new System.Drawing.Point(4, 29);
            this.loanManagerTab.Name = "loanManagerTab";
            this.loanManagerTab.Padding = new System.Windows.Forms.Padding(3);
            this.loanManagerTab.Size = new System.Drawing.Size(1032, 624);
            this.loanManagerTab.TabIndex = 1;
            this.loanManagerTab.Text = "Loan Manager";
            // 
            // customerManagerTab
            // 
            this.customerManagerTab.BackColor = System.Drawing.Color.Gainsboro;
            this.customerManagerTab.Controls.Add(this.updateCustPanel);
            this.customerManagerTab.Controls.Add(this.addCustPanel);
            this.customerManagerTab.Controls.Add(this.label1);
            this.customerManagerTab.Controls.Add(this.searchCustomerByNameTxtBox);
            this.customerManagerTab.Controls.Add(this.showAllBtnCustMan);
            this.customerManagerTab.Controls.Add(this.customerDataGrid);
            this.customerManagerTab.Location = new System.Drawing.Point(4, 29);
            this.customerManagerTab.Name = "customerManagerTab";
            this.customerManagerTab.Padding = new System.Windows.Forms.Padding(3);
            this.customerManagerTab.Size = new System.Drawing.Size(1032, 624);
            this.customerManagerTab.TabIndex = 2;
            this.customerManagerTab.Text = "Customer Manager";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search By Cutomer Name : ";
            // 
            // searchCustomerByNameTxtBox
            // 
            this.searchCustomerByNameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCustomerByNameTxtBox.Location = new System.Drawing.Point(7, 278);
            this.searchCustomerByNameTxtBox.Name = "searchCustomerByNameTxtBox";
            this.searchCustomerByNameTxtBox.Size = new System.Drawing.Size(278, 26);
            this.searchCustomerByNameTxtBox.TabIndex = 2;
            // 
            // showAllBtnCustMan
            // 
            this.showAllBtnCustMan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showAllBtnCustMan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAllBtnCustMan.Location = new System.Drawing.Point(951, 281);
            this.showAllBtnCustMan.Name = "showAllBtnCustMan";
            this.showAllBtnCustMan.Size = new System.Drawing.Size(75, 23);
            this.showAllBtnCustMan.TabIndex = 1;
            this.showAllBtnCustMan.Text = "Show All";
            this.showAllBtnCustMan.UseVisualStyleBackColor = true;
            // 
            // customerDataGrid
            // 
            this.customerDataGrid.AllowUserToAddRows = false;
            this.customerDataGrid.AllowUserToDeleteRows = false;
            this.customerDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGrid.Location = new System.Drawing.Point(6, 310);
            this.customerDataGrid.Name = "customerDataGrid";
            this.customerDataGrid.ReadOnly = true;
            this.customerDataGrid.Size = new System.Drawing.Size(1020, 308);
            this.customerDataGrid.TabIndex = 0;
            // 
            // otherTab
            // 
            this.otherTab.BackColor = System.Drawing.Color.Gainsboro;
            this.otherTab.Location = new System.Drawing.Point(4, 29);
            this.otherTab.Name = "otherTab";
            this.otherTab.Padding = new System.Windows.Forms.Padding(3);
            this.otherTab.Size = new System.Drawing.Size(1032, 624);
            this.otherTab.TabIndex = 3;
            this.otherTab.Text = "Other";
            // 
            // addCustPanel
            // 
            this.addCustPanel.BackColor = System.Drawing.Color.DarkGray;
            this.addCustPanel.Controls.Add(this.addCustClearBtn);
            this.addCustPanel.Controls.Add(this.addCustBtn);
            this.addCustPanel.Controls.Add(this.newCustAddressTxtBox);
            this.addCustPanel.Controls.Add(this.label6);
            this.addCustPanel.Controls.Add(this.newCustTelTxtBox);
            this.addCustPanel.Controls.Add(this.label5);
            this.addCustPanel.Controls.Add(this.newCustNicTxtBox);
            this.addCustPanel.Controls.Add(this.label4);
            this.addCustPanel.Controls.Add(this.newCustNameTxtBox);
            this.addCustPanel.Controls.Add(this.label3);
            this.addCustPanel.Controls.Add(this.label2);
            this.addCustPanel.Location = new System.Drawing.Point(7, 7);
            this.addCustPanel.Name = "addCustPanel";
            this.addCustPanel.Size = new System.Drawing.Size(484, 234);
            this.addCustPanel.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Add Customer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name : ";
            // 
            // newCustNameTxtBox
            // 
            this.newCustNameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCustNameTxtBox.Location = new System.Drawing.Point(111, 47);
            this.newCustNameTxtBox.Name = "newCustNameTxtBox";
            this.newCustNameTxtBox.Size = new System.Drawing.Size(370, 26);
            this.newCustNameTxtBox.TabIndex = 2;
            // 
            // newCustNicTxtBox
            // 
            this.newCustNicTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCustNicTxtBox.Location = new System.Drawing.Point(111, 79);
            this.newCustNicTxtBox.Name = "newCustNicTxtBox";
            this.newCustNicTxtBox.Size = new System.Drawing.Size(370, 26);
            this.newCustNicTxtBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "NIC : ";
            // 
            // newCustTelTxtBox
            // 
            this.newCustTelTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCustTelTxtBox.Location = new System.Drawing.Point(111, 111);
            this.newCustTelTxtBox.Name = "newCustTelTxtBox";
            this.newCustTelTxtBox.Size = new System.Drawing.Size(370, 26);
            this.newCustTelTxtBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Telephone : ";
            // 
            // newCustAddressTxtBox
            // 
            this.newCustAddressTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCustAddressTxtBox.Location = new System.Drawing.Point(111, 143);
            this.newCustAddressTxtBox.Name = "newCustAddressTxtBox";
            this.newCustAddressTxtBox.Size = new System.Drawing.Size(370, 26);
            this.newCustAddressTxtBox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Address : ";
            // 
            // addCustBtn
            // 
            this.addCustBtn.BackColor = System.Drawing.Color.LightGreen;
            this.addCustBtn.Location = new System.Drawing.Point(344, 200);
            this.addCustBtn.Name = "addCustBtn";
            this.addCustBtn.Size = new System.Drawing.Size(137, 31);
            this.addCustBtn.TabIndex = 9;
            this.addCustBtn.Text = "Add Customer";
            this.addCustBtn.UseVisualStyleBackColor = false;
            // 
            // addCustClearBtn
            // 
            this.addCustClearBtn.BackColor = System.Drawing.Color.LightCoral;
            this.addCustClearBtn.Location = new System.Drawing.Point(3, 200);
            this.addCustClearBtn.Name = "addCustClearBtn";
            this.addCustClearBtn.Size = new System.Drawing.Size(137, 31);
            this.addCustClearBtn.TabIndex = 10;
            this.addCustClearBtn.Text = "Clear";
            this.addCustClearBtn.UseVisualStyleBackColor = false;
            // 
            // updateCustPanel
            // 
            this.updateCustPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updateCustPanel.BackColor = System.Drawing.Color.DarkGray;
            this.updateCustPanel.Controls.Add(this.updateCustClearBtn);
            this.updateCustPanel.Controls.Add(this.updateCustBtn);
            this.updateCustPanel.Controls.Add(this.updateCustAddressTxtBox);
            this.updateCustPanel.Controls.Add(this.label7);
            this.updateCustPanel.Controls.Add(this.updateCustTelTxtBox);
            this.updateCustPanel.Controls.Add(this.label8);
            this.updateCustPanel.Controls.Add(this.updateCustNicTxtBox);
            this.updateCustPanel.Controls.Add(this.label9);
            this.updateCustPanel.Controls.Add(this.updateCustNameTxtBox);
            this.updateCustPanel.Controls.Add(this.label10);
            this.updateCustPanel.Controls.Add(this.label11);
            this.updateCustPanel.Location = new System.Drawing.Point(542, 7);
            this.updateCustPanel.Name = "updateCustPanel";
            this.updateCustPanel.Size = new System.Drawing.Size(484, 234);
            this.updateCustPanel.TabIndex = 5;
            // 
            // updateCustClearBtn
            // 
            this.updateCustClearBtn.BackColor = System.Drawing.Color.LightCoral;
            this.updateCustClearBtn.Location = new System.Drawing.Point(3, 200);
            this.updateCustClearBtn.Name = "updateCustClearBtn";
            this.updateCustClearBtn.Size = new System.Drawing.Size(137, 31);
            this.updateCustClearBtn.TabIndex = 10;
            this.updateCustClearBtn.Text = "Clear";
            this.updateCustClearBtn.UseVisualStyleBackColor = false;
            // 
            // updateCustBtn
            // 
            this.updateCustBtn.BackColor = System.Drawing.Color.LightGreen;
            this.updateCustBtn.Location = new System.Drawing.Point(301, 200);
            this.updateCustBtn.Name = "updateCustBtn";
            this.updateCustBtn.Size = new System.Drawing.Size(180, 31);
            this.updateCustBtn.TabIndex = 9;
            this.updateCustBtn.Text = "Update Customer";
            this.updateCustBtn.UseVisualStyleBackColor = false;
            // 
            // updateCustAddressTxtBox
            // 
            this.updateCustAddressTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCustAddressTxtBox.Location = new System.Drawing.Point(111, 143);
            this.updateCustAddressTxtBox.Name = "updateCustAddressTxtBox";
            this.updateCustAddressTxtBox.Size = new System.Drawing.Size(370, 26);
            this.updateCustAddressTxtBox.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Address : ";
            // 
            // updateCustTelTxtBox
            // 
            this.updateCustTelTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCustTelTxtBox.Location = new System.Drawing.Point(111, 111);
            this.updateCustTelTxtBox.Name = "updateCustTelTxtBox";
            this.updateCustTelTxtBox.Size = new System.Drawing.Size(370, 26);
            this.updateCustTelTxtBox.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Telephone : ";
            // 
            // updateCustNicTxtBox
            // 
            this.updateCustNicTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCustNicTxtBox.Location = new System.Drawing.Point(111, 79);
            this.updateCustNicTxtBox.Name = "updateCustNicTxtBox";
            this.updateCustNicTxtBox.Size = new System.Drawing.Size(370, 26);
            this.updateCustNicTxtBox.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "NIC : ";
            // 
            // updateCustNameTxtBox
            // 
            this.updateCustNameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCustNameTxtBox.Location = new System.Drawing.Point(111, 47);
            this.updateCustNameTxtBox.Name = "updateCustNameTxtBox";
            this.updateCustNameTxtBox.Size = new System.Drawing.Size(370, 26);
            this.updateCustNameTxtBox.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Name : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(177, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Update Customer";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 259);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(197, 16);
            this.label12.TabIndex = 7;
            this.label12.Text = "Search By Cutomer Name : ";
            // 
            // searchLoanByCustTxtBox
            // 
            this.searchLoanByCustTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLoanByCustTxtBox.Location = new System.Drawing.Point(7, 278);
            this.searchLoanByCustTxtBox.Name = "searchLoanByCustTxtBox";
            this.searchLoanByCustTxtBox.Size = new System.Drawing.Size(278, 26);
            this.searchLoanByCustTxtBox.TabIndex = 6;
            // 
            // loanShowAllBtn
            // 
            this.loanShowAllBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loanShowAllBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanShowAllBtn.Location = new System.Drawing.Point(951, 281);
            this.loanShowAllBtn.Name = "loanShowAllBtn";
            this.loanShowAllBtn.Size = new System.Drawing.Size(75, 23);
            this.loanShowAllBtn.TabIndex = 5;
            this.loanShowAllBtn.Text = "Show All";
            this.loanShowAllBtn.UseVisualStyleBackColor = true;
            // 
            // loanDataGrid
            // 
            this.loanDataGrid.AllowUserToAddRows = false;
            this.loanDataGrid.AllowUserToDeleteRows = false;
            this.loanDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loanDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.loanDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loanDataGrid.Location = new System.Drawing.Point(6, 310);
            this.loanDataGrid.Name = "loanDataGrid";
            this.loanDataGrid.ReadOnly = true;
            this.loanDataGrid.Size = new System.Drawing.Size(1020, 308);
            this.loanDataGrid.TabIndex = 4;
            // 
            // addLoanPanel
            // 
            this.addLoanPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addLoanPanel.BackColor = System.Drawing.Color.DarkGray;
            this.addLoanPanel.Controls.Add(this.issueLoanGuarAddress2TxtBox);
            this.addLoanPanel.Controls.Add(this.label22);
            this.addLoanPanel.Controls.Add(this.issueLoanGuarName2TxtBox);
            this.addLoanPanel.Controls.Add(this.label23);
            this.addLoanPanel.Controls.Add(this.issueLoanGuarAddress1TxtBox);
            this.addLoanPanel.Controls.Add(this.label21);
            this.addLoanPanel.Controls.Add(this.issueLoanGuarName1TxtBox);
            this.addLoanPanel.Controls.Add(this.label20);
            this.addLoanPanel.Controls.Add(this.issueLoanTermPaymentTxtBox);
            this.addLoanPanel.Controls.Add(this.label19);
            this.addLoanPanel.Controls.Add(this.issueLoanNoOfTermsTxtBox);
            this.addLoanPanel.Controls.Add(this.label18);
            this.addLoanPanel.Controls.Add(this.dateTimePicker1);
            this.addLoanPanel.Controls.Add(this.issueLoanTypeCmbBox);
            this.addLoanPanel.Controls.Add(this.label17);
            this.addLoanPanel.Controls.Add(this.issueLoanCustCmbBox);
            this.addLoanPanel.Controls.Add(this.clearIssueLoanBtn);
            this.addLoanPanel.Controls.Add(this.issueLoanBtn);
            this.addLoanPanel.Controls.Add(this.issueLoanAmountTxtBox);
            this.addLoanPanel.Controls.Add(this.label13);
            this.addLoanPanel.Controls.Add(this.label14);
            this.addLoanPanel.Controls.Add(this.issueLoanCustNicTxtBox);
            this.addLoanPanel.Controls.Add(this.label15);
            this.addLoanPanel.Controls.Add(this.label16);
            this.addLoanPanel.Controls.Add(this.newLoanLabel);
            this.addLoanPanel.Location = new System.Drawing.Point(6, 6);
            this.addLoanPanel.Name = "addLoanPanel";
            this.addLoanPanel.Size = new System.Drawing.Size(1020, 234);
            this.addLoanPanel.TabIndex = 8;
            // 
            // clearIssueLoanBtn
            // 
            this.clearIssueLoanBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearIssueLoanBtn.BackColor = System.Drawing.Color.LightCoral;
            this.clearIssueLoanBtn.Location = new System.Drawing.Point(737, 200);
            this.clearIssueLoanBtn.Name = "clearIssueLoanBtn";
            this.clearIssueLoanBtn.Size = new System.Drawing.Size(137, 31);
            this.clearIssueLoanBtn.TabIndex = 10;
            this.clearIssueLoanBtn.Text = "Clear";
            this.clearIssueLoanBtn.UseVisualStyleBackColor = false;
            // 
            // issueLoanBtn
            // 
            this.issueLoanBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.issueLoanBtn.BackColor = System.Drawing.Color.LightGreen;
            this.issueLoanBtn.Location = new System.Drawing.Point(880, 200);
            this.issueLoanBtn.Name = "issueLoanBtn";
            this.issueLoanBtn.Size = new System.Drawing.Size(137, 31);
            this.issueLoanBtn.TabIndex = 9;
            this.issueLoanBtn.Text = "Issue Loan";
            this.issueLoanBtn.UseVisualStyleBackColor = false;
            // 
            // issueLoanAmountTxtBox
            // 
            this.issueLoanAmountTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueLoanAmountTxtBox.Location = new System.Drawing.Point(111, 143);
            this.issueLoanAmountTxtBox.Name = "issueLoanAmountTxtBox";
            this.issueLoanAmountTxtBox.Size = new System.Drawing.Size(234, 22);
            this.issueLoanAmountTxtBox.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(4, 143);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 20);
            this.label13.TabIndex = 7;
            this.label13.Text = "Amount : ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(4, 111);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 20);
            this.label14.TabIndex = 5;
            this.label14.Text = "Releas Date : ";
            // 
            // issueLoanCustNicTxtBox
            // 
            this.issueLoanCustNicTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueLoanCustNicTxtBox.Location = new System.Drawing.Point(111, 79);
            this.issueLoanCustNicTxtBox.Name = "issueLoanCustNicTxtBox";
            this.issueLoanCustNicTxtBox.ReadOnly = true;
            this.issueLoanCustNicTxtBox.Size = new System.Drawing.Size(234, 22);
            this.issueLoanCustNicTxtBox.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(4, 79);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 20);
            this.label15.TabIndex = 3;
            this.label15.Text = "NIC : ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(4, 47);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 20);
            this.label16.TabIndex = 1;
            this.label16.Text = "Customer : ";
            // 
            // newLoanLabel
            // 
            this.newLoanLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.newLoanLabel.AutoSize = true;
            this.newLoanLabel.Location = new System.Drawing.Point(470, 9);
            this.newLoanLabel.Name = "newLoanLabel";
            this.newLoanLabel.Size = new System.Drawing.Size(98, 20);
            this.newLoanLabel.TabIndex = 0;
            this.newLoanLabel.Text = "Issue Loan";
            // 
            // issueLoanCustCmbBox
            // 
            this.issueLoanCustCmbBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueLoanCustCmbBox.FormattingEnabled = true;
            this.issueLoanCustCmbBox.Location = new System.Drawing.Point(111, 45);
            this.issueLoanCustCmbBox.Name = "issueLoanCustCmbBox";
            this.issueLoanCustCmbBox.Size = new System.Drawing.Size(234, 24);
            this.issueLoanCustCmbBox.TabIndex = 11;
            // 
            // issueLoanTypeCmbBox
            // 
            this.issueLoanTypeCmbBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueLoanTypeCmbBox.FormattingEnabled = true;
            this.issueLoanTypeCmbBox.Location = new System.Drawing.Point(111, 175);
            this.issueLoanTypeCmbBox.Name = "issueLoanTypeCmbBox";
            this.issueLoanTypeCmbBox.Size = new System.Drawing.Size(234, 24);
            this.issueLoanTypeCmbBox.TabIndex = 13;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(4, 177);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 20);
            this.label17.TabIndex = 12;
            this.label17.Text = "Type : ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(111, 111);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(234, 22);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // issueLoanNoOfTermsTxtBox
            // 
            this.issueLoanNoOfTermsTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueLoanNoOfTermsTxtBox.Location = new System.Drawing.Point(480, 47);
            this.issueLoanNoOfTermsTxtBox.Name = "issueLoanNoOfTermsTxtBox";
            this.issueLoanNoOfTermsTxtBox.Size = new System.Drawing.Size(65, 22);
            this.issueLoanNoOfTermsTxtBox.TabIndex = 16;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(351, 47);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(107, 20);
            this.label18.TabIndex = 15;
            this.label18.Text = "No of Terms : ";
            // 
            // issueLoanTermPaymentTxtBox
            // 
            this.issueLoanTermPaymentTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueLoanTermPaymentTxtBox.Location = new System.Drawing.Point(480, 79);
            this.issueLoanTermPaymentTxtBox.Name = "issueLoanTermPaymentTxtBox";
            this.issueLoanTermPaymentTxtBox.Size = new System.Drawing.Size(65, 22);
            this.issueLoanTermPaymentTxtBox.TabIndex = 18;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(351, 79);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(123, 20);
            this.label19.TabIndex = 17;
            this.label19.Text = "Term Payment : ";
            // 
            // issueLoanGuarName1TxtBox
            // 
            this.issueLoanGuarName1TxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.issueLoanGuarName1TxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueLoanGuarName1TxtBox.Location = new System.Drawing.Point(800, 47);
            this.issueLoanGuarName1TxtBox.Name = "issueLoanGuarName1TxtBox";
            this.issueLoanGuarName1TxtBox.Size = new System.Drawing.Size(217, 22);
            this.issueLoanGuarName1TxtBox.TabIndex = 20;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(637, 47);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(140, 20);
            this.label20.TabIndex = 19;
            this.label20.Text = "Guarantor Name : ";
            // 
            // issueLoanGuarAddress1TxtBox
            // 
            this.issueLoanGuarAddress1TxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.issueLoanGuarAddress1TxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueLoanGuarAddress1TxtBox.Location = new System.Drawing.Point(800, 75);
            this.issueLoanGuarAddress1TxtBox.Name = "issueLoanGuarAddress1TxtBox";
            this.issueLoanGuarAddress1TxtBox.Size = new System.Drawing.Size(217, 22);
            this.issueLoanGuarAddress1TxtBox.TabIndex = 22;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(637, 75);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(157, 20);
            this.label21.TabIndex = 21;
            this.label21.Text = "Guarantor Address : ";
            // 
            // issueLoanGuarAddress2TxtBox
            // 
            this.issueLoanGuarAddress2TxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.issueLoanGuarAddress2TxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueLoanGuarAddress2TxtBox.Location = new System.Drawing.Point(800, 137);
            this.issueLoanGuarAddress2TxtBox.Name = "issueLoanGuarAddress2TxtBox";
            this.issueLoanGuarAddress2TxtBox.Size = new System.Drawing.Size(217, 22);
            this.issueLoanGuarAddress2TxtBox.TabIndex = 26;
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(637, 137);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(157, 20);
            this.label22.TabIndex = 25;
            this.label22.Text = "Guarantor Address : ";
            // 
            // issueLoanGuarName2TxtBox
            // 
            this.issueLoanGuarName2TxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.issueLoanGuarName2TxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueLoanGuarName2TxtBox.Location = new System.Drawing.Point(800, 109);
            this.issueLoanGuarName2TxtBox.Name = "issueLoanGuarName2TxtBox";
            this.issueLoanGuarName2TxtBox.Size = new System.Drawing.Size(217, 22);
            this.issueLoanGuarName2TxtBox.TabIndex = 24;
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(637, 109);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(140, 20);
            this.label23.TabIndex = 23;
            this.label23.Text = "Guarantor Name : ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.mainTabControl);
            this.MinimumSize = new System.Drawing.Size(1080, 720);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan Recorder";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.mainTabControl.ResumeLayout(false);
            this.loanManagerTab.ResumeLayout(false);
            this.loanManagerTab.PerformLayout();
            this.customerManagerTab.ResumeLayout(false);
            this.customerManagerTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGrid)).EndInit();
            this.addCustPanel.ResumeLayout(false);
            this.addCustPanel.PerformLayout();
            this.updateCustPanel.ResumeLayout(false);
            this.updateCustPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loanDataGrid)).EndInit();
            this.addLoanPanel.ResumeLayout(false);
            this.addLoanPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage dashboardTab;
        private System.Windows.Forms.TabPage loanManagerTab;
        private System.Windows.Forms.TabPage customerManagerTab;
        private System.Windows.Forms.TabPage otherTab;
        private System.Windows.Forms.DataGridView customerDataGrid;
        private System.Windows.Forms.Button showAllBtnCustMan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchCustomerByNameTxtBox;
        private System.Windows.Forms.Panel addCustPanel;
        private System.Windows.Forms.TextBox newCustNicTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox newCustNameTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newCustTelTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox newCustAddressTxtBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addCustClearBtn;
        private System.Windows.Forms.Button addCustBtn;
        private System.Windows.Forms.Panel updateCustPanel;
        private System.Windows.Forms.Button updateCustClearBtn;
        private System.Windows.Forms.Button updateCustBtn;
        private System.Windows.Forms.TextBox updateCustAddressTxtBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox updateCustTelTxtBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox updateCustNicTxtBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox updateCustNameTxtBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox searchLoanByCustTxtBox;
        private System.Windows.Forms.Button loanShowAllBtn;
        private System.Windows.Forms.DataGridView loanDataGrid;
        private System.Windows.Forms.Panel addLoanPanel;
        private System.Windows.Forms.Button clearIssueLoanBtn;
        private System.Windows.Forms.Button issueLoanBtn;
        private System.Windows.Forms.TextBox issueLoanAmountTxtBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox issueLoanCustNicTxtBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label newLoanLabel;
        private System.Windows.Forms.ComboBox issueLoanCustCmbBox;
        private System.Windows.Forms.ComboBox issueLoanTypeCmbBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox issueLoanGuarAddress1TxtBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox issueLoanGuarName1TxtBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox issueLoanTermPaymentTxtBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox issueLoanNoOfTermsTxtBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox issueLoanGuarAddress2TxtBox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox issueLoanGuarName2TxtBox;
        private System.Windows.Forms.Label label23;
    }
}

