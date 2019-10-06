namespace WindowsFormsApp1
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
            this.heading = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.number1 = new System.Windows.Forms.TextBox();
            this.addition = new System.Windows.Forms.Button();
            this.subtraction = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.number2 = new System.Windows.Forms.TextBox();
            this.division = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.resultTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // heading
            // 
            this.heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.heading.ForeColor = System.Drawing.SystemColors.ControlText;
            this.heading.Location = new System.Drawing.Point(126, 9);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(347, 45);
            this.heading.TabIndex = 0;
            this.heading.Text = "CENG201-Calculator";
            this.heading.Click += new System.EventHandler(this.Heading_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(56, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number 1";
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(42, 139);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(150, 20);
            this.number1.TabIndex = 2;
            this.number1.TextChanged += new System.EventHandler(this.Number1_TextChanged);
            // 
            // addition
            // 
            this.addition.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addition.Location = new System.Drawing.Point(42, 193);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(150, 30);
            this.addition.TabIndex = 5;
            this.addition.Text = "Addition";
            this.addition.UseVisualStyleBackColor = true;
            this.addition.Click += new System.EventHandler(this.Addition_Click);
            // 
            // subtraction
            // 
            this.subtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.subtraction.Location = new System.Drawing.Point(42, 245);
            this.subtraction.Name = "subtraction";
            this.subtraction.Size = new System.Drawing.Size(150, 30);
            this.subtraction.TabIndex = 5;
            this.subtraction.Text = "Subtraction";
            this.subtraction.UseVisualStyleBackColor = true;
            this.subtraction.Click += new System.EventHandler(this.Subtraction_Click);
            // 
            // multiplication
            // 
            this.multiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.multiplication.Location = new System.Drawing.Point(245, 193);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(150, 30);
            this.multiplication.TabIndex = 5;
            this.multiplication.Text = "Multiplication";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.Multiplication_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(264, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Number 2";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(245, 139);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(150, 20);
            this.number2.TabIndex = 7;
            this.number2.TextChanged += new System.EventHandler(this.Number2_TextChanged);
            // 
            // division
            // 
            this.division.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.division.Location = new System.Drawing.Point(245, 245);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(150, 30);
            this.division.TabIndex = 5;
            this.division.Text = "Division";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.Division_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(479, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Result";
            this.label3.UseMnemonic = false;
            // 
            // resultTxtBox
            // 
            this.resultTxtBox.Enabled = false;
            this.resultTxtBox.Location = new System.Drawing.Point(440, 215);
            this.resultTxtBox.Name = "resultTxtBox";
            this.resultTxtBox.ReadOnly = true;
            this.resultTxtBox.Size = new System.Drawing.Size(150, 20);
            this.resultTxtBox.TabIndex = 10;
            this.resultTxtBox.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 348);
            this.Controls.Add(this.resultTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.division);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.subtraction);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.heading);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label heading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox number1;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button subtraction;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox number2;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox resultTxtBox;
    }
}

