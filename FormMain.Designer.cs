namespace FlightApplication
{
    partial class FormMain
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.巡航消耗油量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.总巡航时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HC排放量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CO排放量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOx排放量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CO2排放量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.巡航总成本 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.button开始计算 = new System.Windows.Forms.Button();
            this.textBox成本指数 = new System.Windows.Forms.TextBox();
            this.label成本指数 = new System.Windows.Forms.Label();
            this.comboBox巡航方式 = new System.Windows.Forms.ComboBox();
            this.comboBox巡航高度 = new System.Windows.Forms.ComboBox();
            this.label巡航距离_单位 = new System.Windows.Forms.Label();
            this.label温度偏差_单位 = new System.Windows.Forms.Label();
            this.label巡航高度_单位 = new System.Windows.Forms.Label();
            this.label巡航开始重量_单位 = new System.Windows.Forms.Label();
            this.textBox巡航距离 = new System.Windows.Forms.TextBox();
            this.textBox温度偏差 = new System.Windows.Forms.TextBox();
            this.textBox巡航开始重量 = new System.Windows.Forms.TextBox();
            this.label巡航方式 = new System.Windows.Forms.Label();
            this.label巡航距离 = new System.Windows.Forms.Label();
            this.label温度偏差 = new System.Windows.Forms.Label();
            this.label巡航高度 = new System.Windows.Forms.Label();
            this.label巡航开始重量 = new System.Windows.Forms.Label();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.label燃油价格fuelPrice = new System.Windows.Forms.Label();
            this.label时间价格timePrice = new System.Windows.Forms.Label();
            this.labelHC排放价格 = new System.Windows.Forms.Label();
            this.textBox燃油价格fuelPrice = new System.Windows.Forms.TextBox();
            this.textBox时间价格timePrice = new System.Windows.Forms.TextBox();
            this.textBoxHC排放价格 = new System.Windows.Forms.TextBox();
            this.label燃油价格fuelPrice_单位 = new System.Windows.Forms.Label();
            this.label时间价格timePrice_单位 = new System.Windows.Forms.Label();
            this.labelHC排放价格_单位 = new System.Windows.Forms.Label();
            this.labelCO排放价格_单位 = new System.Windows.Forms.Label();
            this.labelNOx排放价格_单位 = new System.Windows.Forms.Label();
            this.labelCO2排放价格_单位 = new System.Windows.Forms.Label();
            this.labelCO排放价格 = new System.Windows.Forms.Label();
            this.labelNOx排放价格 = new System.Windows.Forms.Label();
            this.labelCO2排放价格 = new System.Windows.Forms.Label();
            this.textBoxCO排放价格 = new System.Windows.Forms.TextBox();
            this.textBoxNOx排放价格 = new System.Windows.Forms.TextBox();
            this.textBoxCO2排放价格 = new System.Windows.Forms.TextBox();
            this.groupBoxParms = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBoxInput.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            this.groupBoxParms.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.巡航消耗油量,
            this.总巡航时间,
            this.HC排放量,
            this.CO排放量,
            this.NOx排放量,
            this.CO2排放量,
            this.巡航总成本});
            this.dataGridView.Location = new System.Drawing.Point(17, 20);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(539, 192);
            this.dataGridView.TabIndex = 0;
            // 
            // 巡航消耗油量
            // 
            this.巡航消耗油量.HeaderText = "巡航消耗油量";
            this.巡航消耗油量.Name = "巡航消耗油量";
            // 
            // 总巡航时间
            // 
            this.总巡航时间.HeaderText = "总巡航时间";
            this.总巡航时间.Name = "总巡航时间";
            // 
            // HC排放量
            // 
            this.HC排放量.HeaderText = "HC排放量";
            this.HC排放量.Name = "HC排放量";
            // 
            // CO排放量
            // 
            this.CO排放量.HeaderText = "CO排放量";
            this.CO排放量.Name = "CO排放量";
            // 
            // NOx排放量
            // 
            this.NOx排放量.HeaderText = "NOx排放量";
            this.NOx排放量.Name = "NOx排放量";
            // 
            // CO2排放量
            // 
            this.CO2排放量.HeaderText = "CO2排放量";
            this.CO2排放量.Name = "CO2排放量";
            // 
            // 巡航总成本
            // 
            this.巡航总成本.HeaderText = "巡航总成本";
            this.巡航总成本.Name = "巡航总成本";
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.button开始计算);
            this.groupBoxInput.Controls.Add(this.textBox成本指数);
            this.groupBoxInput.Controls.Add(this.label成本指数);
            this.groupBoxInput.Controls.Add(this.comboBox巡航方式);
            this.groupBoxInput.Controls.Add(this.comboBox巡航高度);
            this.groupBoxInput.Controls.Add(this.label巡航距离_单位);
            this.groupBoxInput.Controls.Add(this.label温度偏差_单位);
            this.groupBoxInput.Controls.Add(this.label巡航高度_单位);
            this.groupBoxInput.Controls.Add(this.label巡航开始重量_单位);
            this.groupBoxInput.Controls.Add(this.textBox巡航距离);
            this.groupBoxInput.Controls.Add(this.textBox温度偏差);
            this.groupBoxInput.Controls.Add(this.textBox巡航开始重量);
            this.groupBoxInput.Controls.Add(this.label巡航方式);
            this.groupBoxInput.Controls.Add(this.label巡航距离);
            this.groupBoxInput.Controls.Add(this.label温度偏差);
            this.groupBoxInput.Controls.Add(this.label巡航高度);
            this.groupBoxInput.Controls.Add(this.label巡航开始重量);
            this.groupBoxInput.Location = new System.Drawing.Point(13, 13);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(291, 197);
            this.groupBoxInput.TabIndex = 1;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Tag = "";
            this.groupBoxInput.Text = "输入";
            // 
            // button开始计算
            // 
            this.button开始计算.Location = new System.Drawing.Point(225, 129);
            this.button开始计算.Name = "button开始计算";
            this.button开始计算.Size = new System.Drawing.Size(60, 51);
            this.button开始计算.TabIndex = 19;
            this.button开始计算.Text = "开始\n计算";
            this.button开始计算.UseVisualStyleBackColor = true;
            this.button开始计算.Click += new System.EventHandler(this.button开始计算_Click);
            // 
            // textBox成本指数
            // 
            this.textBox成本指数.Enabled = false;
            this.textBox成本指数.Location = new System.Drawing.Point(118, 159);
            this.textBox成本指数.Name = "textBox成本指数";
            this.textBox成本指数.Size = new System.Drawing.Size(100, 21);
            this.textBox成本指数.TabIndex = 18;
            this.textBox成本指数.Text = "0";
            // 
            // label成本指数
            // 
            this.label成本指数.AutoSize = true;
            this.label成本指数.Location = new System.Drawing.Point(15, 162);
            this.label成本指数.Name = "label成本指数";
            this.label成本指数.Size = new System.Drawing.Size(77, 12);
            this.label成本指数.TabIndex = 17;
            this.label成本指数.Text = "成本指数Ci：";
            // 
            // comboBox巡航方式
            // 
            this.comboBox巡航方式.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox巡航方式.FormattingEnabled = true;
            this.comboBox巡航方式.Items.AddRange(new object[] {
            "LRC巡航",
            "经济巡航",
            "0.82马赫数巡航"});
            this.comboBox巡航方式.Location = new System.Drawing.Point(118, 133);
            this.comboBox巡航方式.Name = "comboBox巡航方式";
            this.comboBox巡航方式.Size = new System.Drawing.Size(100, 20);
            this.comboBox巡航方式.TabIndex = 16;
            this.comboBox巡航方式.SelectedIndexChanged += new System.EventHandler(this.comboBox巡航方式_SelectedIndexChanged);
            // 
            // comboBox巡航高度
            // 
            this.comboBox巡航高度.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox巡航高度.FormattingEnabled = true;
            this.comboBox巡航高度.Items.AddRange(new object[] {
            "600",
            "900",
            "1200",
            "1500",
            "1800",
            "2100",
            "2400",
            "2700",
            "3000",
            "3300",
            "3600",
            "3900",
            "4200",
            "4500",
            "4800",
            "5100",
            "5400",
            "5700",
            "6000",
            "6300",
            "6600",
            "6900",
            "7200",
            "7500",
            "7800",
            "8100",
            "8400",
            "8900",
            "9200",
            "9500",
            "9800",
            "10100",
            "10400",
            "10700",
            "11000",
            "11300",
            "11600",
            "11900",
            "12200",
            "12500",
            "13100",
            "13700",
            "14300",
            "14900"});
            this.comboBox巡航高度.Location = new System.Drawing.Point(118, 48);
            this.comboBox巡航高度.Name = "comboBox巡航高度";
            this.comboBox巡航高度.Size = new System.Drawing.Size(100, 20);
            this.comboBox巡航高度.TabIndex = 15;
            // 
            // label巡航距离_单位
            // 
            this.label巡航距离_单位.AutoSize = true;
            this.label巡航距离_单位.Location = new System.Drawing.Point(229, 105);
            this.label巡航距离_单位.Name = "label巡航距离_单位";
            this.label巡航距离_单位.Size = new System.Drawing.Size(17, 12);
            this.label巡航距离_单位.TabIndex = 13;
            this.label巡航距离_单位.Text = "KM";
            // 
            // label温度偏差_单位
            // 
            this.label温度偏差_单位.AutoSize = true;
            this.label温度偏差_单位.Location = new System.Drawing.Point(229, 78);
            this.label温度偏差_单位.Name = "label温度偏差_单位";
            this.label温度偏差_单位.Size = new System.Drawing.Size(53, 12);
            this.label温度偏差_单位.TabIndex = 12;
            this.label温度偏差_单位.Text = "摄氏度℃";
            // 
            // label巡航高度_单位
            // 
            this.label巡航高度_单位.AutoSize = true;
            this.label巡航高度_单位.Location = new System.Drawing.Point(229, 55);
            this.label巡航高度_单位.Name = "label巡航高度_单位";
            this.label巡航高度_单位.Size = new System.Drawing.Size(11, 12);
            this.label巡航高度_单位.TabIndex = 11;
            this.label巡航高度_单位.Text = "M";
            // 
            // label巡航开始重量_单位
            // 
            this.label巡航开始重量_单位.AutoSize = true;
            this.label巡航开始重量_单位.Location = new System.Drawing.Point(229, 23);
            this.label巡航开始重量_单位.Name = "label巡航开始重量_单位";
            this.label巡航开始重量_单位.Size = new System.Drawing.Size(17, 12);
            this.label巡航开始重量_单位.TabIndex = 10;
            this.label巡航开始重量_单位.Text = "KG";
            // 
            // textBox巡航距离
            // 
            this.textBox巡航距离.Location = new System.Drawing.Point(118, 102);
            this.textBox巡航距离.Name = "textBox巡航距离";
            this.textBox巡航距离.Size = new System.Drawing.Size(100, 21);
            this.textBox巡航距离.TabIndex = 8;
            // 
            // textBox温度偏差
            // 
            this.textBox温度偏差.Location = new System.Drawing.Point(118, 75);
            this.textBox温度偏差.Name = "textBox温度偏差";
            this.textBox温度偏差.Size = new System.Drawing.Size(100, 21);
            this.textBox温度偏差.TabIndex = 7;
            // 
            // textBox巡航开始重量
            // 
            this.textBox巡航开始重量.Location = new System.Drawing.Point(118, 20);
            this.textBox巡航开始重量.Name = "textBox巡航开始重量";
            this.textBox巡航开始重量.Size = new System.Drawing.Size(100, 21);
            this.textBox巡航开始重量.TabIndex = 5;
            // 
            // label巡航方式
            // 
            this.label巡航方式.AutoSize = true;
            this.label巡航方式.Location = new System.Drawing.Point(17, 134);
            this.label巡航方式.Name = "label巡航方式";
            this.label巡航方式.Size = new System.Drawing.Size(65, 12);
            this.label巡航方式.TabIndex = 4;
            this.label巡航方式.Text = "巡航方式：";
            // 
            // label巡航距离
            // 
            this.label巡航距离.AutoSize = true;
            this.label巡航距离.Location = new System.Drawing.Point(17, 105);
            this.label巡航距离.Name = "label巡航距离";
            this.label巡航距离.Size = new System.Drawing.Size(71, 12);
            this.label巡航距离.TabIndex = 3;
            this.label巡航距离.Text = "巡航距离R：";
            // 
            // label温度偏差
            // 
            this.label温度偏差.AutoSize = true;
            this.label温度偏差.Location = new System.Drawing.Point(17, 78);
            this.label温度偏差.Name = "label温度偏差";
            this.label温度偏差.Size = new System.Drawing.Size(83, 12);
            this.label温度偏差.TabIndex = 2;
            this.label温度偏差.Text = "温度偏差ΔT：";
            // 
            // label巡航高度
            // 
            this.label巡航高度.AutoSize = true;
            this.label巡航高度.Location = new System.Drawing.Point(17, 51);
            this.label巡航高度.Name = "label巡航高度";
            this.label巡航高度.Size = new System.Drawing.Size(77, 12);
            this.label巡航高度.TabIndex = 1;
            this.label巡航高度.Text = "巡航高度Hp：";
            // 
            // label巡航开始重量
            // 
            this.label巡航开始重量.AutoSize = true;
            this.label巡航开始重量.Location = new System.Drawing.Point(17, 23);
            this.label巡航开始重量.Name = "label巡航开始重量";
            this.label巡航开始重量.Size = new System.Drawing.Size(95, 12);
            this.label巡航开始重量.TabIndex = 0;
            this.label巡航开始重量.Text = "巡航开始重量m：";
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.dataGridView);
            this.groupBoxOutput.Location = new System.Drawing.Point(13, 216);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(577, 228);
            this.groupBoxOutput.TabIndex = 2;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "输出";
            // 
            // label燃油价格fuelPrice
            // 
            this.label燃油价格fuelPrice.AutoSize = true;
            this.label燃油价格fuelPrice.Location = new System.Drawing.Point(7, 28);
            this.label燃油价格fuelPrice.Name = "label燃油价格fuelPrice";
            this.label燃油价格fuelPrice.Size = new System.Drawing.Size(65, 12);
            this.label燃油价格fuelPrice.TabIndex = 0;
            this.label燃油价格fuelPrice.Text = "燃油价格：";
            // 
            // label时间价格timePrice
            // 
            this.label时间价格timePrice.AutoSize = true;
            this.label时间价格timePrice.Location = new System.Drawing.Point(7, 55);
            this.label时间价格timePrice.Name = "label时间价格timePrice";
            this.label时间价格timePrice.Size = new System.Drawing.Size(65, 12);
            this.label时间价格timePrice.TabIndex = 1;
            this.label时间价格timePrice.Text = "时间价格：";
            // 
            // labelHC排放价格
            // 
            this.labelHC排放价格.AutoSize = true;
            this.labelHC排放价格.Location = new System.Drawing.Point(6, 83);
            this.labelHC排放价格.Name = "labelHC排放价格";
            this.labelHC排放价格.Size = new System.Drawing.Size(77, 12);
            this.labelHC排放价格.TabIndex = 2;
            this.labelHC排放价格.Text = "HC排放价格：";
            // 
            // textBox燃油价格fuelPrice
            // 
            this.textBox燃油价格fuelPrice.Location = new System.Drawing.Point(107, 28);
            this.textBox燃油价格fuelPrice.Name = "textBox燃油价格fuelPrice";
            this.textBox燃油价格fuelPrice.Size = new System.Drawing.Size(100, 21);
            this.textBox燃油价格fuelPrice.TabIndex = 3;
            // 
            // textBox时间价格timePrice
            // 
            this.textBox时间价格timePrice.Location = new System.Drawing.Point(107, 52);
            this.textBox时间价格timePrice.Name = "textBox时间价格timePrice";
            this.textBox时间价格timePrice.Size = new System.Drawing.Size(100, 21);
            this.textBox时间价格timePrice.TabIndex = 4;
            // 
            // textBoxHC排放价格
            // 
            this.textBoxHC排放价格.Location = new System.Drawing.Point(107, 78);
            this.textBoxHC排放价格.Name = "textBoxHC排放价格";
            this.textBoxHC排放价格.Size = new System.Drawing.Size(100, 21);
            this.textBoxHC排放价格.TabIndex = 5;
            // 
            // label燃油价格fuelPrice_单位
            // 
            this.label燃油价格fuelPrice_单位.AutoSize = true;
            this.label燃油价格fuelPrice_单位.Location = new System.Drawing.Point(214, 36);
            this.label燃油价格fuelPrice_单位.Name = "label燃油价格fuelPrice_单位";
            this.label燃油价格fuelPrice_单位.Size = new System.Drawing.Size(35, 12);
            this.label燃油价格fuelPrice_单位.TabIndex = 6;
            this.label燃油价格fuelPrice_单位.Text = "元/kg";
            // 
            // label时间价格timePrice_单位
            // 
            this.label时间价格timePrice_单位.AutoSize = true;
            this.label时间价格timePrice_单位.Location = new System.Drawing.Point(214, 60);
            this.label时间价格timePrice_单位.Name = "label时间价格timePrice_单位";
            this.label时间价格timePrice_单位.Size = new System.Drawing.Size(47, 12);
            this.label时间价格timePrice_单位.TabIndex = 7;
            this.label时间价格timePrice_单位.Text = "元/小时";
            // 
            // labelHC排放价格_单位
            // 
            this.labelHC排放价格_单位.AutoSize = true;
            this.labelHC排放价格_单位.Location = new System.Drawing.Point(214, 83);
            this.labelHC排放价格_单位.Name = "labelHC排放价格_单位";
            this.labelHC排放价格_单位.Size = new System.Drawing.Size(35, 12);
            this.labelHC排放价格_单位.TabIndex = 8;
            this.labelHC排放价格_单位.Text = "元/kg";
            // 
            // labelCO排放价格_单位
            // 
            this.labelCO排放价格_单位.AutoSize = true;
            this.labelCO排放价格_单位.Location = new System.Drawing.Point(214, 110);
            this.labelCO排放价格_单位.Name = "labelCO排放价格_单位";
            this.labelCO排放价格_单位.Size = new System.Drawing.Size(35, 12);
            this.labelCO排放价格_单位.TabIndex = 8;
            this.labelCO排放价格_单位.Text = "元/kg";
            // 
            // labelNOx排放价格_单位
            // 
            this.labelNOx排放价格_单位.AutoSize = true;
            this.labelNOx排放价格_单位.Location = new System.Drawing.Point(214, 137);
            this.labelNOx排放价格_单位.Name = "labelNOx排放价格_单位";
            this.labelNOx排放价格_单位.Size = new System.Drawing.Size(35, 12);
            this.labelNOx排放价格_单位.TabIndex = 8;
            this.labelNOx排放价格_单位.Text = "元/kg";
            // 
            // labelCO2排放价格_单位
            // 
            this.labelCO2排放价格_单位.AutoSize = true;
            this.labelCO2排放价格_单位.Location = new System.Drawing.Point(213, 162);
            this.labelCO2排放价格_单位.Name = "labelCO2排放价格_单位";
            this.labelCO2排放价格_单位.Size = new System.Drawing.Size(35, 12);
            this.labelCO2排放价格_单位.TabIndex = 8;
            this.labelCO2排放价格_单位.Text = "元/kg";
            // 
            // labelCO排放价格
            // 
            this.labelCO排放价格.AutoSize = true;
            this.labelCO排放价格.Location = new System.Drawing.Point(7, 111);
            this.labelCO排放价格.Name = "labelCO排放价格";
            this.labelCO排放价格.Size = new System.Drawing.Size(77, 12);
            this.labelCO排放价格.TabIndex = 9;
            this.labelCO排放价格.Text = "CO排放价格：";
            // 
            // labelNOx排放价格
            // 
            this.labelNOx排放价格.AutoSize = true;
            this.labelNOx排放价格.Location = new System.Drawing.Point(9, 136);
            this.labelNOx排放价格.Name = "labelNOx排放价格";
            this.labelNOx排放价格.Size = new System.Drawing.Size(83, 12);
            this.labelNOx排放价格.TabIndex = 10;
            this.labelNOx排放价格.Text = "NOx排放价格：";
            // 
            // labelCO2排放价格
            // 
            this.labelCO2排放价格.AutoSize = true;
            this.labelCO2排放价格.Location = new System.Drawing.Point(9, 162);
            this.labelCO2排放价格.Name = "labelCO2排放价格";
            this.labelCO2排放价格.Size = new System.Drawing.Size(83, 12);
            this.labelCO2排放价格.TabIndex = 11;
            this.labelCO2排放价格.Text = "CO2排放价格：";
            // 
            // textBoxCO排放价格
            // 
            this.textBoxCO排放价格.Location = new System.Drawing.Point(107, 107);
            this.textBoxCO排放价格.Name = "textBoxCO排放价格";
            this.textBoxCO排放价格.Size = new System.Drawing.Size(100, 21);
            this.textBoxCO排放价格.TabIndex = 12;
            // 
            // textBoxNOx排放价格
            // 
            this.textBoxNOx排放价格.Location = new System.Drawing.Point(107, 134);
            this.textBoxNOx排放价格.Name = "textBoxNOx排放价格";
            this.textBoxNOx排放价格.Size = new System.Drawing.Size(100, 21);
            this.textBoxNOx排放价格.TabIndex = 13;
            // 
            // textBoxCO2排放价格
            // 
            this.textBoxCO2排放价格.Location = new System.Drawing.Point(107, 159);
            this.textBoxCO2排放价格.Name = "textBoxCO2排放价格";
            this.textBoxCO2排放价格.Size = new System.Drawing.Size(100, 21);
            this.textBoxCO2排放价格.TabIndex = 14;
            // 
            // groupBoxParms
            // 
            this.groupBoxParms.Controls.Add(this.textBoxCO2排放价格);
            this.groupBoxParms.Controls.Add(this.textBoxNOx排放价格);
            this.groupBoxParms.Controls.Add(this.textBoxCO排放价格);
            this.groupBoxParms.Controls.Add(this.labelCO2排放价格);
            this.groupBoxParms.Controls.Add(this.labelNOx排放价格);
            this.groupBoxParms.Controls.Add(this.labelCO排放价格);
            this.groupBoxParms.Controls.Add(this.labelCO2排放价格_单位);
            this.groupBoxParms.Controls.Add(this.labelNOx排放价格_单位);
            this.groupBoxParms.Controls.Add(this.labelCO排放价格_单位);
            this.groupBoxParms.Controls.Add(this.labelHC排放价格_单位);
            this.groupBoxParms.Controls.Add(this.label时间价格timePrice_单位);
            this.groupBoxParms.Controls.Add(this.label燃油价格fuelPrice_单位);
            this.groupBoxParms.Controls.Add(this.textBoxHC排放价格);
            this.groupBoxParms.Controls.Add(this.textBox时间价格timePrice);
            this.groupBoxParms.Controls.Add(this.textBox燃油价格fuelPrice);
            this.groupBoxParms.Controls.Add(this.labelHC排放价格);
            this.groupBoxParms.Controls.Add(this.label时间价格timePrice);
            this.groupBoxParms.Controls.Add(this.label燃油价格fuelPrice);
            this.groupBoxParms.Location = new System.Drawing.Point(321, 13);
            this.groupBoxParms.Name = "groupBoxParms";
            this.groupBoxParms.Size = new System.Drawing.Size(269, 197);
            this.groupBoxParms.TabIndex = 3;
            this.groupBoxParms.TabStop = false;
            this.groupBoxParms.Text = "优化相关参数";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 455);
            this.Controls.Add(this.groupBoxParms);
            this.Controls.Add(this.groupBoxOutput);
            this.Controls.Add(this.groupBoxInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "主窗口";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxParms.ResumeLayout(false);
            this.groupBoxParms.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.ComboBox comboBox巡航方式;
        private System.Windows.Forms.ComboBox comboBox巡航高度;
        private System.Windows.Forms.Label label巡航距离_单位;
        private System.Windows.Forms.Label label温度偏差_单位;
        private System.Windows.Forms.Label label巡航高度_单位;
        private System.Windows.Forms.Label label巡航开始重量_单位;
        private System.Windows.Forms.TextBox textBox巡航距离;
        private System.Windows.Forms.TextBox textBox温度偏差;
        private System.Windows.Forms.TextBox textBox巡航开始重量;
        private System.Windows.Forms.Label label巡航方式;
        private System.Windows.Forms.Label label巡航距离;
        private System.Windows.Forms.Label label温度偏差;
        private System.Windows.Forms.Label label巡航高度;
        private System.Windows.Forms.Label label巡航开始重量;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.Label label成本指数;
        private System.Windows.Forms.TextBox textBox成本指数;
        private System.Windows.Forms.Button button开始计算;
        private System.Windows.Forms.Label label燃油价格fuelPrice;
        private System.Windows.Forms.Label label时间价格timePrice;
        private System.Windows.Forms.Label labelHC排放价格;
        private System.Windows.Forms.TextBox textBox燃油价格fuelPrice;
        private System.Windows.Forms.TextBox textBox时间价格timePrice;
        private System.Windows.Forms.TextBox textBoxHC排放价格;
        private System.Windows.Forms.Label label燃油价格fuelPrice_单位;
        private System.Windows.Forms.Label label时间价格timePrice_单位;
        private System.Windows.Forms.Label labelHC排放价格_单位;
        private System.Windows.Forms.Label labelCO排放价格_单位;
        private System.Windows.Forms.Label labelNOx排放价格_单位;
        private System.Windows.Forms.Label labelCO2排放价格_单位;
        private System.Windows.Forms.Label labelCO排放价格;
        private System.Windows.Forms.Label labelNOx排放价格;
        private System.Windows.Forms.Label labelCO2排放价格;
        private System.Windows.Forms.TextBox textBoxCO排放价格;
        private System.Windows.Forms.TextBox textBoxNOx排放价格;
        private System.Windows.Forms.TextBox textBoxCO2排放价格;
        private System.Windows.Forms.GroupBox groupBoxParms;
        private System.Windows.Forms.DataGridViewTextBoxColumn 巡航消耗油量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 总巡航时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn HC排放量;
        private System.Windows.Forms.DataGridViewTextBoxColumn CO排放量;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOx排放量;
        private System.Windows.Forms.DataGridViewTextBoxColumn CO2排放量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 巡航总成本;
    }
}