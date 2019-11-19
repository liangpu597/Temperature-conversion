using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.RegularExpressions;



namespace Wealther
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //先将这些函数全部解除绑定
            this.sheShitextBox.TextChanged -= new EventHandler(sheShitextBox_TextChanged);
            this.lieShitextBox.TextChanged -= new EventHandler(lieShitextBox_TextChanged);
            this.jueDuitextBox.TextChanged -= new EventHandler(jueDuitextBox_TextChanged);
            this.huaShitextBox.TextChanged -= new EventHandler(huaShitextBox_TextChanged);
            this.lanShitextBox.TextChanged -= new EventHandler(lanShitextBox_TextChanged);
            
            //if (this.sheShitextBox.Text == "" && this.huaShitextBox.Text == "" && this.lanShitextBox.Text =="" && 
            //    this.jueDuitextBox.Text == "" && this.lieShitextBox.Text == "")
            //    MessageBox.Show("输入不能为空，请在以上任意一个文本框中输入查询内容(请勿在多个文本框中进行输入)");
            int counts = 0;   //记录非空的文本框个数
            string textName="";    //记录非空的文本框名字 不是内容

            //记录非空的文本框名字以及数量
            foreach (Control ctrl in Controls)
            {
                if (ctrl is TextBox)
                {
                    if (ctrl.Text != "")
                    {
                        counts++;
                        textName = ctrl.Name;
                    }
                }
            }
            //全为空 提示
            if (counts == 0)
            {
                MessageBox.Show("输入不能为空，请在以上任意一个文本框中输入查询内容(请勿在多个文本框中进行输入)");
                clearallText();
            }
            //if (counts > 1)
            //{
            //    MessageBox.Show("只能在一个文本框进行输入 请勿在多个文本框中输入");
            //    clearallText();
            //}
            if (counts == 1)            //因为有了前面的textChanged检测 就能保证只能在一个文本框中进行输入
            {
                try
                {
                    double sheshi, huaShi, jueDui, lanShi, lieShi;

                    if (textName == "sheShitextBox") 
                    {
                        
                        sheshi = double.Parse(this.sheShitextBox.Text);
                        huaShi = sheshi * 1.8 + 32;
                        jueDui = sheshi + 273.15;
                        lanShi = sheshi * 1.8 + 32 + 459.67;
                        lieShi = sheshi * 0.8;
                        lieShitextBox.Text = Convert.ToString(lieShi);
                        huaShitextBox.Text = Convert.ToString(huaShi);
                        lanShitextBox.Text = Convert.ToString(lanShi);
                        jueDuitextBox.Text = Convert.ToString(jueDui);

                    }
                    else if (textName == "jueDuitextBox") 
                    {
                        
                        jueDui = double.Parse(this.jueDuitextBox.Text);
                        sheshi = jueDui - 273.15;
                        huaShi = jueDui * 1.8 - 459.67;
                        lanShi = jueDui * 1.8;
                        lieShi = (jueDui - 273.15) * 0.8;
                        sheShitextBox.Text = Convert.ToString(sheshi);
                        huaShitextBox.Text = Convert.ToString(huaShi);
                        lanShitextBox.Text = Convert.ToString(lanShi);
                        lieShitextBox.Text = Convert.ToString(lieShi);
                    }
                    else if (textName == "lieShitextBox") 
                    {
             
                        lieShi = double.Parse(this.lieShitextBox.Text);
                        sheshi = lieShi * 1.25;
                        huaShi = lieShi * 2.25 + 32;
                        jueDui = lieShi * 1.25 + 273.15;
                        lanShi = lieShi * 2.25 + 32 + 459.67;
                        sheShitextBox.Text = Convert.ToString(sheshi);
                        huaShitextBox.Text = Convert.ToString(huaShi);
                        jueDuitextBox.Text = Convert.ToString(jueDui);
                        lanShitextBox.Text = Convert.ToString(lanShi);

                    }
                    else if (textName == "huaShitextBox") 
                    {
                        huaShi = double.Parse(this.huaShitextBox.Text);
                        sheshi = (huaShi - 32) / 1.8;
                        jueDui = (huaShi + 459.67) / 1.8;
                        lanShi = huaShi + 459.67;
                        lieShi = (huaShi - 32) / 2.25;
                        sheShitextBox.Text = Convert.ToString(sheshi);
                        jueDuitextBox.Text = Convert.ToString(jueDui);
                        lanShitextBox.Text = Convert.ToString(lanShi);
                        lieShitextBox.Text = Convert.ToString(lieShi);

                    }
                    else if (textName == "lanShitextBox") 
                    {
                 
                        lanShi = double.Parse(this.lanShitextBox.Text);
                        sheshi = (lanShi - 32 - 459.67) / 1.8;
                        huaShi = lanShi - 459.67;
                        jueDui = lanShi / 1.8;
                        lieShi = (lanShi - 32 - 459.67) / 2.25;
                        sheShitextBox.Text = Convert.ToString(sheshi);
                        huaShitextBox.Text = Convert.ToString(huaShi);
                        jueDuitextBox.Text = Convert.ToString(jueDui);
                        lieShitextBox.Text = Convert.ToString(lieShi);
                    }


                }
                catch
                {
                    MessageBox.Show("数据格式不对，请重新输入");
                    clearallText();
                }
             
             
            }
            /*
            //方法一：使用正则表达式 判断是否是小数
            string regrx = @"^\d+.?\d+$";    // .?  匹配前面的字符0次或者1次
            bool result = Regex.IsMatch(this.sheShitextBox.Text, regrx);
            MessageBox.Show( Convert.ToString(result));     //bool类型的不可以直接转换成string
            /*
             * */
            /*
           try
           {
               //方法二 强制转换成double 看看能不能强制转换成功 
               double num1;
               num1 = double.Parse(this.sheShitextBox.Text);
               //这里强制转换 对于全是空的情况是不能判断的
               MessageBox.Show(Convert.ToString(num1));
               string name = this.sheShitextBox.Text;
           }
           catch
           {
               MessageBox.Show("格式不对，请重新输入");
               foreach (Control ctrl in Controls)
               {
                   if (ctrl is TextBox)
                   {
                       ctrl.Text = "";
                   }
               }
           }
           */
            //上面是解除绑定 这里button 函数已经完成了 需要重新绑定了
            this.sheShitextBox.TextChanged += new EventHandler(sheShitextBox_TextChanged);
            this.lieShitextBox.TextChanged += new EventHandler(lieShitextBox_TextChanged);
            this.jueDuitextBox.TextChanged += new EventHandler(jueDuitextBox_TextChanged);
            this.huaShitextBox.TextChanged += new EventHandler(huaShitextBox_TextChanged);
            this.lanShitextBox.TextChanged += new EventHandler(lanShitextBox_TextChanged);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            clearallText();
        }
        private void clearallText()
        {
            foreach (Control ctrl in Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
            }
        }
        private void clealthis(object sender)
        {
            foreach (Control ctrl in Controls)
            {
                if (ctrl is TextBox)
                {
                    if (ctrl != sender)
                        ctrl.Text = "";
                }
            }
        }

        private void sheShitextBox_TextChanged(object sender, EventArgs e)
        {
            //这里会出现问题 就是当你这个文本框改变的时候 想要把其他的文本框全部置为空
            //但是 每个text里面都这样写的话， 那么其他改变的时候 (也会认为是Changed) 这样就会把这个
            //新输入的数据给清空了

            //解决方法 ： 在其他的还保持前面的计算的值(5个文本框全部填满) 一旦想要对于某一个文本框进行输入新的
            //的值的时候，率先改变的肯定是这个 所以会触发它对应的textChanged函数。
            //这个时候把其他的值全部置为空
            //然后在button 按钮事件的开始关闭 textchanged 的检测就可以了.
            //这样最后计算完成后 对每个文本框重新赋值的时候也不会调用这个检测 
            //从而置为空 而清空为0了
            //也可以这样想： 对于一个文本框来说，改变的情况就两种情况： 1. 置为空 2. 置为其他的值
            //置为0的话 ，说明是由其他的文本框重新进行输入，进行查询的。也就是说，不是这个文本框进行查询的 那么此时
            // 虽然这个改变了，但是不及进行调整
            //或者是置为其他的值的话，两种情况：
            //（1）这个文本框来进行查询的，这个时候 把其他几个不相干的文本框全部置为 空
            //（2） 点击了按钮重新查询了，更新了新的值了。 它虽然改变了，并且不是空。但是这个是正常的情况
            //不需要把其他的置为空。 解决方法： 这个改变是由于点击了查询按钮造成的，所以，在进入查询按钮的时候
            //把这个TextChanged()函数给它关掉就可以了
            //这样 TextChange函数只有两个功能

            clealthis(this.sheShitextBox);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "温度转换小工具";
        }
        //以下这些代码虽然没有用 但是不能删除，删除了就跑不起来了
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

       
        private void huaShitextBox_TextChanged(object sender, EventArgs e)
        {
            clealthis(this.huaShitextBox);
            /*
             * 这个也省略了 直接调用上面这个了
             * 下面的几个函数也是这样
            if (this.huaShitextBox.Text != "")
            {
                foreach (Control ctrl in Controls)
                {
                    if (ctrl is TextBox)
                    {
                        if (ctrl != this.huaShitextBox)
                            ctrl.Text = "";
                    }
                }
            }
            */
        }
        //private void huaShitextBox_TextChanged(object sender, EventArgs e)
        //{
        //    if (this.huaShitextBox.Text != "")
        //    {
        //        foreach (Control ctrl in Controls)
        //        {
        //            if (ctrl is TextBox)
        //            {
        //                if (ctrl != this.huaShitextBox)
        //                    ctrl.Text = "";
        //            }
        //        }
        //    }
        //}
        private void jueDuitextBox_TextChanged(object sender, EventArgs e)
        {
            clealthis(this.jueDuitextBox);
        }

        private void lanShitextBox_TextChanged(object sender, EventArgs e)
        {
            clealthis(this.lanShitextBox);
        }

        private void lieShitextBox_TextChanged(object sender, EventArgs e)
        {
            clealthis(this.lieShitextBox);
        }
    }
}
