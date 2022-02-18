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
using System.Xml.Serialization;

namespace OOP_Labs_C1_T2.Windows.Lab9.Windows
{
    internal partial class SaveFigureWindow : FigureManipulationWindow
    {
        public SaveFigureWindow() : this(Star.EmptyStar) { }

        public SaveFigureWindow(Star star) : base(star)
        {
            InitializeComponent();

            Button.Text = "Save";
            StarTypeGroupBox.Text = "Save as";
            Text = "Figure save window";
        }

        private void SaveXML(string path)
        {
            XmlSerializer ser = new XmlSerializer(typeof(Star));

            using (var fStream = new FileStream(path, FileMode.OpenOrCreate))
            {
                ser.Serialize(fStream, Star);
                fStream.Flush();
            }
        }

        private void SaveBinary(string path)
        {
            using (var fStream = new FileStream(path, FileMode.OpenOrCreate))
            {
                BinaryWriter writer = new BinaryWriter(fStream);

                writer.Write(Star.A);
                writer.Write(Star.B);
                writer.Write(Star.CenterX);
                writer.Write(Star.CenterY);

                fStream.Flush();
            }
        }

        protected override void PathSelectionButton_Click(object sender, EventArgs e)
        {
            var saveType = GetSelectedSaveType();

            if (saveType == String.Empty)
                return;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = saveType switch
            {
                "Binary" => "Binary files (*.bin)|*.bin",
                "XML" => "XML files (*.xml)|*.xml",
                _ => string.Empty,
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                PathTextBox.Text = saveFileDialog.FileName;

            Button.Enabled = PathTextBox.Text != string.Empty;
        }

        protected override void Button_Click(object sender, EventArgs e)
        {
            if (PathTextBox.Text == String.Empty)
                return;

            if (BinaryRadioButton.Checked)
                SaveBinary(PathTextBox.Text);
            else if (XMLRadioButton.Checked)
                SaveXML(PathTextBox.Text);

            DialogResult = DialogResult.OK;
        }
    }
}
