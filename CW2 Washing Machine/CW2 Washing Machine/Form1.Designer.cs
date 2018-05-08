namespace CW2_Washing_Machine
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
            this.temppanel = new System.Windows.Forms.Panel();
            this.light40 = new System.Windows.Forms.Panel();
            this.light60 = new System.Windows.Forms.Panel();
            this.light30 = new System.Windows.Forms.Panel();
            this.tempbtn = new System.Windows.Forms.Button();
            this.temp60 = new System.Windows.Forms.Label();
            this.temp40 = new System.Windows.Forms.Label();
            this.temp30 = new System.Windows.Forms.Label();
            this.rpmpanel = new System.Windows.Forms.Panel();
            this.light600 = new System.Windows.Forms.Panel();
            this.light1200 = new System.Windows.Forms.Panel();
            this.light800 = new System.Windows.Forms.Panel();
            this.spinbtn = new System.Windows.Forms.Button();
            this.spin1200 = new System.Windows.Forms.Label();
            this.spin800 = new System.Windows.Forms.Label();
            this.spin600 = new System.Windows.Forms.Label();
            this.startbtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.tempreadtxt = new System.Windows.Forms.TextBox();
            this.statuslbl = new System.Windows.Forms.Label();
            this.doorbtn = new System.Windows.Forms.Button();
            this.speedreadtxt = new System.Windows.Forms.TextBox();
            this.cycleinfo = new System.Windows.Forms.TextBox();
            this.clothesdetergentBtn = new System.Windows.Forms.Button();
            this.wmachine = new System.Windows.Forms.PictureBox();
            this.temppanel.SuspendLayout();
            this.rpmpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmachine)).BeginInit();
            this.SuspendLayout();
            // 
            // temppanel
            // 
            this.temppanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.temppanel.Controls.Add(this.light40);
            this.temppanel.Controls.Add(this.light60);
            this.temppanel.Controls.Add(this.light30);
            this.temppanel.Controls.Add(this.tempbtn);
            this.temppanel.Controls.Add(this.temp60);
            this.temppanel.Controls.Add(this.temp40);
            this.temppanel.Controls.Add(this.temp30);
            this.temppanel.Location = new System.Drawing.Point(179, 64);
            this.temppanel.Name = "temppanel";
            this.temppanel.Size = new System.Drawing.Size(114, 239);
            this.temppanel.TabIndex = 0;
            // 
            // light40
            // 
            this.light40.Location = new System.Drawing.Point(91, 100);
            this.light40.Name = "light40";
            this.light40.Size = new System.Drawing.Size(17, 17);
            this.light40.TabIndex = 5;
            // 
            // light60
            // 
            this.light60.Location = new System.Drawing.Point(91, 153);
            this.light60.Name = "light60";
            this.light60.Size = new System.Drawing.Size(17, 15);
            this.light60.TabIndex = 5;
            // 
            // light30
            // 
            this.light30.Location = new System.Drawing.Point(91, 48);
            this.light30.Name = "light30";
            this.light30.Size = new System.Drawing.Size(17, 15);
            this.light30.TabIndex = 4;
            // 
            // tempbtn
            // 
            this.tempbtn.Location = new System.Drawing.Point(3, 190);
            this.tempbtn.Name = "tempbtn";
            this.tempbtn.Size = new System.Drawing.Size(105, 42);
            this.tempbtn.TabIndex = 3;
            this.tempbtn.Text = "Wash Temp";
            this.tempbtn.UseVisualStyleBackColor = true;
            this.tempbtn.Click += new System.EventHandler(this.tempbtn_Click);
            // 
            // temp60
            // 
            this.temp60.AutoSize = true;
            this.temp60.Location = new System.Drawing.Point(33, 151);
            this.temp60.Name = "temp60";
            this.temp60.Size = new System.Drawing.Size(43, 17);
            this.temp60.TabIndex = 2;
            this.temp60.Text = "60 °C\r\n";
            // 
            // temp40
            // 
            this.temp40.AutoSize = true;
            this.temp40.Location = new System.Drawing.Point(33, 98);
            this.temp40.Name = "temp40";
            this.temp40.Size = new System.Drawing.Size(43, 17);
            this.temp40.TabIndex = 1;
            this.temp40.Text = "40 °C\r\n";
            // 
            // temp30
            // 
            this.temp30.AutoSize = true;
            this.temp30.Location = new System.Drawing.Point(33, 46);
            this.temp30.Name = "temp30";
            this.temp30.Size = new System.Drawing.Size(43, 17);
            this.temp30.TabIndex = 0;
            this.temp30.Text = "30 °C\r\n";
            // 
            // rpmpanel
            // 
            this.rpmpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpmpanel.Controls.Add(this.light600);
            this.rpmpanel.Controls.Add(this.light1200);
            this.rpmpanel.Controls.Add(this.light800);
            this.rpmpanel.Controls.Add(this.spinbtn);
            this.rpmpanel.Controls.Add(this.spin1200);
            this.rpmpanel.Controls.Add(this.spin800);
            this.rpmpanel.Controls.Add(this.spin600);
            this.rpmpanel.Location = new System.Drawing.Point(316, 64);
            this.rpmpanel.Name = "rpmpanel";
            this.rpmpanel.Size = new System.Drawing.Size(119, 239);
            this.rpmpanel.TabIndex = 1;
            // 
            // light600
            // 
            this.light600.Location = new System.Drawing.Point(91, 48);
            this.light600.Name = "light600";
            this.light600.Size = new System.Drawing.Size(17, 15);
            this.light600.TabIndex = 7;
            // 
            // light1200
            // 
            this.light1200.Location = new System.Drawing.Point(89, 151);
            this.light1200.Name = "light1200";
            this.light1200.Size = new System.Drawing.Size(19, 17);
            this.light1200.TabIndex = 6;
            // 
            // light800
            // 
            this.light800.Location = new System.Drawing.Point(89, 100);
            this.light800.Name = "light800";
            this.light800.Size = new System.Drawing.Size(19, 17);
            this.light800.TabIndex = 5;
            // 
            // spinbtn
            // 
            this.spinbtn.Location = new System.Drawing.Point(9, 190);
            this.spinbtn.Name = "spinbtn";
            this.spinbtn.Size = new System.Drawing.Size(105, 42);
            this.spinbtn.TabIndex = 3;
            this.spinbtn.Text = "Spin Speed";
            this.spinbtn.UseVisualStyleBackColor = true;
            this.spinbtn.Click += new System.EventHandler(this.spinbtn_Click);
            // 
            // spin1200
            // 
            this.spin1200.AutoSize = true;
            this.spin1200.Location = new System.Drawing.Point(10, 153);
            this.spin1200.Name = "spin1200";
            this.spin1200.Size = new System.Drawing.Size(68, 17);
            this.spin1200.TabIndex = 2;
            this.spin1200.Text = "1200 rpm";
            // 
            // spin800
            // 
            this.spin800.AutoSize = true;
            this.spin800.Location = new System.Drawing.Point(10, 100);
            this.spin800.Name = "spin800";
            this.spin800.Size = new System.Drawing.Size(60, 17);
            this.spin800.TabIndex = 1;
            this.spin800.Text = "800 rpm";
            // 
            // spin600
            // 
            this.spin600.AutoSize = true;
            this.spin600.Location = new System.Drawing.Point(10, 46);
            this.spin600.Name = "spin600";
            this.spin600.Size = new System.Drawing.Size(60, 17);
            this.spin600.TabIndex = 0;
            this.spin600.Text = "600 rpm";
            // 
            // startbtn
            // 
            this.startbtn.Location = new System.Drawing.Point(947, 17);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(136, 41);
            this.startbtn.TabIndex = 2;
            this.startbtn.Text = "Start";
            this.startbtn.UseVisualStyleBackColor = true;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(947, 64);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(136, 64);
            this.cancelbtn.TabIndex = 3;
            this.cancelbtn.Text = "Stop/Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // tempreadtxt
            // 
            this.tempreadtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tempreadtxt.Location = new System.Drawing.Point(38, 97);
            this.tempreadtxt.Name = "tempreadtxt";
            this.tempreadtxt.ReadOnly = true;
            this.tempreadtxt.Size = new System.Drawing.Size(69, 22);
            this.tempreadtxt.TabIndex = 4;
            // 
            // statuslbl
            // 
            this.statuslbl.AutoSize = true;
            this.statuslbl.Location = new System.Drawing.Point(250, 26);
            this.statuslbl.Name = "statuslbl";
            this.statuslbl.Size = new System.Drawing.Size(185, 17);
            this.statuslbl.TabIndex = 5;
            this.statuslbl.Text = "Your Wash / Machine status";
            // 
            // doorbtn
            // 
            this.doorbtn.Location = new System.Drawing.Point(805, 17);
            this.doorbtn.Name = "doorbtn";
            this.doorbtn.Size = new System.Drawing.Size(136, 41);
            this.doorbtn.TabIndex = 6;
            this.doorbtn.Text = "Open/Close Door";
            this.doorbtn.UseVisualStyleBackColor = true;
            this.doorbtn.Click += new System.EventHandler(this.doorbtn_Click);
            // 
            // speedreadtxt
            // 
            this.speedreadtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.speedreadtxt.Location = new System.Drawing.Point(38, 125);
            this.speedreadtxt.Name = "speedreadtxt";
            this.speedreadtxt.ReadOnly = true;
            this.speedreadtxt.Size = new System.Drawing.Size(69, 22);
            this.speedreadtxt.TabIndex = 7;
            // 
            // cycleinfo
            // 
            this.cycleinfo.Location = new System.Drawing.Point(453, 26);
            this.cycleinfo.Multiline = true;
            this.cycleinfo.Name = "cycleinfo";
            this.cycleinfo.Size = new System.Drawing.Size(210, 87);
            this.cycleinfo.TabIndex = 8;
            // 
            // clothesdetergentBtn
            // 
            this.clothesdetergentBtn.Location = new System.Drawing.Point(805, 64);
            this.clothesdetergentBtn.Name = "clothesdetergentBtn";
            this.clothesdetergentBtn.Size = new System.Drawing.Size(136, 62);
            this.clothesdetergentBtn.TabIndex = 9;
            this.clothesdetergentBtn.Text = "Add / remove clothes and detergent";
            this.clothesdetergentBtn.UseVisualStyleBackColor = true;
            this.clothesdetergentBtn.Click += new System.EventHandler(this.clothesdetergentBtn_Click);
            // 
            // wmachine
            // 
            this.wmachine.Image = global::CW2_Washing_Machine.Properties.Resources.imgdoorclosed;
            this.wmachine.Location = new System.Drawing.Point(483, 226);
            this.wmachine.Name = "wmachine";
            this.wmachine.Size = new System.Drawing.Size(580, 313);
            this.wmachine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wmachine.TabIndex = 10;
            this.wmachine.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 643);
            this.Controls.Add(this.wmachine);
            this.Controls.Add(this.clothesdetergentBtn);
            this.Controls.Add(this.cycleinfo);
            this.Controls.Add(this.speedreadtxt);
            this.Controls.Add(this.doorbtn);
            this.Controls.Add(this.statuslbl);
            this.Controls.Add(this.tempreadtxt);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.startbtn);
            this.Controls.Add(this.rpmpanel);
            this.Controls.Add(this.temppanel);
            this.Name = "Form1";
            this.Text = "                    ";
            this.temppanel.ResumeLayout(false);
            this.temppanel.PerformLayout();
            this.rpmpanel.ResumeLayout(false);
            this.rpmpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmachine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel temppanel;
        private System.Windows.Forms.Button tempbtn;
        private System.Windows.Forms.Label temp60;
        private System.Windows.Forms.Label temp40;
        private System.Windows.Forms.Label temp30;
        private System.Windows.Forms.Panel rpmpanel;
        private System.Windows.Forms.Button spinbtn;
        private System.Windows.Forms.Label spin1200;
        private System.Windows.Forms.Label spin800;
        private System.Windows.Forms.Label spin600;
        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.TextBox tempreadtxt;
        private System.Windows.Forms.Label statuslbl;
        private System.Windows.Forms.Panel light40;
        private System.Windows.Forms.Panel light60;
        private System.Windows.Forms.Panel light30;
        private System.Windows.Forms.Button doorbtn;
        private System.Windows.Forms.Panel light600;
        private System.Windows.Forms.Panel light1200;
        private System.Windows.Forms.Panel light800;
        private System.Windows.Forms.TextBox speedreadtxt;
        private System.Windows.Forms.TextBox cycleinfo;
        private System.Windows.Forms.Button clothesdetergentBtn;
        private System.Windows.Forms.PictureBox wmachine;
    }
}

