namespace Wealther
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.sheShitextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.huaShitextBox = new System.Windows.Forms.TextBox();
            this.jueDuitextBox = new System.Windows.Forms.TextBox();
            this.lanShitextBox = new System.Windows.Forms.TextBox();
            this.lieShitextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "重置";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(420, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "计算";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sheShitextBox
            // 
            this.sheShitextBox.Location = new System.Drawing.Point(333, 31);
            this.sheShitextBox.Name = "sheShitextBox";
            this.sheShitextBox.Size = new System.Drawing.Size(100, 21);
            this.sheShitextBox.TabIndex = 2;
            this.sheShitextBox.TextChanged += new System.EventHandler(this.sheShitextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "华氏温度";
            // 
            // huaShitextBox
            // 
            this.huaShitextBox.Location = new System.Drawing.Point(333, 72);
            this.huaShitextBox.Name = "huaShitextBox";
            this.huaShitextBox.Size = new System.Drawing.Size(100, 21);
            this.huaShitextBox.TabIndex = 4;
            this.huaShitextBox.TextChanged += new System.EventHandler(this.huaShitextBox_TextChanged);
            // 
            // jueDuitextBox
            // 
            this.jueDuitextBox.Location = new System.Drawing.Point(333, 114);
            this.jueDuitextBox.Name = "jueDuitextBox";
            this.jueDuitextBox.Size = new System.Drawing.Size(100, 21);
            this.jueDuitextBox.TabIndex = 5;
            this.jueDuitextBox.TextChanged += new System.EventHandler(this.jueDuitextBox_TextChanged);
            // 
            // lanShitextBox
            // 
            this.lanShitextBox.Location = new System.Drawing.Point(333, 165);
            this.lanShitextBox.Name = "lanShitextBox";
            this.lanShitextBox.Size = new System.Drawing.Size(100, 21);
            this.lanShitextBox.TabIndex = 6;
            this.lanShitextBox.TextChanged += new System.EventHandler(this.lanShitextBox_TextChanged);
            // 
            // lieShitextBox
            // 
            this.lieShitextBox.Location = new System.Drawing.Point(333, 212);
            this.lieShitextBox.Name = "lieShitextBox";
            this.lieShitextBox.Size = new System.Drawing.Size(100, 21);
            this.lieShitextBox.TabIndex = 7;
            this.lieShitextBox.TextChanged += new System.EventHandler(this.lieShitextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "摄氏温度";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "绝对温度";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "兰氏度";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "列氏度";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(618, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 14);
            this.label6.TabIndex = 12;
            this.label6.Text = "By: 蒲良";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(618, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 14);
            this.label7.TabIndex = 13;
            this.label7.Text = "2019-11-18";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lieShitextBox);
            this.Controls.Add(this.lanShitextBox);
            this.Controls.Add(this.jueDuitextBox);
            this.Controls.Add(this.huaShitextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sheShitextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox sheShitextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox huaShitextBox;
        private System.Windows.Forms.TextBox jueDuitextBox;
        private System.Windows.Forms.TextBox lanShitextBox;
        private System.Windows.Forms.TextBox lieShitextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

