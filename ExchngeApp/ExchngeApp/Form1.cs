using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExchngeApp
{
    public partial class Form1 : Form
    {
        private Dictionary<string, decimal> exchangeRates = new Dictionary<string, decimal>();

        public Form1()
        {
            InitializeComponent();

            // Инициализация выпадающих списков
            comboBoxFromCurrency.Items.AddRange(new string[] { "Рубль", "Доллар", "Евро", "Фунт", "Лира" });
            comboBoxToCurrency.Items.AddRange(new string[] { "Рубль", "Доллар", "Евро", "Фунт", "Лира" });

            // Значения по умолчанию
            comboBoxFromCurrency.SelectedIndex = 0;
            comboBoxToCurrency.SelectedIndex = 1;
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            string fromCurrency = comboBoxFromCurrency.SelectedItem.ToString();
            string toCurrency = comboBoxToCurrency.SelectedItem.ToString();
            decimal exchangeRate;

            if (decimal.TryParse(textBoxExchangeRate.Text, out exchangeRate))
            {
                string key = $"{fromCurrency}-{toCurrency}-{dateTimePicker1.Value.ToShortDateString()}";
                if (!exchangeRates.ContainsKey(key))
                {
                    exchangeRates.Add(key, exchangeRate);
                    UpdateExchangeRateList(); // Обновляем список курсов после добавления
                }
                else
                {
                    MessageBox.Show("Курс для выбранной даты и валюты уже добавлен.", "Ошибка");
                }
            }
            else
            {
                MessageBox.Show("Неверное значение курса.", "Ошибка");
            }

            // Очищаем форму после добавления курса
            comboBoxFromCurrency.SelectedIndex = -1;
            comboBoxToCurrency.SelectedIndex = -1;
            textBoxExchangeRate.Clear();
        }

        private void UpdateExchangeRateList()
        {
            listBoxExchangeRates.Items.Clear();
            listBoxExchangeRates.Items.AddRange(exchangeRates.Keys.ToArray());
        }

        private void listBoxExchangeRates_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxExchangeRates.SelectedIndex != -1)
            {
                string selectedKey = listBoxExchangeRates.SelectedItem.ToString();
                decimal exchangeRate = exchangeRates[selectedKey];
                labelSelectedExchangeRate.Text = $"Выбранный курс: {exchangeRate}";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxExchangeRates_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            this.listBoxExchangeRates.SelectedIndexChanged += new System.EventHandler(this.listBoxExchangeRates_SelectedIndexChanged);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker2.Value.Date;

            string key = exchangeRates.Keys.FirstOrDefault(k => k.Contains(selectedDate.ToShortDateString()));
            if (key != null)
            {
                decimal exchangeRate = exchangeRates[key];
                listBox1.Items.Clear();
                listBox1.Items.Add($"Курс на {selectedDate.ToShortDateString()}: {exchangeRate}");
            }
            else
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Курс для выбранной даты не найден.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string fromCurrency = comboBoxFromCurrency.SelectedItem.ToString();
            string toCurrency = comboBoxToCurrency.SelectedItem.ToString();
            decimal exchangeRate;

            if (decimal.TryParse(textBoxExchangeRate.Text, out exchangeRate))
            {
                string key = $"{fromCurrency} к {toCurrency} ({dateTimePicker1.Value.ToShortDateString()})";
                if (!exchangeRates.ContainsKey(key))
                {
                    exchangeRates.Add(key, exchangeRate);
                    UpdateExchangeRateList(); // Обновляем список курсов после добавления
                }
                else
                {
                    MessageBox.Show("Курс для выбранной даты и валют уже добавлен.", "Ошибка");
                }
            }
            else
            {
                MessageBox.Show("Неверное значение курса.", "Ошибка");
            }

            // Очищаем форму после добавления курса
            comboBoxFromCurrency.SelectedIndex = -1;
            comboBoxToCurrency.SelectedIndex = -1;
            textBoxExchangeRate.Clear();
        }


        private void button2_Click_2(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker2.Value.Date;

            if (comboBoxFromCurrency.SelectedItem != null && comboBoxToCurrency.SelectedItem != null)
            {
                string fromCurrency = comboBoxFromCurrency.SelectedItem.ToString();
                string toCurrency = comboBoxToCurrency.SelectedItem.ToString();

                string selectedKey = $"{fromCurrency}-{toCurrency}-{selectedDate.ToShortDateString()}";
                Console.WriteLine("Selected Key: " + selectedKey); // Добавим этот вывод

                string key = exchangeRates.Keys.FirstOrDefault(k => k == selectedKey);

                if (key != null)
                {
                    decimal exchangeRate = exchangeRates[key];
                    listBox1.Items.Clear();
                    listBox1.Items.Add($"Курс на {selectedDate.ToShortDateString()}: {exchangeRate}");
                }
                else
                {
                    listBox1.Items.Clear();
                    listBox1.Items.Add("Курс для выбранной даты не найден.");
                }
            }
            else
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Выберите валюты.");
            }
        }

        private void buttonShowMinMax_Click(object sender, EventArgs e)
        {
            // Проверяем, выбраны ли элементы в ComboBox
            if (comboBoxFromCurrency.SelectedItem != null && comboBoxToCurrency.SelectedItem != null)
            {
                string fromCurrency = comboBoxFromCurrency.SelectedItem.ToString();
                string toCurrency = comboBoxToCurrency.SelectedItem.ToString();

                // Находим минимальное и максимальное значение курса
                decimal minValue = decimal.MaxValue;
                decimal maxValue = decimal.MinValue;

                foreach (var exchangeRate in exchangeRates)
                {
                    string[] parts = exchangeRate.Key.Split('-');
                    if (parts.Length == 3 && parts[0] == fromCurrency && parts[1] == toCurrency)
                    {
                        decimal rate = exchangeRate.Value;
                        minValue = Math.Min(minValue, rate);
                        maxValue = Math.Max(maxValue, rate);
                    }
                }

                listBox2.Items.Clear();
                listBox2.Items.Add($"Минимальный курс: {minValue}");

                listBox3.Items.Clear();
                listBox3.Items.Add($"Максимальный курс: {maxValue}");
            }
            else
            {
                MessageBox.Show("Выберите валюты.", "Ошибка");
            }
        }

    }

}

