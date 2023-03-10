using System.ComponentModel;
using System.Globalization;
using System.IO.Ports;
using static System.Windows.Forms.LinkLabel;

namespace SerialChat
{
    public partial class FormMain : Form
    {

        FormPopSetting set;
        IniFile fileSendText;
        SerialPort SP1 = new SerialPort();
        string data = null;
        int baudrate = 0;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormSerialChat_Load(object sender, EventArgs e)
        {
            set = new FormPopSetting(this);
            LoadCmbTag();
            PortListLoad(cmbPortName);

            SP1.DataReceived += new SerialDataReceivedEventHandler(SP1_DataReceived);
            cmbBaudRate.SelectedIndex = 0;

        }

        public void SP1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            string readData = SP1.ReadExisting();
            
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(delegate ()
                {
                    //readData = SP1.ReadExisting() + "\r\n";
                    rtbReceiveMsg.AppendText(readData);
                    rtbReceiveMsg.ScrollToCaret();
                }));
            }
            
            AutoMode();
        }

        public void PortListLoad(ComboBox box)
        {
            box.Items.Clear();

            foreach (string comport in SerialPort.GetPortNames())
            {
                box.Items.Add(comport);
            }

            box.SelectedIndex = 0;
        }

        public void Connetcion()
        {
            string portName = cmbPortName.Text;

            if(baudrate <= 0 || baudrate == null || cmbBaudRate.Text.Length < 1)
            {
                baudrate = 9600;
            }
            else
                baudrate = int.Parse(cmbBaudRate.Text);

            if (SP1.IsOpen)
            {
                SP1.Close();
            }

            SP1.PortName = portName;
            SP1.BaudRate = baudrate;
            SP1.DataBits = 8;
            SP1.Parity = Parity.None;
            SP1.StopBits = StopBits.One;
            SP1.Open();

            rtbReceiveMsg.Text += portName + "가 연결되었습니다. \r\n";

        }

        public void LoadCmbTag()
        {
            fileSendText = new IniFile();
            fileSendText.Load(Application.StartupPath + "\\_SerialSendTag.ini");

            for (int i = 0; i < fileSendText["Tag"].Count; i++)
            {
                cmbTag.Items.Add(fileSendText["Tag"]["tag" + i].ToString());
            }

            cmbTag.SelectedIndex = 0;
        }

        public void LoadDgvSendData()
        {
            string tagText = cmbTag.Text;
            fileSendText = new IniFile();
            fileSendText.Load(Application.StartupPath + "\\" + tagText + "_SerialSendText.ini");
         
            for (int i = 0; i < fileSendText[tagText].Count; i++)
            {
                dgvSendText.Rows.Add();

                dgvSendText.Rows[i].Cells[0].Value = (i+1).ToString();
                dgvSendText.Rows[i].Cells[1].Value = fileSendText[tagText][tagText + "_" + i].ToString();
                
            }
            
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            set = new FormPopSetting(this);
            set.Show();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
           dgvSendText.ReadOnly = false;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
           
            SP1.Write(textData.Text + "\n");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            SaveData();
            dgvSendText.ReadOnly = true;
        }

        private void SaveData()
        {
            fileSendText = new IniFile();

            for(int i = 0; i< dgvSendText.Rows.Count; i++)
            {
                if(dgvSendText.Rows[i].Cells[1].Value != null)
                    fileSendText[cmbTag.Text][cmbTag.Text + "_" + i] = dgvSendText.Rows[i].Cells[1].Value.ToString();
            }

            fileSendText.Save(Application.StartupPath + cmbTag.Text + "_SerialSendText.ini");

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbTag_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbTag.Text.Length > 0)
            {
                dgvSendText.Rows.Clear();
                LoadDgvSendData();
            }
                
        }

        private void cmbPortName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Connetcion();
        }

        private void cmbBaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            Connetcion();
        }

       

        private void AutoMode()
        {
            string strkey = null;
            string strval = null;
            strkey = "COM login:";
            strval = "root";

            string txtLastLine = string.Empty;
            int lastRow = rtbReceiveMsg.Lines.Count() - 1;
            txtLastLine = rtbReceiveMsg.Lines[lastRow].ToString();

            if (txtLastLine == strkey)
            {
                SP1.Write(strval + "\n");
            }
        }

    }
}