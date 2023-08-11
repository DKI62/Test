namespace ExchngeApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxFromCurrency = new System.Windows.Forms.ComboBox();
            this.comboBoxToCurrency = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxExchangeRate = new System.Windows.Forms.TextBox();
            this.listBoxExchangeRates = new System.Windows.Forms.ListBox();
            this.labelSelectedExchangeRate = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.buttonShowMinMax = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxFromCurrency
            // 
            this.comboBoxFromCurrency.FormattingEnabled = true;
            this.comboBoxFromCurrency.Location = new System.Drawing.Point(274, 12);
            this.comboBoxFromCurrency.Name = "comboBoxFromCurrency";
            this.comboBoxFromCurrency.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFromCurrency.TabIndex = 0;
            // 
            // comboBoxToCurrency
            // 
            this.comboBoxToCurrency.FormattingEnabled = true;
            this.comboBoxToCurrency.Location = new System.Drawing.Point(426, 12);
            this.comboBoxToCurrency.Name = "comboBoxToCurrency";
            this.comboBoxToCurrency.Size = new System.Drawing.Size(121, 21);
            this.comboBoxToCurrency.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(58, 76);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 24);
            this.button1.TabIndex = 3;
            this.button1.Text = "Добавить ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxExchangeRate
            // 
            this.textBoxExchangeRate.Location = new System.Drawing.Point(58, 40);
            this.textBoxExchangeRate.Name = "textBoxExchangeRate";
            this.textBoxExchangeRate.Size = new System.Drawing.Size(100, 20);
            this.textBoxExchangeRate.TabIndex = 4;
            // 
            // listBoxExchangeRates
            // 
            this.listBoxExchangeRates.FormattingEnabled = true;
            this.listBoxExchangeRates.Location = new System.Drawing.Point(34, 155);
            this.listBoxExchangeRates.Name = "listBoxExchangeRates";
            this.listBoxExchangeRates.Size = new System.Drawing.Size(271, 95);
            this.listBoxExchangeRates.TabIndex = 5;
            this.listBoxExchangeRates.SelectedIndexChanged += new System.EventHandler(this.listBoxExchangeRates_SelectedIndexChanged_1);
            // 
            // labelSelectedExchangeRate
            // 
            this.labelSelectedExchangeRate.AutoSize = true;
            this.labelSelectedExchangeRate.Location = new System.Drawing.Point(138, 139);
            this.labelSelectedExchangeRate.Name = "labelSelectedExchangeRate";
            this.labelSelectedExchangeRate.Size = new System.Drawing.Size(29, 13);
            this.labelSelectedExchangeRate.TabIndex = 6;
            this.labelSelectedExchangeRate.Text = "label";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(568, 40);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(616, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 37);
            this.button2.TabIndex = 12;
            this.button2.Text = "Вывести";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(526, 155);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(271, 95);
            this.listBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Валюта ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "К";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Курс";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(636, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Вывод по дате";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Добавление курса";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Дата";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(529, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Дата";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(34, 317);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(271, 108);
            this.listBox2.TabIndex = 21;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(526, 317);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(256, 108);
            this.listBox3.TabIndex = 22;
            // 
            // buttonShowMinMax
            // 
            this.buttonShowMinMax.Location = new System.Drawing.Point(377, 356);
            this.buttonShowMinMax.Name = "buttonShowMinMax";
            this.buttonShowMinMax.Size = new System.Drawing.Size(93, 33);
            this.buttonShowMinMax.TabIndex = 23;
            this.buttonShowMinMax.Text = "вывести";
            this.buttonShowMinMax.UseVisualStyleBackColor = true;
            this.buttonShowMinMax.Click += new System.EventHandler(this.buttonShowMinMax_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonShowMinMax);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.labelSelectedExchangeRate);
            this.Controls.Add(this.listBoxExchangeRates);
            this.Controls.Add(this.textBoxExchangeRate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxToCurrency);
            this.Controls.Add(this.comboBoxFromCurrency);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFromCurrency;
        private System.Windows.Forms.ComboBox comboBoxToCurrency;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxExchangeRate;
        private System.Windows.Forms.ListBox listBoxExchangeRates;
        private System.Windows.Forms.Label labelSelectedExchangeRate;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button buttonShowMinMax;
    }
}

