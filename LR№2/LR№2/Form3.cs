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

namespace LR_2
{
    public partial class Form3 : Form
    {
        public static List<Airplane> searchedAirplanes = new List<Airplane>(info.airplanes);
        BindingList<Airplane> listForGrid = new BindingList<Airplane>();

        public Form3()
        {
            InitializeComponent();
            searchResult.DataSource = listForGrid;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            Utilities.ResetAllControls(this);
        }

        private void search_Click(object sender, EventArgs e)
        {
            listForGrid.Clear();
            searchedAirplanes = new List<Airplane>(info.airplanes);
            if (model.Text != "")
            {
                Regex regex = new Regex( model.Text);
                if (partialSearch.Checked && !ignoreCase.Checked)
                {
                    regex = new Regex(".*" + model.Text + ".*");
                }
                else if (ignoreCase.Checked && !partialSearch.Checked)
                {
                    regex = new Regex(model.Text, RegexOptions.IgnoreCase);
                }
                else if (ignoreCase.Checked && partialSearch.Checked)
                {
                    regex = new Regex(model.Text, RegexOptions.IgnoreCase);
                }
                for (int i = 0; i < searchedAirplanes.Count; i++)
                {
                    if (!regex.IsMatch(searchedAirplanes[i].Model))
                    {
                        searchedAirplanes.Remove(searchedAirplanes[i]);
                        i--;
                    }
                }
            }
            if (type.Text != "") 
            {
                for (int i = 0; i < searchedAirplanes.Count; i++)
                {
                    if (searchedAirplanes[i].Type != type.Text)
                    {
                        searchedAirplanes.Remove(searchedAirplanes[i]);
                        i--;
                    }
                }
            }
            if (seats.Value != 0) 
            {
                for (int i = 0; i < searchedAirplanes.Count; i++)
                {
                    if (searchedAirplanes[i].Seats != seats.Value)
                    {
                        searchedAirplanes.Remove(searchedAirplanes[i]);
                        i--;
                    }
                }
            }
            if(load.Value != 0)
            {
                for (int i = 0; i < searchedAirplanes.Count; i++)
                {
                    if (searchedAirplanes[i].Load != load.Value)
                    {
                        searchedAirplanes.Remove(searchedAirplanes[i]);
                        i--;
                    }
                }
            }
            if (searchedAirplanes.Count == 0 || (model.Text == "" && type.Text == "" && seats.Value == 0 && load.Value == 0))
            {
                MessageBox.Show("Результатов нет.");
            }
            else
            {
                foreach (Airplane airplane in searchedAirplanes)
                    listForGrid.Add(airplane);
            }
        }

        private void searchResult_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            searchResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
