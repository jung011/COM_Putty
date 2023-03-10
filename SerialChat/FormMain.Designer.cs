namespace SerialChat
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmbTag = new System.Windows.Forms.ComboBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.dgvSendText = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSetting = new System.Windows.Forms.Button();
            this.rtbReceiveMsg = new System.Windows.Forms.RichTextBox();
            this.lblReceive = new System.Windows.Forms.Label();
            this.lblSend = new System.Windows.Forms.Label();
            this.lblTag = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblPort = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbPortName = new System.Windows.Forms.ComboBox();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textData = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSendText)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbTag
            // 
            this.cmbTag.FormattingEnabled = true;
            this.cmbTag.Location = new System.Drawing.Point(1122, 73);
            this.cmbTag.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTag.Name = "cmbTag";
            this.cmbTag.Size = new System.Drawing.Size(193, 28);
            this.cmbTag.TabIndex = 20;
            this.cmbTag.SelectedIndexChanged += new System.EventHandler(this.cmbTag_SelectedIndexChanged);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(1368, 277);
            this.btnModify.Margin = new System.Windows.Forms.Padding(4);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(147, 115);
            this.btnModify.TabIndex = 17;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(1368, 968);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(147, 115);
            this.btnSend.TabIndex = 16;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // dgvSendText
            // 
            this.dgvSendText.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSendText.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvSendText.Location = new System.Drawing.Point(840, 132);
            this.dgvSendText.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSendText.Name = "dgvSendText";
            this.dgvSendText.ReadOnly = true;
            this.dgvSendText.RowHeadersWidth = 51;
            this.dgvSendText.RowTemplate.Height = 29;
            this.dgvSendText.Size = new System.Drawing.Size(477, 991);
            this.dgvSendText.TabIndex = 15;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Seq";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Text";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // btnSetting
            // 
            this.btnSetting.Location = new System.Drawing.Point(1368, 132);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(147, 115);
            this.btnSetting.TabIndex = 21;
            this.btnSetting.Text = "Setting";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // rtbReceiveMsg
            // 
            this.rtbReceiveMsg.BackColor = System.Drawing.SystemColors.Window;
            this.rtbReceiveMsg.Location = new System.Drawing.Point(51, 132);
            this.rtbReceiveMsg.Margin = new System.Windows.Forms.Padding(4);
            this.rtbReceiveMsg.Name = "rtbReceiveMsg";
            this.rtbReceiveMsg.Size = new System.Drawing.Size(655, 989);
            this.rtbReceiveMsg.TabIndex = 12;
            this.rtbReceiveMsg.Text = "";
            this.rtbReceiveMsg.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // lblReceive
            // 
            this.lblReceive.AutoSize = true;
            this.lblReceive.Location = new System.Drawing.Point(51, 84);
            this.lblReceive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceive.Name = "lblReceive";
            this.lblReceive.Size = new System.Drawing.Size(88, 20);
            this.lblReceive.TabIndex = 22;
            this.lblReceive.Text = "ReceiveText";
            // 
            // lblSend
            // 
            this.lblSend.AutoSize = true;
            this.lblSend.Location = new System.Drawing.Point(840, 84);
            this.lblSend.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSend.Name = "lblSend";
            this.lblSend.Size = new System.Drawing.Size(71, 20);
            this.lblSend.TabIndex = 23;
            this.lblSend.Text = "SendText";
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.Location = new System.Drawing.Point(1058, 84);
            this.lblTag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(42, 20);
            this.lblTag.TabIndex = 24;
            this.lblTag.Text = "Tag :";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1368, 831);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(147, 115);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(163, 84);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(37, 20);
            this.lblPort.TabIndex = 26;
            this.lblPort.Text = "Port";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(83, 28);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(82, 24);
            this.toolStripMenuItem2.Text = "`";
            // 
            // cmbPortName
            // 
            this.cmbPortName.FormattingEnabled = true;
            this.cmbPortName.Items.AddRange(new object[] {
            "Select Port"});
            this.cmbPortName.Location = new System.Drawing.Point(206, 84);
            this.cmbPortName.Name = "cmbPortName";
            this.cmbPortName.Size = new System.Drawing.Size(151, 28);
            this.cmbPortName.TabIndex = 27;
            this.cmbPortName.SelectedIndexChanged += new System.EventHandler(this.cmbPortName_SelectedIndexChanged);
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "460800",
            "921600"});
            this.cmbBaudRate.Location = new System.Drawing.Point(470, 84);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(151, 28);
            this.cmbBaudRate.TabIndex = 29;
            this.cmbBaudRate.SelectedIndexChanged += new System.EventHandler(this.cmbBaudRate_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "BaudRate";
            // 
            // textData
            // 
            this.textData.Location = new System.Drawing.Point(840, 1148);
            this.textData.Name = "textData";
            this.textData.Size = new System.Drawing.Size(486, 27);
            this.textData.TabIndex = 30;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1695, 1055);
            this.Controls.Add(this.textData);
            this.Controls.Add(this.cmbBaudRate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPortName);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTag);
            this.Controls.Add(this.lblSend);
            this.Controls.Add(this.lblReceive);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.cmbTag);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.dgvSendText);
            this.Controls.Add(this.rtbReceiveMsg);
            this.Name = "FormMain";
            this.Text = "SerialChat";
            this.Load += new System.EventHandler(this.FormSerialChat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSendText)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbTag;
        private Button btnModify;
        private Button btnSend;
        private DataGridView dgvSendText;
        private Button btnSetting;
        private Label lblReceive;
        private Label lblSend;
        private Label lblTag;
        private Button btnSave;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Label lblPort;
        public RichTextBox rtbReceiveMsg;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ComboBox cmbPortName;
        private ComboBox cmbBaudRate;
        private Label label1;
        private TextBox textData;
    }
}