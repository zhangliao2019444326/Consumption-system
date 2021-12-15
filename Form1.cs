using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           serialPort1.Encoding = Encoding.GetEncoding("GB2312");   //串口编码引入GB2312编码(汉字编码)
            //防止跨线程操作空间异常
            Control.CheckForIllegalCrossThreadCalls = false;   //取消跨线程检查

        }

        //端口号扫描按钮
        private void button1_Click(object sender, EventArgs e)
        {
            ReflashPortToComboBox(serialPort1, comboBox1);
            closebutton.Enabled = false;//关闭串口按钮按钮使能
        }
        //自动扫描可用串口并添加到串口号列表上
        private void ReflashPortToComboBox(SerialPort serialPort, ComboBox comboBox)
        {                                                               //将可用端口号添加到ComboBox
            if (!serialPort.IsOpen)//串口处于关闭状态
            {
                comboBox.Items.Clear();
                string[] str = SerialPort.GetPortNames();
                if (str == null)
                {
                    MessageBox.Show("本机没有串口！", "Error");
                    return;
                }
                //添加串口
                foreach (string s in str)
                {
                    comboBox.Items.Add(s);
                    Console.WriteLine(s);
                }
            }
            else
            {
                MessageBox.Show("串口处于打开状态不能刷新串口列表", "Error");
            }
        }
        //窗体加载函数
        private void Form1_Load(object sender, EventArgs e)
        {
            ReflashPortToComboBox(serialPort1, comboBox1);//第一次加载时候就预先扫描一次串口号
            closebutton.Enabled = false;//关闭串口按钮按钮使能
        }
        //打开串口
        private void button5_Click(object sender, EventArgs e)
        {

            serialPort1.PortName = comboBox1.SelectedItem.ToString();//串口号
            serialPort1.BaudRate = 4800;//波特率

            try
            {
                serialPort1.Open();
                button5.Enabled = false;
                closebutton.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("串口打开失败" + ex, "error");
            }

        }
     
        private void button3_Click(object sender, EventArgs e)
        {
            充值 form2 = new 充值();
            form2.ShowDialog();
        }
        //串口数据接受事件
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            DateTime dateTime = DateTime.Now;

            //连接数据库

            /** server = 127.0.0.1或者localhost 代表本机地址; port = 3306 端口号; **/
            /** user 用户名; password 密码; database 数据库名称; **/
            string connstr = "server = 127.0.0.1; port = 3306; user = root ; password = zhang520; database = zhangliao";
            MySqlConnection conn = new MySqlConnection(connstr);
            try
            {
                string content = serialPort1.ReadExisting();//从串口控件读取输入流返回为string
                //如果接收是字符模式
                if (content!="") 
                { 
                textBox1.AppendText(content);//将接受到的string数据添加到接收窗
                    try
                    {
                        //可能出现异常
                        conn.Open();
                        string sql = "select * from winformtable where idcard = @para1";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("para1", content);
                        MySqlDataReader reader = cmd.ExecuteReader();    //增删改和查询的区别
                        if (reader.Read())
                        {
                            textBox1.AppendText("刷卡成功!\n");
                            textBox1.AppendText("欢迎您！本吧尊敬的vip用户！!\n");
                            
                            nameBox.Text = reader.GetString("name");
                            idBox.Text = reader.GetString("id");
                            balanceBox.Text = reader.GetString("balance");
                            likeBox.Text = reader.GetString("like");
                            gradBox.Text = reader.GetString("grad");
                            
                            timeBox.Text = dateTime.ToString();
                        }
                        reader.Close();
                        cmd.Cancel();
                    }
                    catch (MySqlException ex)
                    {
                        //异常则提示异常信息
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        //务必关闭MysqlConnection

                        conn.Close();
                    }


                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("数据接受出错" + ex, "error");
            }
        }
        //消费
        private void button4_Click(object sender, EventArgs e)
        {
            string connstr1 = "server = 127.0.0.1; port = 3306; user = root ; password = zhang520; database = zhangliao";
            MySqlConnection conn1 = new MySqlConnection(connstr1);

            try
            {
                //可能出现异常
                conn1.Open();
                string sql = "update winformtable set balance=balance-@para2 where id = @para1";
                MySqlCommand cmd = new MySqlCommand(sql, conn1);
                cmd.Parameters.AddWithValue("para1", idBox.Text);
                cmd.Parameters.AddWithValue("para2", totalBox.Text);
                int result = cmd.ExecuteNonQuery();    //增删改和查询的区别


                if (result.Equals(1))
                {
                    textBox1.AppendText("消费成功!\n");
                


                }
                else
                {
                    MessageBox.Show("错误!");
                }

            }
            catch (MySqlException ex)
            {
                //异常则提示异常信息
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //务必关闭MysqlConnection
                conn1.Close();
            }
        }

        //关闭串口
        private void closebutton_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
                button5.Enabled = true;
                closebutton.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("串口关闭失败" + ex, "error");
            }
        }

        private void gradBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void idBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void timeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void balanceBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void likeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void totalBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            idBox.Clear();
            nameBox.Clear();
            gradBox.Clear();
            balanceBox.Clear();
            timeBox.Clear();
            likeBox.Clear();
            totalBox.Clear();
            textBox1.Clear();
        }
    }
}
