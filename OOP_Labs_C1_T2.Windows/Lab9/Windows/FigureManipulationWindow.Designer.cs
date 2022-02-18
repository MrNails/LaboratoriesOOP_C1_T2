namespace OOP_Labs_C1_T2.Windows.Lab9.Windows
{
    partial class FigureManipulationWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BinaryRadioButton = new System.Windows.Forms.RadioButton();
            this.XMLRadioButton = new System.Windows.Forms.RadioButton();
            this.Button = new System.Windows.Forms.Button();
            this.StarTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.PathSelectionButton = new System.Windows.Forms.Button();
            this.StarTypeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BinaryRadioButton
            // 
            this.BinaryRadioButton.AutoSize = true;
            this.BinaryRadioButton.Checked = true;
            this.BinaryRadioButton.Location = new System.Drawing.Point(11, 23);
            this.BinaryRadioButton.Name = "BinaryRadioButton";
            this.BinaryRadioButton.Size = new System.Drawing.Size(58, 19);
            this.BinaryRadioButton.TabIndex = 0;
            this.BinaryRadioButton.TabStop = true;
            this.BinaryRadioButton.Text = "Binary";
            this.BinaryRadioButton.UseVisualStyleBackColor = true;
            // 
            // XMLRadioButton
            // 
            this.XMLRadioButton.AutoSize = true;
            this.XMLRadioButton.Location = new System.Drawing.Point(11, 48);
            this.XMLRadioButton.Name = "XMLRadioButton";
            this.XMLRadioButton.Size = new System.Drawing.Size(49, 19);
            this.XMLRadioButton.TabIndex = 0;
            this.XMLRadioButton.TabStop = true;
            this.XMLRadioButton.Text = "XML";
            this.XMLRadioButton.UseVisualStyleBackColor = true;
            // 
            // Button
            // 
            this.Button.Enabled = false;
            this.Button.Location = new System.Drawing.Point(125, 115);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(142, 23);
            this.Button.TabIndex = 1;
            this.Button.Text = "Save";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // StarTypeGroupBox
            // 
            this.StarTypeGroupBox.Controls.Add(this.XMLRadioButton);
            this.StarTypeGroupBox.Controls.Add(this.BinaryRadioButton);
            this.StarTypeGroupBox.Location = new System.Drawing.Point(12, 12);
            this.StarTypeGroupBox.Name = "StarTypeGroupBox";
            this.StarTypeGroupBox.Size = new System.Drawing.Size(142, 80);
            this.StarTypeGroupBox.TabIndex = 3;
            this.StarTypeGroupBox.TabStop = false;
            this.StarTypeGroupBox.Text = "Save as";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Path";
            // 
            // PathTextBox
            // 
            this.PathTextBox.Location = new System.Drawing.Point(181, 31);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.ReadOnly = true;
            this.PathTextBox.Size = new System.Drawing.Size(152, 23);
            this.PathTextBox.TabIndex = 5;
            // 
            // PathSelectionButton
            // 
            this.PathSelectionButton.Location = new System.Drawing.Point(333, 30);
            this.PathSelectionButton.Name = "PathSelectionButton";
            this.PathSelectionButton.Size = new System.Drawing.Size(32, 25);
            this.PathSelectionButton.TabIndex = 1;
            this.PathSelectionButton.Text = "...";
            this.PathSelectionButton.UseVisualStyleBackColor = true;
            this.PathSelectionButton.Click += new System.EventHandler(this.PathSelectionButton_Click);
            // 
            // FigureManipulationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 151);
            this.Controls.Add(this.PathTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StarTypeGroupBox);
            this.Controls.Add(this.PathSelectionButton);
            this.Controls.Add(this.Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FigureManipulationWindow";
            this.Text = "Figure save window";
            this.StarTypeGroupBox.ResumeLayout(false);
            this.StarTypeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        protected RadioButton BinaryRadioButton;
        protected RadioButton XMLRadioButton;
        protected Button Button;
        protected GroupBox StarTypeGroupBox;
        protected TextBox PathTextBox;
        protected Button PathSelectionButton;
    }
}