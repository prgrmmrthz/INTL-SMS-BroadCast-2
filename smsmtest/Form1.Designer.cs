namespace smsmtest
{
    partial class Form1
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
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtCom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.lvLogs = new System.Windows.Forms.ListView();
            this.log = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSendAll = new System.Windows.Forms.Button();
            this.btnLoadContacts = new System.Windows.Forms.Button();
            this.dgvPhoneNumber = new System.Windows.Forms.DataGridView();
            this.btnConnect = new System.Windows.Forms.Button();
            this.chkUnicode = new System.Windows.Forms.CheckBox();
            this.btnClearLogs = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDBTable = new System.Windows.Forms.ComboBox();
            this.btnClearDGV = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhoneNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(98, 46);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(259, 20);
            this.txtNum.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(98, 194);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCom
            // 
            this.txtCom.Location = new System.Drawing.Point(948, 6);
            this.txtCom.Name = "txtCom";
            this.txtCom.Size = new System.Drawing.Size(235, 20);
            this.txtCom.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Message";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(893, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Com Port";
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(98, 84);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(1085, 104);
            this.txtMsg.TabIndex = 1;
            // 
            // lvLogs
            // 
            this.lvLogs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.log});
            this.lvLogs.Location = new System.Drawing.Point(28, 230);
            this.lvLogs.Margin = new System.Windows.Forms.Padding(2);
            this.lvLogs.Name = "lvLogs";
            this.lvLogs.Size = new System.Drawing.Size(910, 418);
            this.lvLogs.TabIndex = 7;
            this.lvLogs.UseCompatibleStateImageBehavior = false;
            this.lvLogs.View = System.Windows.Forms.View.Details;
            this.lvLogs.SelectedIndexChanged += new System.EventHandler(this.lvLogs_SelectedIndexChanged);
            // 
            // log
            // 
            this.log.Text = "Logs";
            this.log.Width = 600;
            // 
            // btnSendAll
            // 
            this.btnSendAll.Location = new System.Drawing.Point(1029, 250);
            this.btnSendAll.Name = "btnSendAll";
            this.btnSendAll.Size = new System.Drawing.Size(154, 23);
            this.btnSendAll.TabIndex = 8;
            this.btnSendAll.Text = "Send ALL";
            this.btnSendAll.UseVisualStyleBackColor = true;
            this.btnSendAll.Click += new System.EventHandler(this.btnSendAll_Click);
            // 
            // btnLoadContacts
            // 
            this.btnLoadContacts.Location = new System.Drawing.Point(1091, 221);
            this.btnLoadContacts.Name = "btnLoadContacts";
            this.btnLoadContacts.Size = new System.Drawing.Size(92, 23);
            this.btnLoadContacts.TabIndex = 9;
            this.btnLoadContacts.Text = "Load Contacts";
            this.btnLoadContacts.UseVisualStyleBackColor = true;
            this.btnLoadContacts.Click += new System.EventHandler(this.btnLoadContacts_Click);
            // 
            // dgvPhoneNumber
            // 
            this.dgvPhoneNumber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhoneNumber.Location = new System.Drawing.Point(942, 278);
            this.dgvPhoneNumber.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPhoneNumber.Name = "dgvPhoneNumber";
            this.dgvPhoneNumber.RowTemplate.Height = 24;
            this.dgvPhoneNumber.Size = new System.Drawing.Size(241, 370);
            this.dgvPhoneNumber.TabIndex = 10;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(1108, 32);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 11;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // chkUnicode
            // 
            this.chkUnicode.AutoSize = true;
            this.chkUnicode.Location = new System.Drawing.Point(179, 196);
            this.chkUnicode.Name = "chkUnicode";
            this.chkUnicode.Size = new System.Drawing.Size(66, 17);
            this.chkUnicode.TabIndex = 12;
            this.chkUnicode.Text = "Unicode";
            this.chkUnicode.UseVisualStyleBackColor = true;
            // 
            // btnClearLogs
            // 
            this.btnClearLogs.Location = new System.Drawing.Point(863, 202);
            this.btnClearLogs.Name = "btnClearLogs";
            this.btnClearLogs.Size = new System.Drawing.Size(75, 23);
            this.btnClearLogs.TabIndex = 13;
            this.btnClearLogs.Text = "Clear Logs";
            this.btnClearLogs.UseVisualStyleBackColor = true;
            this.btnClearLogs.Click += new System.EventHandler(this.btnClearLogs_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(941, 197);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "DB Table";
            // 
            // cmbDBTable
            // 
            this.cmbDBTable.FormattingEnabled = true;
            this.cmbDBTable.Items.AddRange(new object[] {
            "testphonenumbers",
            "phonenumbers"});
            this.cmbDBTable.Location = new System.Drawing.Point(998, 194);
            this.cmbDBTable.Name = "cmbDBTable";
            this.cmbDBTable.Size = new System.Drawing.Size(185, 21);
            this.cmbDBTable.TabIndex = 14;
            this.cmbDBTable.SelectedIndexChanged += new System.EventHandler(this.cmbDBTable_SelectedIndexChanged);
            // 
            // btnClearDGV
            // 
            this.btnClearDGV.Location = new System.Drawing.Point(944, 250);
            this.btnClearDGV.Name = "btnClearDGV";
            this.btnClearDGV.Size = new System.Drawing.Size(79, 23);
            this.btnClearDGV.TabIndex = 16;
            this.btnClearDGV.Text = "Clear";
            this.btnClearDGV.UseVisualStyleBackColor = true;
            this.btnClearDGV.Click += new System.EventHandler(this.btnClearDGV_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(1027, 32);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 17;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 668);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnClearDGV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbDBTable);
            this.Controls.Add(this.btnClearLogs);
            this.Controls.Add(this.chkUnicode);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.dgvPhoneNumber);
            this.Controls.Add(this.btnLoadContacts);
            this.Controls.Add(this.btnSendAll);
            this.Controls.Add(this.lvLogs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCom);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.txtNum);
            this.Name = "Form1";
            this.Text = "INTL SMS Broadcaster";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhoneNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtCom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.ListView lvLogs;
        private System.Windows.Forms.Button btnSendAll;
        private System.Windows.Forms.ColumnHeader log;
        private System.Windows.Forms.Button btnLoadContacts;
        private System.Windows.Forms.DataGridView dgvPhoneNumber;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.CheckBox chkUnicode;
        private System.Windows.Forms.Button btnClearLogs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDBTable;
        private System.Windows.Forms.Button btnClearDGV;
        private System.Windows.Forms.Button btnDisconnect;
    }
}

