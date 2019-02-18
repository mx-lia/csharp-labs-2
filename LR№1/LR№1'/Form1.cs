using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR_1_
{
    public partial class Form1 : Form
    {
        int count;
        List<Cat> cats = new List<Cat>();
        public string TextInfo { get; set; }
        public string Title { get; set; }
        dynamic inputInfo;

        public void Generate(int count)
        {
            cats.Clear();
            listBox2.Items.Clear();
            for (int i = 0; i < count; i++) 
            {
                cats.Add(new Cat());
                listBox1.Items.Add(cats[i]);
            }
        }

        public void CreateNewForm(string title, string text, out dynamic input)
        {
            TextInfo = text;
            Title = title;
            Form2 form2 = new Form2(this);
            form2.ShowDialog();
            input = form2.textBox1.Text;
        }

        public bool CheckEmptyCollect()
        {
            if (cats.Count == 0)
            {
                MessageBox.Show("Коллекция пуста! Сгенерируйте коллекцию и попробуйте снова.", "Ошибка", MessageBoxButtons.OK);
                return true;
            }
            else
                return false;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(textBox1.Text, out count);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Generate(count);
        }

        private void sort_buttons_Click(object sender, EventArgs e)
        {
            if (!CheckEmptyCollect())
            {
                listBox2.Items.Clear();
                List<Cat> sortedCats = new List<Cat>(cats);
                switch ((sender as Button).Tag)
                {
                    case "1":
                        sortedCats.Sort(Cat.OrderByDescending);
                        break;
                    case "2":
                        sortedCats.Sort(Cat.OrderByAscending);
                        break;
                }
                foreach (var cat in sortedCats)
                {
                    listBox2.Items.Add(cat);
                }
            }
        }

        private void request_buttons_Click(object sender, EventArgs e)
        {
            if (!CheckEmptyCollect())
            {
                List<Cat> selectedCats = new List<Cat>();
                switch ((sender as Button).Tag)
                {
                    case "1":
                        CreateNewForm("Запрос №1", "Поиск котов по возрасту", out inputInfo);
                        Int32.TryParse(inputInfo, out int number);
                        selectedCats = cats.Where(t => t.Age == number).ToList<Cat>();
                        break;
                    case "2":
                        CreateNewForm("Запрос №2", "Поиск котов по кличке", out inputInfo);
                        Convert.ToString(inputInfo);
                        selectedCats = cats.Where(t => t.Name == inputInfo).ToList<Cat>();
                        break;
                    case "3":
                        CreateNewForm("Запрос №3", "Поиск котов по окрасу", out inputInfo);
                        Convert.ToString(inputInfo);
                        selectedCats = cats.Where(t => t.Color == inputInfo).ToList<Cat>();
                        break;
                }
                listBox2.Items.Clear();
                foreach (var cat in selectedCats)
                {
                    listBox2.Items.Add(cat);
                }
            }
        }
    }
}
