using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightApplication
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            DataClass.initialize();
            if (DataClass.list.Count != 3)
                if (MessageBox.Show("只读取到了" + DataClass.list.Count + "种(应该为3种)巡航模式，可能会导致程序崩溃。\n请点击确定关闭本程序，并检查csv文件是否完全！或点击取消继续打开程序", "严重警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                    Application.Exit();
        }

        private void comboBox巡航方式_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox巡航方式.Text == "经济巡航")
                this.textBox成本指数.Enabled = true;
            else
                this.textBox成本指数.Enabled = false;
        }

        /**
         * 返回错误输入的方框号
         * 1.巡航开始重量m
         * 2.巡航高度Hp
         * 3.温度偏差ΔT
         * 4.巡航距离
         * 5.巡航方式
         * 6.成本指数Ci
         * 7.有方框是空的
         */
        private int checkNumbersCurrect()
        {
            int returnNum = 0;
            try
            {
                double temp = double.Parse(this.textBox巡航开始重量.Text);
                if (temp < 50000 | temp > 75000)
                    returnNum = 1;

                temp = double.Parse(this.textBox温度偏差.Text);
                if (temp < -10 || temp > 20)
                    returnNum = 3;

                temp = double.Parse(this.textBox巡航距离.Text);
                if (temp < 1 || temp > 3000)
                    returnNum = 4;

                if(this.comboBox巡航方式.Text == "经济巡航")
                    if (double.Parse(this.textBox成本指数.Text) < 0 || double.Parse(this.textBox成本指数.Text) > 100) 
                        returnNum = 6;
            }
            catch
            {
                returnNum = 7;
            }
            return returnNum;
        }

        private void giveWarning(int warningIndex)
        {
            switch(warningIndex)
            {
                case 1:
                    MessageBox.Show("请输入50000KG-75000KG内的整数", "巡航开始重量 警告");
                    break;
                case 3:
                    MessageBox.Show("请输入-10℃至+20℃任意整数", "温度偏差 警告");
                    break;
                case 4:
                    MessageBox.Show("请输入1KM-3000KM内的整数", "巡航距离 警告");
                    break;
                case 6:
                    MessageBox.Show("请输入0-100内的整数", "成本指数 警告");
                    break;
                case 7:
                    MessageBox.Show("不能有空白文本框！", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void calculateEverything(Item item)
        {
            item.calculateFF0();
            item.calculateF0FromFF0();
            item.calculateIj0();
            item.calculateIj();
            item.calculateEj(int.Parse(this.textBox巡航距离.Text));
            item.calculateCrsFuel(int.Parse(this.textBox巡航距离.Text));
            item.calculateCrsTime(int.Parse(this.textBox巡航距离.Text));
            item.set排放量变量();
            item.calculate巡航总成本(double.Parse(this.textBox燃油价格fuelPrice.Text)
                , double.Parse(this.textBox时间价格timePrice.Text)
                , double.Parse(this.textBoxHC排放价格.Text)
                , double.Parse(this.textBoxCO排放价格.Text)
                , double.Parse(this.textBoxNOx排放价格.Text)
                , double.Parse(this.textBoxCO2排放价格.Text));
        }

        private Boolean equals(Item item,double 巡航开始重量,double 巡航高度,double 温度偏差,String 巡航方式,double 成本指数)
        {
            
            bool flag = true;
            if (item.WEIGHT != 巡航开始重量) flag = false;
            if (item.ALT != 巡航高度) flag = false;
            if (item.ISA != 温度偏差) flag = false;
            if (item.CI != -1 && item.CI != 成本指数) flag = false;
            return flag;
        }

        int datagridviewIndex = 0;//当前的行号

        private void button开始计算_Click(object sender, EventArgs e)
        {
            int warn = checkNumbersCurrect();
            if (warn != 0)
            {
                this.giveWarning(warn);
                return;
            }

            foreach (Section section in DataClass.list)
            {
                if (section.mode != this.comboBox巡航方式.Text)
                    continue;

                //this.dataGridView.Rows.Clear();

                foreach (Item item in section.itemList)
                {
                    this.calculateEverything(item);

                    //this.dataGridView.DataSource = section.itemList;//C#的自动画表格功能，可以替代下面10行代码
                    if (
                        equals(item
                            , double.Parse(this.textBox巡航开始重量.Text)
                            , double.Parse(this.comboBox巡航高度.Text)
                            , double.Parse(this.textBox温度偏差.Text)
                            , this.comboBox巡航方式.Text
                            , double.Parse(this.textBox成本指数.Text)))
                    {
                        //以下是手动输出模块
                        this.dataGridView.Rows.Add();//添加一个空行

                        this.dataGridView.Rows[datagridviewIndex].Cells[0].Value = item.巡航消耗油量;
                        this.dataGridView.Rows[datagridviewIndex].Cells[1].Value = item.总巡航时间;
                        this.dataGridView.Rows[datagridviewIndex].Cells[2].Value = item.HC排放量;
                        this.dataGridView.Rows[datagridviewIndex].Cells[3].Value = item.CO排放量;
                        this.dataGridView.Rows[datagridviewIndex].Cells[4].Value = item.NOx排放量;
                        this.dataGridView.Rows[datagridviewIndex].Cells[5].Value = item.CO2排放量;
                        this.dataGridView.Rows[datagridviewIndex].Cells[6].Value = item.巡航总成本;


                        datagridviewIndex++;
                    }
                }


            }
        }
    }
}
