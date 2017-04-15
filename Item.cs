using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightApplication
{
    /*该手机是基础数据类，包括对数据的计算*/
    class Item
    {
        /**
         * 基础数据
         * 访问属性：公有，外界可以访问
         * 写入方式：外界DataClass负责写入
         */
        public int ALT;//高度Hp，单位m
        public int ISA;//温度偏差delta T,单位。C
        public int WEIGHT;//飞机质量m，单位KG
        public double MACH;//飞行马赫数Ma，无单位
        public double FFENG;//燃油流量wf，单位KG/h
        public int TAS
        {
            
            set { tas = value; speed = (double)value * 1.852; }
        }//真空速Vti，单位knots节，提取后化为KM/h,1knots=1.852KM/h
        private int tas;
        public double speed;

        public int CI = -1;//空值为-1



        /**
         * CFM56-7B26发动机基准排放数据
         * 访问属性：公有只读
         */
        public readonly double[,] CFM56_7B26 =
        {
            //飞行阶段，HC指数，CO指数，NOx指数，CO2指数，燃油流量
            {    1    ,0.0001,0.0002 ,0.0288 ,3.115   ,1.221 },
            {    2    ,0.0001,0.0006 ,0.0225 ,3.115   ,0.999 },
            {    3    ,0.0001,0.0016 ,0.0108 ,3.115   ,0.338 },
            {    4    ,0.0019,0.0188 ,0.0047 ,3.115   ,0.113 }
        };



        /**
         * 拓展数据（通过后期计算所得的数据）
         * 访问属性：私有有，外界不可以访问
         * 写入方式：类内函数计算求得
         */
        private double FF0 = 0; //修正燃油流量
        private double F0 = 0; //单位化的修正燃油流量
        private double[] Ij0 = { 0, 0, 0, 0 /*HC指数，CO指数，NOx指数，CO2指数*/}; //参考排放指数
        private double[] Ij = { 0, 0, 0, 0 }; //实际排放指数
        private double[] Ej = { 0, 0, 0, 0 }; //排放量
        public double 巡航消耗油量 { get; set; } //crsFuel巡航消耗油量
        public double 总巡航时间 { get; set; } //crsTime总巡航时间
        public double HC排放量 { get; set; }
        public double CO排放量 { get; set; }
        public double NOx排放量 { get; set; }
        public double CO2排放量 { get; set; }
        public double 巡航总成本 { get; set; } //totalCost巡航总成本

        /**
         * 类内计算函数
         */
        public void calculateFF0()
        {
            FF0 = FFENG / getDelta() * Math.Pow(getTheta(), 3.8) * Math.Pow(Math.E, 0.2) * MACH * MACH;
        }

        public void calculateF0FromFF0()
        {
            F0 = FF0 / 3600;
        }

        private double getDelta()
        {
            double delta = 0;
            if (ALT <= 11000)
                delta = Math.Pow((1 - 2.25577e-5 * ALT), 5.25588);
            else if (ALT <= 20000)
                delta = 0.2233609 * Math.Pow(Math.E, (11000 - ALT) / 6341.62);
            return delta;
        }

        private double getTheta()
        {
            double theta = 0;
            if (ALT <= 11000)
                theta = (288.15 + ISA - ALT * 0.0065) / 288.15;
            else if (ALT <= 20000)
                theta = 0.75186535;
            return theta;
        }

        public double getIj0(int index)
        {
            return Ij0[index];
        }

        private double getPhi()
        {
            return 0.6;
        }
        
        private double getPv()
        {
            return 0.014504 * Math.Pow(10, getBeta());
        }

        private double getBeta()
        {
            double result;
            result = 7.90298 * (1 - 373.16 / (getTamb() + 273.16));
            result += 3.00571;
            result += 5.02808 * Math.Log10(373.16 / (getTamb() + 273.16));
            result += 1.3816e-7 * (1 - Math.Pow(10, 11.344 * (1 - (getTamb() + 273.16) / 373.16)));
            result += 8.1328e-3 * (Math.Pow(10, 3.49149 * (1 - 373.16 / (getTamb() + 273.16))) - 1);
            return result;
        }

        private double getTamb()
        {
            double result = 0;
            if (this.ALT <= 11000)
                result = 15 + this.ISA - 0.0065 * this.ALT;
            else if (this.ALT <= 20000)
                result = -56.5;
            return result;
        }

        private double getP()
        {
            return getDelta() * 1013.25;//delta*P0
        }

        public void calculateIj0()
        {
            double F1 = CFM56_7B26[0, 5], F2 = CFM56_7B26[1, 5], F3 = CFM56_7B26[2, 5], F4 = CFM56_7B26[3, 5];
            
            for (int i = 0; i < 4; i++)//HC指数，CO指数，NOx指数，CO2指数
            {
                double Ij1 = CFM56_7B26[0, i + 1], Ij2 = CFM56_7B26[1, i + 1], Ij3 = CFM56_7B26[2, i + 1], Ij4 = CFM56_7B26[3, i + 1];
                if (this.F0 <= F3)
                {
                    this.Ij0[i] = (Ij3 - Ij4) * (F0 - F4) / (F3 - F4) + Ij4;
                }
                else if (this.F0 <= F2)
                {
                    this.Ij0[i] = (Ij2 - Ij3) * (F0 - F3) / (F2 - F3) + Ij3;
                }
                else if (F2 < this.F0)
                {
                    this.Ij0[i] = (Ij1 - Ij2) * (F0 - F2) / (F1 - F2) + Ij2;
                }
            }
        }

        public void calculateIj()
        {
            Ij[0] = Ij0[0] * Math.Pow(getTheta(), 3.3) / Math.Pow(getDelta(), 1.02);
            Ij[1] = Ij0[1] * Math.Pow(getTheta(), 3.3) / Math.Pow(getDelta(), 1.02);
            Ij[2] = Ij0[2] * Math.Pow(getDelta(), 0.51) / Math.Pow(getTheta(), 1.65);
            Ij[2] *= Math.Exp(19.0 * ((0.0063 - 0.622 * getPhi() * getPv()) / (getP()-getPhi()*getPv()) ));
            Ij[3] = Ij0[3];
        }

        public void calculateEj(int 巡航距离)
        {
            for (int i = 0; i < 4; i++)
                Ej[i] = 2 * this.FFENG * Ij[i] * 巡航距离 / this.speed;
        }

        public void calculateCrsFuel(int 巡航距离)
        {
            this.巡航消耗油量 = 2 * this.FFENG * 巡航距离 / this.speed;
        }

        public void calculateCrsTime(int 巡航距离)
        {
            this.总巡航时间 = 巡航距离 / this.speed;
        }

        public void set排放量变量()
        {
            this.HC排放量 = Ej[0];
            this.CO排放量 = Ej[1];
            this.NOx排放量 = Ej[2];
            this.CO2排放量 = Ej[3];
        }

        public void calculate巡航总成本(double 燃油价格, double 时间价格, double HC排放价格, double CO排放价格, double NOx排放价格, double CO2排放价格)
        {
            this.巡航总成本 = this.巡航消耗油量 * 燃油价格 + this.总巡航时间 * 时间价格 + Ej[0] * HC排放价格 + Ej[1] * CO排放价格 + Ej[2] * NOx排放价格 + Ej[3] * CO2排放价格;
        }
    }
}
