namespace OOP_Labs_C1_T2.Windows.Lab9
{
    partial class MainForm
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
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DrawingFieldPanel = new System.Windows.Forms.Panel();
            this.FigureInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.ATextBox = new System.Windows.Forms.TextBox();
            this.BTextBox = new System.Windows.Forms.TextBox();
            this.CenterXTextBox = new System.Windows.Forms.TextBox();
            this.CenterYTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DrawButton = new System.Windows.Forms.Button();
            this.MainMenuStrip.SuspendLayout();
            this.FigureInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(584, 24);
            this.MainMenuStrip.TabIndex = 3;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveAsToolStripMenuItem,
            this.LoadAsToolStripMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileMenuItem.Text = "File";
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.SaveAsToolStripMenuItem.Text = "Save as";
            this.SaveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // LoadAsToolStripMenuItem
            // 
            this.LoadAsToolStripMenuItem.Name = "LoadAsToolStripMenuItem";
            this.LoadAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.LoadAsToolStripMenuItem.Text = "Load as";
            this.LoadAsToolStripMenuItem.Click += new System.EventHandler(this.LoadAsToolStripMenuItem_Click);
            // 
            // DrawingFieldPanel
            // 
            this.DrawingFieldPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrawingFieldPanel.Location = new System.Drawing.Point(0, 24);
            this.DrawingFieldPanel.Name = "DrawingFieldPanel";
            this.DrawingFieldPanel.Size = new System.Drawing.Size(584, 167);
            this.DrawingFieldPanel.TabIndex = 4;
            // 
            // FigureInfoGroupBox
            // 
            this.FigureInfoGroupBox.Controls.Add(this.ATextBox);
            this.FigureInfoGroupBox.Controls.Add(this.BTextBox);
            this.FigureInfoGroupBox.Controls.Add(this.CenterXTextBox);
            this.FigureInfoGroupBox.Controls.Add(this.CenterYTextBox);
            this.FigureInfoGroupBox.Controls.Add(this.label4);
            this.FigureInfoGroupBox.Controls.Add(this.label3);
            this.FigureInfoGroupBox.Controls.Add(this.label2);
            this.FigureInfoGroupBox.Controls.Add(this.label1);
            this.FigureInfoGroupBox.Controls.Add(this.DrawButton);
            this.FigureInfoGroupBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.FigureInfoGroupBox.Location = new System.Drawing.Point(366, 24);
            this.FigureInfoGroupBox.Name = "FigureInfoGroupBox";
            this.FigureInfoGroupBox.Size = new System.Drawing.Size(218, 167);
            this.FigureInfoGroupBox.TabIndex = 5;
            this.FigureInfoGroupBox.TabStop = false;
            this.FigureInfoGroupBox.Text = "Figure information";
            // 
            // ATextBox
            // 
            this.ATextBox.Location = new System.Drawing.Point(21, 47);
            this.ATextBox.Name = "ATextBox";
            this.ATextBox.Size = new System.Drawing.Size(80, 23);
            this.ATextBox.TabIndex = 2;
            this.ATextBox.Tag = "A";
            this.ATextBox.Text = "0";
            // 
            // BTextBox
            // 
            this.BTextBox.Location = new System.Drawing.Point(116, 47);
            this.BTextBox.Name = "BTextBox";
            this.BTextBox.Size = new System.Drawing.Size(80, 23);
            this.BTextBox.TabIndex = 2;
            this.BTextBox.Tag = "B";
            this.BTextBox.Text = "0";
            // 
            // CenterXTextBox
            // 
            this.CenterXTextBox.Location = new System.Drawing.Point(22, 102);
            this.CenterXTextBox.Name = "CenterXTextBox";
            this.CenterXTextBox.Size = new System.Drawing.Size(79, 23);
            this.CenterXTextBox.TabIndex = 2;
            this.CenterXTextBox.Tag = "Center x";
            this.CenterXTextBox.Text = "0";
            // 
            // CenterYTextBox
            // 
            this.CenterYTextBox.Location = new System.Drawing.Point(117, 102);
            this.CenterYTextBox.Name = "CenterYTextBox";
            this.CenterYTextBox.Size = new System.Drawing.Size(79, 23);
            this.CenterYTextBox.TabIndex = 2;
            this.CenterYTextBox.Tag = "Center y";
            this.CenterYTextBox.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Center y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Center x";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "A";
            // 
            // DrawButton
            // 
            this.DrawButton.Location = new System.Drawing.Point(22, 139);
            this.DrawButton.Name = "DrawButton";
            this.DrawButton.Size = new System.Drawing.Size(174, 22);
            this.DrawButton.TabIndex = 0;
            this.DrawButton.Text = "Draw";
            this.DrawButton.UseVisualStyleBackColor = true;
            this.DrawButton.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 191);
            this.Controls.Add(this.FigureInfoGroupBox);
            this.Controls.Add(this.DrawingFieldPanel);
            this.Controls.Add(this.MainMenuStrip);
            this.MinimumSize = new System.Drawing.Size(600, 230);
            this.Name = "MainForm";
            this.Text = "MainForm Lab9";
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.FigureInfoGroupBox.ResumeLayout(false);
            this.FigureInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip MainMenuStrip;
        private Panel DrawingFieldPanel;
        private GroupBox FigureInfoGroupBox;
        private TextBox ATextBox;
        private TextBox BTextBox;
        private TextBox CenterXTextBox;
        private TextBox CenterYTextBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button DrawButton;
        private ToolStripMenuItem FileMenuItem;
        private ToolStripMenuItem SaveAsToolStripMenuItem;
        private ToolStripMenuItem LoadAsToolStripMenuItem;
    }
}