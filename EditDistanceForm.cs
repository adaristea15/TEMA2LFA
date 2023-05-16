using System;
using System.Windows.Forms;

namespace TEMA2LFA
{
    public partial class EditDistanceForm : Form
    {
        public int Distance { get; set; }

        public EditDistanceForm(int currentDistance)
        {
            InitializeComponent();
            Distance = currentDistance;
            DistanceNumericUpDown.Value = currentDistance;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Distance = (int)DistanceNumericUpDown.Value;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

