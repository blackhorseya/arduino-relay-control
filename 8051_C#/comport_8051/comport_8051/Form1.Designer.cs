namespace comport_8051
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
			this.ovalShape5 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
			this.ovalShape4 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
			this.ovalShape3 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
			this.ovalShape2 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
			this.ovalShape1 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.btn_off = new System.Windows.Forms.Button();
			this.btn_end = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.label6 = new System.Windows.Forms.Label();
			this.btn_connect = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.mysql_connect = new System.Windows.Forms.Button();
			this.host = new System.Windows.Forms.TextBox();
			this.mysql_disconnect = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.Label9 = new System.Windows.Forms.Label();
			this.user = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.pwd = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(63, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "LOAD1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(147, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 12);
			this.label2.TabIndex = 1;
			this.label2.Text = "LOAD2";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(245, 26);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 12);
			this.label3.TabIndex = 2;
			this.label3.Text = "LOAD3";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(334, 26);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(42, 12);
			this.label4.TabIndex = 3;
			this.label4.Text = "LOAD4";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(434, 26);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(42, 12);
			this.label5.TabIndex = 4;
			this.label5.Text = "LOAD5";
			// 
			// shapeContainer1
			// 
			this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
			this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
			this.shapeContainer1.Name = "shapeContainer1";
			this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.ovalShape5,
            this.ovalShape4,
            this.ovalShape3,
            this.ovalShape2,
            this.ovalShape1});
			this.shapeContainer1.Size = new System.Drawing.Size(539, 390);
			this.shapeContainer1.TabIndex = 5;
			this.shapeContainer1.TabStop = false;
			// 
			// ovalShape5
			// 
			this.ovalShape5.FillColor = System.Drawing.Color.Lime;
			this.ovalShape5.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
			this.ovalShape5.Location = new System.Drawing.Point(431, 47);
			this.ovalShape5.Name = "ovalShape5";
			this.ovalShape5.Size = new System.Drawing.Size(50, 50);
			this.ovalShape5.Tag = "5";
			// 
			// ovalShape4
			// 
			this.ovalShape4.FillColor = System.Drawing.Color.Lime;
			this.ovalShape4.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
			this.ovalShape4.Location = new System.Drawing.Point(338, 47);
			this.ovalShape4.Name = "ovalShape4";
			this.ovalShape4.Size = new System.Drawing.Size(50, 50);
			this.ovalShape4.Tag = "4";
			// 
			// ovalShape3
			// 
			this.ovalShape3.FillColor = System.Drawing.Color.Lime;
			this.ovalShape3.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
			this.ovalShape3.Location = new System.Drawing.Point(245, 47);
			this.ovalShape3.Name = "ovalShape3";
			this.ovalShape3.Size = new System.Drawing.Size(50, 50);
			this.ovalShape3.Tag = "3";
			// 
			// ovalShape2
			// 
			this.ovalShape2.FillColor = System.Drawing.Color.Lime;
			this.ovalShape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
			this.ovalShape2.Location = new System.Drawing.Point(152, 47);
			this.ovalShape2.Name = "ovalShape2";
			this.ovalShape2.Size = new System.Drawing.Size(50, 50);
			this.ovalShape2.Tag = "2";
			// 
			// ovalShape1
			// 
			this.ovalShape1.FillColor = System.Drawing.Color.Lime;
			this.ovalShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
			this.ovalShape1.Location = new System.Drawing.Point(59, 47);
			this.ovalShape1.Name = "ovalShape1";
			this.ovalShape1.Size = new System.Drawing.Size(50, 50);
			this.ovalShape1.Tag = "1";
			// 
			// button1
			// 
			this.button1.Enabled = false;
			this.button1.Location = new System.Drawing.Point(48, 122);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 6;
			this.button1.Text = "LOAD1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Enabled = false;
			this.button2.Location = new System.Drawing.Point(140, 122);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 7;
			this.button2.Text = "LOAD2";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Enabled = false;
			this.button3.Location = new System.Drawing.Point(232, 122);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 8;
			this.button3.Text = "LOAD3";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Enabled = false;
			this.button4.Location = new System.Drawing.Point(324, 122);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 9;
			this.button4.Text = "LOAD4";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.Enabled = false;
			this.button5.Location = new System.Drawing.Point(416, 122);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 23);
			this.button5.TabIndex = 9;
			this.button5.Text = "LOAD5";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// btn_off
			// 
			this.btn_off.Enabled = false;
			this.btn_off.Location = new System.Drawing.Point(319, 185);
			this.btn_off.Name = "btn_off";
			this.btn_off.Size = new System.Drawing.Size(75, 23);
			this.btn_off.TabIndex = 10;
			this.btn_off.Text = "OFF";
			this.btn_off.UseVisualStyleBackColor = true;
			this.btn_off.Click += new System.EventHandler(this.btn_off_Click);
			// 
			// btn_end
			// 
			this.btn_end.Location = new System.Drawing.Point(416, 185);
			this.btn_end.Name = "btn_end";
			this.btn_end.Size = new System.Drawing.Size(75, 23);
			this.btn_end.TabIndex = 11;
			this.btn_end.Text = "結束";
			this.btn_end.UseVisualStyleBackColor = true;
			this.btn_end.Click += new System.EventHandler(this.btn_end_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(93, 186);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(112, 20);
			this.comboBox1.TabIndex = 12;
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// backgroundWorker1
			// 
			this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(47, 190);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(40, 12);
			this.label6.TabIndex = 13;
			this.label6.Text = "COM : ";
			// 
			// btn_connect
			// 
			this.btn_connect.Location = new System.Drawing.Point(222, 185);
			this.btn_connect.Name = "btn_connect";
			this.btn_connect.Size = new System.Drawing.Size(75, 23);
			this.btn_connect.TabIndex = 14;
			this.btn_connect.Text = "連線";
			this.btn_connect.UseVisualStyleBackColor = true;
			this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(48, 215);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(237, 163);
			this.richTextBox1.TabIndex = 15;
			this.richTextBox1.Text = "";
			// 
			// mysql_connect
			// 
			this.mysql_connect.Location = new System.Drawing.Point(416, 249);
			this.mysql_connect.Name = "mysql_connect";
			this.mysql_connect.Size = new System.Drawing.Size(75, 23);
			this.mysql_connect.TabIndex = 16;
			this.mysql_connect.Text = "連線MySQL";
			this.mysql_connect.UseVisualStyleBackColor = true;
			this.mysql_connect.Click += new System.EventHandler(this.mysql_connect_Click);
			// 
			// host
			// 
			this.host.Location = new System.Drawing.Point(293, 233);
			this.host.Name = "host";
			this.host.Size = new System.Drawing.Size(100, 22);
			this.host.TabIndex = 17;
			this.host.Text = "127.0.0.1";
			// 
			// mysql_disconnect
			// 
			this.mysql_disconnect.Enabled = false;
			this.mysql_disconnect.Location = new System.Drawing.Point(416, 295);
			this.mysql_disconnect.Name = "mysql_disconnect";
			this.mysql_disconnect.Size = new System.Drawing.Size(75, 23);
			this.mysql_disconnect.TabIndex = 18;
			this.mysql_disconnect.Text = "中斷MySQL";
			this.mysql_disconnect.UseVisualStyleBackColor = true;
			this.mysql_disconnect.Click += new System.EventHandler(this.mysql_disconnect_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(291, 218);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(35, 12);
			this.label7.TabIndex = 19;
			this.label7.Text = "Host : ";
			// 
			// Label9
			// 
			this.Label9.AutoSize = true;
			this.Label9.Location = new System.Drawing.Point(291, 258);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(32, 12);
			this.Label9.TabIndex = 20;
			this.Label9.Text = "User :";
			// 
			// user
			// 
			this.user.Location = new System.Drawing.Point(293, 273);
			this.user.Name = "user";
			this.user.Size = new System.Drawing.Size(100, 22);
			this.user.TabIndex = 21;
			this.user.Text = "root";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(291, 298);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(57, 12);
			this.label8.TabIndex = 22;
			this.label8.Text = "Password : ";
			// 
			// pwd
			// 
			this.pwd.Location = new System.Drawing.Point(291, 313);
			this.pwd.Name = "pwd";
			this.pwd.PasswordChar = '*';
			this.pwd.Size = new System.Drawing.Size(100, 22);
			this.pwd.TabIndex = 23;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(539, 390);
			this.Controls.Add(this.pwd);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.user);
			this.Controls.Add(this.Label9);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.mysql_disconnect);
			this.Controls.Add(this.host);
			this.Controls.Add(this.mysql_connect);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.btn_connect);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.btn_end);
			this.Controls.Add(this.btn_off);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.shapeContainer1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape5;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape4;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape3;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape2;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_off;
        private System.Windows.Forms.Button btn_end;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button mysql_connect;
        private System.Windows.Forms.TextBox host;
        private System.Windows.Forms.Button mysql_disconnect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Label9;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox pwd;
    }
}

