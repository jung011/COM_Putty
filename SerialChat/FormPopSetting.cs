
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.Unicode;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SerialChat
{
    public partial class FormPopSetting : Form
    {


        FormMain main = null;

        public IniFile fileSendTag;


        public FormPopSetting(FormMain ma)
        {
            InitializeComponent();
            main = ma;

        }



        private void SerialPortSettingForm_Load(object sender, EventArgs e)
        {

            LoadTag();
        }

        private void btnModifyTag_Click(object sender, EventArgs e)
        {
            rtxtTag.ReadOnly = false;
        }

        private void btnSaveTag_Click(object sender, EventArgs e)
        {
            rtxtTag.ReadOnly = true;
            SaveData();
        }

        private void SaveData()
        {
            fileSendTag = new IniFile();

            string fileName = string.Empty;
            FileInfo fi = null;

            for (int i = 0; i < rtxtTag.Lines.Count(); i++)
            {
                if(rtxtTag.Lines[i].ToString().Trim().Length > 0)
                {
                    fileName = Application.StartupPath + rtxtTag.Lines[i].ToString() + "_SerialSendText.ini";
                    fi = new FileInfo(fileName);

                    if (fi.Exists)
                    {
                        //경로 존재
                    }
                    else
                    {
                        //경로 없음
                        fi.Create();
                    }

                    fileSendTag["Tag"]["tag" + i] = rtxtTag.Lines[i].ToString();
                }
            }

            fileSendTag.Save(Application.StartupPath + "\\_SerialSendTag.ini");
        }


        public void LoadTag()
        {
            fileSendTag = new IniFile();
            fileSendTag.Load(Application.StartupPath + "\\_SerialSendTag.ini");

            for (int i = 0; i < fileSendTag["Tag"].Count; i++)
            {
                rtxtTag.AppendText(fileSendTag["Tag"]["tag" + i].ToString() + "\r\n");

            }

        }

    }
}
