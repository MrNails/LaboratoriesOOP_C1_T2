using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Labs_C1_T2.Windows.Lab7
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            float length;

            if (!float.TryParse(SquareSideTextBox.Text, System.Globalization.NumberStyles.Float, CultureInfo.InvariantCulture, out length) ||
                length < 0)
            {
                MessageBox.Show("Wrong square side length input or length less than 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SquareTextBox.Text = (length * length).ToString();
            PerimeterTextBox.Text = (4 * length).ToString();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void task2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task2Form task2Form = new Task2Form();
            task2Form.ShowDialog();
        }
    }
}
