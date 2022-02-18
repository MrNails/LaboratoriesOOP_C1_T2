using OOP_Labs_C1_T2.Windows.Lab9.Figures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Labs_C1_T2.Windows.Lab9.Windows
{
    internal partial class FigureManipulationWindow : Form
    {
        private Star m_star;

        public FigureManipulationWindow() : this(Star.EmptyStar) { }

        public FigureManipulationWindow(Star star)
        {
            Star = star;
            InitializeComponent();

            XMLRadioButton.CheckedChanged += RadioButton_CheckedChanged;
            BinaryRadioButton.CheckedChanged += RadioButton_CheckedChanged;
        }

        public Star Star
        {
            get => m_star;
            set
            {
                if (value == null)
                    throw new ArgumentNullException(nameof(value));

                m_star = value;
            }
        }

        protected string GetSelectedSaveType()
        {
            foreach (var control in StarTypeGroupBox.Controls)
                if (control is RadioButton radioButton && radioButton.Checked)
                    return radioButton.Text;

            return String.Empty;
        }

        private void RadioButton_CheckedChanged(object? sender, EventArgs e)
        {
            PathTextBox.Text = string.Empty;
            Button.Enabled = false;
        }

        protected virtual void PathSelectionButton_Click(object sender, EventArgs e) { }

        protected virtual void Button_Click(object sender, EventArgs e) { }
    }
}
