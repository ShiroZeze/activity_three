namespace WindowsFormsApplication3
{
    partial class Form1
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
            this.japanBox = new System.Windows.Forms.CheckBox();
            this.title = new System.Windows.Forms.Label();
            this.question = new System.Windows.Forms.Label();
            this.philippineBox = new System.Windows.Forms.CheckBox();
            this.thailandBox = new System.Windows.Forms.CheckBox();
            this.australiaBox = new System.Windows.Forms.CheckBox();
            this.othersLabel = new System.Windows.Forms.Label();
            this.othersBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // japanBox
            // 
            this.japanBox.AutoSize = true;
            this.japanBox.Location = new System.Drawing.Point(33, 118);
            this.japanBox.Name = "japanBox";
            this.japanBox.Size = new System.Drawing.Size(55, 17);
            this.japanBox.TabIndex = 0;
            this.japanBox.Text = "Japan";
            this.japanBox.UseVisualStyleBackColor = true;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(28, 23);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(86, 29);
            this.title.TabIndex = 1;
            this.title.Text = "Survey";
            // 
            // question
            // 
            this.question.AutoSize = true;
            this.question.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question.Location = new System.Drawing.Point(30, 83);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(261, 20);
            this.question.TabIndex = 2;
            this.question.Text = "What country would you like to visit?";
            // 
            // philippineBox
            // 
            this.philippineBox.AutoSize = true;
            this.philippineBox.Location = new System.Drawing.Point(33, 160);
            this.philippineBox.Name = "philippineBox";
            this.philippineBox.Size = new System.Drawing.Size(76, 17);
            this.philippineBox.TabIndex = 3;
            this.philippineBox.Text = "Philippines";
            this.philippineBox.UseVisualStyleBackColor = true;
            this.philippineBox.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // thailandBox
            // 
            this.thailandBox.AutoSize = true;
            this.thailandBox.Location = new System.Drawing.Point(194, 118);
            this.thailandBox.Name = "thailandBox";
            this.thailandBox.Size = new System.Drawing.Size(67, 17);
            this.thailandBox.TabIndex = 4;
            this.thailandBox.Text = "Thailand";
            this.thailandBox.UseVisualStyleBackColor = true;
            // 
            // australiaBox
            // 
            this.australiaBox.AutoSize = true;
            this.australiaBox.Location = new System.Drawing.Point(194, 160);
            this.australiaBox.Name = "australiaBox";
            this.australiaBox.Size = new System.Drawing.Size(66, 17);
            this.australiaBox.TabIndex = 5;
            this.australiaBox.Text = "Australia";
            this.australiaBox.UseVisualStyleBackColor = true;
            // 
            // othersLabel
            // 
            this.othersLabel.AutoSize = true;
            this.othersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.othersLabel.Location = new System.Drawing.Point(29, 239);
            this.othersLabel.Name = "othersLabel";
            this.othersLabel.Size = new System.Drawing.Size(187, 20);
            this.othersLabel.TabIndex = 6;
            this.othersLabel.Text = "If Others, Please Specify:";
            this.othersLabel.Visible = false;
            // 
            // othersBox
            // 
            this.othersBox.Location = new System.Drawing.Point(33, 279);
            this.othersBox.Name = "othersBox";
            this.othersBox.Size = new System.Drawing.Size(214, 20);
            this.othersBox.TabIndex = 7;
            this.othersBox.Visible = false;
            this.othersBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(125, 334);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 8;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(34, 197);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(57, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Others";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 380);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.othersBox);
            this.Controls.Add(this.othersLabel);
            this.Controls.Add(this.australiaBox);
            this.Controls.Add(this.thailandBox);
            this.Controls.Add(this.philippineBox);
            this.Controls.Add(this.question);
            this.Controls.Add(this.title);
            this.Controls.Add(this.japanBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox japanBox;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label question;
        private System.Windows.Forms.CheckBox philippineBox;
        private System.Windows.Forms.CheckBox thailandBox;
        private System.Windows.Forms.CheckBox australiaBox;
        private System.Windows.Forms.Label othersLabel;
        private System.Windows.Forms.TextBox othersBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

