using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;

namespace LR_2
{
    public partial class Form2 : Form
    {
        public Crewman crewman;

        public Form2()
        {
            InitializeComponent();
        }

        private void Age_Scroll(object sender, EventArgs e)
        {
            ageText.Text = age.Value.ToString();
        }

        private void OnlyCharTextBoxes_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsLetter(e.KeyChar) || e.KeyChar == 8);
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Utilities.ResetAllControls(this);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            var results = new List<ValidationResult>();
            crewman = new Crewman(surname.Text, name.Text, secondName.Text, age.Value, work.Text, (int)experience.Value);
            var context = new ValidationContext(crewman);
            if (!Validator.TryValidateObject(crewman, context, results, true))
            {
                string strWithError = "";
                foreach (var error in results)
                {
                    strWithError += error.ErrorMessage + "\n";
                }
                MessageBox.Show(strWithError, "Ошибка");
                crewman = null;
            }
            else
            {
                Close();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
