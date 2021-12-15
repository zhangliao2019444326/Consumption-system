using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class 充值 : Form
    {
        public 充值()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connstr1 = "server = 127.0.0.1; port = 3306; user = root ; password = zhang520; database = zhangliao";
            MySqlConnection conn1 = new MySqlConnection(connstr1);

            try
            {
                //可能出现异常
                conn1.Open();
                string sql = "update winformtable set balance=balance+@para2 where id = @para1";
                MySqlCommand cmd = new MySqlCommand(sql, conn1);
                cmd.Parameters.AddWithValue("para1", textBox1.Text);
                cmd.Parameters.AddWithValue("para2",textBox2.Text);
                int result = cmd.ExecuteNonQuery();    //增删改和查询的区别


                if (result.Equals(1))
                {
                    
                    MessageBox.Show("充值成功!");
               
                  
                }
                else
                {
                    MessageBox.Show("充值失败!");
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
    }
}
