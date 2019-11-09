namespace Trigonometry
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
            this.anga = new System.Windows.Forms.Label();
            this.angc = new System.Windows.Forms.Label();
            this.angb = new System.Windows.Forms.Label();
            this.angAtxtBox = new System.Windows.Forms.TextBox();
            this.angCtxtBox = new System.Windows.Forms.TextBox();
            this.angBtxtBox = new System.Windows.Forms.TextBox();
            this.generateRandomButton = new System.Windows.Forms.Button();
            this.showValues = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // anga
            // 
            this.anga.AutoSize = true;
            this.anga.Location = new System.Drawing.Point(95, 56);
            this.anga.Name = "anga";
            this.anga.Size = new System.Drawing.Size(47, 13);
            this.anga.TabIndex = 0;
            this.anga.Text = "Angel A:";
            // 
            // angc
            // 
            this.angc.AutoSize = true;
            this.angc.Location = new System.Drawing.Point(95, 231);
            this.angc.Name = "angc";
            this.angc.Size = new System.Drawing.Size(47, 13);
            this.angc.TabIndex = 1;
            this.angc.Text = "Angel C:";
            // 
            // angb
            // 
            this.angb.AutoSize = true;
            this.angb.Location = new System.Drawing.Point(95, 136);
            this.angb.Name = "angb";
            this.angb.Size = new System.Drawing.Size(47, 13);
            this.angb.TabIndex = 2;
            this.angb.Text = "Angel B:";
            // 
            // angAtxtBox
            // 
            this.angAtxtBox.Location = new System.Drawing.Point(189, 53);
            this.angAtxtBox.Name = "angAtxtBox";
            this.angAtxtBox.Size = new System.Drawing.Size(100, 20);
            this.angAtxtBox.TabIndex = 3;
            // 
            // angCtxtBox
            // 
            this.angCtxtBox.Location = new System.Drawing.Point(189, 228);
            this.angCtxtBox.Name = "angCtxtBox";
            this.angCtxtBox.Size = new System.Drawing.Size(100, 20);
            this.angCtxtBox.TabIndex = 4;
            // 
            // angBtxtBox
            // 
            this.angBtxtBox.Location = new System.Drawing.Point(189, 129);
            this.angBtxtBox.Name = "angBtxtBox";
            this.angBtxtBox.Size = new System.Drawing.Size(100, 20);
            this.angBtxtBox.TabIndex = 5;
            // 
            // generateRandomButton
            // 
            this.generateRandomButton.Location = new System.Drawing.Point(354, 82);
            this.generateRandomButton.Name = "generateRandomButton";
            this.generateRandomButton.Size = new System.Drawing.Size(95, 67);
            this.generateRandomButton.TabIndex = 6;
            this.generateRandomButton.Text = "Generate Random Angles";
            this.generateRandomButton.UseVisualStyleBackColor = true;
            this.generateRandomButton.Click += new System.EventHandler(this.generateRandomNumber_Click);
            // 
            // showValues
            // 
            this.showValues.Location = new System.Drawing.Point(354, 176);
            this.showValues.Name = "showValues";
            this.showValues.Size = new System.Drawing.Size(95, 68);
            this.showValues.TabIndex = 7;
            this.showValues.Text = "Show Trigonometric Values";
            this.showValues.UseVisualStyleBackColor = true;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.resultLabel.Location = new System.Drawing.Point(204, 310);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(55, 20);
            this.resultLabel.TabIndex = 8;
            this.resultLabel.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 425);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.showValues);
            this.Controls.Add(this.generateRandomButton);
            this.Controls.Add(this.angBtxtBox);
            this.Controls.Add(this.angCtxtBox);
            this.Controls.Add(this.angAtxtBox);
            this.Controls.Add(this.angb);
            this.Controls.Add(this.angc);
            this.Controls.Add(this.anga);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label anga;
        private System.Windows.Forms.Label angc;
        private System.Windows.Forms.Label angb;
        private System.Windows.Forms.TextBox angAtxtBox;
        private System.Windows.Forms.TextBox angCtxtBox;
        private System.Windows.Forms.TextBox angBtxtBox;
        private System.Windows.Forms.Button generateRandomButton;
        private System.Windows.Forms.Button showValues;
        private System.Windows.Forms.Label resultLabel;
    }
}

