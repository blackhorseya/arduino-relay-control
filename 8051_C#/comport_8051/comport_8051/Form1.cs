using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using Microsoft.VisualBasic.PowerPacks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace comport_8051
{
    public partial class Form1 : Form
    {
        SerialPort serialport = new SerialPort();
        Boolean serialportopen = false,mysqlopen = false;
        private Color[] MsgTypeColor = { Color.Blue, Color.Green, Color.Black, Color.Orange, Color.Red };
        public enum MsgType { System, User, Normal, Warning, Error };
        int id;
        string msbuff;
        OvalShape[] array;
        private string dbhost, dbname, dbpass, dbuser, dbchar, connstr;
        MySqlConnection conn;

        public Form1()
        {
            InitializeComponent();
            button1.Click += new EventHandler(button_Click);
            button2.Click += new EventHandler(button_Click);
            button3.Click += new EventHandler(button_Click);
            button4.Click += new EventHandler(button_Click);
            button5.Click += new EventHandler(button_Click);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            backgroundWorker1.WorkerSupportsCancellation = true;
            timer1.Interval = 1000;
            comboBox1.Items.Clear();
            array = new OvalShape[5] { ovalShape1, ovalShape2, ovalShape3, ovalShape4, ovalShape5 };
            foreach (string com in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(com);
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            id = int.Parse(btn.Text.Substring(4));
            try 
            {
                serialport.Write(btn.Text.Substring(4));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("確定要關閉程式?", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (serialportopen == false && !serialport.IsOpen)
            {
                try
                {
                    //設定連接埠9600、n、8、1、n
                    serialport.PortName = comboBox1.Text;
                    serialport.BaudRate = 9600;
                    serialport.DataBits = 8;
                    serialport.Parity = Parity.None;
                    serialport.StopBits = StopBits.One;
                    serialport.Encoding = Encoding.Default;//傳輸編碼方式
                    serialport.Open();
                    timer1.Enabled = true;
                    serialportopen = true;
                    btn_true();

                    if (this.backgroundWorker1.WorkerReportsProgress != true)
                    {
                        this.backgroundWorker1.WorkerReportsProgress = true;
                        this.backgroundWorker1.RunWorkerAsync();
                    }
                    btn_connect.Text = "中斷";

                    serialport.Write("0");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else if (serialportopen == true && serialport.IsOpen)
            {
                try
                {
                    serialport.Close();
                    timer1.Enabled = false;
                    serialportopen = false;
                    btn_false();
                    this.backgroundWorker1.WorkerReportsProgress = false;
                    this.backgroundWorker1.CancelAsync();
                    this.backgroundWorker1.Dispose();
                    btn_connect.Text = "連線";
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void Initialize()
        {
            dbhost = host.Text;
            dbuser = user.Text;
            dbpass = pwd.Text;
            dbname = "8051_test";
            dbchar = "utf8";

            connstr = "server=" + dbhost + ";uid=" + dbuser + ";pwd=" + dbpass + ";database=" + dbname + ";CharSet=" + dbchar;
            conn = new MySqlConnection(connstr);
        }

        private void btn_false()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            btn_off.Enabled = false;
        }

        private void btn_true()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            btn_off.Enabled = true;
        }

        private void btn_off_Click(object sender, EventArgs e)
        {
            serialport.Write("0");
            if (mysqlopen == true)
            {
                try
                {
                    for (int i = 1; i < 6; i++)
                    {
                        update(i.ToString(), 0, 99);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (; ; )
            {
                if (backgroundWorker1.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    try
                    {
                        backgroundWorker1.ReportProgress(0);
                        System.Threading.Thread.Sleep(100);
                    }
                    catch (Exception)
                    {
                        e.Cancel = true;
                        break;
                    }
                }
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                if (serialport.BytesToRead != 0)
                {
                    msbuff = serialport.ReadExisting();

                    //接收判斷燈號
                    if (msbuff == "1")
                    {
                        array[id - 1].FillColor = Color.FromArgb(0, 255, 0);
                        update(Convert.ToString(id), 0, id);
                    }
                    else if (msbuff == "0")
                    {
                        array[id - 1].FillColor = Color.FromArgb(255, 0, 0);
                        update(Convert.ToString(id), 1, id);

                    }
                    else if (msbuff == "2")
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            array[i].FillColor = Color.FromArgb(0, 255, 0);
                        }
                    }
                    else
                    {
                        AddText(MsgType.Error, "連線失敗" + "\r\n");
                    }

                    serialport.DiscardInBuffer();
                }
            }
            catch (Exception)
            {

            }
        }

        private void AddText(MsgType msgtype, string msg)
        {
            richTextBox1.Invoke(new EventHandler(delegate
            {
                richTextBox1.SelectedText = string.Empty;
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold);
                richTextBox1.SelectionColor = MsgTypeColor[(int)msgtype];
                richTextBox1.AppendText(msg);
                richTextBox1.ScrollToCaret();
            }));
        }

        private bool connect()
        {
            Initialize();
            try
            {
                AddText(MsgType.System, "IP : " + dbhost + "\r\n");
                conn.Open();
                mysql_connect.Enabled = false;
                mysql_disconnect.Enabled = true;
                mysqlopen = true;
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        AddText(MsgType.Warning, "無法連線到資料庫\r\n");
                        break;
                    case 1045:
                        AddText(MsgType.Warning, "使用者帳號或密碼錯誤\r\n");
                        break;
                    case 1042:
                        AddText(MsgType.Warning, "無效的主機名稱\r\n");
                        break;
                }
                return false;
            }
        }

        private bool disconnect()
        {
            try
            {
                conn.Close();
                mysqlopen = false;
                mysql_connect.Enabled = true;
                mysql_disconnect.Enabled = false;
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        //查詢
        private void select()
        {
            string sql = "SELECT * FROM test_8051";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader mydata = cmd.ExecuteReader();

            if (!mydata.HasRows)
            {
                AddText(MsgType.User, "no data");
            }
            else
            {
                while (mydata.Read())
                {
                    for (int i = 1; i < 6; i++)
                    {
                        AddText(MsgType.User, mydata.GetString(i));
                    }
                    AddText(MsgType.User, "\r\n");

                    for (int i = 1; i < 6; i++)
                    {
                        if (mydata.GetString(i) == "0")
                        {
                            if (array[i - 1].FillColor == Color.FromArgb(255, 0, 0))
                            {
                                serialport.Write(Convert.ToString(i));
                                array[i - 1].FillColor = Color.FromArgb(0, 255, 0);
                            }
                        }
                        else if (mydata.GetString(i) == "1")
                        {
                            if (array[i - 1].FillColor == Color.FromArgb(0, 255, 0))
                            {
                                serialport.Write(Convert.ToString(i));
                                array[i - 1].FillColor = Color.FromArgb(255, 0, 0);
                            }
                        }
                        else
                        {
                            AddText(MsgType.Error, "資料錯誤" + "\r\n");
                        }
                    }
                }
            }

            mydata.Close();
        }

        //更新
        private void update(string a, int o, int s)
        {
            try
            {
                string sql = "UPDATE test_8051 SET A10" + a + " = '" + o + "', state ='" + s + "';";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void mysql_connect_Click(object sender, EventArgs e)
        {
            connect();
            select();
        }

        private void mysql_disconnect_Click(object sender, EventArgs e)
        {
            disconnect();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (mysqlopen == true)
            {
                select();
            }
        }
    }
}
