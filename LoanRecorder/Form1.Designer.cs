namespace LoanRecorder
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
            this.mainTabControl.SuspendLayout();
            this.customerManagerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGrid)).BeginInit();
            this.addCustPanel.SuspendLayout();
            this.updateCustPanel.SuspendLayout();
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
            this.newCustNameTxtBox.Location = new System.Drawing.Point(111, 47);
            this.newCustNameTxtBox.Name = "newCustNameTxtBox";
            this.newCustNameTxtBox.Size = new System.Drawing.Size(370, 26);
            this.newCustNameTxtBox.TabIndex = 2;
            // 
            // newCustNicTxtBox
            // 
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.mainTabControl);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan Recorder";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.mainTabControl.ResumeLayout(false);
            this.customerManagerTab.ResumeLayout(false);
            this.customerManagerTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGrid)).EndInit();
            this.addCustPanel.ResumeLayout(false);
            this.addCustPanel.PerformLayout();
            this.updateCustPanel.ResumeLayout(false);
            this.updateCustPanel.PerformLayout();
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
    }
}

