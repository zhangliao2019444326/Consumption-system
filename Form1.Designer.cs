namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.gradBox = new System.Windows.Forms.TextBox();
            this.balanceBox = new System.Windows.Forms.TextBox();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.likeBox = new System.Windows.Forms.TextBox();
            this.totalBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.closebutton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nameBox.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.nameBox.Location = new System.Drawing.Point(86, 21);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(187, 24);
            this.nameBox.TabIndex = 6;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // idBox
            // 
            this.idBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.idBox.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.idBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.idBox.Location = new System.Drawing.Point(86, 64);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(187, 24);
            this.idBox.TabIndex = 7;
            this.idBox.TextChanged += new System.EventHandler(this.idBox_TextChanged);
            // 
            // gradBox
            // 
            this.gradBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gradBox.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gradBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.gradBox.Location = new System.Drawing.Point(86, 112);
            this.gradBox.Name = "gradBox";
            this.gradBox.Size = new System.Drawing.Size(187, 24);
            this.gradBox.TabIndex = 8;
            this.gradBox.TextChanged += new System.EventHandler(this.gradBox_TextChanged);
            // 
            // balanceBox
            // 
            this.balanceBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.balanceBox.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.balanceBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.balanceBox.Location = new System.Drawing.Point(86, 153);
            this.balanceBox.Name = "balanceBox";
            this.balanceBox.Size = new System.Drawing.Size(187, 24);
            this.balanceBox.TabIndex = 9;
            this.balanceBox.TextChanged += new System.EventHandler(this.balanceBox_TextChanged);
            // 
            // timeBox
            // 
            this.timeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.timeBox.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.timeBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.timeBox.Location = new System.Drawing.Point(86, 195);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(187, 24);
            this.timeBox.TabIndex = 10;
            this.timeBox.TextChanged += new System.EventHandler(this.timeBox_TextChanged);
            // 
            // likeBox
            // 
            this.likeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.likeBox.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.likeBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.likeBox.Location = new System.Drawing.Point(86, 241);
            this.likeBox.Name = "likeBox";
            this.likeBox.Size = new System.Drawing.Size(187, 24);
            this.likeBox.TabIndex = 11;
            this.likeBox.TextChanged += new System.EventHandler(this.likeBox_TextChanged);
            // 
            // totalBox
            // 
            this.totalBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.totalBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBox.ForeColor = System.Drawing.Color.Red;
            this.totalBox.Location = new System.Drawing.Point(298, 193);
            this.totalBox.Multiline = true;
            this.totalBox.Name = "totalBox";
            this.totalBox.Size = new System.Drawing.Size(261, 38);
            this.totalBox.TabIndex = 12;
            this.totalBox.TextChanged += new System.EventHandler(this.totalBox_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Menu;
            this.button3.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button3.Location = new System.Drawing.Point(361, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 29);
            this.button3.TabIndex = 15;
            this.button3.Text = "充值";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Menu;
            this.button4.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button4.Location = new System.Drawing.Point(435, 153);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 29);
            this.button4.TabIndex = 16;
            this.button4.Text = "打烊";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox1.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(298, 21);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(261, 112);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.ForeColor = System.Drawing.Color.Red;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(333, 243);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(72, 22);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 4800;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Menu;
            this.button1.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(411, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 27);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // closebutton
            // 
            this.closebutton.BackColor = System.Drawing.SystemColors.Menu;
            this.closebutton.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.closebutton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.closebutton.Location = new System.Drawing.Point(497, 153);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(62, 29);
            this.closebutton.TabIndex = 21;
            this.closebutton.Text = "关闭";
            this.closebutton.UseVisualStyleBackColor = false;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Menu;
            this.button5.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button5.Location = new System.Drawing.Point(298, 153);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(57, 29);
            this.button5.TabIndex = 22;
            this.button5.Text = "开启";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Menu;
            this.button2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button2.Location = new System.Drawing.Point(38, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 24);
            this.button2.TabIndex = 23;
            this.button2.Text = "会名";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Menu;
            this.button6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button6.Location = new System.Drawing.Point(38, 64);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(42, 24);
            this.button6.TabIndex = 24;
            this.button6.Text = "卡号";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Menu;
            this.button7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button7.Location = new System.Drawing.Point(38, 112);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(42, 24);
            this.button7.TabIndex = 25;
            this.button7.Text = "等级";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.Menu;
            this.button8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button8.Location = new System.Drawing.Point(38, 153);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(42, 24);
            this.button8.TabIndex = 26;
            this.button8.Text = "余额";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.Menu;
            this.button9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button9.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button9.Location = new System.Drawing.Point(38, 195);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(42, 24);
            this.button9.TabIndex = 27;
            this.button9.Text = "时间";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.Menu;
            this.button10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button10.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button10.Location = new System.Drawing.Point(38, 241);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(42, 24);
            this.button10.TabIndex = 28;
            this.button10.Text = "喜好";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.Menu;
            this.button11.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button11.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button11.Location = new System.Drawing.Point(497, 240);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(53, 27);
            this.button11.TabIndex = 29;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(572, 278);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.closebutton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.totalBox);
            this.Controls.Add(this.likeBox);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.balanceBox);
            this.Controls.Add(this.gradBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.nameBox);
            this.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Name = "Form1";
            this.Text = "酒吧消费系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox gradBox;
        private System.Windows.Forms.TextBox balanceBox;
        private System.Windows.Forms.TextBox timeBox;
        private System.Windows.Forms.TextBox likeBox;
        public System.Windows.Forms.TextBox totalBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button closebutton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
    }
}

