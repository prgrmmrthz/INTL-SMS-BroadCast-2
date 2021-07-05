using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using GsmComm.PduConverter;
using GsmComm.PduConverter.SmartMessaging;
using GsmComm.GsmCommunication;
using GsmComm.Interfaces;
using GsmComm.Server;
using System.Globalization;

namespace smsmtest
{
    public partial class Form1 : Form
    {
        private GsmCommMain comm;
        private delegate void SetTextCallback(string text);
        private SmsServer smsServer;
        DataTable tbl = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCom.Text != "")
            {
                sendSMS(txtMsg.Text.ToString(), txtNum.Text.ToString(), 1);
            }
            else
            {
                MessageBox.Show("No device connected Please check COM Port");
            }
        }

        private void lvLogs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLoadContacts_Click(object sender, EventArgs e)
        {
            string q = "";
            try
            {
                tbl.Clear();
                dgvPhoneNumber.DataSource = null;
                dgvPhoneNumber.Rows.Clear();
                dgvPhoneNumber.Refresh();
                string konstr = "datasource=127.0.0.1;port=3306;username=root;password=civong;database=pos";
                q = "select phoneNumber from "+cmbDBTable.Text;
                MySqlConnection kon = new MySqlConnection(konstr);
                MySqlCommand cmd = new MySqlCommand(q, kon);
                kon.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;
                adapter.Fill(tbl);
                dgvPhoneNumber.DataSource = tbl;
                kon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + q);
            }
        }

        private void btnSendAll_Click(object sender, EventArgs e)
        {
            if (txtCom.Text != "" && txtNum.Text != "")
            {
                foreach (DataRow r in tbl.Rows)
                {
                    int index = tbl.Rows.IndexOf(r);
                    sendSMS(txtMsg.Text.ToString(), r["phoneNumber"].ToString(), index + 1);
                    if ((index + 1) % 5 == 0 || index + 1 == tbl.Select().Length)
                    {
                        Thread.Sleep(2000);
                        sendSMS($"Verify send {index+1}/{tbl.Select().Length}", txtNum.Text.ToString(), 000);
                    }
                }
                MessageBox.Show("Done Sending to all contacts please check logs OK");
            }
            else
            {
                MessageBox.Show("Please check COM Port or Number Verifier");
            }
        }

        public void sendSMS(string msg, string phonenumber, int index)
        {
            try
            {
                ListViewItem sending = new ListViewItem("Sending... to " + phonenumber);
                lvLogs.Items.Add(sending);
                Cursor.Current = Cursors.Default;
                //SmsSubmitPdu pdu;
                Cursor.Current = Cursors.WaitCursor;
                //byte dcs = (byte)DataCodingScheme.GeneralCoding.Alpha7BitDefault;
                bool unicode = chkUnicode.Checked;
                //pdu = new SmsSubmitPdu(msg, phonenumber, "+639180000101");
                SmsSubmitPdu[] pdu = SmartMessageFactory.CreateConcatTextMessage(msg, unicode, phonenumber);
                int times = 1;
                for (int i = 0; i < times; i++)
                {
                    try
                    {
                        comm.SendMessages(pdu);
                        ListViewItem sent = new ListViewItem(index + ".Sent to " + phonenumber);
                        lvLogs.Items.Add(sent);
                    }
                    catch(Exception ex)
                    {
                        ListViewItem failed = new ListViewItem(index + ".Failed sending " + phonenumber + "-" + ex.Message);
                        lvLogs.Items.Add(failed);
                    }
                }
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                ListViewItem failed = new ListViewItem(index + ".Failed sending " + phonenumber + "-" + ex.Message);
                lvLogs.Items.Add(failed);
                //MessageBox.Show(ex.Message);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            comm = new GsmCommMain("COM"+txtCom.Text, 9600, 150);
            Cursor.Current = Cursors.Default;
            bool retry;
            do
            {
                retry = false;
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    comm.Open();
                    if (comm.IsConnected() == true)
                    {
                        MessageBox.Show("Modem Connected Sucessfully");
                        //btnConnect.Text = "Disconnect";
                    }
                    Cursor.Current = Cursors.Default;

                }
                catch (Exception ex)
                {
                    Cursor.Current = Cursors.Default;
                    if (MessageBox.Show(this, "GSM Modem is not available", "Check", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning) == DialogResult.Retry)
                    {
                        retry = true;
                    }else{
                        return;
                    }
                }
            }
            while (retry);
        }

        private void btnClearLogs_Click(object sender, EventArgs e)
        {
            lvLogs.Items.Clear();
        }

        private void btnClearDGV_Click(object sender, EventArgs e)
        {
            try
            {
                tbl.Clear();
                dgvPhoneNumber.DataSource = null;
                dgvPhoneNumber.Rows.Clear();
                dgvPhoneNumber.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbDBTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cmbDBTable.Text);
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                comm.Close();
                if (!comm.IsConnected())
                {
                    MessageBox.Show("Modem has been  Disconnected ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
