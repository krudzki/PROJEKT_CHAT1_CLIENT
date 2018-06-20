using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEKT_CHAT1_CLIENT
{
    public partial class Form1 : Form
    {
        public Form1(EventHandler buttonConnectClick, EventHandler buttonSendClick, EventHandler buttonDisconnectClick)
        {
            InitializeComponent();
            this.buttonConnect.Click += buttonConnectClick;
            this.buttonSend.Click += buttonSendClick;
            this.buttonDisconnect.Click += buttonDisconnectClick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public string GetIPString()
        {
            return this.textServerIP.Text;
        }

        public int GetPortNumber()
        {
            return (int)this.numericServerPort.Value;
        }

        public string GetMessageString()
        {
            return this.textMessage.Text.Trim();
        }

        public void ClearMessageText()
        {
            this.textMessage.Clear();
        }

        public string GetNickString()
        {
            return this.textNick.Text;
        }

        delegate void VoidString(string str);

        public void Println(string str)
        {
            if (this.textLog.InvokeRequired)
            {
                VoidString println = Println;
                this.textLog.Invoke(println, str);
            }
            else
            {
                this.textLog.AppendText(str + Environment.NewLine);
            }
        }

        delegate void VoidBoolString(bool bo, string str);

        public void SetStatusLabel(bool isConnect, string point = null)
        {
            if (this.labelStatus.InvokeRequired)
            {
                VoidBoolString ssl = SetStatusLabel;
                this.labelStatus.Invoke(ssl, isConnect, point);
            }
            else
            {
                if (isConnect)
                {
                    this.labelStatus.ForeColor = Color.Green;
                    this.labelStatus.Text = "POŁACZONY";
                    this.labelInfoIP.Text = point;
                }
                else
                {
                    this.labelStatus.ForeColor = Color.Red;
                    this.labelStatus.Text = "NIEPOŁĄCZONY";
                    this.labelInfoIP.Text = "BRAK";
                }
            }
        }

        delegate void VoidBool(bool bo);

        public void SetSendEnabled(bool enabled)
        {
            if (this.buttonSend.InvokeRequired)
            {
                VoidBool sse = SetSendEnabled;
                this.textLog.Invoke(sse, enabled);
            }
            else
            {
                this.buttonSend.Enabled = enabled;
            }
        }

        public void SetConnectEnabled(bool enabled)
        {
            if (this.buttonConnect.InvokeRequired)
            {
                VoidBool sce = SetConnectEnabled;
                this.textLog.Invoke(sce, enabled);
            }
            else
            {
                this.buttonConnect.Enabled = enabled;
            }
        }

        public void SetDisconnectEnabled(bool enabled)
        {
            if (this.buttonDisconnect.InvokeRequired)
            {
                VoidBool sde = SetDisconnectEnabled;
                this.textLog.Invoke(sde, enabled);
            }
            else
            {
                this.buttonDisconnect.Enabled = enabled;
            }
        }
    }
}
