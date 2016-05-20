namespace ColorTracking
{
    partial class tracker
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
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.camerasCombo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.videoSourcePlayer3 = new AForge.Controls.VideoSourcePlayer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.clearPlotBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.uartCombo = new System.Windows.Forms.ComboBox();
            this.uartStop = new System.Windows.Forms.Button();
            this.uartStart = new System.Windows.Forms.Button();
            this.uart = new System.IO.Ports.SerialPort(this.components);
            this.uartsendTxtBox = new System.Windows.Forms.RichTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.Location = new System.Drawing.Point(22, 12);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(392, 385);
            this.videoSourcePlayer1.TabIndex = 3;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            // 
            // camerasCombo
            // 
            this.camerasCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.camerasCombo.FormattingEnabled = true;
            this.camerasCombo.Location = new System.Drawing.Point(93, 26);
            this.camerasCombo.Name = "camerasCombo";
            this.camerasCombo.Size = new System.Drawing.Size(167, 21);
            this.camerasCombo.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // videoSourcePlayer3
            // 
            this.videoSourcePlayer3.Location = new System.Drawing.Point(22, 418);
            this.videoSourcePlayer3.Name = "videoSourcePlayer3";
            this.videoSourcePlayer3.Size = new System.Drawing.Size(392, 385);
            this.videoSourcePlayer3.TabIndex = 7;
            this.videoSourcePlayer3.Text = "videoSourcePlayer3";
            this.videoSourcePlayer3.VideoSource = null;
            this.videoSourcePlayer3.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.videoSourcePlayer3_NewFrame);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(420, 418);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(391, 385);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(827, 322);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(350, 481);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(185, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "disconnect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.camerasCombo);
            this.groupBox1.Location = new System.Drawing.Point(446, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "connection";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.clearPlotBtn);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Location = new System.Drawing.Point(1, -1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(822, 804);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "view";
            // 
            // clearPlotBtn
            // 
            this.clearPlotBtn.Location = new System.Drawing.Point(581, 390);
            this.clearPlotBtn.Name = "clearPlotBtn";
            this.clearPlotBtn.Size = new System.Drawing.Size(75, 23);
            this.clearPlotBtn.TabIndex = 15;
            this.clearPlotBtn.Text = "Clear Plot";
            this.clearPlotBtn.UseVisualStyleBackColor = true;
            this.clearPlotBtn.Click += new System.EventHandler(this.clearPlotBtn_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDown3);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.numericUpDown2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(446, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 198);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "define object ";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(218, 155);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(48, 20);
            this.numericUpDown3.TabIndex = 7;
            this.numericUpDown3.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            this.numericUpDown3.Validated += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "min width of object";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(218, 121);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(48, 20);
            this.numericUpDown2.TabIndex = 5;
            this.numericUpDown2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            this.numericUpDown2.Validated += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "min height of object";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(146, 71);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.numericUpDown1.Validated += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(90, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "press for select color";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(100, 40);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Range";
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.FullOpen = true;
            this.colorDialog1.ShowHelp = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.uartCombo);
            this.groupBox4.Controls.Add(this.uartStop);
            this.groupBox4.Controls.Add(this.uartStart);
            this.groupBox4.Location = new System.Drawing.Point(880, 24);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(262, 119);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "uart controls";
            // 
            // uartCombo
            // 
            this.uartCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uartCombo.FormattingEnabled = true;
            this.uartCombo.Location = new System.Drawing.Point(17, 26);
            this.uartCombo.Name = "uartCombo";
            this.uartCombo.Size = new System.Drawing.Size(222, 21);
            this.uartCombo.TabIndex = 1;
            // 
            // uartStop
            // 
            this.uartStop.Enabled = false;
            this.uartStop.Location = new System.Drawing.Point(144, 77);
            this.uartStop.Name = "uartStop";
            this.uartStop.Size = new System.Drawing.Size(95, 23);
            this.uartStop.TabIndex = 0;
            this.uartStop.Text = "Stop";
            this.uartStop.UseVisualStyleBackColor = true;
            this.uartStop.Click += new System.EventHandler(this.uartStop_Click);
            // 
            // uartStart
            // 
            this.uartStart.Enabled = false;
            this.uartStart.Location = new System.Drawing.Point(17, 77);
            this.uartStart.Name = "uartStart";
            this.uartStart.Size = new System.Drawing.Size(109, 23);
            this.uartStart.TabIndex = 0;
            this.uartStart.Text = "Start Transmitting";
            this.uartStart.UseVisualStyleBackColor = true;
            this.uartStart.Click += new System.EventHandler(this.uartStart_Click);
            // 
            // uart
            // 
            this.uart.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.uart_DataReceived);
            // 
            // uartsendTxtBox
            // 
            this.uartsendTxtBox.Location = new System.Drawing.Point(6, 23);
            this.uartsendTxtBox.Name = "uartsendTxtBox";
            this.uartsendTxtBox.Size = new System.Drawing.Size(250, 124);
            this.uartsendTxtBox.TabIndex = 15;
            this.uartsendTxtBox.Text = "";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.uartsendTxtBox);
            this.groupBox5.Location = new System.Drawing.Point(880, 158);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(262, 153);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "uart send";
            // 
            // tracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 812);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.videoSourcePlayer3);
            this.Controls.Add(this.videoSourcePlayer1);
            this.Controls.Add(this.groupBox3);
            this.Name = "tracker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControlCenter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.f21_FormClosing);
            this.Load += new System.EventHandler(this.tracker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private System.Windows.Forms.ComboBox camerasCombo;
        private System.Windows.Forms.Button button1;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox uartCombo;
        private System.Windows.Forms.Button uartStop;
        private System.Windows.Forms.Button uartStart;
        private System.IO.Ports.SerialPort uart;
        private System.Windows.Forms.RichTextBox uartsendTxtBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button clearPlotBtn;
    }
}

