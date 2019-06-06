using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR_2
{
    class Utilities
    {
        public static void ResetAllControls(Control form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox textBox)
                    textBox.ResetText();

                if (control is ComboBox comboBox)
                    comboBox.ResetText();

                if (control is CheckBox checkBox)
                    checkBox.Checked = false;

                if (control is NumericUpDown numericUpDown)
                    numericUpDown.Value = numericUpDown.Minimum;

                if (control is RadioButton radioButton)
                    radioButton.Checked = false;

                if (control is TrackBar trackBar)
                    trackBar.Value = trackBar.Minimum;

                if (control is DateTimePicker timePicker)
                    timePicker.Value = DateTime.Today;
            }
        }
    }
}
