namespace SerialChat
{
    partial class FormPopSetting
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
            this.label8 = new System.Windows.Forms.Label();
            this.btnModifyTag = new System.Windows.Forms.Button();
            this.btnSaveTag = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.rtxtTag = new System.Windows.Forms.RichTextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(25, 37);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 41);
            this.label8.TabIndex = 5;
            this.label8.Text = "TAG설정";
            // 
            // btnModifyTag
            // 
            this.btnModifyTag.Location = new System.Drawing.Point(160, 26);
            this.btnModifyTag.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifyTag.Name = "btnModifyTag";
            this.btnModifyTag.Size = new System.Drawing.Size(125, 79);
            this.btnModifyTag.TabIndex = 6;
            this.btnModifyTag.Text = "수정";
            this.btnModifyTag.UseVisualStyleBackColor = true;
            this.btnModifyTag.Click += new System.EventHandler(this.btnModifyTag_Click);
            // 
            // btnSaveTag
            // 
            this.btnSaveTag.Location = new System.Drawing.Point(293, 26);
            this.btnSaveTag.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveTag.Name = "btnSaveTag";
            this.btnSaveTag.Size = new System.Drawing.Size(125, 79);
            this.btnSaveTag.TabIndex = 7;
            this.btnSaveTag.Text = "저장";
            this.btnSaveTag.UseVisualStyleBackColor = true;
            this.btnSaveTag.Click += new System.EventHandler(this.btnSaveTag_Click);
            // 
            // rtxtTag
            // 
            this.rtxtTag.Location = new System.Drawing.Point(13, 109);
            this.rtxtTag.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtTag.Name = "rtxtTag";
            this.rtxtTag.ReadOnly = true;
            this.rtxtTag.Size = new System.Drawing.Size(405, 397);
            this.rtxtTag.TabIndex = 8;
            this.rtxtTag.Text = "";
            // 
            // FormPopSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 519);
            this.Controls.Add(this.rtxtTag);
            this.Controls.Add(this.btnSaveTag);
            this.Controls.Add(this.btnModifyTag);
            this.Controls.Add(this.label8);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPopSetting";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "환경설정";
            this.Load += new System.EventHandler(this.SerialPortSettingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label8;
        private Button btnModifyTag;
        private Button btnSaveTag;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public RichTextBox rtxtTag;
        private BindingSource bindingSource1;
    }
}