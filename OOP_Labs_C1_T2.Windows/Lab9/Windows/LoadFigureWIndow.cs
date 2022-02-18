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
    internal partial class LoadFigureWIndow : FigureManipulationWindow
    {
        public LoadFigureWIndow() : this(Star.EmptyStar) { }

        public LoadFigureWIndow(Star star) : base(star)
        {
            InitializeComponent();

            Button.Text = "Load";
            StarTypeGroupBox.Text = "Load as";
            Text = "Figure load window";
        }

        private void LoadXML(string path)
        {
            XmlSerializer ser = new XmlSerializer(typeof(Star));

            using (var fStream = new FileStream(path, FileMode.Open))
            {
                Star = (Star)ser.Deserialize(fStream);
            }
        }

        private void LoadBinary(string path)
        {
            using (var fStream = new FileStream(path, FileMode.Open))
            {
                BinaryReader reader = new BinaryReader(fStream);

                var a = reader.ReadInt32();
                var b = reader.ReadInt32();
                var centerX = reader.ReadInt32();
                var centeY = reader.ReadInt32();

                Star = new Star(a, b, centerX, centeY);
            }
        }

        protected override void PathSelectionButton_Click(object sender, EventArgs e)
        {
            var saveType = GetSelectedSaveType();

            if (saveType == String.Empty)
                return;

            OpenFileDialog saveFileDialog = new OpenFileDialog();
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
                LoadBinary(PathTextBox.Text);
            else if (XMLRadioButton.Checked)
                LoadXML(PathTextBox.Text);

            DialogResult = DialogResult.OK;
        }
    }
}
