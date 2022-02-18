namespace OOP_Labs_C1_T2.Windows.Lab7
{
    partial class Task2Form
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
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ReverseFullNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SmblsCountTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.TextManipulationGroupBox = new System.Windows.Forms.GroupBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LoadedTextTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TextManipulationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(15, 51);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(171, 23);
            this.FullNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your full name";
            // 
            // ReverseFullNameTextBox
            // 
            this.ReverseFullNameTextBox.Location = new System.Drawing.Point(241, 30);
            this.ReverseFullNameTextBox.Name = "ReverseFullNameTextBox";
            this.ReverseFullNameTextBox.Size = new System.Drawing.Size(171, 23);
            this.ReverseFullNameTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your reverse full name";
            // 
            // SmblsCountTextBox
            // 
            this.SmblsCountTextBox.Location = new System.Drawing.Point(241, 88);
            this.SmblsCountTextBox.Name = "SmblsCountTextBox";
            this.SmblsCountTextBox.Size = new System.Drawing.Size(171, 23);
            this.SmblsCountTextBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Full name anount of symbols";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(15, 128);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(87, 28);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // TextManipulationGroupBox
            // 
            this.TextManipulationGroupBox.Controls.Add(this.LoadButton);
            this.TextManipulationGroupBox.Controls.Add(this.SaveButton);
            this.TextManipulationGroupBox.Controls.Add(this.LoadedTextTextBox);
            this.TextManipulationGroupBox.Controls.Add(this.label5);
            this.TextManipulationGroupBox.Controls.Add(this.PathTextBox);
            this.TextManipulationGroupBox.Controls.Add(this.label4);
            this.TextManipulationGroupBox.Location = new System.Drawing.Point(435, 12);
            this.TextManipulationGroupBox.Name = "TextManipulationGroupBox";
            this.TextManipulationGroupBox.Size = new System.Drawing.Size(235, 155);
            this.TextManipulationGroupBox.TabIndex = 3;
            this.TextManipulationGroupBox.TabStop = false;
            this.TextManipulationGroupBox.Text = "Save/load text";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(12, 116);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 28);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(118, 116);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(100, 28);
            this.LoadButton.TabIndex = 2;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // PathTextBox
            // 
            this.PathTextBox.Location = new System.Drawing.Point(13, 83);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(205, 23);
            this.PathTextBox.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Your reverse full name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Loaded text";
            // 
            // LoadedTextTextBox
            // 
            this.LoadedTextTextBox.Location = new System.Drawing.Point(13, 39);
            this.LoadedTextTextBox.Name = "LoadedTextTextBox";
            this.LoadedTextTextBox.ReadOnly = true;
            this.LoadedTextTextBox.Size = new System.Drawing.Size(205, 23);
            this.LoadedTextTextBox.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(15, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 39);
            this.label6.TabIndex = 1;
            this.label6.Text = "For reversing your text and evaluate amount of symbols press OK\r\n";
            // 
            // Task2Form
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 180);
            this.Controls.Add(this.TextManipulationGroupBox);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SmblsCountTextBox);
            this.Controls.Add(this.ReverseFullNameTextBox);
            this.Controls.Add(this.FullNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Task2Form";
            this.Text = "Task 2";
            this.TextManipulationGroupBox.ResumeLayout(false);
            this.TextManipulationGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox FullNameTextBox;
        private Label label1;
        private TextBox ReverseFullNameTextBox;
        private Label label2;
        private TextBox SmblsCountTextBox;
        private Label label3;
        private Button OKButton;
        private GroupBox TextManipulationGroupBox;
        private Button LoadButton;
        private Button SaveButton;
        private TextBox LoadedTextTextBox;
        private Label label5;
        private TextBox PathTextBox;
        private Label label4;
        private Label label6;
    }
}