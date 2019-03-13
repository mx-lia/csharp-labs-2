using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace LR_2
{
    public partial class info : Form
    {
        public static List<Crewman> crew = new List<Crewman>();
        Airplane airplane = new Airplane();
        BindingList<Airplane> listForGrid = new BindingList<Airplane>();
        public static List<Airplane> airplanes = new List<Airplane>();

        public info()
        {
            InitializeComponent();
            date.MaxDate = DateTime.Today;
            date.Value = DateTime.Today;
            table.DataSource = listForGrid;
            timer1.Start();
        }

        private void CrewButtons_Click(object sender, EventArgs e)
        {
            switch ((sender as Button).Text)
            {
                case "+":
                    Form2 form2 = new Form2();
                    form2.ShowDialog();
                    if (form2.crewman != null)
                        infoCrew.Items.Add(form2.crewman);
                    break;
                case "×":
                    crew.Clear();
                    infoCrew.Items.Clear();
                    break;
            }
        }

        private void OnlyDigitTextBoxes_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.KeyChar) || e.KeyChar == 8);
        }

        private void Year_Scroll(object sender, EventArgs e)
        {
            yearText.Text = year.Value.ToString();
            date.MinDate = new DateTime(year.Value, 1, 1);
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Utilities.ResetAllControls(this);
        }

        private void RadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton && radioButton.Checked)
                type.Tag = radioButton.Text;
        }

        private void AddAirplane_Click(object sender, EventArgs e)
        {
            var results = new List<ValidationResult>();
            airplane = new Airplane(ID.Text, model.Text, (int)seats.Value, (int)load.Value, type.Tag.ToString(), year.Value, date.Value, crew);
            var context = new ValidationContext(airplane);
            if (!Validator.TryValidateObject(airplane, context, results, true))
            {
                string strWithError = "";
                foreach (var error in results)
                {
                    strWithError += error.ErrorMessage + "\n";
                }
                MessageBox.Show(strWithError, "Ошибка");
            }
            else
            {
                listForGrid.Add(airplane);
                airplanes.Add(airplane);
            }
        }

        private void SaveOrReadFile(FileDialog dialog, List<Airplane> airplanes)
        {
            try
            {
                dialog.ShowDialog();
                if (!dialog.FileName.Contains(".json") && !dialog.FileName.Contains(".xml"))
                    throw new Exception("Неверное расширение. Только XML и JSON форматы");
                using (FileStream fs = new FileStream(dialog.FileName, FileMode.OpenOrCreate))
                {
                    if (dialog is OpenFileDialog openFileDialog1)
                    {
                        List<Airplane> bufferAirplanes = new List<Airplane>();
                        if (openFileDialog1.FileName.Contains(".json"))
                        {
                            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<Airplane>));
                            bufferAirplanes = (List<Airplane>)jsonSerializer.ReadObject(fs);
                        }
                        else if (openFileDialog1.FileName.Contains(".xml"))
                        {
                            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Airplane>));
                            bufferAirplanes = (List<Airplane>)xmlSerializer.Deserialize(fs);
                        }
                        if (bufferAirplanes.Count != 0)
                        {
                            foreach (Airplane airplane in bufferAirplanes)
                            {
                                airplanes.Add(airplane);
                                listForGrid.Add(airplane);
                            }
                        }
                        else
                            throw new Exception("Не удалось выполнить чтение.");
                    }
                    else if(dialog is SaveFileDialog saveFileDialog1)
                    {
                        if (saveFileDialog1.FileName.Contains(".json"))
                        {
                            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<Airplane>));
                            jsonSerializer.WriteObject(fs, airplanes);
                        }
                        else if (saveFileDialog1.FileName.Contains(".xml"))
                        {
                            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Airplane>));
                            xmlSerializer.Serialize(fs, airplanes);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void InfoCrew_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
                crew.Add(infoCrew.SelectedItem as Crewman);
            else if (e.NewValue == CheckState.Unchecked)
                crew.Remove(infoCrew.SelectedItem as Crewman);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void Table_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch ((sender as ToolStripItem).Tag)
            {
                case "search":
                    Form3 form3 = new Form3();
                    form3.ShowDialog();
                    break;
                case "save":
                    SaveOrReadFile(saveFileDialog1, Form3.searchedAirplanes);
                    break;
                case "aboutProgram":
                    MessageBox.Show("Версия 2.0\nМаксимчикова Юлия", "О программе", MessageBoxButtons.OK);
                    break;
            }
        }

        private void SortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch ((sender as ToolStripItem).Tag)
            {
                case "sortModel":
                    airplanes = new List<Airplane>(airplanes.OrderBy(t => t.Model).ToList());
                    break;
                case "sortDate":
                    airplanes = new List<Airplane>(airplanes.OrderBy(t => t.Date).ToList());
                    break;
            }
            listForGrid.Clear();
            foreach (var item in airplanes)
                listForGrid.Add(item);
        }

        private void SaveOrRead_Click(object sender, EventArgs e)
        {
            switch((sender as Button).Name)
            {
                case "save":
                    SaveOrReadFile(saveFileDialog1, airplanes);
                    break;
                case "read":
                    listForGrid.Clear();
                    airplanes.Clear();
                    SaveOrReadFile(openFileDialog1, airplanes);
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Текущие дата и время: " + DateTime.Now.ToLocalTime().ToString();
            toolStripStatusLabel2.Text = "Количество созданных объектов: " + airplanes.Count;
        }

        private void ToolStripButton_Click(object sender, EventArgs e)
        {
            if (airplanes.Count == 0)
                MessageBox.Show("Коллекция пуста!", "Ошибка");
            else
            {
                switch ((sender as ToolStripItem).Tag)
                {
                    case "delete":
                        airplanes.RemoveAt(airplanes.Count - 1);
                        listForGrid.RemoveAt(listForGrid.Count - 1);
                        break;
                    case "clear":
                        airplanes.Clear();
                        listForGrid.Clear();
                        break;
                }
            }
        }
    }
}