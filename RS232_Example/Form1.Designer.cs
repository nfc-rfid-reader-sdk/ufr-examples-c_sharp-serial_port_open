namespace RS232_Example
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCOMPort = new System.Windows.Forms.TextBox();
            this.checkReset = new System.Windows.Forms.CheckBox();
            this.btnReaderOpen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelDLL = new System.Windows.Forms.Label();
            this.txtDLL = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtHardware = new System.Windows.Forms.TextBox();
            this.labelHardware = new System.Windows.Forms.Label();
            this.txtFirmware = new System.Windows.Forms.TextBox();
            this.labelFirmware = new System.Windows.Forms.Label();
            this.labelReaderSN = new System.Windows.Forms.Label();
            this.labelReaderType = new System.Windows.Forms.Label();
            this.txtReaderSN = new System.Windows.Forms.TextBox();
            this.txtReaderType = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGetCardInfo = new System.Windows.Forms.Button();
            this.labelCardSerial = new System.Windows.Forms.Label();
            this.txtCardSerial = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCardUIDSize = new System.Windows.Forms.TextBox();
            this.labelCardType = new System.Windows.Forms.Label();
            this.txtCardType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReaderStatus = new System.Windows.Forms.TextBox();
            this.txtFunctionStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM Port:";
            // 
            // txtCOMPort
            // 
            this.txtCOMPort.Location = new System.Drawing.Point(68, 22);
            this.txtCOMPort.Name = "txtCOMPort";
            this.txtCOMPort.Size = new System.Drawing.Size(100, 20);
            this.txtCOMPort.TabIndex = 1;
            // 
            // checkReset
            // 
            this.checkReset.AutoSize = true;
            this.checkReset.Location = new System.Drawing.Point(9, 48);
            this.checkReset.Name = "checkReset";
            this.checkReset.Size = new System.Drawing.Size(96, 17);
            this.checkReset.TabIndex = 2;
            this.checkReset.Text = "Reset disabled";
            this.checkReset.UseVisualStyleBackColor = true;
            this.checkReset.Click += new System.EventHandler(this.checkReset_Click);
            // 
            // btnReaderOpen
            // 
            this.btnReaderOpen.Location = new System.Drawing.Point(193, 20);
            this.btnReaderOpen.Name = "btnReaderOpen";
            this.btnReaderOpen.Size = new System.Drawing.Size(131, 23);
            this.btnReaderOpen.TabIndex = 3;
            this.btnReaderOpen.Text = "Reader Open";
            this.btnReaderOpen.UseVisualStyleBackColor = true;
            this.btnReaderOpen.Click += new System.EventHandler(this.btnReaderOpen_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelDLL);
            this.groupBox1.Controls.Add(this.txtDLL);
            this.groupBox1.Controls.Add(this.btnReaderOpen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkReset);
            this.groupBox1.Controls.Add(this.txtCOMPort);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 90);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reader Open";
            // 
            // labelDLL
            // 
            this.labelDLL.AutoSize = true;
            this.labelDLL.Location = new System.Drawing.Point(151, 64);
            this.labelDLL.Name = "labelDLL";
            this.labelDLL.Size = new System.Drawing.Size(67, 13);
            this.labelDLL.TabIndex = 6;
            this.labelDLL.Text = "DLL version:";
            // 
            // txtDLL
            // 
            this.txtDLL.Location = new System.Drawing.Point(224, 61);
            this.txtDLL.Name = "txtDLL";
            this.txtDLL.ReadOnly = true;
            this.txtDLL.Size = new System.Drawing.Size(100, 20);
            this.txtDLL.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtHardware);
            this.groupBox2.Controls.Add(this.labelHardware);
            this.groupBox2.Controls.Add(this.txtFirmware);
            this.groupBox2.Controls.Add(this.labelFirmware);
            this.groupBox2.Controls.Add(this.labelReaderSN);
            this.groupBox2.Controls.Add(this.labelReaderType);
            this.groupBox2.Controls.Add(this.txtReaderSN);
            this.groupBox2.Controls.Add(this.txtReaderType);
            this.groupBox2.Location = new System.Drawing.Point(12, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 90);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reader info";
            // 
            // txtHardware
            // 
            this.txtHardware.Location = new System.Drawing.Point(244, 56);
            this.txtHardware.Name = "txtHardware";
            this.txtHardware.ReadOnly = true;
            this.txtHardware.Size = new System.Drawing.Size(80, 20);
            this.txtHardware.TabIndex = 11;
            // 
            // labelHardware
            // 
            this.labelHardware.AutoSize = true;
            this.labelHardware.Location = new System.Drawing.Point(186, 59);
            this.labelHardware.Name = "labelHardware";
            this.labelHardware.Size = new System.Drawing.Size(56, 13);
            this.labelHardware.TabIndex = 10;
            this.labelHardware.Text = "Hardware:";
            // 
            // txtFirmware
            // 
            this.txtFirmware.Location = new System.Drawing.Point(244, 20);
            this.txtFirmware.Name = "txtFirmware";
            this.txtFirmware.ReadOnly = true;
            this.txtFirmware.Size = new System.Drawing.Size(80, 20);
            this.txtFirmware.TabIndex = 7;
            // 
            // labelFirmware
            // 
            this.labelFirmware.AutoSize = true;
            this.labelFirmware.Location = new System.Drawing.Point(186, 23);
            this.labelFirmware.Name = "labelFirmware";
            this.labelFirmware.Size = new System.Drawing.Size(52, 13);
            this.labelFirmware.TabIndex = 9;
            this.labelFirmware.Text = "Firmware:";
            // 
            // labelReaderSN
            // 
            this.labelReaderSN.AutoSize = true;
            this.labelReaderSN.Location = new System.Drawing.Point(6, 59);
            this.labelReaderSN.Name = "labelReaderSN";
            this.labelReaderSN.Size = new System.Drawing.Size(63, 13);
            this.labelReaderSN.TabIndex = 8;
            this.labelReaderSN.Text = "Reader SN:";
            // 
            // labelReaderType
            // 
            this.labelReaderType.AutoSize = true;
            this.labelReaderType.Location = new System.Drawing.Point(6, 23);
            this.labelReaderType.Name = "labelReaderType";
            this.labelReaderType.Size = new System.Drawing.Size(68, 13);
            this.labelReaderType.TabIndex = 7;
            this.labelReaderType.Text = "Reader type:";
            // 
            // txtReaderSN
            // 
            this.txtReaderSN.Location = new System.Drawing.Point(80, 56);
            this.txtReaderSN.Name = "txtReaderSN";
            this.txtReaderSN.ReadOnly = true;
            this.txtReaderSN.Size = new System.Drawing.Size(100, 20);
            this.txtReaderSN.TabIndex = 6;
            // 
            // txtReaderType
            // 
            this.txtReaderType.Location = new System.Drawing.Point(80, 20);
            this.txtReaderType.Name = "txtReaderType";
            this.txtReaderType.ReadOnly = true;
            this.txtReaderType.Size = new System.Drawing.Size(100, 20);
            this.txtReaderType.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGetCardInfo);
            this.groupBox3.Controls.Add(this.labelCardSerial);
            this.groupBox3.Controls.Add(this.txtCardSerial);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtCardUIDSize);
            this.groupBox3.Controls.Add(this.labelCardType);
            this.groupBox3.Controls.Add(this.txtCardType);
            this.groupBox3.Location = new System.Drawing.Point(12, 204);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(351, 84);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Card info";
            // 
            // btnGetCardInfo
            // 
            this.btnGetCardInfo.Location = new System.Drawing.Point(214, 50);
            this.btnGetCardInfo.Name = "btnGetCardInfo";
            this.btnGetCardInfo.Size = new System.Drawing.Size(131, 23);
            this.btnGetCardInfo.TabIndex = 7;
            this.btnGetCardInfo.Text = "Get card info";
            this.btnGetCardInfo.UseVisualStyleBackColor = true;
            this.btnGetCardInfo.Click += new System.EventHandler(this.btnGetCardInfo_click);
            // 
            // labelCardSerial
            // 
            this.labelCardSerial.AutoSize = true;
            this.labelCardSerial.Location = new System.Drawing.Point(6, 56);
            this.labelCardSerial.Name = "labelCardSerial";
            this.labelCardSerial.Size = new System.Drawing.Size(61, 13);
            this.labelCardSerial.TabIndex = 13;
            this.labelCardSerial.Text = "Card Serial:";
            // 
            // txtCardSerial
            // 
            this.txtCardSerial.Location = new System.Drawing.Point(80, 53);
            this.txtCardSerial.Name = "txtCardSerial";
            this.txtCardSerial.ReadOnly = true;
            this.txtCardSerial.Size = new System.Drawing.Size(128, 20);
            this.txtCardSerial.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(166, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "UID Size:";
            // 
            // txtCardUIDSize
            // 
            this.txtCardUIDSize.Location = new System.Drawing.Point(225, 20);
            this.txtCardUIDSize.Name = "txtCardUIDSize";
            this.txtCardUIDSize.ReadOnly = true;
            this.txtCardUIDSize.Size = new System.Drawing.Size(50, 20);
            this.txtCardUIDSize.TabIndex = 10;
            // 
            // labelCardType
            // 
            this.labelCardType.AutoSize = true;
            this.labelCardType.Location = new System.Drawing.Point(6, 23);
            this.labelCardType.Name = "labelCardType";
            this.labelCardType.Size = new System.Drawing.Size(59, 13);
            this.labelCardType.TabIndex = 9;
            this.labelCardType.Text = "Card Type:";
            // 
            // txtCardType
            // 
            this.txtCardType.Location = new System.Drawing.Point(80, 20);
            this.txtCardType.Name = "txtCardType";
            this.txtCardType.ReadOnly = true;
            this.txtCardType.Size = new System.Drawing.Size(50, 20);
            this.txtCardType.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Reader Status:";
            // 
            // txtReaderStatus
            // 
            this.txtReaderStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReaderStatus.Location = new System.Drawing.Point(102, 305);
            this.txtReaderStatus.Name = "txtReaderStatus";
            this.txtReaderStatus.ReadOnly = true;
            this.txtReaderStatus.Size = new System.Drawing.Size(100, 13);
            this.txtReaderStatus.TabIndex = 8;
            this.txtReaderStatus.Text = "NOT CONNECTED";
            // 
            // txtFunctionStatus
            // 
            this.txtFunctionStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFunctionStatus.Location = new System.Drawing.Point(102, 338);
            this.txtFunctionStatus.Name = "txtFunctionStatus";
            this.txtFunctionStatus.ReadOnly = true;
            this.txtFunctionStatus.Size = new System.Drawing.Size(261, 13);
            this.txtFunctionStatus.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Function Status:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 380);
            this.Controls.Add(this.txtFunctionStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtReaderStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "RS232 Example";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCOMPort;
        private System.Windows.Forms.CheckBox checkReset;
        private System.Windows.Forms.Button btnReaderOpen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelDLL;
        private System.Windows.Forms.TextBox txtDLL;
        private System.Windows.Forms.TextBox txtReaderSN;
        private System.Windows.Forms.TextBox txtReaderType;
        private System.Windows.Forms.Label labelReaderType;
        private System.Windows.Forms.Label labelReaderSN;
        private System.Windows.Forms.Label labelFirmware;
        private System.Windows.Forms.TextBox txtFirmware;
        private System.Windows.Forms.Label labelHardware;
        private System.Windows.Forms.TextBox txtHardware;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelCardSerial;
        private System.Windows.Forms.TextBox txtCardSerial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCardUIDSize;
        private System.Windows.Forms.Label labelCardType;
        private System.Windows.Forms.TextBox txtCardType;
        private System.Windows.Forms.Button btnGetCardInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReaderStatus;
        private System.Windows.Forms.TextBox txtFunctionStatus;
        private System.Windows.Forms.Label label3;
    }
}

