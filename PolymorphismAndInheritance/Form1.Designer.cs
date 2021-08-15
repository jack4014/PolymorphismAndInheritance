
namespace PolymorphismAndInheritance
{
    partial class GoatVaccTextBox
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
            this.CalculateButton = new System.Windows.Forms.Button();
            this.BrowseFileTextBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ProfitTextBox = new System.Windows.Forms.TextBox();
            this.GoatMilkTextBox = new System.Windows.Forms.TextBox();
            this.CowVaccTextBox = new System.Windows.Forms.TextBox();
            this.BrowseFile = new System.Windows.Forms.Button();
            this.CowMilkTextBox = new System.Windows.Forms.TextBox();
            this.JCowVaccTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(383, 124);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 7;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.buttonCalculateButton_press);
            // 
            // BrowseFileTextBox
            // 
            this.BrowseFileTextBox.Location = new System.Drawing.Point(383, 59);
            this.BrowseFileTextBox.Name = "BrowseFileTextBox";
            this.BrowseFileTextBox.Size = new System.Drawing.Size(272, 20);
            this.BrowseFileTextBox.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(383, 153);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(272, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.TabStop = false;
            // 
            // ProfitTextBox
            // 
            this.ProfitTextBox.Location = new System.Drawing.Point(25, 261);
            this.ProfitTextBox.Name = "ProfitTextBox";
            this.ProfitTextBox.Size = new System.Drawing.Size(156, 20);
            this.ProfitTextBox.TabIndex = 4;
            // 
            // GoatMilkTextBox
            // 
            this.GoatMilkTextBox.Location = new System.Drawing.Point(25, 103);
            this.GoatMilkTextBox.Name = "GoatMilkTextBox";
            this.GoatMilkTextBox.Size = new System.Drawing.Size(156, 20);
            this.GoatMilkTextBox.TabIndex = 1;
            // 
            // CowVaccTextBox
            // 
            this.CowVaccTextBox.Location = new System.Drawing.Point(25, 153);
            this.CowVaccTextBox.Name = "CowVaccTextBox";
            this.CowVaccTextBox.Size = new System.Drawing.Size(156, 20);
            this.CowVaccTextBox.TabIndex = 2;
            // 
            // BrowseFile
            // 
            this.BrowseFile.Location = new System.Drawing.Point(383, 30);
            this.BrowseFile.Name = "BrowseFile";
            this.BrowseFile.Size = new System.Drawing.Size(75, 23);
            this.BrowseFile.TabIndex = 5;
            this.BrowseFile.Text = "Browse File";
            this.BrowseFile.UseVisualStyleBackColor = true;
            this.BrowseFile.Click += new System.EventHandler(this.BrowseFile_Click);
            // 
            // CowMilkTextBox
            // 
            this.CowMilkTextBox.Location = new System.Drawing.Point(25, 59);
            this.CowMilkTextBox.Name = "CowMilkTextBox";
            this.CowMilkTextBox.Size = new System.Drawing.Size(156, 20);
            this.CowMilkTextBox.TabIndex = 0;
            // 
            // JCowVaccTextBox
            // 
            this.JCowVaccTextBox.Location = new System.Drawing.Point(25, 211);
            this.JCowVaccTextBox.Name = "JCowVaccTextBox";
            this.JCowVaccTextBox.Size = new System.Drawing.Size(156, 20);
            this.JCowVaccTextBox.TabIndex = 3;
            // 
            // GoatVaccTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.JCowVaccTextBox);
            this.Controls.Add(this.CowMilkTextBox);
            this.Controls.Add(this.BrowseFile);
            this.Controls.Add(this.CowVaccTextBox);
            this.Controls.Add(this.GoatMilkTextBox);
            this.Controls.Add(this.ProfitTextBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.BrowseFileTextBox);
            this.Controls.Add(this.CalculateButton);
            this.Name = "GoatVaccTextBox";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TextBox BrowseFileTextBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox ProfitTextBox;
        private System.Windows.Forms.TextBox GoatMilkTextBox;
        private System.Windows.Forms.TextBox CowVaccTextBox;
        private System.Windows.Forms.Button BrowseFile;
        private System.Windows.Forms.TextBox CowMilkTextBox;
        private System.Windows.Forms.TextBox JCowVaccTextBox;
    }
}

