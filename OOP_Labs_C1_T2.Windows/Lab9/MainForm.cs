using OOP_Labs_C1_T2.Windows.Lab9.Figures;
using OOP_Labs_C1_T2.Windows.Lab9.Windows;
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

namespace OOP_Labs_C1_T2.Windows.Lab9
{
    public partial class MainForm : Form
    {
        private Pen m_pen;
        private Star m_star;

        public MainForm()
        {
            InitializeComponent();

            m_pen = new Pen(new SolidBrush(Color.FromArgb(0, 0, 0)), 2);
            m_star = new Star();
        }

        /// <summary>
        /// Validate all textBoxes in specified control.
        /// </summary>
        /// <param name="container">Container which contains text boxes to validation</param>
        /// <param name="validationRule">Validate text box and return tuple with value and validation result</param>
        /// <param name="errorAction">Sends error text box and returns flag whether continue validation or not</param>
        private Dictionary<string, T> ValidateTextBoxes<T>(Control container, Func<string, (T, bool)> validationRule,
            Func<TextBox, bool> errorAction, out bool haveErrors)
        {
            var result = new Dictionary<string, T>();
            var continueValidate = true;
            haveErrors = false;

            foreach (var control in container.Controls)
            {
                if (!continueValidate)
                {
                    haveErrors = true;
                    break;
                }

                if (control is TextBox textBox)
                {
                    var valiadtionRes = validationRule(textBox.Text);

                    if (valiadtionRes.Item2)
                        result.Add(textBox.Name, valiadtionRes.Item1);
                    else
                        continueValidate = errorAction(textBox);
                }
            }

            return result;
        }

        private (int, bool) ValidateAndGetInt(string inputValue)
        {
            var parseResValue = 0;
            var parseRes = int.TryParse(inputValue, out parseResValue);

            return (parseResValue, parseRes);
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            var haveErrors = false;
            var validationResult = ValidateTextBoxes(FigureInfoGroupBox, ValidateAndGetInt,
                textBox =>
                {
                    MessageBox.Show($"Wrong input {textBox.Tag} value", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return false;
                }, out haveErrors);

            if (haveErrors)
                return;

            m_star.A = validationResult["ATextBox"];
            m_star.B = validationResult["BTextBox"];
            m_star.CenterX = validationResult["CenterXTextBox"];
            m_star.CenterY = validationResult["CenterYTextBox"];

            var graphic = DrawingFieldPanel.CreateGraphics();

            graphic.Clear(FigureInfoGroupBox.BackColor);

            m_star.Draw(graphic, m_pen);
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveWindow = new SaveFigureWindow(m_star);

            if (saveWindow.ShowDialog() == DialogResult.OK)
                MessageBox.Show("Figure saved successfully", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }

        private void LoadAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var loadWindow = new LoadFigureWIndow();

            try
            {
                if (loadWindow.ShowDialog() == DialogResult.OK)
                {
                    m_star = loadWindow.Star;

                    ATextBox.Text = m_star.A.ToString();
                    BTextBox.Text = m_star.B.ToString();
                    CenterXTextBox.Text = m_star.CenterX.ToString();
                    CenterYTextBox.Text = m_star.CenterY.ToString();

                    DrawButton.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured when loading figure. " + ex.Message, "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            PrintObjectProps(m_star);
        }

        private void PrintObjectProps<T>(T star)
        {
            var type = typeof(T);

            Console.WriteLine($"Type name: {type.FullName}\nProperties:");
            foreach (var property in type.GetProperties())
            {
                Console.WriteLine($"Property: \n\tName: {property.Name}, \n\tType: {property.PropertyType.FullName}");
                Console.WriteLine("===============================================\n");
            }
        }
    }
}