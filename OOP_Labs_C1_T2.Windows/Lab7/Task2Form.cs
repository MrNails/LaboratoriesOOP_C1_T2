using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Labs_C1_T2.Windows.Lab7
{
    public partial class Task2Form : Form
    {
        public Task2Form()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            ReverseFullNameTextBox.Text = new string(FullNameTextBox.Text.Reverse().ToArray());
            SmblsCountTextBox.Text = ReverseFullNameTextBox.Text.Length.ToString();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text file (*.txt)|*.txt";

            if (PathTextBox.Text != String.Empty)
                saveFileDialog.InitialDirectory = PathTextBox.Text;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, FullNameTextBox.Text);
                MessageBox.Show("Figure saved successfully", "Information", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text file (*.txt)|*.txt";

            if (PathTextBox.Text != String.Empty)
                openFileDialog.InitialDirectory = PathTextBox.Text;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
                LoadedTextTextBox.Text = File.ReadAllText(openFileDialog.FileName);
        }
    }
}
