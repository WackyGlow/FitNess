﻿namespace FitnessUserApp
{
    partial class FitnessApp
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
            this.fNameField = new System.Windows.Forms.TextBox();
            this.TitleLable = new System.Windows.Forms.Label();
            this.lNameField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.HeightField = new System.Windows.Forms.TextBox();
            this.shreksField = new System.Windows.Forms.TextBox();
            this.ageField = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.wLossPerWeekField = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.desWeightField = new System.Windows.Forms.TextBox();
            this.weightField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fNameField
            // 
            this.fNameField.Location = new System.Drawing.Point(4, 23);
            this.fNameField.Name = "fNameField";
            this.fNameField.Size = new System.Drawing.Size(190, 22);
            this.fNameField.TabIndex = 1;
            this.fNameField.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TitleLable
            // 
            this.TitleLable.AutoSize = true;
            this.TitleLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TitleLable.Location = new System.Drawing.Point(-2, 9);
            this.TitleLable.Name = "TitleLable";
            this.TitleLable.Size = new System.Drawing.Size(386, 51);
            this.TitleLable.TabIndex = 2;
            this.TitleLable.Text = "Fitness Calculator";
            this.TitleLable.Click += new System.EventHandler(this.label1_Click);
            // 
            // lNameField
            // 
            this.lNameField.Location = new System.Drawing.Point(204, 23);
            this.lNameField.Name = "lNameField";
            this.lNameField.Size = new System.Drawing.Size(190, 22);
            this.lNameField.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(204, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-17, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(476, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "___________________________________________________________________";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(417, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 421);
            this.panel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Results:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.HeightField);
            this.panel2.Controls.Add(this.shreksField);
            this.panel2.Controls.Add(this.ageField);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.wLossPerWeekField);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.desWeightField);
            this.panel2.Controls.Add(this.weightField);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.fNameField);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lNameField);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(7, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(404, 421);
            this.panel2.TabIndex = 8;
            // 
            // HeightField
            // 
            this.HeightField.Location = new System.Drawing.Point(4, 195);
            this.HeightField.Name = "HeightField";
            this.HeightField.Size = new System.Drawing.Size(190, 22);
            this.HeightField.TabIndex = 19;
            // 
            // shreksField
            // 
            this.shreksField.Location = new System.Drawing.Point(204, 75);
            this.shreksField.Name = "shreksField";
            this.shreksField.Size = new System.Drawing.Size(190, 22);
            this.shreksField.TabIndex = 18;
            this.shreksField.Text = "Yes please!";
            // 
            // ageField
            // 
            this.ageField.Location = new System.Drawing.Point(3, 75);
            this.ageField.Name = "ageField";
            this.ageField.Size = new System.Drawing.Size(191, 22);
            this.ageField.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "Height";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(207, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Sex";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Age";
            // 
            // wLossPerWeekField
            // 
            this.wLossPerWeekField.Location = new System.Drawing.Point(207, 194);
            this.wLossPerWeekField.Name = "wLossPerWeekField";
            this.wLossPerWeekField.Size = new System.Drawing.Size(187, 22);
            this.wLossPerWeekField.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(204, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Weight Loss Per Week";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-36, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(476, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "___________________________________________________________________";
            // 
            // desWeightField
            // 
            this.desWeightField.Location = new System.Drawing.Point(207, 144);
            this.desWeightField.Name = "desWeightField";
            this.desWeightField.Size = new System.Drawing.Size(187, 22);
            this.desWeightField.TabIndex = 10;
            // 
            // weightField
            // 
            this.weightField.Location = new System.Drawing.Point(4, 144);
            this.weightField.Name = "weightField";
            this.weightField.Size = new System.Drawing.Size(190, 22);
            this.weightField.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(204, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Desired Weight";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Weight";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(86, 161);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(263, 29);
            this.label12.TabIndex = 1;
            this.label12.Text = "<<Some Results....>>";
            // 
            // FitnessApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(828, 521);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TitleLable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FitnessApp";
            this.Text = "Fitness Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox fNameField;
        private System.Windows.Forms.Label TitleLable;
        private System.Windows.Forms.TextBox lNameField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox wLossPerWeekField;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox desWeightField;
        private System.Windows.Forms.TextBox weightField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox HeightField;
        private System.Windows.Forms.TextBox shreksField;
        private System.Windows.Forms.TextBox ageField;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
    }
}

